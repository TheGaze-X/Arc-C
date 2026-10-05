using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001918 RID: 6424
	[Token(Token = "0x2001918")]
	public class MockFurnitureDB : MonoBehaviour, IFurnitureDataProvider, IHotfixable
	{
		// Token: 0x0600A1CE RID: 41422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CE")]
		[Address(RVA = "0x31CE880", Offset = "0x31CD480", VA = "0x1831CE880", Slot = "4")]
		public void QueryData(Predicate<IFurnitureData> filter, Action<IFurnitureData> action)
		{
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CF")]
		[Address(RVA = "0x31CE9A0", Offset = "0x31CD5A0", VA = "0x1831CE9A0", Slot = "5")]
		public void QueryDatas(Predicate<IFurnitureData> filter, Action<IFurnitureData> action)
		{
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D0")]
		[Address(RVA = "0x31CE130", Offset = "0x31CCD30", VA = "0x1831CE130", Slot = "6")]
		public IFurnitureData GetData(string furnitureId)
		{
			return null;
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D1")]
		[Address(RVA = "0x31CE6D0", Offset = "0x31CD2D0", VA = "0x1831CE6D0", Slot = "7")]
		public IList<IFurnitureData> GetDatasByType(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D2")]
		[Address(RVA = "0x31CE360", Offset = "0x31CCF60", VA = "0x1831CE360", Slot = "8")]
		public IList<IFurnitureData> GetDatasBySubType(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D3")]
		[Address(RVA = "0x31CE510", Offset = "0x31CD110", VA = "0x1831CE510", Slot = "9")]
		public IList<IFurnitureData> GetDatasByThemeId(string themeId)
		{
			return null;
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D4")]
		[Address(RVA = "0x31CEAD0", Offset = "0x31CD6D0", VA = "0x1831CEAD0")]
		public MockFurnitureDB()
		{
		}

		// Token: 0x04009812 RID: 38930
		[Token(Token = "0x4009812")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MockFurnitureDB.FurnitureData[] _furnitureData;

		// Token: 0x04009813 RID: 38931
		[Token(Token = "0x4009813")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_QueryData;

		// Token: 0x04009814 RID: 38932
		[Token(Token = "0x4009814")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_QueryDatas;

		// Token: 0x04009815 RID: 38933
		[Token(Token = "0x4009815")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x04009816 RID: 38934
		[Token(Token = "0x4009816")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDatasByType;

		// Token: 0x04009817 RID: 38935
		[Token(Token = "0x4009817")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDatasBySubType;

		// Token: 0x04009818 RID: 38936
		[Token(Token = "0x4009818")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDatasByThemeId;

		// Token: 0x04009819 RID: 38937
		[Token(Token = "0x4009819")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001919 RID: 6425
		[Token(Token = "0x2001919")]
		[Serializable]
		public class FurnitureData : IFurnitureData, IDIYItem, IHotfixable
		{
			// Token: 0x170012B1 RID: 4785
			// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012B1")]
			public string id
			{
				[Token(Token = "0x600A1D5")]
				[Address(RVA = "0x31CAD50", Offset = "0x31C9950", VA = "0x1831CAD50", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012B2 RID: 4786
			// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012B2")]
			public string displayName
			{
				[Token(Token = "0x600A1D6")]
				[Address(RVA = "0x31CAA50", Offset = "0x31C9650", VA = "0x1831CAA50", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012B3 RID: 4787
			// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x0003F0A8 File Offset: 0x0003D2A8
			[Token(Token = "0x170012B3")]
			public int dimX
			{
				[Token(Token = "0x600A1D7")]
				[Address(RVA = "0x31CA930", Offset = "0x31C9530", VA = "0x1831CA930", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B4 RID: 4788
			// (get) Token: 0x0600A1D8 RID: 41432 RVA: 0x0003F0C0 File Offset: 0x0003D2C0
			[Token(Token = "0x170012B4")]
			public int dimY
			{
				[Token(Token = "0x600A1D8")]
				[Address(RVA = "0x31CA990", Offset = "0x31C9590", VA = "0x1831CA990", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B5 RID: 4789
			// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x0003F0D8 File Offset: 0x0003D2D8
			[Token(Token = "0x170012B5")]
			public int dimZ
			{
				[Token(Token = "0x600A1D9")]
				[Address(RVA = "0x31CA9F0", Offset = "0x31C95F0", VA = "0x1831CA9F0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B6 RID: 4790
			// (get) Token: 0x0600A1DA RID: 41434 RVA: 0x0003F0F0 File Offset: 0x0003D2F0
			[Token(Token = "0x170012B6")]
			public int comfort
			{
				[Token(Token = "0x600A1DA")]
				[Address(RVA = "0x31CA870", Offset = "0x31C9470", VA = "0x1831CA870", Slot = "17")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B7 RID: 4791
			// (get) Token: 0x0600A1DB RID: 41435 RVA: 0x0003F108 File Offset: 0x0003D308
			[Token(Token = "0x170012B7")]
			public int rarity
			{
				[Token(Token = "0x600A1DB")]
				[Address(RVA = "0x31CAF90", Offset = "0x31C9B90", VA = "0x1831CAF90", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B8 RID: 4792
			// (get) Token: 0x0600A1DC RID: 41436 RVA: 0x0003F120 File Offset: 0x0003D320
			[Token(Token = "0x170012B8")]
			public int sortId
			{
				[Token(Token = "0x600A1DC")]
				[Address(RVA = "0x31CAFF0", Offset = "0x31C9BF0", VA = "0x1831CAFF0", Slot = "27")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012B9 RID: 4793
			// (get) Token: 0x0600A1DD RID: 41437 RVA: 0x0003F138 File Offset: 0x0003D338
			[Token(Token = "0x170012B9")]
			public int quantity
			{
				[Token(Token = "0x600A1DD")]
				[Address(RVA = "0x31CAF30", Offset = "0x31C9B30", VA = "0x1831CAF30", Slot = "26")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012BA RID: 4794
			// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x0003F150 File Offset: 0x0003D350
			[Token(Token = "0x170012BA")]
			public int enableRoomType
			{
				[Token(Token = "0x600A1DE")]
				[Address(RVA = "0x31CAAB0", Offset = "0x31C96B0", VA = "0x1831CAAB0", Slot = "28")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012BB RID: 4795
			// (get) Token: 0x0600A1DF RID: 41439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012BB")]
			public string themeId
			{
				[Token(Token = "0x600A1DF")]
				[Address(RVA = "0x31CB170", Offset = "0x31C9D70", VA = "0x1831CB170", Slot = "19")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012BC RID: 4796
			// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012BC")]
			public string groupId
			{
				[Token(Token = "0x600A1E0")]
				[Address(RVA = "0x31CAC90", Offset = "0x31C9890", VA = "0x1831CAC90", Slot = "20")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012BD RID: 4797
			// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x0003F168 File Offset: 0x0003D368
			[Token(Token = "0x170012BD")]
			public FurnitureLocationType locationType
			{
				[Token(Token = "0x600A1E1")]
				[Address(RVA = "0x31CAE10", Offset = "0x31C9A10", VA = "0x1831CAE10", Slot = "7")]
				get
				{
					return FurnitureLocationType.GROUND;
				}
			}

			// Token: 0x170012BE RID: 4798
			// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x0003F180 File Offset: 0x0003D380
			[Token(Token = "0x170012BE")]
			public FurnitureInteractType interactType
			{
				[Token(Token = "0x600A1E2")]
				[Address(RVA = "0x31CADB0", Offset = "0x31C99B0", VA = "0x1831CADB0", Slot = "8")]
				get
				{
					return FurnitureInteractType.NONE;
				}
			}

			// Token: 0x170012BF RID: 4799
			// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012BF")]
			public string musicId
			{
				[Token(Token = "0x600A1E3")]
				[Address(RVA = "0x31CAE70", Offset = "0x31C9A70", VA = "0x1831CAE70", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012C0 RID: 4800
			// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012C0")]
			public GameObject prefab
			{
				[Token(Token = "0x600A1E4")]
				[Address(RVA = "0x31CAED0", Offset = "0x31C9AD0", VA = "0x1831CAED0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012C1 RID: 4801
			// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x0003F198 File Offset: 0x0003D398
			[Token(Token = "0x170012C1")]
			public bool validOnRotate
			{
				[Token(Token = "0x600A1E5")]
				[Address(RVA = "0x31CB230", Offset = "0x31C9E30", VA = "0x1831CB230", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170012C2 RID: 4802
			// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x0003F1B0 File Offset: 0x0003D3B0
			[Token(Token = "0x170012C2")]
			public bool enableRotate
			{
				[Token(Token = "0x600A1E6")]
				[Address(RVA = "0x31CAB10", Offset = "0x31C9710", VA = "0x1831CAB10", Slot = "13")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170012C3 RID: 4803
			// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012C3")]
			public Sprite icon
			{
				[Token(Token = "0x600A1E7")]
				[Address(RVA = "0x31CACF0", Offset = "0x31C98F0", VA = "0x1831CACF0", Slot = "21")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012C4 RID: 4804
			// (get) Token: 0x0600A1E8 RID: 41448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012C4")]
			public string desc
			{
				[Token(Token = "0x600A1E8")]
				[Address(RVA = "0x31CA8D0", Offset = "0x31C94D0", VA = "0x1831CA8D0", Slot = "22")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012C5 RID: 4805
			// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012C5")]
			public string usage
			{
				[Token(Token = "0x600A1E9")]
				[Address(RVA = "0x31CB1D0", Offset = "0x31C9DD0", VA = "0x1831CB1D0", Slot = "23")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012C6 RID: 4806
			// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x0003F1C8 File Offset: 0x0003D3C8
			[Token(Token = "0x170012C6")]
			public BuildingData.FurnitureType furniType
			{
				[Token(Token = "0x600A1EA")]
				[Address(RVA = "0x31CAB70", Offset = "0x31C9770", VA = "0x1831CAB70", Slot = "24")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x170012C7 RID: 4807
			// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x0003F1E0 File Offset: 0x0003D3E0
			[Token(Token = "0x170012C7")]
			public BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x600A1EB")]
				[Address(RVA = "0x31CB050", Offset = "0x31C9C50", VA = "0x1831CB050", Slot = "25")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x0600A1EC RID: 41452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1EC")]
			[Address(RVA = "0x31CA7E0", Offset = "0x31C93E0", VA = "0x1831CA7E0")]
			public FurnitureData()
			{
			}

			// Token: 0x0400981A RID: 38938
			[Token(Token = "0x400981A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x0400981B RID: 38939
			[Token(Token = "0x400981B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _displayName;

			// Token: 0x0400981C RID: 38940
			[Token(Token = "0x400981C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _validOnRotate;

			// Token: 0x0400981D RID: 38941
			[Token(Token = "0x400981D")]
			[FieldOffset(Offset = "0x21")]
			[SerializeField]
			private bool _enableRotate;

			// Token: 0x0400981E RID: 38942
			[Token(Token = "0x400981E")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private int _dimX;

			// Token: 0x0400981F RID: 38943
			[Token(Token = "0x400981F")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private int _dimY;

			// Token: 0x04009820 RID: 38944
			[Token(Token = "0x4009820")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private int _dimZ;

			// Token: 0x04009821 RID: 38945
			[Token(Token = "0x4009821")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private int _comfort;

			// Token: 0x04009822 RID: 38946
			[Token(Token = "0x4009822")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private int _rarity;

			// Token: 0x04009823 RID: 38947
			[Token(Token = "0x4009823")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private string _themeId;

			// Token: 0x04009824 RID: 38948
			[Token(Token = "0x4009824")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private string _groupId;

			// Token: 0x04009825 RID: 38949
			[Token(Token = "0x4009825")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private FurnitureLocationType _locationType;

			// Token: 0x04009826 RID: 38950
			[Token(Token = "0x4009826")]
			[FieldOffset(Offset = "0x4C")]
			[SerializeField]
			private FurnitureInteractType _interactType;

			// Token: 0x04009827 RID: 38951
			[Token(Token = "0x4009827")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private string _musicId;

			// Token: 0x04009828 RID: 38952
			[Token(Token = "0x4009828")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public GameObject _prefab;

			// Token: 0x04009829 RID: 38953
			[Token(Token = "0x4009829")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private Sprite _icon;

			// Token: 0x0400982A RID: 38954
			[Token(Token = "0x400982A")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private string _desc;

			// Token: 0x0400982B RID: 38955
			[Token(Token = "0x400982B")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private string _usage;

			// Token: 0x0400982C RID: 38956
			[Token(Token = "0x400982C")]
			[FieldOffset(Offset = "0x78")]
			[SerializeField]
			private string _furnitureType;

			// Token: 0x0400982D RID: 38957
			[Token(Token = "0x400982D")]
			[FieldOffset(Offset = "0x80")]
			[SerializeField]
			private string _furnitureSubType;

			// Token: 0x0400982E RID: 38958
			[Token(Token = "0x400982E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x0400982F RID: 38959
			[Token(Token = "0x400982F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x04009830 RID: 38960
			[Token(Token = "0x4009830")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_dimX;

			// Token: 0x04009831 RID: 38961
			[Token(Token = "0x4009831")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_dimY;

			// Token: 0x04009832 RID: 38962
			[Token(Token = "0x4009832")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_dimZ;

			// Token: 0x04009833 RID: 38963
			[Token(Token = "0x4009833")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_comfort;

			// Token: 0x04009834 RID: 38964
			[Token(Token = "0x4009834")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_rarity;

			// Token: 0x04009835 RID: 38965
			[Token(Token = "0x4009835")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x04009836 RID: 38966
			[Token(Token = "0x4009836")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_quantity;

			// Token: 0x04009837 RID: 38967
			[Token(Token = "0x4009837")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x04009838 RID: 38968
			[Token(Token = "0x4009838")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_themeId;

			// Token: 0x04009839 RID: 38969
			[Token(Token = "0x4009839")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_groupId;

			// Token: 0x0400983A RID: 38970
			[Token(Token = "0x400983A")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_locationType;

			// Token: 0x0400983B RID: 38971
			[Token(Token = "0x400983B")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_interactType;

			// Token: 0x0400983C RID: 38972
			[Token(Token = "0x400983C")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_musicId;

			// Token: 0x0400983D RID: 38973
			[Token(Token = "0x400983D")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_prefab;

			// Token: 0x0400983E RID: 38974
			[Token(Token = "0x400983E")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_validOnRotate;

			// Token: 0x0400983F RID: 38975
			[Token(Token = "0x400983F")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_enableRotate;

			// Token: 0x04009840 RID: 38976
			[Token(Token = "0x4009840")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x04009841 RID: 38977
			[Token(Token = "0x4009841")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_desc;

			// Token: 0x04009842 RID: 38978
			[Token(Token = "0x4009842")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_usage;

			// Token: 0x04009843 RID: 38979
			[Token(Token = "0x4009843")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_furniType;

			// Token: 0x04009844 RID: 38980
			[Token(Token = "0x4009844")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_subType;

			// Token: 0x04009845 RID: 38981
			[Token(Token = "0x4009845")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
