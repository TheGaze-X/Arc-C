using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	public static class FormattableStringFactory
	{
		// Token: 0x060022CF RID: 8911 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x4BD5620", Offset = "0x4BD4220", VA = "0x184BD5620")]
		public static System.FormattableString Create(string format, params object[] arguments)
		{
			return null;
		}

		// Token: 0x02000497 RID: 1175
		[Token(Token = "0x2000497")]
		private sealed class ConcreteFormattableString : System.FormattableString
		{
			// Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
			internal ConcreteFormattableString(string format, object[] arguments)
			{
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700047A")]
			public override string Format
			{
				[Token(Token = "0x60022D1")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x060022D2 RID: 8914 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			public override object[] GetArguments()
			{
				return null;
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x060022D3 RID: 8915 RVA: 0x00013FB0 File Offset: 0x000121B0
			[Token(Token = "0x1700047B")]
			public override int ArgumentCount
			{
				[Token(Token = "0x60022D3")]
				[Address(RVA = "0x4BA9410", Offset = "0x4BA8010", VA = "0x184BA9410", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0x4BA9170", Offset = "0x4BA7D70", VA = "0x184BA9170", Slot = "8")]
			public override object GetArgument(int index)
			{
				return null;
			}

			// Token: 0x060022D5 RID: 8917 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60022D5")]
			[Address(RVA = "0x4BD1000", Offset = "0x4BCFC00", VA = "0x184BD1000", Slot = "9")]
			public override string ToString(System.IFormatProvider formatProvider)
			{
				return null;
			}

			// Token: 0x040013DF RID: 5087
			[Token(Token = "0x40013DF")]
			[FieldOffset(Offset = "0x10")]
			private readonly string _format;

			// Token: 0x040013E0 RID: 5088
			[Token(Token = "0x40013E0")]
			[FieldOffset(Offset = "0x18")]
			private readonly object[] _arguments;
		}
	}
}
