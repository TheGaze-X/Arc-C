using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[RequireComponent(typeof(Camera))]
	public class Tonemapping : PostEffectsBase
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x52FFED0", Offset = "0x52FEAD0", VA = "0x1852FFED0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x5300BF0", Offset = "0x52FF7F0", VA = "0x185300BF0")]
		public float UpdateCurve()
		{
			return 0f;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x53001A0", Offset = "0x52FEDA0", VA = "0x1853001A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x5300090", Offset = "0x52FEC90", VA = "0x185300090")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5300300", Offset = "0x52FEF00", VA = "0x185300300")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5300F00", Offset = "0x52FFB00", VA = "0x185300F00")]
		public Tonemapping()
		{
		}

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x28")]
		public Tonemapping.TonemapperType type;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x2C")]
		public Tonemapping.AdaptiveTexSize adaptiveTextureSize;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x44")]
		public float middleGrey;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x48")]
		public float white;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		public enum TonemapperType
		{
			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			SimpleReinhard,
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			UserCurve,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			Hable,
			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			Photographic,
			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			OptimizedHejiDawson,
			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			AdaptiveReinhard,
			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			AdaptiveReinhardAutoWhite
		}

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		public enum AdaptiveTexSize
		{
			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			Square16 = 16,
			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			Square32 = 32,
			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			Square64 = 64,
			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			Square128 = 128,
			// Token: 0x040002CE RID: 718
			[Token(Token = "0x40002CE")]
			Square256 = 256,
			// Token: 0x040002CF RID: 719
			[Token(Token = "0x40002CF")]
			Square512 = 512,
			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x40002D0")]
			Square1024 = 1024
		}
	}
}
