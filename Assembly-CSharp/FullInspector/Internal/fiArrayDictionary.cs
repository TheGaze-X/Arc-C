using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CAF RID: 31919
	[Token(Token = "0x2007CAF")]
	public class fiArrayDictionary<TKey, TValue>
	{
		// Token: 0x1700685D RID: 26717
		[Token(Token = "0x1700685D")]
		public TKey this[TKey key]
		{
			[Token(Token = "0x602C95B")]
			set
			{
			}
		}

		// Token: 0x0602C95C RID: 182620 RVA: 0x000E0FA0 File Offset: 0x000DF1A0
		[Token(Token = "0x602C95C")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0602C95D RID: 182621 RVA: 0x000E0FB8 File Offset: 0x000DF1B8
		[Token(Token = "0x602C95D")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0602C95E RID: 182622 RVA: 0x000E0FD0 File Offset: 0x000DF1D0
		[Token(Token = "0x602C95E")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0602C95F RID: 182623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C95F")]
		public fiArrayDictionary()
		{
		}

		// Token: 0x040403DA RID: 263130
		[Token(Token = "0x40403DA")]
		[FieldOffset(Offset = "0x0")]
		private List<KeyValuePair<TKey, TValue>> _elements;
	}
}
