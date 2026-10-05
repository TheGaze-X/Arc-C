using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D5 RID: 26069
	[Token(Token = "0x20065D5")]
	public class ArtGalleryCollectDisplayState : PopupFadeState, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x06025785 RID: 153477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025785")]
		[Address(RVA = "0x205AA10", Offset = "0x2059610", VA = "0x18205AA10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025786 RID: 153478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025786")]
		[Address(RVA = "0x205B080", Offset = "0x2059C80", VA = "0x18205B080", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025787 RID: 153479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025787")]
		[Address(RVA = "0x205AA70", Offset = "0x2059670", VA = "0x18205AA70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025788 RID: 153480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025788")]
		[Address(RVA = "0x205AEE0", Offset = "0x2059AE0", VA = "0x18205AEE0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06025789 RID: 153481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025789")]
		[Address(RVA = "0x205B290", Offset = "0x2059E90", VA = "0x18205B290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602578A RID: 153482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578A")]
		[Address(RVA = "0x205B1E0", Offset = "0x2059DE0", VA = "0x18205B1E0")]
		private void _InitData()
		{
		}

		// Token: 0x0602578B RID: 153483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578B")]
		[Address(RVA = "0x205B9A0", Offset = "0x205A5A0", VA = "0x18205B9A0")]
		private void _UpdateData()
		{
		}

		// Token: 0x0602578C RID: 153484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578C")]
		[Address(RVA = "0x205B4D0", Offset = "0x205A0D0", VA = "0x18205B4D0")]
		private void _OnExitClick()
		{
		}

		// Token: 0x0602578D RID: 153485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578D")]
		[Address(RVA = "0x205B390", Offset = "0x2059F90", VA = "0x18205B390")]
		private void _OnDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578E")]
		[Address(RVA = "0x205ABB0", Offset = "0x20597B0", VA = "0x18205ABB0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602578F RID: 153487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602578F")]
		[Address(RVA = "0x205B8B0", Offset = "0x205A4B0", VA = "0x18205B8B0")]
		private void _OnSetBtnClick(string setId)
		{
		}

		// Token: 0x06025790 RID: 153488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025790")]
		[Address(RVA = "0x205B630", Offset = "0x205A230", VA = "0x18205B630")]
		private void _OnFilterItemClick(string setTypeId)
		{
		}

		// Token: 0x06025791 RID: 153489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025791")]
		[Address(RVA = "0x205B7D0", Offset = "0x205A3D0", VA = "0x18205B7D0")]
		private void _OnFilterPanelOpen()
		{
		}

		// Token: 0x06025792 RID: 153490 RVA: 0x000C8070 File Offset: 0x000C6270
		[Token(Token = "0x6025792")]
		[Address(RVA = "0x205B6F0", Offset = "0x205A2F0", VA = "0x18205B6F0")]
		private bool _OnFilterPanelClose()
		{
			return default(bool);
		}

		// Token: 0x06025793 RID: 153491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025793")]
		[Address(RVA = "0x205BA50", Offset = "0x205A650", VA = "0x18205BA50")]
		public ArtGalleryCollectDisplayState()
		{
		}

		// Token: 0x06025794 RID: 153492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025794")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025795 RID: 153493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025795")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025796 RID: 153494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025796")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x04034968 RID: 215400
		[Token(Token = "0x4034968")]
		[NonSerialized]
		public const int MSG_SET_CLICK = 0;

		// Token: 0x04034969 RID: 215401
		[Token(Token = "0x4034969")]
		[NonSerialized]
		public const int MSG_FILTER_ITEM_CLICK = 1;

		// Token: 0x0403496A RID: 215402
		[Token(Token = "0x403496A")]
		[NonSerialized]
		public const int MSG_FILTER_PANEL_OPEN = 2;

		// Token: 0x0403496B RID: 215403
		[Token(Token = "0x403496B")]
		[NonSerialized]
		public const int MSG_FILTER_PANEL_CLOSE = 3;

		// Token: 0x0403496C RID: 215404
		[Token(Token = "0x403496C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0403496D RID: 215405
		[Token(Token = "0x403496D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtGalleryCollectDisplayView _view;

		// Token: 0x0403496E RID: 215406
		[Token(Token = "0x403496E")]
		[FieldOffset(Offset = "0x80")]
		private string m_selectedSetId;

		// Token: 0x0403496F RID: 215407
		[Token(Token = "0x403496F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04034970 RID: 215408
		[Token(Token = "0x4034970")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034971 RID: 215409
		[Token(Token = "0x4034971")]
		[FieldOffset(Offset = "0xA0")]
		private ArtGalleryCollectDisplayProperty m_prop;

		// Token: 0x04034972 RID: 215410
		[Token(Token = "0x4034972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034973 RID: 215411
		[Token(Token = "0x4034973")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04034974 RID: 215412
		[Token(Token = "0x4034974")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034975 RID: 215413
		[Token(Token = "0x4034975")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04034976 RID: 215414
		[Token(Token = "0x4034976")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034977 RID: 215415
		[Token(Token = "0x4034977")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x04034978 RID: 215416
		[Token(Token = "0x4034978")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04034979 RID: 215417
		[Token(Token = "0x4034979")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnExitClick;

		// Token: 0x0403497A RID: 215418
		[Token(Token = "0x403497A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnDetailState;

		// Token: 0x0403497B RID: 215419
		[Token(Token = "0x403497B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403497C RID: 215420
		[Token(Token = "0x403497C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSetBtnClick;

		// Token: 0x0403497D RID: 215421
		[Token(Token = "0x403497D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnFilterItemClick;

		// Token: 0x0403497E RID: 215422
		[Token(Token = "0x403497E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnFilterPanelOpen;

		// Token: 0x0403497F RID: 215423
		[Token(Token = "0x403497F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnFilterPanelClose;

		// Token: 0x04034980 RID: 215424
		[Token(Token = "0x4034980")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
