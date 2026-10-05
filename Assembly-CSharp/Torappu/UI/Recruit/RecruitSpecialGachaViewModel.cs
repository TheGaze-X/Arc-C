using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004767 RID: 18279
	[Token(Token = "0x2004767")]
	public class RecruitSpecialGachaViewModel : IHotfixable
	{
		// Token: 0x0601BAE1 RID: 113377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE1")]
		[Address(RVA = "0x151DFB0", Offset = "0x151CBB0", VA = "0x18151DFB0")]
		public void LoadData(GachaPoolClientData clientData)
		{
		}

		// Token: 0x0601BAE2 RID: 113378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE2")]
		[Address(RVA = "0x151E2C0", Offset = "0x151CEC0", VA = "0x18151E2C0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601BAE3 RID: 113379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE3")]
		[Address(RVA = "0x151E850", Offset = "0x151D450", VA = "0x18151E850")]
		private void _RefreshGachaPolicy()
		{
		}

		// Token: 0x0601BAE4 RID: 113380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE4")]
		[Address(RVA = "0x151E6B0", Offset = "0x151D2B0", VA = "0x18151E6B0")]
		private void _AddSelectCharIdList(JObjectWrapper charDict, RarityRank rank)
		{
		}

		// Token: 0x0601BAE5 RID: 113381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE5")]
		[Address(RVA = "0x151EA40", Offset = "0x151D640", VA = "0x18151EA40")]
		public RecruitSpecialGachaViewModel()
		{
		}

		// Token: 0x04023F3A RID: 147258
		[Token(Token = "0x4023F3A")]
		public const string CHAR_DICT_KEY = "rarityPickCharDict";

		// Token: 0x04023F3B RID: 147259
		[Token(Token = "0x4023F3B")]
		private const string DETAIL_TITLE_KEY = "detailTitle";

		// Token: 0x04023F3C RID: 147260
		[Token(Token = "0x4023F3C")]
		private const string DETAIL_INFO_KEY = "detailInfo";

		// Token: 0x04023F3D RID: 147261
		[Token(Token = "0x4023F3D")]
		private const string HOME_INTRO_KEY = "homeIntroDesc";

		// Token: 0x04023F3E RID: 147262
		[Token(Token = "0x4023F3E")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04023F3F RID: 147263
		[Token(Token = "0x4023F3F")]
		[FieldOffset(Offset = "0x18")]
		public string detailTitle;

		// Token: 0x04023F40 RID: 147264
		[Token(Token = "0x4023F40")]
		[FieldOffset(Offset = "0x20")]
		public string detailInfo;

		// Token: 0x04023F41 RID: 147265
		[Token(Token = "0x4023F41")]
		[FieldOffset(Offset = "0x28")]
		public string homeIntroDesc;

		// Token: 0x04023F42 RID: 147266
		[Token(Token = "0x4023F42")]
		[FieldOffset(Offset = "0x30")]
		public RecruitSpecialGachaViewModel.Status status;

		// Token: 0x04023F43 RID: 147267
		[Token(Token = "0x4023F43")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, List<string>> selectCharIdDict;

		// Token: 0x04023F44 RID: 147268
		[Token(Token = "0x4023F44")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, List<string>> selectedCharIdDict;

		// Token: 0x04023F45 RID: 147269
		[Token(Token = "0x4023F45")]
		[FieldOffset(Offset = "0x48")]
		public bool commonSingleTkt;

		// Token: 0x04023F46 RID: 147270
		[Token(Token = "0x4023F46")]
		[FieldOffset(Offset = "0x49")]
		public bool diamondSingle;

		// Token: 0x04023F47 RID: 147271
		[Token(Token = "0x4023F47")]
		[FieldOffset(Offset = "0x4A")]
		public bool commonTenTkt;

		// Token: 0x04023F48 RID: 147272
		[Token(Token = "0x4023F48")]
		[FieldOffset(Offset = "0x4B")]
		public bool commonTenSingleTkt;

		// Token: 0x04023F49 RID: 147273
		[Token(Token = "0x4023F49")]
		[FieldOffset(Offset = "0x4C")]
		public bool diamondTen;

		// Token: 0x04023F4A RID: 147274
		[Token(Token = "0x4023F4A")]
		[FieldOffset(Offset = "0x4D")]
		public bool hasRemainFlag;

		// Token: 0x04023F4B RID: 147275
		[Token(Token = "0x4023F4B")]
		[FieldOffset(Offset = "0x50")]
		public int remainCnt;

		// Token: 0x04023F4C RID: 147276
		[Token(Token = "0x4023F4C")]
		[FieldOffset(Offset = "0x54")]
		public int advancedGachaCrystalCost;

		// Token: 0x04023F4D RID: 147277
		[Token(Token = "0x4023F4D")]
		[FieldOffset(Offset = "0x58")]
		private int m_guarantee5Avail;

		// Token: 0x04023F4E RID: 147278
		[Token(Token = "0x4023F4E")]
		[FieldOffset(Offset = "0x5C")]
		private int m_guarantee5Count;

		// Token: 0x04023F4F RID: 147279
		[Token(Token = "0x4023F4F")]
		[FieldOffset(Offset = "0x60")]
		public string gachaPoolName;

		// Token: 0x04023F50 RID: 147280
		[Token(Token = "0x4023F50")]
		[FieldOffset(Offset = "0x68")]
		public string gachaPoolSummary;

		// Token: 0x04023F51 RID: 147281
		[Token(Token = "0x4023F51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023F52 RID: 147282
		[Token(Token = "0x4023F52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04023F53 RID: 147283
		[Token(Token = "0x4023F53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshGachaPolicy;

		// Token: 0x04023F54 RID: 147284
		[Token(Token = "0x4023F54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddSelectCharIdList;

		// Token: 0x04023F55 RID: 147285
		[Token(Token = "0x4023F55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004768 RID: 18280
		[Token(Token = "0x2004768")]
		public enum Status
		{
			// Token: 0x04023F57 RID: 147287
			[Token(Token = "0x4023F57")]
			INIT_VIEW,
			// Token: 0x04023F58 RID: 147288
			[Token(Token = "0x4023F58")]
			GACHA_VIEW
		}
	}
}
