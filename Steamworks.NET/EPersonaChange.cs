using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	[Flags]
	public enum EPersonaChange
	{
		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		k_EPersonaChangeName = 1,
		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		k_EPersonaChangeStatus = 2,
		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		k_EPersonaChangeComeOnline = 4,
		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		k_EPersonaChangeGoneOffline = 8,
		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		k_EPersonaChangeGamePlayed = 16,
		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		k_EPersonaChangeGameServer = 32,
		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		k_EPersonaChangeAvatar = 64,
		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		k_EPersonaChangeJoinedSource = 128,
		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		k_EPersonaChangeLeftSource = 256,
		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		k_EPersonaChangeRelationshipChanged = 512,
		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		k_EPersonaChangeNameFirstSet = 1024,
		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		k_EPersonaChangeBroadcast = 2048,
		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		k_EPersonaChangeNickname = 4096,
		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		k_EPersonaChangeSteamLevel = 8192,
		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		k_EPersonaChangeRichPresence = 16384
	}
}
