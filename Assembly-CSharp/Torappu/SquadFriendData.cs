using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	[Serializable]
	public class SquadFriendData : FriendCommonData
	{
		// Token: 0x06006557 RID: 25943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006557")]
		[Address(RVA = "0x1F01D20", Offset = "0x1F00920", VA = "0x181F01D20")]
		public SquadFriendData()
		{
		}

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x68")]
		public SharedCharData assistChar;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x70")]
		public int assistSlotIndex;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
