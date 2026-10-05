using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	internal class CStreamReader : StreamReader
	{
		// Token: 0x06003319 RID: 13081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x4C927A0", Offset = "0x4C913A0", VA = "0x184C927A0")]
		public CStreamReader(Stream stream, System.Text.Encoding encoding)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x4C924F0", Offset = "0x4C910F0", VA = "0x184C924F0", Slot = "9")]
		public override int Peek()
		{
			return 0;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x4C92570", Offset = "0x4C91170", VA = "0x184C92570", Slot = "10")]
		public override int Read()
		{
			return 0;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x4C925D0", Offset = "0x4C911D0", VA = "0x184C925D0", Slot = "11")]
		public override int Read([System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] char[] dest, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x4C92510", Offset = "0x4C91110", VA = "0x184C92510", Slot = "14")]
		public override string ReadLine()
		{
			return null;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x4C92540", Offset = "0x4C91140", VA = "0x184C92540", Slot = "13")]
		public override string ReadToEnd()
		{
			return null;
		}

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TermInfoDriver driver;
	}
}
