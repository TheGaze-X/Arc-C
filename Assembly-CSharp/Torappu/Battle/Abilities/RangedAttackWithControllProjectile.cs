using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AC3 RID: 10947
	[Token(Token = "0x2002AC3")]
	public class RangedAttackWithControllProjectile : RangedAttack
	{
		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x060123B4 RID: 74676 RVA: 0x0006FBE8 File Offset: 0x0006DDE8
		[Token(Token = "0x170027FF")]
		public override bool waitForProjectileInvalid
		{
			[Token(Token = "0x60123B4")]
			[Address(RVA = "0xA47880", Offset = "0xA46480", VA = "0x180A47880", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060123B5 RID: 74677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B5")]
		[Address(RVA = "0xA47740", Offset = "0xA46340", VA = "0x180A47740", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060123B6 RID: 74678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B6")]
		[Address(RVA = "0xA47820", Offset = "0xA46420", VA = "0x180A47820")]
		public RangedAttackWithControllProjectile()
		{
		}

		// Token: 0x060123B7 RID: 74679 RVA: 0x0006FC00 File Offset: 0x0006DE00
		[Token(Token = "0x60123B7")]
		[Address(RVA = "0xA477C0", Offset = "0xA463C0", VA = "0x180A477C0")]
		private bool <>xLuaBaseProxy_get_waitForProjectileInvalid()
		{
			return default(bool);
		}

		// Token: 0x060123B8 RID: 74680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B8")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040149F2 RID: 84466
		[Token(Token = "0x40149F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitForProjectileInvalid;

		// Token: 0x040149F3 RID: 84467
		[Token(Token = "0x40149F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040149F4 RID: 84468
		[Token(Token = "0x40149F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
