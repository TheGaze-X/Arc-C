using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	public class DsaValidationParameters
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x5286750", Offset = "0x5285350", VA = "0x185286750")]
		public DsaValidationParameters(byte[] seed, int counter)
		{
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x52868A0", Offset = "0x52854A0", VA = "0x1852868A0")]
		public DsaValidationParameters(byte[] seed, int counter, int usageIndex)
		{
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x52866D0", Offset = "0x52852D0", VA = "0x1852866D0", Slot = "4")]
		public virtual byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x17000358")]
		public virtual int Counter
		{
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x17000359")]
		public virtual int UsageIndex
		{
			[Token(Token = "0x6001897")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x52865D0", Offset = "0x52851D0", VA = "0x1852865D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x5284110", Offset = "0x5282D10", VA = "0x185284110", Slot = "7")]
		protected virtual bool Equals(DsaValidationParameters other)
		{
			return default(bool);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x5284150", Offset = "0x5282D50", VA = "0x185284150", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] seed;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x18")]
		private readonly int counter;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int usageIndex;
	}
}
