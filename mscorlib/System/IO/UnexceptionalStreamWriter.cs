using System;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	internal class UnexceptionalStreamWriter : StreamWriter
	{
		// Token: 0x06003313 RID: 13075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x4CA2F40", Offset = "0x4CA1B40", VA = "0x184CA2F40")]
		public UnexceptionalStreamWriter(Stream stream, System.Text.Encoding encoding)
		{
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x4CA2EA0", Offset = "0x4CA1AA0", VA = "0x184CA2EA0", Slot = "10")]
		public override void Flush()
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x4CA2F00", Offset = "0x4CA1B00", VA = "0x184CA2F00", Slot = "15")]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x4CA2EC0", Offset = "0x4CA1AC0", VA = "0x184CA2EC0", Slot = "13")]
		public override void Write(char value)
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x4CA2F20", Offset = "0x4CA1B20", VA = "0x184CA2F20", Slot = "14")]
		public override void Write(char[] value)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x4CA2EE0", Offset = "0x4CA1AE0", VA = "0x184CA2EE0", Slot = "17")]
		public override void Write(string value)
		{
		}
	}
}
