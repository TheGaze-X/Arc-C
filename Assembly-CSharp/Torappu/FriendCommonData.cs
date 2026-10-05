using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x0200141B RID: 5147
	[Token(Token = "0x200141B")]
	[Serializable]
	public class FriendCommonData : IPlayerStatus, IHotfixable
	{
		// Token: 0x060076D5 RID: 30421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076D5")]
		[Address(RVA = "0x241E9B0", Offset = "0x241D5B0", VA = "0x18241E9B0", Slot = "4")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076D6")]
		[Address(RVA = "0x241EA10", Offset = "0x241D610", VA = "0x18241EA10", Slot = "5")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x000351A8 File Offset: 0x000333A8
		[Token(Token = "0x60076D7")]
		[Address(RVA = "0x241EA70", Offset = "0x241D670", VA = "0x18241EA70", Slot = "6")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D8")]
		[Address(RVA = "0x241EAD0", Offset = "0x241D6D0", VA = "0x18241EAD0")]
		public FriendCommonData()
		{
		}

		// Token: 0x0400741D RID: 29725
		[Token(Token = "0x400741D")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x0400741E RID: 29726
		[Token(Token = "0x400741E")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x0400741F RID: 29727
		[Token(Token = "0x400741F")]
		[FieldOffset(Offset = "0x20")]
		public string serverName;

		// Token: 0x04007420 RID: 29728
		[Token(Token = "0x4007420")]
		[FieldOffset(Offset = "0x28")]
		public string nickNumber;

		// Token: 0x04007421 RID: 29729
		[Token(Token = "0x4007421")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x04007422 RID: 29730
		[Token(Token = "0x4007422")]
		[FieldOffset(Offset = "0x38")]
		public DateTime lastOnlineTime;

		// Token: 0x04007423 RID: 29731
		[Token(Token = "0x4007423")]
		[FieldOffset(Offset = "0x40")]
		public bool recentVisited;

		// Token: 0x04007424 RID: 29732
		[Token(Token = "0x4007424")]
		[FieldOffset(Offset = "0x48")]
		public AvatarInfo avatar;

		// Token: 0x04007425 RID: 29733
		[Token(Token = "0x4007425")]
		[FieldOffset(Offset = "0x50")]
		public string secretary;

		// Token: 0x04007426 RID: 29734
		[Token(Token = "0x4007426")]
		[FieldOffset(Offset = "0x58")]
		public string secretarySkinId;

		// Token: 0x04007427 RID: 29735
		[Token(Token = "0x4007427")]
		[FieldOffset(Offset = "0x60")]
		public bool secretarySkinSp;

		// Token: 0x04007428 RID: 29736
		[Token(Token = "0x4007428")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04007429 RID: 29737
		[Token(Token = "0x4007429")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x0400742A RID: 29738
		[Token(Token = "0x400742A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x0400742B RID: 29739
		[Token(Token = "0x400742B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
