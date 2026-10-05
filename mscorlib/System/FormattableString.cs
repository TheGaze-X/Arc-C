using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public abstract class FormattableString : System.IFormattable
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000712 RID: 1810
		[Token(Token = "0x1700008F")]
		public abstract string Format { [Token(Token = "0x6000712")] get; }

		// Token: 0x06000713 RID: 1811
		[Token(Token = "0x6000713")]
		public abstract object[] GetArguments();

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000714 RID: 1812
		[Token(Token = "0x17000090")]
		public abstract int ArgumentCount { [Token(Token = "0x6000714")] get; }

		// Token: 0x06000715 RID: 1813
		[Token(Token = "0x6000715")]
		public abstract object GetArgument(int index);

		// Token: 0x06000716 RID: 1814
		[Token(Token = "0x6000716")]
		public abstract string ToString(System.IFormatProvider formatProvider);

		// Token: 0x06000717 RID: 1815 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x4CC4B10", Offset = "0x4CC3710", VA = "0x184CC4B10", Slot = "4")]
		private string ToString(string ignored, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x4CC4B60", Offset = "0x4CC3760", VA = "0x184CC4B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected FormattableString()
		{
		}
	}
}
