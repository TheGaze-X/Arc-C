using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200525F RID: 21087
	[Token(Token = "0x200525F")]
	public interface IRoguelikeDungeonNodeView
	{
		// Token: 0x0601F18F RID: 127375
		[Token(Token = "0x601F18F")]
		Color GetSelectableColor();

		// Token: 0x0601F190 RID: 127376
		[Token(Token = "0x601F190")]
		RectTransform GetRectTransform();
	}
}
