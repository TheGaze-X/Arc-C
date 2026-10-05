using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x02001895 RID: 6293
	[Token(Token = "0x2001895")]
	public class FurnitureDatabase : IFurnitureDataProvider, IHotfixable
	{
		// Token: 0x06009F12 RID: 40722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F12")]
		[Address(RVA = "0x3198540", Offset = "0x3197140", VA = "0x183198540")]
		public void Setup(IFurnitureGroupDataProvider groupDataProvider)
		{
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F13")]
		[Address(RVA = "0x3198230", Offset = "0x3196E30", VA = "0x183198230", Slot = "4")]
		public void QueryData(Predicate<IFurnitureData> filter, Action<IFurnitureData> action)
		{
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F14")]
		[Address(RVA = "0x31983B0", Offset = "0x3196FB0", VA = "0x1831983B0", Slot = "5")]
		public void QueryDatas(Predicate<IFurnitureData> filter, Action<IFurnitureData> action)
		{
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F15")]
		[Address(RVA = "0x3197FF0", Offset = "0x3196BF0", VA = "0x183197FF0", Slot = "6")]
		public IFurnitureData GetData(string furnitureId)
		{
			return null;
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F16")]
		[Address(RVA = "0x31981A0", Offset = "0x3196DA0", VA = "0x1831981A0", Slot = "7")]
		public IList<IFurnitureData> GetDatasByType(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F17")]
		[Address(RVA = "0x3198080", Offset = "0x3196C80", VA = "0x183198080", Slot = "8")]
		public IList<IFurnitureData> GetDatasBySubType(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F18")]
		[Address(RVA = "0x3198110", Offset = "0x3196D10", VA = "0x183198110", Slot = "9")]
		public IList<IFurnitureData> GetDatasByThemeId(string themeId)
		{
			return null;
		}

		// Token: 0x06009F19 RID: 40729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F19")]
		[Address(RVA = "0x3198800", Offset = "0x3197400", VA = "0x183198800")]
		private void _SetupSearchTables()
		{
		}

		// Token: 0x06009F1A RID: 40730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F1A")]
		private void _AddToListInDict<KeyType, DataType>(KeyType key, DataType value, Dictionary<KeyType, IList<DataType>> dict)
		{
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F1B")]
		[Address(RVA = "0x3198BE0", Offset = "0x31977E0", VA = "0x183198BE0")]
		public FurnitureDatabase()
		{
		}

		// Token: 0x040095AC RID: 38316
		[Token(Token = "0x40095AC")]
		private const string DEFAULT_FURNITURE_PREFAB_NAME = "default_furniture";

		// Token: 0x040095AD RID: 38317
		[Token(Token = "0x40095AD")]
		[FieldOffset(Offset = "0x10")]
		private List<FurnitureDatabase.FurnitureDataAdapter> m_adapters;

		// Token: 0x040095AE RID: 38318
		[Token(Token = "0x40095AE")]
		[FieldOffset(Offset = "0x18")]
		private BuildingDB m_buildingDB;

		// Token: 0x040095AF RID: 38319
		[Token(Token = "0x40095AF")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, IFurnitureData> m_furniIdToAdapter;

		// Token: 0x040095B0 RID: 38320
		[Token(Token = "0x40095B0")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, IList<IFurnitureData>> m_themeIdToAdapters;

		// Token: 0x040095B1 RID: 38321
		[Token(Token = "0x40095B1")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<BuildingData.FurnitureType, IList<IFurnitureData>> m_typeToAdapters;

		// Token: 0x040095B2 RID: 38322
		[Token(Token = "0x40095B2")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<BuildingData.FurnitureSubType, IList<IFurnitureData>> m_subTypeToAdapters;

		// Token: 0x040095B3 RID: 38323
		[Token(Token = "0x40095B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x040095B4 RID: 38324
		[Token(Token = "0x40095B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_QueryData;

		// Token: 0x040095B5 RID: 38325
		[Token(Token = "0x40095B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_QueryDatas;

		// Token: 0x040095B6 RID: 38326
		[Token(Token = "0x40095B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x040095B7 RID: 38327
		[Token(Token = "0x40095B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDatasByType;

		// Token: 0x040095B8 RID: 38328
		[Token(Token = "0x40095B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDatasBySubType;

		// Token: 0x040095B9 RID: 38329
		[Token(Token = "0x40095B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDatasByThemeId;

		// Token: 0x040095BA RID: 38330
		[Token(Token = "0x40095BA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupSearchTables;

		// Token: 0x040095BB RID: 38331
		[Token(Token = "0x40095BB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddToListInDict;

		// Token: 0x040095BC RID: 38332
		[Token(Token = "0x40095BC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001896 RID: 6294
		[Token(Token = "0x2001896")]
		private class FurnitureDataAdapter : IFurnitureData, IDIYItem, IHotfixable
		{
			// Token: 0x06009F1C RID: 40732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F1C")]
			[Address(RVA = "0x3197390", Offset = "0x3195F90", VA = "0x183197390")]
			public FurnitureDataAdapter(BuildingData.CustomData.FurnitureData data, IFurnitureGroupData groupData)
			{
			}

			// Token: 0x170011ED RID: 4589
			// (get) Token: 0x06009F1D RID: 40733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011ED")]
			public string id
			{
				[Token(Token = "0x6009F1D")]
				[Address(RVA = "0x3197960", Offset = "0x3196560", VA = "0x183197960", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011EE RID: 4590
			// (get) Token: 0x06009F1E RID: 40734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011EE")]
			public string displayName
			{
				[Token(Token = "0x6009F1E")]
				[Address(RVA = "0x3197660", Offset = "0x3196260", VA = "0x183197660", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x06009F1F RID: 40735 RVA: 0x0003E0B8 File Offset: 0x0003C2B8
			[Token(Token = "0x170011EF")]
			public int dimX
			{
				[Token(Token = "0x6009F1F")]
				[Address(RVA = "0x3197510", Offset = "0x3196110", VA = "0x183197510", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x06009F20 RID: 40736 RVA: 0x0003E0D0 File Offset: 0x0003C2D0
			[Token(Token = "0x170011F0")]
			public int dimY
			{
				[Token(Token = "0x6009F20")]
				[Address(RVA = "0x3197580", Offset = "0x3196180", VA = "0x183197580", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x06009F21 RID: 40737 RVA: 0x0003E0E8 File Offset: 0x0003C2E8
			[Token(Token = "0x170011F1")]
			public int dimZ
			{
				[Token(Token = "0x6009F21")]
				[Address(RVA = "0x31975F0", Offset = "0x31961F0", VA = "0x1831975F0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x06009F22 RID: 40738 RVA: 0x0003E100 File Offset: 0x0003C300
			[Token(Token = "0x170011F2")]
			public bool validOnRotate
			{
				[Token(Token = "0x6009F22")]
				[Address(RVA = "0x3197F80", Offset = "0x3196B80", VA = "0x183197F80", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x06009F23 RID: 40739 RVA: 0x0003E118 File Offset: 0x0003C318
			[Token(Token = "0x170011F3")]
			public bool enableRotate
			{
				[Token(Token = "0x6009F23")]
				[Address(RVA = "0x3197740", Offset = "0x3196340", VA = "0x183197740", Slot = "13")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170011F4 RID: 4596
			// (get) Token: 0x06009F24 RID: 40740 RVA: 0x0003E130 File Offset: 0x0003C330
			[Token(Token = "0x170011F4")]
			public int comfort
			{
				[Token(Token = "0x6009F24")]
				[Address(RVA = "0x3197430", Offset = "0x3196030", VA = "0x183197430", Slot = "17")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F5 RID: 4597
			// (get) Token: 0x06009F25 RID: 40741 RVA: 0x0003E148 File Offset: 0x0003C348
			[Token(Token = "0x170011F5")]
			public int rarity
			{
				[Token(Token = "0x6009F25")]
				[Address(RVA = "0x3197D20", Offset = "0x3196920", VA = "0x183197D20", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x06009F26 RID: 40742 RVA: 0x0003E160 File Offset: 0x0003C360
			[Token(Token = "0x170011F6")]
			public int sortId
			{
				[Token(Token = "0x6009F26")]
				[Address(RVA = "0x3197D90", Offset = "0x3196990", VA = "0x183197D90", Slot = "27")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x06009F27 RID: 40743 RVA: 0x0003E178 File Offset: 0x0003C378
			[Token(Token = "0x170011F7")]
			public int quantity
			{
				[Token(Token = "0x6009F27")]
				[Address(RVA = "0x3197CB0", Offset = "0x31968B0", VA = "0x183197CB0", Slot = "26")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x06009F28 RID: 40744 RVA: 0x0003E190 File Offset: 0x0003C390
			[Token(Token = "0x170011F8")]
			public int enableRoomType
			{
				[Token(Token = "0x6009F28")]
				[Address(RVA = "0x31976D0", Offset = "0x31962D0", VA = "0x1831976D0", Slot = "28")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x06009F29 RID: 40745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011F9")]
			public string themeId
			{
				[Token(Token = "0x6009F29")]
				[Address(RVA = "0x3197E70", Offset = "0x3196A70", VA = "0x183197E70", Slot = "19")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011FA RID: 4602
			// (get) Token: 0x06009F2A RID: 40746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011FA")]
			public string groupId
			{
				[Token(Token = "0x6009F2A")]
				[Address(RVA = "0x3197820", Offset = "0x3196420", VA = "0x183197820", Slot = "20")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011FB RID: 4603
			// (get) Token: 0x06009F2B RID: 40747 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
			[Token(Token = "0x170011FB")]
			public FurnitureInteractType interactType
			{
				[Token(Token = "0x6009F2B")]
				[Address(RVA = "0x31979D0", Offset = "0x31965D0", VA = "0x1831979D0", Slot = "8")]
				get
				{
					return FurnitureInteractType.NONE;
				}
			}

			// Token: 0x170011FC RID: 4604
			// (get) Token: 0x06009F2C RID: 40748 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
			[Token(Token = "0x170011FC")]
			public FurnitureLocationType locationType
			{
				[Token(Token = "0x6009F2C")]
				[Address(RVA = "0x3197A40", Offset = "0x3196640", VA = "0x183197A40", Slot = "7")]
				get
				{
					return FurnitureLocationType.GROUND;
				}
			}

			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x06009F2D RID: 40749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011FD")]
			public GameObject prefab
			{
				[Token(Token = "0x6009F2D")]
				[Address(RVA = "0x3197B80", Offset = "0x3196780", VA = "0x183197B80", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011FE RID: 4606
			// (get) Token: 0x06009F2E RID: 40750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011FE")]
			public Sprite icon
			{
				[Token(Token = "0x6009F2E")]
				[Address(RVA = "0x31978C0", Offset = "0x31964C0", VA = "0x1831978C0", Slot = "21")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011FF RID: 4607
			// (get) Token: 0x06009F2F RID: 40751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011FF")]
			public string desc
			{
				[Token(Token = "0x6009F2F")]
				[Address(RVA = "0x31974A0", Offset = "0x31960A0", VA = "0x1831974A0", Slot = "22")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001200 RID: 4608
			// (get) Token: 0x06009F30 RID: 40752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001200")]
			public string usage
			{
				[Token(Token = "0x6009F30")]
				[Address(RVA = "0x3197F10", Offset = "0x3196B10", VA = "0x183197F10", Slot = "23")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001201 RID: 4609
			// (get) Token: 0x06009F31 RID: 40753 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
			[Token(Token = "0x17001201")]
			public BuildingData.FurnitureType furniType
			{
				[Token(Token = "0x6009F31")]
				[Address(RVA = "0x31977B0", Offset = "0x31963B0", VA = "0x1831977B0", Slot = "24")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x17001202 RID: 4610
			// (get) Token: 0x06009F32 RID: 40754 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
			[Token(Token = "0x17001202")]
			public BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x6009F32")]
				[Address(RVA = "0x3197E00", Offset = "0x3196A00", VA = "0x183197E00", Slot = "25")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x17001203 RID: 4611
			// (get) Token: 0x06009F33 RID: 40755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001203")]
			public string musicId
			{
				[Token(Token = "0x6009F33")]
				[Address(RVA = "0x3197B10", Offset = "0x3196710", VA = "0x183197B10", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x040095BD RID: 38333
			[Token(Token = "0x40095BD")]
			[FieldOffset(Offset = "0x10")]
			private BuildingData.CustomData.FurnitureData m_buildingFurnitureData;

			// Token: 0x040095BE RID: 38334
			[Token(Token = "0x40095BE")]
			[FieldOffset(Offset = "0x18")]
			private IFurnitureGroupData m_groupData;

			// Token: 0x040095BF RID: 38335
			[Token(Token = "0x40095BF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040095C0 RID: 38336
			[Token(Token = "0x40095C0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x040095C1 RID: 38337
			[Token(Token = "0x40095C1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x040095C2 RID: 38338
			[Token(Token = "0x40095C2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_dimX;

			// Token: 0x040095C3 RID: 38339
			[Token(Token = "0x40095C3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_dimY;

			// Token: 0x040095C4 RID: 38340
			[Token(Token = "0x40095C4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_dimZ;

			// Token: 0x040095C5 RID: 38341
			[Token(Token = "0x40095C5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_validOnRotate;

			// Token: 0x040095C6 RID: 38342
			[Token(Token = "0x40095C6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_enableRotate;

			// Token: 0x040095C7 RID: 38343
			[Token(Token = "0x40095C7")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_comfort;

			// Token: 0x040095C8 RID: 38344
			[Token(Token = "0x40095C8")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_rarity;

			// Token: 0x040095C9 RID: 38345
			[Token(Token = "0x40095C9")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x040095CA RID: 38346
			[Token(Token = "0x40095CA")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_quantity;

			// Token: 0x040095CB RID: 38347
			[Token(Token = "0x40095CB")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x040095CC RID: 38348
			[Token(Token = "0x40095CC")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_themeId;

			// Token: 0x040095CD RID: 38349
			[Token(Token = "0x40095CD")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_groupId;

			// Token: 0x040095CE RID: 38350
			[Token(Token = "0x40095CE")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_interactType;

			// Token: 0x040095CF RID: 38351
			[Token(Token = "0x40095CF")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_locationType;

			// Token: 0x040095D0 RID: 38352
			[Token(Token = "0x40095D0")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_prefab;

			// Token: 0x040095D1 RID: 38353
			[Token(Token = "0x40095D1")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x040095D2 RID: 38354
			[Token(Token = "0x40095D2")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_desc;

			// Token: 0x040095D3 RID: 38355
			[Token(Token = "0x40095D3")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_usage;

			// Token: 0x040095D4 RID: 38356
			[Token(Token = "0x40095D4")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_furniType;

			// Token: 0x040095D5 RID: 38357
			[Token(Token = "0x40095D5")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_subType;

			// Token: 0x040095D6 RID: 38358
			[Token(Token = "0x40095D6")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_musicId;
		}
	}
}
