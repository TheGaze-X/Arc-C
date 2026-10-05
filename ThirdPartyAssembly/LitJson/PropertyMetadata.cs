using System;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200047C RID: 1148
	[Token(Token = "0x200047C")]
	internal struct PropertyMetadata
	{
		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		// Token: 0x040014A8 RID: 5288
		[Token(Token = "0x40014A8")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
