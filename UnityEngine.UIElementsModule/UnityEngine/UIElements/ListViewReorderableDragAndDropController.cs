using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x5AE6CA0", Offset = "0x5AE58A0", VA = "0x185AE6CA0")]
		public ListViewReorderableDragAndDropController(ListView view)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x5AE6910", Offset = "0x5AE5510", VA = "0x185AE6910", Slot = "17")]
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			return DragVisualMode.None;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x5AE69F0", Offset = "0x5AE55F0", VA = "0x185AE69F0", Slot = "18")]
		public override void OnDrop(IListDragAndDropArgs args)
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x28")]
		protected readonly ListView m_ListView;
	}
}
