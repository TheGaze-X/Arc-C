using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Ending;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005288 RID: 21128
	[Token(Token = "0x2005288")]
	public class RoguelikeClassicEndingController : RoguelikeEndingController<RoguelikeClassicEndingViewModel>
	{
		// Token: 0x0601F2C8 RID: 127688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2C8")]
		[Address(RVA = "0x18E02D0", Offset = "0x18DEED0", VA = "0x1818E02D0")]
		private void _RenderBasicView()
		{
		}

		// Token: 0x0601F2C9 RID: 127689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2C9")]
		[Address(RVA = "0x18E08E0", Offset = "0x18DF4E0", VA = "0x1818E08E0")]
		private void _TriggerEndingAvgAndRecord(string triggerId)
		{
		}

		// Token: 0x0601F2CA RID: 127690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2CA")]
		[Address(RVA = "0x18E0670", Offset = "0x18DF270", VA = "0x1818E0670")]
		private void _ShowReport([Optional] Story story)
		{
		}

		// Token: 0x0601F2CB RID: 127691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F2CB")]
		[Address(RVA = "0x18E0820", Offset = "0x18DF420", VA = "0x1818E0820")]
		private IEnumerator _ShowViewCoroutine(bool showLeftView)
		{
			return null;
		}

		// Token: 0x0601F2CC RID: 127692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F2CC")]
		[Address(RVA = "0x18E0220", Offset = "0x18DEE20", VA = "0x1818E0220")]
		private IEnumerator _OpenReportCoroutine()
		{
			return null;
		}

		// Token: 0x0601F2CD RID: 127693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F2CD")]
		[Address(RVA = "0x18E0A60", Offset = "0x18DF660", VA = "0x1818E0A60")]
		private IEnumerator _TryDismissSelfAndOpenTopicPage()
		{
			return null;
		}

		// Token: 0x0601F2CE RID: 127694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2CE")]
		[Address(RVA = "0x18E0B10", Offset = "0x18DF710", VA = "0x1818E0B10")]
		private void _TryToOpenReport()
		{
		}

		// Token: 0x0601F2CF RID: 127695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2CF")]
		[Address(RVA = "0x18DFFB0", Offset = "0x18DEBB0", VA = "0x1818DFFB0")]
		private void _OnDismissBpView()
		{
		}

		// Token: 0x0601F2D0 RID: 127696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D0")]
		[Address(RVA = "0x18E0410", Offset = "0x18DF010", VA = "0x1818E0410")]
		private void _SendRequest(Action<RoguelikeTopicGameSettleResponse> action)
		{
		}

		// Token: 0x0601F2D1 RID: 127697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D1")]
		[Address(RVA = "0x18DF7E0", Offset = "0x18DE3E0", VA = "0x1818DF7E0")]
		private void _DoTrackTrigger()
		{
		}

		// Token: 0x0601F2D2 RID: 127698 RVA: 0x000B11E0 File Offset: 0x000AF3E0
		[Token(Token = "0x601F2D2")]
		[Address(RVA = "0x18DFF20", Offset = "0x18DEB20", VA = "0x1818DFF20")]
		private ViewType _GetScoreViewType(RoguelikeTopicMode mode)
		{
			return ViewType.NONE;
		}

		// Token: 0x0601F2D3 RID: 127699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F2D3")]
		[Address(RVA = "0x18DE8A0", Offset = "0x18DD4A0", VA = "0x1818DE8A0", Slot = "5")]
		public override RoguelikeEndingViewModel ConstructViewModel(RoguelikeTopicMode mode)
		{
			return null;
		}

		// Token: 0x0601F2D4 RID: 127700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D4")]
		[Address(RVA = "0x18DEAD0", Offset = "0x18DD6D0", VA = "0x1818DEAD0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601F2D5 RID: 127701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D5")]
		[Address(RVA = "0x18DF290", Offset = "0x18DDE90", VA = "0x1818DF290", Slot = "7")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F2D6 RID: 127702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D6")]
		[Address(RVA = "0x18DFDF0", Offset = "0x18DE9F0", VA = "0x1818DFDF0")]
		private void _EventOnStatsViewClick()
		{
		}

		// Token: 0x0601F2D7 RID: 127703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D7")]
		[Address(RVA = "0x18DFD40", Offset = "0x18DE940", VA = "0x1818DFD40")]
		private void _EventOnStatsScoreViewBackClick()
		{
		}

		// Token: 0x0601F2D8 RID: 127704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D8")]
		[Address(RVA = "0x18DFA50", Offset = "0x18DE650", VA = "0x1818DFA50")]
		private void _EventOnScoreViewBtnClick()
		{
		}

		// Token: 0x0601F2D9 RID: 127705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2D9")]
		[Address(RVA = "0x18DFCE0", Offset = "0x18DE8E0", VA = "0x1818DFCE0")]
		private void _EventOnShowReportBtnClick()
		{
		}

		// Token: 0x0601F2DA RID: 127706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2DA")]
		[Address(RVA = "0x18DF920", Offset = "0x18DE520", VA = "0x1818DF920")]
		private void _EventOnCopySeed()
		{
		}

		// Token: 0x0601F2DB RID: 127707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2DB")]
		[Address(RVA = "0x18DEA70", Offset = "0x18DD670", VA = "0x1818DEA70")]
		public void EventBpViewDismissClick()
		{
		}

		// Token: 0x0601F2DC RID: 127708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2DC")]
		[Address(RVA = "0x18E0D00", Offset = "0x18DF900", VA = "0x1818E0D00")]
		public RoguelikeClassicEndingController()
		{
		}

		// Token: 0x0601F2DF RID: 127711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2DF")]
		[Address(RVA = "0x18DF580", Offset = "0x18DE180", VA = "0x1818DF580")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04029D60 RID: 171360
		[Token(Token = "0x4029D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeClassicEndingPageViewBase[] _pageViewPrefabs;

		// Token: 0x04029D61 RID: 171361
		[Token(Token = "0x4029D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeClassicEndingTopView _topViewPrefab;

		// Token: 0x04029D62 RID: 171362
		[Token(Token = "0x4029D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeClassicEndingSeedView _seedViewPrefab;

		// Token: 0x04029D63 RID: 171363
		[Token(Token = "0x4029D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _statsViewHolder;

		// Token: 0x04029D64 RID: 171364
		[Token(Token = "0x4029D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _scoreViewHolder;

		// Token: 0x04029D65 RID: 171365
		[Token(Token = "0x4029D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topViewHolder;

		// Token: 0x04029D66 RID: 171366
		[Token(Token = "0x4029D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _seedViewHolder;

		// Token: 0x04029D67 RID: 171367
		[Token(Token = "0x4029D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x04029D68 RID: 171368
		[Token(Token = "0x4029D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBlurFloatPanel _bpViewBlur;

		// Token: 0x04029D69 RID: 171369
		[Token(Token = "0x4029D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bpAndGpViewContainer;

		// Token: 0x04029D6A RID: 171370
		[Token(Token = "0x4029D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeTopicEndingBpAndGpView _endingBpAndGpView;

		// Token: 0x04029D6B RID: 171371
		[Token(Token = "0x4029D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x04029D6C RID: 171372
		[Token(Token = "0x4029D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicEndingDataPluginBase _endingDataUtil;

		// Token: 0x04029D6D RID: 171373
		[Token(Token = "0x4029D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RoguelikeClassicEndingPageViewBase m_statsView;

		// Token: 0x04029D6E RID: 171374
		[Token(Token = "0x4029D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RoguelikeClassicEndingPageViewBase m_scoreView;

		// Token: 0x04029D6F RID: 171375
		[Token(Token = "0x4029D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RoguelikeClassicEndingTopView m_topView;

		// Token: 0x04029D70 RID: 171376
		[Token(Token = "0x4029D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RoguelikeClassicEndingSeedView m_seedView;

		// Token: 0x04029D71 RID: 171377
		[Token(Token = "0x4029D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_showLeftView;

		// Token: 0x04029D72 RID: 171378
		[Token(Token = "0x4029D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool m_hasShowReport;

		// Token: 0x04029D73 RID: 171379
		[Token(Token = "0x4029D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private bool m_hasAvgPlayed;

		// Token: 0x04029D74 RID: 171380
		[Token(Token = "0x4029D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBB")]
		private bool m_isRequested;

		// Token: 0x04029D75 RID: 171381
		[Token(Token = "0x4029D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RoguelikeTopicEndingBpAndGpView m_endingBpAndGpView;

		// Token: 0x04029D76 RID: 171382
		[Token(Token = "0x4029D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private PlayerRoguelikeV2.OuterData m_cachedOuterData;

		// Token: 0x04029D77 RID: 171383
		[Token(Token = "0x4029D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderBasicView;

		// Token: 0x04029D78 RID: 171384
		[Token(Token = "0x4029D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TriggerEndingAvgAndRecord;

		// Token: 0x04029D79 RID: 171385
		[Token(Token = "0x4029D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowReport;

		// Token: 0x04029D7A RID: 171386
		[Token(Token = "0x4029D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowViewCoroutine;

		// Token: 0x04029D7B RID: 171387
		[Token(Token = "0x4029D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenReportCoroutine;

		// Token: 0x04029D7C RID: 171388
		[Token(Token = "0x4029D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryDismissSelfAndOpenTopicPage;

		// Token: 0x04029D7D RID: 171389
		[Token(Token = "0x4029D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryToOpenReport;

		// Token: 0x04029D7E RID: 171390
		[Token(Token = "0x4029D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDismissBpView;

		// Token: 0x04029D7F RID: 171391
		[Token(Token = "0x4029D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendRequest;

		// Token: 0x04029D80 RID: 171392
		[Token(Token = "0x4029D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoTrackTrigger;

		// Token: 0x04029D81 RID: 171393
		[Token(Token = "0x4029D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetScoreViewType;

		// Token: 0x04029D82 RID: 171394
		[Token(Token = "0x4029D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConstructViewModel;

		// Token: 0x04029D83 RID: 171395
		[Token(Token = "0x4029D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04029D84 RID: 171396
		[Token(Token = "0x4029D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029D85 RID: 171397
		[Token(Token = "0x4029D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnStatsViewClick;

		// Token: 0x04029D86 RID: 171398
		[Token(Token = "0x4029D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnStatsScoreViewBackClick;

		// Token: 0x04029D87 RID: 171399
		[Token(Token = "0x4029D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnScoreViewBtnClick;

		// Token: 0x04029D88 RID: 171400
		[Token(Token = "0x4029D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnShowReportBtnClick;

		// Token: 0x04029D89 RID: 171401
		[Token(Token = "0x4029D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnCopySeed;

		// Token: 0x04029D8A RID: 171402
		[Token(Token = "0x4029D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventBpViewDismissClick;

		// Token: 0x04029D8B RID: 171403
		[Token(Token = "0x4029D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
