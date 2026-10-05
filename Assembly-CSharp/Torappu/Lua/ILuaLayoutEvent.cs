using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x0200160F RID: 5647
	[Token(Token = "0x200160F")]
	[CSharpCallLua]
	public interface ILuaLayoutEvent
	{
		// Token: 0x0600802F RID: 32815
		[Token(Token = "0x600802F")]
		void OnEnable();

		// Token: 0x06008030 RID: 32816
		[Token(Token = "0x6008030")]
		void OnDisable();

		// Token: 0x06008031 RID: 32817
		[Token(Token = "0x6008031")]
		void OnDestroy();

		// Token: 0x06008032 RID: 32818
		[Token(Token = "0x6008032")]
		void OnResume();

		// Token: 0x06008033 RID: 32819
		[Token(Token = "0x6008033")]
		void OnEnter();

		// Token: 0x06008034 RID: 32820
		[Token(Token = "0x6008034")]
		void OnExit();

		// Token: 0x06008035 RID: 32821
		[Token(Token = "0x6008035")]
		void OnTransInEnd();

		// Token: 0x06008036 RID: 32822
		[Token(Token = "0x6008036")]
		void OnTransOutEnd();
	}
}
