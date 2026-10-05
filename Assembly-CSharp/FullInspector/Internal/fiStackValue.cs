using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CAA RID: 31914
	[Token(Token = "0x2007CAA")]
	public class fiStackValue<T>
	{
		// Token: 0x0602C938 RID: 182584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C938")]
		public void Push(T value)
		{
		}

		// Token: 0x0602C939 RID: 182585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C939")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x17006852 RID: 26706
		// (get) Token: 0x0602C93A RID: 182586 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C93B RID: 182587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006852")]
		public T Value
		{
			[Token(Token = "0x602C93A")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C93B")]
			set
			{
			}
		}

		// Token: 0x0602C93C RID: 182588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C93C")]
		public fiStackValue()
		{
		}

		// Token: 0x040403D1 RID: 263121
		[Token(Token = "0x40403D1")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> _stack;
	}
}
