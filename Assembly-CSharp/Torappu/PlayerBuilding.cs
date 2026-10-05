using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public class PlayerBuilding
	{
		// Token: 0x06006740 RID: 26432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006740")]
		[Address(RVA = "0x1EF2550", Offset = "0x1EF1150", VA = "0x181EF2550")]
		public PlayerBuilding()
		{
		}

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingStatus status;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerBuildingChar> chars;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x20")]
		public List<int> assist;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerBuildingRoomSlot> roomSlots;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x30")]
		public PlayerBuildingRoom rooms;

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, PlayerBuildingFurnitureInfo> furniture;

		// Token: 0x04003913 RID: 14611
		[Token(Token = "0x4003913")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, PlayerBuildingDIYPreset> diyPresetSolutions;

		// Token: 0x04003914 RID: 14612
		[Token(Token = "0x4003914")]
		[FieldOffset(Offset = "0x48")]
		public PlayerBuilding.PlayerBuildingSolution solution;

		// Token: 0x04003915 RID: 14613
		[Token(Token = "0x4003915")]
		[FieldOffset(Offset = "0x50")]
		public BuildingMusic music;

		// Token: 0x02000A86 RID: 2694
		[Token(Token = "0x2000A86")]
		public class PlayerBuildingSolution
		{
			// Token: 0x06006741 RID: 26433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006741")]
			[Address(RVA = "0x1EF1FA0", Offset = "0x1EF0BA0", VA = "0x181EF1FA0")]
			public PlayerBuildingSolution()
			{
			}

			// Token: 0x04003916 RID: 14614
			[Token(Token = "0x4003916")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, long> furnitureTs;
		}
	}
}
