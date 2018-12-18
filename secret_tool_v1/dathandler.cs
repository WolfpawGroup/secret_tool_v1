using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace secret_tool_v1
{
	class dathandler
	{
		/// <summary>
		/// Opens data.dat file and gets the bytes inside it
		/// </summary>
		/// <returns>byte[] data.dat content</returns>
		public byte[] readDat()
		{
			if (File.Exists("data.dat"))
			{
				return File.ReadAllBytes("data.dat");
			}
			else { return null; }
		}

		/// <summary>
		/// Creates data.dat file is non existant
		/// Stores data in dat file in encrypted form
		/// </summary>
		/// <param name="s">String containing encrypted data</param>
		public void writeDat(string s)
		{
			byte[] bb = Encoding.UTF8.GetBytes(s);
			using (FileStream f = new FileStream("data.dat",FileMode.Create))
			{
				foreach(byte b in bb) { f.WriteByte(b); }
			}
		}

		public string encryptDat(dat d)
		{
			string ret = "";



			return ret;
		}

		public dat decryptDat(string s)
		{
			dat d = new dat();



			return d;
		}

		public dat get()
		{
			dat d = new dat();



			return d;
		}

		public void set(string s)
		{

		}

		public string genDatEncKey()
		{
			System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			string[] ret = uniqueidgen.getCpuId();
			string key1 = "DATKEY1." + ret[0];
			string key2 = addseparators(ret[0]).Substring(0,64);
			string key3 = "";
			byte[] md51 = md5.ComputeHash(Encoding.ASCII.GetBytes(ret[1]));
			byte[] md52 = md5.ComputeHash(Encoding.ASCII.GetBytes(ret[2]));
			string mask1_s = "";
			string mask2_s = "";
			string mask_b = "";

			foreach (byte b in md51) { mask1_s += b.ToString("X2"); }
			foreach (byte b in md52) { mask2_s += b.ToString("X2"); }

			foreach(byte c in mask1_s) { if (c > 52) { mask_b += "1"; } else { mask_b += "0"; } }
			foreach(byte c in mask2_s) { if (c > 54) { mask_b += "1"; } else { mask_b += "0"; } }

			for(int i = 0; i < key2.Length; i++)
			{
				if(mask_b.Length >= i)
				{
					if(mask_b[i] == '1')
					{
						key3 += key2[i];
					}
				}
			}
			
			return key3;
		}

		public string addseparators(string s)
		{
			s += "====================";
			string ret = "";
			foreach (char c in s)
			{
				ret += c;
				if(c < 50) { ret += "."; }
				else if(c < 52) { ret += "."; }
				else if(c < 54) { ret += "|"; }
				else if(c < 56) { ret += "*"; }
				else if(c < 57) { ret += "x"; }
				else if(c < 66) { ret += "?"; }
				else if(c < 68) { ret += "-"; }
				else if(c < 70) { ret += "_"; }
				else if(c == 70) { ret += "$"; }
			}
			return ret;
		}
	}

	
}
