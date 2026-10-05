using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	internal struct SparselyPopulatedArrayAddInfo<T> where T : class
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121B")]
		internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001AE")]
		internal SparselyPopulatedArrayFragment<T> Source
		{
			[Token(Token = "0x600121C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x170001AF")]
		internal int Index
		{
			[Token(Token = "0x600121D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x0")]
		private SparselyPopulatedArrayFragment<T> _source;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x0")]
		private int _index;
	}
}
