using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D5F RID: 7519
	[Token(Token = "0x2001D5F")]
	public class BuildingTransferResultHomeState : State
	{
		// Token: 0x0600B9B9 RID: 47545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9B9")]
		[Address(RVA = "0x3371080", Offset = "0x336FC80", VA = "0x183371080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9BA")]
		[Address(RVA = "0x3371680", Offset = "0x3370280", VA = "0x183371680")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9BB")]
		[Address(RVA = "0x33710E0", Offset = "0x336FCE0", VA = "0x1833710E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9BC")]
		[Address(RVA = "0x33712E0", Offset = "0x336FEE0", VA = "0x1833712E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9BD")]
		[Address(RVA = "0x33713E0", Offset = "0x336FFE0", VA = "0x1833713E0")]
		private void SetupView()
		{
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9BE")]
		[Address(RVA = "0x3371750", Offset = "0x3370350", VA = "0x183371750")]
		public BuildingTransferResultHomeState()
		{
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C2")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400B866 RID: 47206
		[Token(Token = "0x400B866")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _blueBackground;

		// Token: 0x0400B867 RID: 47207
		[Token(Token = "0x400B867")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400B868 RID: 47208
		[Token(Token = "0x400B868")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _visitNumberLabel;

		// Token: 0x0400B869 RID: 47209
		[Token(Token = "0x400B869")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _socialPointLabel;

		// Token: 0x0400B86A RID: 47210
		[Token(Token = "0x400B86A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MeetingPeerAdapter _peerAdapter;

		// Token: 0x0400B86B RID: 47211
		[Token(Token = "0x400B86B")]
		[FieldOffset(Offset = "0x78")]
		private IMeetingSession m_currentSession;

		// Token: 0x0400B86C RID: 47212
		[Token(Token = "0x400B86C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B86D RID: 47213
		[Token(Token = "0x400B86D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400B86E RID: 47214
		[Token(Token = "0x400B86E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B86F RID: 47215
		[Token(Token = "0x400B86F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400B870 RID: 47216
		[Token(Token = "0x400B870")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetupView;

		// Token: 0x0400B871 RID: 47217
		[Token(Token = "0x400B871")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
