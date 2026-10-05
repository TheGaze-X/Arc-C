using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	internal class ListViewController : CollectionViewController
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event Action itemsSourceSizeChanged
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x5A8EDE0", Offset = "0x5A8D9E0", VA = "0x185A8EDE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x5A8F090", Offset = "0x5A8DC90", VA = "0x185A8F090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event Action<IEnumerable<int>> itemsAdded
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x5A8EC80", Offset = "0x5A8D880", VA = "0x185A8EC80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x5A8EF30", Offset = "0x5A8DB30", VA = "0x185A8EF30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		public event Action<IEnumerable<int>> itemsRemoved
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x5A8ED30", Offset = "0x5A8D930", VA = "0x185A8ED30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x5A8EFE0", Offset = "0x5A8DBE0", VA = "0x185A8EFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000153")]
		private ListView listView
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x5A8EE80", Offset = "0x5A8DA80", VA = "0x185A8EE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5A8DD50", Offset = "0x5A8C950", VA = "0x185A8DD50", Slot = "8")]
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x5A8DB30", Offset = "0x5A8C730", VA = "0x185A8DB30", Slot = "9")]
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470", Slot = "16")]
		public virtual bool NeedsDragHandle(int index)
		{
			return default(bool);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x5A8D200", Offset = "0x5A8BE00", VA = "0x185A8D200", Slot = "17")]
		public virtual void AddItems(int itemCount)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x5A8E150", Offset = "0x5A8CD50", VA = "0x185A8E150", Slot = "18")]
		public virtual void Move(int index, int newIndex)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x5A8E4A0", Offset = "0x5A8D0A0", VA = "0x185A8E4A0", Slot = "19")]
		public virtual void RemoveItem(int index)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5A8E640", Offset = "0x5A8D240", VA = "0x185A8E640", Slot = "20")]
		public virtual void RemoveItems(List<int> indices)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x5A8E8C0", Offset = "0x5A8D4C0", VA = "0x185A8E8C0", Slot = "21")]
		internal virtual void RemoveItems(int itemCount)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000642")]
		[Address(RVA = "0xEEE3D0", Offset = "0xEECFD0", VA = "0x180EEE3D0")]
		protected void RaiseOnSizeChanged()
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x312CB60", Offset = "0x312B760", VA = "0x18312CB60")]
		protected void RaiseItemsAdded(IEnumerable<int> indices)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2585D60", Offset = "0x2584960", VA = "0x182585D60")]
		protected void RaiseItemsRemoved(IEnumerable<int> indices)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x5A8D960", Offset = "0x5A8C560", VA = "0x185A8D960")]
		private static Array AddToArray(Array source, int itemCount)
		{
			return null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x5A8E2E0", Offset = "0x5A8CEE0", VA = "0x185A8E2E0")]
		private static Array RemoveFromArray(Array source, List<int> indicesToRemove)
		{
			return null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x5A8EAC0", Offset = "0x5A8D6C0", VA = "0x185A8EAC0")]
		private void Swap(int lhs, int rhs)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x5A8DA60", Offset = "0x5A8C660", VA = "0x185A8DA60")]
		private void EnsureItemSourceCanBeResized()
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ListViewController()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x5A8EBA0", Offset = "0x5A8D7A0", VA = "0x185A8EBA0")]
		[CompilerGenerated]
		internal static bool <AddItems>g__IsGenericList|14_0(Type t)
		{
			return default(bool);
		}
	}
}
