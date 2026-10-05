using System;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class StringDedupEntry
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static string _NoDedup(string s)
		{
			return null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x3437180", Offset = "0x3435D80", VA = "0x183437180")]
		public string Dedup(string s)
		{
			return null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x544E330", Offset = "0x544CF30", VA = "0x18544E330")]
		public void SetStrDedup(Func<string, string> func)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x544E2B0", Offset = "0x544CEB0", VA = "0x18544E2B0")]
		public void SetNoDedup()
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x544E3C0", Offset = "0x544CFC0", VA = "0x18544E3C0")]
		public StringDedupEntry()
		{
		}

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x10")]
		private Func<string, string> m_funcDedup;
	}
}
