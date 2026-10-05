using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public class SystemUtils
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x5C31B90", Offset = "0x5C30790", VA = "0x185C31B90")]
		public static string GetDeviceModel()
		{
			return null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x5C31880", Offset = "0x5C30480", VA = "0x185C31880")]
		public static string GetDeviceIDByToken(string token)
		{
			return null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x5C312C0", Offset = "0x5C2FEC0", VA = "0x185C312C0")]
		private static string FindDeviceIdByToken(List<string> historyItems, string token)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x5C31B10", Offset = "0x5C30710", VA = "0x185C31B10")]
		private static string GetDeviceIdMD5(string deviceID)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x5C31A70", Offset = "0x5C30670", VA = "0x185C31A70")]
		public static string GetDeviceIdBySystem()
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x5C31A80", Offset = "0x5C30680", VA = "0x185C31A80")]
		public static string GetDeviceIdInRegistry()
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x5C31F00", Offset = "0x5C30B00", VA = "0x185C31F00")]
		public static void StoreDeviceIDToRegistry(string deviceId)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x5C31650", Offset = "0x5C30250", VA = "0x185C31650")]
		public static string GetCustomDeviceId()
		{
			return null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x5C31100", Offset = "0x5C2FD00", VA = "0x185C31100")]
		private static string CreateRandomDeviceId(string time)
		{
			return null;
		}

		// Token: 0x060004FB RID: 1275
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x5C31580", Offset = "0x5C30180", VA = "0x185C31580")]
		[PreserveSig]
		private static extern bool GetComputerNameEx(SystemUtils.COMPUTER_NAME_FORMAT NameType, StringBuilder lpBuffer, ref uint nSize);

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x5C31D60", Offset = "0x5C30960", VA = "0x185C31D60")]
		private static string GetFullComputerName()
		{
			return null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SystemUtils()
		{
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		private const string RandomChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		private enum COMPUTER_NAME_FORMAT
		{
			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			ComputerNameNetBIOS,
			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			ComputerNameDnsHostname,
			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			ComputerNameDnsDomain,
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			ComputerNameDnsFullyQualified,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			ComputerNamePhysicalNetBIOS,
			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			ComputerNamePhysicalDnsHostname,
			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			ComputerNamePhysicalDnsDomain,
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			ComputerNamePhysicalDnsFullyQualified,
			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			ComputerNameMax
		}
	}
}
