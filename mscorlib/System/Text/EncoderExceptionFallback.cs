using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	[System.Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EncoderExceptionFallback()
		{
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x4AF6160", Offset = "0x4AF4D60", VA = "0x184AF6160", Slot = "4")]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x17000229")]
		public override int MaxCharCount
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x4AF61B0", Offset = "0x4AF4DB0", VA = "0x184AF61B0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x4AF6200", Offset = "0x4AF4E00", VA = "0x184AF6200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
