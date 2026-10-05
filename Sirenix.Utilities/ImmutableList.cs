using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[Serializable]
	public sealed class ImmutableList : IImmutableList<object>, IImmutableList, IList, ICollection, IEnumerable, IList<object>, ICollection<object>, IEnumerable<object>
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x4E245B0", Offset = "0x4E231B0", VA = "0x184E245B0")]
		public ImmutableList(IList innerList)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x1700004D")]
		public int Count
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x4E24640", Offset = "0x4E23240", VA = "0x184E24640", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x1700004E")]
		public bool IsFixedSize
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x1700004F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x17000050")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x4E24690", Offset = "0x4E23290", VA = "0x184E24690", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000051")]
		public object SyncRoot
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x4E24740", Offset = "0x4E23340", VA = "0x184E24740", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000052")]
		private object Item
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x4E244F0", Offset = "0x4E230F0", VA = "0x184E244F0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x4E24550", Offset = "0x4E23150", VA = "0x184E24550", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000053")]
		private object Item
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x4E24250", Offset = "0x4E22E50", VA = "0x184E24250", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x4E242B0", Offset = "0x4E22EB0", VA = "0x184E242B0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		[Token(Token = "0x17000054")]
		public object this[int index]
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x4E246E0", Offset = "0x4E232E0", VA = "0x184E246E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4E23CE0", Offset = "0x4E228E0", VA = "0x184E23CE0", Slot = "30")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4E23DD0", Offset = "0x4E229D0", VA = "0x184E23DD0", Slot = "31")]
		public void CopyTo(object[] array, int arrayIndex)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4E23E40", Offset = "0x4E22A40", VA = "0x184E23E40", Slot = "16")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4E23EB0", Offset = "0x4E22AB0", VA = "0x184E23EB0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4E23EB0", Offset = "0x4E22AB0", VA = "0x184E23EB0", Slot = "20")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4E24110", Offset = "0x4E22D10", VA = "0x184E24110", Slot = "33")]
		private IEnumerator<object> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4E24310", Offset = "0x4E22F10", VA = "0x184E24310", Slot = "7")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4E24370", Offset = "0x4E22F70", VA = "0x184E24370", Slot = "9")]
		private void Clear()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4E243D0", Offset = "0x4E22FD0", VA = "0x184E243D0", Slot = "13")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4E24490", Offset = "0x4E23090", VA = "0x184E24490", Slot = "14")]
		private void Remove(object value)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4E24430", Offset = "0x4E23030", VA = "0x184E24430", Slot = "15")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4E23F00", Offset = "0x4E22B00", VA = "0x184E23F00", Slot = "23")]
		public int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4E241F0", Offset = "0x4E22DF0", VA = "0x184E241F0", Slot = "25")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4E24190", Offset = "0x4E22D90", VA = "0x184E24190", Slot = "24")]
		private void Insert(int index, object item)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4E23FF0", Offset = "0x4E22BF0", VA = "0x184E23FF0", Slot = "28")]
		private void Add(object item)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4E24050", Offset = "0x4E22C50", VA = "0x184E24050", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4E240B0", Offset = "0x4E22CB0", VA = "0x184E240B0", Slot = "32")]
		private bool Remove(object item)
		{
			return default(bool);
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IList innerList;
	}
}
