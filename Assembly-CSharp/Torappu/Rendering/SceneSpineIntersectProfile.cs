using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200206A RID: 8298
	[Token(Token = "0x200206A")]
	public class SceneSpineIntersectProfile : ScriptableObject
	{
		// Token: 0x0600CC6F RID: 52335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6F")]
		[Address(RVA = "0x34E45B0", Offset = "0x34E31B0", VA = "0x1834E45B0")]
		public SceneSpineIntersectProfile()
		{
		}

		// Token: 0x0400D713 RID: 55059
		[Token(Token = "0x400D713")]
		[FieldOffset(Offset = "0x18")]
		public bool spineClip;

		// Token: 0x0400D714 RID: 55060
		[Token(Token = "0x400D714")]
		[FieldOffset(Offset = "0x20")]
		public Shader spineReplaceShader;

		// Token: 0x0400D715 RID: 55061
		[Token(Token = "0x400D715")]
		[FieldOffset(Offset = "0x28")]
		public float spineHeightTeak;

		// Token: 0x0400D716 RID: 55062
		[Token(Token = "0x400D716")]
		[FieldOffset(Offset = "0x2C")]
		public Color spineTintColor;

		// Token: 0x0400D717 RID: 55063
		[Token(Token = "0x400D717")]
		[FieldOffset(Offset = "0x3C")]
		public float spineHeightOffset;
	}
}
