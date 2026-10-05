using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public static class Util
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1040000", Offset = "0x103EC00", VA = "0x181040000")]
		public static bool ValidatePhoneNumber(string phoneNumber)
		{
			return default(bool);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x103FF40", Offset = "0x103EB40", VA = "0x18103FF40")]
		public static string FormatErrorMessage(ResultCode resultCode, string error, [Optional] string url)
		{
			return null;
		}

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex PHONE_NUMBER_LOOSE_REGEX;
	}
}
