using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001922 RID: 6434
	[Token(Token = "0x2001922")]
	public class MockFurnitureGroupDB : MonoBehaviour, IFurnitureGroupDataProvider, IHotfixable
	{
		// Token: 0x0600A20A RID: 41482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A20A")]
		[Address(RVA = "0x31CFD10", Offset = "0x31CE910", VA = "0x1831CFD10")]
		public void Setup(IFurnitureDataProvider furnitureDB, IDIYRoomModifierDataProvider modifierDB)
		{
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012C8")]
		public IEnumerable<IFurnitureGroupData> datas
		{
			[Token(Token = "0x600A20B")]
			[Address(RVA = "0x31D0020", Offset = "0x31CEC20", VA = "0x1831D0020", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A20C")]
		[Address(RVA = "0x31CF8A0", Offset = "0x31CE4A0", VA = "0x1831CF8A0", Slot = "5")]
		public IEnumerable<IFurnitureQuickSetupItem> GetFurnitureQuickSetup(string themeId)
		{
			return null;
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A20D")]
		[Address(RVA = "0x31CF980", Offset = "0x31CE580", VA = "0x1831CF980", Slot = "6")]
		public IFurnitureGroupData GetGroupDataByFurniture(string furnitureId)
		{
			return null;
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A20E")]
		[Address(RVA = "0x31CFFC0", Offset = "0x31CEBC0", VA = "0x1831CFFC0")]
		public MockFurnitureGroupDB()
		{
		}

		// Token: 0x0400985C RID: 39004
		[Token(Token = "0x400985C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<MockFurnitureGroupDB.Entry> _entries;

		// Token: 0x0400985D RID: 39005
		[Token(Token = "0x400985D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MockFurnitureGroupDB.QuickSetupItem> _quickSetupItem;

		// Token: 0x0400985E RID: 39006
		[Token(Token = "0x400985E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400985F RID: 39007
		[Token(Token = "0x400985F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_datas;

		// Token: 0x04009860 RID: 39008
		[Token(Token = "0x4009860")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFurnitureQuickSetup;

		// Token: 0x04009861 RID: 39009
		[Token(Token = "0x4009861")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGroupDataByFurniture;

		// Token: 0x04009862 RID: 39010
		[Token(Token = "0x4009862")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001923 RID: 6435
		[Token(Token = "0x2001923")]
		[Serializable]
		public class Entry : IFurnitureGroupData
		{
			// Token: 0x170012C9 RID: 4809
			// (get) Token: 0x0600A20F RID: 41487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012C9")]
			public string id
			{
				[Token(Token = "0x600A20F")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012CA RID: 4810
			// (get) Token: 0x0600A210 RID: 41488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012CA")]
			public string displayName
			{
				[Token(Token = "0x600A210")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012CB RID: 4811
			// (get) Token: 0x0600A211 RID: 41489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012CB")]
			public string themeId
			{
				[Token(Token = "0x600A211")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A212 RID: 41490 RVA: 0x0003F288 File Offset: 0x0003D488
			[Token(Token = "0x600A212")]
			[Address(RVA = "0x31CA6E0", Offset = "0x31C92E0", VA = "0x1831CA6E0", Slot = "7")]
			public int GetCollectComfort(int count)
			{
				return 0;
			}

			// Token: 0x170012CC RID: 4812
			// (get) Token: 0x0600A213 RID: 41491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012CC")]
			public IEnumerable<string> furnitures
			{
				[Token(Token = "0x600A213")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A214 RID: 41492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A214")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Entry()
			{
			}

			// Token: 0x04009863 RID: 39011
			[Token(Token = "0x4009863")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x04009864 RID: 39012
			[Token(Token = "0x4009864")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _displayName;

			// Token: 0x04009865 RID: 39013
			[Token(Token = "0x4009865")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string _themeId;

			// Token: 0x04009866 RID: 39014
			[Token(Token = "0x4009866")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<string> _furnitures;

			// Token: 0x04009867 RID: 39015
			[Token(Token = "0x4009867")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private List<MockFurnitureGroupDB.Entry.CollectInfo> _collects;

			// Token: 0x02001924 RID: 6436
			[Token(Token = "0x2001924")]
			[Serializable]
			public class CollectInfo
			{
				// Token: 0x0600A215 RID: 41493 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A215")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CollectInfo()
				{
				}

				// Token: 0x04009868 RID: 39016
				[Token(Token = "0x4009868")]
				[FieldOffset(Offset = "0x10")]
				public int count;

				// Token: 0x04009869 RID: 39017
				[Token(Token = "0x4009869")]
				[FieldOffset(Offset = "0x14")]
				public int comfort;
			}
		}

		// Token: 0x02001925 RID: 6437
		[Token(Token = "0x2001925")]
		[Serializable]
		public class QuickSetupItem : IFurnitureQuickSetupItem
		{
			// Token: 0x0600A216 RID: 41494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A216")]
			[Address(RVA = "0x31D2230", Offset = "0x31D0E30", VA = "0x1831D2230")]
			public void Setup(IFurnitureDataProvider furnitureDB, IDIYRoomModifierDataProvider modifierDB)
			{
			}

			// Token: 0x170012CD RID: 4813
			// (get) Token: 0x0600A217 RID: 41495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012CD")]
			public string themeId
			{
				[Token(Token = "0x600A217")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012CE RID: 4814
			// (get) Token: 0x0600A218 RID: 41496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012CE")]
			public IDIYItem diyItem
			{
				[Token(Token = "0x600A218")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012CF RID: 4815
			// (get) Token: 0x0600A219 RID: 41497 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
			[Token(Token = "0x170012CF")]
			public int posX
			{
				[Token(Token = "0x600A219")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012D0 RID: 4816
			// (get) Token: 0x0600A21A RID: 41498 RVA: 0x0003F2B8 File Offset: 0x0003D4B8
			[Token(Token = "0x170012D0")]
			public int posY
			{
				[Token(Token = "0x600A21A")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012D1 RID: 4817
			// (get) Token: 0x0600A21B RID: 41499 RVA: 0x0003F2D0 File Offset: 0x0003D4D0
			[Token(Token = "0x170012D1")]
			public int dir
			{
				[Token(Token = "0x600A21B")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600A21C RID: 41500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A21C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public QuickSetupItem()
			{
			}

			// Token: 0x0400986A RID: 39018
			[Token(Token = "0x400986A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _themeId;

			// Token: 0x0400986B RID: 39019
			[Token(Token = "0x400986B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _furnitureId;

			// Token: 0x0400986C RID: 39020
			[Token(Token = "0x400986C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private int _posX;

			// Token: 0x0400986D RID: 39021
			[Token(Token = "0x400986D")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private int _posY;

			// Token: 0x0400986E RID: 39022
			[Token(Token = "0x400986E")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private int _dir;

			// Token: 0x0400986F RID: 39023
			[Token(Token = "0x400986F")]
			[FieldOffset(Offset = "0x30")]
			private IDIYItem m_diyItem;
		}
	}
}
