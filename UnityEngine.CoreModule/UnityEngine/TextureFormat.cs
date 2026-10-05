using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public enum TextureFormat
	{
		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		Alpha8 = 1,
		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		ARGB4444,
		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		RGB24,
		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		RGBA32,
		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		ARGB32,
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		RGB565 = 7,
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		R16 = 9,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		DXT1,
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		DXT5 = 12,
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		RGBA4444,
		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		BGRA32,
		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		RHalf,
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		RGHalf,
		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		RGBAHalf,
		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		RFloat,
		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		RGFloat,
		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		RGBAFloat,
		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		YUY2,
		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		RGB9e5Float,
		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		BC4 = 26,
		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		BC5,
		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		BC6H = 24,
		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		BC7,
		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		DXT1Crunched = 28,
		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		DXT5Crunched,
		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		PVRTC_RGB2,
		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		PVRTC_RGBA2,
		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		PVRTC_RGB4,
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		PVRTC_RGBA4,
		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		ETC_RGB4,
		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		EAC_R = 41,
		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		EAC_R_SIGNED,
		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		EAC_RG,
		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		EAC_RG_SIGNED,
		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		ETC2_RGB,
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		ETC2_RGBA1,
		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		ETC2_RGBA8,
		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		ASTC_4x4,
		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		ASTC_5x5,
		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		ASTC_6x6,
		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		ASTC_8x8,
		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		ASTC_10x10,
		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		ASTC_12x12,
		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[Obsolete("Nintendo 3DS is no longer supported.")]
		ETC_RGB4_3DS = 60,
		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[Obsolete("Nintendo 3DS is no longer supported.")]
		ETC_RGBA8_3DS,
		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		RG16,
		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		R8,
		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		ETC_RGB4Crunched,
		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		ETC2_RGBA8Crunched,
		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		ASTC_HDR_4x4,
		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		ASTC_HDR_5x5,
		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		ASTC_HDR_6x6,
		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		ASTC_HDR_8x8,
		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		ASTC_HDR_10x10,
		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		ASTC_HDR_12x12,
		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		RG32,
		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		RGB48,
		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		RGBA64,
		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_4x4 = 48,
		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		ASTC_RGB_5x5,
		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		ASTC_RGB_6x6,
		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_8x8,
		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		ASTC_RGB_10x10,
		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_12x12,
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		ASTC_RGBA_4x4,
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_5x5,
		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_6x6,
		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		ASTC_RGBA_8x8,
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_10x10,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		ASTC_RGBA_12x12
	}
}
