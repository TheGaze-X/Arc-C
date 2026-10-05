using System;
using System.Reflection;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	internal struct PropertyMetadata
	{
		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
