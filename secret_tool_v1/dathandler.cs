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
			string key = "DATKEY";
			var proc = System.Diagnostics.Process.GetCurrentProcess();
			key += "";

			return "";
		}
	}

	
}
