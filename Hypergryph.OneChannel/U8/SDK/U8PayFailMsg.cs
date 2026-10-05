using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public struct U8PayFailMsg
	{
		// Token: 0x060001FB RID: 507 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4A21FF0", Offset = "0x4A20BF0", VA = "0x184A21FF0")]
		public static U8PayFailMsg FromJson(string jsonStr)
		{
			return default(U8PayFailMsg);
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x0")]
		public static U8PayFailMsg EMPTY;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		public PayFailStatus status;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x8")]
		public string message;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x10")]
		public string extension;
	}
}
