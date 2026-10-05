using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200254C RID: 9548
	[Token(Token = "0x200254C")]
	public class TargetRootTileSelector : TargetRelatedTileSelector
	{
		// Token: 0x0600F666 RID: 63078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F666")]
		[Address(RVA = "0x6DFA80", Offset = "0x6DE680", VA = "0x1806DFA80", Slot = "42")]
		protected override List<Tile> _GetRelatedTile(ReusableList<Entity> targets)
		{
			return null;
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F667")]
		[Address(RVA = "0x6DFC10", Offset = "0x6DE810", VA = "0x1806DFC10")]
		public TargetRootTileSelector()
		{
		}

		// Token: 0x0401115E RID: 69982
		[Token(Token = "0x401115E")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool _allowDuplicatedRootTile;

		// Token: 0x0401115F RID: 69983
		[Token(Token = "0x401115F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetRelatedTile;

		// Token: 0x04011160 RID: 69984
		[Token(Token = "0x4011160")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
