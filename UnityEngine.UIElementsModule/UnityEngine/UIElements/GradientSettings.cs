using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[Serializable]
	internal struct GradientSettings
	{
		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x0")]
		public GradientType gradientType;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x4")]
		public AddressMode addressMode;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 radialFocus;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x10")]
		public RectInt location;
	}
}
