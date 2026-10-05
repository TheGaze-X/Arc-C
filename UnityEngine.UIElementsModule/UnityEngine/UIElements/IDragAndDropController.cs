using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	internal interface IDragAndDropController<in TArgs>
	{
		// Token: 0x06000A80 RID: 2688
		[Token(Token = "0x6000A80")]
		bool CanStartDrag(IEnumerable<int> itemIndices);

		// Token: 0x06000A81 RID: 2689
		[Token(Token = "0x6000A81")]
		StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIndices, bool skipText = false);

		// Token: 0x06000A82 RID: 2690
		[Token(Token = "0x6000A82")]
		DragVisualMode HandleDragAndDrop(TArgs args);

		// Token: 0x06000A83 RID: 2691
		[Token(Token = "0x6000A83")]
		void OnDrop(TArgs args);

		// Token: 0x06000A84 RID: 2692
		[Token(Token = "0x6000A84")]
		void DragCleanup();

		// Token: 0x06000A85 RID: 2693
		[Token(Token = "0x6000A85")]
		IEnumerable<int> GetSortedSelectedIds();
	}
}
