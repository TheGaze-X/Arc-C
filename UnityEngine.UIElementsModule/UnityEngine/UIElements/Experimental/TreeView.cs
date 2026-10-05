using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	internal class TreeView : BaseVerticalCollectionView
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000553")]
		internal new TreeViewController viewController
		{
			[Token(Token = "0x6001583")]
			[Address(RVA = "0x5A8BE20", Offset = "0x5A8AA20", VA = "0x185A8BE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x5A8BAF0", Offset = "0x5A8A6F0", VA = "0x185A8BAF0", Slot = "104")]
		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000554")]
		internal List<int> expandedItemIds
		{
			[Token(Token = "0x6001585")]
			[Address(RVA = "0x5A8BE10", Offset = "0x5A8AA10", VA = "0x185A8BE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x5A8BB50", Offset = "0x5A8A750", VA = "0x185A8BB50")]
		public bool IsExpanded(int id)
		{
			return default(bool);
		}

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string itemUssClassName;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string itemToggleUssClassName;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string itemIndentsContainerUssClassName;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string itemIndentUssClassName;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string itemContentContainerUssClassName;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x4A8")]
		[SerializeField]
		private List<int> m_ExpandedItemIds;
	}
}
