using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010A5 RID: 4261
	[Token(Token = "0x20010A5")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemType
	{
		// Token: 0x04005AE3 RID: 23267
		[Token(Token = "0x4005AE3")]
		NONE,
		// Token: 0x04005AE4 RID: 23268
		[Token(Token = "0x4005AE4")]
		CHAR,
		// Token: 0x04005AE5 RID: 23269
		[Token(Token = "0x4005AE5")]
		CARD_EXP,
		// Token: 0x04005AE6 RID: 23270
		[Token(Token = "0x4005AE6")]
		MATERIAL,
		// Token: 0x04005AE7 RID: 23271
		[Token(Token = "0x4005AE7")]
		GOLD,
		// Token: 0x04005AE8 RID: 23272
		[Token(Token = "0x4005AE8")]
		EXP_PLAYER,
		// Token: 0x04005AE9 RID: 23273
		[Token(Token = "0x4005AE9")]
		TKT_TRY,
		// Token: 0x04005AEA RID: 23274
		[Token(Token = "0x4005AEA")]
		TKT_RECRUIT,
		// Token: 0x04005AEB RID: 23275
		[Token(Token = "0x4005AEB")]
		TKT_INST_FIN,
		// Token: 0x04005AEC RID: 23276
		[Token(Token = "0x4005AEC")]
		TKT_GACHA,
		// Token: 0x04005AED RID: 23277
		[Token(Token = "0x4005AED")]
		ACTIVITY_COIN,
		// Token: 0x04005AEE RID: 23278
		[Token(Token = "0x4005AEE")]
		DIAMOND,
		// Token: 0x04005AEF RID: 23279
		[Token(Token = "0x4005AEF")]
		DIAMOND_SHD,
		// Token: 0x04005AF0 RID: 23280
		[Token(Token = "0x4005AF0")]
		HGG_SHD,
		// Token: 0x04005AF1 RID: 23281
		[Token(Token = "0x4005AF1")]
		LGG_SHD,
		// Token: 0x04005AF2 RID: 23282
		[Token(Token = "0x4005AF2")]
		FURN,
		// Token: 0x04005AF3 RID: 23283
		[Token(Token = "0x4005AF3")]
		AP_GAMEPLAY,
		// Token: 0x04005AF4 RID: 23284
		[Token(Token = "0x4005AF4")]
		AP_BASE,
		// Token: 0x04005AF5 RID: 23285
		[Token(Token = "0x4005AF5")]
		SOCIAL_PT,
		// Token: 0x04005AF6 RID: 23286
		[Token(Token = "0x4005AF6")]
		CHAR_SKIN,
		// Token: 0x04005AF7 RID: 23287
		[Token(Token = "0x4005AF7")]
		TKT_GACHA_10,
		// Token: 0x04005AF8 RID: 23288
		[Token(Token = "0x4005AF8")]
		TKT_GACHA_PRSV,
		// Token: 0x04005AF9 RID: 23289
		[Token(Token = "0x4005AF9")]
		AP_ITEM,
		// Token: 0x04005AFA RID: 23290
		[Token(Token = "0x4005AFA")]
		AP_SUPPLY,
		// Token: 0x04005AFB RID: 23291
		[Token(Token = "0x4005AFB")]
		RENAMING_CARD,
		// Token: 0x04005AFC RID: 23292
		[Token(Token = "0x4005AFC")]
		RENAMING_CARD_2,
		// Token: 0x04005AFD RID: 23293
		[Token(Token = "0x4005AFD")]
		ET_STAGE,
		// Token: 0x04005AFE RID: 23294
		[Token(Token = "0x4005AFE")]
		ACTIVITY_ITEM,
		// Token: 0x04005AFF RID: 23295
		[Token(Token = "0x4005AFF")]
		VOUCHER_PICK,
		// Token: 0x04005B00 RID: 23296
		[Token(Token = "0x4005B00")]
		VOUCHER_CGACHA,
		// Token: 0x04005B01 RID: 23297
		[Token(Token = "0x4005B01")]
		VOUCHER_MGACHA,
		// Token: 0x04005B02 RID: 23298
		[Token(Token = "0x4005B02")]
		CRS_SHOP_COIN,
		// Token: 0x04005B03 RID: 23299
		[Token(Token = "0x4005B03")]
		CRS_RUNE_COIN,
		// Token: 0x04005B04 RID: 23300
		[Token(Token = "0x4005B04")]
		LMTGS_COIN,
		// Token: 0x04005B05 RID: 23301
		[Token(Token = "0x4005B05")]
		EPGS_COIN,
		// Token: 0x04005B06 RID: 23302
		[Token(Token = "0x4005B06")]
		LIMITED_TKT_GACHA_10,
		// Token: 0x04005B07 RID: 23303
		[Token(Token = "0x4005B07")]
		LIMITED_FREE_GACHA,
		// Token: 0x04005B08 RID: 23304
		[Token(Token = "0x4005B08")]
		REP_COIN,
		// Token: 0x04005B09 RID: 23305
		[Token(Token = "0x4005B09")]
		ROGUELIKE,
		// Token: 0x04005B0A RID: 23306
		[Token(Token = "0x4005B0A")]
		LINKAGE_TKT_GACHA_10,
		// Token: 0x04005B0B RID: 23307
		[Token(Token = "0x4005B0B")]
		VOUCHER_ELITE_II_4,
		// Token: 0x04005B0C RID: 23308
		[Token(Token = "0x4005B0C")]
		VOUCHER_ELITE_II_5,
		// Token: 0x04005B0D RID: 23309
		[Token(Token = "0x4005B0D")]
		VOUCHER_ELITE_II_6,
		// Token: 0x04005B0E RID: 23310
		[Token(Token = "0x4005B0E")]
		VOUCHER_SKIN,
		// Token: 0x04005B0F RID: 23311
		[Token(Token = "0x4005B0F")]
		RETRO_COIN,
		// Token: 0x04005B10 RID: 23312
		[Token(Token = "0x4005B10")]
		PLAYER_AVATAR,
		// Token: 0x04005B11 RID: 23313
		[Token(Token = "0x4005B11")]
		UNI_COLLECTION,
		// Token: 0x04005B12 RID: 23314
		[Token(Token = "0x4005B12")]
		VOUCHER_FULL_POTENTIAL,
		// Token: 0x04005B13 RID: 23315
		[Token(Token = "0x4005B13")]
		RL_COIN,
		// Token: 0x04005B14 RID: 23316
		[Token(Token = "0x4005B14")]
		RETURN_CREDIT,
		// Token: 0x04005B15 RID: 23317
		[Token(Token = "0x4005B15")]
		MEDAL,
		// Token: 0x04005B16 RID: 23318
		[Token(Token = "0x4005B16")]
		CHARM,
		// Token: 0x04005B17 RID: 23319
		[Token(Token = "0x4005B17")]
		HOME_BACKGROUND,
		// Token: 0x04005B18 RID: 23320
		[Token(Token = "0x4005B18")]
		EXTERMINATION_AGENT,
		// Token: 0x04005B19 RID: 23321
		[Token(Token = "0x4005B19")]
		OPTIONAL_VOUCHER_PICK,
		// Token: 0x04005B1A RID: 23322
		[Token(Token = "0x4005B1A")]
		ACT_CART_COMPONENT,
		// Token: 0x04005B1B RID: 23323
		[Token(Token = "0x4005B1B")]
		VOUCHER_LEVELMAX_6,
		// Token: 0x04005B1C RID: 23324
		[Token(Token = "0x4005B1C")]
		VOUCHER_LEVELMAX_5,
		// Token: 0x04005B1D RID: 23325
		[Token(Token = "0x4005B1D")]
		VOUCHER_LEVELMAX_4,
		// Token: 0x04005B1E RID: 23326
		[Token(Token = "0x4005B1E")]
		VOUCHER_SKILL_SPECIALLEVELMAX_6,
		// Token: 0x04005B1F RID: 23327
		[Token(Token = "0x4005B1F")]
		VOUCHER_SKILL_SPECIALLEVELMAX_5,
		// Token: 0x04005B20 RID: 23328
		[Token(Token = "0x4005B20")]
		VOUCHER_SKILL_SPECIALLEVELMAX_4,
		// Token: 0x04005B21 RID: 23329
		[Token(Token = "0x4005B21")]
		ACTIVITY_POTENTIAL,
		// Token: 0x04005B22 RID: 23330
		[Token(Token = "0x4005B22")]
		ITEM_PACK,
		// Token: 0x04005B23 RID: 23331
		[Token(Token = "0x4005B23")]
		SANDBOX,
		// Token: 0x04005B24 RID: 23332
		[Token(Token = "0x4005B24")]
		FAVOR_ADD_ITEM,
		// Token: 0x04005B25 RID: 23333
		[Token(Token = "0x4005B25")]
		CLASSIC_SHD,
		// Token: 0x04005B26 RID: 23334
		[Token(Token = "0x4005B26")]
		CLASSIC_TKT_GACHA,
		// Token: 0x04005B27 RID: 23335
		[Token(Token = "0x4005B27")]
		CLASSIC_TKT_GACHA_10,
		// Token: 0x04005B28 RID: 23336
		[Token(Token = "0x4005B28")]
		LIMITED_BUFF,
		// Token: 0x04005B29 RID: 23337
		[Token(Token = "0x4005B29")]
		CLASSIC_FES_PICK_TIER_5,
		// Token: 0x04005B2A RID: 23338
		[Token(Token = "0x4005B2A")]
		CLASSIC_FES_PICK_TIER_6,
		// Token: 0x04005B2B RID: 23339
		[Token(Token = "0x4005B2B")]
		RETURN_PROGRESS,
		// Token: 0x04005B2C RID: 23340
		[Token(Token = "0x4005B2C")]
		NEW_PROGRESS,
		// Token: 0x04005B2D RID: 23341
		[Token(Token = "0x4005B2D")]
		MCARD_VOUCHER,
		// Token: 0x04005B2E RID: 23342
		[Token(Token = "0x4005B2E")]
		MATERIAL_ISSUE_VOUCHER,
		// Token: 0x04005B2F RID: 23343
		[Token(Token = "0x4005B2F")]
		CRS_SHOP_COIN_V2,
		// Token: 0x04005B30 RID: 23344
		[Token(Token = "0x4005B30")]
		HOME_THEME,
		// Token: 0x04005B31 RID: 23345
		[Token(Token = "0x4005B31")]
		SANDBOX_PERM,
		// Token: 0x04005B32 RID: 23346
		[Token(Token = "0x4005B32")]
		SANDBOX_TOKEN,
		// Token: 0x04005B33 RID: 23347
		[Token(Token = "0x4005B33")]
		TEMPLATE_TRAP,
		// Token: 0x04005B34 RID: 23348
		[Token(Token = "0x4005B34")]
		NAME_CARD_SKIN,
		// Token: 0x04005B35 RID: 23349
		[Token(Token = "0x4005B35")]
		EMOTICON_SET,
		// Token: 0x04005B36 RID: 23350
		[Token(Token = "0x4005B36")]
		EXCLUSIVE_TKT_GACHA,
		// Token: 0x04005B37 RID: 23351
		[Token(Token = "0x4005B37")]
		EXCLUSIVE_TKT_GACHA_10,
		// Token: 0x04005B38 RID: 23352
		[Token(Token = "0x4005B38")]
		SO_CHAR_EXP,
		// Token: 0x04005B39 RID: 23353
		[Token(Token = "0x4005B39")]
		GIFTPACKAGE_TKT,
		// Token: 0x04005B3A RID: 23354
		[Token(Token = "0x4005B3A")]
		VOUCHER_SKIN_V2,
		// Token: 0x04005B3B RID: 23355
		[Token(Token = "0x4005B3B")]
		RANDOM_VOUCHER_SKIN,
		// Token: 0x04005B3C RID: 23356
		[Token(Token = "0x4005B3C")]
		ACT1VHALFIDLE_ITEM,
		// Token: 0x04005B3D RID: 23357
		[Token(Token = "0x4005B3D")]
		PLOT_ITEM,
		// Token: 0x04005B3E RID: 23358
		[Token(Token = "0x4005B3E")]
		MAGAZINE_LEAF,
		// Token: 0x04005B3F RID: 23359
		[Token(Token = "0x4005B3F")]
		STICKER
	}
}
