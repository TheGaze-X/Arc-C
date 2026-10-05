using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public struct U8PayResult
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4A223B0", Offset = "0x4A20FB0", VA = "0x184A223B0")]
		public static U8PayResult FromJson(string jsonData)
		{
			return default(U8PayResult);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4A22660", Offset = "0x4A21260", VA = "0x184A22660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x0")]
		public static readonly U8PayResult EMPTY;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x0")]
		public PayResultStatus status;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x8")]
		public string outTradeNo;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x10")]
		public string extension;
	}
}
