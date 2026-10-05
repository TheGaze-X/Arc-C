using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB1 RID: 19889
	[Token(Token = "0x2004DB1")]
	public class FriendListRequestItem : FriendListItemBase
	{
		// Token: 0x0601DBEC RID: 121836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBEC")]
		[Address(RVA = "0x1751230", Offset = "0x174FE30", VA = "0x181751230")]
		public void AddFriend()
		{
		}

		// Token: 0x0601DBED RID: 121837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBED")]
		[Address(RVA = "0x17512B0", Offset = "0x174FEB0", VA = "0x1817512B0")]
		public void RefuseFriend()
		{
		}

		// Token: 0x0601DBEE RID: 121838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBEE")]
		[Address(RVA = "0x1751330", Offset = "0x174FF30", VA = "0x181751330")]
		public FriendListRequestItem()
		{
		}

		// Token: 0x0402757C RID: 161148
		[Token(Token = "0x402757C")]
		[FieldOffset(Offset = "0x108")]
		public Action<FriendData, FriendDealEnum> DealAction;

		// Token: 0x0402757D RID: 161149
		[Token(Token = "0x402757D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddFriend;

		// Token: 0x0402757E RID: 161150
		[Token(Token = "0x402757E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefuseFriend;

		// Token: 0x0402757F RID: 161151
		[Token(Token = "0x402757F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
