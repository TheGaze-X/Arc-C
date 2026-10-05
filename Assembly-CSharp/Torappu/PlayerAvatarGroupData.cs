using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FED RID: 4077
	[Token(Token = "0x2000FED")]
	public class PlayerAvatarGroupData
	{
		// Token: 0x06006D44 RID: 27972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D44")]
		[Address(RVA = "0x2109A80", Offset = "0x2108680", VA = "0x182109A80")]
		public PlayerAvatarGroupData()
		{
		}

		// Token: 0x0400567A RID: 22138
		[Token(Token = "0x400567A")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarGroupType avatarType;

		// Token: 0x0400567B RID: 22139
		[Token(Token = "0x400567B")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x0400567C RID: 22140
		[Token(Token = "0x400567C")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0400567D RID: 22141
		[Token(Token = "0x400567D")]
		[FieldOffset(Offset = "0x28")]
		public List<string> avatarIdList;
	}
}
