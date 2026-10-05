using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	internal static class TimeUtility
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x5900D80", Offset = "0x58FF980", VA = "0x185900D80")]
		private static void ValidateFrameRate(double frameRate)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x5900910", Offset = "0x58FF510", VA = "0x185900910")]
		public static int ToFrames(double time, double frameRate)
		{
			return 0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x59006C0", Offset = "0x58FF2C0", VA = "0x1859006C0")]
		public static double ToExactFrames(double time, double frameRate)
		{
			return 0.0;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x58FED30", Offset = "0x58FD930", VA = "0x1858FED30")]
		public static double FromFrames(int frames, double frameRate)
		{
			return 0.0;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x58FEDA0", Offset = "0x58FD9A0", VA = "0x1858FEDA0")]
		public static double FromFrames(double frames, double frameRate)
		{
			return 0.0;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x58FF2C0", Offset = "0x58FDEC0", VA = "0x1858FF2C0")]
		public static bool OnFrameBoundary(double time, double frameRate)
		{
			return default(bool);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x58FF0A0", Offset = "0x58FDCA0", VA = "0x1858FF0A0")]
		public static double GetEpsilon(double time, double frameRate)
		{
			return 0.0;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x58FF150", Offset = "0x58FDD50", VA = "0x1858FF150")]
		public static bool OnFrameBoundary(double time, double frameRate, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x58FFEF0", Offset = "0x58FEAF0", VA = "0x1858FFEF0")]
		public static double RoundToFrame(double time, double frameRate)
		{
			return 0.0;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x58FFFF0", Offset = "0x58FEBF0", VA = "0x1858FFFF0")]
		public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
		{
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x5900110", Offset = "0x58FED10", VA = "0x185900110")]
		public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
		{
			return null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x58FF470", Offset = "0x58FE070", VA = "0x1858FF470")]
		public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x58FFA20", Offset = "0x58FE620", VA = "0x1858FFA20")]
		public static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x58FEE10", Offset = "0x58FDA10", VA = "0x1858FEE10")]
		public static double GetAnimationClipLength(AnimationClip clip)
		{
			return 0.0;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x58FFE10", Offset = "0x58FEA10", VA = "0x1858FFE10")]
		private static string RemoveChar(string str, Func<char, bool> charToRemoveFunc)
		{
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x58FEFA0", Offset = "0x58FDBA0", VA = "0x1858FEFA0")]
		public static FrameRate GetClosestFrameRate(double frameRate)
		{
			return default(FrameRate);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x5900730", Offset = "0x58FF330", VA = "0x185900730")]
		public static FrameRate ToFrameRate(StandardFrameRates enumValue)
		{
			return default(FrameRate);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x5900A50", Offset = "0x58FF650", VA = "0x185900A50")]
		internal static bool ToStandardFrameRate(FrameRate rate, out StandardFrameRates standard)
		{
			return default(bool);
		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double kTimeEpsilon;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double kFrameRateEpsilon;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly double k_MaxTimelineDurationInSeconds;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly double kFrameRateRounding;
	}
}
