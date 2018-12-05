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
	}

	public partial class NativeMethods
	{

		///Return Type:				HANDLE					->	void*
		///lpFileName:				LPCWSTR					->	WCHAR*
		///dwDesiredAccess:			DWORD					->	unsigned int
		///dwShareMode:				DWORD					->	unsigned int
		///lpSecurityAttributes:	LPSECURITY_ATTRIBUTES	->	_SECURITY_ATTRIBUTES*
		///dwCreationDisposition:	DWORD					->	unsigned int
		///dwFlagsAndAttributes:	DWORD					->	unsigned int
		///hTemplateFile:			HANDLE					->	void*
		[DllImportAttribute("kernel32.dll", EntryPoint = "CreateFileW")]
		public static extern System.IntPtr CreateFileW(
			[InAttribute()] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpFileName,
			uint dwDesiredAccess,
			uint dwShareMode,
			[InAttribute()] System.IntPtr lpSecurityAttributes,
			uint dwCreationDisposition,
			uint dwFlagsAndAttributes,
			[InAttribute()] System.IntPtr hTemplateFile
		);

	}
	
	public partial class NativeConstants
	{

		/// GENERIC_WRITE -> (0x40000000L)
		public const int GENERIC_WRITE = 1073741824;

		/// FILE_SHARE_DELETE -> 0x00000004
		public const int FILE_SHARE_DELETE = 4;

		/// FILE_SHARE_WRITE -> 0x00000002
		public const int FILE_SHARE_WRITE = 2;

		/// FILE_SHARE_READ -> 0x00000001
		public const int FILE_SHARE_READ = 1;

		/// CREATE_ALWAYS -> 2
		public const int CREATE_ALWAYS = 2;

		/// OPEN_ALWAYS -> 4
		public const int OPEN_ALWAYS = 4;
	}
}
