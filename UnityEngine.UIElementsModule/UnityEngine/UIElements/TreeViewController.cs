using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal abstract class TreeViewController : CollectionViewController
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000154")]
		protected TreeView treeView
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x5A93630", Offset = "0x5A92230", VA = "0x185A93630")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x5A93110", Offset = "0x5A91D10", VA = "0x185A93110")]
		public void RebuildTree()
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x59976A0", Offset = "0x59962A0", VA = "0x1859976A0")]
		public IEnumerable<int> GetRootItemIds()
		{
			return null;
		}

		// Token: 0x0600064E RID: 1614
		[Token(Token = "0x600064E")]
		public abstract IEnumerable<int> GetAllItemIds([Optional] IEnumerable<int> rootIds);

		// Token: 0x0600064F RID: 1615
		[Token(Token = "0x600064F")]
		public abstract int GetParentId(int id);

		// Token: 0x06000650 RID: 1616
		[Token(Token = "0x6000650")]
		public abstract IEnumerable<int> GetChildrenIds(int id);

		// Token: 0x06000651 RID: 1617
		[Token(Token = "0x6000651")]
		public abstract void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true);

		// Token: 0x06000652 RID: 1618 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x5A92EC0", Offset = "0x5A91AC0", VA = "0x185A92EC0", Slot = "20")]
		public virtual bool HasChildren(int id)
		{
			return default(bool);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5A92E10", Offset = "0x5A91A10", VA = "0x185A92E10")]
		public bool HasChildrenByIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5A92CD0", Offset = "0x5A918D0", VA = "0x185A92CD0")]
		public IEnumerable<int> GetChildrenIdsByIndex(int index)
		{
			return null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5A92B00", Offset = "0x5A91700", VA = "0x185A92B00")]
		public int GetChildIndexForId(int id)
		{
			return 0;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x5A92D80", Offset = "0x5A91980", VA = "0x185A92D80")]
		public int GetIndentationDepth(int id)
		{
			return 0;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x5A93040", Offset = "0x5A91C40", VA = "0x185A93040")]
		public bool IsExpanded(int id)
		{
			return default(bool);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x5A92F40", Offset = "0x5A91B40", VA = "0x185A92F40")]
		public bool IsExpandedByIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5A91E70", Offset = "0x5A90A70", VA = "0x185A91E70")]
		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5A92930", Offset = "0x5A91530", VA = "0x185A92930")]
		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x5A934C0", Offset = "0x5A920C0", VA = "0x185A934C0")]
		internal void RegenerateWrappers()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x5A919A0", Offset = "0x5A905A0", VA = "0x185A919A0")]
		private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x5A930B0", Offset = "0x5A91CB0", VA = "0x185A930B0")]
		private bool IsIndexValid(int index)
		{
			return default(bool);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x5A8CD40", Offset = "0x5A8B940", VA = "0x185A8CD40")]
		internal void RaiseItemParentChanged(int id, int newParentId)
		{
		}

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, TreeItem> m_TreeItems;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> m_RootIndices;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<TreeViewItemWrapper> m_ItemWrappers;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HashSet<int> m_TreeItemIdsWithItemWrappers;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<TreeViewItemWrapper> m_WrapperInsertionList;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker K_ExpandItemByIndex;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker k_CreateWrappers;
	}
}
