using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.AutoChess;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070F3 RID: 28915
	[Token(Token = "0x20070F3")]
	public class ActAutoChessEntryViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x060291A1 RID: 168353 RVA: 0x000D47A8 File Offset: 0x000D29A8
		[Token(Token = "0x17006161")]
		public long singleRemainTs
		{
			[Token(Token = "0x60291A1")]
			[Address(RVA = "0x24820E0", Offset = "0x2480CE0", VA = "0x1824820E0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x060291A2 RID: 168354 RVA: 0x000D47C0 File Offset: 0x000D29C0
		[Token(Token = "0x17006162")]
		public long singleSettleTs
		{
			[Token(Token = "0x60291A2")]
			[Address(RVA = "0x2482170", Offset = "0x2480D70", VA = "0x182482170")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x060291A3 RID: 168355 RVA: 0x000D47D8 File Offset: 0x000D29D8
		[Token(Token = "0x17006163")]
		public long multiRemainTs
		{
			[Token(Token = "0x60291A3")]
			[Address(RVA = "0x2482050", Offset = "0x2480C50", VA = "0x182482050")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x060291A4 RID: 168356 RVA: 0x000D47F0 File Offset: 0x000D29F0
		[Token(Token = "0x17006164")]
		public bool hasAlertsNeedShow
		{
			[Token(Token = "0x60291A4")]
			[Address(RVA = "0x2481FE0", Offset = "0x2480BE0", VA = "0x182481FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060291A5 RID: 168357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291A5")]
		[Address(RVA = "0x2481B60", Offset = "0x2480760", VA = "0x182481B60")]
		public ActAutoChessEntryViewModel(object param)
		{
		}

		// Token: 0x060291A6 RID: 168358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291A6")]
		[Address(RVA = "0x2481290", Offset = "0x247FE90", VA = "0x182481290")]
		public void RefreshPlayerData(List<string> chessShopChanged, ActAutoChessSyncInfoBattleInfo info)
		{
		}

		// Token: 0x060291A7 RID: 168359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291A7")]
		[Address(RVA = "0x2481340", Offset = "0x247FF40", VA = "0x182481340")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x060291A8 RID: 168360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291A8")]
		[Address(RVA = "0x24818A0", Offset = "0x24804A0", VA = "0x1824818A0")]
		public void ResetChessShopChangeAlertFlag()
		{
		}

		// Token: 0x060291A9 RID: 168361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291A9")]
		[Address(RVA = "0x2481940", Offset = "0x2480540", VA = "0x182481940")]
		public void ResetMultiMatchBanAlertFlag()
		{
		}

		// Token: 0x060291AA RID: 168362 RVA: 0x000D4808 File Offset: 0x000D2A08
		[Token(Token = "0x60291AA")]
		[Address(RVA = "0x24819A0", Offset = "0x24805A0", VA = "0x1824819A0")]
		private bool _CheckIfNeedShowChessShopChangeAlert()
		{
			return default(bool);
		}

		// Token: 0x060291AB RID: 168363 RVA: 0x000D4820 File Offset: 0x000D2A20
		[Token(Token = "0x60291AB")]
		[Address(RVA = "0x2481A60", Offset = "0x2480660", VA = "0x182481A60")]
		private bool _CheckIfNeedShowMatchBanAlert()
		{
			return default(bool);
		}

		// Token: 0x0403AAA8 RID: 240296
		[Token(Token = "0x403AAA8")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403AAA9 RID: 240297
		[Token(Token = "0x403AAA9")]
		[FieldOffset(Offset = "0x28")]
		public ActAutoChessEntryViewModel.Status status;

		// Token: 0x0403AAAA RID: 240298
		[Token(Token = "0x403AAAA")]
		[FieldOffset(Offset = "0x30")]
		public string medalIconId;

		// Token: 0x0403AAAB RID: 240299
		[Token(Token = "0x403AAAB")]
		[FieldOffset(Offset = "0x38")]
		public int medalCount;

		// Token: 0x0403AAAC RID: 240300
		[Token(Token = "0x403AAAC")]
		[FieldOffset(Offset = "0x40")]
		public long multiModeProtectTs;

		// Token: 0x0403AAAD RID: 240301
		[Token(Token = "0x403AAAD")]
		[FieldOffset(Offset = "0x48")]
		public bool isWaitRetry;

		// Token: 0x0403AAAE RID: 240302
		[Token(Token = "0x403AAAE")]
		[FieldOffset(Offset = "0x49")]
		public bool isRetryGameEnd;

		// Token: 0x0403AAAF RID: 240303
		[Token(Token = "0x403AAAF")]
		[FieldOffset(Offset = "0x4A")]
		public bool isSingleMode;

		// Token: 0x0403AAB0 RID: 240304
		[Token(Token = "0x403AAB0")]
		[FieldOffset(Offset = "0x4B")]
		public bool isDailyMissionComplete;

		// Token: 0x0403AAB1 RID: 240305
		[Token(Token = "0x403AAB1")]
		[FieldOffset(Offset = "0x4C")]
		public float dailyMissionProgress;

		// Token: 0x0403AAB2 RID: 240306
		[Token(Token = "0x403AAB2")]
		[FieldOffset(Offset = "0x50")]
		private long m_singleModeEndTs;

		// Token: 0x0403AAB3 RID: 240307
		[Token(Token = "0x403AAB3")]
		[FieldOffset(Offset = "0x58")]
		private long m_singleModeProtectTs;

		// Token: 0x0403AAB4 RID: 240308
		[Token(Token = "0x403AAB4")]
		[FieldOffset(Offset = "0x60")]
		private int m_dailyMissionTarget;

		// Token: 0x0403AAB5 RID: 240309
		[Token(Token = "0x403AAB5")]
		[FieldOffset(Offset = "0x68")]
		private List<AutoChessMedalInfoModel> m_medalModelList;

		// Token: 0x0403AAB6 RID: 240310
		[Token(Token = "0x403AAB6")]
		[FieldOffset(Offset = "0x70")]
		private long m_singleModeReconnectTime;

		// Token: 0x0403AAB7 RID: 240311
		[Token(Token = "0x403AAB7")]
		[FieldOffset(Offset = "0x78")]
		public ActAutoChessSyncInfoBattleInfo battleInfo;

		// Token: 0x0403AAB8 RID: 240312
		[Token(Token = "0x403AAB8")]
		[FieldOffset(Offset = "0x80")]
		public List<string> chessPoolChangesList;

		// Token: 0x0403AAB9 RID: 240313
		[Token(Token = "0x403AAB9")]
		[FieldOffset(Offset = "0x88")]
		public bool hasChessShopChangeAlertNeedShow;

		// Token: 0x0403AABA RID: 240314
		[Token(Token = "0x403AABA")]
		[FieldOffset(Offset = "0x89")]
		public bool hasMultiMatchBanAlertNeedShow;

		// Token: 0x0403AABB RID: 240315
		[Token(Token = "0x403AABB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_singleRemainTs;

		// Token: 0x0403AABC RID: 240316
		[Token(Token = "0x403AABC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_singleSettleTs;

		// Token: 0x0403AABD RID: 240317
		[Token(Token = "0x403AABD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_multiRemainTs;

		// Token: 0x0403AABE RID: 240318
		[Token(Token = "0x403AABE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasAlertsNeedShow;

		// Token: 0x0403AABF RID: 240319
		[Token(Token = "0x403AABF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403AAC0 RID: 240320
		[Token(Token = "0x403AAC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403AAC1 RID: 240321
		[Token(Token = "0x403AAC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_RefreshPlayerData;

		// Token: 0x0403AAC2 RID: 240322
		[Token(Token = "0x403AAC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetChessShopChangeAlertFlag;

		// Token: 0x0403AAC3 RID: 240323
		[Token(Token = "0x403AAC3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetMultiMatchBanAlertFlag;

		// Token: 0x0403AAC4 RID: 240324
		[Token(Token = "0x403AAC4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfNeedShowChessShopChangeAlert;

		// Token: 0x0403AAC5 RID: 240325
		[Token(Token = "0x403AAC5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfNeedShowMatchBanAlert;

		// Token: 0x020070F4 RID: 28916
		[Token(Token = "0x20070F4")]
		public class Input
		{
			// Token: 0x060291AC RID: 168364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60291AC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403AAC6 RID: 240326
			[Token(Token = "0x403AAC6")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x020070F5 RID: 28917
		[Token(Token = "0x20070F5")]
		public enum Status
		{
			// Token: 0x0403AAC8 RID: 240328
			[Token(Token = "0x403AAC8")]
			TRAIN,
			// Token: 0x0403AAC9 RID: 240329
			[Token(Token = "0x403AAC9")]
			NORMAL,
			// Token: 0x0403AACA RID: 240330
			[Token(Token = "0x403AACA")]
			TIME_OUT
		}
	}
}
