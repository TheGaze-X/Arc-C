using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI.Medal
{
	// Token: 0x02004936 RID: 18742
	[Token(Token = "0x2004936")]
	public interface IMedalDIYContext
	{
		// Token: 0x0601C400 RID: 115712
		[Token(Token = "0x601C400")]
		T LoadAsset<T>(string path) where T : UnityEngine.Object;

		// Token: 0x0601C401 RID: 115713
		[Token(Token = "0x601C401")]
		void BeginDragFromToken(string medalId);

		// Token: 0x0601C402 RID: 115714
		[Token(Token = "0x601C402")]
		void EndDragFromToken(string medalId);

		// Token: 0x0601C403 RID: 115715
		[Token(Token = "0x601C403")]
		void PointDownFromToken(string medalId, PointerEventData eventData);

		// Token: 0x0601C404 RID: 115716
		[Token(Token = "0x601C404")]
		void DragCardFromList(string medalId, PointerEventData eventData);

		// Token: 0x0601C405 RID: 115717
		[Token(Token = "0x601C405")]
		Sprite LoadMedalIcon(string spriteId);

		// Token: 0x0601C406 RID: 115718
		[Token(Token = "0x601C406")]
		string GetTargetMedalId();

		// Token: 0x0601C407 RID: 115719
		[Token(Token = "0x601C407")]
		UIPage GetPage();
	}
}
