using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class StringWriter : TextWriter
	{
		// Token: 0x06003275 RID: 12917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x4CA1890", Offset = "0x4CA0490", VA = "0x184CA1890")]
		public StringWriter()
		{
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003276")]
		[Address(RVA = "0x4CA1A70", Offset = "0x4CA0670", VA = "0x184CA1A70")]
		public StringWriter(System.IFormatProvider formatProvider)
		{
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003277")]
		[Address(RVA = "0x4CA1B30", Offset = "0x4CA0730", VA = "0x184CA1B30")]
		public StringWriter(System.Text.StringBuilder sb)
		{
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003278")]
		[Address(RVA = "0x4CA1980", Offset = "0x4CA0580", VA = "0x184CA1980")]
		public StringWriter(System.Text.StringBuilder sb, System.IFormatProvider formatProvider)
		{
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003279")]
		[Address(RVA = "0x4CA1510", Offset = "0x4CA0110", VA = "0x184CA1510", Slot = "8")]
		public override void Close()
		{
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327A")]
		[Address(RVA = "0x4CA1550", Offset = "0x4CA0150", VA = "0x184CA1550", Slot = "9")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000814")]
		public override System.Text.Encoding Encoding
		{
			[Token(Token = "0x600327B")]
			[Address(RVA = "0x4CA1C60", Offset = "0x4CA0860", VA = "0x184CA1C60", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327C")]
		[Address(RVA = "0x4CA1840", Offset = "0x4CA0440", VA = "0x184CA1840", Slot = "13")]
		public override void Write(char value)
		{
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x4CA15B0", Offset = "0x4CA01B0", VA = "0x184CA15B0", Slot = "15")]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x4CA17F0", Offset = "0x4CA03F0", VA = "0x184CA17F0", Slot = "17")]
		public override void Write(string value)
		{
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x4CA1560", Offset = "0x4CA0160", VA = "0x184CA1560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Text.UnicodeEncoding m_encoding;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Text.StringBuilder _sb;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isOpen;
	}
}
