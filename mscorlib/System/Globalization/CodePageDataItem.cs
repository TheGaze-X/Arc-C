using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	[System.Serializable]
	internal class CodePageDataItem
	{
		// Token: 0x06002ABA RID: 10938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x4C45D40", Offset = "0x4C44940", VA = "0x184C45D40")]
		internal CodePageDataItem(int dataIndex)
		{
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x4C45C00", Offset = "0x4C44800", VA = "0x184C45C00")]
		internal static string CreateString(string pStrings, uint index)
		{
			return null;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700067E")]
		public string WebName
		{
			[Token(Token = "0x6002ABC")]
			[Address(RVA = "0x4C45ED0", Offset = "0x4C44AD0", VA = "0x184C45ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700067F")]
		public string HeaderName
		{
			[Token(Token = "0x6002ABD")]
			[Address(RVA = "0x4C45E00", Offset = "0x4C44A00", VA = "0x184C45E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x10")]
		internal int m_dataIndex;

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x14")]
		internal int m_uiFamilyCodePage;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x18")]
		internal string m_webName;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x20")]
		internal string m_headerName;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x28")]
		internal string m_bodyName;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x30")]
		internal uint m_flags;

		// Token: 0x040018C3 RID: 6339
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] sep;
	}
}
