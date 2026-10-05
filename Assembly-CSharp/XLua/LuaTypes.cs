using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	public enum LuaTypes
	{
		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		LUA_TNONE = -1,
		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		LUA_TNIL,
		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		LUA_TNUMBER = 3,
		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		LUA_TSTRING,
		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		LUA_TBOOLEAN = 1,
		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		LUA_TTABLE = 5,
		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		LUA_TFUNCTION,
		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		LUA_TUSERDATA,
		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		LUA_TTHREAD,
		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		LUA_TLIGHTUSERDATA = 2
	}
}
