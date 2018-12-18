using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32.SafeHandles;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Management;

namespace secret_tool_v1
{
	public static class uniqueidgen
	{
		public static string getCpuData()
		{
			string ret = "";

			ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			foreach (ManagementObject MO in MOS.Get())
			{
				ret +=   ("Processor Details");
				ret +=   ("===============================================================");
				ret +=   ("AddressWidth: "				.PadRight(30)	+	MO["AddressWidth"]				+ "\r\n");
				ret +=   ("Architecture: "				.PadRight(30)	+	MO["Architecture"]				+ "\r\n");
				ret +=   ("Availability: "				.PadRight(30)	+	MO["Availability"]				+ "\r\n");
				ret +=   ("Caption: "					.PadRight(30)	+	MO["Caption"]					+ "\r\n");
				ret +=   ("ConfigManagerErrorCode: "	.PadRight(30)	+	MO["ConfigManagerErrorCode"]	+ "\r\n");
				ret +=   ("ConfigManagerUserConfig: "	.PadRight(30)	+	MO["ConfigManagerUserConfig"]	+ "\r\n");
				ret +=   ("CpuStatus: "					.PadRight(30)	+	MO["CpuStatus"]					+ "\r\n");
				ret +=   ("CreationClassName: "			.PadRight(30)	+	MO["CreationClassName"]			+ "\r\n");
				ret +=   ("CurrentClockSpeed: "			.PadRight(30)	+	MO["CurrentClockSpeed"]			+ "\r\n");
				ret +=   ("CurrentVoltage: "			.PadRight(30)	+	MO["CurrentVoltage"]			+ "\r\n");
				ret +=   ("DataWidth: "					.PadRight(30)	+	MO["DataWidth"]					+ "\r\n");
				ret +=   ("Description: "				.PadRight(30)	+	MO["Description"]				+ "\r\n");
				ret +=   ("DeviceID: "					.PadRight(30)	+	MO["DeviceID"]					+ "\r\n");
				ret +=   ("ErrorCleared: "				.PadRight(30)	+	MO["ErrorCleared"]				+ "\r\n");
				ret +=   ("InstallDate: "				.PadRight(30)	+	MO["InstallDate"]				+ "\r\n");
				ret +=   ("LoadPercentage: "			.PadRight(30)	+	MO["LoadPercentage"]			+ "\r\n");
				ret +=   ("Name: "						.PadRight(30)	+	MO["Name"]						+ "\r\n");
				ret +=   ("NumberOfCores: "				.PadRight(30)	+	MO["NumberOfCores"]				+ "\r\n");
				ret +=   ("NumberOfLogicalProcessors: "	.PadRight(30)	+	MO["NumberOfLogicalProcessors"]	+ "\r\n");
				ret +=   ("ProcessorID: "				.PadRight(30)	+	MO["ProcessorID"]				+ "\r\n");
				ret +=   ("ProcessorType: "				.PadRight(30)	+	MO["ProcessorType"]				+ "\r\n");
				ret +=   ("OtherFamilyDescription: "	.PadRight(30)	+	MO["OtherFamilyDescription"]	+ "\r\n");
				ret +=   ("PNPDeviceID: "				.PadRight(30)	+	MO["PNPDeviceID"]				+ "\r\n");
				ret +=   ("PowerManagementSupported: "	.PadRight(30)	+	MO["PowerManagementSupported"]	+ "\r\n");
				ret +=   ("Revision: "					.PadRight(30)	+	MO["Revision"]					+ "\r\n");
				ret +=   ("Role: "						.PadRight(30)	+	MO["Role"]						+ "\r\n");
				ret +=   ("SocketDesignation: "			.PadRight(30)	+	MO["SocketDesignation"]			+ "\r\n");
				ret +=   ("Status: "					.PadRight(30)	+	MO["Status"]					+ "\r\n");
				ret +=   ("StatusInfo: "				.PadRight(30)	+	MO["StatusInfo"]				+ "\r\n");
				ret +=   ("Stepping: "					.PadRight(30)	+	MO["Stepping"]					+ "\r\n");
				ret +=   ("SystemCreationClassName: "	.PadRight(30)	+	MO["SystemCreationClassName"]	+ "\r\n");
				ret +=   ("SystemName: "				.PadRight(30)	+	MO["SystemName"]				+ "\r\n");
				ret +=   ("UniqueId: "					.PadRight(30)	+	MO["UniqueId"]					+ "\r\n");
				ret +=   ("UpgradeMethod: "				.PadRight(30)	+	MO["UpgradeMethod"]				+ "\r\n");
				ret +=   ("Version: "					.PadRight(30)	+	MO["Version"]					+ "\r\n");
				ret +=   ("VoltageCaps: "				.PadRight(30)	+	MO["VoltageCaps"]				+ "\r\n");
			}
			
			return ret;
		}

		public static string[] getCpuId()
		{
			string[] ret = new string[3];
			ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT SystemName, NumberOfCores, NumberOfLogicalProcessors, ProcessorID, Revision FROM Win32_Processor");
			ManagementObject[] moc = new ManagementObject[1];
			MOS.Get().CopyTo(moc, 0);
			ManagementObject MO = moc[0];
			ret[0] =	MO["SystemName"]				+ "." + 
						MO["NumberOfCores"]				+ "." + 
						MO["NumberOfLogicalProcessors"] + "." + 
						MO["ProcessorID"]				+ "." + 
						MO["Revision"];
			ret[1] =	MO["SystemName"]				+ "." + 
						MO["NumberOfCores"];
			ret[2] =	MO["ProcessorID"]				+ "." + 
						MO["Revision"];

			return ret;
		}

		public static string getMacAddress()
		{
			string ret = "";





			return ret;
		}

		public static string getHddId()
		{
			string ret = "";





			return ret;
		}

	}
	
}
