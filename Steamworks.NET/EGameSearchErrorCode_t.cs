using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public enum EGameSearchErrorCode_t
	{
		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		k_EGameSearchErrorCode_OK = 1,
		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		k_EGameSearchErrorCode_Failed_Search_Already_In_Progress,
		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		k_EGameSearchErrorCode_Failed_No_Search_In_Progress,
		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		k_EGameSearchErrorCode_Failed_Not_Lobby_Leader,
		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		k_EGameSearchErrorCode_Failed_No_Host_Available,
		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		k_EGameSearchErrorCode_Failed_Search_Params_Invalid,
		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		k_EGameSearchErrorCode_Failed_Offline,
		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		k_EGameSearchErrorCode_Failed_NotAuthorized,
		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		k_EGameSearchErrorCode_Failed_Unknown_Error
	}
}
