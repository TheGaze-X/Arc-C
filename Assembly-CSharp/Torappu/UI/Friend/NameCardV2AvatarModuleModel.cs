using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D8C RID: 19852
	[Token(Token = "0x2004D8C")]
	public class NameCardV2AvatarModuleModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DB40 RID: 121664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB40")]
		[Address(RVA = "0x17459F0", Offset = "0x17445F0", VA = "0x1817459F0", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB41 RID: 121665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB41")]
		[Address(RVA = "0x1745AF0", Offset = "0x17446F0", VA = "0x181745AF0", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB42 RID: 121666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB42")]
		[Address(RVA = "0x1745C20", Offset = "0x1744820", VA = "0x181745C20", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB43 RID: 121667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB43")]
		[Address(RVA = "0x1745D00", Offset = "0x1744900", VA = "0x181745D00")]
		public NameCardV2AvatarModuleModel()
		{
		}

		// Token: 0x04027410 RID: 160784
		[Token(Token = "0x4027410")]
		[FieldOffset(Offset = "0x38")]
		public string nickName;

		// Token: 0x04027411 RID: 160785
		[Token(Token = "0x4027411")]
		[FieldOffset(Offset = "0x40")]
		public string nickNameId;

		// Token: 0x04027412 RID: 160786
		[Token(Token = "0x4027412")]
		[FieldOffset(Offset = "0x48")]
		public int level;

		// Token: 0x04027413 RID: 160787
		[Token(Token = "0x4027413")]
		[FieldOffset(Offset = "0x50")]
		public string uid;

		// Token: 0x04027414 RID: 160788
		[Token(Token = "0x4027414")]
		[FieldOffset(Offset = "0x58")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04027415 RID: 160789
		[Token(Token = "0x4027415")]
		[FieldOffset(Offset = "0x70")]
		public bool isSelf;

		// Token: 0x04027416 RID: 160790
		[Token(Token = "0x4027416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027417 RID: 160791
		[Token(Token = "0x4027417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x04027418 RID: 160792
		[Token(Token = "0x4027418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x04027419 RID: 160793
		[Token(Token = "0x4027419")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
