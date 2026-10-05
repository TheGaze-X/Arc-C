using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B6E RID: 11118
	[Token(Token = "0x2002B6E")]
	public class ToggleablePassiveWrapperAbility : ToggleablePassiveBuffAbility
	{
		// Token: 0x06012ABA RID: 76474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABA")]
		[Address(RVA = "0xAA8A90", Offset = "0xAA7690", VA = "0x180AA8A90", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABB")]
		[Address(RVA = "0xAA8BC0", Offset = "0xAA77C0", VA = "0x180AA8BC0", Slot = "97")]
		protected override void OnToggleChanged(bool isToggled)
		{
		}

		// Token: 0x06012ABC RID: 76476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABC")]
		[Address(RVA = "0xAA8D40", Offset = "0xAA7940", VA = "0x180AA8D40")]
		public ToggleablePassiveWrapperAbility()
		{
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABD")]
		[Address(RVA = "0xAA7730", Offset = "0xAA6330", VA = "0x180AA7730")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012ABE RID: 76478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABE")]
		[Address(RVA = "0xAA7760", Offset = "0xAA6360", VA = "0x180AA7760")]
		private void <>xLuaBaseProxy_OnToggleChanged(bool P0)
		{
		}

		// Token: 0x040151AD RID: 86445
		[Token(Token = "0x40151AD")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Ability[] _passiveAbilities;

		// Token: 0x040151AE RID: 86446
		[Token(Token = "0x40151AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040151AF RID: 86447
		[Token(Token = "0x40151AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnToggleChanged;

		// Token: 0x040151B0 RID: 86448
		[Token(Token = "0x40151B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
