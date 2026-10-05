using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FEB RID: 4075
	[Token(Token = "0x2000FEB")]
	public class PlayerAvatarPerData
	{
		// Token: 0x06006D41 RID: 27969 RVA: 0x00031C08 File Offset: 0x0002FE08
		[Token(Token = "0x6006D41")]
		[Address(RVA = "0x2109B10", Offset = "0x2108710", VA = "0x182109B10")]
		public bool ShouldSerializelimitDatas()
		{
			return default(bool);
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D42")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerAvatarPerData()
		{
		}

		// Token: 0x04005668 RID: 22120
		[Token(Token = "0x4005668")]
		public const PlayerAvatarGroupType ASSISTANT_GROUP_TYPE = PlayerAvatarGroupType.ASSISTANT;

		// Token: 0x04005669 RID: 22121
		[Token(Token = "0x4005669")]
		[FieldOffset(Offset = "0x10")]
		public string avatarId;

		// Token: 0x0400566A RID: 22122
		[Token(Token = "0x400566A")]
		[FieldOffset(Offset = "0x18")]
		public PlayerAvatarGroupType avatarType;

		// Token: 0x0400566B RID: 22123
		[Token(Token = "0x400566B")]
		[FieldOffset(Offset = "0x20")]
		public string avatarDesc;

		// Token: 0x0400566C RID: 22124
		[Token(Token = "0x400566C")]
		[FieldOffset(Offset = "0x28")]
		public bool isSecret;

		// Token: 0x0400566D RID: 22125
		[Token(Token = "0x400566D")]
		[FieldOffset(Offset = "0x30")]
		public long avatarStartTs;

		// Token: 0x0400566E RID: 22126
		[Token(Token = "0x400566E")]
		[FieldOffset(Offset = "0x38")]
		public bool avatarLimit;

		// Token: 0x0400566F RID: 22127
		[Token(Token = "0x400566F")]
		[FieldOffset(Offset = "0x3C")]
		public int avatarIdSort;

		// Token: 0x04005670 RID: 22128
		[Token(Token = "0x4005670")]
		[FieldOffset(Offset = "0x40")]
		public string avatarIdDesc;

		// Token: 0x04005671 RID: 22129
		[Token(Token = "0x4005671")]
		[FieldOffset(Offset = "0x48")]
		public string avatarItemName;

		// Token: 0x04005672 RID: 22130
		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x50")]
		public string avatarItemDesc;

		// Token: 0x04005673 RID: 22131
		[Token(Token = "0x4005673")]
		[FieldOffset(Offset = "0x58")]
		public string avatarItemUsage;

		// Token: 0x04005674 RID: 22132
		[Token(Token = "0x4005674")]
		[FieldOffset(Offset = "0x60")]
		public string obtainApproach;

		// Token: 0x04005675 RID: 22133
		[Token(Token = "0x4005675")]
		[FieldOffset(Offset = "0x68")]
		public string dynAvatarId;

		// Token: 0x04005676 RID: 22134
		[Token(Token = "0x4005676")]
		[FieldOffset(Offset = "0x70")]
		public List<PlayerAvatarLimitData> limitDatas;
	}
}
