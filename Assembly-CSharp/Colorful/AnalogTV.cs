using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CC7 RID: 31943
	[Token(Token = "0x2007CC7")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/analog-tv.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Analog TV")]
	public class AnalogTV : BaseEffect
	{
		// Token: 0x0602C9A1 RID: 182689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A1")]
		[Address(RVA = "0x2878560", Offset = "0x2877160", VA = "0x182878560", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x0602C9A2 RID: 182690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A2")]
		[Address(RVA = "0x28783E0", Offset = "0x2876FE0", VA = "0x1828783E0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9A3 RID: 182691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9A3")]
		[Address(RVA = "0x28783B0", Offset = "0x2876FB0", VA = "0x1828783B0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9A4 RID: 182692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A4")]
		[Address(RVA = "0x28785C0", Offset = "0x28771C0", VA = "0x1828785C0")]
		public AnalogTV()
		{
		}

		// Token: 0x040403ED RID: 263149
		[Token(Token = "0x40403ED")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Automatically animate the Phase value.")]
		public bool AutomaticPhase;

		// Token: 0x040403EE RID: 263150
		[Token(Token = "0x40403EE")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Current noise phase. Consider this a seed value.")]
		public float Phase;

		// Token: 0x040403EF RID: 263151
		[Token(Token = "0x40403EF")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Convert the original render to black & white.")]
		public bool ConvertToGrayscale;

		// Token: 0x040403F0 RID: 263152
		[Token(Token = "0x40403F0")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Noise brightness. Will impact the scanlines visibility.")]
		public float NoiseIntensity;

		// Token: 0x040403F1 RID: 263153
		[Token(Token = "0x40403F1")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 10f)]
		[Tooltip("Scanline brightness. Depends on the NoiseIntensity value.")]
		public float ScanlinesIntensity;

		// Token: 0x040403F2 RID: 263154
		[Token(Token = "0x40403F2")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 4096f)]
		[Tooltip("The number of scanlines to draw.")]
		public int ScanlinesCount;

		// Token: 0x040403F3 RID: 263155
		[Token(Token = "0x40403F3")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Scanline offset. Gives a cool screen scanning effect when animated.")]
		public float ScanlinesOffset;

		// Token: 0x040403F4 RID: 263156
		[Token(Token = "0x40403F4")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Uses vertical scanlines.")]
		public bool VerticalScanlines;

		// Token: 0x040403F5 RID: 263157
		[Token(Token = "0x40403F5")]
		[FieldOffset(Offset = "0x48")]
		[Range(-2f, 2f)]
		[Tooltip("Spherical distortion factor.")]
		public float Distortion;

		// Token: 0x040403F6 RID: 263158
		[Token(Token = "0x40403F6")]
		[FieldOffset(Offset = "0x4C")]
		[Range(-2f, 2f)]
		[Tooltip("Cubic distortion factor.")]
		public float CubicDistortion;

		// Token: 0x040403F7 RID: 263159
		[Token(Token = "0x40403F7")]
		[FieldOffset(Offset = "0x50")]
		[Range(0.01f, 2f)]
		[Tooltip("Helps avoid screen streching on borders when working with heavy distortions.")]
		public float Scale;
	}
}
