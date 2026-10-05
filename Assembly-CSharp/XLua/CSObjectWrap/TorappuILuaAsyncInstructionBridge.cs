using System;
using Il2CppDummyDll;
using Torappu;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public class TorappuILuaAsyncInstructionBridge : LuaBase, ILuaAsyncInstruction, ICSharpCallLua
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004024")]
		[Address(RVA = "0xC0A280", Offset = "0xC08E80", VA = "0x180C0A280")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuILuaAsyncInstructionBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00020730 File Offset: 0x0001E930
		[Token(Token = "0x6004026")]
		[Address(RVA = "0xC0A040", Offset = "0xC08C40", VA = "0x180C0A040", Slot = "7")]
		private bool KeepWaiting()
		{
			return default(bool);
		}
	}
}
