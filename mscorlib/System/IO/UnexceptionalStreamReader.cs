using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000688 RID: 1672
	[Token(Token = "0x2000688")]
	internal class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x4CA2E30", Offset = "0x4CA1A30", VA = "0x184CA2E30")]
		public UnexceptionalStreamReader(Stream stream, System.Text.Encoding encoding)
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0001B360 File Offset: 0x00019560
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x4C924F0", Offset = "0x4C910F0", VA = "0x184C924F0", Slot = "9")]
		public override int Peek()
		{
			return 0;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0001B378 File Offset: 0x00019578
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x4CA2D60", Offset = "0x4CA1960", VA = "0x184CA2D60", Slot = "10")]
		public override int Read()
		{
			return 0;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x4CA2AE0", Offset = "0x4CA16E0", VA = "0x184CA2AE0", Slot = "11")]
		public override int Read([System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] char[] dest_buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x4CA28C0", Offset = "0x4CA14C0", VA = "0x184CA28C0")]
		private bool CheckEOL(char current)
		{
			return default(bool);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x4CA2AA0", Offset = "0x4CA16A0", VA = "0x184CA2AA0", Slot = "14")]
		public override string ReadLine()
		{
			return null;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x4CA2AC0", Offset = "0x4CA16C0", VA = "0x184CA2AC0", Slot = "13")]
		public override string ReadToEnd()
		{
			return null;
		}

		// Token: 0x04001BE7 RID: 7143
		[Token(Token = "0x4001BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool[] newline;

		// Token: 0x04001BE8 RID: 7144
		[Token(Token = "0x4001BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static char newlineChar;
	}
}
