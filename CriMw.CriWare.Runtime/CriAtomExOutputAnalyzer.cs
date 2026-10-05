using System;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public class CriAtomExOutputAnalyzer : CriDisposable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x17000050")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x36E2040", Offset = "0x36E0C40", VA = "0x1836E2040")]
		public CriAtomExOutputAnalyzer(CriAtomExOutputAnalyzer.Config config)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x36E1290", Offset = "0x36DFE90", VA = "0x1836E1290", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x36E12A0", Offset = "0x36DFEA0", VA = "0x1836E12A0")]
		protected void Dispose(bool disposing)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x36E0CA0", Offset = "0x36DF8A0", VA = "0x1836E0CA0")]
		public bool AttachExPlayer(CriAtomExPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x36E1120", Offset = "0x36DFD20", VA = "0x1836E1120")]
		public void DetachExPlayer()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x36E0B40", Offset = "0x36DF740", VA = "0x1836E0B40")]
		public bool AttachDspBus(string busName)
		{
			return default(bool);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x36E0FF0", Offset = "0x36DFBF0", VA = "0x1836E0FF0")]
		public void DetachDspBus()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x36E1A50", Offset = "0x36E0650", VA = "0x1836E1A50")]
		public float GetRms(int channel)
		{
			return 0f;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x36E1BA0", Offset = "0x36E07A0", VA = "0x1836E1BA0")]
		public void GetSpectrumLevels(ref float[] levels)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x36E1890", Offset = "0x36E0490", VA = "0x1836E1890")]
		public void GetPcmData(ref float[] data, int ch)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
		public void SetPcmCaptureCallback(CriAtomExOutputAnalyzer.PcmCaptureCallback callback)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x36E1450", Offset = "0x36E0050", VA = "0x1836E1450")]
		public void ExecutePcmCaptureCallback()
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x36E1420", Offset = "0x36E0020", VA = "0x1836E1420")]
		[Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
		public void ExecutePcmCaptureCallback(CriAtomExOutputAnalyzer.PcmCaptureCallback callback)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x36E1FA0", Offset = "0x36E0BA0", VA = "0x1836E1FA0")]
		protected CriAtomExOutputAnalyzer()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x36E1830", Offset = "0x36E0430", VA = "0x1836E1830", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x36E1D30", Offset = "0x36E0930", VA = "0x1836E1D30")]
		protected void InitializeWithConfig(CriAtomExOutputAnalyzer.Config config)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x36E0E30", Offset = "0x36DFA30", VA = "0x1836E0E30")]
		[MonoPInvokeCallback(typeof(CriAtomExOutputAnalyzer.InternalPcmCaptureCallback))]
		private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData)
		{
		}

		// Token: 0x06000433 RID: 1075
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x36E2240", Offset = "0x36E0E40", VA = "0x1836E2240")]
		[PreserveSig]
		protected static extern IntPtr criAtomExOutputAnalyzer_Create([In] ref CriAtomExOutputAnalyzer.Config config);

		// Token: 0x06000434 RID: 1076
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x36E22F0", Offset = "0x36E0EF0", VA = "0x1836E22F0")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer);

		// Token: 0x06000435 RID: 1077
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x36E21B0", Offset = "0x36E0DB0", VA = "0x1836E21B0")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player);

		// Token: 0x06000436 RID: 1078
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x36E2410", Offset = "0x36E1010", VA = "0x1836E2410")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player);

		// Token: 0x06000437 RID: 1079
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x36E2110", Offset = "0x36E0D10", VA = "0x1836E2110")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName);

		// Token: 0x06000438 RID: 1080
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x36E2370", Offset = "0x36E0F70", VA = "0x1836E2370")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName);

		// Token: 0x06000439 RID: 1081
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x36E25C0", Offset = "0x36E11C0", VA = "0x1836E25C0")]
		[PreserveSig]
		protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel);

		// Token: 0x0600043A RID: 1082
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x36E2650", Offset = "0x36E1250", VA = "0x1836E2650")]
		[PreserveSig]
		protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer);

		// Token: 0x0600043B RID: 1083
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x36E2530", Offset = "0x36E1130", VA = "0x1836E2530")]
		[PreserveSig]
		protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch);

		// Token: 0x0600043C RID: 1084
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x36E24A0", Offset = "0x36E10A0", VA = "0x1836E24A0")]
		[PreserveSig]
		protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback);

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		public const int MaximumSpectrumBands = 512;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected IntPtr handle;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected CriAtomExPlayer player;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string busName;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected int numBands;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected int numCapturedPcmSamples;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected CriAtomExOutputAnalyzer.PcmCaptureCallback userPcmCaptureCallback;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected float[] dataL;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float[] dataR;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		protected const int pcmCapturerNumMaxData = 512;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static IntPtr InternalCallbackFunctionPointer;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static CriAtomExOutputAnalyzer.InternalPcmCaptureCallback DelegateObject;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float[] DataL;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static float[] DataR;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static CriAtomExOutputAnalyzer.PcmCaptureCallback UserPcmCaptureCallback;

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600043F RID: 1087
		[Token(Token = "0x2000082")]
		public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData);

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		public struct Config
		{
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enableLevelmeter;

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool enableSpectrumAnalyzer;

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool enablePcmCapture;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool enablePcmCaptureCallback;

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numSpectrumAnalyzerBands;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int numCapturedPcmSamples;
		}

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000443 RID: 1091
		[Token(Token = "0x2000084")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData);
	}
}
