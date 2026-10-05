using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CriAtomExAsrRack : CriDisposable
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetDefaultConfig_ANDROID(ref CriAtomExAsrRack.PlatformConfigAndroid platformConfig)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x36C1EF0", Offset = "0x36C0AF0", VA = "0x1836C1EF0")]
		public CriAtomExAsrRack(CriAtomExAsrRack.Config config, CriAtomExAsrRack.IPlatformConfig platformConfig)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x36C1C50", Offset = "0x36C0850", VA = "0x1836C1C50")]
		[Obsolete("Use CriAtomExAsrRack.CriAtomExAsrRack(Config config, IPlatformConfig platformConfig)")]
		public CriAtomExAsrRack(CriAtomExAsrRack.Config config, CriAtomExAsrRack.PlatformConfig platformConfig)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x36C1E20", Offset = "0x36C0A20", VA = "0x1836C1E20")]
		public CriAtomExAsrRack(int existingRackId)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x36C0E40", Offset = "0x36BFA40", VA = "0x1836C0E40")]
		public void AttachDspBusSetting(string settingName)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x36C1060", Offset = "0x36BFC60", VA = "0x1836C1060")]
		public void DetachDspBusSetting()
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x36C0D50", Offset = "0x36BF950", VA = "0x1836C0D50")]
		public void ApplyDspBusSnapshot(string snapshotName, int timeMs)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x36C1410", Offset = "0x36C0010", VA = "0x1836C1410")]
		public static string GetAppliedDspBusSnapshotName(int rackId)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x36C1360", Offset = "0x36BFF60", VA = "0x1836C1360")]
		public string GetAppliedDspBusSnapshotName()
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x36C17F0", Offset = "0x36C03F0", VA = "0x1836C17F0")]
		public CriAtomExAsrRack.PerformanceInfo GetPerformanceInfo()
		{
			return default(CriAtomExAsrRack.PerformanceInfo);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x36C1780", Offset = "0x36C0380", VA = "0x1836C1780")]
		public static CriAtomExAsrRack.PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0)
		{
			return default(CriAtomExAsrRack.PerformanceInfo);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x36C1900", Offset = "0x36C0500", VA = "0x1836C1900")]
		public void ResetPerformanceMonitor()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x36C18B0", Offset = "0x36C04B0", VA = "0x1836C18B0")]
		public static void ResetPerformanceMonitorByRackId(int rackId = 0)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x36C1950", Offset = "0x36C0550", VA = "0x1836C1950")]
		public static void SetAisacControl(int rackId, string controlName, float value)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x36C1A30", Offset = "0x36C0630", VA = "0x1836C1A30")]
		public static void SetAisacControl(int rackId, int controlId, float value)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x36C1B00", Offset = "0x36C0700", VA = "0x1836C1B00")]
		public static void SetDefaultConfig(ref CriAtomExAsrRack.Config config)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x36C1110", Offset = "0x36BFD10", VA = "0x1836C1110", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x36C1560", Offset = "0x36C0160", VA = "0x1836C1560")]
		public static void GetNumRenderedSamples(int rackId, out long numSamples, out int samplingRate)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x36C12C0", Offset = "0x36BFEC0", VA = "0x1836C12C0")]
		public static int GetAmbisonicRackId()
		{
			return 0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x36C14C0", Offset = "0x36C00C0", VA = "0x1836C14C0")]
		public static int GetChannelBasedAudioRackId()
		{
			return 0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x36C1640", Offset = "0x36C0240", VA = "0x1836C1640")]
		public static int GetObjectBasedAudioRackId()
		{
			return 0;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x36C16E0", Offset = "0x36C02E0", VA = "0x1836C16E0")]
		public static int GetPassThroughRackId()
		{
			return 0;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x1700000A")]
		public int rackId
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700000B")]
		public static CriAtomExAsrRack Default
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x36C2A40", Offset = "0x36C1640", VA = "0x1836C2A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x1700000C")]
		[Obsolete("Use CriAtomExAsrRack.Config.Default")]
		public static CriAtomExAsrRack.Config defaultConfig
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x36C2A90", Offset = "0x36C1690", VA = "0x1836C2A90")]
			get
			{
				return default(CriAtomExAsrRack.Config);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600006F RID: 111
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x36C2360", Offset = "0x36C0F60", VA = "0x1836C2360")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_Create(in CriAtomExAsrRack.Config config, IntPtr work, int work_size);

		// Token: 0x06000070 RID: 112
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x36C0F50", Offset = "0x36BFB50", VA = "0x1836C0F50")]
		[PreserveSig]
		private static extern int CRIWARE1F7577D1([In] ref CriAtomExAsrRack.Config config, [In] ref CriAtomExAsrRack.PlatformConfig platformConfig);

		// Token: 0x06000071 RID: 113
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x36C2400", Offset = "0x36C1000", VA = "0x1836C2400")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_Destroy(int rackId);

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x36C22A0", Offset = "0x36C0EA0", VA = "0x1836C22A0")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x36C2480", Offset = "0x36C1080", VA = "0x1836C2480")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId);

		// Token: 0x06000074 RID: 116
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x36C2570", Offset = "0x36C1170", VA = "0x1836C2570")]
		[PreserveSig]
		private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId);

		// Token: 0x06000075 RID: 117
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x36C21F0", Offset = "0x36C0DF0", VA = "0x1836C21F0")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs);

		// Token: 0x06000076 RID: 118
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x36C0FE0", Offset = "0x36BFBE0", VA = "0x1836C0FE0")]
		[PreserveSig]
		private static extern void CRIWARED7579187(ref CriAtomExAsrRack.Config config);

		// Token: 0x06000077 RID: 119
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x36C27E0", Offset = "0x36C13E0", VA = "0x1836C27E0")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out CriAtomExAsrRack.PerformanceInfo perfInfo);

		// Token: 0x06000078 RID: 120
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x36C2870", Offset = "0x36C1470", VA = "0x1836C2870")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId);

		// Token: 0x06000079 RID: 121
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x36C28F0", Offset = "0x36C14F0", VA = "0x1836C28F0")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value);

		// Token: 0x0600007A RID: 122
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x36C2990", Offset = "0x36C1590", VA = "0x1836C2990")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value);

		// Token: 0x0600007B RID: 123
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x36C2660", Offset = "0x36C1260", VA = "0x1836C2660")]
		[PreserveSig]
		private static extern void criAtomExAsrRack_GetNumRenderedSamples(int rack_id, ref long num_samples, ref int sampling_rate);

		// Token: 0x0600007C RID: 124
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x36C2500", Offset = "0x36C1100", VA = "0x1836C2500")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_GetAmbisonicRackId();

		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x36C25F0", Offset = "0x36C11F0", VA = "0x1836C25F0")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_GetChannelBasedAudioRackId();

		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x36C2700", Offset = "0x36C1300", VA = "0x1836C2700")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_GetObjectBasedAudioRackId();

		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x36C2770", Offset = "0x36C1370", VA = "0x1836C2770")]
		[PreserveSig]
		private static extern int criAtomExAsrRack_GetPassThroughRackId();

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		public const int defaultRackId = 0;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		public const int IllegalRackId = -1;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _rackId;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool hasExistingRackId;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum StreamType
		{
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			Music,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			Alarm,
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			Dtmf,
			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			Notification,
			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			Ring,
			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			System,
			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			VoiceCall
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public struct PlatformConfigAndroid : CriAtomExAsrRack.IPlatformConfig
		{
			// Token: 0x06000081 RID: 129 RVA: 0x0000224C File Offset: 0x0000044C
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			public bool IsSupportedPlatform()
			{
				return default(bool);
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002264 File Offset: 0x00000464
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x36DB870", Offset = "0x36DA470", VA = "0x1836DB870")]
			public static CriAtomExAsrRack.PlatformConfigAndroid Default()
			{
				return default(CriAtomExAsrRack.PlatformConfigAndroid);
			}

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExAsrRack.StreamType streamType;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool enableSpatialAudio;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		protected class NativeMethods
		{
			// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			internal static void criAtomExAsrRack_SetDefaultConfig_ANDROID_Macro(ref CriAtomExAsrRack.PlatformConfigAndroid config)
			{
			}

			// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NativeMethods()
			{
			}
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		public struct Config
		{
			// Token: 0x06000085 RID: 133 RVA: 0x0000227C File Offset: 0x0000047C
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x36B3DF0", Offset = "0x36B29F0", VA = "0x1836B3DF0")]
			public static CriAtomExAsrRack.Config Default()
			{
				return default(CriAtomExAsrRack.Config);
			}

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float serverFrequency;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numBuses;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int outputChannels;

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtom.SpeakerMapping speakerMapping;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int outputSamplingRate;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CriAtomEx.SoundRendererType soundRendererType;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int outputRackId;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntPtr context;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public struct PlatformConfig
		{
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reserved;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public struct PerformanceInfo
		{
			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint processCount;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint lastProcessTime;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint maxProcessTime;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint averageProcessTime;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint lastProcessInterval;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint maxProcessInterval;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint averageProcessInterval;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint lastProcessSamples;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint maxProcessSamples;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public uint averageProcessSamples;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public interface IPlatformConfig
		{
			// Token: 0x06000086 RID: 134
			[Token(Token = "0x6000086")]
			bool IsSupportedPlatform();
		}
	}
}
