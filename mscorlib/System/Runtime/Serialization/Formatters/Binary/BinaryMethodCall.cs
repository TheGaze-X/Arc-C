using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	internal sealed class BinaryMethodCall
	{
		// Token: 0x0600209A RID: 8346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x4B958D0", Offset = "0x4B944D0", VA = "0x184B958D0")]
		internal void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void Dump()
		{
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x621E20", Offset = "0x620A20", VA = "0x180621E20")]
		public BinaryMethodCall()
		{
		}

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x18")]
		private string typeName;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x20")]
		private object[] args;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x28")]
		private object callContext;

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x30")]
		private System.Type[] argTypes;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x38")]
		private bool bArgsPrimitive;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x3C")]
		private MessageEnum messageEnum;
	}
}
