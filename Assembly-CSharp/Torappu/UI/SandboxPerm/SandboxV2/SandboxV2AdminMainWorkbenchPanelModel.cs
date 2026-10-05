using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040EC RID: 16620
	[Token(Token = "0x20040EC")]
	public class SandboxV2AdminMainWorkbenchPanelModel
	{
		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x06019B40 RID: 105280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B41 RID: 105281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D52")]
		public string topicId
		{
			[Token(Token = "0x6019B40")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019B41")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x06019B42 RID: 105282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B43 RID: 105283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D53")]
		public SandboxV2AdminMainWorkbenchInitParam initParam
		{
			[Token(Token = "0x6019B42")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019B43")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x06019B44 RID: 105284 RVA: 0x0009F1F8 File Offset: 0x0009D3F8
		// (set) Token: 0x06019B45 RID: 105285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D54")]
		public SandboxV2AdminMainWorkbenchType currWorkbenchType
		{
			[Token(Token = "0x6019B44")]
			[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0")]
			[CompilerGenerated]
			get
			{
				return SandboxV2AdminMainWorkbenchType.NONE;
			}
			[Token(Token = "0x6019B45")]
			[Address(RVA = "0x12905E0", Offset = "0x128F1E0", VA = "0x1812905E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x06019B46 RID: 105286 RVA: 0x0009F210 File Offset: 0x0009D410
		// (set) Token: 0x06019B47 RID: 105287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D55")]
		public bool initShow
		{
			[Token(Token = "0x6019B46")]
			[Address(RVA = "0x12905D0", Offset = "0x128F1D0", VA = "0x1812905D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019B47")]
			[Address(RVA = "0x1290600", Offset = "0x128F200", VA = "0x181290600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x06019B48 RID: 105288 RVA: 0x0009F228 File Offset: 0x0009D428
		// (set) Token: 0x06019B49 RID: 105289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D56")]
		public bool filterCantMake
		{
			[Token(Token = "0x6019B48")]
			[Address(RVA = "0x12905B0", Offset = "0x128F1B0", VA = "0x1812905B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019B49")]
			[Address(RVA = "0x12905F0", Offset = "0x128F1F0", VA = "0x1812905F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x06019B4A RID: 105290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D57")]
		public List<SandboxV2AdminMainMaterialModel> materialItems
		{
			[Token(Token = "0x6019B4A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x06019B4B RID: 105291 RVA: 0x0009F240 File Offset: 0x0009D440
		[Token(Token = "0x17003D58")]
		public int goldStock
		{
			[Token(Token = "0x6019B4B")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06019B4C RID: 105292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B4C")]
		[Address(RVA = "0x128DEC0", Offset = "0x128CAC0", VA = "0x18128DEC0")]
		public void LoadData(string topicId, SandboxV2AdminMainWorkbenchInitParam initParam)
		{
		}

		// Token: 0x06019B4D RID: 105293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B4D")]
		[Address(RVA = "0x128E310", Offset = "0x128CF10", VA = "0x18128E310")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06019B4E RID: 105294 RVA: 0x0009F258 File Offset: 0x0009D458
		[Token(Token = "0x6019B4E")]
		[Address(RVA = "0x128DE30", Offset = "0x128CA30", VA = "0x18128DE30")]
		public bool CheckTypeActive(SandboxV2AdminMainWorkbenchType type)
		{
			return default(bool);
		}

		// Token: 0x06019B4F RID: 105295 RVA: 0x0009F270 File Offset: 0x0009D470
		[Token(Token = "0x6019B4F")]
		[Address(RVA = "0x128E550", Offset = "0x128D150", VA = "0x18128E550")]
		public bool SetWorkbenchType(SandboxV2AdminMainWorkbenchType workbenchType, bool init = false)
		{
			return default(bool);
		}

		// Token: 0x06019B50 RID: 105296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B50")]
		[Address(RVA = "0x128DE60", Offset = "0x128CA60", VA = "0x18128DE60")]
		public List<SandboxV2WorkbenchItemModel> GetCurrentItems()
		{
			return null;
		}

		// Token: 0x06019B51 RID: 105297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B51")]
		[Address(RVA = "0x128F9D0", Offset = "0x128E5D0", VA = "0x18128F9D0")]
		private void _LoadCommonItems(SandboxV2Data gameData, PlayerSandboxV2 playerData, List<SandboxV2WorkbenchItemModel> list, List<SandboxV2WorkbenchItemModel> listFiltered, SandboxV2CraftItemType type)
		{
		}

		// Token: 0x06019B52 RID: 105298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B52")]
		[Address(RVA = "0x128F640", Offset = "0x128E240", VA = "0x18128F640")]
		private void _LoadAlchemyItems(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B53 RID: 105299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B53")]
		[Address(RVA = "0x128FEC0", Offset = "0x128EAC0", VA = "0x18128FEC0")]
		private void _LoadMaterialsIfNeed(PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B54 RID: 105300 RVA: 0x0009F288 File Offset: 0x0009D488
		[Token(Token = "0x6019B54")]
		[Address(RVA = "0x128E7F0", Offset = "0x128D3F0", VA = "0x18128E7F0")]
		private static bool _CheckAlchemyUnlocked(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
			return default(bool);
		}

		// Token: 0x06019B55 RID: 105301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B55")]
		[Address(RVA = "0x128EFD0", Offset = "0x128DBD0", VA = "0x18128EFD0")]
		private List<SandboxV2AdminMainMaterialModel> _GenerateMaterials(PlayerSandboxV2 playerData, Dictionary<string, int> materialDict, out bool canMake)
		{
			return null;
		}

		// Token: 0x06019B56 RID: 105302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B56")]
		[Address(RVA = "0x128EC10", Offset = "0x128D810", VA = "0x18128EC10")]
		private List<SandboxV2AdminMainMaterialModel> _GenerateMaterials(PlayerSandboxV2 playerData, List<SandboxV2AlchemyMaterialData> materialList, out bool canMake)
		{
			return null;
		}

		// Token: 0x06019B57 RID: 105303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B57")]
		[Address(RVA = "0x128EA90", Offset = "0x128D690", VA = "0x18128EA90")]
		private static void _GenerateMaterialItem(PlayerSandboxV2 playerData, List<SandboxV2AdminMainMaterialModel> result, string matId, int matCount, out bool valid)
		{
		}

		// Token: 0x06019B58 RID: 105304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B58")]
		[Address(RVA = "0x128F3B0", Offset = "0x128DFB0", VA = "0x18128F3B0")]
		private void _GenerateWaterItem(List<SandboxV2AdminMainMaterialModel> result, int waterCount, out bool valid)
		{
		}

		// Token: 0x06019B59 RID: 105305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B59")]
		[Address(RVA = "0x128E970", Offset = "0x128D570", VA = "0x18128E970")]
		private void _GenerateGoldItem(List<SandboxV2AdminMainMaterialModel> result, int goldCount, out bool valid)
		{
		}

		// Token: 0x06019B5A RID: 105306 RVA: 0x0009F2A0 File Offset: 0x0009D4A0
		[Token(Token = "0x6019B5A")]
		[Address(RVA = "0x128F4D0", Offset = "0x128E0D0", VA = "0x18128F4D0")]
		private static int _GetCommonItemStock(PlayerSandboxV2 playerData, string itemId, SandboxV2CraftItemType type)
		{
			return 0;
		}

		// Token: 0x06019B5B RID: 105307 RVA: 0x0009F2B8 File Offset: 0x0009D4B8
		[Token(Token = "0x6019B5B")]
		[Address(RVA = "0x1290310", Offset = "0x128EF10", VA = "0x181290310")]
		private static int _MatComparison(SandboxV2AdminMainMaterialModel x, SandboxV2AdminMainMaterialModel y)
		{
			return 0;
		}

		// Token: 0x06019B5C RID: 105308 RVA: 0x0009F2D0 File Offset: 0x0009D4D0
		[Token(Token = "0x6019B5C")]
		[Address(RVA = "0x128F580", Offset = "0x128E180", VA = "0x18128F580")]
		private static int _ItemComparison(SandboxV2WorkbenchItemModel x, SandboxV2WorkbenchItemModel y)
		{
			return 0;
		}

		// Token: 0x06019B5D RID: 105309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B5D")]
		[Address(RVA = "0x1290390", Offset = "0x128EF90", VA = "0x181290390")]
		public SandboxV2AdminMainWorkbenchPanelModel()
		{
		}

		// Token: 0x04020288 RID: 131720
		[Token(Token = "0x4020288")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SandboxV2AdminMainMaterialModel> m_materialItems;

		// Token: 0x04020289 RID: 131721
		[Token(Token = "0x4020289")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<SandboxV2WorkbenchItemModel> m_tacticalItems;

		// Token: 0x0402028A RID: 131722
		[Token(Token = "0x402028A")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<SandboxV2WorkbenchItemModel> m_tacticalItemsFiltered;

		// Token: 0x0402028B RID: 131723
		[Token(Token = "0x402028B")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<SandboxV2WorkbenchItemModel> m_baseBuildingItems;

		// Token: 0x0402028C RID: 131724
		[Token(Token = "0x402028C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<SandboxV2WorkbenchItemModel> m_baseBuildingItemsFiltered;

		// Token: 0x0402028D RID: 131725
		[Token(Token = "0x402028D")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<SandboxV2WorkbenchItemModel> m_combatBuildingItems;

		// Token: 0x0402028E RID: 131726
		[Token(Token = "0x402028E")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<SandboxV2WorkbenchItemModel> m_combatBuildingItemsFiltered;

		// Token: 0x0402028F RID: 131727
		[Token(Token = "0x402028F")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<SandboxV2WorkbenchItemModel> m_alchemyItems;

		// Token: 0x04020290 RID: 131728
		[Token(Token = "0x4020290")]
		[FieldOffset(Offset = "0x50")]
		private string m_waterId;

		// Token: 0x04020291 RID: 131729
		[Token(Token = "0x4020291")]
		[FieldOffset(Offset = "0x58")]
		private string m_goldId;

		// Token: 0x04020292 RID: 131730
		[Token(Token = "0x4020292")]
		[FieldOffset(Offset = "0x60")]
		private int m_waterStock;

		// Token: 0x04020293 RID: 131731
		[Token(Token = "0x4020293")]
		[FieldOffset(Offset = "0x64")]
		private int m_goldStock;

		// Token: 0x04020294 RID: 131732
		[Token(Token = "0x4020294")]
		[FieldOffset(Offset = "0x68")]
		private bool m_materialDirty;

		// Token: 0x04020295 RID: 131733
		[Token(Token = "0x4020295")]
		[FieldOffset(Offset = "0x69")]
		private bool m_tacticalActive;

		// Token: 0x04020296 RID: 131734
		[Token(Token = "0x4020296")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_tacticalDirty;

		// Token: 0x04020297 RID: 131735
		[Token(Token = "0x4020297")]
		[FieldOffset(Offset = "0x6B")]
		private bool m_baseBuildingActive;

		// Token: 0x04020298 RID: 131736
		[Token(Token = "0x4020298")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_baseBuildingDirty;

		// Token: 0x04020299 RID: 131737
		[Token(Token = "0x4020299")]
		[FieldOffset(Offset = "0x6D")]
		private bool m_combatBuildingActive;

		// Token: 0x0402029A RID: 131738
		[Token(Token = "0x402029A")]
		[FieldOffset(Offset = "0x6E")]
		private bool m_combatBuildingDirty;

		// Token: 0x0402029B RID: 131739
		[Token(Token = "0x402029B")]
		[FieldOffset(Offset = "0x6F")]
		private bool m_alchemyActive;

		// Token: 0x0402029C RID: 131740
		[Token(Token = "0x402029C")]
		[FieldOffset(Offset = "0x70")]
		private bool m_alchemyDirty;
	}
}
