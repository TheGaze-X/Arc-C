using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		// Token: 0x0600024B RID: 587 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x52FDA50", Offset = "0x52FC650", VA = "0x1852FDA50", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x52FDAB0", Offset = "0x52FC6B0", VA = "0x1852FDAB0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x52FDB40", Offset = "0x52FC740", VA = "0x1852FDB40")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x52FE520", Offset = "0x52FD120", VA = "0x1852FE520")]
		public ScreenSpaceAmbientObscurance()
		{
		}

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x50")]
		private Material aoMaterial;
	}
}
