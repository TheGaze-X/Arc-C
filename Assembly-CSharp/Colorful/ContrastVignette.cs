using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD4 RID: 31956
	[Token(Token = "0x2007CD4")]
	[AddComponentMenu("Colorful FX/Camera Effects/Contrast Vignette")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/contrast-vignette.html")]
	[ExecuteInEditMode]
	public class ContrastVignette : BaseEffect
	{
		// Token: 0x0602C9C7 RID: 182727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C7")]
		[Address(RVA = "0x287A8F0", Offset = "0x28794F0", VA = "0x18287A8F0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9C8 RID: 182728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9C8")]
		[Address(RVA = "0x287A8C0", Offset = "0x28794C0", VA = "0x18287A8C0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9C9 RID: 182729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C9")]
		[Address(RVA = "0x287AAC0", Offset = "0x28796C0", VA = "0x18287AAC0")]
		public ContrastVignette()
		{
		}

		// Token: 0x04040439 RID: 263225
		[Token(Token = "0x4040439")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Center point.")]
		public Vector2 Center;

		// Token: 0x0404043A RID: 263226
		[Token(Token = "0x404043A")]
		[FieldOffset(Offset = "0x30")]
		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		// Token: 0x0404043B RID: 263227
		[Token(Token = "0x404043B")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		// Token: 0x0404043C RID: 263228
		[Token(Token = "0x404043C")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 200f)]
		[Tooltip("Expands or shrinks the overall range of tonal values in the vignette area.")]
		public float Contrast;

		// Token: 0x0404043D RID: 263229
		[Token(Token = "0x404043D")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 ContrastCoeff;

		// Token: 0x0404043E RID: 263230
		[Token(Token = "0x404043E")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 200f)]
		[Tooltip("Blends the contrast change toward the edges of the vignette effect.")]
		public float EdgeBlending;
	}
}
