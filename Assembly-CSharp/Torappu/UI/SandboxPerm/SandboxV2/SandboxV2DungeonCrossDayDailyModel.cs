using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200419C RID: 16796
	[Token(Token = "0x200419C")]
	public class SandboxV2DungeonCrossDayDailyModel : IHotfixable
	{
		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x06019E8A RID: 106122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DB8")]
		public List<List<Sprite>> expeditionSquadData
		{
			[Token(Token = "0x6019E8A")]
			[Address(RVA = "0x12C20B0", Offset = "0x12C0CB0", VA = "0x1812C20B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x06019E8B RID: 106123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DB9")]
		public List<SandboxV2DungeonCrossDayReportItemModel> expeditionRewardItemList
		{
			[Token(Token = "0x6019E8B")]
			[Address(RVA = "0x12C2050", Offset = "0x12C0C50", VA = "0x1812C2050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x06019E8C RID: 106124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DBA")]
		public List<SandboxV2DungeonCrossDayReportItemModel> baseProductItemList
		{
			[Token(Token = "0x6019E8C")]
			[Address(RVA = "0x12C1FF0", Offset = "0x12C0BF0", VA = "0x1812C1FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019E8D RID: 106125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E8D")]
		[Address(RVA = "0x12C0E60", Offset = "0x12BFA60", VA = "0x1812C0E60")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2.Status playerStatus, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x06019E8E RID: 106126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E8E")]
		[Address(RVA = "0x12C17B0", Offset = "0x12C03B0", VA = "0x1812C17B0")]
		private void _GetSortedReportItemList(ref List<SandboxV2DungeonCrossDayReportItemModel> resultList, List<PlayerSandboxV2.Dungeon.ReportGainItem> reportGainItems, Dictionary<string, SandboxPermItemData> sandboxPermItemData)
		{
		}

		// Token: 0x06019E8F RID: 106127 RVA: 0x0009FB10 File Offset: 0x0009DD10
		[Token(Token = "0x6019E8F")]
		[Address(RVA = "0x12C1B90", Offset = "0x12C0790", VA = "0x1812C1B90")]
		private int _ItemSort(SandboxV2DungeonCrossDayReportItemModel a, SandboxV2DungeonCrossDayReportItemModel b)
		{
			return 0;
		}

		// Token: 0x06019E90 RID: 106128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E90")]
		[Address(RVA = "0x12C1EB0", Offset = "0x12C0AB0", VA = "0x1812C1EB0")]
		public SandboxV2DungeonCrossDayDailyModel()
		{
		}

		// Token: 0x04020964 RID: 133476
		[Token(Token = "0x4020964")]
		[FieldOffset(Offset = "0x10")]
		public bool showLongAnim;

		// Token: 0x04020965 RID: 133477
		[Token(Token = "0x4020965")]
		[FieldOffset(Offset = "0x11")]
		public bool showHasRead;

		// Token: 0x04020966 RID: 133478
		[Token(Token = "0x4020966")]
		[FieldOffset(Offset = "0x12")]
		public bool showHasSave;

		// Token: 0x04020967 RID: 133479
		[Token(Token = "0x4020967")]
		[FieldOffset(Offset = "0x13")]
		public bool showSeasonChangeInfo;

		// Token: 0x04020968 RID: 133480
		[Token(Token = "0x4020968")]
		[FieldOffset(Offset = "0x14")]
		public SandboxV2SeasonType seasonType;

		// Token: 0x04020969 RID: 133481
		[Token(Token = "0x4020969")]
		[FieldOffset(Offset = "0x18")]
		public string seasonTitle;

		// Token: 0x0402096A RID: 133482
		[Token(Token = "0x402096A")]
		[FieldOffset(Offset = "0x20")]
		public string seasonDesc;

		// Token: 0x0402096B RID: 133483
		[Token(Token = "0x402096B")]
		[FieldOffset(Offset = "0x28")]
		public Color seasonCol;

		// Token: 0x0402096C RID: 133484
		[Token(Token = "0x402096C")]
		[FieldOffset(Offset = "0x38")]
		public int circleDayBefore;

		// Token: 0x0402096D RID: 133485
		[Token(Token = "0x402096D")]
		[FieldOffset(Offset = "0x3C")]
		public int circleDayAfter;

		// Token: 0x0402096E RID: 133486
		[Token(Token = "0x402096E")]
		[FieldOffset(Offset = "0x40")]
		public bool showDayCircleSeasonInfo;

		// Token: 0x0402096F RID: 133487
		[Token(Token = "0x402096F")]
		[FieldOffset(Offset = "0x44")]
		public float circleSeasonBeforeAngle;

		// Token: 0x04020970 RID: 133488
		[Token(Token = "0x4020970")]
		[FieldOffset(Offset = "0x48")]
		public float circleSeasonAfterAngle;

		// Token: 0x04020971 RID: 133489
		[Token(Token = "0x4020971")]
		[FieldOffset(Offset = "0x4C")]
		public int circleMaxApDotCount;

		// Token: 0x04020972 RID: 133490
		[Token(Token = "0x4020972")]
		[FieldOffset(Offset = "0x50")]
		public bool showCircleDayText;

		// Token: 0x04020973 RID: 133491
		[Token(Token = "0x4020973")]
		[FieldOffset(Offset = "0x58")]
		public string circleDayTitleText;

		// Token: 0x04020974 RID: 133492
		[Token(Token = "0x4020974")]
		[FieldOffset(Offset = "0x60")]
		public bool showCircleDaySaveFilePic;

		// Token: 0x04020975 RID: 133493
		[Token(Token = "0x4020975")]
		[FieldOffset(Offset = "0x61")]
		public bool showCircleDayRiftPic;

		// Token: 0x04020976 RID: 133494
		[Token(Token = "0x4020976")]
		[FieldOffset(Offset = "0x62")]
		public bool showCircleDayRiftTotal;

		// Token: 0x04020977 RID: 133495
		[Token(Token = "0x4020977")]
		[FieldOffset(Offset = "0x64")]
		public int circleDayRiftTotal;

		// Token: 0x04020978 RID: 133496
		[Token(Token = "0x4020978")]
		[FieldOffset(Offset = "0x68")]
		public bool showCircleDayChallengePic;

		// Token: 0x04020979 RID: 133497
		[Token(Token = "0x4020979")]
		[FieldOffset(Offset = "0x69")]
		public bool showBaseProductPart;

		// Token: 0x0402097A RID: 133498
		[Token(Token = "0x402097A")]
		[FieldOffset(Offset = "0x6A")]
		public bool showExpeditionPart;

		// Token: 0x0402097B RID: 133499
		[Token(Token = "0x402097B")]
		[FieldOffset(Offset = "0x6B")]
		public bool isRift;

		// Token: 0x0402097C RID: 133500
		[Token(Token = "0x402097C")]
		[FieldOffset(Offset = "0x6C")]
		public bool isChallenge;

		// Token: 0x0402097D RID: 133501
		[Token(Token = "0x402097D")]
		[FieldOffset(Offset = "0x6D")]
		public bool isFirstDay;

		// Token: 0x0402097E RID: 133502
		[Token(Token = "0x402097E")]
		[FieldOffset(Offset = "0x70")]
		private List<List<Sprite>> m_expeditionSquadData;

		// Token: 0x0402097F RID: 133503
		[Token(Token = "0x402097F")]
		[FieldOffset(Offset = "0x78")]
		private List<SandboxV2DungeonCrossDayReportItemModel> m_expeditionRewardItemList;

		// Token: 0x04020980 RID: 133504
		[Token(Token = "0x4020980")]
		[FieldOffset(Offset = "0x80")]
		private List<SandboxV2DungeonCrossDayReportItemModel> m_baseProductItemList;

		// Token: 0x04020981 RID: 133505
		[Token(Token = "0x4020981")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_expeditionSquadData;

		// Token: 0x04020982 RID: 133506
		[Token(Token = "0x4020982")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_expeditionRewardItemList;

		// Token: 0x04020983 RID: 133507
		[Token(Token = "0x4020983")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_baseProductItemList;

		// Token: 0x04020984 RID: 133508
		[Token(Token = "0x4020984")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020985 RID: 133509
		[Token(Token = "0x4020985")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSortedReportItemList;

		// Token: 0x04020986 RID: 133510
		[Token(Token = "0x4020986")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ItemSort;

		// Token: 0x04020987 RID: 133511
		[Token(Token = "0x4020987")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
