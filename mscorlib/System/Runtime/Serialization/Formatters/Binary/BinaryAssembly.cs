using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	internal sealed class BinaryAssembly
	{
		// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryAssembly()
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x4B93D10", Offset = "0x4B92910", VA = "0x184B93D10")]
		internal void Set(int assemId, string assemblyString)
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x4B93D30", Offset = "0x4B92930", VA = "0x184B93D30", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x4B93CC0", Offset = "0x4B928C0", VA = "0x184B93CC0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x10")]
		internal int assemId;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x18")]
		internal string assemblyString;
	}
}
