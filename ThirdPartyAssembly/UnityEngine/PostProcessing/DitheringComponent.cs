using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x1700003C")]
		public override bool active
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x52F79F0", Offset = "0x52F65F0", VA = "0x1852F79F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xC96C40", Offset = "0xC95840", VA = "0x180C96C40", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x52F7540", Offset = "0x52F6140", VA = "0x1852F7540")]
		private void LoadNoiseTextures()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x52F7670", Offset = "0x52F6270", VA = "0x1852F7670", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x52F79B0", Offset = "0x52F65B0", VA = "0x1852F79B0")]
		public DitheringComponent()
		{
		}

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D[] noiseTextures;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x28")]
		private int textureIndex;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		private const int k_TextureCount = 64;

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		private static class Uniforms
		{
			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DitheringTex;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _DitheringCoords;
		}
	}
}
