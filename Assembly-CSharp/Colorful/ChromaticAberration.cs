using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD1 RID: 31953
	[Token(Token = "0x2007CD1")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/chromatic-aberration.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Chromatic Aberration")]
	public class ChromaticAberration : BaseEffect
	{
		// Token: 0x0602C9BE RID: 182718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9BE")]
		[Address(RVA = "0x287A290", Offset = "0x2878E90", VA = "0x18287A290", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9BF RID: 182719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9BF")]
		[Address(RVA = "0x287A260", Offset = "0x2878E60", VA = "0x18287A260", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9C0 RID: 182720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C0")]
		[Address(RVA = "0x287A3A0", Offset = "0x2878FA0", VA = "0x18287A3A0")]
		public ChromaticAberration()
		{
		}

		// Token: 0x04040428 RID: 263208
		[Token(Token = "0x4040428")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.9f, 1.1f)]
		[Tooltip("Indice of refraction for the red channel.")]
		public float RedRefraction;

		// Token: 0x04040429 RID: 263209
		[Token(Token = "0x4040429")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.9f, 1.1f)]
		[Tooltip("Indice of refraction for the green channel.")]
		public float GreenRefraction;

		// Token: 0x0404042A RID: 263210
		[Token(Token = "0x404042A")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.9f, 1.1f)]
		[Tooltip("Indice of refraction for the blue channel.")]
		public float BlueRefraction;

		// Token: 0x0404042B RID: 263211
		[Token(Token = "0x404042B")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Enable this option if you need the effect to keep the alpha channel from the original render (some effects like Glow will need it). Disable it otherwise for better performances.")]
		public bool PreserveAlpha;
	}
}
