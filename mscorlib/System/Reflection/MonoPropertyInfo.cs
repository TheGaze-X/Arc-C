using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	internal struct MonoPropertyInfo
	{
		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x0")]
		public System.Type parent;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x8")]
		public System.Type declaring_type;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x18")]
		public MethodInfo get_method;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x20")]
		public MethodInfo set_method;

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x28")]
		public PropertyAttributes attrs;
	}
}
