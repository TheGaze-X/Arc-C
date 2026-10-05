using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006321 RID: 25377
	[Token(Token = "0x2006321")]
	public class AutoChessShopQuickAssistState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602496C RID: 149868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602496C")]
		[Address(RVA = "0x1F79A30", Offset = "0x1F78630", VA = "0x181F79A30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602496D RID: 149869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602496D")]
		[Address(RVA = "0x1F79A90", Offset = "0x1F78690", VA = "0x181F79A90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602496E RID: 149870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602496E")]
		[Address(RVA = "0x1F79EB0", Offset = "0x1F78AB0", VA = "0x181F79EB0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602496F RID: 149871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602496F")]
		[Address(RVA = "0x1F7A010", Offset = "0x1F78C10", VA = "0x181F7A010", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06024970 RID: 149872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024970")]
		[Address(RVA = "0x1F7ACE0", Offset = "0x1F798E0", VA = "0x181F7ACE0")]
		private void _RegisterFromCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x06024971 RID: 149873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024971")]
		[Address(RVA = "0x1F7AE60", Offset = "0x1F79A60", VA = "0x181F7AE60")]
		private void _RegisterToCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x06024972 RID: 149874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024972")]
		[Address(RVA = "0x1F7A170", Offset = "0x1F78D70", VA = "0x181F7A170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024973 RID: 149875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024973")]
		[Address(RVA = "0x1F7AF40", Offset = "0x1F79B40", VA = "0x181F7AF40")]
		private void _TryToTriggerShopAvg()
		{
		}

		// Token: 0x06024974 RID: 149876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024974")]
		[Address(RVA = "0x1F79DD0", Offset = "0x1F789D0", VA = "0x181F79DD0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024975 RID: 149877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024975")]
		[Address(RVA = "0x1F7A8D0", Offset = "0x1F794D0", VA = "0x181F7A8D0")]
		private void _OnItemCardCancelClick(object msgObj)
		{
		}

		// Token: 0x06024976 RID: 149878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024976")]
		[Address(RVA = "0x1F7A3F0", Offset = "0x1F78FF0", VA = "0x181F7A3F0")]
		private void _OnChessCharItemCancelSuc(string chessId)
		{
		}

		// Token: 0x06024977 RID: 149879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024977")]
		[Address(RVA = "0x1F7A560", Offset = "0x1F79160", VA = "0x181F7A560")]
		private void _OnItemCardAssistClick(object msgObj)
		{
		}

		// Token: 0x06024978 RID: 149880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024978")]
		[Address(RVA = "0x1F7B010", Offset = "0x1F79C10", VA = "0x181F7B010")]
		public AutoChessShopQuickAssistState()
		{
		}

		// Token: 0x06024979 RID: 149881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024979")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602497A RID: 149882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602497A")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602497B RID: 149883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602497B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040330CD RID: 209101
		[Token(Token = "0x40330CD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessShopQuickAssistView _view;

		// Token: 0x040330CE RID: 209102
		[Token(Token = "0x40330CE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rectTopMenuContainer;

		// Token: 0x040330CF RID: 209103
		[Token(Token = "0x40330CF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x040330D0 RID: 209104
		[Token(Token = "0x40330D0")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessShopQuickAssistStateBean m_stateBean;

		// Token: 0x040330D1 RID: 209105
		[Token(Token = "0x40330D1")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessFriendAssistPlugin m_friendAssistPlugin;

		// Token: 0x040330D2 RID: 209106
		[Token(Token = "0x40330D2")]
		[NonSerialized]
		public const int MSG_ITEM_CARD_CANCEL_CLICK = 0;

		// Token: 0x040330D3 RID: 209107
		[Token(Token = "0x40330D3")]
		[NonSerialized]
		public const int MSG_ITEM_CARD_ASSIST_CLICK = 1;

		// Token: 0x040330D4 RID: 209108
		[Token(Token = "0x40330D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040330D5 RID: 209109
		[Token(Token = "0x40330D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040330D6 RID: 209110
		[Token(Token = "0x40330D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040330D7 RID: 209111
		[Token(Token = "0x40330D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040330D8 RID: 209112
		[Token(Token = "0x40330D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterFromCommonFriendAssistState;

		// Token: 0x040330D9 RID: 209113
		[Token(Token = "0x40330D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterToCommonFriendAssistState;

		// Token: 0x040330DA RID: 209114
		[Token(Token = "0x40330DA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040330DB RID: 209115
		[Token(Token = "0x40330DB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryToTriggerShopAvg;

		// Token: 0x040330DC RID: 209116
		[Token(Token = "0x40330DC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040330DD RID: 209117
		[Token(Token = "0x40330DD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnItemCardCancelClick;

		// Token: 0x040330DE RID: 209118
		[Token(Token = "0x40330DE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCancelSuc;

		// Token: 0x040330DF RID: 209119
		[Token(Token = "0x40330DF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnItemCardAssistClick;

		// Token: 0x040330E0 RID: 209120
		[Token(Token = "0x40330E0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
