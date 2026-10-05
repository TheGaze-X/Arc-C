using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	public class TorappuUIIUICharacterIllustLoaderBridge : LuaBase, IUICharacterIllustLoader
	{
		// Token: 0x06004350 RID: 17232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004350")]
		[Address(RVA = "0xF289D0", Offset = "0xF275D0", VA = "0x180F289D0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004351")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIIUICharacterIllustLoaderBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004352")]
		[Address(RVA = "0xF28640", Offset = "0xF27240", VA = "0x180F28640", Slot = "7")]
		private Image ControllerOnlyLoadChrIllust(CharUISkinStruct skin, Transform parent)
		{
			return null;
		}
	}
}
