using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x2000C0C")]
	[CSharpCallLua]
	public interface ILuaPlayerData
	{
		// Token: 0x060068A8 RID: 26792
		[Token(Token = "0x60068A8")]
		void ExportSetData(LuaTable luaData);
	}
}
