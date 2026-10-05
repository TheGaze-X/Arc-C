using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B6B RID: 11115
	[Token(Token = "0x2002B6B")]
	public class ToggleablePassiveAbilityGroup : ToggleablePassiveBuffAbility
	{
		// Token: 0x06012A8E RID: 76430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8E")]
		[Address(RVA = "0xAA77D0", Offset = "0xAA63D0", VA = "0x180AA77D0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8F")]
		[Address(RVA = "0xAA79B0", Offset = "0xAA65B0", VA = "0x180AA79B0", Slot = "97")]
		protected override void OnToggleChanged(bool isToggled)
		{
		}

		// Token: 0x06012A90 RID: 76432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A90")]
		[Address(RVA = "0xAA7AF0", Offset = "0xAA66F0", VA = "0x180AA7AF0")]
		public ToggleablePassiveAbilityGroup()
		{
		}

		// Token: 0x06012A91 RID: 76433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A91")]
		[Address(RVA = "0xAA7730", Offset = "0xAA6330", VA = "0x180AA7730")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012A92 RID: 76434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A92")]
		[Address(RVA = "0xAA7760", Offset = "0xAA6360", VA = "0x180AA7760")]
		private void <>xLuaBaseProxy_OnToggleChanged(bool P0)
		{
		}

		// Token: 0x04015184 RID: 86404
		[Token(Token = "0x4015184")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected Ability[] _abilities;

		// Token: 0x04015185 RID: 86405
		[Token(Token = "0x4015185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015186 RID: 86406
		[Token(Token = "0x4015186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnToggleChanged;

		// Token: 0x04015187 RID: 86407
		[Token(Token = "0x4015187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
