using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	internal abstract class Nat160
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x5488F10", Offset = "0x5487B10", VA = "0x185488F10")]
		public static uint Add(uint[] x, uint[] y, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5488A20", Offset = "0x5487620", VA = "0x185488A20")]
		public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5488CE0", Offset = "0x54878E0", VA = "0x185488CE0")]
		public static uint AddTo(uint[] x, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x5488DD0", Offset = "0x54879D0", VA = "0x185488DD0")]
		public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			return 0U;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5488B70", Offset = "0x5487770", VA = "0x185488B70")]
		public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
		{
			return 0U;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5489020", Offset = "0x5487C20", VA = "0x185489020")]
		public static void Copy(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x54890E0", Offset = "0x5487CE0", VA = "0x1854890E0")]
		public static uint[] Create()
		{
			return null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x54890A0", Offset = "0x5487CA0", VA = "0x1854890A0")]
		public static uint[] CreateExt()
		{
			return null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5489120", Offset = "0x5487D20", VA = "0x185489120")]
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return default(bool);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x5489200", Offset = "0x5487E00", VA = "0x185489200")]
		public static bool Eq(uint[] x, uint[] y)
		{
			return default(bool);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x5489260", Offset = "0x5487E60", VA = "0x185489260")]
		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x5489390", Offset = "0x5487F90", VA = "0x185489390")]
		public static uint GetBit(uint[] x, int bit)
		{
			return 0U;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x5489460", Offset = "0x5488060", VA = "0x185489460")]
		public static bool Gte(uint[] x, uint[] y)
		{
			return default(bool);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x54893F0", Offset = "0x5487FF0", VA = "0x1854893F0")]
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			return default(bool);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x54894C0", Offset = "0x54880C0", VA = "0x1854894C0")]
		public static bool IsOne(uint[] x)
		{
			return default(bool);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x5489510", Offset = "0x5488110", VA = "0x185489510")]
		public static bool IsZero(uint[] x)
		{
			return default(bool);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x5489FB0", Offset = "0x5488BB0", VA = "0x185489FB0")]
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x548A1F0", Offset = "0x5488DF0", VA = "0x18548A1F0")]
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x5489AE0", Offset = "0x54886E0", VA = "0x185489AE0")]
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			return 0U;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x54898F0", Offset = "0x54884F0", VA = "0x1854898F0")]
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			return 0U;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x5489550", Offset = "0x5488150", VA = "0x185489550")]
		public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return 0UL;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x5489C90", Offset = "0x5488890", VA = "0x185489C90")]
		public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
		{
			return 0U;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x5489720", Offset = "0x5488320", VA = "0x185489720")]
		public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x5489830", Offset = "0x5488430", VA = "0x185489830")]
		public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x5489DD0", Offset = "0x54889D0", VA = "0x185489DD0")]
		public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x5489F20", Offset = "0x5488B20", VA = "0x185489F20")]
		public static uint MulWordsAdd(uint x, uint y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x5489EA0", Offset = "0x5488AA0", VA = "0x185489EA0")]
		public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x548A870", Offset = "0x5489470", VA = "0x18548A870")]
		public static void Square(uint[] x, uint[] zz)
		{
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x548A480", Offset = "0x5489080", VA = "0x18548A480")]
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x548AEE0", Offset = "0x5489AE0", VA = "0x18548AEE0")]
		public static int Sub(uint[] x, uint[] y, uint[] z)
		{
			return 0;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x548B000", Offset = "0x5489C00", VA = "0x18548B000")]
		public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return 0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x548AB80", Offset = "0x5489780", VA = "0x18548AB80")]
		public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
		{
			return 0;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x548ADF0", Offset = "0x54899F0", VA = "0x18548ADF0")]
		public static int SubFrom(uint[] x, uint[] z)
		{
			return 0;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x548ACD0", Offset = "0x54898D0", VA = "0x18548ACD0")]
		public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
		{
			return 0;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x548B180", Offset = "0x5489D80", VA = "0x18548B180")]
		public static BigInteger ToBigInteger(uint[] x)
		{
			return null;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x548B250", Offset = "0x5489E50", VA = "0x18548B250")]
		public static void Zero(uint[] z)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Nat160()
		{
		}

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		private const ulong M = 4294967295UL;
	}
}
