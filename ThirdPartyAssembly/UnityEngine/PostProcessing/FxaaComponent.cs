using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x1700003F")]
		public override bool active
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x5424A90", Offset = "0x5423690", VA = "0x185424A90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x54247E0", Offset = "0x54233E0", VA = "0x1854247E0")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5424A50", Offset = "0x5423650", VA = "0x185424A50")]
		public FxaaComponent()
		{
		}

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		private static class Uniforms
		{
			// Token: 0x040003C2 RID: 962
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _QualitySettings;

			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _ConsoleSettings;
		}
	}
}
