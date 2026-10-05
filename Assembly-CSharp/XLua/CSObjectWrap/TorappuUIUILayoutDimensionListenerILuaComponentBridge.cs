using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public class TorappuUIUILayoutDimensionListenerILuaComponentBridge : LuaBase, UILayoutDimensionListener.ILuaComponent, ICSharpCallLua
	{
		// Token: 0x06004411 RID: 17425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x1043BD0", Offset = "0x10427D0", VA = "0x181043BD0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIUILayoutDimensionListenerILuaComponentBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x10439C0", Offset = "0x10425C0", VA = "0x1810439C0", Slot = "7")]
		private void ExportOnPostLayout()
		{
		}
	}
}
