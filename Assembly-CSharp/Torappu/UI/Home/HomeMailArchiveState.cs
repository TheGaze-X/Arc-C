using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B19 RID: 19225
	[Token(Token = "0x2004B19")]
	public class HomeMailArchiveState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601CE91 RID: 118417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE91")]
		[Address(RVA = "0x1658370", Offset = "0x1656F70", VA = "0x181658370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE92")]
		[Address(RVA = "0x16583D0", Offset = "0x1656FD0", VA = "0x1816583D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CE93 RID: 118419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE93")]
		[Address(RVA = "0x16587C0", Offset = "0x16573C0", VA = "0x1816587C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE94")]
		[Address(RVA = "0x16589D0", Offset = "0x16575D0", VA = "0x1816589D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE95")]
		[Address(RVA = "0x1658250", Offset = "0x1656E50", VA = "0x181658250")]
		public void EventOnMailClicked()
		{
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE96")]
		[Address(RVA = "0x1658120", Offset = "0x1656D20", VA = "0x181658120")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601CE97 RID: 118423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE97")]
		[Address(RVA = "0x1658F60", Offset = "0x1657B60", VA = "0x181658F60")]
		private void _OnGetListProceed(MailCollectionGetListResponse response)
		{
		}

		// Token: 0x0601CE98 RID: 118424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE98")]
		[Address(RVA = "0x1658C50", Offset = "0x1657850", VA = "0x181658C50")]
		private void _EventOnItemClicked(string itemId)
		{
		}

		// Token: 0x0601CE99 RID: 118425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE99")]
		[Address(RVA = "0x1658B30", Offset = "0x1657730", VA = "0x181658B30")]
		private void _EventOnBarItemClicked(int year)
		{
		}

		// Token: 0x0601CE9A RID: 118426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE9A")]
		[Address(RVA = "0x1658E40", Offset = "0x1657A40", VA = "0x181658E40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CE9B RID: 118427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE9B")]
		[Address(RVA = "0x1659020", Offset = "0x1657C20", VA = "0x181659020")]
		private void _OnJumpToArchiveDetailState(IStateBean sb)
		{
		}

		// Token: 0x0601CE9C RID: 118428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE9C")]
		[Address(RVA = "0x1659150", Offset = "0x1657D50", VA = "0x181659150")]
		public HomeMailArchiveState()
		{
		}

		// Token: 0x0601CE9D RID: 118429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE9D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CE9E RID: 118430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE9E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04025EED RID: 155373
		[Token(Token = "0x4025EED")]
		[NonSerialized]
		public const int ON_BAR_ITEM_CLICKED = 0;

		// Token: 0x04025EEE RID: 155374
		[Token(Token = "0x4025EEE")]
		[NonSerialized]
		public const int ON_ARCHIVE_ITEM_CLICKED = 1;

		// Token: 0x04025EEF RID: 155375
		[Token(Token = "0x4025EEF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgBlurBkg;

		// Token: 0x04025EF0 RID: 155376
		[Token(Token = "0x4025EF0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04025EF1 RID: 155377
		[Token(Token = "0x4025EF1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HomeMailArchiveListView _listView;

		// Token: 0x04025EF2 RID: 155378
		[Token(Token = "0x4025EF2")]
		[FieldOffset(Offset = "0x88")]
		private HomeMailArchiveStateBean m_stateBean;

		// Token: 0x04025EF3 RID: 155379
		[Token(Token = "0x4025EF3")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04025EF4 RID: 155380
		[Token(Token = "0x4025EF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025EF5 RID: 155381
		[Token(Token = "0x4025EF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025EF6 RID: 155382
		[Token(Token = "0x4025EF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025EF7 RID: 155383
		[Token(Token = "0x4025EF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025EF8 RID: 155384
		[Token(Token = "0x4025EF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMailClicked;

		// Token: 0x04025EF9 RID: 155385
		[Token(Token = "0x4025EF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04025EFA RID: 155386
		[Token(Token = "0x4025EFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnGetListProceed;

		// Token: 0x04025EFB RID: 155387
		[Token(Token = "0x4025EFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x04025EFC RID: 155388
		[Token(Token = "0x4025EFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBarItemClicked;

		// Token: 0x04025EFD RID: 155389
		[Token(Token = "0x4025EFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025EFE RID: 155390
		[Token(Token = "0x4025EFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnJumpToArchiveDetailState;

		// Token: 0x04025EFF RID: 155391
		[Token(Token = "0x4025EFF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
