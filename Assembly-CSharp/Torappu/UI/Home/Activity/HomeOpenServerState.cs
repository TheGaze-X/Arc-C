using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C73 RID: 19571
	[Token(Token = "0x2004C73")]
	public class HomeOpenServerState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0601D5A1 RID: 120225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D5A1")]
		[Address(RVA = "0x16E2140", Offset = "0x16E0D40", VA = "0x1816E2140", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D5A2 RID: 120226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A2")]
		[Address(RVA = "0x16E2C70", Offset = "0x16E1870", VA = "0x1816E2C70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D5A3 RID: 120227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A3")]
		[Address(RVA = "0x16E21A0", Offset = "0x16E0DA0", VA = "0x1816E21A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D5A4 RID: 120228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A4")]
		[Address(RVA = "0x16E24A0", Offset = "0x16E10A0", VA = "0x1816E24A0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D5A5 RID: 120229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A5")]
		[Address(RVA = "0x16E3050", Offset = "0x16E1C50", VA = "0x1816E3050")]
		public void _SendGetChain(int rewardIndex)
		{
		}

		// Token: 0x0601D5A6 RID: 120230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A6")]
		[Address(RVA = "0x16E3260", Offset = "0x16E1E60", VA = "0x1816E3260")]
		private void _SendGetCheckIn(int rewardIndex)
		{
		}

		// Token: 0x0601D5A7 RID: 120231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A7")]
		[Address(RVA = "0x16E2DA0", Offset = "0x16E19A0", VA = "0x1816E2DA0")]
		public void _SendConfirmMissionRequest(string missionID_)
		{
		}

		// Token: 0x0601D5A8 RID: 120232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A8")]
		[Address(RVA = "0x16E3470", Offset = "0x16E2070", VA = "0x1816E3470")]
		private void _ShowCharDetail(string charId)
		{
		}

		// Token: 0x0601D5A9 RID: 120233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A9")]
		[Address(RVA = "0x16E35B0", Offset = "0x16E21B0", VA = "0x1816E35B0")]
		public HomeOpenServerState()
		{
		}

		// Token: 0x0601D5AC RID: 120236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5AC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040269D8 RID: 158168
		[Token(Token = "0x40269D8")]
		[NonSerialized]
		public const int MSG_DISMISS = 1;

		// Token: 0x040269D9 RID: 158169
		[Token(Token = "0x40269D9")]
		[NonSerialized]
		public const int MSG_TOTAL_LOGIN_ITEM_CLICK = 2;

		// Token: 0x040269DA RID: 158170
		[Token(Token = "0x40269DA")]
		[NonSerialized]
		public const int MSG_CHAIN_LOGIN_ITEM_CLICK = 3;

		// Token: 0x040269DB RID: 158171
		[Token(Token = "0x40269DB")]
		[NonSerialized]
		public const int MSG_MISSION_ITEM_CLICK = 4;

		// Token: 0x040269DC RID: 158172
		[Token(Token = "0x40269DC")]
		[NonSerialized]
		public const int MSG_CHAR_DETAIL_CLICK = 5;

		// Token: 0x040269DD RID: 158173
		[Token(Token = "0x40269DD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x040269DE RID: 158174
		[Token(Token = "0x40269DE")]
		[FieldOffset(Offset = "0x78")]
		private OpenServerMainAbstractView m_mainView;

		// Token: 0x040269DF RID: 158175
		[Token(Token = "0x40269DF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040269E0 RID: 158176
		[Token(Token = "0x40269E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040269E1 RID: 158177
		[Token(Token = "0x40269E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040269E2 RID: 158178
		[Token(Token = "0x40269E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040269E3 RID: 158179
		[Token(Token = "0x40269E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040269E4 RID: 158180
		[Token(Token = "0x40269E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendGetChain;

		// Token: 0x040269E5 RID: 158181
		[Token(Token = "0x40269E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendGetCheckIn;

		// Token: 0x040269E6 RID: 158182
		[Token(Token = "0x40269E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendConfirmMissionRequest;

		// Token: 0x040269E7 RID: 158183
		[Token(Token = "0x40269E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowCharDetail;

		// Token: 0x040269E8 RID: 158184
		[Token(Token = "0x40269E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
