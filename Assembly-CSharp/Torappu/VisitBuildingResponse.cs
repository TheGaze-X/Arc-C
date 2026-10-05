using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	public class VisitBuildingResponse : PlayerDeltaResponse
	{
		// Token: 0x06006580 RID: 25984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006580")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public VisitBuildingResponse()
		{
		}

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x28")]
		public VisitBuildingResponse.Snapshot snapshot;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x30")]
		public List<VisitBuildingResponse.VisitorInfo> visitorList;

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle[] rewards;

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x40")]
		public int notice;

		// Token: 0x020008CF RID: 2255
		[Token(Token = "0x20008CF")]
		public class Snapshot
		{
			// Token: 0x06006581 RID: 25985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006581")]
			[Address(RVA = "0x1F01B30", Offset = "0x1F00730", VA = "0x181F01B30")]
			public Snapshot()
			{
			}

			// Token: 0x040032C8 RID: 13000
			[Token(Token = "0x40032C8")]
			[FieldOffset(Offset = "0x10")]
			public VisitBuildingResponse.RoomOwner owner;

			// Token: 0x040032C9 RID: 13001
			[Token(Token = "0x40032C9")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerBuildingChar> chars;

			// Token: 0x040032CA RID: 13002
			[Token(Token = "0x40032CA")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerBuildingRoomSlot> roomSlots;

			// Token: 0x040032CB RID: 13003
			[Token(Token = "0x40032CB")]
			[FieldOffset(Offset = "0x28")]
			public PlayerBuildingRoom rooms;

			// Token: 0x040032CC RID: 13004
			[Token(Token = "0x40032CC")]
			[FieldOffset(Offset = "0x30")]
			public VisitBuildingResponse.BuildingSnapshotMusic music;
		}

		// Token: 0x020008D0 RID: 2256
		[Token(Token = "0x20008D0")]
		public class RoomOwner : IPlayerStatus, IHotfixable
		{
			// Token: 0x06006582 RID: 25986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006582")]
			[Address(RVA = "0x1F01070", Offset = "0x1EFFC70", VA = "0x181F01070", Slot = "4")]
			public AvatarInfo GetAvatarInfo()
			{
				return null;
			}

			// Token: 0x06006583 RID: 25987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006583")]
			[Address(RVA = "0x1F010D0", Offset = "0x1EFFCD0", VA = "0x181F010D0", Slot = "5")]
			public string GetSecretarySkinId()
			{
				return null;
			}

			// Token: 0x06006584 RID: 25988 RVA: 0x00030738 File Offset: 0x0002E938
			[Token(Token = "0x6006584")]
			[Address(RVA = "0x1F01130", Offset = "0x1EFFD30", VA = "0x181F01130", Slot = "6")]
			public bool GetSecretarySkinSp()
			{
				return default(bool);
			}

			// Token: 0x06006585 RID: 25989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006585")]
			[Address(RVA = "0x1F01190", Offset = "0x1EFFD90", VA = "0x181F01190")]
			public RoomOwner()
			{
			}

			// Token: 0x040032CD RID: 13005
			[Token(Token = "0x40032CD")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x040032CE RID: 13006
			[Token(Token = "0x40032CE")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x040032CF RID: 13007
			[Token(Token = "0x40032CF")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x040032D0 RID: 13008
			[Token(Token = "0x40032D0")]
			[FieldOffset(Offset = "0x28")]
			public int level;

			// Token: 0x040032D1 RID: 13009
			[Token(Token = "0x40032D1")]
			[FieldOffset(Offset = "0x30")]
			public AvatarInfo avatar;

			// Token: 0x040032D2 RID: 13010
			[Token(Token = "0x40032D2")]
			[FieldOffset(Offset = "0x38")]
			public string secretarySkinId;

			// Token: 0x040032D3 RID: 13011
			[Token(Token = "0x40032D3")]
			[FieldOffset(Offset = "0x40")]
			public string secretary;

			// Token: 0x040032D4 RID: 13012
			[Token(Token = "0x40032D4")]
			[FieldOffset(Offset = "0x48")]
			public bool secretarySkinSp;

			// Token: 0x040032D5 RID: 13013
			[Token(Token = "0x40032D5")]
			[FieldOffset(Offset = "0x50")]
			public string nameCardSkinId;

			// Token: 0x040032D6 RID: 13014
			[Token(Token = "0x40032D6")]
			[FieldOffset(Offset = "0x58")]
			public int nameCardSkinTmpl;

			// Token: 0x040032D7 RID: 13015
			[Token(Token = "0x40032D7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAvatarInfo;

			// Token: 0x040032D8 RID: 13016
			[Token(Token = "0x40032D8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinId;

			// Token: 0x040032D9 RID: 13017
			[Token(Token = "0x40032D9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

			// Token: 0x040032DA RID: 13018
			[Token(Token = "0x40032DA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020008D1 RID: 2257
		[Token(Token = "0x20008D1")]
		public class VisitorInfo
		{
			// Token: 0x06006586 RID: 25990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006586")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VisitorInfo()
			{
			}

			// Token: 0x040032DB RID: 13019
			[Token(Token = "0x40032DB")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x040032DC RID: 13020
			[Token(Token = "0x40032DC")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x040032DD RID: 13021
			[Token(Token = "0x40032DD")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x040032DE RID: 13022
			[Token(Token = "0x40032DE")]
			[FieldOffset(Offset = "0x28")]
			public string secretary;

			// Token: 0x040032DF RID: 13023
			[Token(Token = "0x40032DF")]
			[FieldOffset(Offset = "0x30")]
			public string secretarySkinId;

			// Token: 0x040032E0 RID: 13024
			[Token(Token = "0x40032E0")]
			[FieldOffset(Offset = "0x38")]
			public int level;

			// Token: 0x040032E1 RID: 13025
			[Token(Token = "0x40032E1")]
			[FieldOffset(Offset = "0x40")]
			public long ts;
		}

		// Token: 0x020008D2 RID: 2258
		[Token(Token = "0x20008D2")]
		public class BuildingSnapshotMusic
		{
			// Token: 0x06006587 RID: 25991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006587")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildingSnapshotMusic()
			{
			}

			// Token: 0x040032E2 RID: 13026
			[Token(Token = "0x40032E2")]
			[FieldOffset(Offset = "0x10")]
			public string selected;
		}
	}
}
