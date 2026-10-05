using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F53 RID: 16211
	[Token(Token = "0x2003F53")]
	public class SiracusaMapController : PageSingleComponent
	{
		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0601929A RID: 103066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C27")]
		public string groupId
		{
			[Token(Token = "0x601929A")]
			[Address(RVA = "0x11D7C60", Offset = "0x11D6860", VA = "0x1811D7C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0601929B RID: 103067 RVA: 0x0009D218 File Offset: 0x0009B418
		[Token(Token = "0x17003C28")]
		public bool isRetro
		{
			[Token(Token = "0x601929B")]
			[Address(RVA = "0x11D7D20", Offset = "0x11D6920", VA = "0x1811D7D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0601929C RID: 103068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C29")]
		public SiracusaMapPanelMapProperty panelMapProperty
		{
			[Token(Token = "0x601929C")]
			[Address(RVA = "0x11D7DE0", Offset = "0x11D69E0", VA = "0x1811D7DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0601929D RID: 103069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C2A")]
		public Image backMask
		{
			[Token(Token = "0x601929D")]
			[Address(RVA = "0x11D7C00", Offset = "0x11D6800", VA = "0x1811D7C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0601929E RID: 103070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C2B")]
		public Image previewImg
		{
			[Token(Token = "0x601929E")]
			[Address(RVA = "0x11D7E40", Offset = "0x11D6A40", VA = "0x1811D7E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0601929F RID: 103071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C2C")]
		public GameObject mapTips
		{
			[Token(Token = "0x601929F")]
			[Address(RVA = "0x11D7D80", Offset = "0x11D6980", VA = "0x1811D7D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x060192A0 RID: 103072 RVA: 0x0009D230 File Offset: 0x0009B430
		[Token(Token = "0x17003C2D")]
		public bool hasInited
		{
			[Token(Token = "0x60192A0")]
			[Address(RVA = "0x11D7CC0", Offset = "0x11D68C0", VA = "0x1811D7CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060192A1 RID: 103073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192A1")]
		[Address(RVA = "0x11D40A0", Offset = "0x11D2CA0", VA = "0x1811D40A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x060192A2 RID: 103074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192A2")]
		[Address(RVA = "0x11D4890", Offset = "0x11D3490", VA = "0x1811D4890", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060192A3 RID: 103075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192A3")]
		[Address(RVA = "0x11D5F00", Offset = "0x11D4B00", VA = "0x1811D5F00")]
		private void _LoadSpriteHubs(UIPage page)
		{
		}

		// Token: 0x060192A4 RID: 103076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192A4")]
		[Address(RVA = "0x11D3BF0", Offset = "0x11D27F0", VA = "0x1811D3BF0")]
		public AutoPackSpriteHub GetCharCardItemSpriteHub()
		{
			return null;
		}

		// Token: 0x060192A5 RID: 103077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192A5")]
		[Address(RVA = "0x11D3C50", Offset = "0x11D2850", VA = "0x1811D3C50")]
		public AutoPackSpriteHub GetCharCardSpriteHub()
		{
			return null;
		}

		// Token: 0x060192A6 RID: 103078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192A6")]
		[Address(RVA = "0x11D3B90", Offset = "0x11D2790", VA = "0x1811D3B90")]
		public AutoPackSpriteHub GetCharCardItalyNameSpriteHub()
		{
			return null;
		}

		// Token: 0x060192A7 RID: 103079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192A7")]
		[Address(RVA = "0x11D3B30", Offset = "0x11D2730", VA = "0x1811D3B30")]
		public AutoPackSpriteHub GetAreaPointIconSpriteHub()
		{
			return null;
		}

		// Token: 0x060192A8 RID: 103080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192A8")]
		[Address(RVA = "0x11D3F10", Offset = "0x11D2B10", VA = "0x1811D3F10")]
		public AutoPackSpriteHub GetTaskCharAvatarCharHub()
		{
			return null;
		}

		// Token: 0x060192A9 RID: 103081 RVA: 0x0009D248 File Offset: 0x0009B448
		[Token(Token = "0x60192A9")]
		[Address(RVA = "0x11D3690", Offset = "0x11D2290", VA = "0x1811D3690")]
		public bool CheckIfInBigMapViewAndHandle()
		{
			return default(bool);
		}

		// Token: 0x060192AA RID: 103082 RVA: 0x0009D260 File Offset: 0x0009B460
		[Token(Token = "0x60192AA")]
		[Address(RVA = "0x11D5DF0", Offset = "0x11D49F0", VA = "0x1811D5DF0")]
		private bool _IsSelectingStage()
		{
			return default(bool);
		}

		// Token: 0x060192AB RID: 103083 RVA: 0x0009D278 File Offset: 0x0009B478
		[Token(Token = "0x60192AB")]
		[Address(RVA = "0x11D5D20", Offset = "0x11D4920", VA = "0x1811D5D20")]
		private bool _IsInSmallMapState()
		{
			return default(bool);
		}

		// Token: 0x060192AC RID: 103084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192AC")]
		[Address(RVA = "0x11D7700", Offset = "0x11D6300", VA = "0x1811D7700")]
		private void _SwitchToBigMapState()
		{
		}

		// Token: 0x060192AD RID: 103085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192AD")]
		[Address(RVA = "0x11D7940", Offset = "0x11D6540", VA = "0x1811D7940")]
		private void _TryUnselectPoint(bool needChangeShowSelectedFlag = true)
		{
		}

		// Token: 0x060192AE RID: 103086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192AE")]
		[Address(RVA = "0x11D7850", Offset = "0x11D6450", VA = "0x1811D7850")]
		private void _TryUnselectNaviDetailStage()
		{
		}

		// Token: 0x060192AF RID: 103087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192AF")]
		[Address(RVA = "0x11D4AA0", Offset = "0x11D36A0", VA = "0x1811D4AA0")]
		public void UpdateCharCardProp()
		{
		}

		// Token: 0x060192B0 RID: 103088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B0")]
		[Address(RVA = "0x11D4BE0", Offset = "0x11D37E0", VA = "0x1811D4BE0")]
		public void UpdateReviewCharCard(string charCardId)
		{
		}

		// Token: 0x060192B1 RID: 103089 RVA: 0x0009D290 File Offset: 0x0009B490
		[Token(Token = "0x60192B1")]
		[Address(RVA = "0x11D3CB0", Offset = "0x11D28B0", VA = "0x1811D3CB0")]
		public SiracusaMapController.SiracusaMapChatParam GetSiracusaMapChatParam()
		{
			return default(SiracusaMapController.SiracusaMapChatParam);
		}

		// Token: 0x060192B2 RID: 103090 RVA: 0x0009D2A8 File Offset: 0x0009B4A8
		[Token(Token = "0x60192B2")]
		[Address(RVA = "0x11D35C0", Offset = "0x11D21C0", VA = "0x1811D35C0")]
		public bool CanTaskRingTakeReward()
		{
			return default(bool);
		}

		// Token: 0x060192B3 RID: 103091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B3")]
		[Address(RVA = "0x11D48F0", Offset = "0x11D34F0", VA = "0x1811D48F0")]
		public void ShowToast(string toast)
		{
		}

		// Token: 0x060192B4 RID: 103092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192B4")]
		[Address(RVA = "0x11D3A20", Offset = "0x11D2620", VA = "0x1811D3A20")]
		public SiracusaMapPage.Param GeneRecoverPageParam(string storyId, string pointId)
		{
			return null;
		}

		// Token: 0x060192B5 RID: 103093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B5")]
		[Address(RVA = "0x11D3F70", Offset = "0x11D2B70", VA = "0x1811D3F70")]
		public void NotifyAreaUnlock(string areaId)
		{
		}

		// Token: 0x060192B6 RID: 103094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B6")]
		[Address(RVA = "0x11D4A20", Offset = "0x11D3620", VA = "0x1811D4A20")]
		public void TryToUnselectNode(bool needChangeShowSelectedFlag = true)
		{
		}

		// Token: 0x060192B7 RID: 103095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B7")]
		[Address(RVA = "0x11D5BE0", Offset = "0x11D47E0", VA = "0x1811D5BE0")]
		private void _InitZoneMapView()
		{
		}

		// Token: 0x060192B8 RID: 103096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B8")]
		[Address(RVA = "0x11D6560", Offset = "0x11D5160", VA = "0x1811D6560")]
		private void _OnMapNodeClicked(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x060192B9 RID: 103097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192B9")]
		[Address(RVA = "0x11D6500", Offset = "0x11D5100", VA = "0x1811D6500")]
		private void _OnMapBlankClicked()
		{
		}

		// Token: 0x060192BA RID: 103098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BA")]
		[Address(RVA = "0x11D5210", Offset = "0x11D3E10", VA = "0x1811D5210")]
		private void _InitCharCardView()
		{
		}

		// Token: 0x060192BB RID: 103099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BB")]
		[Address(RVA = "0x11D70C0", Offset = "0x11D5CC0", VA = "0x1811D70C0")]
		private void _OnTaskClick(string taskRingId, string taskId)
		{
		}

		// Token: 0x060192BC RID: 103100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BC")]
		[Address(RVA = "0x11D6210", Offset = "0x11D4E10", VA = "0x1811D6210")]
		private void _OnCharCardBagClick()
		{
		}

		// Token: 0x060192BD RID: 103101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BD")]
		[Address(RVA = "0x11D63E0", Offset = "0x11D4FE0", VA = "0x1811D63E0")]
		private void _OnCharChangeClick()
		{
		}

		// Token: 0x060192BE RID: 103102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BE")]
		[Address(RVA = "0x11D7500", Offset = "0x11D6100", VA = "0x1811D7500")]
		private void _ShowBubble()
		{
		}

		// Token: 0x060192BF RID: 103103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192BF")]
		[Address(RVA = "0x11D7440", Offset = "0x11D6040", VA = "0x1811D7440")]
		private void _SelectTaskRing(int index)
		{
		}

		// Token: 0x060192C0 RID: 103104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C0")]
		[Address(RVA = "0x11D4E30", Offset = "0x11D3A30", VA = "0x1811D4E30")]
		private void _CloseBubbleAfterDelay()
		{
		}

		// Token: 0x060192C1 RID: 103105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C1")]
		[Address(RVA = "0x11D54A0", Offset = "0x11D40A0", VA = "0x1811D54A0")]
		private void _InitNavigationView()
		{
		}

		// Token: 0x060192C2 RID: 103106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C2")]
		[Address(RVA = "0x11D6700", Offset = "0x11D5300", VA = "0x1811D6700")]
		private void _OnNavigationSelect(string entryId, SiracusaData.NavigationType entryType)
		{
		}

		// Token: 0x060192C3 RID: 103107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C3")]
		[Address(RVA = "0x11D6680", Offset = "0x11D5280", VA = "0x1811D6680")]
		private void _OnNavigationDetailStageItemSelect(string itemId)
		{
		}

		// Token: 0x060192C4 RID: 103108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C4")]
		[Address(RVA = "0x11D68D0", Offset = "0x11D54D0", VA = "0x1811D68D0")]
		private void _OnNavigationStageItemUnSelect()
		{
		}

		// Token: 0x060192C5 RID: 103109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C5")]
		[Address(RVA = "0x11D60A0", Offset = "0x11D4CA0", VA = "0x1811D60A0")]
		private void _NavigationDetailStageItemSelect(string itemId)
		{
		}

		// Token: 0x060192C6 RID: 103110 RVA: 0x0009D2C0 File Offset: 0x0009B4C0
		[Token(Token = "0x60192C6")]
		[Address(RVA = "0x11D4D50", Offset = "0x11D3950", VA = "0x1811D4D50")]
		private bool _CheckIfNavigationDetailStageCurSelectNothing()
		{
			return default(bool);
		}

		// Token: 0x060192C7 RID: 103111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C7")]
		[Address(RVA = "0x11D5A30", Offset = "0x11D4630", VA = "0x1811D5A30")]
		private void _InitStoryStagePreviewView()
		{
		}

		// Token: 0x060192C8 RID: 103112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192C8")]
		[Address(RVA = "0x11D6A20", Offset = "0x11D5620", VA = "0x1811D6A20")]
		private void _OnPlayStory(SiracusaMapStageDetailInfoViewModel data)
		{
		}

		// Token: 0x060192C9 RID: 103113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192C9")]
		[Address(RVA = "0x11D4F60", Offset = "0x11D3B60", VA = "0x1811D4F60")]
		private UIPageControllerParam _GeneRecoverParamWithStory(SiracusaMapController controller, bool isFirstPassedStage, string zoneId, string stageId, string pointId, StoryOnlyStartBattleResponse response)
		{
			return null;
		}

		// Token: 0x060192CA RID: 103114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CA")]
		[Address(RVA = "0x11D5740", Offset = "0x11D4340", VA = "0x1811D5740")]
		private void _InitStagePreviewView()
		{
		}

		// Token: 0x060192CB RID: 103115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CB")]
		[Address(RVA = "0x11D6DE0", Offset = "0x11D59E0", VA = "0x1811D6DE0")]
		private void _OnPreviewBeHard(string _)
		{
		}

		// Token: 0x060192CC RID: 103116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CC")]
		[Address(RVA = "0x11D6EC0", Offset = "0x11D5AC0", VA = "0x1811D6EC0")]
		private void _OnPreviewBeNormal(string _)
		{
		}

		// Token: 0x060192CD RID: 103117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CD")]
		[Address(RVA = "0x11D6FA0", Offset = "0x11D5BA0", VA = "0x1811D6FA0")]
		private void _OnRewardClick(string _)
		{
		}

		// Token: 0x060192CE RID: 103118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CE")]
		[Address(RVA = "0x11D7B50", Offset = "0x11D6750", VA = "0x1811D7B50")]
		public SiracusaMapController()
		{
		}

		// Token: 0x060192CF RID: 103119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192CF")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x060192D0 RID: 103120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192D0")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0401F319 RID: 127769
		[Token(Token = "0x401F319")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SiracusaMapZoneMapHolder _zoneMapHolder;

		// Token: 0x0401F31A RID: 127770
		[Token(Token = "0x401F31A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _charCardContainer;

		// Token: 0x0401F31B RID: 127771
		[Token(Token = "0x401F31B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _bigMapNavigationContainer;

		// Token: 0x0401F31C RID: 127772
		[Token(Token = "0x401F31C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _smallMapStageDtailContainer;

		// Token: 0x0401F31D RID: 127773
		[Token(Token = "0x401F31D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SiracusaCharCardView _charCardViewPrefab;

		// Token: 0x0401F31E RID: 127774
		[Token(Token = "0x401F31E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SiracusaMapNavigationView _bigMapNavigationViewPrefab;

		// Token: 0x0401F31F RID: 127775
		[Token(Token = "0x401F31F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SiracusaMapStageDetailView _smallMapStageDetailViewPrefab;

		// Token: 0x0401F320 RID: 127776
		[Token(Token = "0x401F320")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SiracusaMapPointInfoHolder _pointInfoViewHolder;

		// Token: 0x0401F321 RID: 127777
		[Token(Token = "0x401F321")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SiracusaMapCoinView _coinView;

		// Token: 0x0401F322 RID: 127778
		[Token(Token = "0x401F322")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Story Preview")]
		private RectTransform _storyPreviewViewContainer;

		// Token: 0x0401F323 RID: 127779
		[Token(Token = "0x401F323")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Story Preview")]
		private SiracusaMapStageStoryPreviewView _storyPreviewViewPrefab;

		// Token: 0x0401F324 RID: 127780
		[Token(Token = "0x401F324")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Preview")]
		private SiracusaMapStagePreviewView _stagePreviewView;

		// Token: 0x0401F325 RID: 127781
		[Token(Token = "0x401F325")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Preview")]
		private GameObject _mapTips;

		// Token: 0x0401F326 RID: 127782
		[Token(Token = "0x401F326")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Preview")]
		private Image _previewImg;

		// Token: 0x0401F327 RID: 127783
		[Token(Token = "0x401F327")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Preview")]
		private Image _backMask;

		// Token: 0x0401F328 RID: 127784
		[Token(Token = "0x401F328")]
		[FieldOffset(Offset = "0x98")]
		private SiracusaCharCardView m_charCardView;

		// Token: 0x0401F329 RID: 127785
		[Token(Token = "0x401F329")]
		[FieldOffset(Offset = "0xA0")]
		private SiracusaMapNavigationView m_bigMapNavigationView;

		// Token: 0x0401F32A RID: 127786
		[Token(Token = "0x401F32A")]
		[FieldOffset(Offset = "0xA8")]
		private SiracusaMapStageDetailView m_smallMapStageDetailView;

		// Token: 0x0401F32B RID: 127787
		[Token(Token = "0x401F32B")]
		[FieldOffset(Offset = "0xB0")]
		private SiracusaMapStageStoryPreviewView m_storyStagePreviewView;

		// Token: 0x0401F32C RID: 127788
		[Token(Token = "0x401F32C")]
		[FieldOffset(Offset = "0xB8")]
		private SiracusaMapPanelMapProperty m_panelMapProperty;

		// Token: 0x0401F32D RID: 127789
		[Token(Token = "0x401F32D")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_bubbleCoroutine;

		// Token: 0x0401F32E RID: 127790
		[Token(Token = "0x401F32E")]
		[FieldOffset(Offset = "0xC8")]
		private AutoPackSpriteHub m_charCardItemSpriteHub;

		// Token: 0x0401F32F RID: 127791
		[Token(Token = "0x401F32F")]
		[FieldOffset(Offset = "0xD0")]
		private AutoPackSpriteHub m_charCardSpriteHub;

		// Token: 0x0401F330 RID: 127792
		[Token(Token = "0x401F330")]
		[FieldOffset(Offset = "0xD8")]
		private AutoPackSpriteHub m_charCardItalyNameSpriteHub;

		// Token: 0x0401F331 RID: 127793
		[Token(Token = "0x401F331")]
		[FieldOffset(Offset = "0xE0")]
		private AutoPackSpriteHub m_areaPointIconSpriteHub;

		// Token: 0x0401F332 RID: 127794
		[Token(Token = "0x401F332")]
		[FieldOffset(Offset = "0xE8")]
		private AutoPackSpriteHub m_taskCharAvatarSpriteHub;

		// Token: 0x0401F333 RID: 127795
		[Token(Token = "0x401F333")]
		[FieldOffset(Offset = "0xF0")]
		private string m_groupId;

		// Token: 0x0401F334 RID: 127796
		[Token(Token = "0x401F334")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x0401F335 RID: 127797
		[Token(Token = "0x401F335")]
		[FieldOffset(Offset = "0xF9")]
		private bool m_isRetro;

		// Token: 0x0401F336 RID: 127798
		[Token(Token = "0x401F336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0401F337 RID: 127799
		[Token(Token = "0x401F337")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x0401F338 RID: 127800
		[Token(Token = "0x401F338")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_panelMapProperty;

		// Token: 0x0401F339 RID: 127801
		[Token(Token = "0x401F339")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_backMask;

		// Token: 0x0401F33A RID: 127802
		[Token(Token = "0x401F33A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_previewImg;

		// Token: 0x0401F33B RID: 127803
		[Token(Token = "0x401F33B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_mapTips;

		// Token: 0x0401F33C RID: 127804
		[Token(Token = "0x401F33C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasInited;

		// Token: 0x0401F33D RID: 127805
		[Token(Token = "0x401F33D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401F33E RID: 127806
		[Token(Token = "0x401F33E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F33F RID: 127807
		[Token(Token = "0x401F33F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadSpriteHubs;

		// Token: 0x0401F340 RID: 127808
		[Token(Token = "0x401F340")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCharCardItemSpriteHub;

		// Token: 0x0401F341 RID: 127809
		[Token(Token = "0x401F341")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCharCardSpriteHub;

		// Token: 0x0401F342 RID: 127810
		[Token(Token = "0x401F342")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCharCardItalyNameSpriteHub;

		// Token: 0x0401F343 RID: 127811
		[Token(Token = "0x401F343")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetAreaPointIconSpriteHub;

		// Token: 0x0401F344 RID: 127812
		[Token(Token = "0x401F344")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTaskCharAvatarCharHub;

		// Token: 0x0401F345 RID: 127813
		[Token(Token = "0x401F345")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfInBigMapViewAndHandle;

		// Token: 0x0401F346 RID: 127814
		[Token(Token = "0x401F346")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__IsSelectingStage;

		// Token: 0x0401F347 RID: 127815
		[Token(Token = "0x401F347")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsInSmallMapState;

		// Token: 0x0401F348 RID: 127816
		[Token(Token = "0x401F348")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwitchToBigMapState;

		// Token: 0x0401F349 RID: 127817
		[Token(Token = "0x401F349")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryUnselectPoint;

		// Token: 0x0401F34A RID: 127818
		[Token(Token = "0x401F34A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryUnselectNaviDetailStage;

		// Token: 0x0401F34B RID: 127819
		[Token(Token = "0x401F34B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UpdateCharCardProp;

		// Token: 0x0401F34C RID: 127820
		[Token(Token = "0x401F34C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdateReviewCharCard;

		// Token: 0x0401F34D RID: 127821
		[Token(Token = "0x401F34D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetSiracusaMapChatParam;

		// Token: 0x0401F34E RID: 127822
		[Token(Token = "0x401F34E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CanTaskRingTakeReward;

		// Token: 0x0401F34F RID: 127823
		[Token(Token = "0x401F34F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowToast;

		// Token: 0x0401F350 RID: 127824
		[Token(Token = "0x401F350")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GeneRecoverPageParam;

		// Token: 0x0401F351 RID: 127825
		[Token(Token = "0x401F351")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_NotifyAreaUnlock;

		// Token: 0x0401F352 RID: 127826
		[Token(Token = "0x401F352")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TryToUnselectNode;

		// Token: 0x0401F353 RID: 127827
		[Token(Token = "0x401F353")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__InitZoneMapView;

		// Token: 0x0401F354 RID: 127828
		[Token(Token = "0x401F354")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnMapNodeClicked;

		// Token: 0x0401F355 RID: 127829
		[Token(Token = "0x401F355")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnMapBlankClicked;

		// Token: 0x0401F356 RID: 127830
		[Token(Token = "0x401F356")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__InitCharCardView;

		// Token: 0x0401F357 RID: 127831
		[Token(Token = "0x401F357")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnTaskClick;

		// Token: 0x0401F358 RID: 127832
		[Token(Token = "0x401F358")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnCharCardBagClick;

		// Token: 0x0401F359 RID: 127833
		[Token(Token = "0x401F359")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnCharChangeClick;

		// Token: 0x0401F35A RID: 127834
		[Token(Token = "0x401F35A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ShowBubble;

		// Token: 0x0401F35B RID: 127835
		[Token(Token = "0x401F35B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SelectTaskRing;

		// Token: 0x0401F35C RID: 127836
		[Token(Token = "0x401F35C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CloseBubbleAfterDelay;

		// Token: 0x0401F35D RID: 127837
		[Token(Token = "0x401F35D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__InitNavigationView;

		// Token: 0x0401F35E RID: 127838
		[Token(Token = "0x401F35E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnNavigationSelect;

		// Token: 0x0401F35F RID: 127839
		[Token(Token = "0x401F35F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnNavigationDetailStageItemSelect;

		// Token: 0x0401F360 RID: 127840
		[Token(Token = "0x401F360")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnNavigationStageItemUnSelect;

		// Token: 0x0401F361 RID: 127841
		[Token(Token = "0x401F361")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__NavigationDetailStageItemSelect;

		// Token: 0x0401F362 RID: 127842
		[Token(Token = "0x401F362")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__CheckIfNavigationDetailStageCurSelectNothing;

		// Token: 0x0401F363 RID: 127843
		[Token(Token = "0x401F363")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__InitStoryStagePreviewView;

		// Token: 0x0401F364 RID: 127844
		[Token(Token = "0x401F364")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnPlayStory;

		// Token: 0x0401F365 RID: 127845
		[Token(Token = "0x401F365")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GeneRecoverParamWithStory;

		// Token: 0x0401F366 RID: 127846
		[Token(Token = "0x401F366")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__InitStagePreviewView;

		// Token: 0x0401F367 RID: 127847
		[Token(Token = "0x401F367")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnPreviewBeHard;

		// Token: 0x0401F368 RID: 127848
		[Token(Token = "0x401F368")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__OnPreviewBeNormal;

		// Token: 0x0401F369 RID: 127849
		[Token(Token = "0x401F369")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__OnRewardClick;

		// Token: 0x0401F36A RID: 127850
		[Token(Token = "0x401F36A")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F54 RID: 16212
		[Token(Token = "0x2003F54")]
		public struct SiracusaMapChatParam : IHotfixable
		{
			// Token: 0x060192D1 RID: 103121 RVA: 0x0009D2D8 File Offset: 0x0009B4D8
			[Token(Token = "0x60192D1")]
			[Address(RVA = "0x11E9E20", Offset = "0x11E8A20", VA = "0x1811E9E20")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0401F36B RID: 127851
			[Token(Token = "0x401F36B")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x0401F36C RID: 127852
			[Token(Token = "0x401F36C")]
			[FieldOffset(Offset = "0x8")]
			public string charCardId;

			// Token: 0x0401F36D RID: 127853
			[Token(Token = "0x401F36D")]
			[FieldOffset(Offset = "0x10")]
			public string taskRingId;

			// Token: 0x0401F36E RID: 127854
			[Token(Token = "0x401F36E")]
			[FieldOffset(Offset = "0x18")]
			public string taskInfoId;

			// Token: 0x0401F36F RID: 127855
			[Token(Token = "0x401F36F")]
			[FieldOffset(Offset = "0x0")]
			public static SiracusaMapController.SiracusaMapChatParam EMPTY;

			// Token: 0x0401F370 RID: 127856
			[Token(Token = "0x401F370")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsValid;
		}
	}
}
