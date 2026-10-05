using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[Serializable]
	internal struct VectorImageVertex
	{
		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xC")]
		public Color32 tint;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 uv;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x18")]
		public uint settingIndex;
	}
}
