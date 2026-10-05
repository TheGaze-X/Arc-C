using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x17000047")]
		public override bool active
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x5435B00", Offset = "0x5434700", VA = "0x185435B00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x5435810", Offset = "0x5434410", VA = "0x185435810", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x5435AC0", Offset = "0x54346C0", VA = "0x185435AC0")]
		public VignetteComponent()
		{
		}

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		private static class Uniforms
		{
			// Token: 0x04000439 RID: 1081
			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Vignette_Color;

			// Token: 0x0400043A RID: 1082
			[Token(Token = "0x400043A")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Vignette_Center;

			// Token: 0x0400043B RID: 1083
			[Token(Token = "0x400043B")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Vignette_Settings;

			// Token: 0x0400043C RID: 1084
			[Token(Token = "0x400043C")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _Vignette_Mask;

			// Token: 0x0400043D RID: 1085
			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _Vignette_Opacity;
		}
	}
}
