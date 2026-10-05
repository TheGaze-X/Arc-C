using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Prng;

namespace Org.BouncyCastle.Security
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	public class SecureRandom : Random
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x5482810", Offset = "0x5481410", VA = "0x185482810")]
		private static long NextCounterValue()
		{
			return 0L;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		private static SecureRandom Master
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x54831B0", Offset = "0x5481DB0", VA = "0x1854831B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x5481EE0", Offset = "0x5480AE0", VA = "0x185481EE0")]
		private static DigestRandomGenerator CreatePrng(string digestName, bool autoSeed)
		{
			return null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x5482540", Offset = "0x5481140", VA = "0x185482540")]
		public static byte[] GetNextBytes(SecureRandom secureRandom, int length)
		{
			return null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x5482380", Offset = "0x5480F80", VA = "0x185482380")]
		public static SecureRandom GetInstance(string algorithm)
		{
			return null;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x54821E0", Offset = "0x5480DE0", VA = "0x1854821E0")]
		public static SecureRandom GetInstance(string algorithm, bool autoSeed)
		{
			return null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x54825C0", Offset = "0x54811C0", VA = "0x1854825C0")]
		[Obsolete("Call GenerateSeed() on a SecureRandom instance instead")]
		public static byte[] GetSeed(int length)
		{
			return null;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x5482F90", Offset = "0x5481B90", VA = "0x185482F90")]
		public SecureRandom()
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x54830C0", Offset = "0x5481CC0", VA = "0x1854830C0")]
		[Obsolete("Use GetInstance/SetSeed instead")]
		public SecureRandom(byte[] seed)
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x5483050", Offset = "0x5481C50", VA = "0x185483050")]
		public SecureRandom(IRandomGenerator generator)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x54820F0", Offset = "0x5480CF0", VA = "0x1854820F0", Slot = "10")]
		public virtual byte[] GenerateSeed(int length)
		{
			return null;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x5482CD0", Offset = "0x54818D0", VA = "0x185482CD0", Slot = "11")]
		public virtual void SetSeed(byte[] seed)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x5482D30", Offset = "0x5481930", VA = "0x185482D30", Slot = "12")]
		public virtual void SetSeed(long seed)
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5482A60", Offset = "0x5481660", VA = "0x185482A60", Slot = "5")]
		public override int Next()
		{
			return 0;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x5482AA0", Offset = "0x54816A0", VA = "0x185482AA0", Slot = "7")]
		public override int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5482BC0", Offset = "0x54817C0", VA = "0x185482BC0", Slot = "6")]
		public override int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x54827B0", Offset = "0x54813B0", VA = "0x1854827B0", Slot = "9")]
		public override void NextBytes(byte[] buf)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x54826B0", Offset = "0x54812B0", VA = "0x1854826B0", Slot = "13")]
		public virtual void NextBytes(byte[] buf, int off, int len)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x5482860", Offset = "0x5481460", VA = "0x185482860", Slot = "8")]
		public override double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x5482920", Offset = "0x5481520", VA = "0x185482920", Slot = "14")]
		public virtual int NextInt()
		{
			return 0;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x54829E0", Offset = "0x54815E0", VA = "0x1854829E0", Slot = "15")]
		public virtual long NextLong()
		{
			return 0L;
		}

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x0")]
		private static long counter;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly SecureRandom master;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x20")]
		protected readonly IRandomGenerator generator;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly double DoubleScale;
	}
}
