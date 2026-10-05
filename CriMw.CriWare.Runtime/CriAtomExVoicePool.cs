using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public abstract class CriAtomExVoicePool : CriDisposable
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x36F1830", Offset = "0x36F0430", VA = "0x1836F1830")]
		public static CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices(CriAtomExVoicePool.VoicePoolId voicePoolId)
		{
			return default(CriAtomExVoicePool.UsedVoicesInfo);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x1700005F")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x17000060")]
		public uint identifier
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x17000061")]
		public int numVoices
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x17000062")]
		public int maxChannels
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x17000063")]
		public int maxSamplingRate
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x36F16F0", Offset = "0x36F02F0", VA = "0x1836F16F0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x36F18C0", Offset = "0x36F04C0", VA = "0x1836F18C0")]
		public CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices()
		{
			return default(CriAtomExVoicePool.UsedVoicesInfo);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x36F1490", Offset = "0x36F0090", VA = "0x1836F1490")]
		public void AttachDspTimeStretch()
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x36F1370", Offset = "0x36EFF70", VA = "0x1836F1370")]
		public void AttachDspPitchShifter(CriAtomExVoicePool.PitchShifterMode mode = CriAtomExVoicePool.PitchShifterMode.Music, int windosSize = 1024, int overlapTimes = 4)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x36F1630", Offset = "0x36F0230", VA = "0x1836F1630")]
		public void DetachDsp()
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060005B1 RID: 1457
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x36F1590", Offset = "0x36F0190", VA = "0x1836F1590")]
		[PreserveSig]
		private static extern void CRIWAREA3F8BAA7(int voice_pool_id, out int num_used_voices, out int num_pool_voices);

		// Token: 0x060005B2 RID: 1458
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x36F1C60", Offset = "0x36F0860", VA = "0x1836F1C60")]
		[PreserveSig]
		private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices);

		// Token: 0x060005B3 RID: 1459
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x36F1BE0", Offset = "0x36F07E0", VA = "0x1836F1BE0")]
		[PreserveSig]
		public static extern void criAtomExVoicePool_Free(IntPtr pool);

		// Token: 0x060005B4 RID: 1460
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x36F1AB0", Offset = "0x36F06B0", VA = "0x1836F1AB0")]
		[PreserveSig]
		private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref CriAtomExVoicePool.ExTimeStretchConfig config, IntPtr work, int work_size);

		// Token: 0x060005B5 RID: 1461
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x36F1A00", Offset = "0x36F0600", VA = "0x1836F1A00")]
		[PreserveSig]
		private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref CriAtomExVoicePool.ExPitchShifterConfig config, IntPtr work, int work_size);

		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x36F1B60", Offset = "0x36F0760", VA = "0x1836F1B60")]
		[PreserveSig]
		private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool);

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x36F19A0", Offset = "0x36F05A0", VA = "0x1836F19A0")]
		protected CriAtomExVoicePool()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		public const int StandardMemoryAsrVoicePoolId = 0;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		public const int StandardStreamingAsrVoicePoolId = 1;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		public const int StandardMemoryNsrVoicePoolId = 2;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		public const int StandardStreamingNsrVoicePoolId = 3;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected IntPtr _handle;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected uint _identifier;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected int _numVoices;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected int _maxChannels;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected int _maxSamplingRate;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		public enum VoicePoolId
		{
			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			StandardMemory,
			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			StandardStreaming,
			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			HcaMxMemory = 4,
			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			HcaMxStreaming
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		public enum PitchShifterMode
		{
			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			Music,
			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			Vocal,
			// Token: 0x04000312 RID: 786
			[Token(Token = "0x4000312")]
			SoundEffect,
			// Token: 0x04000313 RID: 787
			[Token(Token = "0x4000313")]
			Speech
		}

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		public struct UsedVoicesInfo
		{
			// Token: 0x04000314 RID: 788
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numUsedVoices;

			// Token: 0x04000315 RID: 789
			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numPoolVoices;
		}

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		public struct PlayerConfig
		{
			// Token: 0x04000316 RID: 790
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxChannels;

			// Token: 0x04000317 RID: 791
			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxSamplingRate;

			// Token: 0x04000318 RID: 792
			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool streamingFlag;

			// Token: 0x04000319 RID: 793
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int soundRendererType;

			// Token: 0x0400031A RID: 794
			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int decodeLatency;

			// Token: 0x0400031B RID: 795
			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IntPtr context;
		}

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		private struct PitchShifterConfig
		{
			// Token: 0x0400031C RID: 796
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int mode;

			// Token: 0x0400031D RID: 797
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int windowSize;

			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int overlapTimes;
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		private struct ExPitchShifterConfig
		{
			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numDsp;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxChannels;

			// Token: 0x04000321 RID: 801
			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxSamplingRate;

			// Token: 0x04000322 RID: 802
			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtomExVoicePool.PitchShifterConfig config;
		}

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		private struct TimeStretchConfig
		{
			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int reserved;
		}

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		private struct ExTimeStretchConfig
		{
			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numDsp;

			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxChannels;

			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxSamplingRate;

			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtomExVoicePool.TimeStretchConfig config;
		}
	}
}
