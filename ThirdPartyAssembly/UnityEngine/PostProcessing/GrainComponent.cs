using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x17000040")]
		public override bool active
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x5426A90", Offset = "0x5425690", VA = "0x185426A90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x52F3A50", Offset = "0x52F2650", VA = "0x1852F3A50", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5426580", Offset = "0x5425180", VA = "0x185426580", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x5426A50", Offset = "0x5425650", VA = "0x185426A50")]
		public GrainComponent()
		{
		}

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		private static class Uniforms
		{
			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Grain_Params1;

			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Grain_Params2;

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _GrainTex;

			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _Phase;
		}
	}
}
