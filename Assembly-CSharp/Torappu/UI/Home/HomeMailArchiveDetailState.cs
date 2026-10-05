using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B17 RID: 19223
	[Token(Token = "0x2004B17")]
	public class HomeMailArchiveDetailState : PopupFloatState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601CE86 RID: 118406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE86")]
		[Address(RVA = "0x16575A0", Offset = "0x16561A0", VA = "0x1816575A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CE87 RID: 118407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE87")]
		[Address(RVA = "0x1657540", Offset = "0x1656140", VA = "0x181657540", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CE88 RID: 118408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE88")]
		[Address(RVA = "0x16577B0", Offset = "0x16563B0", VA = "0x1816577B0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CE89 RID: 118409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE89")]
		[Address(RVA = "0x16574E0", Offset = "0x16560E0", VA = "0x1816574E0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601CE8A RID: 118410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8A")]
		[Address(RVA = "0x1657A90", Offset = "0x1656690", VA = "0x181657A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CE8B RID: 118411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8B")]
		[Address(RVA = "0x1657BE0", Offset = "0x16567E0", VA = "0x181657BE0")]
		private void _OnCloseImpl()
		{
		}

		// Token: 0x0601CE8C RID: 118412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8C")]
		[Address(RVA = "0x1657E40", Offset = "0x1656A40", VA = "0x181657E40")]
		private void _OnPrevClick()
		{
		}

		// Token: 0x0601CE8D RID: 118413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8D")]
		[Address(RVA = "0x1657D10", Offset = "0x1656910", VA = "0x181657D10")]
		private void _OnNextClick()
		{
		}

		// Token: 0x0601CE8E RID: 118414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8E")]
		[Address(RVA = "0x1657F50", Offset = "0x1656B50", VA = "0x181657F50")]
		public HomeMailArchiveDetailState()
		{
		}

		// Token: 0x0601CE8F RID: 118415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE8F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04025EDB RID: 155355
		[Token(Token = "0x4025EDB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _bactRect;

		// Token: 0x04025EDC RID: 155356
		[Token(Token = "0x4025EDC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeMailArchiveDetailView _view;

		// Token: 0x04025EDD RID: 155357
		[Token(Token = "0x4025EDD")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04025EDE RID: 155358
		[Token(Token = "0x4025EDE")]
		[FieldOffset(Offset = "0x88")]
		private HomeMailArchiveDetailStateBean m_stateBean;

		// Token: 0x04025EDF RID: 155359
		[Token(Token = "0x4025EDF")]
		[NonSerialized]
		public const int ON_PREV_CLICK = 0;

		// Token: 0x04025EE0 RID: 155360
		[Token(Token = "0x4025EE0")]
		[NonSerialized]
		public const int ON_NEXT_CLICK = 1;

		// Token: 0x04025EE1 RID: 155361
		[Token(Token = "0x4025EE1")]
		[NonSerialized]
		public const int ON_CLOSE_CLICK = 2;

		// Token: 0x04025EE2 RID: 155362
		[Token(Token = "0x4025EE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025EE3 RID: 155363
		[Token(Token = "0x4025EE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025EE4 RID: 155364
		[Token(Token = "0x4025EE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025EE5 RID: 155365
		[Token(Token = "0x4025EE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04025EE6 RID: 155366
		[Token(Token = "0x4025EE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025EE7 RID: 155367
		[Token(Token = "0x4025EE7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCloseImpl;

		// Token: 0x04025EE8 RID: 155368
		[Token(Token = "0x4025EE8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPrevClick;

		// Token: 0x04025EE9 RID: 155369
		[Token(Token = "0x4025EE9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnNextClick;

		// Token: 0x04025EEA RID: 155370
		[Token(Token = "0x4025EEA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
