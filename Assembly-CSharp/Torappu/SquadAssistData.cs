using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	[Serializable]
	public class SquadAssistData : FriendCommonData
	{
		// Token: 0x06006558 RID: 25944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006558")]
		[Address(RVA = "0x1F01CC0", Offset = "0x1F008C0", VA = "0x181F01CC0")]
		public SquadAssistData()
		{
		}

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x68")]
		public int assistSlotIndex;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x70")]
		public string aliasName;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x78")]
		public SharedCharData[] assistCharList;

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x80")]
		public bool isFriend;

		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x81")]
		public bool canRequestFriend;

		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x82")]
		public bool isStarFriend;

		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
