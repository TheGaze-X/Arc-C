using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200263F RID: 9791
	[Token(Token = "0x200263F")]
	[Serializable]
	public struct BuildCondition : IHotfixable
	{
		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06010034 RID: 65588 RVA: 0x000616E0 File Offset: 0x0005F8E0
		[Token(Token = "0x170022F6")]
		private bool isMelee
		{
			[Token(Token = "0x6010034")]
			[Address(RVA = "0x77B080", Offset = "0x779C80", VA = "0x18077B080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06010035 RID: 65589 RVA: 0x000616F8 File Offset: 0x0005F8F8
		[Token(Token = "0x170022F7")]
		public bool needAbilityName
		{
			[Token(Token = "0x6010035")]
			[Address(RVA = "0x77B120", Offset = "0x779D20", VA = "0x18077B120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06010036 RID: 65590 RVA: 0x00061710 File Offset: 0x0005F910
		// (set) Token: 0x06010037 RID: 65591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022F8")]
		public bool excludeOccupiedByWalkEnemy
		{
			[Token(Token = "0x6010036")]
			[Address(RVA = "0x77AFE0", Offset = "0x779BE0", VA = "0x18077AFE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010037")]
			[Address(RVA = "0x77B280", Offset = "0x779E80", VA = "0x18077B280")]
			set
			{
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06010038 RID: 65592 RVA: 0x00061728 File Offset: 0x0005F928
		// (set) Token: 0x06010039 RID: 65593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022F9")]
		public bool checkUpdateBuildable
		{
			[Token(Token = "0x6010038")]
			[Address(RVA = "0x77AF40", Offset = "0x779B40", VA = "0x18077AF40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010039")]
			[Address(RVA = "0x77B1C0", Offset = "0x779DC0", VA = "0x18077B1C0")]
			set
			{
			}
		}

		// Token: 0x0601003A RID: 65594 RVA: 0x00061740 File Offset: 0x0005F940
		[Token(Token = "0x601003A")]
		[Address(RVA = "0x779470", Offset = "0x778070", VA = "0x180779470")]
		public bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0601003B RID: 65595 RVA: 0x00061758 File Offset: 0x0005F958
		[Token(Token = "0x601003B")]
		[Address(RVA = "0x77A0D0", Offset = "0x778CD0", VA = "0x18077A0D0")]
		private bool _CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0601003C RID: 65596 RVA: 0x00061770 File Offset: 0x0005F970
		[Token(Token = "0x601003C")]
		[Address(RVA = "0x77AA00", Offset = "0x779600", VA = "0x18077AA00")]
		public bool _CheckIgnoreBuildableType(Tile tile, BattleCharacterData sourceData)
		{
			return default(bool);
		}

		// Token: 0x0601003D RID: 65597 RVA: 0x00061788 File Offset: 0x0005F988
		[Token(Token = "0x601003D")]
		[Address(RVA = "0x779CF0", Offset = "0x7788F0", VA = "0x180779CF0")]
		public bool CheckTileKeyBuildableCondition(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601003E RID: 65598 RVA: 0x000617A0 File Offset: 0x0005F9A0
		[Token(Token = "0x601003E")]
		[Address(RVA = "0x7792C0", Offset = "0x777EC0", VA = "0x1807792C0")]
		public bool CanBuildOrOverlap(Tile tile, BattleCharacterData sourceData, bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0601003F RID: 65599 RVA: 0x000617B8 File Offset: 0x0005F9B8
		[Token(Token = "0x601003F")]
		[Address(RVA = "0x779A80", Offset = "0x778680", VA = "0x180779A80")]
		public bool CheckInHostRange(Tile tile, Character host)
		{
			return default(bool);
		}

		// Token: 0x06010040 RID: 65600 RVA: 0x000617D0 File Offset: 0x0005F9D0
		[Token(Token = "0x6010040")]
		[Address(RVA = "0x779840", Offset = "0x778440", VA = "0x180779840")]
		public bool CheckBuildable(Tile tile, BattleCharacterData sourceData, bool checkHost, bool spawnManually, bool overflowOccupiedCnt, PlayerSide operationSide = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x06010041 RID: 65601 RVA: 0x000617E8 File Offset: 0x0005F9E8
		[Token(Token = "0x6010041")]
		[Address(RVA = "0x779DF0", Offset = "0x7789F0", VA = "0x180779DF0")]
		public bool CheckUpdateBuildable()
		{
			return default(bool);
		}

		// Token: 0x06010042 RID: 65602 RVA: 0x00061800 File Offset: 0x0005FA00
		[Token(Token = "0x6010042")]
		[Address(RVA = "0x779ED0", Offset = "0x778AD0", VA = "0x180779ED0")]
		public BuildCondition Combine(AdditionalBuildCondition additionalBuildCondition)
		{
			return default(BuildCondition);
		}

		// Token: 0x04011CB8 RID: 72888
		[Token(Token = "0x4011CB8")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly BuildCondition DEFAULT;

		// Token: 0x04011CB9 RID: 72889
		[Token(Token = "0x4011CB9")]
		[FieldOffset(Offset = "0x0")]
		public BuildableType buildableType;

		// Token: 0x04011CBA RID: 72890
		[Token(Token = "0x4011CBA")]
		[FieldOffset(Offset = "0x4")]
		public bool isTryingOverlapCharacater;

		// Token: 0x04011CBB RID: 72891
		[Token(Token = "0x4011CBB")]
		[FieldOffset(Offset = "0x5")]
		public bool needSpecifyDirection;

		// Token: 0x04011CBC RID: 72892
		[Token(Token = "0x4011CBC")]
		[FieldOffset(Offset = "0x6")]
		public bool limitByHostAttackRange;

		// Token: 0x04011CBD RID: 72893
		[Token(Token = "0x4011CBD")]
		[FieldOffset(Offset = "0x7")]
		public bool limitByHostAbilityRange;

		// Token: 0x04011CBE RID: 72894
		[Token(Token = "0x4011CBE")]
		[FieldOffset(Offset = "0x8")]
		public string abilityName;

		// Token: 0x04011CBF RID: 72895
		[Token(Token = "0x4011CBF")]
		[FieldOffset(Offset = "0x10")]
		public string tileKey;

		// Token: 0x04011CC0 RID: 72896
		[Token(Token = "0x4011CC0")]
		[FieldOffset(Offset = "0x18")]
		public ExtraBuildConditionArray extraBuildConditionArray;

		// Token: 0x04011CC1 RID: 72897
		[Token(Token = "0x4011CC1")]
		[FieldOffset(Offset = "0x20")]
		public AdvancedBuildableMask advancedBuildableMask;

		// Token: 0x04011CC2 RID: 72898
		[Token(Token = "0x4011CC2")]
		[FieldOffset(Offset = "0x28")]
		public BuildCondition.OverlapOptions overlapOptions;

		// Token: 0x04011CC3 RID: 72899
		[Token(Token = "0x4011CC3")]
		[FieldOffset(Offset = "0x30")]
		public bool excludeNoTargetTile;

		// Token: 0x04011CC4 RID: 72900
		[Token(Token = "0x4011CC4")]
		[FieldOffset(Offset = "0x38")]
		public string extraLocateRange;

		// Token: 0x04011CC5 RID: 72901
		[Token(Token = "0x4011CC5")]
		[FieldOffset(Offset = "0x40")]
		public bool checkManuallyBuildableType;

		// Token: 0x04011CC6 RID: 72902
		[Token(Token = "0x4011CC6")]
		[FieldOffset(Offset = "0x44")]
		public BuildableType manuallyBuildableType;

		// Token: 0x04011CC7 RID: 72903
		[Token(Token = "0x4011CC7")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public int dynamicBuildConditionMask;

		// Token: 0x04011CC8 RID: 72904
		[Token(Token = "0x4011CC8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _excludeOccupiedByWalkEnemy;

		// Token: 0x04011CC9 RID: 72905
		[Token(Token = "0x4011CC9")]
		[FieldOffset(Offset = "0x4D")]
		[SerializeField]
		public bool allowWalkEnemyInHostRange;

		// Token: 0x04011CCA RID: 72906
		[Token(Token = "0x4011CCA")]
		[FieldOffset(Offset = "0x4E")]
		[SerializeField]
		private bool _checkUpdateBuildable;

		// Token: 0x04011CCB RID: 72907
		[Token(Token = "0x4011CCB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isMelee;

		// Token: 0x04011CCC RID: 72908
		[Token(Token = "0x4011CCC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_needAbilityName;

		// Token: 0x04011CCD RID: 72909
		[Token(Token = "0x4011CCD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_excludeOccupiedByWalkEnemy;

		// Token: 0x04011CCE RID: 72910
		[Token(Token = "0x4011CCE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_excludeOccupiedByWalkEnemy;

		// Token: 0x04011CCF RID: 72911
		[Token(Token = "0x4011CCF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_checkUpdateBuildable;

		// Token: 0x04011CD0 RID: 72912
		[Token(Token = "0x4011CD0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_checkUpdateBuildable;

		// Token: 0x04011CD1 RID: 72913
		[Token(Token = "0x4011CD1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x04011CD2 RID: 72914
		[Token(Token = "0x4011CD2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckBuildable;

		// Token: 0x04011CD3 RID: 72915
		[Token(Token = "0x4011CD3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckIgnoreBuildableType;

		// Token: 0x04011CD4 RID: 72916
		[Token(Token = "0x4011CD4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckTileKeyBuildableCondition;

		// Token: 0x04011CD5 RID: 72917
		[Token(Token = "0x4011CD5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CanBuildOrOverlap;

		// Token: 0x04011CD6 RID: 72918
		[Token(Token = "0x4011CD6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckInHostRange;

		// Token: 0x04011CD7 RID: 72919
		[Token(Token = "0x4011CD7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_CheckBuildable;

		// Token: 0x04011CD8 RID: 72920
		[Token(Token = "0x4011CD8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckUpdateBuildable;

		// Token: 0x04011CD9 RID: 72921
		[Token(Token = "0x4011CD9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Combine;

		// Token: 0x02002640 RID: 9792
		[Token(Token = "0x2002640")]
		[Serializable]
		public class OverlapOptions : IHotfixable
		{
			// Token: 0x170022FA RID: 8954
			// (get) Token: 0x06010044 RID: 65604 RVA: 0x00061818 File Offset: 0x0005FA18
			[Token(Token = "0x170022FA")]
			private bool verifySourceID
			{
				[Token(Token = "0x6010044")]
				[Address(RVA = "0x783360", Offset = "0x781F60", VA = "0x180783360")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022FB RID: 8955
			// (get) Token: 0x06010045 RID: 65605 RVA: 0x00061830 File Offset: 0x0005FA30
			[Token(Token = "0x170022FB")]
			private bool verifySourceProfession
			{
				[Token(Token = "0x6010045")]
				[Address(RVA = "0x7833E0", Offset = "0x781FE0", VA = "0x1807833E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022FC RID: 8956
			// (get) Token: 0x06010046 RID: 65606 RVA: 0x00061848 File Offset: 0x0005FA48
			[Token(Token = "0x170022FC")]
			public int overlapPriority
			{
				[Token(Token = "0x6010046")]
				[Address(RVA = "0x783300", Offset = "0x781F00", VA = "0x180783300")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170022FD RID: 8957
			// (get) Token: 0x06010047 RID: 65607 RVA: 0x00061860 File Offset: 0x0005FA60
			[Token(Token = "0x170022FD")]
			public bool changeTargetGraphicColor
			{
				[Token(Token = "0x6010047")]
				[Address(RVA = "0x7832A0", Offset = "0x781EA0", VA = "0x1807832A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010048 RID: 65608 RVA: 0x00061878 File Offset: 0x0005FA78
			[Token(Token = "0x6010048")]
			[Address(RVA = "0x782F90", Offset = "0x781B90", VA = "0x180782F90")]
			public bool VerifyOverlap(Character target, BattleCharacterData source)
			{
				return default(bool);
			}

			// Token: 0x06010049 RID: 65609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010049")]
			[Address(RVA = "0x782DE0", Offset = "0x7819E0", VA = "0x180782DE0")]
			public void AddOverlapSourceId(string sourceId)
			{
			}

			// Token: 0x0601004A RID: 65610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601004A")]
			[Address(RVA = "0x782E80", Offset = "0x781A80", VA = "0x180782E80")]
			public void RemoveOverlapSourceId(string sourceId)
			{
			}

			// Token: 0x0601004B RID: 65611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601004B")]
			[Address(RVA = "0x782F20", Offset = "0x781B20", VA = "0x180782F20")]
			public void SetOverlapTakeEffect(bool flag)
			{
			}

			// Token: 0x0601004C RID: 65612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601004C")]
			[Address(RVA = "0x783190", Offset = "0x781D90", VA = "0x180783190")]
			public OverlapOptions()
			{
			}

			// Token: 0x04011CDA RID: 72922
			[Token(Token = "0x4011CDA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _verifySourceId;

			// Token: 0x04011CDB RID: 72923
			[Token(Token = "0x4011CDB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private List<string> _verifySourceIds;

			// Token: 0x04011CDC RID: 72924
			[Token(Token = "0x4011CDC")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _verifySourceProfession;

			// Token: 0x04011CDD RID: 72925
			[Token(Token = "0x4011CDD")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private ProfessionCategory _verifySourceProfessions;

			// Token: 0x04011CDE RID: 72926
			[Token(Token = "0x4011CDE")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private bool _isAllConditionOR;

			// Token: 0x04011CDF RID: 72927
			[Token(Token = "0x4011CDF")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private BuildCondition.OverlapOptions.OnOverlapPriority _overlapPriority;

			// Token: 0x04011CE0 RID: 72928
			[Token(Token = "0x4011CE0")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _changeTargetGraphicColor;

			// Token: 0x04011CE1 RID: 72929
			[Token(Token = "0x4011CE1")]
			[FieldOffset(Offset = "0x38")]
			private HashSet<string> m_additionalSourceIds;

			// Token: 0x04011CE2 RID: 72930
			[Token(Token = "0x4011CE2")]
			[FieldOffset(Offset = "0x40")]
			private bool m_isOverlapTakeEffect;

			// Token: 0x04011CE3 RID: 72931
			[Token(Token = "0x4011CE3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_verifySourceID;

			// Token: 0x04011CE4 RID: 72932
			[Token(Token = "0x4011CE4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_verifySourceProfession;

			// Token: 0x04011CE5 RID: 72933
			[Token(Token = "0x4011CE5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_overlapPriority;

			// Token: 0x04011CE6 RID: 72934
			[Token(Token = "0x4011CE6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_changeTargetGraphicColor;

			// Token: 0x04011CE7 RID: 72935
			[Token(Token = "0x4011CE7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_VerifyOverlap;

			// Token: 0x04011CE8 RID: 72936
			[Token(Token = "0x4011CE8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AddOverlapSourceId;

			// Token: 0x04011CE9 RID: 72937
			[Token(Token = "0x4011CE9")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RemoveOverlapSourceId;

			// Token: 0x04011CEA RID: 72938
			[Token(Token = "0x4011CEA")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetOverlapTakeEffect;

			// Token: 0x04011CEB RID: 72939
			[Token(Token = "0x4011CEB")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02002641 RID: 9793
			[Token(Token = "0x2002641")]
			public enum OnOverlapPriority
			{
				// Token: 0x04011CED RID: 72941
				[Token(Token = "0x4011CED")]
				HIGH_PRIORITY = -1000,
				// Token: 0x04011CEE RID: 72942
				[Token(Token = "0x4011CEE")]
				DEFAULT = 0,
				// Token: 0x04011CEF RID: 72943
				[Token(Token = "0x4011CEF")]
				LOW_PRIORITY = 1000,
				// Token: 0x04011CF0 RID: 72944
				[Token(Token = "0x4011CF0")]
				LOWER_PRIORITY = 2000
			}
		}
	}
}
