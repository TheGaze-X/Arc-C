using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class CriAtomExAsr
	{
		// Token: 0x0600026E RID: 622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x36C2C20", Offset = "0x36C1820", VA = "0x1836C2C20")]
		public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x36C2B00", Offset = "0x36C1700", VA = "0x1836C2B00")]
		public static void AttachBusAnalyzer(int interval, int peakHoldTime)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x36C2CC0", Offset = "0x36C18C0", VA = "0x1836C2CC0")]
		public static void DetachBusAnalyzer(string busName)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x36C2D50", Offset = "0x36C1950", VA = "0x1836C2D50")]
		public static void DetachBusAnalyzer()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x36C3060", Offset = "0x36C1C60", VA = "0x1836C3060")]
		public static void GetBusAnalyzerInfo(string busName, out CriAtomExAsr.BusAnalyzerInfo info)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x36C2E60", Offset = "0x36C1A60", VA = "0x1836C2E60")]
		[Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
		public static void GetBusAnalyzerInfo(int busId, out CriAtomExAsr.BusAnalyzerInfo info)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x36C3830", Offset = "0x36C2430", VA = "0x1836C3830")]
		public static void SetBusVolume(string busName, float volume)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x36C38D0", Offset = "0x36C24D0", VA = "0x1836C38D0")]
		[Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
		public static void SetBusVolume(int busId, float volume)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x36C3770", Offset = "0x36C2370", VA = "0x1836C3770")]
		public static void SetBusSendLevel(string busName, string sendTo, float level)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x36C36D0", Offset = "0x36C22D0", VA = "0x1836C36D0")]
		[Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
		public static void SetBusSendLevel(int busId, int sendTo, float level)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x36C3610", Offset = "0x36C2210", VA = "0x1836C3610")]
		public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x36C3560", Offset = "0x36C2160", VA = "0x1836C3560")]
		[Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
		public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x36C3960", Offset = "0x36C2560", VA = "0x1836C3960")]
		public static void SetEffectBypass(string busName, string effectName, bool bypass)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x36C3A20", Offset = "0x36C2620", VA = "0x1836C3A20")]
		public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x36C3320", Offset = "0x36C1F20", VA = "0x1836C3320")]
		public static float GetEffectParameter(string busName, string effectName, uint parameterIndex)
		{
			return 0f;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x36C34E0", Offset = "0x36C20E0", VA = "0x1836C34E0")]
		public static bool RegisterEffectInterface(IntPtr afx_interface)
		{
			return default(bool);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x36C3B90", Offset = "0x36C2790", VA = "0x1836C3B90")]
		public static void UnregisterEffectInterface(IntPtr afx_interface)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x36C3280", Offset = "0x36C1E80", VA = "0x1836C3280")]
		public static void GetBusVolume(string busName, out float volume)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x36C2DE0", Offset = "0x36C19E0", VA = "0x1836C2DE0")]
		public static void EnableBinauralizer(bool enabled)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x36C33F0", Offset = "0x36C1FF0", VA = "0x1836C33F0")]
		public static bool IsEnabledBinauralizer()
		{
			return default(bool);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer)
		{
			return 0;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		public static int GetNumBufferedPcmOutputSamples()
		{
			return 0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetPcmBufferSize(int numSamples)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x36C3460", Offset = "0x36C2060", VA = "0x1836C3460")]
		public static void PauseOutputVoice(bool sw)
		{
		}

		// Token: 0x06000286 RID: 646
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x36C3C90", Offset = "0x36C2890", VA = "0x1836C3C90")]
		[PreserveSig]
		private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref CriAtomExAsr.BusAnalyzerConfig config);

		// Token: 0x06000287 RID: 647
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x36C3D30", Offset = "0x36C2930", VA = "0x1836C3D30")]
		[PreserveSig]
		private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref CriAtomExAsr.BusAnalyzerConfig config);

		// Token: 0x06000288 RID: 648
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x36C2CC0", Offset = "0x36C18C0", VA = "0x1836C2CC0")]
		[PreserveSig]
		private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName);

		// Token: 0x06000289 RID: 649
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x36C3DC0", Offset = "0x36C29C0", VA = "0x1836C3DC0")]
		[PreserveSig]
		private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo);

		// Token: 0x0600028A RID: 650
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x36C3E40", Offset = "0x36C2A40", VA = "0x1836C3E40")]
		[PreserveSig]
		private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info);

		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x36C3EE0", Offset = "0x36C2AE0", VA = "0x1836C3EE0")]
		[PreserveSig]
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info);

		// Token: 0x0600028C RID: 652
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x36C3830", Offset = "0x36C2430", VA = "0x1836C3830")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume);

		// Token: 0x0600028D RID: 653
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x36C38D0", Offset = "0x36C24D0", VA = "0x1836C38D0")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume);

		// Token: 0x0600028E RID: 654
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x36C3770", Offset = "0x36C2370", VA = "0x1836C3770")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level);

		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x36C36D0", Offset = "0x36C22D0", VA = "0x1836C36D0")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level);

		// Token: 0x06000290 RID: 656
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x36C3610", Offset = "0x36C2210", VA = "0x1836C3610")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix);

		// Token: 0x06000291 RID: 657
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x36C3560", Offset = "0x36C2160", VA = "0x1836C3560")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix);

		// Token: 0x06000292 RID: 658
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x36C3960", Offset = "0x36C2560", VA = "0x1836C3960")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass);

		// Token: 0x06000293 RID: 659
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x36C4040", Offset = "0x36C2C40", VA = "0x1836C4040")]
		[PreserveSig]
		private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName);

		// Token: 0x06000294 RID: 660
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x36C3F70", Offset = "0x36C2B70", VA = "0x1836C3F70")]
		[PreserveSig]
		private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue);

		// Token: 0x06000295 RID: 661
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x36C3320", Offset = "0x36C1F20", VA = "0x1836C3320")]
		[PreserveSig]
		private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex);

		// Token: 0x06000296 RID: 662
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x36C34E0", Offset = "0x36C20E0", VA = "0x1836C34E0")]
		[PreserveSig]
		private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface);

		// Token: 0x06000297 RID: 663
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x36C3B90", Offset = "0x36C2790", VA = "0x1836C3B90")]
		[PreserveSig]
		private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface);

		// Token: 0x06000298 RID: 664
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x36C2DE0", Offset = "0x36C19E0", VA = "0x1836C2DE0")]
		[PreserveSig]
		private static extern void criAtomExAsr_EnableBinauralizer(bool enabled);

		// Token: 0x06000299 RID: 665
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x36C33F0", Offset = "0x36C1FF0", VA = "0x1836C33F0")]
		[PreserveSig]
		private static extern bool criAtomExAsr_IsEnabledBinauralizer();

		// Token: 0x0600029A RID: 666
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x36C3460", Offset = "0x36C2060", VA = "0x1836C3460")]
		[PreserveSig]
		private static extern void criAtomExAsr_PauseOutputVoice(bool sw);

		// Token: 0x0600029B RID: 667
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x36C3C10", Offset = "0x36C2810", VA = "0x1836C3C10")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_GetNumBuses(int rackId);

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x36C3280", Offset = "0x36C1E80", VA = "0x1836C3280")]
		[PreserveSig]
		private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume);

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CriAtomExAsr()
		{
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		private struct BusAnalyzerConfig
		{
			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int interval;

			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int peakHoldTime;
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		public struct BusAnalyzerInfo
		{
			// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x36B3660", Offset = "0x36B2260", VA = "0x1836B3660")]
			public BusAnalyzerInfo(byte[] data)
			{
			}

			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numChannels;

			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float[] rmsLevels;

			// Token: 0x040001E2 RID: 482
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] peakLevels;

			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float[] peakHoldLevels;
		}
	}
}
