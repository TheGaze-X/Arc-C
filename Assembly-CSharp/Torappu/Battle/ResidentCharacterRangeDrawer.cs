using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002669 RID: 9833
	[Token(Token = "0x2002669")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ResidentCharacterRangeDrawer : GridRangeDrawer
	{
		// Token: 0x0601014F RID: 65871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014F")]
		[Address(RVA = "0x7CF910", Offset = "0x7CE510", VA = "0x1807CF910", Slot = "12")]
		protected override void _TurnOnInternal(IList<GridRangeDrawer.RangeEntry> ranges, Material material)
		{
		}

		// Token: 0x06010150 RID: 65872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010150")]
		[Address(RVA = "0x7CFBF0", Offset = "0x7CE7F0", VA = "0x1807CFBF0")]
		public void _UpdateRange()
		{
		}

		// Token: 0x06010151 RID: 65873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010151")]
		public void TurnOnAircraft<T>(IList<T> units) where T : Character
		{
		}

		// Token: 0x06010152 RID: 65874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010152")]
		[Address(RVA = "0x7CF810", Offset = "0x7CE410", VA = "0x1807CF810")]
		private void _TurnOnInternalAircraft(IList<GridRangeDrawer.RangeEntry> ranges, Material material)
		{
		}

		// Token: 0x06010153 RID: 65875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010153")]
		[Address(RVA = "0x7CEFA0", Offset = "0x7CDBA0", VA = "0x1807CEFA0")]
		private Mesh _CreateAircraftMesh(IList<GridRangeDrawer.RangeEntry> ranges)
		{
			return null;
		}

		// Token: 0x06010154 RID: 65876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010154")]
		[Address(RVA = "0x7CEE50", Offset = "0x7CDA50", VA = "0x1807CEE50")]
		public void ClearResidentRanges()
		{
		}

		// Token: 0x06010155 RID: 65877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010155")]
		[Address(RVA = "0x7CEEF0", Offset = "0x7CDAF0", VA = "0x1807CEEF0", Slot = "11")]
		public override void TurnOff()
		{
		}

		// Token: 0x06010156 RID: 65878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010156")]
		[Address(RVA = "0x7CFD30", Offset = "0x7CE930", VA = "0x1807CFD30")]
		public ResidentCharacterRangeDrawer()
		{
		}

		// Token: 0x06010157 RID: 65879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010157")]
		[Address(RVA = "0x7C7690", Offset = "0x7C6290", VA = "0x1807C7690")]
		private void <>xLuaBaseProxy__TurnOnInternal(IList<GridRangeDrawer.RangeEntry> P0, Material P1)
		{
		}

		// Token: 0x06010158 RID: 65880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010158")]
		[Address(RVA = "0x7C69E0", Offset = "0x7C55E0", VA = "0x1807C69E0")]
		private void <>xLuaBaseProxy_TurnOff()
		{
		}

		// Token: 0x04011E21 RID: 73249
		[Token(Token = "0x4011E21")]
		[FieldOffset(Offset = "0xC0")]
		private HashSet<GridPosition> m_meshPonitGridPositions;

		// Token: 0x04011E22 RID: 73250
		[Token(Token = "0x4011E22")]
		[FieldOffset(Offset = "0xC8")]
		private HashSet<Vector2> m_meshPonits;

		// Token: 0x04011E23 RID: 73251
		[Token(Token = "0x4011E23")]
		[FieldOffset(Offset = "0xD0")]
		private Vector2 m_centerOffset;

		// Token: 0x04011E24 RID: 73252
		[Token(Token = "0x4011E24")]
		[FieldOffset(Offset = "0xD8")]
		private List<GridRangeDrawer.RangeEntry> m_residentRanges;

		// Token: 0x04011E25 RID: 73253
		[Token(Token = "0x4011E25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TurnOnInternal;

		// Token: 0x04011E26 RID: 73254
		[Token(Token = "0x4011E26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateRange;

		// Token: 0x04011E27 RID: 73255
		[Token(Token = "0x4011E27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TurnOnAircraft;

		// Token: 0x04011E28 RID: 73256
		[Token(Token = "0x4011E28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TurnOnInternalAircraft;

		// Token: 0x04011E29 RID: 73257
		[Token(Token = "0x4011E29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateAircraftMesh;

		// Token: 0x04011E2A RID: 73258
		[Token(Token = "0x4011E2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearResidentRanges;

		// Token: 0x04011E2B RID: 73259
		[Token(Token = "0x4011E2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TurnOff;

		// Token: 0x04011E2C RID: 73260
		[Token(Token = "0x4011E2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
