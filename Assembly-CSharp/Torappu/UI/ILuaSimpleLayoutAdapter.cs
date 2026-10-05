using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039BC RID: 14780
	[Token(Token = "0x20039BC")]
	[CSharpCallLua]
	public interface ILuaSimpleLayoutAdapter
	{
		// Token: 0x060175A5 RID: 95653
		[Token(Token = "0x60175A5")]
		int GetCount();

		// Token: 0x060175A6 RID: 95654
		[Token(Token = "0x60175A6")]
		void UpdateView(int index, GameObject view);

		// Token: 0x060175A7 RID: 95655
		[Token(Token = "0x60175A7")]
		GameObject GetOverridePrefab();
	}
}
