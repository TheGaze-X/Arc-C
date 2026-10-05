using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F6 RID: 29686
	[Token(Token = "0x20073F6")]
	public class Act3D0ReplicateState : PopupFloatState
	{
		// Token: 0x06029EEC RID: 171756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EEC")]
		[Address(RVA = "0x2590960", Offset = "0x258F560", VA = "0x182590960", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029EED RID: 171757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EED")]
		[Address(RVA = "0x2590900", Offset = "0x258F500", VA = "0x182590900", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029EEE RID: 171758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EEE")]
		[Address(RVA = "0x25909E0", Offset = "0x258F5E0", VA = "0x1825909E0")]
		public void ToShopPage()
		{
		}

		// Token: 0x06029EEF RID: 171759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EEF")]
		[Address(RVA = "0x2590AC0", Offset = "0x258F6C0", VA = "0x182590AC0")]
		public Act3D0ReplicateState()
		{
		}

		// Token: 0x06029EF0 RID: 171760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403C161 RID: 246113
		[Token(Token = "0x403C161")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act3D0ReplicateView _view;

		// Token: 0x0403C162 RID: 246114
		[Token(Token = "0x403C162")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C163 RID: 246115
		[Token(Token = "0x403C163")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C164 RID: 246116
		[Token(Token = "0x403C164")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToShopPage;

		// Token: 0x0403C165 RID: 246117
		[Token(Token = "0x403C165")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
