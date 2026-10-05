using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
	[Il2CppEagerStaticClassConstruction]
	[NativeHeader("Runtime/Utilities/BitUtility.h")]
	[NativeHeader("Runtime/Math/FloatConversion.h")]
	[NativeHeader("Runtime/Math/PerlinNoise.h")]
	public struct Mathf
	{
		// Token: 0x060007B9 RID: 1977
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x594BC00", Offset = "0x594A800", VA = "0x18594BC00")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern int ClosestPowerOfTwo(int value);

		// Token: 0x060007BA RID: 1978
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x594C020", Offset = "0x594AC20", VA = "0x18594C020")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern bool IsPowerOfTwo(int value);

		// Token: 0x060007BB RID: 1979
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x594C720", Offset = "0x594B320", VA = "0x18594C720")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern int NextPowerOfTwo(int value);

		// Token: 0x060007BC RID: 1980
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x594BF10", Offset = "0x594AB10", VA = "0x18594BF10")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern float GammaToLinearSpace(float value);

		// Token: 0x060007BD RID: 1981
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x594C2A0", Offset = "0x594AEA0", VA = "0x18594C2A0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern float LinearToGammaSpace(float value);

		// Token: 0x060007BE RID: 1982 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x594BC90", Offset = "0x594A890", VA = "0x18594BC90")]
		[FreeFunction(IsThreadSafe = true)]
		public static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			return default(Color);
		}

		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x594BE10", Offset = "0x594AA10", VA = "0x18594BE10")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern ushort FloatToHalf(float val);

		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x594BFA0", Offset = "0x594ABA0", VA = "0x18594BFA0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern float HalfToFloat(ushort val);

		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x594C760", Offset = "0x594B360", VA = "0x18594C760")]
		[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern float PerlinNoise(float x, float y);

		// Token: 0x060007C2 RID: 1986 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x594CA40", Offset = "0x594B640", VA = "0x18594CA40")]
		[MethodImpl(256)]
		public static float Sin(float f)
		{
			return 0f;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x594BCE0", Offset = "0x594A8E0", VA = "0x18594BCE0")]
		[MethodImpl(256)]
		public static float Cos(float f)
		{
			return 0f;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x594CE80", Offset = "0x594BA80", VA = "0x18594CE80")]
		[MethodImpl(256)]
		public static float Tan(float f)
		{
			return 0f;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x594B9D0", Offset = "0x594A5D0", VA = "0x18594B9D0")]
		[MethodImpl(256)]
		public static float Asin(float f)
		{
			return 0f;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x594B8E0", Offset = "0x594A4E0", VA = "0x18594B8E0")]
		[MethodImpl(256)]
		public static float Acos(float f)
		{
			return 0f;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x594BAA0", Offset = "0x594A6A0", VA = "0x18594BAA0")]
		[MethodImpl(256)]
		public static float Atan(float f)
		{
			return 0f;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x594BA30", Offset = "0x594A630", VA = "0x18594BA30")]
		[MethodImpl(256)]
		public static float Atan2(float y, float x)
		{
			return 0f;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x594CE00", Offset = "0x594BA00", VA = "0x18594CE00")]
		[MethodImpl(256)]
		public static float Sqrt(float f)
		{
			return 0f;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x594B830", Offset = "0x594A430", VA = "0x18594B830")]
		[MethodImpl(256)]
		public static float Abs(float f)
		{
			return 0f;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x594B890", Offset = "0x594A490", VA = "0x18594B890")]
		[MethodImpl(256)]
		public static int Abs(int value)
		{
			return 0;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x594C4F0", Offset = "0x594B0F0", VA = "0x18594C4F0")]
		[MethodImpl(256)]
		public static float Min(float a, float b)
		{
			return 0f;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x594C510", Offset = "0x594B110", VA = "0x18594C510")]
		[MethodImpl(256)]
		public static float Min(params float[] values)
		{
			return 0f;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x594C500", Offset = "0x594B100", VA = "0x18594C500")]
		[MethodImpl(256)]
		public static int Min(int a, int b)
		{
			return 0;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x594C570", Offset = "0x594B170", VA = "0x18594C570")]
		[MethodImpl(256)]
		public static int Min(params int[] values)
		{
			return 0;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x594C4E0", Offset = "0x594B0E0", VA = "0x18594C4E0")]
		[MethodImpl(256)]
		public static float Max(float a, float b)
		{
			return 0f;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x594C480", Offset = "0x594B080", VA = "0x18594C480")]
		[MethodImpl(256)]
		public static float Max(params float[] values)
		{
			return 0f;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x594C470", Offset = "0x594B070", VA = "0x18594C470")]
		[MethodImpl(256)]
		public static int Max(int a, int b)
		{
			return 0;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x594C410", Offset = "0x594B010", VA = "0x18594C410")]
		[MethodImpl(256)]
		public static int Max(params int[] values)
		{
			return 0;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x594C830", Offset = "0x594B430", VA = "0x18594C830")]
		[MethodImpl(256)]
		public static float Pow(float f, float p)
		{
			return 0f;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x594BDB0", Offset = "0x594A9B0", VA = "0x18594BDB0")]
		[MethodImpl(256)]
		public static float Exp(float power)
		{
			return 0f;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x594C340", Offset = "0x594AF40", VA = "0x18594C340")]
		[MethodImpl(256)]
		public static float Log(float f, float p)
		{
			return 0f;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x594C3B0", Offset = "0x594AFB0", VA = "0x18594C3B0")]
		[MethodImpl(256)]
		public static float Log(float f)
		{
			return 0f;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x594C2E0", Offset = "0x594AEE0", VA = "0x18594C2E0")]
		[MethodImpl(256)]
		public static float Log10(float f)
		{
			return 0f;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x594BB60", Offset = "0x594A760", VA = "0x18594BB60")]
		[MethodImpl(256)]
		public static float Ceil(float f)
		{
			return 0f;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x594BEB0", Offset = "0x594AAB0", VA = "0x18594BEB0")]
		[MethodImpl(256)]
		public static float Floor(float f)
		{
			return 0f;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x594C9C0", Offset = "0x594B5C0", VA = "0x18594C9C0")]
		[MethodImpl(256)]
		public static float Round(float f)
		{
			return 0f;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x594BB00", Offset = "0x594A700", VA = "0x18594BB00")]
		[MethodImpl(256)]
		public static int CeilToInt(float f)
		{
			return 0;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x594BE50", Offset = "0x594AA50", VA = "0x18594BE50")]
		[MethodImpl(256)]
		public static int FloorToInt(float f)
		{
			return 0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x594C960", Offset = "0x594B560", VA = "0x18594C960")]
		[MethodImpl(256)]
		public static int RoundToInt(float f)
		{
			return 0;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x594CA20", Offset = "0x594B620", VA = "0x18594CA20")]
		[MethodImpl(256)]
		public static float Sign(float f)
		{
			return 0f;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x4E50640", Offset = "0x4E4F240", VA = "0x184E50640")]
		[MethodImpl(256)]
		public static float Clamp(float value, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x594BBE0", Offset = "0x594A7E0", VA = "0x18594BBE0")]
		[MethodImpl(256)]
		public static int Clamp(int value, int min, int max)
		{
			return 0;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x594BBC0", Offset = "0x594A7C0", VA = "0x18594BBC0")]
		[MethodImpl(256)]
		public static float Clamp01(float value)
		{
			return 0f;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x544CEC0", Offset = "0x544BAC0", VA = "0x18544CEC0")]
		[MethodImpl(256)]
		public static float Lerp(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x594C060", Offset = "0x594AC60", VA = "0x18594C060")]
		[MethodImpl(256)]
		public static float LerpUnclamped(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x4F6DF0", Offset = "0x4F59F0", VA = "0x1804F6DF0")]
		[MethodImpl(256)]
		public static float LerpAngle(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x594C6D0", Offset = "0x594B2D0", VA = "0x18594C6D0")]
		[MethodImpl(256)]
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			return 0f;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x594C5D0", Offset = "0x594B1D0", VA = "0x18594C5D0")]
		[MethodImpl(256)]
		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			return 0f;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x594CDA0", Offset = "0x594B9A0", VA = "0x18594CDA0")]
		[MethodImpl(256)]
		public static float SmoothStep(float from, float to, float t)
		{
			return 0f;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x594BF50", Offset = "0x594AB50", VA = "0x18594BF50")]
		[MethodImpl(256)]
		public static float Gamma(float value, float absmax, float gamma)
		{
			return 0f;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x594B940", Offset = "0x594A540", VA = "0x18594B940")]
		[MethodImpl(256)]
		public static bool Approximately(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x594CBF0", Offset = "0x594B7F0", VA = "0x18594CBF0")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			return 0f;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x594CB80", Offset = "0x594B780", VA = "0x18594CB80")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			return 0f;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x594CC60", Offset = "0x594B860", VA = "0x18594CC60")]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return 0f;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x594CAA0", Offset = "0x594B6A0", VA = "0x18594CAA0")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			return 0f;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x594CB10", Offset = "0x594B710", VA = "0x18594CB10")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			return 0f;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x12586C0", Offset = "0x12572C0", VA = "0x1812586C0")]
		[MethodImpl(256)]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return 0f;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x4F6EA0", Offset = "0x4F5AA0", VA = "0x1804F6EA0")]
		[MethodImpl(256)]
		public static float Repeat(float t, float length)
		{
			return 0f;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x594C7B0", Offset = "0x594B3B0", VA = "0x18594C7B0")]
		[MethodImpl(256)]
		public static float PingPong(float t, float length)
		{
			return 0f;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x594BFE0", Offset = "0x594ABE0", VA = "0x18594BFE0")]
		[MethodImpl(256)]
		public static float InverseLerp(float a, float b, float value)
		{
			return 0f;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x594BD40", Offset = "0x594A940", VA = "0x18594BD40")]
		[MethodImpl(256)]
		public static float DeltaAngle(float current, float target)
		{
			return 0f;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x594C080", Offset = "0x594AC80", VA = "0x18594C080")]
		internal static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			return default(bool);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x594C160", Offset = "0x594AD60", VA = "0x18594C160")]
		internal static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			return default(bool);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x594C8A0", Offset = "0x594B4A0", VA = "0x18594C8A0")]
		internal static long RandomToLong(Random r)
		{
			return 0L;
		}

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x594BC40", Offset = "0x594A840", VA = "0x18594BC40")]
		[MethodImpl(4096)]
		private static extern void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret);

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		public const float PI = 3.1415927f;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		public const float Rad2Deg = 57.29578f;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float Epsilon;
	}
}
