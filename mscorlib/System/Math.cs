using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public static class Math
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x4CDC020", Offset = "0x4CDAC20", VA = "0x184CDC020")]
		[MethodImpl(256)]
		public static int Abs(int value)
		{
			return 0;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x4CDBFD0", Offset = "0x4CDABD0", VA = "0x184CDBFD0")]
		[MethodImpl(256)]
		public static long Abs(long value)
		{
			return 0L;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x4CDCD20", Offset = "0x4CDB920", VA = "0x184CDCD20")]
		[StackTraceHidden]
		private static void ThrowAbsOverflow()
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x4CDC1A0", Offset = "0x4CDADA0", VA = "0x184CDC1A0")]
		public static int DivRem(int a, int b, out int result)
		{
			return 0;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x4CDC0E0", Offset = "0x4CDACE0", VA = "0x184CDC0E0")]
		[MethodImpl(256)]
		public static int Clamp(int value, int min, int max)
		{
			return 0;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x4CDC1E0", Offset = "0x4CDADE0", VA = "0x184CDC1E0")]
		public static double IEEERemainder(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x4CDC4A0", Offset = "0x4CDB0A0", VA = "0x184CDC4A0")]
		public static double Log(double a, double newBase)
		{
			return 0.0;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x4CDC600", Offset = "0x4CDB200", VA = "0x184CDC600")]
		[NonVersionable]
		public static byte Max(byte val1, byte val2)
		{
			return 0;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x4CDC630", Offset = "0x4CDB230", VA = "0x184CDC630")]
		public static double Max(double val1, double val2)
		{
			return 0.0;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x4CDC610", Offset = "0x4CDB210", VA = "0x184CDC610")]
		[NonVersionable]
		public static int Max(int val1, int val2)
		{
			return 0;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x4CDC710", Offset = "0x4CDB310", VA = "0x184CDC710")]
		[NonVersionable]
		public static long Max(long val1, long val2)
		{
			return 0L;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x4CDC680", Offset = "0x4CDB280", VA = "0x184CDC680")]
		public static float Max(float val1, float val2)
		{
			return 0f;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x4CDC620", Offset = "0x4CDB220", VA = "0x184CDC620")]
		[NonVersionable]
		[System.CLSCompliant(false)]
		public static uint Max(uint val1, uint val2)
		{
			return 0U;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x4CDC750", Offset = "0x4CDB350", VA = "0x184CDC750")]
		public static double Min(double val1, double val2)
		{
			return 0.0;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x4CDC730", Offset = "0x4CDB330", VA = "0x184CDC730")]
		[NonVersionable]
		public static int Min(int val1, int val2)
		{
			return 0;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4CDC7A0", Offset = "0x4CDB3A0", VA = "0x184CDC7A0")]
		[NonVersionable]
		public static long Min(long val1, long val2)
		{
			return 0L;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x4CDC7B0", Offset = "0x4CDB3B0", VA = "0x184CDC7B0")]
		public static float Min(float val1, float val2)
		{
			return 0f;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x4CDC740", Offset = "0x4CDB340", VA = "0x184CDC740")]
		[System.CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2)
		{
			return 0U;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x4CDC720", Offset = "0x4CDB320", VA = "0x184CDC720")]
		[NonVersionable]
		[System.CLSCompliant(false)]
		public static ulong Min(ulong val1, ulong val2)
		{
			return 0UL;
		}

		// Token: 0x060008B2 RID: 2226
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x4CDCB70", Offset = "0x4CDB770", VA = "0x184CDCB70")]
		[MethodImpl(4096)]
		public static extern double Round(double a);

		// Token: 0x060008B3 RID: 2227 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4CDC860", Offset = "0x4CDB460", VA = "0x184CDC860")]
		[MethodImpl(256)]
		public static double Round(double value, int digits)
		{
			return 0.0;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4CDC8C0", Offset = "0x4CDB4C0", VA = "0x184CDC8C0")]
		public static double Round(double value, int digits, System.MidpointRounding mode)
		{
			return 0.0;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4CDCB80", Offset = "0x4CDB780", VA = "0x184CDCB80")]
		public static int Sign(double value)
		{
			return 0;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4CDCC10", Offset = "0x4CDB810", VA = "0x184CDCC10")]
		public static int Sign(long value)
		{
			return 0;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x4CDCC30", Offset = "0x4CDB830", VA = "0x184CDCC30")]
		public static int Sign(float value)
		{
			return 0;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x4CDCDF0", Offset = "0x4CDB9F0", VA = "0x184CDCDF0")]
		[MethodImpl(256)]
		public static decimal Truncate(decimal d)
		{
			return 0m;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4CDCD80", Offset = "0x4CDB980", VA = "0x184CDCD80")]
		public static double Truncate(double d)
		{
			return 0.0;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		private static void ThrowMinMaxException<T>(T min, T max)
		{
		}

		// Token: 0x060008BB RID: 2235
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4CDC080", Offset = "0x4CDAC80", VA = "0x184CDC080")]
		[MethodImpl(4096)]
		public static extern double Abs(double value);

		// Token: 0x060008BC RID: 2236
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4CDC070", Offset = "0x4CDAC70", VA = "0x184CDC070")]
		[MethodImpl(4096)]
		public static extern float Abs(float value);

		// Token: 0x060008BD RID: 2237
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4CDC090", Offset = "0x4CDAC90", VA = "0x184CDC090")]
		[MethodImpl(4096)]
		public static extern double Acos(double d);

		// Token: 0x060008BE RID: 2238
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x4CDC0A0", Offset = "0x4CDACA0", VA = "0x184CDC0A0")]
		[MethodImpl(4096)]
		public static extern double Asin(double d);

		// Token: 0x060008BF RID: 2239
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x4CDC0C0", Offset = "0x4CDACC0", VA = "0x184CDC0C0")]
		[MethodImpl(4096)]
		public static extern double Atan(double d);

		// Token: 0x060008C0 RID: 2240
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x4CDC0B0", Offset = "0x4CDACB0", VA = "0x184CDC0B0")]
		[MethodImpl(4096)]
		public static extern double Atan2(double y, double x);

		// Token: 0x060008C1 RID: 2241
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x4CDC0D0", Offset = "0x4CDACD0", VA = "0x184CDC0D0")]
		[MethodImpl(4096)]
		public static extern double Ceiling(double a);

		// Token: 0x060008C2 RID: 2242
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x4CDC180", Offset = "0x4CDAD80", VA = "0x184CDC180")]
		[MethodImpl(4096)]
		public static extern double Cos(double d);

		// Token: 0x060008C3 RID: 2243
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4CDC190", Offset = "0x4CDAD90", VA = "0x184CDC190")]
		[MethodImpl(4096)]
		public static extern double Cosh(double value);

		// Token: 0x060008C4 RID: 2244
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x4CDC1C0", Offset = "0x4CDADC0", VA = "0x184CDC1C0")]
		[MethodImpl(4096)]
		public static extern double Exp(double d);

		// Token: 0x060008C5 RID: 2245
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x4CDC1D0", Offset = "0x4CDADD0", VA = "0x184CDC1D0")]
		[MethodImpl(4096)]
		public static extern double Floor(double d);

		// Token: 0x060008C6 RID: 2246
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x4CDC490", Offset = "0x4CDB090", VA = "0x184CDC490")]
		[MethodImpl(4096)]
		public static extern double Log(double d);

		// Token: 0x060008C7 RID: 2247
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x4CDC480", Offset = "0x4CDB080", VA = "0x184CDC480")]
		[MethodImpl(4096)]
		public static extern double Log10(double d);

		// Token: 0x060008C8 RID: 2248
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x4CDC850", Offset = "0x4CDB450", VA = "0x184CDC850")]
		[MethodImpl(4096)]
		public static extern double Pow(double x, double y);

		// Token: 0x060008C9 RID: 2249
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x4CDCCC0", Offset = "0x4CDB8C0", VA = "0x184CDCCC0")]
		[MethodImpl(4096)]
		public static extern double Sin(double a);

		// Token: 0x060008CA RID: 2250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x4CDCCD0", Offset = "0x4CDB8D0", VA = "0x184CDCCD0")]
		[MethodImpl(4096)]
		public static extern double Sinh(double value);

		// Token: 0x060008CB RID: 2251
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x4CDCCE0", Offset = "0x4CDB8E0", VA = "0x184CDCCE0")]
		[MethodImpl(4096)]
		public static extern double Sqrt(double d);

		// Token: 0x060008CC RID: 2252
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x4CDCD00", Offset = "0x4CDB900", VA = "0x184CDCD00")]
		[MethodImpl(4096)]
		public static extern double Tan(double a);

		// Token: 0x060008CD RID: 2253
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x4CDCD10", Offset = "0x4CDB910", VA = "0x184CDCD10")]
		[MethodImpl(4096)]
		public static extern double Tanh(double value);

		// Token: 0x060008CE RID: 2254
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4CDC840", Offset = "0x4CDB440", VA = "0x184CDC840")]
		[MethodImpl(4096)]
		private unsafe static extern double ModF(double x, double* intptr);

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x0")]
		private static double doubleRoundLimit;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x8")]
		private static double[] roundPower10Double;
	}
}
