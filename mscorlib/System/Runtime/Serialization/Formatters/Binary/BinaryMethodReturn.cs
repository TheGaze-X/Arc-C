using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	internal sealed class BinaryMethodReturn
	{
		// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209E")]
		[Address(RVA = "0x1D66F70", Offset = "0x1D65B70", VA = "0x181D66F70")]
		internal BinaryMethodReturn()
		{
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209F")]
		[Address(RVA = "0x4B95BE0", Offset = "0x4B947E0", VA = "0x184B95BE0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x10")]
		private object returnValue;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x18")]
		private object[] args;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x20")]
		private object callContext;

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x28")]
		private System.Type[] argTypes;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x30")]
		private bool bArgsPrimitive;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x34")]
		private MessageEnum messageEnum;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x38")]
		private System.Type returnType;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x0")]
		private static object instanceOfVoid;
	}
}
