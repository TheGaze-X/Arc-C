using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200204C RID: 8268
	[Token(Token = "0x200204C")]
	public class SceneEffectProfile : ScriptableObject
	{
		// Token: 0x0600CBDB RID: 52187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDB")]
		[Address(RVA = "0x34CD3A0", Offset = "0x34CBFA0", VA = "0x1834CD3A0")]
		public SceneEffectProfile()
		{
		}

		// Token: 0x0400D631 RID: 54833
		[Token(Token = "0x400D631")]
		[FieldOffset(Offset = "0x18")]
		public bool shadowTint;

		// Token: 0x0400D632 RID: 54834
		[Token(Token = "0x400D632")]
		[FieldOffset(Offset = "0x1C")]
		public Color shadowTintColor;

		// Token: 0x0400D633 RID: 54835
		[Token(Token = "0x400D633")]
		[FieldOffset(Offset = "0x2C")]
		public Color fogColor;

		// Token: 0x0400D634 RID: 54836
		[Token(Token = "0x400D634")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D fogNoise;

		// Token: 0x0400D635 RID: 54837
		[Token(Token = "0x400D635")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 fogNoiseScale;

		// Token: 0x0400D636 RID: 54838
		[Token(Token = "0x400D636")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 20f)]
		public float fogSpeed;

		// Token: 0x0400D637 RID: 54839
		[Token(Token = "0x400D637")]
		[FieldOffset(Offset = "0x54")]
		public bool heightFog;

		// Token: 0x0400D638 RID: 54840
		[Token(Token = "0x400D638")]
		[FieldOffset(Offset = "0x58")]
		public float fogBaseline;

		// Token: 0x0400D639 RID: 54841
		[Token(Token = "0x400D639")]
		[FieldOffset(Offset = "0x5C")]
		public float fogTop;

		// Token: 0x0400D63A RID: 54842
		[Token(Token = "0x400D63A")]
		[FieldOffset(Offset = "0x60")]
		public bool dirFog;

		// Token: 0x0400D63B RID: 54843
		[Token(Token = "0x400D63B")]
		[FieldOffset(Offset = "0x61")]
		public bool noCenterMask;

		// Token: 0x0400D63C RID: 54844
		[Token(Token = "0x400D63C")]
		[FieldOffset(Offset = "0x62")]
		public bool colorGrading;

		// Token: 0x0400D63D RID: 54845
		[Token(Token = "0x400D63D")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D colorGradingLut;

		// Token: 0x0400D63E RID: 54846
		[Token(Token = "0x400D63E")]
		[FieldOffset(Offset = "0x70")]
		public bool graphicsGrading;
	}
}
