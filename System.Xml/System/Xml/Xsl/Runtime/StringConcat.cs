using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Xml.Xsl.Runtime
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct StringConcat
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x4FE6C50", Offset = "0x4FE5850", VA = "0x184FE6C50")]
		public void Clear()
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x170001F0")]
		internal int Count
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x4FE6E00", Offset = "0x4FE5A00", VA = "0x184FE6E00")]
		public string GetResult()
		{
			return null;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x4FE6C70", Offset = "0x4FE5870", VA = "0x184FE6C70")]
		internal void ConcatNoDelimiter(string s)
		{
		}

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x0")]
		private string s1;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x8")]
		private string s2;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x10")]
		private string s3;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x18")]
		private string s4;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x20")]
		private string delimiter;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x28")]
		private List<string> strList;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x30")]
		private int idxStr;
	}
}
