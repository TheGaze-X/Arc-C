using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250B RID: 9483
	[Token(Token = "0x200250B")]
	public class EnemyBlockerOrAdvancedSelector : AdvancedSelector
	{
		// Token: 0x0600F45A RID: 62554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F45A")]
		[Address(RVA = "0x6BC3F0", Offset = "0x6BAFF0", VA = "0x1806BC3F0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F45B RID: 62555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F45B")]
		[Address(RVA = "0x6BC140", Offset = "0x6BAD40", VA = "0x1806BC140", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F45C RID: 62556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F45C")]
		[Address(RVA = "0x6BC580", Offset = "0x6BB180", VA = "0x1806BC580")]
		public EnemyBlockerOrAdvancedSelector()
		{
		}

		// Token: 0x0600F45D RID: 62557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F45D")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F45E RID: 62558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F45E")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010E9B RID: 69275
		[Token(Token = "0x4010E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Enemy m_enemy;

		// Token: 0x04010E9C RID: 69276
		[Token(Token = "0x4010E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E9D RID: 69277
		[Token(Token = "0x4010E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E9E RID: 69278
		[Token(Token = "0x4010E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
