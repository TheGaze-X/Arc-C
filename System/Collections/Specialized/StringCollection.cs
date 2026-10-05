using System;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x1700033D RID: 829
		[Token(Token = "0x1700033D")]
		public string this[int index]
		{
			[Token(Token = "0x6001000")]
			[Address(RVA = "0x51891F0", Offset = "0x5187DF0", VA = "0x1851891F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001001")]
			[Address(RVA = "0x51893B0", Offset = "0x5187FB0", VA = "0x1851893B0")]
			set
			{
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x1700033E")]
		public int Count
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x1700033F")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6001003")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x17000340")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6001004")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x5188D60", Offset = "0x5187960", VA = "0x185188D60")]
		public int Add(string value)
		{
			return 0;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x512E8E0", Offset = "0x512D4E0", VA = "0x18512E8E0", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x4C5BC40", Offset = "0x4C5A840", VA = "0x184C5BC40")]
		public bool Contains(string value)
		{
			return default(bool);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x4C5B9D0", Offset = "0x4C5A5D0", VA = "0x184C5B9D0")]
		public void CopyTo(string[] array, int index)
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x4C5BCA0", Offset = "0x4C5A8A0", VA = "0x184C5BCA0")]
		public int IndexOf(string value)
		{
			return 0;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x5188DC0", Offset = "0x51879C0", VA = "0x185188DC0")]
		public void Insert(int index, string value)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x17000341")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x5188E70", Offset = "0x5187A70", VA = "0x185188E70")]
		public void Remove(string value)
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x5188E20", Offset = "0x5187A20", VA = "0x185188E20", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000342")]
		public object SyncRoot
		{
			[Token(Token = "0x600100E")]
			[Address(RVA = "0x4C5BA80", Offset = "0x4C5A680", VA = "0x184C5BA80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000343")]
		private object Item
		{
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x51891F0", Offset = "0x5187DF0", VA = "0x1851891F0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x5189290", Offset = "0x5187E90", VA = "0x185189290", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x5188EC0", Offset = "0x5187AC0", VA = "0x185188EC0", Slot = "6")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x5188F60", Offset = "0x5187B60", VA = "0x185188F60", Slot = "7")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x5189000", Offset = "0x5187C00", VA = "0x185189000", Slot = "11")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x51890A0", Offset = "0x5187CA0", VA = "0x1851890A0", Slot = "12")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x5189150", Offset = "0x5187D50", VA = "0x185189150", Slot = "13")]
		private void Remove(object value)
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x4C5B9D0", Offset = "0x4C5A5D0", VA = "0x184C5B9D0", Slot = "15")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x4A88790", Offset = "0x4A87390", VA = "0x184A88790", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x5189340", Offset = "0x5187F40", VA = "0x185189340")]
		public StringCollection()
		{
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x10")]
		private readonly ArrayList data;
	}
}
