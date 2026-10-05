using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	internal struct MonoEventInfo
	{
		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x0")]
		public System.Type declaring_type;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x8")]
		public System.Type reflected_type;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x18")]
		public MethodInfo add_method;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x20")]
		public MethodInfo remove_method;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x28")]
		public MethodInfo raise_method;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x30")]
		public EventAttributes attrs;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x38")]
		public MethodInfo[] other_methods;
	}
}
