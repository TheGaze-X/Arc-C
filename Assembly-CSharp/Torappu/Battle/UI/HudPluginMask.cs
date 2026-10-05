using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x0200336A RID: 13162
	[Token(Token = "0x200336A")]
	[Flags]
	public enum HudPluginMask
	{
		// Token: 0x04018FBD RID: 102333
		[Token(Token = "0x4018FBD")]
		NONE = 0,
		// Token: 0x04018FBE RID: 102334
		[Token(Token = "0x4018FBE")]
		HP = 1,
		// Token: 0x04018FBF RID: 102335
		[Token(Token = "0x4018FBF")]
		EP = 2,
		// Token: 0x04018FC0 RID: 102336
		[Token(Token = "0x4018FC0")]
		SP = 4,
		// Token: 0x04018FC1 RID: 102337
		[Token(Token = "0x4018FC1")]
		SP_CAST = 8,
		// Token: 0x04018FC2 RID: 102338
		[Token(Token = "0x4018FC2")]
		BULLET = 16,
		// Token: 0x04018FC3 RID: 102339
		[Token(Token = "0x4018FC3")]
		CHANT = 32,
		// Token: 0x04018FC4 RID: 102340
		[Token(Token = "0x4018FC4")]
		BG = 64,
		// Token: 0x04018FC5 RID: 102341
		[Token(Token = "0x4018FC5")]
		OTHER_RESIDENT = 128,
		// Token: 0x04018FC6 RID: 102342
		[Token(Token = "0x4018FC6")]
		CUSTOM = 256,
		// Token: 0x04018FC7 RID: 102343
		[Token(Token = "0x4018FC7")]
		DEFAULT_SHOW = 448,
		// Token: 0x04018FC8 RID: 102344
		[Token(Token = "0x4018FC8")]
		EXCLUDE_SKILL = 451
	}
}
