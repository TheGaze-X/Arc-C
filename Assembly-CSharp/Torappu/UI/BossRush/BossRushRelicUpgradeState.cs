using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200618C RID: 24972
	[Token(Token = "0x200618C")]
	public class BossRushRelicUpgradeState : PopupFloatState
	{
		// Token: 0x0602405D RID: 147549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602405D")]
		[Address(RVA = "0x1EA80B0", Offset = "0x1EA6CB0", VA = "0x181EA80B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602405E RID: 147550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602405E")]
		[Address(RVA = "0x1EA8190", Offset = "0x1EA6D90", VA = "0x181EA8190", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602405F RID: 147551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602405F")]
		[Address(RVA = "0x1EA8610", Offset = "0x1EA7210", VA = "0x181EA8610")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024060 RID: 147552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024060")]
		[Address(RVA = "0x1EA8110", Offset = "0x1EA6D10", VA = "0x181EA8110")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06024061 RID: 147553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024061")]
		[Address(RVA = "0x1EA8480", Offset = "0x1EA7080", VA = "0x181EA8480")]
		public void OnUpgradeClicked(string rID)
		{
		}

		// Token: 0x06024062 RID: 147554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024062")]
		[Address(RVA = "0x1EA8720", Offset = "0x1EA7320", VA = "0x181EA8720")]
		private void _SendRelicUpgradeRequest(string aId, string rId, Action onComplete)
		{
		}

		// Token: 0x06024063 RID: 147555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024063")]
		[Address(RVA = "0x1EA8A50", Offset = "0x1EA7650", VA = "0x181EA8A50")]
		public BossRushRelicUpgradeState()
		{
		}

		// Token: 0x06024065 RID: 147557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024065")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040320BE RID: 204990
		[Token(Token = "0x40320BE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BossRushRelicUpgradeView _relicUpgradeView;

		// Token: 0x040320BF RID: 204991
		[Token(Token = "0x40320BF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x040320C0 RID: 204992
		[Token(Token = "0x40320C0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040320C1 RID: 204993
		[Token(Token = "0x40320C1")]
		[FieldOffset(Offset = "0x88")]
		private BossRushRelicUpgradeStateBean m_stateBean;

		// Token: 0x040320C2 RID: 204994
		[Token(Token = "0x40320C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040320C3 RID: 204995
		[Token(Token = "0x40320C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040320C4 RID: 204996
		[Token(Token = "0x40320C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040320C5 RID: 204997
		[Token(Token = "0x40320C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x040320C6 RID: 204998
		[Token(Token = "0x40320C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpgradeClicked;

		// Token: 0x040320C7 RID: 204999
		[Token(Token = "0x40320C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRelicUpgradeRequest;

		// Token: 0x040320C8 RID: 205000
		[Token(Token = "0x40320C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
