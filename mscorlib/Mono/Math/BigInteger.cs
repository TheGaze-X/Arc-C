using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Math
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	internal class BigInteger
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4AC0F00", Offset = "0x4ABFB00", VA = "0x184AC0F00")]
		public BigInteger(BigInteger.Sign sign, uint len)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4AC0F70", Offset = "0x4ABFB70", VA = "0x184AC0F70")]
		public BigInteger(BigInteger bi)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4AC0E30", Offset = "0x4ABFA30", VA = "0x184AC0E30")]
		public BigInteger(BigInteger bi, uint len)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4AC1070", Offset = "0x4ABFC70", VA = "0x184AC1070")]
		public BigInteger(byte[] inData)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4AC0DB0", Offset = "0x4ABF9B0", VA = "0x184AC0DB0")]
		public BigInteger(uint ui)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4AC1770", Offset = "0x4AC0370", VA = "0x184AC1770")]
		public static implicit operator BigInteger(uint value)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4AC16B0", Offset = "0x4AC02B0", VA = "0x184AC16B0")]
		public static implicit operator BigInteger(int value)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4AC13F0", Offset = "0x4ABFFF0", VA = "0x184AC13F0")]
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4AC1EB0", Offset = "0x4AC0AB0", VA = "0x184AC1EB0")]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4A970F0", Offset = "0x4A95CF0", VA = "0x184A970F0")]
		public static uint operator %(BigInteger bi, uint ui)
		{
			return 0U;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4AC18A0", Offset = "0x4AC04A0", VA = "0x184AC18A0")]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4AC15C0", Offset = "0x4AC01C0", VA = "0x184AC15C0")]
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4AC1B80", Offset = "0x4AC0780", VA = "0x184AC1B80")]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4AC18D0", Offset = "0x4AC04D0", VA = "0x184AC18D0")]
		public static BigInteger operator *(BigInteger bi, int i)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4AC1890", Offset = "0x4AC0490", VA = "0x184AC1890")]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4AC1EA0", Offset = "0x4AC0AA0", VA = "0x184AC1EA0")]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000036")]
		private static System.Security.Cryptography.RandomNumberGenerator Rng
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x4AC1310", Offset = "0x4ABFF10", VA = "0x184AC1310")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4ABFCB0", Offset = "0x4ABE8B0", VA = "0x184ABFCB0")]
		public static BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng)
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4ABFC50", Offset = "0x4ABE850", VA = "0x184ABFC50")]
		public static BigInteger GenerateRandom(int bits)
		{
			return null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4AC0510", Offset = "0x4ABF110", VA = "0x184AC0510")]
		public void Randomize(System.Security.Cryptography.RandomNumberGenerator rng)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4AC0750", Offset = "0x4ABF350", VA = "0x184AC0750")]
		public void Randomize()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4A95140", Offset = "0x4A93D40", VA = "0x184A95140")]
		public int BitCount()
		{
			return 0;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4AC07B0", Offset = "0x4ABF3B0", VA = "0x184AC07B0")]
		public bool TestBit(uint bitNum)
		{
			return default(bool);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4AC07F0", Offset = "0x4ABF3F0", VA = "0x184AC07F0")]
		public bool TestBit(int bitNum)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4A95DC0", Offset = "0x4A949C0", VA = "0x184A95DC0")]
		public void SetBit(uint bitNum)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4A95E10", Offset = "0x4A94A10", VA = "0x184A95E10")]
		public void SetBit(uint bitNum, bool value)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x4AC0370", Offset = "0x4ABEF70", VA = "0x184AC0370")]
		public int LowestSetBit()
		{
			return 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4ABFEC0", Offset = "0x4ABEAC0", VA = "0x184ABFEC0")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4A96C70", Offset = "0x4A95870", VA = "0x184A96C70")]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4A96FE0", Offset = "0x4A95BE0", VA = "0x184A96FE0")]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4AC15F0", Offset = "0x4AC01F0", VA = "0x184AC15F0")]
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4AC17D0", Offset = "0x4AC03D0", VA = "0x184AC17D0")]
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4A96DE0", Offset = "0x4A959E0", VA = "0x184A96DE0")]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4A970A0", Offset = "0x4A95CA0", VA = "0x184A970A0")]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4A96DC0", Offset = "0x4A959C0", VA = "0x184A96DC0")]
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4A97080", Offset = "0x4A95C80", VA = "0x184A97080")]
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4AC08A0", Offset = "0x4ABF4A0", VA = "0x184AC08A0")]
		public string ToString(uint radix)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4AC0930", Offset = "0x4ABF530", VA = "0x184AC0930")]
		public string ToString(uint radix, string characterSet)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4A95D60", Offset = "0x4A94960", VA = "0x184A95D60")]
		private void Normalize()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4A951F0", Offset = "0x4A93DF0", VA = "0x184A951F0")]
		public void Clear()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4A95AC0", Offset = "0x4A946C0", VA = "0x184A95AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4AC08F0", Offset = "0x4ABF4F0", VA = "0x184AC08F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4ABF890", Offset = "0x4ABE490", VA = "0x184ABF890", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4AC0470", Offset = "0x4ABF070", VA = "0x184AC0470")]
		public BigInteger ModInverse(BigInteger modulus)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4AC0480", Offset = "0x4ABF080", VA = "0x184AC0480")]
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4AC0060", Offset = "0x4ABEC60", VA = "0x184AC0060")]
		public bool IsProbablePrime()
		{
			return default(bool);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4ABFBD0", Offset = "0x4ABE7D0", VA = "0x184ABFBD0")]
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			return null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4A95B10", Offset = "0x4A94710", VA = "0x184A95B10")]
		public void Incr2()
		{
		}

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x10")]
		private uint length;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x18")]
		private uint[] data;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] smallPrimes;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x8")]
		private static System.Security.Cryptography.RandomNumberGenerator rng;

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		public enum Sign
		{
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			Negative = -1,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			Zero,
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			Positive
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		internal sealed class ModulusRing
		{
			// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x4ACD230", Offset = "0x4ACBE30", VA = "0x184ACD230")]
			public ModulusRing(BigInteger modulus)
			{
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x4ACC5F0", Offset = "0x4ACB1F0", VA = "0x184ACC5F0")]
			public void BarrettReduction(BigInteger x)
			{
			}

			// Token: 0x06000225 RID: 549 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4ACCD40", Offset = "0x4ACB940", VA = "0x184ACCD40")]
			public BigInteger Multiply(BigInteger a, BigInteger b)
			{
				return null;
			}

			// Token: 0x06000226 RID: 550 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x4ACCB10", Offset = "0x4ACB710", VA = "0x184ACCB10")]
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				return null;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x4ACD010", Offset = "0x4ACBC10", VA = "0x184ACD010")]
			public BigInteger Pow(BigInteger a, BigInteger k)
			{
				return null;
			}

			// Token: 0x06000228 RID: 552 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x4ACD1A0", Offset = "0x4ACBDA0", VA = "0x184ACD1A0")]
			public BigInteger Pow(uint b, BigInteger exp)
			{
				return null;
			}

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x10")]
			private BigInteger mod;

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x18")]
			private BigInteger constant;
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		private sealed class Kernel
		{
			// Token: 0x06000229 RID: 553 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x4AC77B0", Offset = "0x4AC63B0", VA = "0x184AC77B0")]
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2)
			{
				return null;
			}

			// Token: 0x0600022A RID: 554 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x4AC83D0", Offset = "0x4AC6FD0", VA = "0x184AC83D0")]
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				return null;
			}

			// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x4A998A0", Offset = "0x4A984A0", VA = "0x184A998A0")]
			public static void MinusEq(BigInteger big, BigInteger small)
			{
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x4A99C10", Offset = "0x4A98810", VA = "0x184A99C10")]
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00003018 File Offset: 0x00001218
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x4A99160", Offset = "0x4A97D60", VA = "0x184A99160")]
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				return BigInteger.Sign.Zero;
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00003030 File Offset: 0x00001230
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x4A9A040", Offset = "0x4A98C40", VA = "0x184A9A040")]
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				return 0U;
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00003048 File Offset: 0x00001248
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x4A970F0", Offset = "0x4A95CF0", VA = "0x184A970F0")]
			public static uint DwordMod(BigInteger n, uint d)
			{
				return 0U;
			}

			// Token: 0x06000230 RID: 560 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x4AC7A20", Offset = "0x4AC6620", VA = "0x184AC7A20")]
			public static BigInteger[] DwordDivMod(BigInteger n, uint d)
			{
				return null;
			}

			// Token: 0x06000231 RID: 561 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x4AC90A0", Offset = "0x4AC7CA0", VA = "0x184AC90A0")]
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				return null;
			}

			// Token: 0x06000232 RID: 562 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x4AC7CF0", Offset = "0x4AC68F0", VA = "0x184AC7CF0")]
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				return null;
			}

			// Token: 0x06000233 RID: 563 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x4AC8180", Offset = "0x4AC6D80", VA = "0x184AC8180")]
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				return null;
			}

			// Token: 0x06000234 RID: 564 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x4AC7FF0", Offset = "0x4AC6BF0", VA = "0x184AC7FF0")]
			public static BigInteger MultiplyByDword(BigInteger n, uint f)
			{
				return null;
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x4A99B00", Offset = "0x4A98700", VA = "0x184A99B00")]
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset)
			{
			}

			// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x4A999E0", Offset = "0x4A985E0", VA = "0x184A999E0")]
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00003060 File Offset: 0x00001260
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x4AC8F80", Offset = "0x4AC7B80", VA = "0x184AC8F80")]
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				return 0U;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x4AC8620", Offset = "0x4AC7220", VA = "0x184AC8620")]
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				return null;
			}
		}
	}
}
