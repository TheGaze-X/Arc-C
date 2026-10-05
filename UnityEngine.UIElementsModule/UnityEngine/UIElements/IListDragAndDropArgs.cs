using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	internal interface IListDragAndDropArgs
	{
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A8E RID: 2702
		[Token(Token = "0x17000249")]
		int insertAtIndex { [Token(Token = "0x6000A8E")] get; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A8F RID: 2703
		[Token(Token = "0x1700024A")]
		int parentId { [Token(Token = "0x6000A8F")] get; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A90 RID: 2704
		[Token(Token = "0x1700024B")]
		int childIndex { [Token(Token = "0x6000A90")] get; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A91 RID: 2705
		[Token(Token = "0x1700024C")]
		IDragAndDropData dragAndDropData { [Token(Token = "0x6000A91")] get; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A92 RID: 2706
		[Token(Token = "0x1700024D")]
		DragAndDropPosition dragAndDropPosition { [Token(Token = "0x6000A92")] get; }
	}
}
