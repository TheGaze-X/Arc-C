using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	[System.Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DecoderExceptionFallback()
		{
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x4ADBBC0", Offset = "0x4ADA7C0", VA = "0x184ADBBC0", Slot = "4")]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x17000218")]
		public override int MaxCharCount
		{
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x4ADBC10", Offset = "0x4ADA810", VA = "0x184ADBC10", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x4ADBC60", Offset = "0x4ADA860", VA = "0x184ADBC60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
