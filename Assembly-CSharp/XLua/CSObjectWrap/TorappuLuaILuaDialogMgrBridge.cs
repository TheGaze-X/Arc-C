using System;
using Il2CppDummyDll;
using Torappu.Lua;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	public class TorappuLuaILuaDialogMgrBridge : LuaBase, ILuaDialogMgr
	{
		// Token: 0x0600405F RID: 16479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405F")]
		[Address(RVA = "0xC10F60", Offset = "0xC0FB60", VA = "0x180C10F60")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuLuaILuaDialogMgrBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004061")]
		[Address(RVA = "0xC10C40", Offset = "0xC0F840", VA = "0x180C10C40", Slot = "7")]
		private ILuaDialog CreateDlgByName(string dlgClsName, ILuaDialog parent)
		{
			return null;
		}
	}
}
