using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	internal interface IDragAndDrop
	{
		// Token: 0x06000A75 RID: 2677
		[Token(Token = "0x6000A75")]
		void StartDrag(StartDragArgs args, Vector3 pointerPosition);

		// Token: 0x06000A76 RID: 2678
		[Token(Token = "0x6000A76")]
		void UpdateDrag(Vector3 pointerPosition);

		// Token: 0x06000A77 RID: 2679
		[Token(Token = "0x6000A77")]
		void AcceptDrag();

		// Token: 0x06000A78 RID: 2680
		[Token(Token = "0x6000A78")]
		void DragCleanup();

		// Token: 0x06000A79 RID: 2681
		[Token(Token = "0x6000A79")]
		void SetVisualMode(DragVisualMode visualMode);

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A7A RID: 2682
		[Token(Token = "0x17000241")]
		DragAndDropData data { [Token(Token = "0x6000A7A")] get; }
	}
}
