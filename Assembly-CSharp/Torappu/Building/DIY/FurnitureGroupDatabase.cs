using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x0200189D RID: 6301
	[Token(Token = "0x200189D")]
	public class FurnitureGroupDatabase : IFurnitureGroupDataProvider, IHotfixable
	{
		// Token: 0x06009F5A RID: 40794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F5A")]
		[Address(RVA = "0x319C390", Offset = "0x319AF90", VA = "0x18319C390")]
		public void SetupGroup()
		{
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F5B")]
		[Address(RVA = "0x319C640", Offset = "0x319B240", VA = "0x18319C640")]
		public void SetupQuickSetup(IFurnitureDataProvider furnitureDB, IDIYRoomModifierDataProvider modifierDB)
		{
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001210")]
		public IEnumerable<IFurnitureGroupData> datas
		{
			[Token(Token = "0x6009F5C")]
			[Address(RVA = "0x319CAC0", Offset = "0x319B6C0", VA = "0x18319CAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F5D")]
		[Address(RVA = "0x319C1F0", Offset = "0x319ADF0", VA = "0x18319C1F0", Slot = "5")]
		public IEnumerable<IFurnitureQuickSetupItem> GetFurnitureQuickSetup(string themeId)
		{
			return null;
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F5E")]
		[Address(RVA = "0x319C2D0", Offset = "0x319AED0", VA = "0x18319C2D0", Slot = "6")]
		public IFurnitureGroupData GetGroupDataByFurniture(string furnitureId)
		{
			return null;
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F5F")]
		[Address(RVA = "0x319C970", Offset = "0x319B570", VA = "0x18319C970")]
		public FurnitureGroupDatabase()
		{
		}

		// Token: 0x04009608 RID: 38408
		[Token(Token = "0x4009608")]
		[FieldOffset(Offset = "0x10")]
		private List<FurnitureGroupDatabase.FurnitureGroupDataAdapter> m_dataList;

		// Token: 0x04009609 RID: 38409
		[Token(Token = "0x4009609")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, IFurnitureGroupData> m_furniIdToGroupData;

		// Token: 0x0400960A RID: 38410
		[Token(Token = "0x400960A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, List<FurnitureGroupDatabase.FurnitureQuickSetupItemAdapter>> m_quickSetup;

		// Token: 0x0400960B RID: 38411
		[Token(Token = "0x400960B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetupGroup;

		// Token: 0x0400960C RID: 38412
		[Token(Token = "0x400960C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetupQuickSetup;

		// Token: 0x0400960D RID: 38413
		[Token(Token = "0x400960D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_datas;

		// Token: 0x0400960E RID: 38414
		[Token(Token = "0x400960E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFurnitureQuickSetup;

		// Token: 0x0400960F RID: 38415
		[Token(Token = "0x400960F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetGroupDataByFurniture;

		// Token: 0x04009610 RID: 38416
		[Token(Token = "0x4009610")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200189E RID: 6302
		[Token(Token = "0x200189E")]
		private class FurnitureGroupDataAdapter : IFurnitureGroupData
		{
			// Token: 0x06009F60 RID: 40800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F60")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public FurnitureGroupDataAdapter(BuildingData.CustomData.GroupData groupData)
			{
			}

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06009F61 RID: 40801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001211")]
			public string id
			{
				[Token(Token = "0x6009F61")]
				[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x06009F62 RID: 40802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001212")]
			public string displayName
			{
				[Token(Token = "0x6009F62")]
				[Address(RVA = "0x111CB60", Offset = "0x111B760", VA = "0x18111CB60", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06009F63 RID: 40803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001213")]
			public string themeId
			{
				[Token(Token = "0x6009F63")]
				[Address(RVA = "0x1CA1D60", Offset = "0x1CA0960", VA = "0x181CA1D60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009F64 RID: 40804 RVA: 0x0003E328 File Offset: 0x0003C528
			[Token(Token = "0x6009F64")]
			[Address(RVA = "0x319C120", Offset = "0x319AD20", VA = "0x18319C120", Slot = "7")]
			public int GetCollectComfort(int count)
			{
				return 0;
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06009F65 RID: 40805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001214")]
			public IEnumerable<string> furnitures
			{
				[Token(Token = "0x6009F65")]
				[Address(RVA = "0x319C150", Offset = "0x319AD50", VA = "0x18319C150", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x04009611 RID: 38417
			[Token(Token = "0x4009611")]
			[FieldOffset(Offset = "0x10")]
			private BuildingData.CustomData.GroupData m_groupData;
		}

		// Token: 0x020018A0 RID: 6304
		[Token(Token = "0x20018A0")]
		private class FurnitureQuickSetupItemAdapter : IFurnitureQuickSetupItem
		{
			// Token: 0x06009F6E RID: 40814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F6E")]
			[Address(RVA = "0x319E380", Offset = "0x319CF80", VA = "0x18319E380")]
			public FurnitureQuickSetupItemAdapter(BuildingData.CustomData.ThemeQuickSetupItem item, IFurnitureDataProvider furnitureDataProvider, IDIYRoomModifierDataProvider modifierDataProvider)
			{
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x06009F6F RID: 40815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001217")]
			public IDIYItem diyItem
			{
				[Token(Token = "0x6009F6F")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x06009F70 RID: 40816 RVA: 0x0003E358 File Offset: 0x0003C558
			[Token(Token = "0x17001218")]
			public int posX
			{
				[Token(Token = "0x6009F70")]
				[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x06009F71 RID: 40817 RVA: 0x0003E370 File Offset: 0x0003C570
			[Token(Token = "0x17001219")]
			public int posY
			{
				[Token(Token = "0x6009F71")]
				[Address(RVA = "0x2704800", Offset = "0x2703400", VA = "0x182704800", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x06009F72 RID: 40818 RVA: 0x0003E388 File Offset: 0x0003C588
			[Token(Token = "0x1700121A")]
			public int dir
			{
				[Token(Token = "0x6009F72")]
				[Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04009618 RID: 38424
			[Token(Token = "0x4009618")]
			[FieldOffset(Offset = "0x10")]
			private BuildingData.CustomData.ThemeQuickSetupItem m_item;

			// Token: 0x04009619 RID: 38425
			[Token(Token = "0x4009619")]
			[FieldOffset(Offset = "0x18")]
			private IDIYItem m_diyItem;
		}
	}
}
