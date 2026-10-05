using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A55 RID: 10837
	[Token(Token = "0x2002A55")]
	public class ConstructRepairAllTrap : ConstructOp
	{
		// Token: 0x06011FCA RID: 73674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FCA")]
		[Address(RVA = "0x9FFF50", Offset = "0x9FEB50", VA = "0x1809FFF50")]
		public ConstructRepairAllTrap(int discount)
		{
		}

		// Token: 0x06011FCB RID: 73675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FCB")]
		[Address(RVA = "0x9FFA20", Offset = "0x9FE620", VA = "0x1809FFA20", Slot = "7")]
		public override void Execute()
		{
		}

		// Token: 0x06011FCC RID: 73676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FCC")]
		[Address(RVA = "0x9FFD60", Offset = "0x9FE960", VA = "0x1809FFD60", Slot = "8")]
		public override void Revert()
		{
		}

		// Token: 0x06011FCD RID: 73677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FCD")]
		[Address(RVA = "0x9FFC80", Offset = "0x9FE880", VA = "0x1809FFC80", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FCE RID: 73678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FCE")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020")]
		private void <>xLuaBaseProxy_Execute()
		{
		}

		// Token: 0x06011FCF RID: 73679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FCF")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0")]
		private void <>xLuaBaseProxy_Revert()
		{
		}

		// Token: 0x06011FD0 RID: 73680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FD0")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144EC RID: 83180
		[Token(Token = "0x40144EC")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<GridPosition, FP> m_cachedHpRatio;

		// Token: 0x040144ED RID: 83181
		[Token(Token = "0x40144ED")]
		[FieldOffset(Offset = "0x18")]
		private int m_discount;

		// Token: 0x040144EE RID: 83182
		[Token(Token = "0x40144EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040144EF RID: 83183
		[Token(Token = "0x40144EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144F0 RID: 83184
		[Token(Token = "0x40144F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144F1 RID: 83185
		[Token(Token = "0x40144F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;
	}
}
