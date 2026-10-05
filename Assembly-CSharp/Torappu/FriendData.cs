using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200141E RID: 5150
	[Token(Token = "0x200141E")]
	public class FriendData : FriendCommonData
	{
		// Token: 0x060076DF RID: 30431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DF")]
		[Address(RVA = "0x241EE80", Offset = "0x241DA80", VA = "0x18241EE80")]
		public FriendData()
		{
		}

		// Token: 0x04007433 RID: 29747
		[Token(Token = "0x4007433")]
		[FieldOffset(Offset = "0x68")]
		public List<SharedCharData> assistCharList;

		// Token: 0x04007434 RID: 29748
		[Token(Token = "0x4007434")]
		[FieldOffset(Offset = "0x70")]
		public List<string> board;

		// Token: 0x04007435 RID: 29749
		[Token(Token = "0x4007435")]
		[FieldOffset(Offset = "0x78")]
		public long infoShare;

		// Token: 0x04007436 RID: 29750
		[Token(Token = "0x4007436")]
		[FieldOffset(Offset = "0x80")]
		public int infoShareVisited;

		// Token: 0x04007437 RID: 29751
		[Token(Token = "0x4007437")]
		[FieldOffset(Offset = "0x88")]
		public PlayerNameCardSkin skin;

		// Token: 0x04007438 RID: 29752
		[Token(Token = "0x4007438")]
		[FieldOffset(Offset = "0x90")]
		public int clueSendToMe;

		// Token: 0x04007439 RID: 29753
		[Token(Token = "0x4007439")]
		[FieldOffset(Offset = "0x98")]
		public List<string> clueReceiveFromMe;

		// Token: 0x0400743A RID: 29754
		[Token(Token = "0x400743A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
