using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	[DefaultMember("Item")]
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x511B060", Offset = "0x5119C60", VA = "0x18511B060")]
		internal TraceListenerCollection()
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x17000112")]
		public int Count
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x511A1F0", Offset = "0x5118DF0", VA = "0x18511A1F0")]
		public int Add(TraceListener listener)
		{
			return 0;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x511A320", Offset = "0x5118F20", VA = "0x18511A320", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x4A88790", Offset = "0x4A87390", VA = "0x184A88790", Slot = "19")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x511A390", Offset = "0x5118F90", VA = "0x18511A390")]
		internal void InitializeListener(TraceListener listener)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x511A4E0", Offset = "0x51190E0", VA = "0x18511A4E0", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000113")]
		private object Item
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x511ADE0", Offset = "0x51199E0", VA = "0x18511ADE0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x511AE30", Offset = "0x5119A30", VA = "0x18511AE30", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x17000114")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x17000115")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x511A710", Offset = "0x5119310", VA = "0x18511A710", Slot = "6")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x4C5BC40", Offset = "0x4C5A840", VA = "0x184C5BC40", Slot = "7")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x4C5BCA0", Offset = "0x4C5A8A0", VA = "0x184C5BCA0", Slot = "11")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x511A9F0", Offset = "0x51195F0", VA = "0x18511A9F0", Slot = "12")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x511ACD0", Offset = "0x51198D0", VA = "0x18511ACD0", Slot = "13")]
		private void Remove(object value)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000116")]
		private object SyncRoot
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x17000117")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x511A5F0", Offset = "0x51191F0", VA = "0x18511A5F0", Slot = "15")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList list;
	}
}
