using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CDE RID: 31966
	[Token(Token = "0x2007CDE")]
	[AddComponentMenu("Colorful FX/Camera Effects/Frost")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/frost.html")]
	[ExecuteInEditMode]
	public class Frost : BaseEffect
	{
		// Token: 0x0602C9DF RID: 182751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9DF")]
		[Address(RVA = "0x287BE50", Offset = "0x287AA50", VA = "0x18287BE50", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9E0 RID: 182752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9E0")]
		[Address(RVA = "0x287BE20", Offset = "0x287AA20", VA = "0x18287BE20", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9E1 RID: 182753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E1")]
		[Address(RVA = "0x287BFF0", Offset = "0x287ABF0", VA = "0x18287BFF0")]
		public Frost()
		{
		}

		// Token: 0x0404046C RID: 263276
		[Token(Token = "0x404046C")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 16f)]
		[Tooltip("Frosting strength.")]
		public float Scale;

		// Token: 0x0404046D RID: 263277
		[Token(Token = "0x404046D")]
		[FieldOffset(Offset = "0x2C")]
		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		// Token: 0x0404046E RID: 263278
		[Token(Token = "0x404046E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		// Token: 0x0404046F RID: 263279
		[Token(Token = "0x404046F")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Should the effect be applied like a vignette ?")]
		public bool EnableVignette;
	}
}
