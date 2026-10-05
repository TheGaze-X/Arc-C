using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	public enum LuaThreadStatus
	{
		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		LUA_RESUME_ERROR = -1,
		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		LUA_OK,
		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		LUA_YIELD,
		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		LUA_ERRRUN,
		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		LUA_ERRSYNTAX,
		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		LUA_ERRMEM,
		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		LUA_ERRERR
	}
}
