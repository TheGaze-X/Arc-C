using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2000579")]
	public class ShallowEqualArray<T>
	{
		// Token: 0x06005BB2 RID: 23474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB2")]
		public ShallowEqualArray(T[] array)
		{
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06005BB3 RID: 23475 RVA: 0x0002EF08 File Offset: 0x0002D108
		[Token(Token = "0x17000CB3")]
		public int length
		{
			[Token(Token = "0x6005BB3")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		[Token(Token = "0x17000CB4")]
		public T this[int index]
		{
			[Token(Token = "0x6005BB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BB5")]
			set
			{
			}
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB6")]
		public static implicit operator T[](ShallowEqualArray<T> ary)
		{
			return null;
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB7")]
		public static implicit operator ShallowEqualArray<T>(T[] content)
		{
			return null;
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB8")]
		public ShallowEqualArray<T> Clone()
		{
			return null;
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x0002EF20 File Offset: 0x0002D120
		[Token(Token = "0x6005BB9")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x0002EF38 File Offset: 0x0002D138
		[Token(Token = "0x6005BBA")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x0")]
		private T[] m_content;
	}
}
