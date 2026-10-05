using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x17000039")]
		public override bool active
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x52F3D60", Offset = "0x52F2960", VA = "0x1852F3D60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x52F3A50", Offset = "0x52F2650", VA = "0x1852F3A50", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x52F3A80", Offset = "0x52F2680", VA = "0x1852F3A80", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x52F3D20", Offset = "0x52F2920", VA = "0x1852F3D20")]
		public ChromaticAberrationComponent()
		{
		}

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_SpectrumLut;

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		private static class Uniforms
		{
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _ChromaticAberration_Amount;

			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _ChromaticAberration_Spectrum;
		}
	}
}
