using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	internal interface IGenericMenu
	{
		// Token: 0x060007DD RID: 2013
		[Token(Token = "0x60007DD")]
		void AddItem(string itemName, bool isChecked, Action action);

		// Token: 0x060007DE RID: 2014
		[Token(Token = "0x60007DE")]
		void DropDown(Rect position, [Optional] VisualElement targetElement, bool anchored = false);
	}
}
