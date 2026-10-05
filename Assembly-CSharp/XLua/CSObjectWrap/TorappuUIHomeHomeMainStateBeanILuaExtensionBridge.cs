using System;
using Il2CppDummyDll;
using Torappu.UI.Home;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	public class TorappuUIHomeHomeMainStateBeanILuaExtensionBridge : LuaBase, HomeMainStateBean.ILuaExtension
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433D")]
		[Address(RVA = "0xF27240", Offset = "0xF25E40", VA = "0x180F27240")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIHomeHomeMainStateBeanILuaExtensionBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00023F10 File Offset: 0x00022110
		[Token(Token = "0x600433F")]
		[Address(RVA = "0xF26FB0", Offset = "0xF25BB0", VA = "0x180F26FB0", Slot = "7")]
		private HomeMainStateBean.ReturningStatus GetReturnStatus()
		{
			return default(HomeMainStateBean.ReturningStatus);
		}
	}
}
