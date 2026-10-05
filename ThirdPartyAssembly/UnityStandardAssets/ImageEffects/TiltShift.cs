using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	[RequireComponent(typeof(Camera))]
	internal class TiltShift : PostEffectsBase
	{
		// Token: 0x0600025C RID: 604 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x52FFB00", Offset = "0x52FE700", VA = "0x1852FFB00", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x52FFBC0", Offset = "0x52FE7C0", VA = "0x1852FFBC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x52FFEB0", Offset = "0x52FEAB0", VA = "0x1852FFEB0")]
		public TiltShift()
		{
		}

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x28")]
		public TiltShift.TiltShiftMode mode;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x2C")]
		public TiltShift.TiltShiftQuality quality;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 15f)]
		public float blurArea;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public enum TiltShiftMode
		{
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			TiltShiftMode,
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			IrisMode
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		public enum TiltShiftQuality
		{
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			Preview,
			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			Low,
			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			Normal,
			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			High
		}
	}
}
