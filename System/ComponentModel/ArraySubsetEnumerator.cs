using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	internal class ArraySubsetEnumerator : IEnumerator
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x51395C0", Offset = "0x51381C0", VA = "0x1851395C0")]
		public ArraySubsetEnumerator(Array array, int count)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x51395A0", Offset = "0x51381A0", VA = "0x1851395A0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x504A5E0", Offset = "0x50491E0", VA = "0x18504A5E0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		public object Current
		{
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x51565A0", Offset = "0x51551A0", VA = "0x1851565A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x10")]
		private Array array;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x18")]
		private int total;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x1C")]
		private int current;
	}
}
