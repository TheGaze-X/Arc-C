using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017FE RID: 6142
	[Token(Token = "0x20017FE")]
	public struct BuildingPrivateOwnerModel : IHotfixable
	{
		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06009B64 RID: 39780 RVA: 0x0003C798 File Offset: 0x0003A998
		[Token(Token = "0x17001105")]
		public bool isValid
		{
			[Token(Token = "0x6009B64")]
			[Address(RVA = "0x315DFB0", Offset = "0x315CBB0", VA = "0x18315DFB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
		[Token(Token = "0x17001106")]
		public int instId
		{
			[Token(Token = "0x6009B65")]
			[Address(RVA = "0x315DEE0", Offset = "0x315CAE0", VA = "0x18315DEE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B66")]
		[Address(RVA = "0x315D300", Offset = "0x315BF00", VA = "0x18315D300")]
		public static List<BuildingPrivateOwnerModel> LoadPrivateOwners(ListDict<int, string> ownerInfos, Dictionary<string, PlayerBuildingChar> playerChars, Dictionary<string, RoomSlotModel> roomSlots)
		{
			return null;
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
		[Token(Token = "0x6009B67")]
		[Address(RVA = "0x315D620", Offset = "0x315C220", VA = "0x18315D620")]
		private static BuildingPrivateOwnerModel _LoadSingleOwner(KeyValuePair<int, string> ownerInfo, Dictionary<string, PlayerBuildingChar> playerChars, Dictionary<string, RoomSlotModel> roomSlots)
		{
			return default(BuildingPrivateOwnerModel);
		}

		// Token: 0x040091E4 RID: 37348
		[Token(Token = "0x40091E4")]
		[FieldOffset(Offset = "0x0")]
		private static List<BuildingPrivateOwnerModel> ownerModels;

		// Token: 0x040091E5 RID: 37349
		[Token(Token = "0x40091E5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BuildingPrivateOwnerModel EMPTY;

		// Token: 0x040091E6 RID: 37350
		[Token(Token = "0x40091E6")]
		[FieldOffset(Offset = "0x0")]
		public string originSlotId;

		// Token: 0x040091E7 RID: 37351
		[Token(Token = "0x40091E7")]
		[FieldOffset(Offset = "0x8")]
		public BuildingCharModel charModel;

		// Token: 0x040091E8 RID: 37352
		[Token(Token = "0x40091E8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x040091E9 RID: 37353
		[Token(Token = "0x40091E9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x040091EA RID: 37354
		[Token(Token = "0x40091EA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadPrivateOwners;

		// Token: 0x040091EB RID: 37355
		[Token(Token = "0x40091EB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadSingleOwner;
	}
}
