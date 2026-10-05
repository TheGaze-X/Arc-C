using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001BA6 RID: 7078
	[Token(Token = "0x2001BA6")]
	public abstract class LevelConditionCheckItem
	{
		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600B08A RID: 45194
		[Token(Token = "0x170014E6")]
		public abstract int level { [Token(Token = "0x600B08A")] get; }

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600B08B RID: 45195
		[Token(Token = "0x170014E7")]
		public abstract BuildingData.RoomType roomType { [Token(Token = "0x600B08B")] get; }

		// Token: 0x0600B08C RID: 45196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B08C")]
		[Address(RVA = "0x32AC270", Offset = "0x32AAE70", VA = "0x1832AC270")]
		public static LevelConditionCheckItem Create(RoomSlotModel room)
		{
			return null;
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B08D")]
		[Address(RVA = "0x32AC200", Offset = "0x32AAE00", VA = "0x1832AC200")]
		public static LevelConditionCheckItem Create(int level, BuildingData.RoomType type)
		{
			return null;
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B08E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected LevelConditionCheckItem()
		{
		}

		// Token: 0x02001BA7 RID: 7079
		[Token(Token = "0x2001BA7")]
		private class LevelConditionCheckItemRoom : LevelConditionCheckItem
		{
			// Token: 0x170014E8 RID: 5352
			// (get) Token: 0x0600B08F RID: 45199 RVA: 0x00043728 File Offset: 0x00041928
			[Token(Token = "0x170014E8")]
			public override int level
			{
				[Token(Token = "0x600B08F")]
				[Address(RVA = "0x32AC180", Offset = "0x32AAD80", VA = "0x1832AC180", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170014E9 RID: 5353
			// (get) Token: 0x0600B090 RID: 45200 RVA: 0x00043740 File Offset: 0x00041940
			[Token(Token = "0x170014E9")]
			public override BuildingData.RoomType roomType
			{
				[Token(Token = "0x600B090")]
				[Address(RVA = "0x32AC1E0", Offset = "0x32AADE0", VA = "0x1832AC1E0", Slot = "5")]
				get
				{
					return BuildingData.RoomType.NONE;
				}
			}

			// Token: 0x0600B091 RID: 45201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B091")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelConditionCheckItemRoom()
			{
			}

			// Token: 0x0400AB05 RID: 43781
			[Token(Token = "0x400AB05")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;
		}

		// Token: 0x02001BA8 RID: 7080
		[Token(Token = "0x2001BA8")]
		private class LevelConditionCheckItemFake : LevelConditionCheckItem
		{
			// Token: 0x170014EA RID: 5354
			// (get) Token: 0x0600B092 RID: 45202 RVA: 0x00043758 File Offset: 0x00041958
			[Token(Token = "0x170014EA")]
			public override int level
			{
				[Token(Token = "0x600B092")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170014EB RID: 5355
			// (get) Token: 0x0600B093 RID: 45203 RVA: 0x00043770 File Offset: 0x00041970
			[Token(Token = "0x170014EB")]
			public override BuildingData.RoomType roomType
			{
				[Token(Token = "0x600B093")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "5")]
				get
				{
					return BuildingData.RoomType.NONE;
				}
			}

			// Token: 0x0600B094 RID: 45204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B094")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelConditionCheckItemFake()
			{
			}

			// Token: 0x0400AB06 RID: 43782
			[Token(Token = "0x400AB06")]
			[FieldOffset(Offset = "0x10")]
			public int fakeLevel;

			// Token: 0x0400AB07 RID: 43783
			[Token(Token = "0x400AB07")]
			[FieldOffset(Offset = "0x14")]
			public BuildingData.RoomType fakeRoomType;
		}
	}
}
