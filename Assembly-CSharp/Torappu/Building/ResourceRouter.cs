using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017E4 RID: 6116
	[Token(Token = "0x20017E4")]
	public static class ResourceRouter
	{
		// Token: 0x020017E5 RID: 6117
		[Token(Token = "0x20017E5")]
		public static class Vault
		{
			// Token: 0x06009A9F RID: 39583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009A9F")]
			[Address(RVA = "0x316A1E0", Offset = "0x3168DE0", VA = "0x18316A1E0")]
			public static string GetRoomPath(string roomId)
			{
				return null;
			}

			// Token: 0x06009AA0 RID: 39584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009AA0")]
			[Address(RVA = "0x316A160", Offset = "0x3168D60", VA = "0x18316A160")]
			public static string GetCharacterPath(string characterId)
			{
				return null;
			}

			// Token: 0x06009AA1 RID: 39585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009AA1")]
			[Address(RVA = "0x316A1A0", Offset = "0x3168DA0", VA = "0x18316A1A0")]
			public static string GetDoorPath(string doorId)
			{
				return null;
			}

			// Token: 0x040090E8 RID: 37096
			[Token(Token = "0x40090E8")]
			private const string ROOM_PATH_FORMAT = "building/vault/[uc]rooms/{0}";

			// Token: 0x040090E9 RID: 37097
			[Token(Token = "0x40090E9")]
			private const string DOOR_PATH_FORMAT = "building/vault/[uc]doors/{0}";

			// Token: 0x040090EA RID: 37098
			[Token(Token = "0x40090EA")]
			private const string CHARACTER_PATH_FORMAT = "building/vault/characters/build_{0}";
		}

		// Token: 0x020017E6 RID: 6118
		[Token(Token = "0x20017E6")]
		public static class Blueprint
		{
			// Token: 0x06009AA2 RID: 39586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009AA2")]
			[Address(RVA = "0x314EC60", Offset = "0x314D860", VA = "0x18314EC60")]
			public static string GetRoomSlotPath()
			{
				return null;
			}

			// Token: 0x06009AA3 RID: 39587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009AA3")]
			[Address(RVA = "0x314EC20", Offset = "0x314D820", VA = "0x18314EC20")]
			public static string GetRoomPath(string roomId)
			{
				return null;
			}

			// Token: 0x06009AA4 RID: 39588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009AA4")]
			[Address(RVA = "0x314EBC0", Offset = "0x314D7C0", VA = "0x18314EBC0")]
			public static string GetRoomHilightContainerPath()
			{
				return null;
			}

			// Token: 0x040090EB RID: 37099
			[Token(Token = "0x40090EB")]
			private const string ROOM_SLOT_NAME = "room_slot";

			// Token: 0x040090EC RID: 37100
			[Token(Token = "0x40090EC")]
			private const string ROOM_FOLDER = "building/blueprint/[uc]rooms/{0}";

			// Token: 0x040090ED RID: 37101
			[Token(Token = "0x40090ED")]
			private const string HILIGHT_CONTAINER_NAME = "room_slot_hilight";
		}
	}
}
