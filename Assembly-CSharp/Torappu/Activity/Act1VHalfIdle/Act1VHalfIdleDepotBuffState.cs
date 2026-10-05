using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200779B RID: 30619
	[Token(Token = "0x200779B")]
	public class Act1VHalfIdleDepotBuffState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602AFDE RID: 176094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AFDE")]
		[Address(RVA = "0x26C8F20", Offset = "0x26C7B20", VA = "0x1826C8F20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AFDF RID: 176095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFDF")]
		[Address(RVA = "0x26C9380", Offset = "0x26C7F80", VA = "0x1826C9380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AFE0 RID: 176096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE0")]
		[Address(RVA = "0x26C8F80", Offset = "0x26C7B80", VA = "0x1826C8F80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AFE1 RID: 176097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE1")]
		[Address(RVA = "0x26C9290", Offset = "0x26C7E90", VA = "0x1826C9290", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602AFE2 RID: 176098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE2")]
		[Address(RVA = "0x26C9830", Offset = "0x26C8430", VA = "0x1826C9830")]
		private void _OnTopMenuCreated(GameObject obj)
		{
		}

		// Token: 0x0602AFE3 RID: 176099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE3")]
		[Address(RVA = "0x26C9490", Offset = "0x26C8090", VA = "0x1826C9490")]
		private void _OnBtnBackClicked()
		{
		}

		// Token: 0x0602AFE4 RID: 176100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE4")]
		[Address(RVA = "0x26C91C0", Offset = "0x26C7DC0", VA = "0x1826C91C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602AFE5 RID: 176101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE5")]
		[Address(RVA = "0x26C95B0", Offset = "0x26C81B0", VA = "0x1826C95B0")]
		private void _OnBuffClick(int profIndex)
		{
		}

		// Token: 0x0602AFE6 RID: 176102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE6")]
		[Address(RVA = "0x26C9980", Offset = "0x26C8580", VA = "0x1826C9980")]
		public Act1VHalfIdleDepotBuffState()
		{
		}

		// Token: 0x0602AFE7 RID: 176103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AFE8 RID: 176104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE8")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0403E0DD RID: 254173
		[Token(Token = "0x403E0DD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuPrefabHolder;

		// Token: 0x0403E0DE RID: 254174
		[Token(Token = "0x403E0DE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleDepotBuffView _view;

		// Token: 0x0403E0DF RID: 254175
		[Token(Token = "0x403E0DF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403E0E0 RID: 254176
		[Token(Token = "0x403E0E0")]
		[FieldOffset(Offset = "0x84")]
		private int m_detailInst;

		// Token: 0x0403E0E1 RID: 254177
		[Token(Token = "0x403E0E1")]
		[FieldOffset(Offset = "0x88")]
		private Act1VHalfIdleDepotBuffStateBean m_stateBean;

		// Token: 0x0403E0E2 RID: 254178
		[Token(Token = "0x403E0E2")]
		[NonSerialized]
		public const int ON_BUFF_ITEM_CLICK = 0;

		// Token: 0x0403E0E3 RID: 254179
		[Token(Token = "0x403E0E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E0E4 RID: 254180
		[Token(Token = "0x403E0E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E0E5 RID: 254181
		[Token(Token = "0x403E0E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E0E6 RID: 254182
		[Token(Token = "0x403E0E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403E0E7 RID: 254183
		[Token(Token = "0x403E0E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTopMenuCreated;

		// Token: 0x0403E0E8 RID: 254184
		[Token(Token = "0x403E0E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBtnBackClicked;

		// Token: 0x0403E0E9 RID: 254185
		[Token(Token = "0x403E0E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403E0EA RID: 254186
		[Token(Token = "0x403E0EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBuffClick;

		// Token: 0x0403E0EB RID: 254187
		[Token(Token = "0x403E0EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
