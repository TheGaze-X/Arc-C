using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public struct Vertex
	{
		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float nearZ;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0xC")]
		public Color32 tint;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 uv;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x18")]
		internal Color32 xformClipPages;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x1C")]
		internal Color32 ids;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x20")]
		internal Color32 flags;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x24")]
		internal Color32 opacityColorPages;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x28")]
		internal Vector4 circle;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x38")]
		internal float textureId;
	}
}
