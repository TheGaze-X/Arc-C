using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A52 RID: 10834
	[Token(Token = "0x2002A52")]
	public class ConstructRepairTrap : ConstructOp
	{
		// Token: 0x06011FB3 RID: 73651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB3")]
		[Address(RVA = "0xA00550", Offset = "0x9FF150", VA = "0x180A00550")]
		public ConstructRepairTrap(GridPosition pos, int discount)
		{
		}

		// Token: 0x06011FB4 RID: 73652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB4")]
		[Address(RVA = "0xA00060", Offset = "0x9FEC60", VA = "0x180A00060", Slot = "7")]
		public override void Execute()
		{
		}

		// Token: 0x06011FB5 RID: 73653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB5")]
		[Address(RVA = "0xA003C0", Offset = "0x9FEFC0", VA = "0x180A003C0", Slot = "8")]
		public override void Revert()
		{
		}

		// Token: 0x06011FB6 RID: 73654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FB6")]
		[Address(RVA = "0xA00230", Offset = "0x9FEE30", VA = "0x180A00230", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FB7 RID: 73655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB7")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020")]
		private void <>xLuaBaseProxy_Execute()
		{
		}

		// Token: 0x06011FB8 RID: 73656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB8")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0")]
		private void <>xLuaBaseProxy_Revert()
		{
		}

		// Token: 0x06011FB9 RID: 73657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FB9")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144D0 RID: 83152
		[Token(Token = "0x40144D0")]
		[FieldOffset(Offset = "0x10")]
		private FP m_cachedHpRatio;

		// Token: 0x040144D1 RID: 83153
		[Token(Token = "0x40144D1")]
		[FieldOffset(Offset = "0x18")]
		private FP m_hpRatio;

		// Token: 0x040144D2 RID: 83154
		[Token(Token = "0x40144D2")]
		[FieldOffset(Offset = "0x20")]
		private GridPosition m_pos;

		// Token: 0x040144D3 RID: 83155
		[Token(Token = "0x40144D3")]
		[FieldOffset(Offset = "0x28")]
		private int m_discount;

		// Token: 0x040144D4 RID: 83156
		[Token(Token = "0x40144D4")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isBaseBuilding;

		// Token: 0x040144D5 RID: 83157
		[Token(Token = "0x40144D5")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_isPortBuilding;

		// Token: 0x040144D6 RID: 83158
		[Token(Token = "0x40144D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040144D7 RID: 83159
		[Token(Token = "0x40144D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144D8 RID: 83160
		[Token(Token = "0x40144D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144D9 RID: 83161
		[Token(Token = "0x40144D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;
	}
}
