using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> where T : struct, IConvertible
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170003CC")]
		public T value
		{
			[Token(Token = "0x6000FA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00008658 File Offset: 0x00006858
		[Token(Token = "0x170003CD")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FA9")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAA")]
		public StyleEnum(T v)
		{
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAB")]
		public StyleEnum(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAC")]
		internal StyleEnum(T v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6000FAD")]
		public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x6000FAE")]
		public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x6000FAF")]
		public static implicit operator StyleEnum<T>(StyleKeyword keyword)
		{
			return default(StyleEnum<T>);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x6000FB0")]
		public static implicit operator StyleEnum<T>(T v)
		{
			return default(StyleEnum<T>);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x6000FB1")]
		public bool Equals(StyleEnum<T> other)
		{
			return default(bool);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x6000FB2")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x6000FB3")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FB4")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x0")]
		private T m_Value;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x0")]
		private StyleKeyword m_Keyword;
	}
}
