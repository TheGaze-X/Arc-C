using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	internal static class DragAndDropUtility
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x5AD8B20", Offset = "0x5AD7720", VA = "0x185AD8B20")]
		internal static IDragAndDrop GetDragAndDrop(IPanel panel)
		{
			return null;
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x0")]
		private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x8")]
		private static IDragAndDrop s_DragAndDropEditor;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x10")]
		private static IDragAndDrop s_DragAndDropPlayMode;
	}
}
