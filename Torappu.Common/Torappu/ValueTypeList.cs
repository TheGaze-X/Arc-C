using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public class ValueTypeList<T> : BaseValueTypeList<StructWrapper<T>> where T : struct
	{
		// Token: 0x17000065 RID: 101
		[Token(Token = "0x17000065")]
		public T this[int index]
		{
			[Token(Token = "0x6000527")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			set
			{
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000529")]
		public void Add(T item)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x600052A")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x600052B")]
		public ValueTypeList<T>.Enumerator GetEnumerator()
		{
			return default(ValueTypeList<T>.Enumerator);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x600052C")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600052D")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x600052E")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600052F")]
		public void Sort(Comparison<T> comparison)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000530")]
		protected override Comparison<StructWrapper<T>> CreateComparison()
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000531")]
		public ValueTypeList()
		{
		}

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x0")]
		private Comparison<T> m_comparison;

		// Token: 0x020000D8 RID: 216
		[Token(Token = "0x20000D8")]
		public struct Enumerator
		{
			// Token: 0x06000533 RID: 1331 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000533")]
			public Enumerator(List<StructWrapper<T>>.Enumerator rawEnumerator)
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000066")]
			public T Current
			{
				[Token(Token = "0x6000534")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00005A74 File Offset: 0x00003C74
			[Token(Token = "0x6000535")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40004EB")]
			[FieldOffset(Offset = "0x0")]
			private List<StructWrapper<T>>.Enumerator m_rawEnumerator;
		}
	}
}
