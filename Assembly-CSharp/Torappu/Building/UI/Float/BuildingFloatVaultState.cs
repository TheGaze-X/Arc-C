using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DEB RID: 7659
	[Token(Token = "0x2001DEB")]
	public class BuildingFloatVaultState : BuildingFloatState
	{
		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600BD2D RID: 48429 RVA: 0x00046410 File Offset: 0x00044610
		[Token(Token = "0x170016E2")]
		protected override FloatState state
		{
			[Token(Token = "0x600BD2D")]
			[Address(RVA = "0x33AE530", Offset = "0x33AD130", VA = "0x1833AE530", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2E")]
		[Address(RVA = "0x33AE420", Offset = "0x33AD020", VA = "0x1833AE420")]
		public void EventOnHideUIClicked()
		{
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2F")]
		[Address(RVA = "0x33AE490", Offset = "0x33AD090", VA = "0x1833AE490")]
		public BuildingFloatVaultState()
		{
		}

		// Token: 0x0400BD62 RID: 48482
		[Token(Token = "0x400BD62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD63 RID: 48483
		[Token(Token = "0x400BD63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnHideUIClicked;

		// Token: 0x0400BD64 RID: 48484
		[Token(Token = "0x400BD64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
