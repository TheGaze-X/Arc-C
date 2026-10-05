using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public abstract class NumberHashSet<TNumber> : Dictionary<TNumber, object> where TNumber : struct
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x60004BB")]
		public bool Contains(TNumber target)
		{
			return default(bool);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x60004BC")]
		public bool Add(TNumber target)
		{
			return default(bool);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x60004BD")]
		public new NumberHashSet<TNumber>.SetEnumerator GetEnumerator()
		{
			return default(NumberHashSet<TNumber>.SetEnumerator);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004BE")]
		protected NumberHashSet()
		{
		}

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		public struct SetEnumerator : IDisposable
		{
			// Token: 0x060004BF RID: 1215 RVA: 0x000056CC File Offset: 0x000038CC
			[Token(Token = "0x60004BF")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000061")]
			public TNumber Current
			{
				[Token(Token = "0x60004C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60004C1")]
			public void Dispose()
			{
			}

			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			[FieldOffset(Offset = "0x0")]
			public Dictionary<TNumber, object>.Enumerator dictEnum;
		}
	}
}
