using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007C57 RID: 31831
	[Token(Token = "0x2007C57")]
	public class TypeSpecifier<TBaseType>
	{
		// Token: 0x0602C7E3 RID: 182243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7E3")]
		public TypeSpecifier()
		{
		}

		// Token: 0x0602C7E4 RID: 182244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7E4")]
		public TypeSpecifier(Type type)
		{
		}

		// Token: 0x0602C7E5 RID: 182245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7E5")]
		public static implicit operator Type(TypeSpecifier<TBaseType> specifier)
		{
			return null;
		}

		// Token: 0x0602C7E6 RID: 182246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7E6")]
		public static implicit operator TypeSpecifier<TBaseType>(Type type)
		{
			return null;
		}

		// Token: 0x0602C7E7 RID: 182247 RVA: 0x000E0538 File Offset: 0x000DE738
		[Token(Token = "0x602C7E7")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0602C7E8 RID: 182248 RVA: 0x000E0550 File Offset: 0x000DE750
		[Token(Token = "0x602C7E8")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04040328 RID: 262952
		[Token(Token = "0x4040328")]
		[FieldOffset(Offset = "0x0")]
		public Type Type;
	}
}
