using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006543 RID: 25923
	[Token(Token = "0x2006543")]
	public class ArtMagazineDiyPage : StateEnginePage, IValueMsgReceiver, ICompDialogCallBack, IDialogMgrHolder
	{
		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x06025439 RID: 152633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005805")]
		public string leafId
		{
			[Token(Token = "0x6025439")]
			[Address(RVA = "0x203BD20", Offset = "0x203A920", VA = "0x18203BD20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x0602543A RID: 152634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005806")]
		public ArtMagazineDiyLeafCharIllustHolder.LeafCharSkinWrapper charSkinWrapper
		{
			[Token(Token = "0x602543A")]
			[Address(RVA = "0x203BCC0", Offset = "0x203A8C0", VA = "0x18203BCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602543B RID: 152635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602543B")]
		[Address(RVA = "0x20374F0", Offset = "0x20360F0", VA = "0x1820374F0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602543C RID: 152636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602543C")]
		[Address(RVA = "0x20383F0", Offset = "0x2036FF0", VA = "0x1820383F0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602543D RID: 152637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602543D")]
		[Address(RVA = "0x2037440", Offset = "0x2036040", VA = "0x182037440", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602543E RID: 152638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602543E")]
		[Address(RVA = "0x2037590", Offset = "0x2036190", VA = "0x182037590", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602543F RID: 152639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602543F")]
		[Address(RVA = "0x20373B0", Offset = "0x2035FB0", VA = "0x1820373B0", Slot = "30")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06025440 RID: 152640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025440")]
		[Address(RVA = "0x2037350", Offset = "0x2035F50", VA = "0x182037350", Slot = "32")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x06025441 RID: 152641 RVA: 0x000C7488 File Offset: 0x000C5688
		[Token(Token = "0x6025441")]
		[Address(RVA = "0x203A050", Offset = "0x2038C50", VA = "0x18203A050")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x06025442 RID: 152642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025442")]
		private void _OpenStateWhenStable<T>() where T : State
		{
		}

		// Token: 0x06025443 RID: 152643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025443")]
		private void _RemoveToStateWhenStable<T>() where T : State
		{
		}

		// Token: 0x06025444 RID: 152644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025444")]
		[Address(RVA = "0x2039A40", Offset = "0x2038640", VA = "0x182039A40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025445 RID: 152645 RVA: 0x000C74A0 File Offset: 0x000C56A0
		[Token(Token = "0x6025445")]
		[Address(RVA = "0x2039650", Offset = "0x2038250", VA = "0x182039650")]
		private ArtMagazineDiyDecorTabType _GetFirstValidTabType(ArtMagazineDiyHomeViewModel model)
		{
			return ArtMagazineDiyDecorTabType.NONE;
		}

		// Token: 0x06025446 RID: 152646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025446")]
		[Address(RVA = "0x203AD60", Offset = "0x2039960", VA = "0x18203AD60")]
		private void _OpenTab(long intVal)
		{
		}

		// Token: 0x06025447 RID: 152647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025447")]
		[Address(RVA = "0x203ABA0", Offset = "0x20397A0", VA = "0x18203ABA0")]
		private void _OpenTab(ArtMagazineDiyDecorTabType tabType)
		{
		}

		// Token: 0x06025448 RID: 152648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025448")]
		[Address(RVA = "0x203A420", Offset = "0x2039020", VA = "0x18203A420")]
		private void _OnLeafElementSelected(string leafElementId)
		{
		}

		// Token: 0x06025449 RID: 152649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025449")]
		[Address(RVA = "0x203A4F0", Offset = "0x20390F0", VA = "0x18203A4F0")]
		private void _OnLeafElementSwitch(string leafElementId)
		{
		}

		// Token: 0x0602544A RID: 152650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602544A")]
		[Address(RVA = "0x203A300", Offset = "0x2038F00", VA = "0x18203A300")]
		private void _OnLeafElementDelete(string leafElementId)
		{
		}

		// Token: 0x0602544B RID: 152651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602544B")]
		[Address(RVA = "0x203A240", Offset = "0x2038E40", VA = "0x18203A240")]
		private void _OnClearLeafElementSelection()
		{
		}

		// Token: 0x0602544C RID: 152652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602544C")]
		[Address(RVA = "0x2038E10", Offset = "0x2037A10", VA = "0x182038E10")]
		private ArtMagazineLeafData _GenArtMagazineLeafData()
		{
			return null;
		}

		// Token: 0x0602544D RID: 152653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602544D")]
		[Address(RVA = "0x203A630", Offset = "0x2039230", VA = "0x18203A630")]
		private void _OnSaveLeaf()
		{
		}

		// Token: 0x0602544E RID: 152654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602544E")]
		[Address(RVA = "0x203B2D0", Offset = "0x2039ED0", VA = "0x18203B2D0")]
		private void _SelectItem(object objVal)
		{
		}

		// Token: 0x0602544F RID: 152655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602544F")]
		[Address(RVA = "0x203B5B0", Offset = "0x203A1B0", VA = "0x18203B5B0")]
		private void _SetSorter(object objVal)
		{
		}

		// Token: 0x06025450 RID: 152656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025450")]
		[Address(RVA = "0x203B3B0", Offset = "0x2039FB0", VA = "0x18203B3B0")]
		private void _SetFilter(object objVal)
		{
		}

		// Token: 0x06025451 RID: 152657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025451")]
		[Address(RVA = "0x203B9D0", Offset = "0x203A5D0", VA = "0x18203B9D0")]
		private void _UnselectItem(object objVal)
		{
		}

		// Token: 0x06025452 RID: 152658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025452")]
		[Address(RVA = "0x203BAB0", Offset = "0x203A6B0", VA = "0x18203BAB0")]
		private void _UnselectType(long intVal)
		{
		}

		// Token: 0x06025453 RID: 152659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025453")]
		[Address(RVA = "0x203B790", Offset = "0x203A390", VA = "0x18203B790")]
		private void _UnselectAll()
		{
		}

		// Token: 0x06025454 RID: 152660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025454")]
		[Address(RVA = "0x203A180", Offset = "0x2038D80", VA = "0x18203A180")]
		private void _NotifySysUpdate()
		{
		}

		// Token: 0x06025455 RID: 152661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025455")]
		[Address(RVA = "0x20389B0", Offset = "0x20375B0", VA = "0x1820389B0")]
		private void _ApplyLeafPresetData()
		{
		}

		// Token: 0x06025456 RID: 152662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025456")]
		[Address(RVA = "0x2038B90", Offset = "0x2037790", VA = "0x182038B90")]
		private void _ClosePageWithCheckingDiff()
		{
		}

		// Token: 0x06025457 RID: 152663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025457")]
		[Address(RVA = "0x203B010", Offset = "0x2039C10", VA = "0x18203B010")]
		private void _RecordSkinLayout()
		{
		}

		// Token: 0x06025458 RID: 152664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025458")]
		[Address(RVA = "0x203AEF0", Offset = "0x2039AF0", VA = "0x18203AEF0")]
		private void _RecordSelectingSkinId()
		{
		}

		// Token: 0x06025459 RID: 152665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025459")]
		[Address(RVA = "0x2038AF0", Offset = "0x20376F0", VA = "0x182038AF0")]
		private void _ApplySelectingSkinId()
		{
		}

		// Token: 0x0602545A RID: 152666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545A")]
		[Address(RVA = "0x203B110", Offset = "0x2039D10", VA = "0x18203B110")]
		private void _RegisterCharSkinWrapper(object objVal)
		{
		}

		// Token: 0x0602545B RID: 152667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545B")]
		[Address(RVA = "0x203B1F0", Offset = "0x2039DF0", VA = "0x18203B1F0")]
		private void _ResetCharSkin(string itemId)
		{
		}

		// Token: 0x0602545C RID: 152668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545C")]
		[Address(RVA = "0x2037160", Offset = "0x2035D60", VA = "0x182037160")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x0602545D RID: 152669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545D")]
		[Address(RVA = "0x2037210", Offset = "0x2035E10", VA = "0x182037210")]
		public void EventOnClearLeafElementSelection()
		{
		}

		// Token: 0x0602545E RID: 152670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545E")]
		[Address(RVA = "0x2037010", Offset = "0x2035C10", VA = "0x182037010")]
		public void BindDataBinder(DataBinder<ArtMagazineDiyHomeProperty> dataBinder)
		{
		}

		// Token: 0x0602545F RID: 152671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602545F")]
		[Address(RVA = "0x20387E0", Offset = "0x20373E0", VA = "0x1820387E0")]
		public void UnbindDataBinder(DataBinder<ArtMagazineDiyHomeProperty> dataBinder)
		{
		}

		// Token: 0x06025460 RID: 152672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025460")]
		[Address(RVA = "0x2038880", Offset = "0x2037480", VA = "0x182038880")]
		public void UpdateLeafViewDisplayOptions(ArtMagazineDiyPage.LeafViewDisplayOptions displayOptions)
		{
		}

		// Token: 0x06025461 RID: 152673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025461")]
		[Address(RVA = "0x2038530", Offset = "0x2037130", VA = "0x182038530")]
		public void OpenDecorPanel()
		{
		}

		// Token: 0x06025462 RID: 152674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025462")]
		[Address(RVA = "0x20370B0", Offset = "0x2035CB0", VA = "0x1820370B0")]
		public void CloseDecorPanel()
		{
		}

		// Token: 0x06025463 RID: 152675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025463")]
		[Address(RVA = "0x2038680", Offset = "0x2037280", VA = "0x182038680")]
		public void TrySetEditingLeafElementIdDuringTouch(string itemId)
		{
		}

		// Token: 0x06025464 RID: 152676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025464")]
		[Address(RVA = "0x20385D0", Offset = "0x20371D0", VA = "0x1820385D0")]
		public void TryClearEditingLeafElementIdDuringTouch()
		{
		}

		// Token: 0x06025465 RID: 152677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025465")]
		[Address(RVA = "0x203BBC0", Offset = "0x203A7C0", VA = "0x18203BBC0")]
		public ArtMagazineDiyPage()
		{
		}

		// Token: 0x06025468 RID: 152680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025468")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025469 RID: 152681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025469")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0602546A RID: 152682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602546A")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04034479 RID: 214137
		[Token(Token = "0x4034479")]
		[NonSerialized]
		public const int EVENT_OPEN_TEMPLATE_STATE = 0;

		// Token: 0x0403447A RID: 214138
		[Token(Token = "0x403447A")]
		[NonSerialized]
		public const int EVENT_OPEN_SKIN_SELECT_STATE = 1;

		// Token: 0x0403447B RID: 214139
		[Token(Token = "0x403447B")]
		[NonSerialized]
		public const int EVENT_OPEN_SKIN_EDIT_STATE = 2;

		// Token: 0x0403447C RID: 214140
		[Token(Token = "0x403447C")]
		[NonSerialized]
		public const int EVENT_OPEN_DECOR_STATE = 3;

		// Token: 0x0403447D RID: 214141
		[Token(Token = "0x403447D")]
		[NonSerialized]
		public const int EVENT_BACK_TO_HOME_STATE = 4;

		// Token: 0x0403447E RID: 214142
		[Token(Token = "0x403447E")]
		[NonSerialized]
		public const int EVENT_BACK_CLICKED = 5;

		// Token: 0x0403447F RID: 214143
		[Token(Token = "0x403447F")]
		[NonSerialized]
		public const int EVENT_OPEN_INIT_SKIN_SELECT_STATE = 6;

		// Token: 0x04034480 RID: 214144
		[Token(Token = "0x4034480")]
		[NonSerialized]
		public const int EVENT_LEAF_ELEMENT_SELECTED = 7;

		// Token: 0x04034481 RID: 214145
		[Token(Token = "0x4034481")]
		[NonSerialized]
		public const int EVENT_CLEAR_LEAF_ELEMENT_SELECTION = 8;

		// Token: 0x04034482 RID: 214146
		[Token(Token = "0x4034482")]
		[NonSerialized]
		public const int EVENT_SELECT_DIY_ITEM = 9;

		// Token: 0x04034483 RID: 214147
		[Token(Token = "0x4034483")]
		[NonSerialized]
		public const int EVENT_SORTER_CLICK = 10;

		// Token: 0x04034484 RID: 214148
		[Token(Token = "0x4034484")]
		[NonSerialized]
		public const int EVENT_FILTER_CLICK = 11;

		// Token: 0x04034485 RID: 214149
		[Token(Token = "0x4034485")]
		[NonSerialized]
		public const int EVENT_UNSELECT_DIY_ITEM = 12;

		// Token: 0x04034486 RID: 214150
		[Token(Token = "0x4034486")]
		[NonSerialized]
		public const int EVENT_UNSELECT_TYPE_ITEMS = 13;

		// Token: 0x04034487 RID: 214151
		[Token(Token = "0x4034487")]
		[NonSerialized]
		public const int EVENT_UNSELECT_ALL = 14;

		// Token: 0x04034488 RID: 214152
		[Token(Token = "0x4034488")]
		[NonSerialized]
		public const int EVENT_LEAF_ELEMENT_SWITCH = 15;

		// Token: 0x04034489 RID: 214153
		[Token(Token = "0x4034489")]
		[NonSerialized]
		public const int EVENT_LEAF_ELEMENT_DELETE = 16;

		// Token: 0x0403448A RID: 214154
		[Token(Token = "0x403448A")]
		[NonSerialized]
		public const int EVENT_SAVE_LEAF = 20;

		// Token: 0x0403448B RID: 214155
		[Token(Token = "0x403448B")]
		[NonSerialized]
		public const int EVENT_RECORD_CHAR_SKIN_LAYOUT = 30;

		// Token: 0x0403448C RID: 214156
		[Token(Token = "0x403448C")]
		[NonSerialized]
		public const int EVENT_REGISTER_SKIN_WRAPPER = 31;

		// Token: 0x0403448D RID: 214157
		[Token(Token = "0x403448D")]
		[NonSerialized]
		public const int EVENT_RESET_CHAR_SKIN = 32;

		// Token: 0x0403448E RID: 214158
		[Token(Token = "0x403448E")]
		[NonSerialized]
		public const int EVENT_RECORD_CHAR_SKIN_ID = 33;

		// Token: 0x0403448F RID: 214159
		[Token(Token = "0x403448F")]
		[NonSerialized]
		public const int EVENT_APPLY_CACHE_CHAR_SKIN_ID = 34;

		// Token: 0x04034490 RID: 214160
		[Token(Token = "0x4034490")]
		[NonSerialized]
		public const int EVENT_OPEN_DECOR_TAB = 50;

		// Token: 0x04034491 RID: 214161
		[Token(Token = "0x4034491")]
		[NonSerialized]
		public const int EVENT_APPLY_PRESET = 60;

		// Token: 0x04034492 RID: 214162
		[Token(Token = "0x4034492")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UITabPager _decorTabPager;

		// Token: 0x04034493 RID: 214163
		[Token(Token = "0x4034493")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ArtMagazineDiyBasicView _view;

		// Token: 0x04034494 RID: 214164
		[Token(Token = "0x4034494")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04034495 RID: 214165
		[Token(Token = "0x4034495")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ArtMagazineDiyLeafDragAndPinchController _dragAndPinchController;

		// Token: 0x04034496 RID: 214166
		[Token(Token = "0x4034496")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x04034497 RID: 214167
		[Token(Token = "0x4034497")]
		[FieldOffset(Offset = "0x118")]
		private ArtMagazineDiyPage.Param m_param;

		// Token: 0x04034498 RID: 214168
		[Token(Token = "0x4034498")]
		[FieldOffset(Offset = "0x120")]
		private ArtMagazineDiyHomeProperty m_homeProperty;

		// Token: 0x04034499 RID: 214169
		[Token(Token = "0x4034499")]
		[FieldOffset(Offset = "0x128")]
		private ListDict<string, UITabPager.TabPageViewModel> m_tabPageModels;

		// Token: 0x0403449A RID: 214170
		[Token(Token = "0x403449A")]
		[FieldOffset(Offset = "0x130")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x0403449B RID: 214171
		[Token(Token = "0x403449B")]
		[FieldOffset(Offset = "0x138")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403449C RID: 214172
		[Token(Token = "0x403449C")]
		[FieldOffset(Offset = "0x140")]
		private bool m_hasInited;

		// Token: 0x0403449D RID: 214173
		[Token(Token = "0x403449D")]
		[FieldOffset(Offset = "0x148")]
		private ArtMagazineLeafView.LeafTransformData m_cachedLeafTransformData;

		// Token: 0x0403449E RID: 214174
		[Token(Token = "0x403449E")]
		[FieldOffset(Offset = "0x170")]
		private ArtMagazineDiyLeafCharIllustHolder.LeafCharSkinWrapper m_charSkinWrapper;

		// Token: 0x0403449F RID: 214175
		[Token(Token = "0x403449F")]
		private const string TAB_DECOR_HOME_THEME = "tab_decor_home_theme";

		// Token: 0x040344A0 RID: 214176
		[Token(Token = "0x40344A0")]
		private const string TAB_DECOR_HOME_BACKGROUND = "tab_decor_home_background";

		// Token: 0x040344A1 RID: 214177
		[Token(Token = "0x40344A1")]
		private const string TAB_DECOR_NAME_CARD = "tab_decor_name_card";

		// Token: 0x040344A2 RID: 214178
		[Token(Token = "0x40344A2")]
		private const string TAB_DECOR_AVATAR = "tab_decor_avatar";

		// Token: 0x040344A3 RID: 214179
		[Token(Token = "0x40344A3")]
		private const string TAB_DECOR_STICKER = "tab_decor_sticker";

		// Token: 0x040344A4 RID: 214180
		[Token(Token = "0x40344A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_leafId;

		// Token: 0x040344A5 RID: 214181
		[Token(Token = "0x40344A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charSkinWrapper;

		// Token: 0x040344A6 RID: 214182
		[Token(Token = "0x40344A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040344A7 RID: 214183
		[Token(Token = "0x40344A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040344A8 RID: 214184
		[Token(Token = "0x40344A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040344A9 RID: 214185
		[Token(Token = "0x40344A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040344AA RID: 214186
		[Token(Token = "0x40344AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040344AB RID: 214187
		[Token(Token = "0x40344AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x040344AC RID: 214188
		[Token(Token = "0x40344AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x040344AD RID: 214189
		[Token(Token = "0x40344AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenStateWhenStable;

		// Token: 0x040344AE RID: 214190
		[Token(Token = "0x40344AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RemoveToStateWhenStable;

		// Token: 0x040344AF RID: 214191
		[Token(Token = "0x40344AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040344B0 RID: 214192
		[Token(Token = "0x40344B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetFirstValidTabType;

		// Token: 0x040344B1 RID: 214193
		[Token(Token = "0x40344B1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenTab;

		// Token: 0x040344B2 RID: 214194
		[Token(Token = "0x40344B2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1__OpenTab;

		// Token: 0x040344B3 RID: 214195
		[Token(Token = "0x40344B3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnLeafElementSelected;

		// Token: 0x040344B4 RID: 214196
		[Token(Token = "0x40344B4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnLeafElementSwitch;

		// Token: 0x040344B5 RID: 214197
		[Token(Token = "0x40344B5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnLeafElementDelete;

		// Token: 0x040344B6 RID: 214198
		[Token(Token = "0x40344B6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnClearLeafElementSelection;

		// Token: 0x040344B7 RID: 214199
		[Token(Token = "0x40344B7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenArtMagazineLeafData;

		// Token: 0x040344B8 RID: 214200
		[Token(Token = "0x40344B8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSaveLeaf;

		// Token: 0x040344B9 RID: 214201
		[Token(Token = "0x40344B9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x040344BA RID: 214202
		[Token(Token = "0x40344BA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SetSorter;

		// Token: 0x040344BB RID: 214203
		[Token(Token = "0x40344BB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SetFilter;

		// Token: 0x040344BC RID: 214204
		[Token(Token = "0x40344BC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UnselectItem;

		// Token: 0x040344BD RID: 214205
		[Token(Token = "0x40344BD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UnselectType;

		// Token: 0x040344BE RID: 214206
		[Token(Token = "0x40344BE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UnselectAll;

		// Token: 0x040344BF RID: 214207
		[Token(Token = "0x40344BF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__NotifySysUpdate;

		// Token: 0x040344C0 RID: 214208
		[Token(Token = "0x40344C0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ApplyLeafPresetData;

		// Token: 0x040344C1 RID: 214209
		[Token(Token = "0x40344C1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ClosePageWithCheckingDiff;

		// Token: 0x040344C2 RID: 214210
		[Token(Token = "0x40344C2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RecordSkinLayout;

		// Token: 0x040344C3 RID: 214211
		[Token(Token = "0x40344C3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RecordSelectingSkinId;

		// Token: 0x040344C4 RID: 214212
		[Token(Token = "0x40344C4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ApplySelectingSkinId;

		// Token: 0x040344C5 RID: 214213
		[Token(Token = "0x40344C5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__RegisterCharSkinWrapper;

		// Token: 0x040344C6 RID: 214214
		[Token(Token = "0x40344C6")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ResetCharSkin;

		// Token: 0x040344C7 RID: 214215
		[Token(Token = "0x40344C7")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x040344C8 RID: 214216
		[Token(Token = "0x40344C8")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EventOnClearLeafElementSelection;

		// Token: 0x040344C9 RID: 214217
		[Token(Token = "0x40344C9")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_BindDataBinder;

		// Token: 0x040344CA RID: 214218
		[Token(Token = "0x40344CA")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_UnbindDataBinder;

		// Token: 0x040344CB RID: 214219
		[Token(Token = "0x40344CB")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_UpdateLeafViewDisplayOptions;

		// Token: 0x040344CC RID: 214220
		[Token(Token = "0x40344CC")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OpenDecorPanel;

		// Token: 0x040344CD RID: 214221
		[Token(Token = "0x40344CD")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CloseDecorPanel;

		// Token: 0x040344CE RID: 214222
		[Token(Token = "0x40344CE")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_TrySetEditingLeafElementIdDuringTouch;

		// Token: 0x040344CF RID: 214223
		[Token(Token = "0x40344CF")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_TryClearEditingLeafElementIdDuringTouch;

		// Token: 0x040344D0 RID: 214224
		[Token(Token = "0x40344D0")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006544 RID: 25924
		[Token(Token = "0x2006544")]
		[Serializable]
		public struct LeafViewDisplayOptions
		{
			// Token: 0x040344D1 RID: 214225
			[Token(Token = "0x40344D1")]
			[FieldOffset(Offset = "0x0")]
			public bool charIllustInteractable;

			// Token: 0x040344D2 RID: 214226
			[Token(Token = "0x40344D2")]
			[FieldOffset(Offset = "0x1")]
			public bool leafElementInteractable;

			// Token: 0x040344D3 RID: 214227
			[Token(Token = "0x40344D3")]
			[FieldOffset(Offset = "0x4")]
			public ArtMagazineLeafViewDisplayType displayType;

			// Token: 0x040344D4 RID: 214228
			[Token(Token = "0x40344D4")]
			[FieldOffset(Offset = "0x8")]
			public bool useSmallLeafSize;
		}

		// Token: 0x02006545 RID: 25925
		[Token(Token = "0x2006545")]
		public class Param
		{
			// Token: 0x0602546B RID: 152683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602546B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040344D5 RID: 214229
			[Token(Token = "0x40344D5")]
			[FieldOffset(Offset = "0x10")]
			public string leafId;
		}

		// Token: 0x02006546 RID: 25926
		[Token(Token = "0x2006546")]
		private class TabCommonModel : UITabPager.TabPageViewModel
		{
			// Token: 0x0602546C RID: 152684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602546C")]
			[Address(RVA = "0x2055F60", Offset = "0x2054B60", VA = "0x182055F60")]
			public TabCommonModel(ArtMagazineDiyPage closure, ItemType type)
			{
			}

			// Token: 0x0602546D RID: 152685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602546D")]
			[Address(RVA = "0x2055E80", Offset = "0x2054A80", VA = "0x182055E80", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0602546E RID: 152686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602546E")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x040344D6 RID: 214230
			[Token(Token = "0x40344D6")]
			[FieldOffset(Offset = "0x30")]
			private ArtMagazineDiyPage m_closure;

			// Token: 0x040344D7 RID: 214231
			[Token(Token = "0x40344D7")]
			[FieldOffset(Offset = "0x38")]
			private ItemType m_type;

			// Token: 0x040344D8 RID: 214232
			[Token(Token = "0x40344D8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040344D9 RID: 214233
			[Token(Token = "0x40344D9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDialogInput;
		}

		// Token: 0x02006547 RID: 25927
		[Token(Token = "0x2006547")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x0602546F RID: 152687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602546F")]
			[Address(RVA = "0x2056180", Offset = "0x2054D80", VA = "0x182056180")]
			public TabDataSource(ArtMagazineDiyPage closure)
			{
			}

			// Token: 0x06025470 RID: 152688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025470")]
			[Address(RVA = "0x20560C0", Offset = "0x2054CC0", VA = "0x1820560C0", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x06025471 RID: 152689 RVA: 0x000C74B8 File Offset: 0x000C56B8
			[Token(Token = "0x6025471")]
			[Address(RVA = "0x2055FF0", Offset = "0x2054BF0", VA = "0x182055FF0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x040344DA RID: 214234
			[Token(Token = "0x40344DA")]
			[FieldOffset(Offset = "0x10")]
			private ArtMagazineDiyPage m_closure;

			// Token: 0x040344DB RID: 214235
			[Token(Token = "0x40344DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040344DC RID: 214236
			[Token(Token = "0x40344DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x040344DD RID: 214237
			[Token(Token = "0x40344DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTabCount;
		}
	}
}
