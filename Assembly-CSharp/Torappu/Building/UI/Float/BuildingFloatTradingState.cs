using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE0 RID: 7648
	[Token(Token = "0x2001DE0")]
	public class BuildingFloatTradingState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x00046338 File Offset: 0x00044538
		[Token(Token = "0x170016D7")]
		protected override FloatState state
		{
			[Token(Token = "0x600BCC6")]
			[Address(RVA = "0x33A6CD0", Offset = "0x33A58D0", VA = "0x1833A6CD0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC7")]
		[Address(RVA = "0x33A6950", Offset = "0x33A5550", VA = "0x1833A6950", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC8")]
		[Address(RVA = "0x33A6870", Offset = "0x33A5470", VA = "0x1833A6870", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BCC9 RID: 48329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC9")]
		[Address(RVA = "0x33A6A40", Offset = "0x33A5640", VA = "0x1833A6A40")]
		private void _Render(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600BCCA RID: 48330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCA")]
		[Address(RVA = "0x33A6C50", Offset = "0x33A5850", VA = "0x1833A6C50")]
		public BuildingFloatTradingState()
		{
		}

		// Token: 0x0600BCCB RID: 48331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCB")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BCCC RID: 48332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCC")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0400BCE9 RID: 48361
		[Token(Token = "0x400BCE9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BuildingFloatTradingView _tradingView;

		// Token: 0x0400BCEA RID: 48362
		[Token(Token = "0x400BCEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BCEB RID: 48363
		[Token(Token = "0x400BCEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BCEC RID: 48364
		[Token(Token = "0x400BCEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BCED RID: 48365
		[Token(Token = "0x400BCED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0400BCEE RID: 48366
		[Token(Token = "0x400BCEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
