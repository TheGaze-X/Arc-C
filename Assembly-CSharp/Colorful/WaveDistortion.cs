using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D12 RID: 32018
	[Token(Token = "0x2007D12")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/wave-distortion.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Wave Distortion")]
	public class WaveDistortion : BaseEffect
	{
		// Token: 0x0602CA6C RID: 182892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA6C")]
		[Address(RVA = "0x2883A70", Offset = "0x2882670", VA = "0x182883A70", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA6D RID: 182893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA6D")]
		[Address(RVA = "0x2883A40", Offset = "0x2882640", VA = "0x182883A40", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA6E RID: 182894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA6E")]
		[Address(RVA = "0x2883BA0", Offset = "0x28827A0", VA = "0x182883BA0")]
		public WaveDistortion()
		{
		}

		// Token: 0x04040585 RID: 263557
		[Token(Token = "0x4040585")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Wave amplitude.")]
		public float Amplitude;

		// Token: 0x04040586 RID: 263558
		[Token(Token = "0x4040586")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Amount of waves.")]
		public float Waves;

		// Token: 0x04040587 RID: 263559
		[Token(Token = "0x4040587")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 5f)]
		[Tooltip("Amount of color shifting.")]
		public float ColorGlitch;

		// Token: 0x04040588 RID: 263560
		[Token(Token = "0x4040588")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Distortion state. Think of it as a bell curve going from 0 to 1, with 0.5 being the highest point.")]
		public float Phase;
	}
}
