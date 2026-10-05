using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x1700003B")]
		public override bool active
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x52F74C0", Offset = "0x52F60C0", VA = "0x1852F74C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x52F6940", Offset = "0x52F5540", VA = "0x1852F6940")]
		private float CalculateFocalLength()
		{
			return 0f;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x52F69E0", Offset = "0x52F55E0", VA = "0x1852F69E0")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return 0f;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x52F6AE0", Offset = "0x52F56E0", VA = "0x1852F6AE0")]
		public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x52F6A60", Offset = "0x52F5660", VA = "0x1852F6A60", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x52F7450", Offset = "0x52F6050", VA = "0x1852F7450")]
		public DepthOfFieldComponent()
		{
		}

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_CoCHistory;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x28")]
		private RenderBuffer[] m_MRT;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		private const float k_FilmHeight = 0.024f;

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		private static class Uniforms
		{
			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthOfFieldTex;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Distance;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _LensCoeff;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _MaxCoC;

			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _RcpMaxCoC;

			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _RcpAspect;

			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _MainTex;

			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _HistoryCoC;

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _HistoryWeight;

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _DepthOfFieldParams;
		}
	}
}
