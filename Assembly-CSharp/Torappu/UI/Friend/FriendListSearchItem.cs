using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB2 RID: 19890
	[Token(Token = "0x2004DB2")]
	public class FriendListSearchItem : FriendListItemBase
	{
		// Token: 0x0601DBEF RID: 121839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBEF")]
		[Address(RVA = "0x1751530", Offset = "0x1750130", VA = "0x181751530")]
		public void SetFriend(FriendStatus friendAdded)
		{
		}

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF0")]
		[Address(RVA = "0x1751390", Offset = "0x174FF90", VA = "0x181751390")]
		public void AddFriend()
		{
		}

		// Token: 0x0601DBF1 RID: 121841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF1")]
		[Address(RVA = "0x17514A0", Offset = "0x17500A0", VA = "0x1817514A0")]
		public void AlreadySend()
		{
		}

		// Token: 0x0601DBF2 RID: 121842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF2")]
		[Address(RVA = "0x1751410", Offset = "0x1750010", VA = "0x181751410")]
		public void AlreadyFriend()
		{
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF3")]
		[Address(RVA = "0x1751610", Offset = "0x1750210", VA = "0x181751610")]
		public FriendListSearchItem()
		{
		}

		// Token: 0x04027580 RID: 161152
		[Token(Token = "0x4027580")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ThreeStateToggle _addFriendFlag;

		// Token: 0x04027581 RID: 161153
		[Token(Token = "0x4027581")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public Action<FriendData> DealAction;

		// Token: 0x04027582 RID: 161154
		[Token(Token = "0x4027582")]
		private const int NORMAL = 0;

		// Token: 0x04027583 RID: 161155
		[Token(Token = "0x4027583")]
		private const int ALREADY_SEND = 1;

		// Token: 0x04027584 RID: 161156
		[Token(Token = "0x4027584")]
		private const int ALREADY_ADD = 2;

		// Token: 0x04027585 RID: 161157
		[Token(Token = "0x4027585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetFriend;

		// Token: 0x04027586 RID: 161158
		[Token(Token = "0x4027586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddFriend;

		// Token: 0x04027587 RID: 161159
		[Token(Token = "0x4027587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AlreadySend;

		// Token: 0x04027588 RID: 161160
		[Token(Token = "0x4027588")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AlreadyFriend;

		// Token: 0x04027589 RID: 161161
		[Token(Token = "0x4027589")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
