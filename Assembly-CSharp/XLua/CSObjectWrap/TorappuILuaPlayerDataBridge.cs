using System;
using Il2CppDummyDll;
using Torappu;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public class TorappuILuaPlayerDataBridge : LuaBase, ILuaPlayerData
	{
		// Token: 0x06004027 RID: 16423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004027")]
		[Address(RVA = "0xC0A550", Offset = "0xC09150", VA = "0x180C0A550")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuILuaPlayerDataBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004029")]
		[Address(RVA = "0xC0A2F0", Offset = "0xC08EF0", VA = "0x180C0A2F0", Slot = "7")]
		private void ExportSetData(LuaTable luaData)
		{
		}
	}
}
