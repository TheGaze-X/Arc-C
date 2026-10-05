using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F2 RID: 8690
	[Token(Token = "0x20021F2")]
	public class RangeLineEffectByStatusHandler : RangeLineEffectHandler
	{
		// Token: 0x0600D96A RID: 55658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96A")]
		[Address(RVA = "0x35E6E20", Offset = "0x35E5A20", VA = "0x1835E6E20")]
		public void SetTileStatus(GridPosition grid, int status)
		{
		}

		// Token: 0x0600D96B RID: 55659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96B")]
		[Address(RVA = "0x35E7550", Offset = "0x35E6150", VA = "0x1835E7550", Slot = "4")]
		protected override void _InitMapIfNot()
		{
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96C")]
		[Address(RVA = "0x35E83C0", Offset = "0x35E6FC0", VA = "0x1835E83C0", Slot = "6")]
		protected override void _UpdateEdgeCornerStatus()
		{
		}

		// Token: 0x0600D96D RID: 55661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96D")]
		[Address(RVA = "0x35E82C0", Offset = "0x35E6EC0", VA = "0x1835E82C0")]
		private void _UpdateAllPointStatus()
		{
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96E")]
		[Address(RVA = "0x35E7600", Offset = "0x35E6200", VA = "0x1835E7600", Slot = "5")]
		protected override void _RenderLine()
		{
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D96F")]
		[Address(RVA = "0x35E7DB0", Offset = "0x35E69B0", VA = "0x1835E7DB0")]
		private void _SplitEdgeLinesByStatus()
		{
		}

		// Token: 0x0600D970 RID: 55664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D970")]
		[Address(RVA = "0x35E7F70", Offset = "0x35E6B70", VA = "0x1835E7F70")]
		private void _SplitPointListByStatus(List<GridPosition> pointList)
		{
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x0004EF48 File Offset: 0x0004D148
		[Token(Token = "0x600D971")]
		[Address(RVA = "0x35E7450", Offset = "0x35E6050", VA = "0x1835E7450")]
		private int _GetTileStatus(int row, int col)
		{
			return 0;
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x0004EF60 File Offset: 0x0004D160
		[Token(Token = "0x600D972")]
		[Address(RVA = "0x35E71D0", Offset = "0x35E5DD0", VA = "0x1835E71D0")]
		private int _GetPointStatus(int row, int col)
		{
			return 0;
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x0004EF78 File Offset: 0x0004D178
		[Token(Token = "0x600D973")]
		[Address(RVA = "0x35E7010", Offset = "0x35E5C10", VA = "0x1835E7010")]
		private int _GetEdgeStatus(GridPosition point1, GridPosition point2)
		{
			return 0;
		}

		// Token: 0x0600D974 RID: 55668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D974")]
		[Address(RVA = "0x35E6AB0", Offset = "0x35E56B0", VA = "0x1835E6AB0")]
		private Effect GetEffect(string key)
		{
			return null;
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D975")]
		[Address(RVA = "0x35E8500", Offset = "0x35E7100", VA = "0x1835E8500")]
		public RangeLineEffectByStatusHandler()
		{
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D976")]
		[Address(RVA = "0x35E6FE0", Offset = "0x35E5BE0", VA = "0x1835E6FE0")]
		private void <>xLuaBaseProxy__InitMapIfNot()
		{
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D977")]
		[Address(RVA = "0x35E7000", Offset = "0x35E5C00", VA = "0x1835E7000")]
		private void <>xLuaBaseProxy__UpdateEdgeCornerStatus()
		{
		}

		// Token: 0x0600D978 RID: 55672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D978")]
		[Address(RVA = "0x35E6FF0", Offset = "0x35E5BF0", VA = "0x1835E6FF0")]
		private void <>xLuaBaseProxy__RenderLine()
		{
		}

		// Token: 0x0400EA7B RID: 60027
		[Token(Token = "0x400EA7B")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<List<int>> m_tileStatus;

		// Token: 0x0400EA7C RID: 60028
		[Token(Token = "0x400EA7C")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<List<int>> m_pointStatus;

		// Token: 0x0400EA7D RID: 60029
		[Token(Token = "0x400EA7D")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<List<GridPosition>> m_edgeLinesTemp;

		// Token: 0x0400EA7E RID: 60030
		[Token(Token = "0x400EA7E")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<int> m_edgeLinesStatus;

		// Token: 0x0400EA7F RID: 60031
		[Token(Token = "0x400EA7F")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<ObjectPtr<Effect>> m_edgeEffectsUnused;

		// Token: 0x0400EA80 RID: 60032
		[Token(Token = "0x400EA80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetTileStatus;

		// Token: 0x0400EA81 RID: 60033
		[Token(Token = "0x400EA81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitMapIfNot;

		// Token: 0x0400EA82 RID: 60034
		[Token(Token = "0x400EA82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateEdgeCornerStatus;

		// Token: 0x0400EA83 RID: 60035
		[Token(Token = "0x400EA83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAllPointStatus;

		// Token: 0x0400EA84 RID: 60036
		[Token(Token = "0x400EA84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderLine;

		// Token: 0x0400EA85 RID: 60037
		[Token(Token = "0x400EA85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SplitEdgeLinesByStatus;

		// Token: 0x0400EA86 RID: 60038
		[Token(Token = "0x400EA86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SplitPointListByStatus;

		// Token: 0x0400EA87 RID: 60039
		[Token(Token = "0x400EA87")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTileStatus;

		// Token: 0x0400EA88 RID: 60040
		[Token(Token = "0x400EA88")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetPointStatus;

		// Token: 0x0400EA89 RID: 60041
		[Token(Token = "0x400EA89")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetEdgeStatus;

		// Token: 0x0400EA8A RID: 60042
		[Token(Token = "0x400EA8A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetEffect;

		// Token: 0x0400EA8B RID: 60043
		[Token(Token = "0x400EA8B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
