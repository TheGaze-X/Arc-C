using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200596E RID: 22894
	[Token(Token = "0x200596E")]
	public class CrisisV2SlotDetailViewModel : IHotfixable
	{
		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06021632 RID: 136754 RVA: 0x000BA048 File Offset: 0x000B8248
		[Token(Token = "0x17004E7F")]
		public Vector2 mapSize
		{
			[Token(Token = "0x6021632")]
			[Address(RVA = "0x1BCF520", Offset = "0x1BCE120", VA = "0x181BCF520")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06021633 RID: 136755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E80")]
		public Dictionary<string, CrisisV2RoadPosData> roadPosMap
		{
			[Token(Token = "0x6021633")]
			[Address(RVA = "0x1BCF640", Offset = "0x1BCE240", VA = "0x181BCF640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x06021634 RID: 136756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E81")]
		public Dictionary<string, CrisisV2NodePosData> nodePosMap
		{
			[Token(Token = "0x6021634")]
			[Address(RVA = "0x1BCF5D0", Offset = "0x1BCE1D0", VA = "0x181BCF5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06021635 RID: 136757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E82")]
		public Dictionary<string, CrisisV2BagPosData> bagPosMap
		{
			[Token(Token = "0x6021635")]
			[Address(RVA = "0x1BCF440", Offset = "0x1BCE040", VA = "0x181BCF440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x06021636 RID: 136758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E83")]
		public Dictionary<string, CrisisV2ExclusionPosData> exclusionMap
		{
			[Token(Token = "0x6021636")]
			[Address(RVA = "0x1BCF4B0", Offset = "0x1BCE0B0", VA = "0x181BCF4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021637 RID: 136759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021637")]
		[Address(RVA = "0x1BCF350", Offset = "0x1BCDF50", VA = "0x181BCF350")]
		public void LoadData(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x06021638 RID: 136760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021638")]
		[Address(RVA = "0x1BCF3E0", Offset = "0x1BCDFE0", VA = "0x181BCF3E0")]
		public CrisisV2SlotDetailViewModel()
		{
		}

		// Token: 0x0402D88B RID: 186507
		[Token(Token = "0x402D88B")]
		[FieldOffset(Offset = "0x10")]
		private CrisisV2NodeViewData m_nodeViewData;

		// Token: 0x0402D88C RID: 186508
		[Token(Token = "0x402D88C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapSize;

		// Token: 0x0402D88D RID: 186509
		[Token(Token = "0x402D88D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_roadPosMap;

		// Token: 0x0402D88E RID: 186510
		[Token(Token = "0x402D88E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nodePosMap;

		// Token: 0x0402D88F RID: 186511
		[Token(Token = "0x402D88F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bagPosMap;

		// Token: 0x0402D890 RID: 186512
		[Token(Token = "0x402D890")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_exclusionMap;

		// Token: 0x0402D891 RID: 186513
		[Token(Token = "0x402D891")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D892 RID: 186514
		[Token(Token = "0x402D892")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
