using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Grading
{
	// Token: 0x02001641 RID: 5697
	[Token(Token = "0x2001641")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HGGradingDetector
	{
		// Token: 0x0600813B RID: 33083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813B")]
		[Address(RVA = "0x2B082D0", Offset = "0x2B06ED0", VA = "0x182B082D0")]
		private static void _SetGradingWithLog(GradingController.GradingLevel level, string info)
		{
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813C")]
		[Address(RVA = "0x2B064E0", Offset = "0x2B050E0", VA = "0x182B064E0")]
		public static void DoGradingTest([Optional] Action<HGGradingDetector.GradingResult> onTestComplete)
		{
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813D")]
		[Address(RVA = "0x2B07790", Offset = "0x2B06390", VA = "0x182B07790")]
		private static void _GetGradingAndSetImpl(Action<HGGradingDetector.GradingResult> onTestComplete)
		{
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x00038790 File Offset: 0x00036990
		[Token(Token = "0x600813E")]
		[Address(RVA = "0x2B08350", Offset = "0x2B06F50", VA = "0x182B08350")]
		private static bool _TryGetGradingViaInitialTestResult(out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x000387A8 File Offset: 0x000369A8
		[Token(Token = "0x600813F")]
		[Address(RVA = "0x2B07360", Offset = "0x2B05F60", VA = "0x182B07360")]
		private static HGGradingDetector.GradingResult _GenerateGradingResult(GradingController.GradingLevel deviceLevel, bool isSimulator, string logInfo)
		{
			return default(HGGradingDetector.GradingResult);
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x000387C0 File Offset: 0x000369C0
		[Token(Token = "0x6008140")]
		[Address(RVA = "0x2B06AD0", Offset = "0x2B056D0", VA = "0x182B06AD0")]
		private static bool _DetectByAndroidCPULadder(List<string> cpuCandidates, CPULadder cpuLadder, out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x000387D8 File Offset: 0x000369D8
		[Token(Token = "0x6008141")]
		[Address(RVA = "0x2B07220", Offset = "0x2B05E20", VA = "0x182B07220")]
		private static bool _FindProperAndroidSoCByCPULadder(List<string> cpuCandidates, CPULadder cpuLadder, out string cpu, out CPULadder.CPUData correspondData)
		{
			return default(bool);
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x000387F0 File Offset: 0x000369F0
		[Token(Token = "0x6008142")]
		[Address(RVA = "0x2B06EA0", Offset = "0x2B05AA0", VA = "0x182B06EA0")]
		private static bool _DetectByAndroidGPULadder(string gpu, CPULadder cpuLadder, out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00038808 File Offset: 0x00036A08
		[Token(Token = "0x6008143")]
		[Address(RVA = "0x2B07020", Offset = "0x2B05C20", VA = "0x182B07020")]
		private static bool _DetectByAndroidWhiteList(string brand, string model, out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x00038820 File Offset: 0x00036A20
		[Token(Token = "0x6008144")]
		[Address(RVA = "0x2B069C0", Offset = "0x2B055C0", VA = "0x182B069C0")]
		private static bool _DetectAndroidSimulator(string processorType, out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008145")]
		[Address(RVA = "0x2B06610", Offset = "0x2B05210", VA = "0x182B06610")]
		public static string GetAndroidSOCOrModelName()
		{
			return null;
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008146")]
		[Address(RVA = "0x2B07480", Offset = "0x2B06080", VA = "0x182B07480")]
		private static List<string> _GetAndroidSOCCandidates()
		{
			return null;
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x00038838 File Offset: 0x00036A38
		[Token(Token = "0x6008147")]
		[Address(RVA = "0x2B08230", Offset = "0x2B06E30", VA = "0x182B08230")]
		private static bool _IsInvalidAndroidSOCName(string socInLowerCase)
		{
			return default(bool);
		}

		// Token: 0x06008148 RID: 33096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008148")]
		[Address(RVA = "0x2B07850", Offset = "0x2B06450", VA = "0x182B07850")]
		private static void _GradeAndroid(Action<HGGradingDetector.GradingResult> onTestComplete)
		{
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008149")]
		[Address(RVA = "0x2B07EB0", Offset = "0x2B06AB0", VA = "0x182B07EB0")]
		private static void _GradeIOS(Action<HGGradingDetector.GradingResult> onTestComplete)
		{
		}

		// Token: 0x0600814A RID: 33098 RVA: 0x00038850 File Offset: 0x00036A50
		[Token(Token = "0x600814A")]
		[Address(RVA = "0x2B06870", Offset = "0x2B05470", VA = "0x182B06870")]
		public static bool GetIsIOSAppOnMac()
		{
			return default(bool);
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x00038868 File Offset: 0x00036A68
		[Token(Token = "0x600814B")]
		[Address(RVA = "0x2B06800", Offset = "0x2B05400", VA = "0x182B06800")]
		public static int GetIOSGeneration()
		{
			return 0;
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x00038880 File Offset: 0x00036A80
		[Token(Token = "0x600814C")]
		[Address(RVA = "0x2B070C0", Offset = "0x2B05CC0", VA = "0x182B070C0")]
		private static bool _DetectByIOSGenerationLadder(int generation, CPULadder cpuLadder, out HGGradingDetector.GradingResult result)
		{
			return default(bool);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600814D")]
		[Address(RVA = "0x2B06950", Offset = "0x2B05550", VA = "0x182B06950")]
		public static void PrintDeviceInfo()
		{
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600814E")]
		[Address(RVA = "0x2B068E0", Offset = "0x2B054E0", VA = "0x182B068E0")]
		public static string GetSoc_DebugOnly()
		{
			return null;
		}

		// Token: 0x040082FB RID: 33531
		[Token(Token = "0x40082FB")]
		private const string INVALID_SOC_NAME = "placeholder";

		// Token: 0x040082FC RID: 33532
		[Token(Token = "0x40082FC")]
		private const string IOS_ON_MAC_SDK_IDENTIFIER = "YES";

		// Token: 0x040082FD RID: 33533
		[Token(Token = "0x40082FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PerformanceTest.DeviceLevel s_initialTestLevel;

		// Token: 0x040082FE RID: 33534
		[Token(Token = "0x40082FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float s_initialTestScore;

		// Token: 0x040082FF RID: 33535
		[Token(Token = "0x40082FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetGradingWithLog;

		// Token: 0x04008300 RID: 33536
		[Token(Token = "0x4008300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoGradingTest;

		// Token: 0x04008301 RID: 33537
		[Token(Token = "0x4008301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetGradingAndSetImpl;

		// Token: 0x04008302 RID: 33538
		[Token(Token = "0x4008302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetGradingViaInitialTestResult;

		// Token: 0x04008303 RID: 33539
		[Token(Token = "0x4008303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateGradingResult;

		// Token: 0x04008304 RID: 33540
		[Token(Token = "0x4008304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DetectByAndroidCPULadder;

		// Token: 0x04008305 RID: 33541
		[Token(Token = "0x4008305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FindProperAndroidSoCByCPULadder;

		// Token: 0x04008306 RID: 33542
		[Token(Token = "0x4008306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DetectByAndroidGPULadder;

		// Token: 0x04008307 RID: 33543
		[Token(Token = "0x4008307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DetectByAndroidWhiteList;

		// Token: 0x04008308 RID: 33544
		[Token(Token = "0x4008308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DetectAndroidSimulator;

		// Token: 0x04008309 RID: 33545
		[Token(Token = "0x4008309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAndroidSOCOrModelName;

		// Token: 0x0400830A RID: 33546
		[Token(Token = "0x400830A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAndroidSOCCandidates;

		// Token: 0x0400830B RID: 33547
		[Token(Token = "0x400830B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IsInvalidAndroidSOCName;

		// Token: 0x0400830C RID: 33548
		[Token(Token = "0x400830C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GradeAndroid;

		// Token: 0x0400830D RID: 33549
		[Token(Token = "0x400830D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GradeIOS;

		// Token: 0x0400830E RID: 33550
		[Token(Token = "0x400830E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetIsIOSAppOnMac;

		// Token: 0x0400830F RID: 33551
		[Token(Token = "0x400830F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetIOSGeneration;

		// Token: 0x04008310 RID: 33552
		[Token(Token = "0x4008310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DetectByIOSGenerationLadder;

		// Token: 0x04008311 RID: 33553
		[Token(Token = "0x4008311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PrintDeviceInfo;

		// Token: 0x04008312 RID: 33554
		[Token(Token = "0x4008312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetSoc_DebugOnly;

		// Token: 0x02001642 RID: 5698
		[Token(Token = "0x2001642")]
		public struct GradingResult
		{
			// Token: 0x04008313 RID: 33555
			[Token(Token = "0x4008313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GradingController.GradingLevel deviceLevel;

			// Token: 0x04008314 RID: 33556
			[Token(Token = "0x4008314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool isSimulator;
		}
	}
}
