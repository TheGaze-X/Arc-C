using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x02001878 RID: 6264
	[Token(Token = "0x2001878")]
	public class DIYRoomModifierDatabase : IDIYRoomModifierDataProvider, IHotfixable
	{
		// Token: 0x06009E82 RID: 40578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E82")]
		[Address(RVA = "0x318D970", Offset = "0x318C570", VA = "0x18318D970")]
		public void Setup(IFurnitureGroupDataProvider groupDataProvider)
		{
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E83")]
		[Address(RVA = "0x318D660", Offset = "0x318C260", VA = "0x18318D660", Slot = "4")]
		public void QueryData(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action)
		{
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E84")]
		[Address(RVA = "0x318D7E0", Offset = "0x318C3E0", VA = "0x18318D7E0", Slot = "5")]
		public void QueryDatas(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action)
		{
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E85")]
		[Address(RVA = "0x318D390", Offset = "0x318BF90", VA = "0x18318D390", Slot = "6")]
		public IDIYRoomModifierData GetData(string furnitureId)
		{
			return null;
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E86")]
		[Address(RVA = "0x318D5D0", Offset = "0x318C1D0", VA = "0x18318D5D0", Slot = "7")]
		public IList<IDIYRoomModifierData> GetDatasByType(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E87")]
		[Address(RVA = "0x318D4B0", Offset = "0x318C0B0", VA = "0x18318D4B0", Slot = "8")]
		public IList<IDIYRoomModifierData> GetDatasBySubType(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E88")]
		[Address(RVA = "0x318D540", Offset = "0x318C140", VA = "0x18318D540", Slot = "9")]
		public IList<IDIYRoomModifierData> GetDatasByThemeId(string themeId)
		{
			return null;
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E89")]
		[Address(RVA = "0x318D420", Offset = "0x318C020", VA = "0x18318D420", Slot = "10")]
		public IList<IDIYRoomModifierData> GetDatasByRoomPart(DIYRoomPart part)
		{
			return null;
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E8A")]
		[Address(RVA = "0x318DC10", Offset = "0x318C810", VA = "0x18318DC10")]
		private void _SetupSearchTables()
		{
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E8B")]
		private void _AddToListInDict<KeyType, DataType>(KeyType key, DataType value, Dictionary<KeyType, IList<DataType>> dict)
		{
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E8C")]
		[Address(RVA = "0x318E090", Offset = "0x318CC90", VA = "0x18318E090")]
		public DIYRoomModifierDatabase()
		{
		}

		// Token: 0x0400954F RID: 38223
		[Token(Token = "0x400954F")]
		private const string DEFAULT_FURNITURE_PREFAB_NAME = "default_furniture";

		// Token: 0x04009550 RID: 38224
		[Token(Token = "0x4009550")]
		[FieldOffset(Offset = "0x10")]
		private List<DIYRoomModifierDatabase.DIYRoomModifierDataAdapter> m_adapters;

		// Token: 0x04009551 RID: 38225
		[Token(Token = "0x4009551")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, IDIYRoomModifierData> m_furniIdToAdapter;

		// Token: 0x04009552 RID: 38226
		[Token(Token = "0x4009552")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, IList<IDIYRoomModifierData>> m_themeIdToAdapters;

		// Token: 0x04009553 RID: 38227
		[Token(Token = "0x4009553")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<BuildingData.FurnitureType, IList<IDIYRoomModifierData>> m_typeToAdapters;

		// Token: 0x04009554 RID: 38228
		[Token(Token = "0x4009554")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<BuildingData.FurnitureSubType, IList<IDIYRoomModifierData>> m_subTypeToAdapters;

		// Token: 0x04009555 RID: 38229
		[Token(Token = "0x4009555")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<DIYRoomPart, IList<IDIYRoomModifierData>> m_roomPartToAdapter;

		// Token: 0x04009556 RID: 38230
		[Token(Token = "0x4009556")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009557 RID: 38231
		[Token(Token = "0x4009557")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_QueryData;

		// Token: 0x04009558 RID: 38232
		[Token(Token = "0x4009558")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_QueryDatas;

		// Token: 0x04009559 RID: 38233
		[Token(Token = "0x4009559")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0400955A RID: 38234
		[Token(Token = "0x400955A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDatasByType;

		// Token: 0x0400955B RID: 38235
		[Token(Token = "0x400955B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDatasBySubType;

		// Token: 0x0400955C RID: 38236
		[Token(Token = "0x400955C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDatasByThemeId;

		// Token: 0x0400955D RID: 38237
		[Token(Token = "0x400955D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDatasByRoomPart;

		// Token: 0x0400955E RID: 38238
		[Token(Token = "0x400955E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetupSearchTables;

		// Token: 0x0400955F RID: 38239
		[Token(Token = "0x400955F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddToListInDict;

		// Token: 0x04009560 RID: 38240
		[Token(Token = "0x4009560")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001879 RID: 6265
		[Token(Token = "0x2001879")]
		private class DIYRoomModifierDataAdapter : IDIYRoomModifierData, IDIYItem, IHotfixable
		{
			// Token: 0x06009E8D RID: 40589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E8D")]
			[Address(RVA = "0x318CA40", Offset = "0x318B640", VA = "0x18318CA40")]
			public DIYRoomModifierDataAdapter(BuildingData.CustomData.FurnitureData furnitureData, IFurnitureGroupData groupData)
			{
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x06009E8E RID: 40590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011BC")]
			public string id
			{
				[Token(Token = "0x6009E8E")]
				[Address(RVA = "0x318CE40", Offset = "0x318BA40", VA = "0x18318CE40", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x06009E8F RID: 40591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011BD")]
			public string displayName
			{
				[Token(Token = "0x6009E8F")]
				[Address(RVA = "0x318CBC0", Offset = "0x318B7C0", VA = "0x18318CBC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x06009E90 RID: 40592 RVA: 0x0003DE00 File Offset: 0x0003C000
			[Token(Token = "0x170011BE")]
			public int comfort
			{
				[Token(Token = "0x6009E90")]
				[Address(RVA = "0x318CAE0", Offset = "0x318B6E0", VA = "0x18318CAE0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x06009E91 RID: 40593 RVA: 0x0003DE18 File Offset: 0x0003C018
			[Token(Token = "0x170011BF")]
			public int rarity
			{
				[Token(Token = "0x6009E91")]
				[Address(RVA = "0x318D130", Offset = "0x318BD30", VA = "0x18318D130", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x06009E92 RID: 40594 RVA: 0x0003DE30 File Offset: 0x0003C030
			[Token(Token = "0x170011C0")]
			public int sortId
			{
				[Token(Token = "0x6009E92")]
				[Address(RVA = "0x318D1A0", Offset = "0x318BDA0", VA = "0x18318D1A0", Slot = "19")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x06009E93 RID: 40595 RVA: 0x0003DE48 File Offset: 0x0003C048
			[Token(Token = "0x170011C1")]
			public int quantity
			{
				[Token(Token = "0x6009E93")]
				[Address(RVA = "0x318D0C0", Offset = "0x318BCC0", VA = "0x18318D0C0", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x06009E94 RID: 40596 RVA: 0x0003DE60 File Offset: 0x0003C060
			[Token(Token = "0x170011C2")]
			public int enableRoomType
			{
				[Token(Token = "0x6009E94")]
				[Address(RVA = "0x318CC30", Offset = "0x318B830", VA = "0x18318CC30", Slot = "20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011C3 RID: 4547
			// (get) Token: 0x06009E95 RID: 40597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C3")]
			public string themeId
			{
				[Token(Token = "0x6009E95")]
				[Address(RVA = "0x318D280", Offset = "0x318BE80", VA = "0x18318D280", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011C4 RID: 4548
			// (get) Token: 0x06009E96 RID: 40598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C4")]
			public string groupId
			{
				[Token(Token = "0x6009E96")]
				[Address(RVA = "0x318CD10", Offset = "0x318B910", VA = "0x18318CD10", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011C5 RID: 4549
			// (get) Token: 0x06009E97 RID: 40599 RVA: 0x0003DE78 File Offset: 0x0003C078
			[Token(Token = "0x170011C5")]
			public DIYRoomPart part
			{
				[Token(Token = "0x6009E97")]
				[Address(RVA = "0x318D050", Offset = "0x318BC50", VA = "0x18318D050", Slot = "4")]
				get
				{
					return DIYRoomPart.FLOOR;
				}
			}

			// Token: 0x170011C6 RID: 4550
			// (get) Token: 0x06009E98 RID: 40600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C6")]
			public Mesh mesh
			{
				[Token(Token = "0x6009E98")]
				[Address(RVA = "0x318CFF0", Offset = "0x318BBF0", VA = "0x18318CFF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011C7 RID: 4551
			// (get) Token: 0x06009E99 RID: 40601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C7")]
			public Material material
			{
				[Token(Token = "0x6009E99")]
				[Address(RVA = "0x318CEB0", Offset = "0x318BAB0", VA = "0x18318CEB0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011C8 RID: 4552
			// (get) Token: 0x06009E9A RID: 40602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C8")]
			public Sprite icon
			{
				[Token(Token = "0x6009E9A")]
				[Address(RVA = "0x318CDB0", Offset = "0x318B9B0", VA = "0x18318CDB0", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x06009E9B RID: 40603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011C9")]
			public string desc
			{
				[Token(Token = "0x6009E9B")]
				[Address(RVA = "0x318CB50", Offset = "0x318B750", VA = "0x18318CB50", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x06009E9C RID: 40604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011CA")]
			public string usage
			{
				[Token(Token = "0x6009E9C")]
				[Address(RVA = "0x318D320", Offset = "0x318BF20", VA = "0x18318D320", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x06009E9D RID: 40605 RVA: 0x0003DE90 File Offset: 0x0003C090
			[Token(Token = "0x170011CB")]
			public BuildingData.FurnitureType furniType
			{
				[Token(Token = "0x6009E9D")]
				[Address(RVA = "0x318CCA0", Offset = "0x318B8A0", VA = "0x18318CCA0", Slot = "16")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x06009E9E RID: 40606 RVA: 0x0003DEA8 File Offset: 0x0003C0A8
			[Token(Token = "0x170011CC")]
			public BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x6009E9E")]
				[Address(RVA = "0x318D210", Offset = "0x318BE10", VA = "0x18318D210", Slot = "17")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x04009561 RID: 38241
			[Token(Token = "0x4009561")]
			[FieldOffset(Offset = "0x10")]
			private BuildingData.CustomData.FurnitureData m_buildingFurnitureData;

			// Token: 0x04009562 RID: 38242
			[Token(Token = "0x4009562")]
			[FieldOffset(Offset = "0x18")]
			private IFurnitureGroupData m_groupData;

			// Token: 0x04009563 RID: 38243
			[Token(Token = "0x4009563")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009564 RID: 38244
			[Token(Token = "0x4009564")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x04009565 RID: 38245
			[Token(Token = "0x4009565")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x04009566 RID: 38246
			[Token(Token = "0x4009566")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_comfort;

			// Token: 0x04009567 RID: 38247
			[Token(Token = "0x4009567")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_rarity;

			// Token: 0x04009568 RID: 38248
			[Token(Token = "0x4009568")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x04009569 RID: 38249
			[Token(Token = "0x4009569")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_quantity;

			// Token: 0x0400956A RID: 38250
			[Token(Token = "0x400956A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x0400956B RID: 38251
			[Token(Token = "0x400956B")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_themeId;

			// Token: 0x0400956C RID: 38252
			[Token(Token = "0x400956C")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_groupId;

			// Token: 0x0400956D RID: 38253
			[Token(Token = "0x400956D")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_part;

			// Token: 0x0400956E RID: 38254
			[Token(Token = "0x400956E")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_mesh;

			// Token: 0x0400956F RID: 38255
			[Token(Token = "0x400956F")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_material;

			// Token: 0x04009570 RID: 38256
			[Token(Token = "0x4009570")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x04009571 RID: 38257
			[Token(Token = "0x4009571")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_desc;

			// Token: 0x04009572 RID: 38258
			[Token(Token = "0x4009572")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_usage;

			// Token: 0x04009573 RID: 38259
			[Token(Token = "0x4009573")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_furniType;

			// Token: 0x04009574 RID: 38260
			[Token(Token = "0x4009574")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_subType;
		}
	}
}
