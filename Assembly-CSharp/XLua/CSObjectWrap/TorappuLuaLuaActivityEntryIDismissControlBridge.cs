using System;
using Il2CppDummyDll;
using Torappu.Lua;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	public class TorappuLuaLuaActivityEntryIDismissControlBridge : LuaBase, LuaActivityEntry.IDismissControl
	{
		// Token: 0x0600406C RID: 16492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406C")]
		[Address(RVA = "0xCF5040", Offset = "0xCF3C40", VA = "0x180CF5040")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuLuaLuaActivityEntryIDismissControlBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x600406E")]
		[Address(RVA = "0xCF4E00", Offset = "0xCF3A00", VA = "0x180CF4E00", Slot = "7")]
		private bool TryDismiss()
		{
			return default(bool);
		}
	}
}
