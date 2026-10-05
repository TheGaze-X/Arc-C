using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	public class TorappuUIITrackPointStatusBridge : LuaBase, ITrackPointStatus
	{
		// Token: 0x0600434D RID: 17229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434D")]
		[Address(RVA = "0xF285D0", Offset = "0xF271D0", VA = "0x180F285D0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIITrackPointStatusBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00023F70 File Offset: 0x00022170
		[Token(Token = "0x600434F")]
		[Address(RVA = "0xF28390", Offset = "0xF26F90", VA = "0x180F28390", Slot = "7")]
		private bool IsShow()
		{
			return default(bool);
		}
	}
}
