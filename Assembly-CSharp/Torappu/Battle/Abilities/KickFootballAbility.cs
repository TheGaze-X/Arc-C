using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA0 RID: 11168
	[Token(Token = "0x2002BA0")]
	public class KickFootballAbility : AnimatedActionToOwnerAbility
	{
		// Token: 0x06012D42 RID: 77122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D42")]
		[Address(RVA = "0xABD430", Offset = "0xABC030", VA = "0x180ABD430", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D43")]
		[Address(RVA = "0xABD6C0", Offset = "0xABC2C0", VA = "0x180ABD6C0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012D44 RID: 77124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D44")]
		[Address(RVA = "0xABD5D0", Offset = "0xABC1D0", VA = "0x180ABD5D0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012D45 RID: 77125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D45")]
		[Address(RVA = "0xABD900", Offset = "0xABC500", VA = "0x180ABD900")]
		public KickFootballAbility()
		{
		}

		// Token: 0x06012D46 RID: 77126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D46")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012D47 RID: 77127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D47")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012D48 RID: 77128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D48")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x040153F6 RID: 87030
		[Token(Token = "0x40153F6")]
		[FieldOffset(Offset = "0x1D0")]
		private FootballPlayerEnemy m_abilityOwner;

		// Token: 0x040153F7 RID: 87031
		[Token(Token = "0x40153F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040153F8 RID: 87032
		[Token(Token = "0x40153F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040153F9 RID: 87033
		[Token(Token = "0x40153F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x040153FA RID: 87034
		[Token(Token = "0x40153FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
