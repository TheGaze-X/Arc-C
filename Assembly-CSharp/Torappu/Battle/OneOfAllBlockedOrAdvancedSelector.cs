using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200251C RID: 9500
	[Token(Token = "0x200251C")]
	public class OneOfAllBlockedOrAdvancedSelector : BlockedBaseSelector
	{
		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x0600F51A RID: 62746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F51B RID: 62747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FF5")]
		private protected Character character
		{
			[Token(Token = "0x600F51A")]
			[Address(RVA = "0x6CC2D0", Offset = "0x6CAED0", VA = "0x1806CC2D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F51B")]
			[Address(RVA = "0x6CC330", Offset = "0x6CAF30", VA = "0x1806CC330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600F51C RID: 62748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F51C")]
		[Address(RVA = "0x6CC0D0", Offset = "0x6CACD0", VA = "0x1806CC0D0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F51D RID: 62749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F51D")]
		[Address(RVA = "0x6CBC90", Offset = "0x6CA890", VA = "0x1806CBC90", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F51E")]
		[Address(RVA = "0x6CC230", Offset = "0x6CAE30", VA = "0x1806CC230")]
		public OneOfAllBlockedOrAdvancedSelector()
		{
		}

		// Token: 0x0600F51F RID: 62751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F51F")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F520 RID: 62752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F520")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010FB1 RID: 69553
		[Token(Token = "0x4010FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010FB2 RID: 69554
		[Token(Token = "0x4010FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010FB3 RID: 69555
		[Token(Token = "0x4010FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010FB4 RID: 69556
		[Token(Token = "0x4010FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010FB5 RID: 69557
		[Token(Token = "0x4010FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
