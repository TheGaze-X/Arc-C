using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CCC RID: 31948
	[Token(Token = "0x2007CCC")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/brightness-contrast-gamma.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Brightness, Contrast, Gamma")]
	public class BrightnessContrastGamma : BaseEffect
	{
		// Token: 0x0602C9B1 RID: 182705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B1")]
		[Address(RVA = "0x28797F0", Offset = "0x28783F0", VA = "0x1828797F0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9B2 RID: 182706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9B2")]
		[Address(RVA = "0x28797C0", Offset = "0x28783C0", VA = "0x1828797C0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9B3 RID: 182707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B3")]
		[Address(RVA = "0x28799C0", Offset = "0x28785C0", VA = "0x1828799C0")]
		public BrightnessContrastGamma()
		{
		}

		// Token: 0x04040415 RID: 263189
		[Token(Token = "0x4040415")]
		[FieldOffset(Offset = "0x28")]
		[Range(-100f, 100f)]
		[Tooltip("Moving the slider to the right increases tonal values and expands highlights, to the left decreases values and expands shadows.")]
		public float Brightness;

		// Token: 0x04040416 RID: 263190
		[Token(Token = "0x4040416")]
		[FieldOffset(Offset = "0x2C")]
		[Range(-100f, 100f)]
		[Tooltip("Expands or shrinks the overall range of tonal values.")]
		public float Contrast;

		// Token: 0x04040417 RID: 263191
		[Token(Token = "0x4040417")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 ContrastCoeff;

		// Token: 0x04040418 RID: 263192
		[Token(Token = "0x4040418")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0.1f, 9.9f)]
		[Tooltip("Simple power function.")]
		public float Gamma;
	}
}
