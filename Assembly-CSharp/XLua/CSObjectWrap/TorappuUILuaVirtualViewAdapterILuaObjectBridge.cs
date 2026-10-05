using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Lua;
using Torappu.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public class TorappuUILuaVirtualViewAdapterILuaObjectBridge : LuaBase, LuaVirtualViewAdapter.ILuaObject, ICSharpCallLua
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004388")]
		[Address(RVA = "0xF2F030", Offset = "0xF2DC30", VA = "0x180F2F030")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUILuaVirtualViewAdapterILuaObjectBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438A")]
		[Address(RVA = "0xF2ED90", Offset = "0xF2D990", VA = "0x180F2ED90", Slot = "7")]
		private void ExportBindView(int type, int indexFrom1, LuaLayout layout, int widgetId)
		{
		}
	}
}
