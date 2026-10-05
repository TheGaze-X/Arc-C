using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[DefaultMember("Item")]
	internal struct ArrayBuilder<T>
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DA")]
		public ArrayBuilder(int capacity)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DC")]
		public void UncheckedAdd(T item)
		{
		}

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
