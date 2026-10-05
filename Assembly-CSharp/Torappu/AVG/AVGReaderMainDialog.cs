using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F19 RID: 7961
	[Token(Token = "0x2001F19")]
	public class AVGReaderMainDialog : UICompDialog<AVGReaderMainDialog.Input>, IValueMsgReceiver, ICompDialogDestroyedCallback
	{
		// Token: 0x0600C585 RID: 50565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C585")]
		[Address(RVA = "0x345C6D0", Offset = "0x345B2D0", VA = "0x18345C6D0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600C586 RID: 50566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C586")]
		[Address(RVA = "0x345C8B0", Offset = "0x345B4B0", VA = "0x18345C8B0", Slot = "18")]
		protected override void OnRender(AVGReaderMainDialog.Input input)
		{
		}

		// Token: 0x0600C587 RID: 50567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C587")]
		[Address(RVA = "0x345D2F0", Offset = "0x345BEF0", VA = "0x18345D2F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C588 RID: 50568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C588")]
		[Address(RVA = "0x345CB30", Offset = "0x345B730", VA = "0x18345CB30")]
		private void _BindBackPress()
		{
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C589")]
		[Address(RVA = "0x345DEF0", Offset = "0x345CAF0", VA = "0x18345DEF0")]
		private void _RenderView()
		{
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58A")]
		[Address(RVA = "0x345E090", Offset = "0x345CC90", VA = "0x18345E090")]
		private void _TryBindView()
		{
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58B")]
		[Address(RVA = "0x345CCE0", Offset = "0x345B8E0", VA = "0x18345CCE0")]
		private void _BindViews()
		{
		}

		// Token: 0x0600C58C RID: 50572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58C")]
		[Address(RVA = "0x345C1B0", Offset = "0x345ADB0", VA = "0x18345C1B0", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58D")]
		[Address(RVA = "0x345CF50", Offset = "0x345BB50", VA = "0x18345CF50")]
		private void _InitAutoPlayButtons()
		{
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58E")]
		[Address(RVA = "0x345D520", Offset = "0x345C120", VA = "0x18345D520")]
		private void _OnAutoModeChanged()
		{
		}

		// Token: 0x0600C58F RID: 50575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58F")]
		[Address(RVA = "0x345DA90", Offset = "0x345C690", VA = "0x18345DA90")]
		private void _OnSpeedChanged()
		{
		}

		// Token: 0x0600C590 RID: 50576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C590")]
		[Address(RVA = "0x345D880", Offset = "0x345C480", VA = "0x18345D880")]
		private void _OnSpeedButtonClicked()
		{
		}

		// Token: 0x0600C591 RID: 50577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C591")]
		[Address(RVA = "0x345D620", Offset = "0x345C220", VA = "0x18345D620")]
		private void _OnReaderViewDrag()
		{
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C592")]
		[Address(RVA = "0x345E550", Offset = "0x345D150", VA = "0x18345E550")]
		private void _UpdateSpeedButton()
		{
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C593")]
		[Address(RVA = "0x345E430", Offset = "0x345D030", VA = "0x18345E430")]
		private void _UpdateButtonVisibility()
		{
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C594")]
		[Address(RVA = "0x345DFB0", Offset = "0x345CBB0", VA = "0x18345DFB0")]
		private void _ShowBriefInternal()
		{
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C595")]
		[Address(RVA = "0x345DAF0", Offset = "0x345C6F0", VA = "0x18345DAF0")]
		private void _OpenReaderSettingDialog()
		{
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C596")]
		[Address(RVA = "0x345CE20", Offset = "0x345BA20", VA = "0x18345CE20")]
		private void _CloseSettingDialog()
		{
		}

		// Token: 0x0600C597 RID: 50583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C597")]
		[Address(RVA = "0x345D7B0", Offset = "0x345C3B0", VA = "0x18345D7B0")]
		private void _OnSettingDialogOpened(int instId)
		{
		}

		// Token: 0x0600C598 RID: 50584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C598")]
		[Address(RVA = "0x345D6E0", Offset = "0x345C2E0", VA = "0x18345D6E0")]
		private void _OnSettingDialogClosed()
		{
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C599")]
		[Address(RVA = "0x345BCF0", Offset = "0x345A8F0", VA = "0x18345BCF0")]
		public void EventOnAutoButtonClicked()
		{
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59A")]
		[Address(RVA = "0x345BFE0", Offset = "0x345ABE0", VA = "0x18345BFE0")]
		public void EventOnHideAll()
		{
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59B")]
		[Address(RVA = "0x345BE70", Offset = "0x345AA70", VA = "0x18345BE70")]
		public void EventOnExitHide()
		{
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59C")]
		[Address(RVA = "0x345DDF0", Offset = "0x345C9F0", VA = "0x18345DDF0")]
		private void _ProcessHideObjects(bool active)
		{
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59D")]
		[Address(RVA = "0x345BE10", Offset = "0x345AA10", VA = "0x18345BE10")]
		public void EventOnBriefShow()
		{
		}

		// Token: 0x0600C59E RID: 50590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59E")]
		[Address(RVA = "0x345C0C0", Offset = "0x345ACC0", VA = "0x18345C0C0")]
		public void EventOnSettingClicked()
		{
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59F")]
		[Address(RVA = "0x345BF50", Offset = "0x345AB50", VA = "0x18345BF50")]
		public void EventOnExitReaderMode()
		{
		}

		// Token: 0x0600C5A0 RID: 50592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A0")]
		[Address(RVA = "0x345C730", Offset = "0x345B330", VA = "0x18345C730", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0600C5A1 RID: 50593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A1")]
		[Address(RVA = "0x345C130", Offset = "0x345AD30", VA = "0x18345C130", Slot = "20")]
		public void HandleDialogDestroyedCallback(int instId)
		{
		}

		// Token: 0x0600C5A2 RID: 50594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A2")]
		[Address(RVA = "0x345E7E0", Offset = "0x345D3E0", VA = "0x18345E7E0")]
		public AVGReaderMainDialog()
		{
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A4")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A5")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x0400CA49 RID: 51785
		[Token(Token = "0x400CA49")]
		public const int MSG_DRAG = 0;

		// Token: 0x0400CA4A RID: 51786
		[Token(Token = "0x400CA4A")]
		public const int MSG_SKIP = 1;

		// Token: 0x0400CA4B RID: 51787
		[Token(Token = "0x400CA4B")]
		public const int MSG_HIDE_SETTING = 2;

		// Token: 0x0400CA4C RID: 51788
		[Token(Token = "0x400CA4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AVGReaderModeView _view;

		// Token: 0x0400CA4D RID: 51789
		[Token(Token = "0x400CA4D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AVGReaderModeAutoButton _readerAutoBtn;

		// Token: 0x0400CA4E RID: 51790
		[Token(Token = "0x400CA4E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AVGReaderModeSpeedButton _readerSpeedBtn;

		// Token: 0x0400CA4F RID: 51791
		[Token(Token = "0x400CA4F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AVGReaderModeImageView _imageView;

		// Token: 0x0400CA50 RID: 51792
		[Token(Token = "0x400CA50")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AVGReaderModeImageView _bgView;

		// Token: 0x0400CA51 RID: 51793
		[Token(Token = "0x400CA51")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AVGReaderModeLargeBackgroundView _largeBgView;

		// Token: 0x0400CA52 RID: 51794
		[Token(Token = "0x400CA52")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AVGReaderModeShowItemView _itemView;

		// Token: 0x0400CA53 RID: 51795
		[Token(Token = "0x400CA53")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AVGReaderModeCgItemView _cgItemView;

		// Token: 0x0400CA54 RID: 51796
		[Token(Token = "0x400CA54")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AVGReaderModeCharSlotView _charSlotView;

		// Token: 0x0400CA55 RID: 51797
		[Token(Token = "0x400CA55")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _btnPanel;

		// Token: 0x0400CA56 RID: 51798
		[Token(Token = "0x400CA56")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _hideAllBlocker;

		// Token: 0x0400CA57 RID: 51799
		[Token(Token = "0x400CA57")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject[] _objToHide;

		// Token: 0x0400CA58 RID: 51800
		[Token(Token = "0x400CA58")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _clickAutoDelay;

		// Token: 0x0400CA59 RID: 51801
		[Token(Token = "0x400CA59")]
		[FieldOffset(Offset = "0xD8")]
		private AVGReaderModeAdapter m_cmdExecutor;

		// Token: 0x0400CA5A RID: 51802
		[Token(Token = "0x400CA5A")]
		[FieldOffset(Offset = "0xE0")]
		private AVGReaderModeAutoPlayController m_autoPlayController;

		// Token: 0x0400CA5B RID: 51803
		[Token(Token = "0x400CA5B")]
		[FieldOffset(Offset = "0xE8")]
		private AVGReaderModePerformanceAdapter m_performExecutor;

		// Token: 0x0400CA5C RID: 51804
		[Token(Token = "0x400CA5C")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_hasInited;

		// Token: 0x0400CA5D RID: 51805
		[Token(Token = "0x400CA5D")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_settingShowing;

		// Token: 0x0400CA5E RID: 51806
		[Token(Token = "0x400CA5E")]
		[FieldOffset(Offset = "0xF4")]
		private int m_settingDialogInstId;

		// Token: 0x0400CA5F RID: 51807
		[Token(Token = "0x400CA5F")]
		[FieldOffset(Offset = "0xF8")]
		private AVGUIStateEngineController m_uiController;

		// Token: 0x0400CA60 RID: 51808
		[Token(Token = "0x400CA60")]
		private const string AVG_READER_SETTING_DLG_PATH = "AVG/[UC]Common/Reader/avg_reader_setting_dialog.prefab";

		// Token: 0x0400CA61 RID: 51809
		[Token(Token = "0x400CA61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400CA62 RID: 51810
		[Token(Token = "0x400CA62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400CA63 RID: 51811
		[Token(Token = "0x400CA63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400CA64 RID: 51812
		[Token(Token = "0x400CA64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BindBackPress;

		// Token: 0x0400CA65 RID: 51813
		[Token(Token = "0x400CA65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0400CA66 RID: 51814
		[Token(Token = "0x400CA66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryBindView;

		// Token: 0x0400CA67 RID: 51815
		[Token(Token = "0x400CA67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BindViews;

		// Token: 0x0400CA68 RID: 51816
		[Token(Token = "0x400CA68")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x0400CA69 RID: 51817
		[Token(Token = "0x400CA69")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitAutoPlayButtons;

		// Token: 0x0400CA6A RID: 51818
		[Token(Token = "0x400CA6A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnAutoModeChanged;

		// Token: 0x0400CA6B RID: 51819
		[Token(Token = "0x400CA6B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSpeedChanged;

		// Token: 0x0400CA6C RID: 51820
		[Token(Token = "0x400CA6C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSpeedButtonClicked;

		// Token: 0x0400CA6D RID: 51821
		[Token(Token = "0x400CA6D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnReaderViewDrag;

		// Token: 0x0400CA6E RID: 51822
		[Token(Token = "0x400CA6E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateSpeedButton;

		// Token: 0x0400CA6F RID: 51823
		[Token(Token = "0x400CA6F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateButtonVisibility;

		// Token: 0x0400CA70 RID: 51824
		[Token(Token = "0x400CA70")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ShowBriefInternal;

		// Token: 0x0400CA71 RID: 51825
		[Token(Token = "0x400CA71")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenReaderSettingDialog;

		// Token: 0x0400CA72 RID: 51826
		[Token(Token = "0x400CA72")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CloseSettingDialog;

		// Token: 0x0400CA73 RID: 51827
		[Token(Token = "0x400CA73")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSettingDialogOpened;

		// Token: 0x0400CA74 RID: 51828
		[Token(Token = "0x400CA74")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSettingDialogClosed;

		// Token: 0x0400CA75 RID: 51829
		[Token(Token = "0x400CA75")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnAutoButtonClicked;

		// Token: 0x0400CA76 RID: 51830
		[Token(Token = "0x400CA76")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnHideAll;

		// Token: 0x0400CA77 RID: 51831
		[Token(Token = "0x400CA77")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnExitHide;

		// Token: 0x0400CA78 RID: 51832
		[Token(Token = "0x400CA78")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ProcessHideObjects;

		// Token: 0x0400CA79 RID: 51833
		[Token(Token = "0x400CA79")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnBriefShow;

		// Token: 0x0400CA7A RID: 51834
		[Token(Token = "0x400CA7A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnSettingClicked;

		// Token: 0x0400CA7B RID: 51835
		[Token(Token = "0x400CA7B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnExitReaderMode;

		// Token: 0x0400CA7C RID: 51836
		[Token(Token = "0x400CA7C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400CA7D RID: 51837
		[Token(Token = "0x400CA7D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_HandleDialogDestroyedCallback;

		// Token: 0x0400CA7E RID: 51838
		[Token(Token = "0x400CA7E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F1A RID: 7962
		[Token(Token = "0x2001F1A")]
		public class Input
		{
			// Token: 0x0600C5A6 RID: 50598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C5A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0400CA7F RID: 51839
			[Token(Token = "0x400CA7F")]
			[FieldOffset(Offset = "0x10")]
			public AVGReaderModeAdapter adapter;

			// Token: 0x0400CA80 RID: 51840
			[Token(Token = "0x400CA80")]
			[FieldOffset(Offset = "0x18")]
			public AVGReaderModePerformanceAdapter performanceAdapter;

			// Token: 0x0400CA81 RID: 51841
			[Token(Token = "0x400CA81")]
			[FieldOffset(Offset = "0x20")]
			public AVGReaderModeAutoPlayController autoPlayController;

			// Token: 0x0400CA82 RID: 51842
			[Token(Token = "0x400CA82")]
			[FieldOffset(Offset = "0x28")]
			public AVGUIStateEngineController uiController;
		}
	}
}
