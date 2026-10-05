using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007848 RID: 30792
	[Token(Token = "0x2007848")]
	public class Act1MainSSApCostRewardDetailState : PopupFloatState
	{
		// Token: 0x0602B2F5 RID: 176885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F5")]
		[Address(RVA = "0x26EF0E0", Offset = "0x26EDCE0", VA = "0x1826EF0E0")]
		public void OnBackgroundClickEvent()
		{
		}

		// Token: 0x0602B2F6 RID: 176886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2F6")]
		[Address(RVA = "0x26EF080", Offset = "0x26EDC80", VA = "0x1826EF080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B2F7 RID: 176887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F7")]
		[Address(RVA = "0x26EF190", Offset = "0x26EDD90", VA = "0x1826EF190", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B2F8 RID: 176888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F8")]
		[Address(RVA = "0x26EF610", Offset = "0x26EE210", VA = "0x1826EF610")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602B2F9 RID: 176889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F9")]
		[Address(RVA = "0x26EF730", Offset = "0x26EE330", VA = "0x1826EF730")]
		public Act1MainSSApCostRewardDetailState()
		{
		}

		// Token: 0x0602B2FA RID: 176890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2FA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403E6CC RID: 255692
		[Token(Token = "0x403E6CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1MainSSApCostRewardDetailView _view;

		// Token: 0x0403E6CD RID: 255693
		[Token(Token = "0x403E6CD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E6CE RID: 255694
		[Token(Token = "0x403E6CE")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403E6CF RID: 255695
		[Token(Token = "0x403E6CF")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedActivityId;

		// Token: 0x0403E6D0 RID: 255696
		[Token(Token = "0x403E6D0")]
		[FieldOffset(Offset = "0x90")]
		private Act1MainSSApCostRewardDetailView.Param m_cachedParam;

		// Token: 0x0403E6D1 RID: 255697
		[Token(Token = "0x403E6D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBackgroundClickEvent;

		// Token: 0x0403E6D2 RID: 255698
		[Token(Token = "0x403E6D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E6D3 RID: 255699
		[Token(Token = "0x403E6D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E6D4 RID: 255700
		[Token(Token = "0x403E6D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403E6D5 RID: 255701
		[Token(Token = "0x403E6D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
