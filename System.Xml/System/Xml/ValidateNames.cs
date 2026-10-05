using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	internal static class ValidateNames
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x4FEB2D0", Offset = "0x4FE9ED0", VA = "0x184FEB2D0")]
		internal static int ParseNmtoken(string s, int offset)
		{
			return 0;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x4FEB200", Offset = "0x4FE9E00", VA = "0x184FEB200")]
		internal static int ParseNmtokenNoNamespaces(string s, int offset)
		{
			return 0;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x4FEB0B0", Offset = "0x4FE9CB0", VA = "0x184FEB0B0")]
		internal static int ParseNameNoNamespaces(string s, int offset)
		{
			return 0;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x4FEAF90", Offset = "0x4FE9B90", VA = "0x184FEAF90")]
		internal static int ParseNCName(string s, int offset)
		{
			return 0;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x4FEAF40", Offset = "0x4FE9B40", VA = "0x184FEAF40")]
		internal static int ParseNCName(string s)
		{
			return 0;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x4FEB530", Offset = "0x4FEA130", VA = "0x184FEB530")]
		internal static int ParseQName(string s, int offset, out int colonOffset)
		{
			return 0;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x4FEB390", Offset = "0x4FE9F90", VA = "0x184FEB390")]
		internal static void ParseQNameThrow(string s, out string prefix, out string localName)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x4FEB610", Offset = "0x4FEA210", VA = "0x184FEB610")]
		internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x4FEACC0", Offset = "0x4FE98C0", VA = "0x184FEACC0")]
		internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
		{
			return null;
		}

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x0")]
		private static XmlCharType xmlCharType;
	}
}
