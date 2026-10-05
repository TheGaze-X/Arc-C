using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	internal class Set<TElement>
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		public Set(IEqualityComparer<TElement> comparer)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000138")]
		public bool Add(TElement value)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000139")]
		private bool Find(TElement value, bool add)
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013A")]
		private void Resize()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600013B")]
		internal int InternalGetHashCode(TElement value)
		{
			return 0;
		}

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		private int[] buckets;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x0")]
		private Set<TElement>.Slot[] slots;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		private int freeList;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TElement> comparer;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		internal struct Slot
		{
			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x0")]
			internal TElement value;

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x0")]
			internal int next;
		}
	}
}
