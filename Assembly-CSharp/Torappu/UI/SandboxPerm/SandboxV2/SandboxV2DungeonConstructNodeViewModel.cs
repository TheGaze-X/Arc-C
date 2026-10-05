using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CF RID: 17103
	[Token(Token = "0x20042CF")]
	public abstract class SandboxV2DungeonConstructNodeViewModel : SandboxV2DungeonNodeViewModel, ISandboxV2BuildingDetail
	{
		// Token: 0x0601A4FB RID: 107771 RVA: 0x000A1148 File Offset: 0x0009F348
		[Token(Token = "0x601A4FB")]
		[Address(RVA = "0x1329E30", Offset = "0x1328A30", VA = "0x181329E30", Slot = "4")]
		protected sealed override bool IsConstructNode()
		{
			return default(bool);
		}

		// Token: 0x0601A4FC RID: 107772 RVA: 0x000A1160 File Offset: 0x0009F360
		[Token(Token = "0x601A4FC")]
		[Address(RVA = "0x1329F00", Offset = "0x1328B00", VA = "0x181329F00", Slot = "8")]
		protected sealed override bool IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4FD RID: 107773 RVA: 0x000A1178 File Offset: 0x0009F378
		[Token(Token = "0x601A4FD")]
		[Address(RVA = "0x1329C20", Offset = "0x1328820", VA = "0x181329C20", Slot = "10")]
		protected sealed override SandboxV2NodeStartBattleFuncType GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4FE RID: 107774 RVA: 0x000A1190 File Offset: 0x0009F390
		[Token(Token = "0x601A4FE")]
		[Address(RVA = "0x1329BC0", Offset = "0x13287C0", VA = "0x181329BC0", Slot = "9")]
		protected sealed override SandboxV2EnemyDetailShowType GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4FF RID: 107775 RVA: 0x000A11A8 File Offset: 0x0009F3A8
		[Token(Token = "0x601A4FF")]
		[Address(RVA = "0x1329B60", Offset = "0x1328760", VA = "0x181329B60", Slot = "11")]
		protected sealed override int GetNodeActionCost()
		{
			return 0;
		}

		// Token: 0x0601A500 RID: 107776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A500")]
		[Address(RVA = "0x132A1F0", Offset = "0x1328DF0", VA = "0x18132A1F0", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A501 RID: 107777
		[Token(Token = "0x601A501")]
		protected abstract bool SupportBuildingTrapType(SandboxV2TrapItemType buildingTrapType);

		// Token: 0x0601A502 RID: 107778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A502")]
		[Address(RVA = "0x132A5D0", Offset = "0x13291D0", VA = "0x18132A5D0")]
		private void _LoadBuildingData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A503 RID: 107779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A503")]
		[Address(RVA = "0x132B390", Offset = "0x1329F90", VA = "0x18132B390")]
		private void _TryAddBuildingInfoModel(SandboxV2Data topicDetailData, SandboxV2ItemTrapData itemTrapData, Dictionary<string, int> trapDeployLimitData, PlayerSandboxV2.Dungeon.Building playerBuilding, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A504 RID: 107780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A504")]
		[Address(RVA = "0x132A290", Offset = "0x1328E90", VA = "0x18132A290")]
		private void _AddBuildingInfoModel(SandboxV2DungeonBuildingTrapInfo buildingInfo)
		{
		}

		// Token: 0x0601A505 RID: 107781 RVA: 0x000A11C0 File Offset: 0x0009F3C0
		[Token(Token = "0x601A505")]
		[Address(RVA = "0x132A410", Offset = "0x1329010", VA = "0x18132A410")]
		private bool _CanUpgrade(string itemId, string upgradeItemId, SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
			return default(bool);
		}

		// Token: 0x0601A506 RID: 107782 RVA: 0x000A11D8 File Offset: 0x0009F3D8
		[Token(Token = "0x601A506")]
		[Address(RVA = "0x1329E90", Offset = "0x1328A90", VA = "0x181329E90", Slot = "15")]
		public bool IsConstructTipSelected(SandboxV2ConstructTipType tipType)
		{
			return default(bool);
		}

		// Token: 0x0601A507 RID: 107783 RVA: 0x000A11F0 File Offset: 0x0009F3F0
		[Token(Token = "0x601A507")]
		[Address(RVA = "0x1329AD0", Offset = "0x13286D0", VA = "0x181329AD0", Slot = "16")]
		public int GetConstructTipCount(SandboxV2ConstructTipType tipType)
		{
			return 0;
		}

		// Token: 0x0601A508 RID: 107784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A508")]
		[Address(RVA = "0x1329F60", Offset = "0x1328B60", VA = "0x181329F60", Slot = "17")]
		public IEnumerable<SandboxV2DungeonBuildingTrapInfo> IterBuildingTrapInfo()
		{
			return null;
		}

		// Token: 0x0601A509 RID: 107785 RVA: 0x000A1208 File Offset: 0x0009F408
		[Token(Token = "0x601A509")]
		[Address(RVA = "0x1329D40", Offset = "0x1328940", VA = "0x181329D40", Slot = "18")]
		public bool IsBuildingDetailEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601A50A RID: 107786 RVA: 0x000A1220 File Offset: 0x0009F420
		[Token(Token = "0x601A50A")]
		[Address(RVA = "0x1329CE0", Offset = "0x13288E0", VA = "0x181329CE0", Slot = "19")]
		public SandboxV2NodeType GetNodeType()
		{
			return SandboxV2NodeType.NONE;
		}

		// Token: 0x0601A50B RID: 107787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A50B")]
		[Address(RVA = "0x1329C80", Offset = "0x1328880", VA = "0x181329C80", Slot = "20")]
		public string GetNodeTypeName()
		{
			return null;
		}

		// Token: 0x0601A50C RID: 107788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A50C")]
		[Address(RVA = "0x132B910", Offset = "0x132A510", VA = "0x18132B910")]
		protected SandboxV2DungeonConstructNodeViewModel()
		{
		}

		// Token: 0x0601A50D RID: 107789 RVA: 0x000A1238 File Offset: 0x0009F438
		[Token(Token = "0x601A50D")]
		[Address(RVA = "0x132A130", Offset = "0x1328D30", VA = "0x18132A130")]
		private bool <>xLuaBaseProxy_IsConstructNode()
		{
			return default(bool);
		}

		// Token: 0x0601A50E RID: 107790 RVA: 0x000A1250 File Offset: 0x0009F450
		[Token(Token = "0x601A50E")]
		[Address(RVA = "0x132A190", Offset = "0x1328D90", VA = "0x18132A190")]
		private bool <>xLuaBaseProxy_IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A50F RID: 107791 RVA: 0x000A1268 File Offset: 0x0009F468
		[Token(Token = "0x601A50F")]
		[Address(RVA = "0x132A0D0", Offset = "0x1328CD0", VA = "0x18132A0D0")]
		private SandboxV2NodeStartBattleFuncType <>xLuaBaseProxy_GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A510 RID: 107792 RVA: 0x000A1280 File Offset: 0x0009F480
		[Token(Token = "0x601A510")]
		[Address(RVA = "0x132A070", Offset = "0x1328C70", VA = "0x18132A070")]
		private SandboxV2EnemyDetailShowType <>xLuaBaseProxy_GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A511 RID: 107793 RVA: 0x000A1298 File Offset: 0x0009F498
		[Token(Token = "0x601A511")]
		[Address(RVA = "0x132A010", Offset = "0x1328C10", VA = "0x18132A010")]
		private int <>xLuaBaseProxy_GetNodeActionCost()
		{
			return 0;
		}

		// Token: 0x0601A512 RID: 107794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A512")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x040215A2 RID: 136610
		[Token(Token = "0x40215A2")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<string, SandboxV2DungeonBuildingTrapInfo> m_buildingTrapInfoDict;

		// Token: 0x040215A3 RID: 136611
		[Token(Token = "0x40215A3")]
		[FieldOffset(Offset = "0x100")]
		public bool constructUnlocked;

		// Token: 0x040215A4 RID: 136612
		[Token(Token = "0x40215A4")]
		[FieldOffset(Offset = "0x104")]
		public int constructUnlockLevel;

		// Token: 0x040215A5 RID: 136613
		[Token(Token = "0x40215A5")]
		[FieldOffset(Offset = "0x108")]
		public int[] constructTips;

		// Token: 0x040215A6 RID: 136614
		[Token(Token = "0x40215A6")]
		[FieldOffset(Offset = "0x110")]
		public List<SandboxV2DungeonBuildingTrapInfo> buildingTrapInfoList;

		// Token: 0x040215A7 RID: 136615
		[Token(Token = "0x40215A7")]
		[FieldOffset(Offset = "0x118")]
		public float hpRatio;

		// Token: 0x040215A8 RID: 136616
		[Token(Token = "0x40215A8")]
		[FieldOffset(Offset = "0x11C")]
		public SandboxV2ConstructHpType hpType;

		// Token: 0x040215A9 RID: 136617
		[Token(Token = "0x40215A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsConstructNode;

		// Token: 0x040215AA RID: 136618
		[Token(Token = "0x40215AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsUpgradable;

		// Token: 0x040215AB RID: 136619
		[Token(Token = "0x40215AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNodeStartBattleFuncType;

		// Token: 0x040215AC RID: 136620
		[Token(Token = "0x40215AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNodeEnemyDetailShowType;

		// Token: 0x040215AD RID: 136621
		[Token(Token = "0x40215AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNodeActionCost;

		// Token: 0x040215AE RID: 136622
		[Token(Token = "0x40215AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x040215AF RID: 136623
		[Token(Token = "0x40215AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadBuildingData;

		// Token: 0x040215B0 RID: 136624
		[Token(Token = "0x40215B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryAddBuildingInfoModel;

		// Token: 0x040215B1 RID: 136625
		[Token(Token = "0x40215B1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddBuildingInfoModel;

		// Token: 0x040215B2 RID: 136626
		[Token(Token = "0x40215B2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CanUpgrade;

		// Token: 0x040215B3 RID: 136627
		[Token(Token = "0x40215B3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsConstructTipSelected;

		// Token: 0x040215B4 RID: 136628
		[Token(Token = "0x40215B4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetConstructTipCount;

		// Token: 0x040215B5 RID: 136629
		[Token(Token = "0x40215B5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IterBuildingTrapInfo;

		// Token: 0x040215B6 RID: 136630
		[Token(Token = "0x40215B6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsBuildingDetailEmpty;

		// Token: 0x040215B7 RID: 136631
		[Token(Token = "0x40215B7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetNodeType;

		// Token: 0x040215B8 RID: 136632
		[Token(Token = "0x40215B8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetNodeTypeName;

		// Token: 0x040215B9 RID: 136633
		[Token(Token = "0x40215B9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
