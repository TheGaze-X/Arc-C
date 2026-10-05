using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001611 RID: 5649
	[Token(Token = "0x2001611")]
	[CSharpCallLua]
	public interface ILuaDialogMgr
	{
		// Token: 0x06008043 RID: 32835
		[Token(Token = "0x6008043")]
		ILuaDialog CreateDlgByName(string dlgClsName, ILuaDialog parent);
	}
}
