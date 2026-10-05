using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[RequireComponent(typeof(Camera))]
	public class ScreenOverlay : PostEffectsBase
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x52FD7F0", Offset = "0x52FC3F0", VA = "0x1852FD7F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x52FD8B0", Offset = "0x52FC4B0", VA = "0x1852FD8B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x52FDA30", Offset = "0x52FC630", VA = "0x1852FDA30")]
		public ScreenOverlay()
		{
		}

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x28")]
		public ScreenOverlay.OverlayBlendMode blendMode;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		public enum OverlayBlendMode
		{
			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			Additive,
			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			ScreenBlend,
			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			Multiply,
			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			Overlay,
			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			AlphaBlend
		}
	}
}
