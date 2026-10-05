using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public class PlayerBuildingRoom
	{
		// Token: 0x0600673D RID: 26429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600673D")]
		[Address(RVA = "0x1EF1B80", Offset = "0x1EF0780", VA = "0x181EF1B80")]
		public PlayerBuildingRoom()
		{
		}

		// Token: 0x040038FD RID: 14589
		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("MANUFACTURE")]
		public ListDict<string, PlayerBuildingManufacture> manufact;

		// Token: 0x040038FE RID: 14590
		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("SHOP")]
		public ListDict<string, PlayerBuildingShop> shop;

		// Token: 0x040038FF RID: 14591
		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("POWER")]
		public ListDict<string, PlayerBuildingPower> power;

		// Token: 0x04003900 RID: 14592
		[Token(Token = "0x4003900")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("CONTROL")]
		public ListDict<string, PlayerBuildingControl> control;

		// Token: 0x04003901 RID: 14593
		[Token(Token = "0x4003901")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("MEETING")]
		public ListDict<string, PlayerBuildingMeeting> meeting;

		// Token: 0x04003902 RID: 14594
		[Token(Token = "0x4003902")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("HIRE")]
		public ListDict<string, PlayerBuildingHire> hire;

		// Token: 0x04003903 RID: 14595
		[Token(Token = "0x4003903")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("DORMITORY")]
		public ListDict<string, PlayerBuildingDormitory> dorm;

		// Token: 0x04003904 RID: 14596
		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("PRIVATE")]
		public ListDict<string, PlayerBuildingPrivate> privateDorm;

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("TRAINING")]
		public ListDict<string, PlayerBuildingTraining> training;

		// Token: 0x04003906 RID: 14598
		[Token(Token = "0x4003906")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("WORKSHOP")]
		public ListDict<string, PlayerBuildingWorkshop> workshop;

		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("TRADING")]
		public ListDict<string, PlayerBuildingTrading> trading;
	}
}
