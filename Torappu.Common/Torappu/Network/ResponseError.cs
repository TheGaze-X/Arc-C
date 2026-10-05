using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	public struct ResponseError
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x000085AC File Offset: 0x000067AC
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x6144B0", Offset = "0x6130B0", VA = "0x1806144B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x0")]
		public int statusCode;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x8")]
		public string error;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x10")]
		public string message;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x18")]
		public long code;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x24")]
		public ResponseStatus errorStatus;
	}
}
