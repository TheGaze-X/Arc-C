using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	internal sealed class BinaryCrossAppDomainMap
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryCrossAppDomainMap()
		{
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x4B94E20", Offset = "0x4B93A20", VA = "0x184B94E20", Slot = "4")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x10")]
		internal int crossAppDomainArrayIndex;
	}
}
