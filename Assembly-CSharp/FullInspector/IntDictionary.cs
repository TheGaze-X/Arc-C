using System;
using System.Collections;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BC3 RID: 31683
	[Token(Token = "0x2007BC3")]
	internal class IntDictionary<TValue> : IDictionary<int, TValue>, ICollection<KeyValuePair<int, TValue>>, IEnumerable<KeyValuePair<int, TValue>>, IEnumerable
	{
		// Token: 0x0602C576 RID: 181622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C576")]
		public void Add(int key, TValue value)
		{
		}

		// Token: 0x0602C577 RID: 181623 RVA: 0x000DF9E0 File Offset: 0x000DDBE0
		[Token(Token = "0x602C577")]
		public bool ContainsKey(int key)
		{
			return default(bool);
		}

		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x0602C578 RID: 181624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067C9")]
		public ICollection<int> Keys
		{
			[Token(Token = "0x602C578")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C579 RID: 181625 RVA: 0x000DF9F8 File Offset: 0x000DDBF8
		[Token(Token = "0x602C579")]
		public bool Remove(int key)
		{
			return default(bool);
		}

		// Token: 0x0602C57A RID: 181626 RVA: 0x000DFA10 File Offset: 0x000DDC10
		[Token(Token = "0x602C57A")]
		public bool TryGetValue(int key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x0602C57B RID: 181627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067CA")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x602C57B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067CB RID: 26571
		[Token(Token = "0x170067CB")]
		public TValue this[int key]
		{
			[Token(Token = "0x602C57C")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C57D")]
			set
			{
			}
		}

		// Token: 0x0602C57E RID: 181630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C57E")]
		public void Add(KeyValuePair<int, TValue> item)
		{
		}

		// Token: 0x0602C57F RID: 181631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C57F")]
		public void Clear()
		{
		}

		// Token: 0x0602C580 RID: 181632 RVA: 0x000DFA28 File Offset: 0x000DDC28
		[Token(Token = "0x602C580")]
		public bool Contains(KeyValuePair<int, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0602C581 RID: 181633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C581")]
		public void CopyTo(KeyValuePair<int, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x0602C582 RID: 181634 RVA: 0x000DFA40 File Offset: 0x000DDC40
		[Token(Token = "0x170067CC")]
		public int Count
		{
			[Token(Token = "0x602C582")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x0602C583 RID: 181635 RVA: 0x000DFA58 File Offset: 0x000DDC58
		[Token(Token = "0x170067CD")]
		public bool IsReadOnly
		{
			[Token(Token = "0x602C583")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C584 RID: 181636 RVA: 0x000DFA70 File Offset: 0x000DDC70
		[Token(Token = "0x602C584")]
		public bool Remove(KeyValuePair<int, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0602C585 RID: 181637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C585")]
		public IEnumerator<KeyValuePair<int, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0602C586 RID: 181638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C586")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0602C587 RID: 181639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C587")]
		public IntDictionary()
		{
		}

		// Token: 0x0404021E RID: 262686
		[Token(Token = "0x404021E")]
		[FieldOffset(Offset = "0x0")]
		private List<fiOption<TValue>> _positives;

		// Token: 0x0404021F RID: 262687
		[Token(Token = "0x404021F")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, TValue> _negatives;
	}
}
