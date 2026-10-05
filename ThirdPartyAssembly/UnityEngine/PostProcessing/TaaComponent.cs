using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x17000045")]
		public override bool active
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x5433B20", Offset = "0x5432720", VA = "0x185433B20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x5433520", Offset = "0x5432120", VA = "0x185433520")]
		public void ResetHistory()
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x5433530", Offset = "0x5432130", VA = "0x185433530")]
		public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5432ED0", Offset = "0x5431AD0", VA = "0x185432ED0")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x54326F0", Offset = "0x54312F0", VA = "0x1854326F0")]
		private float GetHaltonValue(int index, int radix)
		{
			return 0f;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5432630", Offset = "0x5431230", VA = "0x185432630")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x5432910", Offset = "0x5431510", VA = "0x185432910")]
		private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5432730", Offset = "0x5431330", VA = "0x185432730")]
		private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x5432E40", Offset = "0x5431A40", VA = "0x185432E40", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x5433AB0", Offset = "0x54326B0", VA = "0x185433AB0")]
		public TaaComponent()
		{
		}

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		private const int k_SampleCount = 8;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderBuffer[] m_MRT;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_ResetHistory;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_HistoryTexture;

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		private static class Uniforms
		{
			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			[FieldOffset(Offset = "0x0")]
			internal static int _Jitter;

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			[FieldOffset(Offset = "0x4")]
			internal static int _SharpenParameters;

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			[FieldOffset(Offset = "0x8")]
			internal static int _FinalBlendParameters;

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0xC")]
			internal static int _HistoryTex;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x10")]
			internal static int _MainTex;
		}
	}
}
