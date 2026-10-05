using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE1 RID: 7649
	[Token(Token = "0x2001DE1")]
	public class BuildingFloatTrainingState : BuildingFloatVaultInfoState
	{
		// Token: 0x0600BCCD RID: 48333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCD")]
		[Address(RVA = "0x33A7760", Offset = "0x33A6360", VA = "0x1833A7760", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCE")]
		[Address(RVA = "0x33A76E0", Offset = "0x33A62E0", VA = "0x1833A76E0", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x0600BCCF RID: 48335 RVA: 0x00046350 File Offset: 0x00044550
		[Token(Token = "0x170016D8")]
		protected override FloatState state
		{
			[Token(Token = "0x600BCCF")]
			[Address(RVA = "0x33A7D10", Offset = "0x33A6910", VA = "0x1833A7D10", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD0")]
		[Address(RVA = "0x33A75F0", Offset = "0x33A61F0", VA = "0x1833A75F0")]
		public void EventOnTrainingClick()
		{
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD1")]
		[Address(RVA = "0x33A7800", Offset = "0x33A6400", VA = "0x1833A7800")]
		public void OnUpgradeFinish()
		{
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD2")]
		[Address(RVA = "0x33A7C90", Offset = "0x33A6890", VA = "0x1833A7C90")]
		public BuildingFloatTrainingState()
		{
		}

		// Token: 0x0600BCD3 RID: 48339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD3")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD4")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0400BCEF RID: 48367
		[Token(Token = "0x400BCEF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BuildingFloatTrainingView _view;

		// Token: 0x0400BCF0 RID: 48368
		[Token(Token = "0x400BCF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BCF1 RID: 48369
		[Token(Token = "0x400BCF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BCF2 RID: 48370
		[Token(Token = "0x400BCF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BCF3 RID: 48371
		[Token(Token = "0x400BCF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTrainingClick;

		// Token: 0x0400BCF4 RID: 48372
		[Token(Token = "0x400BCF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpgradeFinish;

		// Token: 0x0400BCF5 RID: 48373
		[Token(Token = "0x400BCF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
