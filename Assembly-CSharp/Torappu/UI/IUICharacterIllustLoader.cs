using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200353C RID: 13628
	[Token(Token = "0x200353C")]
	[CSharpCallLua]
	public interface IUICharacterIllustLoader
	{
		// Token: 0x06015B97 RID: 88983
		[Token(Token = "0x6015B97")]
		Image ControllerOnlyLoadChrIllust(CharUISkinStruct skin, [Optional] Transform parent);
	}
}
