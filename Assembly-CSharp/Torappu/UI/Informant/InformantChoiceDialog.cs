using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A2B RID: 18987
	[Token(Token = "0x2004A2B")]
	public class InformantChoiceDialog : UICompDialog<InformantDialogCommonInput>, ICompDialogCallBack, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0601C8E9 RID: 116969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E9")]
		[Address(RVA = "0x1613410", Offset = "0x1612010", VA = "0x181613410", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C8EA RID: 116970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8EA")]
		[Address(RVA = "0x1613840", Offset = "0x1612440", VA = "0x181613840", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C8EB RID: 116971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8EB")]
		[Address(RVA = "0x1613C20", Offset = "0x1612820", VA = "0x181613C20")]
		private void _InitDialog(string actId)
		{
		}

		// Token: 0x0601C8EC RID: 116972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8EC")]
		[Address(RVA = "0x1613A30", Offset = "0x1612630", VA = "0x181613A30")]
		private void _EventOnExitClicked()
		{
		}

		// Token: 0x0601C8ED RID: 116973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8ED")]
		[Address(RVA = "0x1613380", Offset = "0x1611F80", VA = "0x181613380", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601C8EE RID: 116974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8EE")]
		[Address(RVA = "0x1613190", Offset = "0x1611D90", VA = "0x181613190", Slot = "20")]
		public CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C8EF RID: 116975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8EF")]
		[Address(RVA = "0x1613B90", Offset = "0x1612790", VA = "0x181613B90")]
		private CustomYieldInstruction _HandleTabSelectChoice(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C8F0 RID: 116976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8F0")]
		[Address(RVA = "0x1613B00", Offset = "0x1612700", VA = "0x181613B00")]
		private CustomYieldInstruction _HandleTabChoiceEnd(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C8F1 RID: 116977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F1")]
		[Address(RVA = "0x16145A0", Offset = "0x16131A0", VA = "0x1816145A0")]
		private void _UpdateSelectedDialog()
		{
		}

		// Token: 0x0601C8F2 RID: 116978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F2")]
		[Address(RVA = "0x1613580", Offset = "0x1612180", VA = "0x181613580", Slot = "21")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C8F3 RID: 116979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F3")]
		[Address(RVA = "0x1614190", Offset = "0x1612D90", VA = "0x181614190")]
		private void _PlayTransitionNormalAnim()
		{
		}

		// Token: 0x0601C8F4 RID: 116980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F4")]
		[Address(RVA = "0x1614070", Offset = "0x1612C70", VA = "0x181614070")]
		private void _PlayTransitionAngryAnim()
		{
		}

		// Token: 0x0601C8F5 RID: 116981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F5")]
		[Address(RVA = "0x16142B0", Offset = "0x1612EB0", VA = "0x1816142B0")]
		private void _RefreshCustomerPart()
		{
		}

		// Token: 0x0601C8F6 RID: 116982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F6")]
		[Address(RVA = "0x1613070", Offset = "0x1611C70", VA = "0x181613070")]
		public void EventOnOpenCustomerInfoDialog()
		{
		}

		// Token: 0x0601C8F7 RID: 116983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F7")]
		[Address(RVA = "0x1613100", Offset = "0x1611D00", VA = "0x181613100")]
		public void EventOnOpenNewsDialog()
		{
		}

		// Token: 0x0601C8F8 RID: 116984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F8")]
		[Address(RVA = "0x16149D0", Offset = "0x16135D0", VA = "0x1816149D0")]
		public InformantChoiceDialog()
		{
		}

		// Token: 0x0601C8F9 RID: 116985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8F9")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04025753 RID: 153427
		[Token(Token = "0x4025753")]
		private const string TAB_SELECT_CHOICE = "tab_select_choice";

		// Token: 0x04025754 RID: 153428
		[Token(Token = "0x4025754")]
		private const string TAB_CHOICE_END = "tab_choice_end";

		// Token: 0x04025755 RID: 153429
		[Token(Token = "0x4025755")]
		[NonSerialized]
		public const int EVENT_PLAY_TRANSITION_NORMAL_ANIM = 0;

		// Token: 0x04025756 RID: 153430
		[Token(Token = "0x4025756")]
		[NonSerialized]
		public const int EVENT_PLAY_TRANSITION_ANGRY_ANIM = 1;

		// Token: 0x04025757 RID: 153431
		[Token(Token = "0x4025757")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04025758 RID: 153432
		[Token(Token = "0x4025758")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04025759 RID: 153433
		[Token(Token = "0x4025759")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterSimpleAnim;

		// Token: 0x0402575A RID: 153434
		[Token(Token = "0x402575A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _transitionNormalAnim;

		// Token: 0x0402575B RID: 153435
		[Token(Token = "0x402575B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _transitionAngryAnim;

		// Token: 0x0402575C RID: 153436
		[Token(Token = "0x402575C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Common")]
		private InformantCustomerBarView _customerBarPrefab;

		// Token: 0x0402575D RID: 153437
		[Token(Token = "0x402575D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _customerBarContainer;

		// Token: 0x0402575E RID: 153438
		[Token(Token = "0x402575E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Common")]
		private InformantCommonTopMenu _topMenuPrefab;

		// Token: 0x0402575F RID: 153439
		[Token(Token = "0x402575F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _topMenuContainer;

		// Token: 0x04025760 RID: 153440
		[Token(Token = "0x4025760")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Customer")]
		private AVGSharedCharacter _customerIllust;

		// Token: 0x04025761 RID: 153441
		[Token(Token = "0x4025761")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Customer")]
		private float _avgCharBlackStart;

		// Token: 0x04025762 RID: 153442
		[Token(Token = "0x4025762")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Group("Customer")]
		private float _avgCharBlackEnd;

		// Token: 0x04025763 RID: 153443
		[Token(Token = "0x4025763")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Customer")]
		private TwoStateToggle _customerTagToggle;

		// Token: 0x04025764 RID: 153444
		[Token(Token = "0x4025764")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Customer")]
		private Text[] _customerTag;

		// Token: 0x04025765 RID: 153445
		[Token(Token = "0x4025765")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Customer")]
		private Text _customerName;

		// Token: 0x04025766 RID: 153446
		[Token(Token = "0x4025766")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Customer")]
		private Text _customerDialog;

		// Token: 0x04025767 RID: 153447
		[Token(Token = "0x4025767")]
		[FieldOffset(Offset = "0x108")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x04025768 RID: 153448
		[Token(Token = "0x4025768")]
		[FieldOffset(Offset = "0x110")]
		private ListDict<string, UITabPager.TabPageViewModel> m_tabPageModels;

		// Token: 0x04025769 RID: 153449
		[Token(Token = "0x4025769")]
		[FieldOffset(Offset = "0x118")]
		private string m_actId;

		// Token: 0x0402576A RID: 153450
		[Token(Token = "0x402576A")]
		[FieldOffset(Offset = "0x120")]
		private bool m_choiceEndSimpleEnterAnim;

		// Token: 0x0402576B RID: 153451
		[Token(Token = "0x402576B")]
		[FieldOffset(Offset = "0x121")]
		private bool m_selectChoiceSimpleEnterAnim;

		// Token: 0x0402576C RID: 153452
		[Token(Token = "0x402576C")]
		[FieldOffset(Offset = "0x128")]
		private InformantCustomerBarProperty m_customerBarProperty;

		// Token: 0x0402576D RID: 153453
		[Token(Token = "0x402576D")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_enterAnimTween;

		// Token: 0x0402576E RID: 153454
		[Token(Token = "0x402576E")]
		[FieldOffset(Offset = "0x138")]
		private InformantChoiceViewModel m_choiceViewModel;

		// Token: 0x0402576F RID: 153455
		[Token(Token = "0x402576F")]
		[FieldOffset(Offset = "0x140")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04025770 RID: 153456
		[Token(Token = "0x4025770")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_transitionAnimTween;

		// Token: 0x04025771 RID: 153457
		[Token(Token = "0x4025771")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04025772 RID: 153458
		[Token(Token = "0x4025772")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025773 RID: 153459
		[Token(Token = "0x4025773")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitDialog;

		// Token: 0x04025774 RID: 153460
		[Token(Token = "0x4025774")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnExitClicked;

		// Token: 0x04025775 RID: 153461
		[Token(Token = "0x4025775")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04025776 RID: 153462
		[Token(Token = "0x4025776")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBackAsync;

		// Token: 0x04025777 RID: 153463
		[Token(Token = "0x4025777")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleTabSelectChoice;

		// Token: 0x04025778 RID: 153464
		[Token(Token = "0x4025778")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleTabChoiceEnd;

		// Token: 0x04025779 RID: 153465
		[Token(Token = "0x4025779")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSelectedDialog;

		// Token: 0x0402577A RID: 153466
		[Token(Token = "0x402577A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402577B RID: 153467
		[Token(Token = "0x402577B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayTransitionNormalAnim;

		// Token: 0x0402577C RID: 153468
		[Token(Token = "0x402577C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayTransitionAngryAnim;

		// Token: 0x0402577D RID: 153469
		[Token(Token = "0x402577D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RefreshCustomerPart;

		// Token: 0x0402577E RID: 153470
		[Token(Token = "0x402577E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnOpenCustomerInfoDialog;

		// Token: 0x0402577F RID: 153471
		[Token(Token = "0x402577F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnOpenNewsDialog;

		// Token: 0x04025780 RID: 153472
		[Token(Token = "0x4025780")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A2C RID: 18988
		[Token(Token = "0x2004A2C")]
		private class TabDataSource : UITabPager.TabDataSource, IHotfixable
		{
			// Token: 0x0601C8FA RID: 116986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C8FA")]
			[Address(RVA = "0x161D3E0", Offset = "0x161BFE0", VA = "0x18161D3E0")]
			public TabDataSource(InformantChoiceDialog closure)
			{
			}

			// Token: 0x0601C8FB RID: 116987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C8FB")]
			[Address(RVA = "0x161D320", Offset = "0x161BF20", VA = "0x18161D320", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x0601C8FC RID: 116988 RVA: 0x000A8A68 File Offset: 0x000A6C68
			[Token(Token = "0x601C8FC")]
			[Address(RVA = "0x161D250", Offset = "0x161BE50", VA = "0x18161D250", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x04025781 RID: 153473
			[Token(Token = "0x4025781")]
			[FieldOffset(Offset = "0x10")]
			private InformantChoiceDialog m_closure;

			// Token: 0x04025782 RID: 153474
			[Token(Token = "0x4025782")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025783 RID: 153475
			[Token(Token = "0x4025783")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x04025784 RID: 153476
			[Token(Token = "0x4025784")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTabCount;
		}

		// Token: 0x02004A2D RID: 18989
		[Token(Token = "0x2004A2D")]
		private class TabModelSelectChoice : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C8FD RID: 116989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C8FD")]
			[Address(RVA = "0x161D570", Offset = "0x161C170", VA = "0x18161D570", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C8FE RID: 116990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C8FE")]
			[Address(RVA = "0x161D660", Offset = "0x161C260", VA = "0x18161D660")]
			public TabModelSelectChoice()
			{
			}

			// Token: 0x0601C8FF RID: 116991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C8FF")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025785 RID: 153477
			[Token(Token = "0x4025785")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x04025786 RID: 153478
			[Token(Token = "0x4025786")]
			[FieldOffset(Offset = "0x38")]
			public bool useSimpleEnterAnim;

			// Token: 0x04025787 RID: 153479
			[Token(Token = "0x4025787")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04025788 RID: 153480
			[Token(Token = "0x4025788")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A2E RID: 18990
		[Token(Token = "0x2004A2E")]
		private class TabModelChoiceEnd : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C900 RID: 116992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C900")]
			[Address(RVA = "0x161D460", Offset = "0x161C060", VA = "0x18161D460", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C901 RID: 116993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C901")]
			[Address(RVA = "0x161D510", Offset = "0x161C110", VA = "0x18161D510")]
			public TabModelChoiceEnd()
			{
			}

			// Token: 0x0601C902 RID: 116994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C902")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025789 RID: 153481
			[Token(Token = "0x4025789")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x0402578A RID: 153482
			[Token(Token = "0x402578A")]
			[FieldOffset(Offset = "0x38")]
			public bool useSimpleEnterAnim;

			// Token: 0x0402578B RID: 153483
			[Token(Token = "0x402578B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0402578C RID: 153484
			[Token(Token = "0x402578C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
