using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B89 RID: 15241
	[Token(Token = "0x2003B89")]
	public class VoucherSkinHomeState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06017E2D RID: 97837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E2D")]
		[Address(RVA = "0x1024BF0", Offset = "0x10237F0", VA = "0x181024BF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017E2E RID: 97838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E2E")]
		[Address(RVA = "0x1024C50", Offset = "0x1023850", VA = "0x181024C50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017E2F RID: 97839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E2F")]
		[Address(RVA = "0x1024EA0", Offset = "0x1023AA0", VA = "0x181024EA0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06017E30 RID: 97840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E30")]
		[Address(RVA = "0x10254F0", Offset = "0x10240F0", VA = "0x1810254F0")]
		private void _EventOnSwitchRuleState(bool state)
		{
		}

		// Token: 0x06017E31 RID: 97841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E31")]
		[Address(RVA = "0x1025240", Offset = "0x1023E40", VA = "0x181025240")]
		private void _EventOnSkinClicked(string skinId)
		{
		}

		// Token: 0x06017E32 RID: 97842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E32")]
		[Address(RVA = "0x1025190", Offset = "0x1023D90", VA = "0x181025190")]
		private void _EventOnClosePage()
		{
		}

		// Token: 0x06017E33 RID: 97843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E33")]
		[Address(RVA = "0x1025660", Offset = "0x1024260", VA = "0x181025660")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017E34 RID: 97844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E34")]
		[Address(RVA = "0x1025740", Offset = "0x1024340", VA = "0x181025740")]
		public VoucherSkinHomeState()
		{
		}

		// Token: 0x06017E35 RID: 97845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E35")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401CDFC RID: 118268
		[Token(Token = "0x401CDFC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VoucherSkinHomeView _view;

		// Token: 0x0401CDFD RID: 118269
		[Token(Token = "0x401CDFD")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0401CDFE RID: 118270
		[Token(Token = "0x401CDFE")]
		[FieldOffset(Offset = "0x80")]
		private VoucherSkinHomeStateBean m_stateBean;

		// Token: 0x0401CDFF RID: 118271
		[Token(Token = "0x401CDFF")]
		[NonSerialized]
		public const int SWITCH_RULE_STATE = 0;

		// Token: 0x0401CE00 RID: 118272
		[Token(Token = "0x401CE00")]
		[NonSerialized]
		public const int ROUTE_TO_SKIN = 1;

		// Token: 0x0401CE01 RID: 118273
		[Token(Token = "0x401CE01")]
		[NonSerialized]
		public const int CLOSE_PAGE = 2;

		// Token: 0x0401CE02 RID: 118274
		[Token(Token = "0x401CE02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401CE03 RID: 118275
		[Token(Token = "0x401CE03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401CE04 RID: 118276
		[Token(Token = "0x401CE04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401CE05 RID: 118277
		[Token(Token = "0x401CE05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnSwitchRuleState;

		// Token: 0x0401CE06 RID: 118278
		[Token(Token = "0x401CE06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnSkinClicked;

		// Token: 0x0401CE07 RID: 118279
		[Token(Token = "0x401CE07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnClosePage;

		// Token: 0x0401CE08 RID: 118280
		[Token(Token = "0x401CE08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CE09 RID: 118281
		[Token(Token = "0x401CE09")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
