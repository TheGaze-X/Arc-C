using System;
using Il2CppDummyDll;

namespace DG.Tweening
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public enum LinkBehaviour
	{
		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		PauseOnDisable,
		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		PauseOnDisablePlayOnEnable,
		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		PauseOnDisableRestartOnEnable,
		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		PlayOnEnable,
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		RestartOnEnable,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		KillOnDisable,
		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		KillOnDestroy,
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		CompleteOnDisable,
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		CompleteAndKillOnDisable,
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		RewindOnDisable,
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		RewindAndKillOnDisable
	}
}
