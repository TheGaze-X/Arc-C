using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C22 RID: 7202
	[Token(Token = "0x2001C22")]
	public class BuildingTradingNegotiationState : PopupFloatState
	{
		// Token: 0x0600B37E RID: 45950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B37E")]
		[Address(RVA = "0x32D6E50", Offset = "0x32D5A50", VA = "0x1832D6E50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B37F")]
		[Address(RVA = "0x32D6EB0", Offset = "0x32D5AB0", VA = "0x1832D6EB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B380")]
		[Address(RVA = "0x32D7040", Offset = "0x32D5C40", VA = "0x1832D7040", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B381")]
		[Address(RVA = "0x32D6B90", Offset = "0x32D5790", VA = "0x1832D6B90", Slot = "22")]
		public override void DismissSelf()
		{
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B382")]
		[Address(RVA = "0x32D70B0", Offset = "0x32D5CB0", VA = "0x1832D70B0")]
		private void _OnTypeSelected(TradingOrderViewType viewType)
		{
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B383")]
		[Address(RVA = "0x32D7150", Offset = "0x32D5D50", VA = "0x1832D7150")]
		private void _UpdateOrderType()
		{
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B384")]
		[Address(RVA = "0x32D7290", Offset = "0x32D5E90", VA = "0x1832D7290")]
		public BuildingTradingNegotiationState()
		{
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B386")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B387 RID: 45959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B387")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B388")]
		[Address(RVA = "0x1637780", Offset = "0x1636380", VA = "0x181637780")]
		private void <>xLuaBaseProxy_DismissSelf()
		{
		}

		// Token: 0x0400AED5 RID: 44757
		[Token(Token = "0x400AED5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingTradingNegotiationItem[] _typeItems;

		// Token: 0x0400AED6 RID: 44758
		[Token(Token = "0x400AED6")]
		[FieldOffset(Offset = "0x78")]
		private TradingNegoiationBean m_stateBean;

		// Token: 0x0400AED7 RID: 44759
		[Token(Token = "0x400AED7")]
		[FieldOffset(Offset = "0x80")]
		private BuildingData.OrderType m_strategyWhenEnter;

		// Token: 0x0400AED8 RID: 44760
		[Token(Token = "0x400AED8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AED9 RID: 44761
		[Token(Token = "0x400AED9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AEDA RID: 44762
		[Token(Token = "0x400AEDA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AEDB RID: 44763
		[Token(Token = "0x400AEDB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x0400AEDC RID: 44764
		[Token(Token = "0x400AEDC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTypeSelected;

		// Token: 0x0400AEDD RID: 44765
		[Token(Token = "0x400AEDD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateOrderType;

		// Token: 0x0400AEDE RID: 44766
		[Token(Token = "0x400AEDE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
