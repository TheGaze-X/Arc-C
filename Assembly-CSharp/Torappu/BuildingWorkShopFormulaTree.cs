using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	public class BuildingWorkShopFormulaTree : IHotfixable
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x0002D720 File Offset: 0x0002B920
		[Token(Token = "0x170001FE")]
		public bool isTreeAvail
		{
			[Token(Token = "0x6004D2C")]
			[Address(RVA = "0x17900A0", Offset = "0x178ECA0", VA = "0x1817900A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x178F590", Offset = "0x178E190", VA = "0x18178F590")]
		private void _RefreshItemCount()
		{
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x178EA60", Offset = "0x178D660", VA = "0x18178EA60")]
		public void RefreshTree()
		{
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0002D738 File Offset: 0x0002B938
		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x178F0B0", Offset = "0x178DCB0", VA = "0x18178F0B0")]
		private int _GetFormulaWorkMaxCount(BuildingWorkShopFormulaTree.Node node, int defaultWorkMaxCount)
		{
			return 0;
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x178ED20", Offset = "0x178D920", VA = "0x18178ED20")]
		public BuildingWorkShopFormulaTree.Node TryGetNodeByItemId(string itemId)
		{
			return null;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x178FFA0", Offset = "0x178EBA0", VA = "0x18178FFA0")]
		public BuildingWorkShopFormulaTree(string requireItemId)
		{
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x178FE80", Offset = "0x178EA80", VA = "0x18178FE80")]
		public BuildingWorkShopFormulaTree(string requireItemId, int requireCount)
		{
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x178F890", Offset = "0x178E490", VA = "0x18178F890")]
		private void _SetWorkFormulaTree(string requireItem, int requireCount, bool isNeedCalculateExtraRequire)
		{
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x178F710", Offset = "0x178E310", VA = "0x18178F710")]
		private void _RegisterNode(BuildingWorkShopFormulaTree.Node node)
		{
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x178E510", Offset = "0x178D110", VA = "0x18178E510")]
		public void OutPutTree()
		{
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x178EFB0", Offset = "0x178DBB0", VA = "0x18178EFB0")]
		private BuildingWorkShopFormulaTree.Node _GenNodeWithOutChild(string itemId, int requireCount, bool isNeedCalculateExtraRequire)
		{
			return null;
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x178EDF0", Offset = "0x178D9F0", VA = "0x18178EDF0")]
		private BuildingWorkShopFormulaTree.Node _GenNodeWithOutChild(string parentNodeItemId, string itemId, int requireCount, int perCount, bool isNeedCalculateExtraRequire)
		{
			return null;
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x178F290", Offset = "0x178DE90", VA = "0x18178F290")]
		private BuildingWorkShopFormulaTree.Node _InternalGenNodeWithoutChild(BuildingWorkShopFormulaTree.Node node, string itemId, int requireCount, bool isNeedCalculateExtraRequire)
		{
			return null;
		}

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x10")]
		public BuildingWorkShopFormulaTree.Node currentNode;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, BuildingWorkShopFormulaTree.Node> nodeDict;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x20")]
		public List<BuildingWorkShopFormulaTree.Node> nodeList;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x28")]
		public List<string> itemList;

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isTreeAvail;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MAX_NODE_COUNT;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isTreeAvail;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshItemCount;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshTree;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetFormulaWorkMaxCount;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetNodeByItemId;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetWorkFormulaTree;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RegisterNode;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OutPutTree;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenNodeWithOutChild;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1__GenNodeWithOutChild;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InternalGenNodeWithoutChild;

		// Token: 0x020004B6 RID: 1206
		[Token(Token = "0x20004B6")]
		public class Node
		{
			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06004D3A RID: 19770 RVA: 0x0002D750 File Offset: 0x0002B950
			[Token(Token = "0x170001FF")]
			public bool isFulfillOne
			{
				[Token(Token = "0x6004D3A")]
				[Address(RVA = "0x17930D0", Offset = "0x1791CD0", VA = "0x1817930D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x06004D3B RID: 19771 RVA: 0x0002D768 File Offset: 0x0002B968
			[Token(Token = "0x17000200")]
			public int extraRequireCount
			{
				[Token(Token = "0x6004D3B")]
				[Address(RVA = "0x1793020", Offset = "0x1791C20", VA = "0x181793020")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004D3C RID: 19772 RVA: 0x0002D780 File Offset: 0x0002B980
			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0x1792D80", Offset = "0x1791980", VA = "0x181792D80")]
			public int GetFormulaPerCount(string parentNodeItemId)
			{
				return 0;
			}

			// Token: 0x06004D3D RID: 19773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x1792DF0", Offset = "0x17919F0", VA = "0x181792DF0")]
			public void RefreshRequireCountByParentNode()
			{
			}

			// Token: 0x06004D3E RID: 19774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D3E")]
			[Address(RVA = "0x1792F50", Offset = "0x1791B50", VA = "0x181792F50")]
			public Node()
			{
			}

			// Token: 0x04001146 RID: 4422
			[Token(Token = "0x4001146")]
			[FieldOffset(Offset = "0x10")]
			public int nodeIndex;

			// Token: 0x04001147 RID: 4423
			[Token(Token = "0x4001147")]
			[FieldOffset(Offset = "0x18")]
			public List<BuildingWorkShopFormulaTree.Node> childNodes;

			// Token: 0x04001148 RID: 4424
			[Token(Token = "0x4001148")]
			[FieldOffset(Offset = "0x20")]
			public string itemId;

			// Token: 0x04001149 RID: 4425
			[Token(Token = "0x4001149")]
			[FieldOffset(Offset = "0x28")]
			public ItemType itemType;

			// Token: 0x0400114A RID: 4426
			[Token(Token = "0x400114A")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, int> perCountDict;

			// Token: 0x0400114B RID: 4427
			[Token(Token = "0x400114B")]
			[FieldOffset(Offset = "0x38")]
			public int itemCurrentCount;

			// Token: 0x0400114C RID: 4428
			[Token(Token = "0x400114C")]
			[FieldOffset(Offset = "0x3C")]
			public int itemRequireCount;

			// Token: 0x0400114D RID: 4429
			[Token(Token = "0x400114D")]
			[FieldOffset(Offset = "0x40")]
			public bool isNeedCalculateExtraRequire;

			// Token: 0x0400114E RID: 4430
			[Token(Token = "0x400114E")]
			[FieldOffset(Offset = "0x44")]
			public int availWorkMaxCount;

			// Token: 0x0400114F RID: 4431
			[Token(Token = "0x400114F")]
			[FieldOffset(Offset = "0x48")]
			public bool isChildNodeAlreadyUsed;

			// Token: 0x04001150 RID: 4432
			[Token(Token = "0x4001150")]
			[FieldOffset(Offset = "0x4C")]
			public int nodeLevel;

			// Token: 0x04001151 RID: 4433
			[Token(Token = "0x4001151")]
			[FieldOffset(Offset = "0x50")]
			public bool isBlockJump;

			// Token: 0x04001152 RID: 4434
			[Token(Token = "0x4001152")]
			[FieldOffset(Offset = "0x58")]
			public BuildingData.WorkshopFormula workshopFormula;

			// Token: 0x04001153 RID: 4435
			[Token(Token = "0x4001153")]
			[FieldOffset(Offset = "0x60")]
			public List<BuildingWorkShopFormulaTree.Node> formulaTargets;
		}
	}
}
