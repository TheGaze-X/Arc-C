using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200237F RID: 9087
	[Token(Token = "0x200237F")]
	public class LhshipSPFA : SPFA
	{
		// Token: 0x0600E67C RID: 59004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E67C")]
		[Address(RVA = "0x5C13F0", Offset = "0x5BFFF0", VA = "0x1805C13F0")]
		public LhshipSPFA(Map map)
		{
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x00053E20 File Offset: 0x00052020
		[Token(Token = "0x600E67D")]
		[Address(RVA = "0x5C1330", Offset = "0x5BFF30", VA = "0x1805C1330", Slot = "9")]
		protected override bool CheckPassableGoto(Tile tile, MotionMode motionMode, SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x00053E38 File Offset: 0x00052038
		[Token(Token = "0x600E67E")]
		[Address(RVA = "0x5C13E0", Offset = "0x5BFFE0", VA = "0x1805C13E0")]
		private bool <>xLuaBaseProxy_CheckPassableGoto(Tile P0, MotionMode P1, SharedConsts.Direction P2)
		{
			return default(bool);
		}

		// Token: 0x0400FDFB RID: 65019
		[Token(Token = "0x400FDFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDFC RID: 65020
		[Token(Token = "0x400FDFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckPassableGoto;
	}
}
