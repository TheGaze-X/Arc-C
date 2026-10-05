using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B23 RID: 11043
	[Token(Token = "0x2002B23")]
	public class AuraWithHostAsSourceAbility : AuraAbility
	{
		// Token: 0x060127FA RID: 75770 RVA: 0x00071700 File Offset: 0x0006F900
		[Token(Token = "0x60127FA")]
		[Address(RVA = "0xA7BA30", Offset = "0xA7A630", VA = "0x180A7BA30", Slot = "98")]
		protected override bool DealTargetTouched(Entity target, AuraAbility.TargetMeta meta)
		{
			return default(bool);
		}

		// Token: 0x060127FB RID: 75771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127FB")]
		[Address(RVA = "0xA7BCA0", Offset = "0xA7A8A0", VA = "0x180A7BCA0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060127FC RID: 75772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127FC")]
		[Address(RVA = "0xA7BF70", Offset = "0xA7AB70", VA = "0x180A7BF70")]
		public AuraWithHostAsSourceAbility()
		{
		}

		// Token: 0x060127FD RID: 75773 RVA: 0x00071718 File Offset: 0x0006F918
		[Token(Token = "0x60127FD")]
		[Address(RVA = "0xA7B930", Offset = "0xA7A530", VA = "0x180A7B930")]
		private bool <>xLuaBaseProxy_DealTargetTouched(Entity P0, AuraAbility.TargetMeta P1)
		{
			return default(bool);
		}

		// Token: 0x060127FE RID: 75774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127FE")]
		[Address(RVA = "0xA7B940", Offset = "0xA7A540", VA = "0x180A7B940")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x04014E79 RID: 85625
		[Token(Token = "0x4014E79")]
		[FieldOffset(Offset = "0x180")]
		private ObjectPtr<Character> m_host;

		// Token: 0x04014E7A RID: 85626
		[Token(Token = "0x4014E7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealTargetTouched;

		// Token: 0x04014E7B RID: 85627
		[Token(Token = "0x4014E7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014E7C RID: 85628
		[Token(Token = "0x4014E7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
