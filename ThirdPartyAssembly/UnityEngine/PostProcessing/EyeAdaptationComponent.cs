using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x1700003D")]
		public override bool active
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x52F8C40", Offset = "0x52F7840", VA = "0x1852F8C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x52F7C60", Offset = "0x52F6860", VA = "0x1852F7C60")]
		public void ResetHistory()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x52F7C60", Offset = "0x52F6860", VA = "0x1852F7C60", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x52F7B70", Offset = "0x52F6770", VA = "0x1852F7B70", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x52F7A50", Offset = "0x52F6650", VA = "0x1852F7A50")]
		private Vector4 GetHistogramScaleOffsetRes()
		{
			return default(Vector4);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x52F7E60", Offset = "0x52F6A60", VA = "0x1852F7E60")]
		public Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			return null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x52F7C70", Offset = "0x52F6870", VA = "0x1852F7C70")]
		public void OnGUI()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x52F8BD0", Offset = "0x52F77D0", VA = "0x1852F8BD0")]
		public EyeAdaptationComponent()
		{
		}

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x20")]
		private ComputeShader m_EyeCompute;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_HistogramBuffer;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x30")]
		private readonly RenderTexture[] m_AutoExposurePool;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x38")]
		private int m_AutoExposurePingPing;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_CurrentAutoExposure;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_DebugHistogram;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x0")]
		private static uint[] s_EmptyHistogramBuffer;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_FirstFrame;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		private const int k_HistogramBins = 64;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		private const int k_HistogramThreadX = 16;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		private const int k_HistogramThreadY = 16;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		private static class Uniforms
		{
			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Params;

			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Speed;

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _ScaleOffsetRes;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _ExposureCompensation;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _AutoExposure;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _DebugWidth;
		}
	}
}
