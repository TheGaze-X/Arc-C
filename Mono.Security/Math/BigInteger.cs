using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Math
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public class BigInteger
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4A96530", Offset = "0x4A95130", VA = "0x184A96530")]
		[CLSCompliant(false)]
		public BigInteger(BigInteger.Sign sign, uint len)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4A96430", Offset = "0x4A95030", VA = "0x184A96430")]
		public BigInteger(BigInteger bi)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4A968C0", Offset = "0x4A954C0", VA = "0x184A968C0")]
		[CLSCompliant(false)]
		public BigInteger(BigInteger bi, uint len)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4A965A0", Offset = "0x4A951A0", VA = "0x184A965A0")]
		public BigInteger(byte[] inData)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x4A96840", Offset = "0x4A95440", VA = "0x184A96840")]
		[CLSCompliant(false)]
		public BigInteger(uint ui)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4A96E00", Offset = "0x4A95A00", VA = "0x184A96E00")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4A96E60", Offset = "0x4A95A60", VA = "0x184A96E60")]
		public static implicit operator BigInteger(int value)
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4A96A70", Offset = "0x4A95670", VA = "0x184A96A70")]
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4A97480", Offset = "0x4A96080", VA = "0x184A97480")]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4A970F0", Offset = "0x4A95CF0", VA = "0x184A970F0")]
		[CLSCompliant(false)]
		public static uint operator %(BigInteger bi, uint ui)
		{
			return 0U;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4A970C0", Offset = "0x4A95CC0", VA = "0x184A970C0")]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4A96C40", Offset = "0x4A95840", VA = "0x184A96C40")]
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4A97150", Offset = "0x4A95D50", VA = "0x184A97150")]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4A97070", Offset = "0x4A95C70", VA = "0x184A97070")]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4A97470", Offset = "0x4A96070", VA = "0x184A97470")]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		private static RandomNumberGenerator Rng
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x4A96990", Offset = "0x4A95590", VA = "0x184A96990")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4A95600", Offset = "0x4A94200", VA = "0x184A95600")]
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4A95810", Offset = "0x4A94410", VA = "0x184A95810")]
		public static BigInteger GenerateRandom(int bits)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4A95140", Offset = "0x4A93D40", VA = "0x184A95140")]
		public int BitCount()
		{
			return 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4A95E70", Offset = "0x4A94A70", VA = "0x184A95E70")]
		public bool TestBit(int bitNum)
		{
			return default(bool);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4A95DC0", Offset = "0x4A949C0", VA = "0x184A95DC0")]
		[CLSCompliant(false)]
		public void SetBit(uint bitNum)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4A95E10", Offset = "0x4A94A10", VA = "0x184A95E10")]
		[CLSCompliant(false)]
		public void SetBit(uint bitNum, bool value)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4A95BC0", Offset = "0x4A947C0", VA = "0x184A95BC0")]
		public int LowestSetBit()
		{
			return 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4A95920", Offset = "0x4A94520", VA = "0x184A95920")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4A96C70", Offset = "0x4A95870", VA = "0x184A96C70")]
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4A96FE0", Offset = "0x4A95BE0", VA = "0x184A96FE0")]
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4A96D00", Offset = "0x4A95900", VA = "0x184A96D00")]
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4A96F20", Offset = "0x4A95B20", VA = "0x184A96F20")]
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4A96DE0", Offset = "0x4A959E0", VA = "0x184A96DE0")]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4A970A0", Offset = "0x4A95CA0", VA = "0x184A970A0")]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4A96DC0", Offset = "0x4A959C0", VA = "0x184A96DC0")]
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4A97080", Offset = "0x4A95C80", VA = "0x184A97080")]
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4A96310", Offset = "0x4A94F10", VA = "0x184A96310")]
		[CLSCompliant(false)]
		public string ToString(uint radix)
		{
			return null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4A95F20", Offset = "0x4A94B20", VA = "0x184A95F20")]
		[CLSCompliant(false)]
		public string ToString(uint radix, string characterSet)
		{
			return null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4A95D60", Offset = "0x4A94960", VA = "0x184A95D60")]
		private void Normalize()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4A951F0", Offset = "0x4A93DF0", VA = "0x184A951F0")]
		public void Clear()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4A95AC0", Offset = "0x4A946C0", VA = "0x184A95AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4A96360", Offset = "0x4A94F60", VA = "0x184A96360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4A95240", Offset = "0x4A93E40", VA = "0x184A95240", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4A95CC0", Offset = "0x4A948C0", VA = "0x184A95CC0")]
		public BigInteger ModInverse(BigInteger modulus)
		{
			return null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x4A95CD0", Offset = "0x4A948D0", VA = "0x184A95CD0")]
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			return null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4A95580", Offset = "0x4A94180", VA = "0x184A95580")]
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4A95B10", Offset = "0x4A94710", VA = "0x184A95B10")]
		public void Incr2()
		{
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x10")]
		private uint length;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x18")]
		private uint[] data;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] smallPrimes;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x8")]
		private static RandomNumberGenerator rng;

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		public enum Sign
		{
			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			Negative = -1,
			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			Zero,
			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			Positive
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		public sealed class ModulusRing
		{
			// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x4A9E5C0", Offset = "0x4A9D1C0", VA = "0x184A9E5C0")]
			public ModulusRing(BigInteger modulus)
			{
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x4A9D980", Offset = "0x4A9C580", VA = "0x184A9D980")]
			public void BarrettReduction(BigInteger x)
			{
			}

			// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x4A9E0D0", Offset = "0x4A9CCD0", VA = "0x184A9E0D0")]
			public BigInteger Multiply(BigInteger a, BigInteger b)
			{
				return null;
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x4A9DEA0", Offset = "0x4A9CAA0", VA = "0x184A9DEA0")]
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				return null;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x4A9E430", Offset = "0x4A9D030", VA = "0x184A9E430")]
			public BigInteger Pow(BigInteger a, BigInteger k)
			{
				return null;
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x4A9E3A0", Offset = "0x4A9CFA0", VA = "0x184A9E3A0")]
			[CLSCompliant(false)]
			public BigInteger Pow(uint b, BigInteger exp)
			{
				return null;
			}

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x10")]
			private BigInteger mod;

			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			[FieldOffset(Offset = "0x18")]
			private BigInteger constant;
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		private sealed class Kernel
		{
			// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x4A98EF0", Offset = "0x4A97AF0", VA = "0x184A98EF0")]
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2)
			{
				return null;
			}

			// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x4A9A100", Offset = "0x4A98D00", VA = "0x184A9A100")]
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				return null;
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x4A998A0", Offset = "0x4A984A0", VA = "0x184A998A0")]
			public static void MinusEq(BigInteger big, BigInteger small)
			{
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x4A99C10", Offset = "0x4A98810", VA = "0x184A99C10")]
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x4A99160", Offset = "0x4A97D60", VA = "0x184A99160")]
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				return BigInteger.Sign.Zero;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002AC0 File Offset: 0x00000CC0
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x4A9A040", Offset = "0x4A98C40", VA = "0x184A9A040")]
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				return 0U;
			}

			// Token: 0x06000240 RID: 576 RVA: 0x00002AD8 File Offset: 0x00000CD8
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x4A970F0", Offset = "0x4A95CF0", VA = "0x184A970F0")]
			public static uint DwordMod(BigInteger n, uint d)
			{
				return 0U;
			}

			// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x4A992D0", Offset = "0x4A97ED0", VA = "0x184A992D0")]
			public static BigInteger[] DwordDivMod(BigInteger n, uint d)
			{
				return null;
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x4A9ADD0", Offset = "0x4A999D0", VA = "0x184A9ADD0")]
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				return null;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x4A995A0", Offset = "0x4A981A0", VA = "0x184A995A0")]
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				return null;
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x4A99DF0", Offset = "0x4A989F0", VA = "0x184A99DF0")]
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				return null;
			}

			// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x4A99B00", Offset = "0x4A98700", VA = "0x184A99B00")]
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset)
			{
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x4A999E0", Offset = "0x4A985E0", VA = "0x184A999E0")]
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x4A9A350", Offset = "0x4A98F50", VA = "0x184A9A350")]
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				return 0U;
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x4A9A470", Offset = "0x4A99070", VA = "0x184A9A470")]
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				return null;
			}
		}
	}
}
