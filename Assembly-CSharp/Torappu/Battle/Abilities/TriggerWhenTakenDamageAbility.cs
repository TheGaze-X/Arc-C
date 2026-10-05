using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B75 RID: 11125
	[Token(Token = "0x2002B75")]
	public class TriggerWhenTakenDamageAbility : TriggablePassiveAbility
	{
		// Token: 0x06012AEC RID: 76524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AEC")]
		[Address(RVA = "0xAA9870", Offset = "0xAA8470", VA = "0x180AA9870", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012AED RID: 76525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AED")]
		[Address(RVA = "0xAA9970", Offset = "0xAA8570", VA = "0x180AA9970", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012AEE RID: 76526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AEE")]
		[Address(RVA = "0xAA9A70", Offset = "0xAA8670", VA = "0x180AA9A70")]
		private void _OnTakeDamage(object arg)
		{
		}

		// Token: 0x06012AEF RID: 76527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AEF")]
		[Address(RVA = "0xAA9BC0", Offset = "0xAA87C0", VA = "0x180AA9BC0")]
		public TriggerWhenTakenDamageAbility()
		{
		}

		// Token: 0x06012AF0 RID: 76528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AF0")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012AF1 RID: 76529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AF1")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040151D7 RID: 86487
		[Token(Token = "0x40151D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040151D8 RID: 86488
		[Token(Token = "0x40151D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040151D9 RID: 86489
		[Token(Token = "0x40151D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTakeDamage;

		// Token: 0x040151DA RID: 86490
		[Token(Token = "0x40151DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
