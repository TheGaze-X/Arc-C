using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B6A RID: 11114
	[Token(Token = "0x2002B6A")]
	public class ToggleableOnlyOncePassiveBuffAbility : ToggleablePassiveBuffAbility
	{
		// Token: 0x06012A89 RID: 76425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A89")]
		[Address(RVA = "0xAA75B0", Offset = "0xAA61B0", VA = "0x180AA75B0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012A8A RID: 76426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8A")]
		[Address(RVA = "0xAA7660", Offset = "0xAA6260", VA = "0x180AA7660", Slot = "97")]
		protected override void OnToggleChanged(bool isToggled)
		{
		}

		// Token: 0x06012A8B RID: 76427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8B")]
		[Address(RVA = "0xAA7770", Offset = "0xAA6370", VA = "0x180AA7770")]
		public ToggleableOnlyOncePassiveBuffAbility()
		{
		}

		// Token: 0x06012A8C RID: 76428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8C")]
		[Address(RVA = "0xAA7730", Offset = "0xAA6330", VA = "0x180AA7730")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012A8D RID: 76429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A8D")]
		[Address(RVA = "0xAA7760", Offset = "0xAA6360", VA = "0x180AA7760")]
		private void <>xLuaBaseProxy_OnToggleChanged(bool P0)
		{
		}

		// Token: 0x0401517F RID: 86399
		[Token(Token = "0x401517F")]
		[FieldOffset(Offset = "0x138")]
		private bool m_isTriggered;

		// Token: 0x04015180 RID: 86400
		[Token(Token = "0x4015180")]
		[FieldOffset(Offset = "0x139")]
		private bool m_isTriggerFinished;

		// Token: 0x04015181 RID: 86401
		[Token(Token = "0x4015181")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015182 RID: 86402
		[Token(Token = "0x4015182")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnToggleChanged;

		// Token: 0x04015183 RID: 86403
		[Token(Token = "0x4015183")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
