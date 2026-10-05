using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Resource;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006157 RID: 24919
	[Token(Token = "0x2006157")]
	public class CampaignZoneSelectPreviewView : DataBinder<CampaignZoneMapProperty>, IHotfixable
	{
		// Token: 0x06023F80 RID: 147328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F80")]
		[Address(RVA = "0x1EAFB50", Offset = "0x1EAE750", VA = "0x181EAFB50")]
		private void OnEnable()
		{
		}

		// Token: 0x06023F81 RID: 147329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F81")]
		[Address(RVA = "0x1EB0F30", Offset = "0x1EAFB30", VA = "0x181EB0F30")]
		protected void _InitIfNot()
		{
		}

		// Token: 0x06023F82 RID: 147330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F82")]
		[Address(RVA = "0x1EAFAB0", Offset = "0x1EAE6B0", VA = "0x181EAFAB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023F83 RID: 147331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F83")]
		[Address(RVA = "0x1EAFFA0", Offset = "0x1EAEBA0", VA = "0x181EAFFA0")]
		public void OpenAutoTips()
		{
		}

		// Token: 0x06023F84 RID: 147332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F84")]
		[Address(RVA = "0x1EB0200", Offset = "0x1EAEE00", VA = "0x181EB0200")]
		public void OpenStarTips()
		{
		}

		// Token: 0x06023F85 RID: 147333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F85")]
		[Address(RVA = "0x1EB0120", Offset = "0x1EAED20", VA = "0x181EB0120")]
		public void OpenMapTips()
		{
		}

		// Token: 0x06023F86 RID: 147334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F86")]
		[Address(RVA = "0x1EAF6A0", Offset = "0x1EAE2A0", VA = "0x181EAF6A0")]
		public void CloseTips()
		{
		}

		// Token: 0x06023F87 RID: 147335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F87")]
		[Address(RVA = "0x1EAF750", Offset = "0x1EAE350", VA = "0x181EAF750")]
		public void EventOnCampaignBreakDetailsClick()
		{
		}

		// Token: 0x06023F88 RID: 147336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F88")]
		[Address(RVA = "0x1EAFA20", Offset = "0x1EAE620", VA = "0x181EAFA20")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x06023F89 RID: 147337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F89")]
		[Address(RVA = "0x1EAF990", Offset = "0x1EAE590", VA = "0x181EAF990")]
		public void EventOnRuleBtnClicked()
		{
		}

		// Token: 0x06023F8A RID: 147338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8A")]
		[Address(RVA = "0x1EAF900", Offset = "0x1EAE500", VA = "0x181EAF900")]
		public void EventOnRewardBtnClicked()
		{
		}

		// Token: 0x06023F8B RID: 147339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8B")]
		[Address(RVA = "0x1EAF870", Offset = "0x1EAE470", VA = "0x181EAF870")]
		public void EventOnEnemyBtnClicked()
		{
		}

		// Token: 0x06023F8C RID: 147340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8C")]
		[Address(RVA = "0x1EB1530", Offset = "0x1EB0130", VA = "0x181EB1530")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x06023F8D RID: 147341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8D")]
		[Address(RVA = "0x1EB0D10", Offset = "0x1EAF910", VA = "0x181EB0D10")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06023F8E RID: 147342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8E")]
		[Address(RVA = "0x1EB02E0", Offset = "0x1EAEEE0", VA = "0x181EB02E0")]
		protected void RefreshView(CampaignZoneMapStageViewModel selectedStageModel)
		{
		}

		// Token: 0x06023F8F RID: 147343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F8F")]
		[Address(RVA = "0x1EB14A0", Offset = "0x1EB00A0", VA = "0x181EB14A0")]
		private void _RenderCampaign(CampaignStateViewModel campViewModel)
		{
		}

		// Token: 0x06023F90 RID: 147344 RVA: 0x000C28E0 File Offset: 0x000C0AE0
		[Token(Token = "0x6023F90")]
		[Address(RVA = "0x1EAFCC0", Offset = "0x1EAE8C0", VA = "0x181EAFCC0")]
		protected bool OnZoneViewChanged(CampaignZoneMapStageViewModel selectedStageModel)
		{
			return default(bool);
		}

		// Token: 0x06023F91 RID: 147345 RVA: 0x000C28F8 File Offset: 0x000C0AF8
		[Token(Token = "0x6023F91")]
		[Address(RVA = "0x1EB09B0", Offset = "0x1EAF5B0", VA = "0x181EB09B0")]
		protected bool SelectStageViewModel(ZoneViewModel zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06023F92 RID: 147346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F92")]
		[Address(RVA = "0x1EB0080", Offset = "0x1EAEC80", VA = "0x181EB0080")]
		public void OpenCampaignImmediate()
		{
		}

		// Token: 0x06023F93 RID: 147347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F93")]
		[Address(RVA = "0x1EAF7E0", Offset = "0x1EAE3E0", VA = "0x181EAF7E0")]
		public void EventOnClosePreviewPanel()
		{
		}

		// Token: 0x06023F94 RID: 147348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F94")]
		[Address(RVA = "0x1EB0A80", Offset = "0x1EAF680", VA = "0x181EB0A80")]
		protected void UpdateAnimatorState(bool active)
		{
		}

		// Token: 0x06023F95 RID: 147349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F95")]
		[Address(RVA = "0x1EB10F0", Offset = "0x1EAFCF0", VA = "0x181EB10F0")]
		private Sprite[] _LoadSprites(string[] ids, SpriteHub spriteHub)
		{
			return null;
		}

		// Token: 0x06023F96 RID: 147350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F96")]
		[Address(RVA = "0x1EB15A0", Offset = "0x1EB01A0", VA = "0x181EB15A0")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x06023F97 RID: 147351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F97")]
		[Address(RVA = "0x1EB12D0", Offset = "0x1EAFED0", VA = "0x181EB12D0")]
		private void _LoadStagePreviewMap(string stageId)
		{
		}

		// Token: 0x06023F98 RID: 147352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F98")]
		[Address(RVA = "0x1EB0E10", Offset = "0x1EAFA10", VA = "0x181EB0E10")]
		private string _DisplayCostValueFormat(int value)
		{
			return null;
		}

		// Token: 0x06023F99 RID: 147353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F99")]
		[Address(RVA = "0x1EAFBF0", Offset = "0x1EAE7F0", VA = "0x181EAFBF0", Slot = "7")]
		public override void OnValueChanged(CampaignZoneMapProperty property)
		{
		}

		// Token: 0x06023F9A RID: 147354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F9A")]
		[Address(RVA = "0x1EB16B0", Offset = "0x1EB02B0", VA = "0x181EB16B0")]
		public CampaignZoneSelectPreviewView()
		{
		}

		// Token: 0x04031F43 RID: 204611
		[Token(Token = "0x4031F43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageTypeText;

		// Token: 0x04031F44 RID: 204612
		[Token(Token = "0x4031F44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageZoneText;

		// Token: 0x04031F45 RID: 204613
		[Token(Token = "0x4031F45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageNameText;

		// Token: 0x04031F46 RID: 204614
		[Token(Token = "0x4031F46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x04031F47 RID: 204615
		[Token(Token = "0x4031F47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _rewardGrid;

		// Token: 0x04031F48 RID: 204616
		[Token(Token = "0x4031F48")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imageMapPreview;

		// Token: 0x04031F49 RID: 204617
		[Token(Token = "0x4031F49")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _starTips;

		// Token: 0x04031F4A RID: 204618
		[Token(Token = "0x4031F4A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _autoTips;

		// Token: 0x04031F4B RID: 204619
		[Token(Token = "0x4031F4B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _mapTips;

		// Token: 0x04031F4C RID: 204620
		[Token(Token = "0x4031F4C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imageMapTips;

		// Token: 0x04031F4D RID: 204621
		[Token(Token = "0x4031F4D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textDangerDesc;

		// Token: 0x04031F4E RID: 204622
		[Token(Token = "0x4031F4E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _backTips;

		// Token: 0x04031F4F RID: 204623
		[Token(Token = "0x4031F4F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04031F50 RID: 204624
		[Token(Token = "0x4031F50")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _bossIcon;

		// Token: 0x04031F51 RID: 204625
		[Token(Token = "0x4031F51")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _btnStartBattleAp;

		// Token: 0x04031F52 RID: 204626
		[Token(Token = "0x4031F52")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _apCostText;

		// Token: 0x04031F53 RID: 204627
		[Token(Token = "0x4031F53")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _containerStartBattleEt;

		// Token: 0x04031F54 RID: 204628
		[Token(Token = "0x4031F54")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private StagePreviewCampaignSummaryInfoView _campaignPreviewInfo;

		// Token: 0x04031F55 RID: 204629
		[Token(Token = "0x4031F55")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _previewPage;

		// Token: 0x04031F56 RID: 204630
		[Token(Token = "0x4031F56")]
		[FieldOffset(Offset = "0xB8")]
		private SpriteHub m_enemySpineImageHub;

		// Token: 0x04031F57 RID: 204631
		[Token(Token = "0x4031F57")]
		[FieldOffset(Offset = "0xC0")]
		private SpriteHub m_itemIconHub;

		// Token: 0x04031F58 RID: 204632
		[Token(Token = "0x4031F58")]
		[FieldOffset(Offset = "0xC8")]
		private CampaignZoneSelectPreviewView.RewardPreviewAdapter m_rewardAdapter;

		// Token: 0x04031F59 RID: 204633
		[Token(Token = "0x4031F59")]
		[FieldOffset(Offset = "0xD0")]
		private StageStartBattleETButton m_btnStartBattleEt;

		// Token: 0x04031F5A RID: 204634
		[Token(Token = "0x4031F5A")]
		[FieldOffset(Offset = "0xD8")]
		private Sprite m_stagePreviewMap;

		// Token: 0x04031F5B RID: 204635
		[Token(Token = "0x4031F5B")]
		[FieldOffset(Offset = "0xE0")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x04031F5C RID: 204636
		[Token(Token = "0x4031F5C")]
		[FieldOffset(Offset = "0xE8")]
		private CampaignStateViewModel m_campViewModel;

		// Token: 0x04031F5D RID: 204637
		[Token(Token = "0x4031F5D")]
		[FieldOffset(Offset = "0xF0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031F5E RID: 204638
		[Token(Token = "0x4031F5E")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isInited;

		// Token: 0x04031F5F RID: 204639
		[Token(Token = "0x4031F5F")]
		[FieldOffset(Offset = "0x108")]
		protected string m_selectedStageIdCache;

		// Token: 0x04031F60 RID: 204640
		[Token(Token = "0x4031F60")]
		[FieldOffset(Offset = "0x110")]
		protected bool m_cacheState;

		// Token: 0x04031F61 RID: 204641
		[Token(Token = "0x4031F61")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_cacheTween;

		// Token: 0x04031F62 RID: 204642
		[Token(Token = "0x4031F62")]
		[FieldOffset(Offset = "0x120")]
		private bool m_autoOpenBreaking;

		// Token: 0x04031F63 RID: 204643
		[Token(Token = "0x4031F63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04031F64 RID: 204644
		[Token(Token = "0x4031F64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031F65 RID: 204645
		[Token(Token = "0x4031F65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04031F66 RID: 204646
		[Token(Token = "0x4031F66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenAutoTips;

		// Token: 0x04031F67 RID: 204647
		[Token(Token = "0x4031F67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenStarTips;

		// Token: 0x04031F68 RID: 204648
		[Token(Token = "0x4031F68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OpenMapTips;

		// Token: 0x04031F69 RID: 204649
		[Token(Token = "0x4031F69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CloseTips;

		// Token: 0x04031F6A RID: 204650
		[Token(Token = "0x4031F6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCampaignBreakDetailsClick;

		// Token: 0x04031F6B RID: 204651
		[Token(Token = "0x4031F6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x04031F6C RID: 204652
		[Token(Token = "0x4031F6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnRuleBtnClicked;

		// Token: 0x04031F6D RID: 204653
		[Token(Token = "0x4031F6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnRewardBtnClicked;

		// Token: 0x04031F6E RID: 204654
		[Token(Token = "0x4031F6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnEnemyBtnClicked;

		// Token: 0x04031F6F RID: 204655
		[Token(Token = "0x4031F6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x04031F70 RID: 204656
		[Token(Token = "0x4031F70")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x04031F71 RID: 204657
		[Token(Token = "0x4031F71")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04031F72 RID: 204658
		[Token(Token = "0x4031F72")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderCampaign;

		// Token: 0x04031F73 RID: 204659
		[Token(Token = "0x4031F73")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x04031F74 RID: 204660
		[Token(Token = "0x4031F74")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x04031F75 RID: 204661
		[Token(Token = "0x4031F75")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OpenCampaignImmediate;

		// Token: 0x04031F76 RID: 204662
		[Token(Token = "0x4031F76")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnClosePreviewPanel;

		// Token: 0x04031F77 RID: 204663
		[Token(Token = "0x4031F77")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_UpdateAnimatorState;

		// Token: 0x04031F78 RID: 204664
		[Token(Token = "0x4031F78")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadSprites;

		// Token: 0x04031F79 RID: 204665
		[Token(Token = "0x4031F79")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x04031F7A RID: 204666
		[Token(Token = "0x4031F7A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadStagePreviewMap;

		// Token: 0x04031F7B RID: 204667
		[Token(Token = "0x4031F7B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__DisplayCostValueFormat;

		// Token: 0x04031F7C RID: 204668
		[Token(Token = "0x4031F7C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031F7D RID: 204669
		[Token(Token = "0x4031F7D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006158 RID: 24920
		[Token(Token = "0x2006158")]
		private class RewardPreviewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170054DF RID: 21727
			// (get) Token: 0x06023F9B RID: 147355 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023F9C RID: 147356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054DF")]
			public List<StageRewardViewModel> cardModels
			{
				[Token(Token = "0x6023F9B")]
				[Address(RVA = "0x1EB1B20", Offset = "0x1EB0720", VA = "0x181EB1B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x6023F9C")]
				[Address(RVA = "0x1EB1C90", Offset = "0x1EB0890", VA = "0x181EB1C90")]
				set
				{
				}
			}

			// Token: 0x170054E0 RID: 21728
			// (get) Token: 0x06023F9D RID: 147357 RVA: 0x000C2910 File Offset: 0x000C0B10
			[Token(Token = "0x170054E0")]
			public override int count
			{
				[Token(Token = "0x6023F9D")]
				[Address(RVA = "0x1EB1B80", Offset = "0x1EB0780", VA = "0x181EB1B80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023F9E RID: 147358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023F9E")]
			[Address(RVA = "0x1EB1900", Offset = "0x1EB0500", VA = "0x181EB1900", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023F9F RID: 147359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F9F")]
			[Address(RVA = "0x1EB1AC0", Offset = "0x1EB06C0", VA = "0x181EB1AC0")]
			public RewardPreviewAdapter()
			{
			}

			// Token: 0x04031F7E RID: 204670
			[Token(Token = "0x4031F7E")]
			private const int MAX_ITEM_COUNT = 3;

			// Token: 0x04031F7F RID: 204671
			[Token(Token = "0x4031F7F")]
			[FieldOffset(Offset = "0x20")]
			private List<StageRewardViewModel> m_cardModels;

			// Token: 0x04031F80 RID: 204672
			[Token(Token = "0x4031F80")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardModels;

			// Token: 0x04031F81 RID: 204673
			[Token(Token = "0x4031F81")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_cardModels;

			// Token: 0x04031F82 RID: 204674
			[Token(Token = "0x4031F82")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031F83 RID: 204675
			[Token(Token = "0x4031F83")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031F84 RID: 204676
			[Token(Token = "0x4031F84")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
