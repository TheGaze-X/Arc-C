using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public class BuildingVisitContext
	{
		// Token: 0x06004D1C RID: 19740 RVA: 0x0002D660 File Offset: 0x0002B860
		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x178D650", Offset = "0x178C250", VA = "0x18178D650")]
		public bool TryFindFriend(string uid, out BuildingVisitContext.FriendInfo target)
		{
			return default(bool);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x0002D678 File Offset: 0x0002B878
		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x178D770", Offset = "0x178C370", VA = "0x18178D770")]
		public bool TryPickNextFriend(out BuildingVisitContext.FriendInfo nextFriend)
		{
			return default(bool);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingVisitContext()
		{
		}

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x10")]
		public int nextIndex;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x18")]
		public string originScene;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x20")]
		public BuildingVisitContext.PlayerInfo playerInfo;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x48")]
		public List<BuildingVisitContext.FriendInfo> sortedFriendList;

		// Token: 0x020004B0 RID: 1200
		[Token(Token = "0x20004B0")]
		public struct PlayerInfo
		{
			// Token: 0x04001122 RID: 4386
			[Token(Token = "0x4001122")]
			[FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04001123 RID: 4387
			[Token(Token = "0x4001123")]
			[FieldOffset(Offset = "0x8")]
			public int level;

			// Token: 0x04001124 RID: 4388
			[Token(Token = "0x4001124")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04001125 RID: 4389
			[Token(Token = "0x4001125")]
			[FieldOffset(Offset = "0x18")]
			public string skinId;

			// Token: 0x04001126 RID: 4390
			[Token(Token = "0x4001126")]
			[FieldOffset(Offset = "0x20")]
			public string nickName;
		}

		// Token: 0x020004B1 RID: 1201
		[Token(Token = "0x20004B1")]
		public struct FriendInfo
		{
			// Token: 0x06004D1F RID: 19743 RVA: 0x0002D690 File Offset: 0x0002B890
			[Token(Token = "0x6004D1F")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04001127 RID: 4391
			[Token(Token = "0x4001127")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BuildingVisitContext.FriendInfo EMPTY;

			// Token: 0x04001128 RID: 4392
			[Token(Token = "0x4001128")]
			[FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04001129 RID: 4393
			[Token(Token = "0x4001129")]
			[FieldOffset(Offset = "0x8")]
			public bool isSharing;

			// Token: 0x0400112A RID: 4394
			[Token(Token = "0x400112A")]
			[FieldOffset(Offset = "0x9")]
			public bool isSharingVisited;

			// Token: 0x0400112B RID: 4395
			[Token(Token = "0x400112B")]
			[FieldOffset(Offset = "0xA")]
			public bool isVisited;

			// Token: 0x0400112C RID: 4396
			[Token(Token = "0x400112C")]
			[FieldOffset(Offset = "0xB")]
			public bool isStar;

			// Token: 0x0400112D RID: 4397
			[Token(Token = "0x400112D")]
			[FieldOffset(Offset = "0xC")]
			public int rawIndex;
		}
	}
}
