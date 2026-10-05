using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[Preserve]
	[Serializable]
	public sealed class TemporalAntialiasing
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000002")]
		public Vector2 jitter
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x318C4E0", Offset = "0x318B0E0", VA = "0x18318C4E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000003")]
		public int sampleIndex
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x582D650", Offset = "0x582C250", VA = "0x18582D650")]
		public bool IsSupported()
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00")]
		internal DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5104EF0", Offset = "0x5103AF0", VA = "0x185104EF0")]
		internal void ResetHistory()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x582D3A0", Offset = "0x582BFA0", VA = "0x18582D3A0")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x582D440", Offset = "0x582C040", VA = "0x18582D440")]
		public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x582CF50", Offset = "0x582BB50", VA = "0x18582CF50")]
		public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x582D030", Offset = "0x582BC30", VA = "0x18582D030")]
		public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x582D2B0", Offset = "0x582BEB0", VA = "0x18582D2B0")]
		private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x582C9C0", Offset = "0x582B5C0", VA = "0x18582C9C0")]
		private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x582D800", Offset = "0x582C400", VA = "0x18582D800")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x582D690", Offset = "0x582C290", VA = "0x18582D690")]
		internal void Release()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x582DD10", Offset = "0x582C910", VA = "0x18582DD10")]
		public TemporalAntialiasing()
		{
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
		[Range(0.1f, 1f)]
		public float jitterSpread;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
		[Range(0f, 3f)]
		public float sharpness;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
		[Range(0f, 0.99f)]
		public float stationaryBlending;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
		[Range(0f, 0.99f)]
		public float motionBlending;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x20")]
		public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x30")]
		private readonly RenderTargetIdentifier[] m_Mrt;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_ResetHistory;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		private const int k_SampleCount = 8;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		private const int k_NumEyes = 2;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		private const int k_NumHistoryTextures = 2;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x40")]
		private readonly RenderTexture[][] m_HistoryTextures;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x48")]
		private readonly int[] m_HistoryPingPong;

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		private enum Pass
		{
			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			SolverDilate,
			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			SolverNoDilate
		}
	}
}
