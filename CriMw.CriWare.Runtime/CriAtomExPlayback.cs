using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public struct CriAtomExPlayback
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public CriAtomExPlayback(uint id)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x36E3C20", Offset = "0x36E2820", VA = "0x1836E3C20")]
		public void Stop(bool ignoresReleaseTime)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x36E3A00", Offset = "0x36E2600", VA = "0x1836E3A00")]
		public void Pause()
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x36E3A10", Offset = "0x36E2610", VA = "0x1836E3A10")]
		public void Resume(CriAtomEx.ResumeMode mode)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x36E3970", Offset = "0x36E2570", VA = "0x1836E3970")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x36E35B0", Offset = "0x36E21B0", VA = "0x1836E35B0")]
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x36E3760", Offset = "0x36E2360", VA = "0x1836E3760")]
		public CriAtomExPlayback.Status GetStatus()
		{
			return (CriAtomExPlayback.Status)0;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x36E3860", Offset = "0x36E2460", VA = "0x1836E3860")]
		public long GetTime()
		{
			return 0L;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x36E37E0", Offset = "0x36E23E0", VA = "0x1836E37E0")]
		public long GetTimeSyncedWithAudio()
		{
			return 0L;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x36E3640", Offset = "0x36E2240", VA = "0x1836E3640")]
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate)
		{
			return default(bool);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x36E36E0", Offset = "0x36E22E0", VA = "0x1836E36E0")]
		public long GetSequencePosition()
		{
			return 0L;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x36E3530", Offset = "0x36E2130", VA = "0x1836E3530")]
		public int GetCurrentBlockIndex()
		{
			return 0;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x36E38E0", Offset = "0x36E24E0", VA = "0x1836E38E0")]
		public bool GetTrackInfo(out CriAtomExPlayback.TrackInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x36E34A0", Offset = "0x36E20A0", VA = "0x1836E34A0")]
		public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info)
		{
			return default(bool);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x36E3B30", Offset = "0x36E2730", VA = "0x1836E3B30")]
		public void SetNextBlockIndex(int index)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x36E3AA0", Offset = "0x36E26A0", VA = "0x1836E3AA0")]
		public bool SetBeatSyncOffset(short timeMs)
		{
			return default(bool);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000053")]
		public uint id
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x17000054")]
		public CriAtomExPlayback.Status status
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x36E4590", Offset = "0x36E3190", VA = "0x1836E4590")]
			get
			{
				return (CriAtomExPlayback.Status)0;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x17000055")]
		public long time
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x36E45B0", Offset = "0x36E31B0", VA = "0x1836E45B0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x17000056")]
		public long timeSyncedWithAudio
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x36E45A0", Offset = "0x36E31A0", VA = "0x1836E45A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x36E3CA0", Offset = "0x36E28A0", VA = "0x1836E3CA0")]
		public void Stop()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x36E3BC0", Offset = "0x36E27C0", VA = "0x1836E3BC0")]
		public void StopWithoutReleaseTime()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x36E39F0", Offset = "0x36E25F0", VA = "0x1836E39F0")]
		public void Pause(bool sw)
		{
		}

		// Token: 0x06000474 RID: 1140
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x36E4510", Offset = "0x36E3110", VA = "0x1836E4510")]
		[PreserveSig]
		private static extern void criAtomExPlayback_Stop(uint id);

		// Token: 0x06000475 RID: 1141
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x36E4490", Offset = "0x36E3090", VA = "0x1836E4490")]
		[PreserveSig]
		private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id);

		// Token: 0x06000476 RID: 1142
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x36E4250", Offset = "0x36E2E50", VA = "0x1836E4250")]
		[PreserveSig]
		private static extern void criAtomExPlayback_Pause(uint id, bool sw);

		// Token: 0x06000477 RID: 1143
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x36E42E0", Offset = "0x36E2EE0", VA = "0x1836E42E0")]
		[PreserveSig]
		private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode);

		// Token: 0x06000478 RID: 1144
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x36E41D0", Offset = "0x36E2DD0", VA = "0x1836E41D0")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_IsPaused(uint id);

		// Token: 0x06000479 RID: 1145
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x36E4050", Offset = "0x36E2C50", VA = "0x1836E4050")]
		[PreserveSig]
		private static extern CriAtomExPlayback.Status criAtomExPlayback_GetStatus(uint id);

		// Token: 0x0600047A RID: 1146
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x36E3E10", Offset = "0x36E2A10", VA = "0x1836E3E10")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info);

		// Token: 0x0600047B RID: 1147
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x36E4150", Offset = "0x36E2D50", VA = "0x1836E4150")]
		[PreserveSig]
		private static extern long criAtomExPlayback_GetTime(uint id);

		// Token: 0x0600047C RID: 1148
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x36E40D0", Offset = "0x36E2CD0", VA = "0x1836E40D0")]
		[PreserveSig]
		private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id);

		// Token: 0x0600047D RID: 1149
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x36E3EA0", Offset = "0x36E2AA0", VA = "0x1836E3EA0")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate);

		// Token: 0x0600047E RID: 1150
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x36E3FD0", Offset = "0x36E2BD0", VA = "0x1836E3FD0")]
		[PreserveSig]
		private static extern long criAtomExPlayback_GetSequencePosition(uint id);

		// Token: 0x0600047F RID: 1151
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x36E4400", Offset = "0x36E3000", VA = "0x1836E4400")]
		[PreserveSig]
		private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index);

		// Token: 0x06000480 RID: 1152
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x36E3D90", Offset = "0x36E2990", VA = "0x1836E3D90")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id);

		// Token: 0x06000481 RID: 1153
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x36E3F40", Offset = "0x36E2B40", VA = "0x1836E3F40")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out CriAtomExPlayback.TrackInfo info);

		// Token: 0x06000482 RID: 1154
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x36E3D00", Offset = "0x36E2900", VA = "0x1836E3D00")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info);

		// Token: 0x06000483 RID: 1155
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x36E4370", Offset = "0x36E2F70", VA = "0x1836E4370")]
		[PreserveSig]
		private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs);

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		public const uint invalidId = 4294967295U;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		public enum Status
		{
			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			Prep = 1,
			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			Playing,
			// Token: 0x040002CE RID: 718
			[Token(Token = "0x40002CE")]
			Removed
		}

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		public struct TrackInfo
		{
			// Token: 0x040002CF RID: 719
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint id;

			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public CriAtomEx.CueType sequenceType;

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr playerHn;

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ushort trackNo;

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public ushort reserved;
		}
	}
}
