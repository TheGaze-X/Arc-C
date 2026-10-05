using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	public class TorappuUILuaTabPagerBridgeILuaObjectBridge : LuaBase, LuaTabPagerBridge.ILuaObject, ICSharpCallLua
	{
		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0xF2D7F0", Offset = "0xF2C3F0", VA = "0x180F2D7F0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUILuaTabPagerBridgeILuaObjectBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x000241B0 File Offset: 0x000223B0
		[Token(Token = "0x6004376")]
		[Address(RVA = "0xF2CAD0", Offset = "0xF2B6D0", VA = "0x180F2CAD0", Slot = "7")]
		private int CSTabCount()
		{
			return 0;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0xF2C890", Offset = "0xF2B490", VA = "0x180F2C890", Slot = "8")]
		private string CSDefaultTab()
		{
			return null;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004378")]
		[Address(RVA = "0xF2D040", Offset = "0xF2BC40", VA = "0x180F2D040", Slot = "9")]
		private string CSTabId(int indexFrom1)
		{
			return null;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0xF2D580", Offset = "0xF2C180", VA = "0x180F2D580", Slot = "10")]
		private string CSTabResPath(int indexFrom1)
		{
			return null;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437A")]
		[Address(RVA = "0xF2CD10", Offset = "0xF2B910", VA = "0x180F2CD10", Slot = "11")]
		private Type CSTabDialogType(int indexFrom1)
		{
			return null;
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437B")]
		[Address(RVA = "0xF2D2B0", Offset = "0xF2BEB0", VA = "0x180F2D2B0", Slot = "12")]
		private object CSTabInput(int indexFrom1)
		{
			return null;
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437C")]
		[Address(RVA = "0xF2C540", Offset = "0xF2B140", VA = "0x180F2C540", Slot = "13")]
		private ILuaAsyncInstruction CSCallback(int indexFrom1, ValueBundle output)
		{
			return null;
		}
	}
}
