using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004186 RID: 16774
	[Token(Token = "0x2004186")]
	public class SandboxV2DungeonCrossDayCalcDetailDialog : UICompDialog<SandboxV2DungeonCrossDayCalcDetailDialog.Options>
	{
		// Token: 0x06019E17 RID: 106007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E17")]
		[Address(RVA = "0x12BEF20", Offset = "0x12BDB20", VA = "0x1812BEF20", Slot = "18")]
		protected override void OnRender(SandboxV2DungeonCrossDayCalcDetailDialog.Options options)
		{
		}

		// Token: 0x06019E18 RID: 106008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019E18")]
		[Address(RVA = "0x12BEAC0", Offset = "0x12BD6C0", VA = "0x1812BEAC0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019E19 RID: 106009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E19")]
		[Address(RVA = "0x12BEBE0", Offset = "0x12BD7E0", VA = "0x1812BEBE0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06019E1A RID: 106010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1A")]
		[Address(RVA = "0x12BF2F0", Offset = "0x12BDEF0", VA = "0x1812BF2F0")]
		private void _LoadData(string topicId, SandboxV2DungeonCrossDaySettleCalcModel baseData)
		{
		}

		// Token: 0x06019E1B RID: 106011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1B")]
		[Address(RVA = "0x12BF870", Offset = "0x12BE470", VA = "0x1812BF870")]
		private void _RefreshBaseInfoList()
		{
		}

		// Token: 0x06019E1C RID: 106012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1C")]
		[Address(RVA = "0x12BFBE0", Offset = "0x12BE7E0", VA = "0x1812BFBE0")]
		private void _RefreshEnemyInfoList(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon.ReportSettle settle)
		{
		}

		// Token: 0x06019E1D RID: 106013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1D")]
		[Address(RVA = "0x12C0410", Offset = "0x12BF010", VA = "0x1812C0410")]
		private void _RefreshHomeInfoList(PlayerSandboxV2.Dungeon playerDungeonData, SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon.ReportSettle settle)
		{
		}

		// Token: 0x06019E1E RID: 106014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1E")]
		[Address(RVA = "0x12C0310", Offset = "0x12BEF10", VA = "0x1812C0310")]
		private void _RefreshEnemyRush(SandboxV2EnemyRushTypeData data, string otherName, int killCount, int score)
		{
		}

		// Token: 0x06019E1F RID: 106015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E1F")]
		[Address(RVA = "0x12C0110", Offset = "0x12BED10", VA = "0x1812C0110")]
		private void _RefreshEnemyRushData(SandboxV2DungeonCrossDayEnemyRushType type, string name, int killCount, int score)
		{
		}

		// Token: 0x06019E20 RID: 106016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E20")]
		[Address(RVA = "0x12BEB20", Offset = "0x12BD720", VA = "0x1812BEB20")]
		public void OnBackEvent()
		{
		}

		// Token: 0x06019E21 RID: 106017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E21")]
		[Address(RVA = "0x12C0A50", Offset = "0x12BF650", VA = "0x1812C0A50")]
		public SandboxV2DungeonCrossDayCalcDetailDialog()
		{
		}

		// Token: 0x06019E22 RID: 106018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019E22")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019E23 RID: 106019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E23")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402088A RID: 133258
		[Token(Token = "0x402088A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x0402088B RID: 133259
		[Token(Token = "0x402088B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtSurviveTitle;

		// Token: 0x0402088C RID: 133260
		[Token(Token = "0x402088C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtSurviveDay;

		// Token: 0x0402088D RID: 133261
		[Token(Token = "0x402088D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _baseInfoContent;

		// Token: 0x0402088E RID: 133262
		[Token(Token = "0x402088E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _enemyRushInfoContent;

		// Token: 0x0402088F RID: 133263
		[Token(Token = "0x402088F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SimpleLayoutContent _homeInfoContent;

		// Token: 0x04020890 RID: 133264
		[Token(Token = "0x4020890")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _txtRatioTitle;

		// Token: 0x04020891 RID: 133265
		[Token(Token = "0x4020891")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _txtRatio;

		// Token: 0x04020892 RID: 133266
		[Token(Token = "0x4020892")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _txtRatioInfo;

		// Token: 0x04020893 RID: 133267
		[Token(Token = "0x4020893")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _txtRatioScore;

		// Token: 0x04020894 RID: 133268
		[Token(Token = "0x4020894")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objExploreAll;

		// Token: 0x04020895 RID: 133269
		[Token(Token = "0x4020895")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _txtExploreAllTips;

		// Token: 0x04020896 RID: 133270
		[Token(Token = "0x4020896")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _objExploring;

		// Token: 0x04020897 RID: 133271
		[Token(Token = "0x4020897")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _txtExploringTitle;

		// Token: 0x04020898 RID: 133272
		[Token(Token = "0x4020898")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _txtExploringScore;

		// Token: 0x04020899 RID: 133273
		[Token(Token = "0x4020899")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _objRift;

		// Token: 0x0402089A RID: 133274
		[Token(Token = "0x402089A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _objRiftNotGoingTips;

		// Token: 0x0402089B RID: 133275
		[Token(Token = "0x402089B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _txtRiftNotGoingTips;

		// Token: 0x0402089C RID: 133276
		[Token(Token = "0x402089C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _objRiftGoing;

		// Token: 0x0402089D RID: 133277
		[Token(Token = "0x402089D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _txtRiftGoingTitle;

		// Token: 0x0402089E RID: 133278
		[Token(Token = "0x402089E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text _txtRiftGoingScore;

		// Token: 0x0402089F RID: 133279
		[Token(Token = "0x402089F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text _txtSurvivalTotalScoreTitle;

		// Token: 0x040208A0 RID: 133280
		[Token(Token = "0x40208A0")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Text _txtSurvivalTotalScore;

		// Token: 0x040208A1 RID: 133281
		[Token(Token = "0x40208A1")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040208A2 RID: 133282
		[Token(Token = "0x40208A2")]
		[FieldOffset(Offset = "0x130")]
		private SandboxV2DungeonCrossDayCalcDetailDialog.Options m_options;

		// Token: 0x040208A3 RID: 133283
		[Token(Token = "0x40208A3")]
		[FieldOffset(Offset = "0x138")]
		private string m_dayRewardScoreTitle;

		// Token: 0x040208A4 RID: 133284
		[Token(Token = "0x40208A4")]
		[FieldOffset(Offset = "0x140")]
		private int m_dayRewardScore;

		// Token: 0x040208A5 RID: 133285
		[Token(Token = "0x40208A5")]
		[FieldOffset(Offset = "0x148")]
		private string m_actionRewardTitle;

		// Token: 0x040208A6 RID: 133286
		[Token(Token = "0x40208A6")]
		[FieldOffset(Offset = "0x150")]
		private int m_actionRewardScore;

		// Token: 0x040208A7 RID: 133287
		[Token(Token = "0x40208A7")]
		[FieldOffset(Offset = "0x158")]
		private string m_tacticalTitle;

		// Token: 0x040208A8 RID: 133288
		[Token(Token = "0x40208A8")]
		[FieldOffset(Offset = "0x160")]
		private int m_tacticalScore;

		// Token: 0x040208A9 RID: 133289
		[Token(Token = "0x40208A9")]
		[FieldOffset(Offset = "0x168")]
		private string m_foodTitle;

		// Token: 0x040208AA RID: 133290
		[Token(Token = "0x40208AA")]
		[FieldOffset(Offset = "0x170")]
		private int m_foodScore;

		// Token: 0x040208AB RID: 133291
		[Token(Token = "0x40208AB")]
		[FieldOffset(Offset = "0x178")]
		private SandboxV2DungeonCrossDayCalcDetailDialog.Adapter m_baseInfoAdapter;

		// Token: 0x040208AC RID: 133292
		[Token(Token = "0x40208AC")]
		[FieldOffset(Offset = "0x180")]
		private SandboxV2DungeonCrossDayCalcDetailDialog.Adapter m_enemyRushInfoAdapter;

		// Token: 0x040208AD RID: 133293
		[Token(Token = "0x40208AD")]
		[FieldOffset(Offset = "0x188")]
		private SandboxV2DungeonCrossDayCalcDetailDialog.Adapter m_homeInfoAdapter;

		// Token: 0x040208AE RID: 133294
		[Token(Token = "0x40208AE")]
		[FieldOffset(Offset = "0x190")]
		private string m_ratioTitle;

		// Token: 0x040208AF RID: 133295
		[Token(Token = "0x40208AF")]
		[FieldOffset(Offset = "0x198")]
		private string m_ratioCount;

		// Token: 0x040208B0 RID: 133296
		[Token(Token = "0x40208B0")]
		[FieldOffset(Offset = "0x1A0")]
		private string m_ratioTips;

		// Token: 0x040208B1 RID: 133297
		[Token(Token = "0x40208B1")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_ratioScore;

		// Token: 0x040208B2 RID: 133298
		[Token(Token = "0x40208B2")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_exploreNodeScore;

		// Token: 0x040208B3 RID: 133299
		[Token(Token = "0x40208B3")]
		[FieldOffset(Offset = "0x1B0")]
		private bool m_exploreNodeComplete;

		// Token: 0x040208B4 RID: 133300
		[Token(Token = "0x40208B4")]
		[FieldOffset(Offset = "0x1B8")]
		private string m_exploreNodeCompleteTips;

		// Token: 0x040208B5 RID: 133301
		[Token(Token = "0x40208B5")]
		[FieldOffset(Offset = "0x1C0")]
		private string m_exploreNodeTips;

		// Token: 0x040208B6 RID: 133302
		[Token(Token = "0x40208B6")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_isRiftUnlocked;

		// Token: 0x040208B7 RID: 133303
		[Token(Token = "0x40208B7")]
		[FieldOffset(Offset = "0x1C9")]
		private bool m_hasRift;

		// Token: 0x040208B8 RID: 133304
		[Token(Token = "0x40208B8")]
		[FieldOffset(Offset = "0x1D0")]
		private string m_noRiftTips;

		// Token: 0x040208B9 RID: 133305
		[Token(Token = "0x40208B9")]
		[FieldOffset(Offset = "0x1D8")]
		private string m_riftTitle;

		// Token: 0x040208BA RID: 133306
		[Token(Token = "0x40208BA")]
		[FieldOffset(Offset = "0x1E0")]
		private int m_riftTotalScore;

		// Token: 0x040208BB RID: 133307
		[Token(Token = "0x40208BB")]
		[FieldOffset(Offset = "0x1E8")]
		private string m_survivalTotalTitle;

		// Token: 0x040208BC RID: 133308
		[Token(Token = "0x40208BC")]
		[FieldOffset(Offset = "0x1F0")]
		private int m_survivalTotalScore;

		// Token: 0x040208BD RID: 133309
		[Token(Token = "0x40208BD")]
		[FieldOffset(Offset = "0x1F8")]
		private ListDict<SandboxV2DungeonCrossDayEnemyRushType, SandboxV2DungeonCrossDayEnemyRushData> m_enemyRushInfoData;

		// Token: 0x040208BE RID: 133310
		[Token(Token = "0x40208BE")]
		[FieldOffset(Offset = "0x200")]
		private List<SandboxV2DungeonCrossDayHomeData> m_homeInfoData;

		// Token: 0x040208BF RID: 133311
		[Token(Token = "0x40208BF")]
		[FieldOffset(Offset = "0x208")]
		private List<SandboxV2DungeonCrossDayCalcDetailItemModel> m_enemyRushItemList;

		// Token: 0x040208C0 RID: 133312
		[Token(Token = "0x40208C0")]
		[FieldOffset(Offset = "0x210")]
		private List<SandboxV2DungeonCrossDayCalcDetailItemModel> m_homeItemList;

		// Token: 0x040208C1 RID: 133313
		[Token(Token = "0x40208C1")]
		[FieldOffset(Offset = "0x218")]
		private List<SandboxV2DungeonCrossDayCalcDetailItemModel> m_baseItemList;

		// Token: 0x040208C2 RID: 133314
		[Token(Token = "0x40208C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040208C3 RID: 133315
		[Token(Token = "0x40208C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040208C4 RID: 133316
		[Token(Token = "0x40208C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040208C5 RID: 133317
		[Token(Token = "0x40208C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040208C6 RID: 133318
		[Token(Token = "0x40208C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshBaseInfoList;

		// Token: 0x040208C7 RID: 133319
		[Token(Token = "0x40208C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshEnemyInfoList;

		// Token: 0x040208C8 RID: 133320
		[Token(Token = "0x40208C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshHomeInfoList;

		// Token: 0x040208C9 RID: 133321
		[Token(Token = "0x40208C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshEnemyRush;

		// Token: 0x040208CA RID: 133322
		[Token(Token = "0x40208CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshEnemyRushData;

		// Token: 0x040208CB RID: 133323
		[Token(Token = "0x40208CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x040208CC RID: 133324
		[Token(Token = "0x40208CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004187 RID: 16775
		[Token(Token = "0x2004187")]
		public class Options
		{
			// Token: 0x06019E24 RID: 106020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019E24")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040208CD RID: 133325
			[Token(Token = "0x40208CD")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x040208CE RID: 133326
			[Token(Token = "0x40208CE")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2DungeonCrossDaySettleCalcModel calcBaseData;
		}

		// Token: 0x02004188 RID: 16776
		[Token(Token = "0x2004188")]
		private enum BASE_ITEM_SORT_ORDER_TYPE
		{
			// Token: 0x040208D0 RID: 133328
			[Token(Token = "0x40208D0")]
			SURVIVE,
			// Token: 0x040208D1 RID: 133329
			[Token(Token = "0x40208D1")]
			ACTION,
			// Token: 0x040208D2 RID: 133330
			[Token(Token = "0x40208D2")]
			TACTICAL,
			// Token: 0x040208D3 RID: 133331
			[Token(Token = "0x40208D3")]
			FOOD
		}

		// Token: 0x02004189 RID: 16777
		[Token(Token = "0x2004189")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003DA3 RID: 15779
			// (get) Token: 0x06019E25 RID: 106021 RVA: 0x0009F9C0 File Offset: 0x0009DBC0
			[Token(Token = "0x17003DA3")]
			public override int count
			{
				[Token(Token = "0x6019E25")]
				[Address(RVA = "0x12B7070", Offset = "0x12B5C70", VA = "0x1812B7070", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019E26 RID: 106022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019E26")]
			[Address(RVA = "0x12B6DA0", Offset = "0x12B59A0", VA = "0x1812B6DA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019E27 RID: 106023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019E27")]
			[Address(RVA = "0x12B7010", Offset = "0x12B5C10", VA = "0x1812B7010")]
			public Adapter()
			{
			}

			// Token: 0x040208D4 RID: 133332
			[Token(Token = "0x40208D4")]
			[FieldOffset(Offset = "0x20")]
			public List<SandboxV2DungeonCrossDayCalcDetailItemModel> items;

			// Token: 0x040208D5 RID: 133333
			[Token(Token = "0x40208D5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040208D6 RID: 133334
			[Token(Token = "0x40208D6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040208D7 RID: 133335
			[Token(Token = "0x40208D7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
