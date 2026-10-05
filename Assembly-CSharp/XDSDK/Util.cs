using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public static class Util
	{
		// Token: 0x06000314 RID: 788 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x514ED0", Offset = "0x513AD0", VA = "0x180514ED0")]
		public static bool ValidatePhoneNumber(string phoneNumber)
		{
			return default(bool);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x514E10", Offset = "0x513A10", VA = "0x180514E10")]
		public static string FormatErrorMessage(ResultCode resultCode, string error, [Optional] string url)
		{
			return null;
		}

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex PHONE_NUMBER_LOOSE_REGEX;
	}
}
