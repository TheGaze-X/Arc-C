using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	internal struct PropertyMetadata
	{
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
