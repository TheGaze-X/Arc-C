using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FEE RID: 4078
	[Token(Token = "0x2000FEE")]
	public class PlayerAvatarData
	{
		// Token: 0x06006D45 RID: 27973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D45")]
		[Address(RVA = "0x2109970", Offset = "0x2108570", VA = "0x182109970")]
		public PlayerAvatarData()
		{
		}

		// Token: 0x0400567E RID: 22142
		[Token(Token = "0x400567E")]
		[FieldOffset(Offset = "0x10")]
		public string defaultAvatarId;

		// Token: 0x0400567F RID: 22143
		[Token(Token = "0x400567F")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerAvatarPerData> avatarList;

		// Token: 0x04005680 RID: 22144
		[Token(Token = "0x4005680")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<PlayerAvatarGroupType, PlayerAvatarGroupData> avatarTypeData;

		// Token: 0x04005681 RID: 22145
		[Token(Token = "0x4005681")]
		[FieldOffset(Offset = "0x28")]
		public AvatarConstData constData;
	}
}
