using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200067C RID: 1660
	[Token(Token = "0x200067C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class StringReader : TextReader
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326C")]
		[Address(RVA = "0x4CA1440", Offset = "0x4CA0040", VA = "0x184CA1440")]
		public StringReader(string s)
		{
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326D")]
		[Address(RVA = "0x4B6A320", Offset = "0x4B68F20", VA = "0x184B6A320", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x4CA0F20", Offset = "0x4C9FB20", VA = "0x184CA0F20", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x0001B030 File Offset: 0x00019230
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x4CA0F70", Offset = "0x4C9FB70", VA = "0x184CA0F70", Slot = "9")]
		public override int Peek()
		{
			return 0;
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x0001B048 File Offset: 0x00019248
		[Token(Token = "0x6003270")]
		[Address(RVA = "0x4CA13F0", Offset = "0x4C9FFF0", VA = "0x184CA13F0", Slot = "10")]
		public override int Read()
		{
			return 0;
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0001B060 File Offset: 0x00019260
		[Token(Token = "0x6003271")]
		[Address(RVA = "0x4CA1190", Offset = "0x4C9FD90", VA = "0x184CA1190", Slot = "11")]
		public override int Read([System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] char[] buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003272")]
		[Address(RVA = "0x4CA1140", Offset = "0x4C9FD40", VA = "0x184CA1140", Slot = "13")]
		public override string ReadToEnd()
		{
			return null;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003273")]
		[Address(RVA = "0x4CA0FC0", Offset = "0x4C9FBC0", VA = "0x184CA0FC0", Slot = "14")]
		public override string ReadLine()
		{
			return null;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003274")]
		[Address(RVA = "0x4CA10B0", Offset = "0x4C9FCB0", VA = "0x184CA10B0", Slot = "15")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.Threading.Tasks.Task<string> ReadToEndAsync()
		{
			return null;
		}

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _s;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _pos;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _length;
	}
}
