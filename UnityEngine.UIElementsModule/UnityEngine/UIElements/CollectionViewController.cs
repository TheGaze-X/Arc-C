using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	internal class CollectionViewController
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public event Action itemsSourceChanged
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x5A8CEE0", Offset = "0x5A8BAE0", VA = "0x185A8CEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x5A8D030", Offset = "0x5A8BC30", VA = "0x185A8D030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		public event Action<int, int> itemIndexChanged
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x5A8CE30", Offset = "0x5A8BA30", VA = "0x185A8CE30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x5A8CF80", Offset = "0x5A8BB80", VA = "0x185A8CF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public IList itemsSource
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x5A8D0D0", Offset = "0x5A8BCD0", VA = "0x185A8D0D0")]
			set
			{
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
		protected void SetItemsSourceWithoutNotify(IList source)
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000152")]
		protected BaseVerticalCollectionView view
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x5A8CD60", Offset = "0x5A8B960", VA = "0x185A8CD60")]
		public void SetView(BaseVerticalCollectionView view)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x5A8C9B0", Offset = "0x5A8B5B0", VA = "0x185A8C9B0", Slot = "4")]
		public virtual int GetItemsCount()
		{
			return 0;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x5A8C910", Offset = "0x5A8B510", VA = "0x185A8C910", Slot = "5")]
		public virtual int GetIndexForId(int id)
		{
			return 0;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x5A8C8D0", Offset = "0x5A8B4D0", VA = "0x185A8C8D0", Slot = "6")]
		public virtual int GetIdForIndex(int index)
		{
			return 0;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5A8C920", Offset = "0x5A8B520", VA = "0x185A8C920", Slot = "7")]
		public virtual object GetItemForIndex(int index)
		{
			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5A8CB80", Offset = "0x5A8B780", VA = "0x185A8CB80", Slot = "8")]
		internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x5A8CA00", Offset = "0x5A8B600", VA = "0x185A8CA00", Slot = "9")]
		internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x5A8CC00", Offset = "0x5A8B800", VA = "0x185A8CC00", Slot = "10")]
		internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x5A8CB30", Offset = "0x5A8B730", VA = "0x185A8CB30", Slot = "11")]
		internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5A8CC60", Offset = "0x5A8B860", VA = "0x185A8CC60", Slot = "12")]
		public virtual VisualElement MakeItem()
		{
			return null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x5A8C6B0", Offset = "0x5A8B2B0", VA = "0x185A8C6B0", Slot = "13")]
		protected virtual void BindItem(VisualElement element, int index)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x5A8CDF0", Offset = "0x5A8B9F0", VA = "0x185A8CDF0", Slot = "14")]
		public virtual void UnbindItem(VisualElement element, int index)
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x5A8C890", Offset = "0x5A8B490", VA = "0x185A8C890", Slot = "15")]
		public virtual void DestroyItem(VisualElement element)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x5134F0", Offset = "0x5120F0", VA = "0x1805134F0")]
		protected void RaiseItemsSourceChanged()
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x5A8CD40", Offset = "0x5A8B940", VA = "0x185A8CD40")]
		protected void RaiseItemIndexChanged(int srcIndex, int dstIndex)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CollectionViewController()
		{
		}

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x10")]
		private BaseVerticalCollectionView m_View;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x18")]
		private IList m_ItemsSource;
	}
}
