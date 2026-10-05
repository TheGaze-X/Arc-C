using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAC RID: 7340
	[Token(Token = "0x2001CAC")]
	public struct StationRoomStructModel
	{
		// Token: 0x0600B5EE RID: 46574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EE")]
		[Address(RVA = "0x331AC20", Offset = "0x3319820", VA = "0x18331AC20")]
		public StationRoomStructModel(ManageMode mode, BuildingModel buildingModel, RoomSlotModel slotData, [Optional] IntHashSet inPreQueueChars, [Optional] int[] dormLockEditList)
		{
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600B5EF RID: 46575 RVA: 0x00044E08 File Offset: 0x00043008
		[Token(Token = "0x170015D9")]
		public bool isEmpty
		{
			[Token(Token = "0x600B5EF")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B295 RID: 45717
		[Token(Token = "0x400B295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly StationRoomStructModel EMPTY;

		// Token: 0x0400B296 RID: 45718
		[Token(Token = "0x400B296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x0400B297 RID: 45719
		[Token(Token = "0x400B297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BuildingData.RoomType roomId;

		// Token: 0x0400B298 RID: 45720
		[Token(Token = "0x400B298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400B299 RID: 45721
		[Token(Token = "0x400B299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string roomIndex;

		// Token: 0x0400B29A RID: 45722
		[Token(Token = "0x400B29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x0400B29B RID: 45723
		[Token(Token = "0x400B29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int stationedCharNum;

		// Token: 0x0400B29C RID: 45724
		[Token(Token = "0x400B29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int maxStationedCharNum;

		// Token: 0x0400B29D RID: 45725
		[Token(Token = "0x400B29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int finalMaxCharNum;

		// Token: 0x0400B29E RID: 45726
		[Token(Token = "0x400B29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isUpgrading;

		// Token: 0x0400B29F RID: 45727
		[Token(Token = "0x400B29F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string targetName;

		// Token: 0x0400B2A0 RID: 45728
		[Token(Token = "0x400B2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ShallowEqualArray<StationCharStructModel> chars;

		// Token: 0x0400B2A1 RID: 45729
		[Token(Token = "0x400B2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool canPresetQueue;

		// Token: 0x0400B2A2 RID: 45730
		[Token(Token = "0x400B2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool hasPresetQueue;

		// Token: 0x0400B2A3 RID: 45731
		[Token(Token = "0x400B2A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool hasAvailableQueue;

		// Token: 0x0400B2A4 RID: 45732
		[Token(Token = "0x400B2A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int stationedCharTiredNum;

		// Token: 0x0400B2A5 RID: 45733
		[Token(Token = "0x400B2A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int firstAvailableQueueIdx;

		// Token: 0x0400B2A6 RID: 45734
		[Token(Token = "0x400B2A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool stopWork;
	}
}
