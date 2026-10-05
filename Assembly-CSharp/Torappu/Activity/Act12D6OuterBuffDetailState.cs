using System;
using Il2CppDummyDll;
using Torappu.Activity.Act12D6;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D37 RID: 27959
	[Token(Token = "0x2006D37")]
	public class Act12D6OuterBuffDetailState : PopupFloatState, IHotfixable
	{
		// Token: 0x06027DA2 RID: 163234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DA2")]
		[Address(RVA = "0x22EB850", Offset = "0x22EA450", VA = "0x1822EB850", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027DA3 RID: 163235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA3")]
		[Address(RVA = "0x22EB8B0", Offset = "0x22EA4B0", VA = "0x1822EB8B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027DA4 RID: 163236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA4")]
		[Address(RVA = "0x22EBA40", Offset = "0x22EA640", VA = "0x1822EBA40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027DA5 RID: 163237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA5")]
		[Address(RVA = "0x22EB400", Offset = "0x22EA000", VA = "0x1822EB400")]
		public void EventOnOuterBuffUpgrade(string buffId)
		{
		}

		// Token: 0x06027DA6 RID: 163238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA6")]
		[Address(RVA = "0x22EBB50", Offset = "0x22EA750", VA = "0x1822EBB50")]
		public Act12D6OuterBuffDetailState()
		{
		}

		// Token: 0x06027DA9 RID: 163241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040387D4 RID: 231380
		[Token(Token = "0x40387D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12D6OuterBuffDetailView _view;

		// Token: 0x040387D5 RID: 231381
		[Token(Token = "0x40387D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStringEvent _onOuterBuffUpgradeClicked;

		// Token: 0x040387D6 RID: 231382
		[Token(Token = "0x40387D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040387D7 RID: 231383
		[Token(Token = "0x40387D7")]
		[FieldOffset(Offset = "0x88")]
		private Act12D6OuterBuffDetailStateBean m_stateBean;

		// Token: 0x040387D8 RID: 231384
		[Token(Token = "0x40387D8")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x040387D9 RID: 231385
		[Token(Token = "0x40387D9")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x040387DA RID: 231386
		[Token(Token = "0x40387DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040387DB RID: 231387
		[Token(Token = "0x40387DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040387DC RID: 231388
		[Token(Token = "0x40387DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040387DD RID: 231389
		[Token(Token = "0x40387DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnOuterBuffUpgrade;

		// Token: 0x040387DE RID: 231390
		[Token(Token = "0x40387DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
