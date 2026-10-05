using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x0200168D RID: 5773
	[Token(Token = "0x200168D")]
	public struct ConverterInput
	{
		// Token: 0x06009255 RID: 37461 RVA: 0x00038FD0 File Offset: 0x000371D0
		[Token(Token = "0x6009255")]
		[Address(RVA = "0x2B2DB40", Offset = "0x2B2C740", VA = "0x182B2DB40")]
		public static ConverterInput Create(TextAsset value)
		{
			return default(ConverterInput);
		}

		// Token: 0x04008822 RID: 34850
		[Token(Token = "0x4008822")]
		[FieldOffset(Offset = "0x0")]
		public string text;

		// Token: 0x04008823 RID: 34851
		[Token(Token = "0x4008823")]
		[FieldOffset(Offset = "0x8")]
		public byte[] bytes;
	}
}
