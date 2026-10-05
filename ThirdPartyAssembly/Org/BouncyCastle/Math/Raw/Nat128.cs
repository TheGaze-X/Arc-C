using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	internal abstract class Nat128
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x547C700", Offset = "0x547B300", VA = "0x18547C700")]
		public static uint Add(uint[] x, uint[] y, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x547C310", Offset = "0x547AF10", VA = "0x18547C310")]
		public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x547C640", Offset = "0x547B240", VA = "0x18547C640")]
		public static uint AddTo(uint[] x, uint[] z)
		{
			return 0U;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x547C550", Offset = "0x547B150", VA = "0x18547C550")]
		public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			return 0U;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x547C420", Offset = "0x547B020", VA = "0x18547C420")]
		public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
		{
			return 0U;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x547C830", Offset = "0x547B430", VA = "0x18547C830")]
		public static void Copy(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x547C7E0", Offset = "0x547B3E0", VA = "0x18547C7E0")]
		public static void Copy64(ulong[] x, ulong[] z)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x547C960", Offset = "0x547B560", VA = "0x18547C960")]
		public static uint[] Create()
		{
			return null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x547C8A0", Offset = "0x547B4A0", VA = "0x18547C8A0")]
		public static ulong[] Create64()
		{
			return null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x547C920", Offset = "0x547B520", VA = "0x18547C920")]
		public static uint[] CreateExt()
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x547C8E0", Offset = "0x547B4E0", VA = "0x18547C8E0")]
		public static ulong[] CreateExt64()
		{
			return null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x547C9A0", Offset = "0x547B5A0", VA = "0x18547C9A0")]
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return default(bool);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x547CAE0", Offset = "0x547B6E0", VA = "0x18547CAE0")]
		public static bool Eq(uint[] x, uint[] y)
		{
			return default(bool);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x547CA80", Offset = "0x547B680", VA = "0x18547CA80")]
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			return default(bool);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x547CCA0", Offset = "0x547B8A0", VA = "0x18547CCA0")]
		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x547CB40", Offset = "0x547B740", VA = "0x18547CB40")]
		public static ulong[] FromBigInteger64(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x547CDE0", Offset = "0x547B9E0", VA = "0x18547CDE0")]
		public static uint GetBit(uint[] x, int bit)
		{
			return 0U;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x547CE40", Offset = "0x547BA40", VA = "0x18547CE40")]
		public static bool Gte(uint[] x, uint[] y)
		{
			return default(bool);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x547CEA0", Offset = "0x547BAA0", VA = "0x18547CEA0")]
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			return default(bool);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x547CF70", Offset = "0x547BB70", VA = "0x18547CF70")]
		public static bool IsOne(uint[] x)
		{
			return default(bool);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x547CF10", Offset = "0x547BB10", VA = "0x18547CF10")]
		public static bool IsOne64(ulong[] x)
		{
			return default(bool);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x547D000", Offset = "0x547BC00", VA = "0x18547D000")]
		public static bool IsZero(uint[] x)
		{
			return default(bool);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x547CFC0", Offset = "0x547BBC0", VA = "0x18547CFC0")]
		public static bool IsZero64(ulong[] x)
		{
			return default(bool);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x547D970", Offset = "0x547C570", VA = "0x18547D970")]
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x547DB50", Offset = "0x547C750", VA = "0x18547DB50")]
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x547D500", Offset = "0x547C100", VA = "0x18547D500")]
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			return 0U;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x547D350", Offset = "0x547BF50", VA = "0x18547D350")]
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			return 0U;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x547D040", Offset = "0x547BC40", VA = "0x18547D040")]
		public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return 0UL;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x547D680", Offset = "0x547C280", VA = "0x18547D680")]
		public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
		{
			return 0U;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x547D1D0", Offset = "0x547BDD0", VA = "0x18547D1D0")]
		public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x547D290", Offset = "0x547BE90", VA = "0x18547D290")]
		public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x547D790", Offset = "0x547C390", VA = "0x18547D790")]
		public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x547D8E0", Offset = "0x547C4E0", VA = "0x18547D8E0")]
		public static uint MulWordsAdd(uint x, uint y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x547D860", Offset = "0x547C460", VA = "0x18547D860")]
		public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
		{
			return 0U;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x547E070", Offset = "0x547CC70", VA = "0x18547E070")]
		public static void Square(uint[] x, uint[] zz)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x547DD80", Offset = "0x547C980", VA = "0x18547DD80")]
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x547E590", Offset = "0x547D190", VA = "0x18547E590")]
		public static int Sub(uint[] x, uint[] y, uint[] z)
		{
			return 0;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x547E680", Offset = "0x547D280", VA = "0x18547E680")]
		public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return 0;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x547E2D0", Offset = "0x547CED0", VA = "0x18547E2D0")]
		public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
		{
			return 0;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x547E3E0", Offset = "0x547CFE0", VA = "0x18547E3E0")]
		public static int SubFrom(uint[] x, uint[] z)
		{
			return 0;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x547E4A0", Offset = "0x547D0A0", VA = "0x18547E4A0")]
		public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
		{
			return 0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x547E8A0", Offset = "0x547D4A0", VA = "0x18547E8A0")]
		public static BigInteger ToBigInteger(uint[] x)
		{
			return null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x547E7C0", Offset = "0x547D3C0", VA = "0x18547E7C0")]
		public static BigInteger ToBigInteger64(ulong[] x)
		{
			return null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x547E970", Offset = "0x547D570", VA = "0x18547E970")]
		public static void Zero(uint[] z)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Nat128()
		{
		}

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		private const ulong M = 4294967295UL;
	}
}
