using System;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	internal class CStreamWriter : StreamWriter
	{
		// Token: 0x0600331F RID: 13087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x4C92E60", Offset = "0x4C91A60", VA = "0x184C92E60")]
		public CStreamWriter(Stream stream, System.Text.Encoding encoding, bool leaveOpen)
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x4C92A40", Offset = "0x4C91640", VA = "0x184C92A40", Slot = "15")]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x4C92C70", Offset = "0x4C91870", VA = "0x184C92C70", Slot = "13")]
		public override void Write(char val)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x4C92980", Offset = "0x4C91580", VA = "0x184C92980")]
		public void InternalWriteString(string val)
		{
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x4C92940", Offset = "0x4C91540", VA = "0x184C92940")]
		public void InternalWriteChar(char val)
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x4C92960", Offset = "0x4C91560", VA = "0x184C92960")]
		public void InternalWriteChars(char[] buffer, int n)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x4C92DF0", Offset = "0x4C919F0", VA = "0x184C92DF0", Slot = "14")]
		public override void Write(char[] val)
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x4C92D60", Offset = "0x4C91960", VA = "0x184C92D60", Slot = "17")]
		public override void Write(string val)
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x4C929A0", Offset = "0x4C915A0", VA = "0x184C929A0", Slot = "21")]
		public override void WriteLine(string val)
		{
		}

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x70")]
		private TermInfoDriver driver;
	}
}
