using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001908 RID: 6408
	[Token(Token = "0x2001908")]
	public class MockDIYRoomModifierDB : MonoBehaviour, IDIYRoomModifierDataProvider, IHotfixable
	{
		// Token: 0x0600A16A RID: 41322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A16A")]
		[Address(RVA = "0x31CCBF0", Offset = "0x31CB7F0", VA = "0x1831CCBF0", Slot = "4")]
		public void QueryData(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action)
		{
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A16B")]
		[Address(RVA = "0x31CCD10", Offset = "0x31CB910", VA = "0x1831CCD10", Slot = "5")]
		public void QueryDatas(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action)
		{
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16C")]
		[Address(RVA = "0x31CC2F0", Offset = "0x31CAEF0", VA = "0x1831CC2F0", Slot = "6")]
		public IDIYRoomModifierData GetData(string furnitureId)
		{
			return null;
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16D")]
		[Address(RVA = "0x31CCA40", Offset = "0x31CB640", VA = "0x1831CCA40", Slot = "7")]
		public IList<IDIYRoomModifierData> GetDatasByType(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16E")]
		[Address(RVA = "0x31CC6D0", Offset = "0x31CB2D0", VA = "0x1831CC6D0", Slot = "8")]
		public IList<IDIYRoomModifierData> GetDatasBySubType(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16F")]
		[Address(RVA = "0x31CC880", Offset = "0x31CB480", VA = "0x1831CC880", Slot = "9")]
		public IList<IDIYRoomModifierData> GetDatasByThemeId(string themeId)
		{
			return null;
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A170")]
		[Address(RVA = "0x31CC520", Offset = "0x31CB120", VA = "0x1831CC520", Slot = "10")]
		public IList<IDIYRoomModifierData> GetDatasByRoomPart(DIYRoomPart part)
		{
			return null;
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A171")]
		[Address(RVA = "0x31CCE40", Offset = "0x31CBA40", VA = "0x1831CCE40")]
		public MockDIYRoomModifierDB()
		{
		}

		// Token: 0x040097AE RID: 38830
		[Token(Token = "0x40097AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockDIYRoomModifierDB.DIYRoomModifierData[] _DIYRoomModifierData;

		// Token: 0x040097AF RID: 38831
		[Token(Token = "0x40097AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_QueryData;

		// Token: 0x040097B0 RID: 38832
		[Token(Token = "0x40097B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_QueryDatas;

		// Token: 0x040097B1 RID: 38833
		[Token(Token = "0x40097B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x040097B2 RID: 38834
		[Token(Token = "0x40097B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDatasByType;

		// Token: 0x040097B3 RID: 38835
		[Token(Token = "0x40097B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDatasBySubType;

		// Token: 0x040097B4 RID: 38836
		[Token(Token = "0x40097B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDatasByThemeId;

		// Token: 0x040097B5 RID: 38837
		[Token(Token = "0x40097B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDatasByRoomPart;

		// Token: 0x040097B6 RID: 38838
		[Token(Token = "0x40097B6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001909 RID: 6409
		[Token(Token = "0x2001909")]
		[Serializable]
		public class DIYRoomModifierData : IDIYRoomModifierData, IDIYItem, IHotfixable
		{
			// Token: 0x1700128C RID: 4748
			// (get) Token: 0x0600A172 RID: 41330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700128C")]
			public string id
			{
				[Token(Token = "0x600A172")]
				[Address(RVA = "0x31BF410", Offset = "0x31BE010", VA = "0x1831BF410", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700128D RID: 4749
			// (get) Token: 0x0600A173 RID: 41331 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700128D")]
			public string displayName
			{
				[Token(Token = "0x600A173")]
				[Address(RVA = "0x31BF170", Offset = "0x31BDD70", VA = "0x1831BF170", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700128E RID: 4750
			// (get) Token: 0x0600A174 RID: 41332 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
			[Token(Token = "0x1700128E")]
			public int comfort
			{
				[Token(Token = "0x600A174")]
				[Address(RVA = "0x31BF0B0", Offset = "0x31BDCB0", VA = "0x1831BF0B0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700128F RID: 4751
			// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0003EDD8 File Offset: 0x0003CFD8
			[Token(Token = "0x1700128F")]
			public int rarity
			{
				[Token(Token = "0x600A175")]
				[Address(RVA = "0x31BF5F0", Offset = "0x31BE1F0", VA = "0x1831BF5F0", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001290 RID: 4752
			// (get) Token: 0x0600A176 RID: 41334 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
			[Token(Token = "0x17001290")]
			public int sortId
			{
				[Token(Token = "0x600A176")]
				[Address(RVA = "0x31BF650", Offset = "0x31BE250", VA = "0x1831BF650", Slot = "19")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001291 RID: 4753
			// (get) Token: 0x0600A177 RID: 41335 RVA: 0x0003EE08 File Offset: 0x0003D008
			[Token(Token = "0x17001291")]
			public int quantity
			{
				[Token(Token = "0x600A177")]
				[Address(RVA = "0x31BF590", Offset = "0x31BE190", VA = "0x1831BF590", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001292 RID: 4754
			// (get) Token: 0x0600A178 RID: 41336 RVA: 0x0003EE20 File Offset: 0x0003D020
			[Token(Token = "0x17001292")]
			public int enableRoomType
			{
				[Token(Token = "0x600A178")]
				[Address(RVA = "0x31BF1D0", Offset = "0x31BDDD0", VA = "0x1831BF1D0", Slot = "20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001293 RID: 4755
			// (get) Token: 0x0600A179 RID: 41337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001293")]
			public string themeId
			{
				[Token(Token = "0x600A179")]
				[Address(RVA = "0x31BF7D0", Offset = "0x31BE3D0", VA = "0x1831BF7D0", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x0600A17A RID: 41338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001294")]
			public string groupId
			{
				[Token(Token = "0x600A17A")]
				[Address(RVA = "0x31BF350", Offset = "0x31BDF50", VA = "0x1831BF350", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x0600A17B RID: 41339 RVA: 0x0003EE38 File Offset: 0x0003D038
			[Token(Token = "0x17001295")]
			public DIYRoomPart part
			{
				[Token(Token = "0x600A17B")]
				[Address(RVA = "0x31BF530", Offset = "0x31BE130", VA = "0x1831BF530", Slot = "4")]
				get
				{
					return DIYRoomPart.FLOOR;
				}
			}

			// Token: 0x17001296 RID: 4758
			// (get) Token: 0x0600A17C RID: 41340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001296")]
			public Mesh mesh
			{
				[Token(Token = "0x600A17C")]
				[Address(RVA = "0x31BF4D0", Offset = "0x31BE0D0", VA = "0x1831BF4D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001297 RID: 4759
			// (get) Token: 0x0600A17D RID: 41341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001297")]
			public Material material
			{
				[Token(Token = "0x600A17D")]
				[Address(RVA = "0x31BF470", Offset = "0x31BE070", VA = "0x1831BF470", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001298 RID: 4760
			// (get) Token: 0x0600A17E RID: 41342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001298")]
			public Sprite icon
			{
				[Token(Token = "0x600A17E")]
				[Address(RVA = "0x31BF3B0", Offset = "0x31BDFB0", VA = "0x1831BF3B0", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001299 RID: 4761
			// (get) Token: 0x0600A17F RID: 41343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001299")]
			public string desc
			{
				[Token(Token = "0x600A17F")]
				[Address(RVA = "0x31BF110", Offset = "0x31BDD10", VA = "0x1831BF110", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700129A RID: 4762
			// (get) Token: 0x0600A180 RID: 41344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700129A")]
			public string usage
			{
				[Token(Token = "0x600A180")]
				[Address(RVA = "0x31BF830", Offset = "0x31BE430", VA = "0x1831BF830", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700129B RID: 4763
			// (get) Token: 0x0600A181 RID: 41345 RVA: 0x0003EE50 File Offset: 0x0003D050
			[Token(Token = "0x1700129B")]
			public BuildingData.FurnitureType furniType
			{
				[Token(Token = "0x600A181")]
				[Address(RVA = "0x31BF230", Offset = "0x31BDE30", VA = "0x1831BF230", Slot = "16")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x1700129C RID: 4764
			// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0003EE68 File Offset: 0x0003D068
			[Token(Token = "0x1700129C")]
			public BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x600A182")]
				[Address(RVA = "0x31BF6B0", Offset = "0x31BE2B0", VA = "0x1831BF6B0", Slot = "17")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x0600A183 RID: 41347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A183")]
			[Address(RVA = "0x31BF050", Offset = "0x31BDC50", VA = "0x1831BF050")]
			public DIYRoomModifierData()
			{
			}

			// Token: 0x040097B7 RID: 38839
			[Token(Token = "0x40097B7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x040097B8 RID: 38840
			[Token(Token = "0x40097B8")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _displayName;

			// Token: 0x040097B9 RID: 38841
			[Token(Token = "0x40097B9")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private int _comfort;

			// Token: 0x040097BA RID: 38842
			[Token(Token = "0x40097BA")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private int _rarity;

			// Token: 0x040097BB RID: 38843
			[Token(Token = "0x40097BB")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private string _themeId;

			// Token: 0x040097BC RID: 38844
			[Token(Token = "0x40097BC")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private string _groupId;

			// Token: 0x040097BD RID: 38845
			[Token(Token = "0x40097BD")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private DIYRoomPart _part;

			// Token: 0x040097BE RID: 38846
			[Token(Token = "0x40097BE")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Mesh _mesh;

			// Token: 0x040097BF RID: 38847
			[Token(Token = "0x40097BF")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Material _material;

			// Token: 0x040097C0 RID: 38848
			[Token(Token = "0x40097C0")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private Sprite _icon;

			// Token: 0x040097C1 RID: 38849
			[Token(Token = "0x40097C1")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private string _desc;

			// Token: 0x040097C2 RID: 38850
			[Token(Token = "0x40097C2")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private string _usage;

			// Token: 0x040097C3 RID: 38851
			[Token(Token = "0x40097C3")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private string _furnitureType;

			// Token: 0x040097C4 RID: 38852
			[Token(Token = "0x40097C4")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private string _furnitureSubType;

			// Token: 0x040097C5 RID: 38853
			[Token(Token = "0x40097C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x040097C6 RID: 38854
			[Token(Token = "0x40097C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x040097C7 RID: 38855
			[Token(Token = "0x40097C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_comfort;

			// Token: 0x040097C8 RID: 38856
			[Token(Token = "0x40097C8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_rarity;

			// Token: 0x040097C9 RID: 38857
			[Token(Token = "0x40097C9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x040097CA RID: 38858
			[Token(Token = "0x40097CA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_quantity;

			// Token: 0x040097CB RID: 38859
			[Token(Token = "0x40097CB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x040097CC RID: 38860
			[Token(Token = "0x40097CC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_themeId;

			// Token: 0x040097CD RID: 38861
			[Token(Token = "0x40097CD")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_groupId;

			// Token: 0x040097CE RID: 38862
			[Token(Token = "0x40097CE")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_part;

			// Token: 0x040097CF RID: 38863
			[Token(Token = "0x40097CF")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_mesh;

			// Token: 0x040097D0 RID: 38864
			[Token(Token = "0x40097D0")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_material;

			// Token: 0x040097D1 RID: 38865
			[Token(Token = "0x40097D1")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x040097D2 RID: 38866
			[Token(Token = "0x40097D2")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_desc;

			// Token: 0x040097D3 RID: 38867
			[Token(Token = "0x40097D3")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_usage;

			// Token: 0x040097D4 RID: 38868
			[Token(Token = "0x40097D4")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_furniType;

			// Token: 0x040097D5 RID: 38869
			[Token(Token = "0x40097D5")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_subType;

			// Token: 0x040097D6 RID: 38870
			[Token(Token = "0x40097D6")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
