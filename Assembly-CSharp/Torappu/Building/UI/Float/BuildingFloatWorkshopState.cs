using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DEE RID: 7662
	[Token(Token = "0x2001DEE")]
	public class BuildingFloatWorkshopState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x0600BD43 RID: 48451 RVA: 0x00046458 File Offset: 0x00044658
		[Token(Token = "0x170016E4")]
		protected override FloatState state
		{
			[Token(Token = "0x600BD43")]
			[Address(RVA = "0x33B0580", Offset = "0x33AF180", VA = "0x1833B0580", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BD44 RID: 48452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD44")]
		[Address(RVA = "0x33B0400", Offset = "0x33AF000", VA = "0x1833B0400", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD45")]
		[Address(RVA = "0x33B0480", Offset = "0x33AF080", VA = "0x1833B0480", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD46")]
		[Address(RVA = "0x33B02B0", Offset = "0x33AEEB0", VA = "0x1833B02B0")]
		public void EventOnWorkshopClick()
		{
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD47")]
		[Address(RVA = "0x33B0500", Offset = "0x33AF100", VA = "0x1833B0500")]
		public BuildingFloatWorkshopState()
		{
		}

		// Token: 0x0600BD48 RID: 48456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD48")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0600BD49 RID: 48457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD49")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BD7F RID: 48511
		[Token(Token = "0x400BD7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD80 RID: 48512
		[Token(Token = "0x400BD80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BD81 RID: 48513
		[Token(Token = "0x400BD81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD82 RID: 48514
		[Token(Token = "0x400BD82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnWorkshopClick;

		// Token: 0x0400BD83 RID: 48515
		[Token(Token = "0x400BD83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
