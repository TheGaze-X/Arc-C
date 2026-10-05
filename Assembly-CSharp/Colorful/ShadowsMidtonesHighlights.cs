using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D04 RID: 32004
	[Token(Token = "0x2007D04")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Shadows, Midtones, Highlights")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/shadows-midtones-highlights.html")]
	public class ShadowsMidtonesHighlights : BaseEffect
	{
		// Token: 0x0602CA4B RID: 182859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA4B")]
		[Address(RVA = "0x2881EE0", Offset = "0x2880AE0", VA = "0x182881EE0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA4C RID: 182860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA4C")]
		[Address(RVA = "0x2881EB0", Offset = "0x2880AB0", VA = "0x182881EB0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA4D RID: 182861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA4D")]
		[Address(RVA = "0x2882260", Offset = "0x2880E60", VA = "0x182882260")]
		public ShadowsMidtonesHighlights()
		{
		}

		// Token: 0x04040535 RID: 263477
		[Token(Token = "0x4040535")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Color mode. The difference between these two modes is the way shadows are handled.")]
		public ShadowsMidtonesHighlights.ColorMode Mode;

		// Token: 0x04040536 RID: 263478
		[Token(Token = "0x4040536")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Adds density or darkness, raises or lowers the shadow levels with its alpha value and offset the color balance in the dark regions with the hue point.")]
		public Color Shadows;

		// Token: 0x04040537 RID: 263479
		[Token(Token = "0x4040537")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Shifts the middle tones to be brighter or darker. For instance, to make your render more warm, just move the midtone color toward the yellow/red range. The more saturated the color is, the warmer the render becomes.")]
		public Color Midtones;

		// Token: 0x04040538 RID: 263480
		[Token(Token = "0x4040538")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Brightens and tints the entire render but mostly affects the highlights.")]
		public Color Highlights;

		// Token: 0x04040539 RID: 263481
		[Token(Token = "0x4040539")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x02007D05 RID: 32005
		[Token(Token = "0x2007D05")]
		public enum ColorMode
		{
			// Token: 0x0404053B RID: 263483
			[Token(Token = "0x404053B")]
			LiftGammaGain,
			// Token: 0x0404053C RID: 263484
			[Token(Token = "0x404053C")]
			OffsetGammaSlope
		}
	}
}
