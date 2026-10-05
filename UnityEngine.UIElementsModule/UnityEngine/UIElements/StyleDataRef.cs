using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> where T : struct, IEquatable<T>, IStyleDataGroup<T>
	{
		// Token: 0x06000F98 RID: 3992 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6000F98")]
		public StyleDataRef<T> Acquire()
		{
			return default(StyleDataRef<T>);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F99")]
		public void Release()
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9A")]
		public void CopyFrom(StyleDataRef<T> other)
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F9B")]
		public ref T Read()
		{
			return null;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F9C")]
		public ref T Write()
		{
			return null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6000F9D")]
		public static StyleDataRef<T> Create()
		{
			return default(StyleDataRef<T>);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x6000F9E")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6000F9F")]
		public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x6000FA0")]
		public bool Equals(StyleDataRef<T> other)
		{
			return default(bool);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x6000FA1")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x0")]
		private StyleDataRef<T>.RefCounted m_Ref;

		// Token: 0x0200022E RID: 558
		[Token(Token = "0x200022E")]
		private class RefCounted
		{
			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00008640 File Offset: 0x00006840
			[Token(Token = "0x170003CB")]
			public int refCount
			{
				[Token(Token = "0x6000FA2")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FA3")]
			public RefCounted()
			{
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FA4")]
			public void Acquire()
			{
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FA5")]
			public void Release()
			{
			}

			// Token: 0x06000FA6 RID: 4006 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000FA6")]
			public StyleDataRef<T>.RefCounted Copy()
			{
				return null;
			}

			// Token: 0x04000812 RID: 2066
			[Token(Token = "0x4000812")]
			[FieldOffset(Offset = "0x0")]
			private static uint m_NextId;

			// Token: 0x04000813 RID: 2067
			[Token(Token = "0x4000813")]
			[FieldOffset(Offset = "0x0")]
			private int m_RefCount;

			// Token: 0x04000814 RID: 2068
			[Token(Token = "0x4000814")]
			[FieldOffset(Offset = "0x0")]
			private readonly uint m_Id;

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x0")]
			public T value;
		}
	}
}
