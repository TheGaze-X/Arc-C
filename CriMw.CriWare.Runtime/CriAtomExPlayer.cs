using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public class CriAtomExPlayer : CriDisposable
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x17000057")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x17000058")]
		public bool isAvailable
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x36EF4A0", Offset = "0x36EE0A0", VA = "0x1836EF4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000487 RID: 1159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000F")]
		private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x36EB710", Offset = "0x36EA310", VA = "0x1836EB710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x36EF730", Offset = "0x36EE330", VA = "0x1836EF730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000488 RID: 1160 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000489 RID: 1161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000010")]
		public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x36EB4F0", Offset = "0x36EA0F0", VA = "0x1836EB4F0")]
			add
			{
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x36EF4F0", Offset = "0x36EE0F0", VA = "0x1836EF4F0")]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600048A RID: 1162 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600048B RID: 1163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000011")]
		private event CriAtomExSequencer.EventCallback _onSequenceCallback
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x36EB7B0", Offset = "0x36EA3B0", VA = "0x1836EB7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x36EF7D0", Offset = "0x36EE3D0", VA = "0x1836EF7D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600048C RID: 1164 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600048D RID: 1165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000012")]
		public event CriAtomExSequencer.EventCallback OnSequenceCallback
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x36EB600", Offset = "0x36EA200", VA = "0x1836EB600")]
			add
			{
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x36EF610", Offset = "0x36EE210", VA = "0x1836EF610")]
			remove
			{
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x36EB230", Offset = "0x36E9E30", VA = "0x1836EB230")]
		public CriAtomExPlayer()
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x36EB1B0", Offset = "0x36E9DB0", VA = "0x1836EB1B0")]
		public CriAtomExPlayer(int maxPath, int maxPathStrings)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x36EB140", Offset = "0x36E9D40", VA = "0x1836EB140")]
		public CriAtomExPlayer(bool enableAudioSyncedTimer)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x36EB0B0", Offset = "0x36E9CB0", VA = "0x1836EB0B0")]
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x36EB080", Offset = "0x36E9C80", VA = "0x1836EB080")]
		public CriAtomExPlayer(IntPtr existingNativeHandle)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x36EB290", Offset = "0x36E9E90", VA = "0x1836EB290")]
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x36E5860", Offset = "0x36E4460", VA = "0x1836E5860", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x36E8670", Offset = "0x36E7270", VA = "0x1836E8670")]
		public void SetCue(CriAtomExAcb acb, string name)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x36E8790", Offset = "0x36E7390", VA = "0x1836E8790")]
		public void SetCue(CriAtomExAcb acb, int id)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x36E84B0", Offset = "0x36E70B0", VA = "0x1836E84B0")]
		public void SetCueIndex(CriAtomExAcb acb, int index)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x36E83B0", Offset = "0x36E6FB0", VA = "0x1836E83B0")]
		public void SetContentId(CriFsBinder binder, int contentId)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x36E9470", Offset = "0x36E8070", VA = "0x1836E9470")]
		public void SetFile(CriFsBinder binder, string path)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x36E8960", Offset = "0x36E7560", VA = "0x1836E8960")]
		public void SetData(byte[] buffer, int size)
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x36E8890", Offset = "0x36E7490", VA = "0x1836E8890")]
		public void SetData(IntPtr buffer, int size)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x36E9650", Offset = "0x36E8250", VA = "0x1836E9650")]
		public void SetFormat(CriAtomEx.Format format)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x36E97D0", Offset = "0x36E83D0", VA = "0x1836E97D0")]
		public void SetNumChannels(int numChannels)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x36E9E90", Offset = "0x36E8A90", VA = "0x1836E9E90")]
		public void SetSamplingRate(int samplingRate)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x36E7170", Offset = "0x36E5D70", VA = "0x1836E7170")]
		public void PrepareEntryPool(int capacity, bool stopOnEmpty)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x36E6760", Offset = "0x36E5360", VA = "0x1836E6760")]
		public int GetNumEntries()
		{
			return 0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x36E6670", Offset = "0x36E5270", VA = "0x1836E6670")]
		public int GetNumConsumedEntries()
		{
			return 0;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x17000059")]
		public int entryPoolCapacity
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x36E6020", Offset = "0x36E4C20", VA = "0x1836E6020")]
		public bool EntryFile(CriFsBinder binder, string path, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x36E5B30", Offset = "0x36E4730", VA = "0x1836E5B30")]
		public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x36E5EF0", Offset = "0x36E4AF0", VA = "0x1836E5EF0")]
		public bool EntryData(byte[] buffer, int size, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x36E5DD0", Offset = "0x36E49D0", VA = "0x1836E5DD0")]
		public bool EntryData(IntPtr buffer, int size, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x36E5C70", Offset = "0x36E4870", VA = "0x1836E5C70")]
		public bool EntryCue(CriAtomExAcb acb, string name, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x36EA8C0", Offset = "0x36E94C0", VA = "0x1836EA8C0")]
		public CriAtomExPlayback Start()
		{
			return default(CriAtomExPlayback);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x36E7300", Offset = "0x36E5F00", VA = "0x1836E7300")]
		public CriAtomExPlayback Prepare()
		{
			return default(CriAtomExPlayback);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x36EA7F0", Offset = "0x36E93F0", VA = "0x1836EA7F0")]
		public bool StartAsync([Optional] IntPtr playbackId)
		{
			return default(bool);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x36E6D70", Offset = "0x36E5970", VA = "0x1836E6D70")]
		public bool IsReadyToStartAsync()
		{
			return default(bool);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x36EAA30", Offset = "0x36E9630", VA = "0x1836EAA30")]
		public void StopAsync()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00003674 File Offset: 0x00001874
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x36E65C0", Offset = "0x36E51C0", VA = "0x1836E65C0")]
		public CriAtomExPlayback GetLastPlaybackId()
		{
			return default(CriAtomExPlayback);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x36EAB80", Offset = "0x36E9780", VA = "0x1836EAB80")]
		public void Stop(bool ignoresReleaseTime)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x36E70C0", Offset = "0x36E5CC0", VA = "0x1836E70C0")]
		public void Pause()
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x36E7790", Offset = "0x36E6390", VA = "0x1836E7790")]
		public void Resume(CriAtomEx.ResumeMode mode)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x36E6CB0", Offset = "0x36E58B0", VA = "0x1836E6CB0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x36EA730", Offset = "0x36E9330", VA = "0x1836EA730")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x36E9B90", Offset = "0x36E8790", VA = "0x1836E9B90")]
		public void SetPitch(float pitch)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x36E9C50", Offset = "0x36E8850", VA = "0x1836E9C50")]
		public void SetPlaybackRatio(float ratio)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x36E9890", Offset = "0x36E8490", VA = "0x1836E9890")]
		public void SetPan3dAngle(float angle)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x36E9950", Offset = "0x36E8550", VA = "0x1836E9950")]
		public void SetPan3dInteriorDistance(float distance)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x36E9A10", Offset = "0x36E8610", VA = "0x1836E9A10")]
		public void SetPan3dVolume(float volume)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x36E9AD0", Offset = "0x36E86D0", VA = "0x1836E9AD0")]
		public void SetPanType(CriAtomEx.PanType panType)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x36EA110", Offset = "0x36E8D10", VA = "0x1836EA110")]
		public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x36E7D90", Offset = "0x36E6990", VA = "0x1836E7D90")]
		public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x36E7CC0", Offset = "0x36E68C0", VA = "0x1836E7CC0")]
		public void SetBandpassFilterParameters(float cofLow, float cofHigh)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x36E8050", Offset = "0x36E6C50", VA = "0x1836E8050")]
		public void SetBusSendLevel(string busName, float level)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x36E64D0", Offset = "0x36E50D0", VA = "0x1836E64D0")]
		public bool GetBusSendLevel(string busName, out float level)
		{
			return default(bool);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x36E8140", Offset = "0x36E6D40", VA = "0x1836E8140")]
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
		public void SetBusSendLevel(int busId, float level)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x36E7E90", Offset = "0x36E6A90", VA = "0x1836E7E90")]
		public void SetBusSendLevelOffset(string busName, float levelOffset)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x36E63E0", Offset = "0x36E4FE0", VA = "0x1836E63E0")]
		public bool GetBusSendLevelOffset(string busName, out float level)
		{
			return default(bool);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x36E7F80", Offset = "0x36E6B80", VA = "0x1836E7F80")]
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x36E4940", Offset = "0x36E3540", VA = "0x1836E4940")]
		public void AttachAisac(string globalAisacName)
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x36E5550", Offset = "0x36E4150", VA = "0x1836E5550")]
		public void DetachAisac(string globalAisacName)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x36E7A30", Offset = "0x36E6630", VA = "0x1836E7A30")]
		public void SetAisacControl(string controlName, float value)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x36E7A30", Offset = "0x36E6630", VA = "0x1836E7A30")]
		[Obsolete("Use CriAtomExPlayer.SetAisacControl")]
		public void SetAisac(string controlName, float value)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x36E7B20", Offset = "0x36E6720", VA = "0x1836E7B20")]
		public void SetAisacControl(uint controlId, float value)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x36E7B90", Offset = "0x36E6790", VA = "0x1836E7B90")]
		[Obsolete("Use SetAisacControl")]
		public void SetAisac(uint controlId, float value)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x36E61A0", Offset = "0x36E4DA0", VA = "0x1836E61A0")]
		public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
		{
			return default(bool);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x36E7940", Offset = "0x36E6540", VA = "0x1836E7940")]
		public void Set3dSource(CriAtomEx3dSource source)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x36E7850", Offset = "0x36E6450", VA = "0x1836E7850")]
		public void Set3dListener(CriAtomEx3dListener listener)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x36EA430", Offset = "0x36E9030", VA = "0x1836EA430")]
		public void SetStartTime(long startTimeMs)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x36EA370", Offset = "0x36E8F70", VA = "0x1836EA370")]
		public void SetStartTimeMicro(long startTimeUs)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x36E9590", Offset = "0x36E8190", VA = "0x1836E9590")]
		public void SetFirstBlockIndex(int index)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x36EA010", Offset = "0x36E8C10", VA = "0x1836EA010")]
		public void SetSelectorLabel(string selector, string label)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x36EADF0", Offset = "0x36E99F0", VA = "0x1836EADF0")]
		public void UnsetSelectorLabel(string selector)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x36E54A0", Offset = "0x36E40A0", VA = "0x1836E54A0")]
		public void ClearSelectorLabels()
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x36E8210", Offset = "0x36E6E10", VA = "0x1836E8210")]
		public void SetCategory(int categoryId)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x36E82D0", Offset = "0x36E6ED0", VA = "0x1836E82D0")]
		public void SetCategory(string categoryName)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x36EAD40", Offset = "0x36E9940", VA = "0x1836EAD40")]
		public void UnsetCategory()
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x36E85B0", Offset = "0x36E71B0", VA = "0x1836E85B0")]
		public void SetCuePriority(int priority)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x36EA670", Offset = "0x36E9270", VA = "0x1836EA670")]
		public void SetVoicePriority(int priority)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x36EA4F0", Offset = "0x36E90F0", VA = "0x1836EA4F0")]
		public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x36E9D10", Offset = "0x36E8910", VA = "0x1836E9D10")]
		public void SetPreDelayTime(float time)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x36E8C10", Offset = "0x36E7810", VA = "0x1836E8C10")]
		public void SetEnvelopeAttackTime(float time)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x36E8E60", Offset = "0x36E7A60", VA = "0x1836E8E60")]
		public void SetEnvelopeHoldTime(float time)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x36E8DA0", Offset = "0x36E79A0", VA = "0x1836E8DA0")]
		public void SetEnvelopeDecayTime(float time)
		{
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x36E8FF0", Offset = "0x36E7BF0", VA = "0x1836E8FF0")]
		public void SetEnvelopeReleaseTime(float time)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x36E90B0", Offset = "0x36E7CB0", VA = "0x1836E90B0")]
		public void SetEnvelopeSustainLevel(float level)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x36E4A20", Offset = "0x36E3620", VA = "0x1836E4A20")]
		public void AttachFader()
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x36E5630", Offset = "0x36E4230", VA = "0x1836E5630")]
		public void DetachFader()
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x36E93B0", Offset = "0x36E7FB0", VA = "0x1836E93B0")]
		public void SetFadeOutTime(int ms)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x36E9230", Offset = "0x36E7E30", VA = "0x1836E9230")]
		public void SetFadeInTime(int ms)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x36E9170", Offset = "0x36E7D70", VA = "0x1836E9170")]
		public void SetFadeInStartOffset(int ms)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x36E92F0", Offset = "0x36E7EF0", VA = "0x1836E92F0")]
		public void SetFadeOutEndDelay(int ms)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x36E6BF0", Offset = "0x36E57F0", VA = "0x1836E6BF0")]
		public bool IsFading()
		{
			return default(bool);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x36E7630", Offset = "0x36E6230", VA = "0x1836E7630")]
		public void ResetFaderParameters()
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x36E9710", Offset = "0x36E8310", VA = "0x1836E9710")]
		public void SetGroupNumber(int group_no)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x36EAF80", Offset = "0x36E9B80", VA = "0x1836EAF80")]
		public void Update(CriAtomExPlayback playback)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x36EAED0", Offset = "0x36E9AD0", VA = "0x1836EAED0")]
		public void UpdateAll()
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x36E76E0", Offset = "0x36E62E0", VA = "0x1836E76E0")]
		public void ResetParameters()
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x36E6B40", Offset = "0x36E5740", VA = "0x1836E6B40")]
		public long GetTime()
		{
			return 0L;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x36E6A90", Offset = "0x36E5690", VA = "0x1836E6A90")]
		public CriAtomExPlayer.Status GetStatus()
		{
			return CriAtomExPlayer.Status.Stop;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x36E6850", Offset = "0x36E5450", VA = "0x1836E6850")]
		public float GetParameterFloat32(CriAtomEx.Parameter id)
		{
			return 0f;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x36E69D0", Offset = "0x36E55D0", VA = "0x1836E69D0")]
		public uint GetParameterUint32(CriAtomEx.Parameter id)
		{
			return 0U;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x36E6910", Offset = "0x36E5510", VA = "0x1836E6910")]
		public int GetParameterSint32(CriAtomEx.Parameter id)
		{
			return 0;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x36EA2B0", Offset = "0x36E8EB0", VA = "0x1836EA2B0")]
		public void SetSoundRendererType(CriAtomEx.SoundRendererType type)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x36E9DD0", Offset = "0x36E89D0", VA = "0x1836E9DD0")]
		public void SetRandomSeed(uint seed)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x36E6E30", Offset = "0x36E5A30", VA = "0x1836E6E30")]
		public void Loop(bool sw)
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x36E7C00", Offset = "0x36E6800", VA = "0x1836E7C00")]
		public void SetAsrRackId(int asr_rack_id)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x36EA5B0", Offset = "0x36E91B0", VA = "0x1836EA5B0")]
		public void SetVoicePoolIdentifier(uint identifier)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x36E8B30", Offset = "0x36E7730", VA = "0x1836E8B30")]
		public void SetDspTimeStretchRatio(float ratio)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x36E8B10", Offset = "0x36E7710", VA = "0x1836E8B10")]
		public void SetDspPitchShifterPitch(float pitch)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x36E8A40", Offset = "0x36E7640", VA = "0x1836E8A40")]
		public void SetDspParameter(int id, float value)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x36EA1F0", Offset = "0x36E8DF0", VA = "0x1836EA1F0")]
		public void SetSequencePrepareTime(uint ms)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x36E4B00", Offset = "0x36E3700", VA = "0x1836E4B00")]
		public void AttachTween(CriAtomExTween tween)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x36E5790", Offset = "0x36E4390", VA = "0x1836E5790")]
		public void DetachTween(CriAtomExTween tween)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x36E56E0", Offset = "0x36E42E0", VA = "0x1836E56E0")]
		public void DetachTweenAll()
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x36E8B40", Offset = "0x36E7740", VA = "0x1836E8B40")]
		public void SetEnvelopeAttackCurve(CriAtomEx.CurveType curveType, float strength)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x36E8CD0", Offset = "0x36E78D0", VA = "0x1836E8CD0")]
		public void SetEnvelopeDecayCurve(CriAtomEx.CurveType curveType, float strength)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x36E8F20", Offset = "0x36E7B20", VA = "0x1836E8F20")]
		public void SetEnvelopeReleaseCurve(CriAtomEx.CurveType curveType, float strength)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x36E47A0", Offset = "0x36E33A0", VA = "0x1836E47A0")]
		public void AddOutputPort(CriAtomExOutputPort outputPort)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x36E73B0", Offset = "0x36E5FB0", VA = "0x1836E73B0")]
		public void RemoveOutputPort(CriAtomExOutputPort outputPort)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x36E5340", Offset = "0x36E3F40", VA = "0x1836E5340")]
		public void ClearOutputPorts()
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x36E4870", Offset = "0x36E3470", VA = "0x1836E4870")]
		public void AddPreferredOutputPort(CriAtomExOutputPort outputPort)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x36E7480", Offset = "0x36E6080", VA = "0x1836E7480")]
		public void RemovePreferredOutputPort(CriAtomExOutputPort outputPort)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x36E7550", Offset = "0x36E6150", VA = "0x1836E7550")]
		public void RemovePreferredOutputPort(string name)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x36E53F0", Offset = "0x36E3FF0", VA = "0x1836E53F0")]
		public void ClearPreferredOutputPorts()
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x36E9F50", Offset = "0x36E8B50", VA = "0x1836E9F50")]
		public void SetScheduleTime(long scheduleTime)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x36EACA0", Offset = "0x36E98A0", VA = "0x1836EACA0")]
		public void Stop()
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x36EAAE0", Offset = "0x36E96E0", VA = "0x1836EAAE0")]
		public void StopWithoutReleaseTime()
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x36E7110", Offset = "0x36E5D10", VA = "0x1836E7110")]
		public void Pause(bool sw)
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x36E7020", Offset = "0x36E5C20", VA = "0x1836E7020")]
		private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x36E7070", Offset = "0x36E5C70", VA = "0x1836E7070")]
		private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info)
		{
		}

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x36EBD60", Offset = "0x36EA960", VA = "0x1836EBD60")]
		[PreserveSig]
		private static extern IntPtr criAtomExPlayer_Create(ref CriAtomExPlayer.Config config, IntPtr work, int work_size);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x36EBE70", Offset = "0x36EAA70", VA = "0x1836EBE70")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Destroy(IntPtr player);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x36ED610", Offset = "0x36EC210", VA = "0x1836ED610")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x36ED750", Offset = "0x36EC350", VA = "0x1836ED750")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x36ED6B0", Offset = "0x36EC2B0", VA = "0x1836ED6B0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index);

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x36EE160", Offset = "0x36ECD60", VA = "0x1836EE160")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x36ED930", Offset = "0x36EC530", VA = "0x1836ED930")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size);

		// Token: 0x06000512 RID: 1298
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x36ED890", Offset = "0x36EC490", VA = "0x1836ED890")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size);

		// Token: 0x06000513 RID: 1299
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x36ED570", Offset = "0x36EC170", VA = "0x1836ED570")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id);

		// Token: 0x06000514 RID: 1300
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x36EEE30", Offset = "0x36EDA30", VA = "0x1836EEE30")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier);

		// Token: 0x06000515 RID: 1301
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x36EF070", Offset = "0x36EDC70", VA = "0x1836EF070")]
		[PreserveSig]
		private static extern uint criAtomExPlayer_Start(IntPtr player);

		// Token: 0x06000516 RID: 1302
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x36EC970", Offset = "0x36EB570", VA = "0x1836EC970")]
		[PreserveSig]
		private static extern uint criAtomExPlayer_Prepare(IntPtr player);

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x36EEFE0", Offset = "0x36EDBE0", VA = "0x1836EEFE0")]
		[PreserveSig]
		private static extern int criAtomExPlayer_StartAsync(IntPtr player, IntPtr playback_id);

		// Token: 0x06000518 RID: 1304
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x36EF0F0", Offset = "0x36EDCF0", VA = "0x1836EF0F0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_StopAsync(IntPtr player);

		// Token: 0x06000519 RID: 1305
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x36EC7D0", Offset = "0x36EB3D0", VA = "0x1836EC7D0")]
		[PreserveSig]
		private static extern int criAtomExPlayer_IsReadyToStartAsync(IntPtr player);

		// Token: 0x0600051A RID: 1306
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x36EC320", Offset = "0x36EAF20", VA = "0x1836EC320")]
		[PreserveSig]
		private static extern uint criAtomExPlayer_GetLastPlaybackId(IntPtr player);

		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x36EF1F0", Offset = "0x36EDDF0", VA = "0x1836EF1F0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Stop(IntPtr player);

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x36EF170", Offset = "0x36EDD70", VA = "0x1836EF170")]
		[PreserveSig]
		private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player);

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x36EC8E0", Offset = "0x36EB4E0", VA = "0x1836EC8E0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw);

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x36ECCB0", Offset = "0x36EB8B0", VA = "0x1836ECCB0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode);

		// Token: 0x0600051F RID: 1311
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x36EC750", Offset = "0x36EB350", VA = "0x1836EC750")]
		[PreserveSig]
		private static extern bool criAtomExPlayer_IsPaused(IntPtr player);

		// Token: 0x06000520 RID: 1312
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x36EC5D0", Offset = "0x36EB1D0", VA = "0x1836EC5D0")]
		[PreserveSig]
		private static extern CriAtomExPlayer.Status criAtomExPlayer_GetStatus(IntPtr player);

		// Token: 0x06000521 RID: 1313
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x36EC650", Offset = "0x36EB250", VA = "0x1836EC650")]
		[PreserveSig]
		private static extern long criAtomExPlayer_GetTime(IntPtr player);

		// Token: 0x06000522 RID: 1314
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x36EE2A0", Offset = "0x36ECEA0", VA = "0x1836EE2A0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format);

		// Token: 0x06000523 RID: 1315
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x36EE3C0", Offset = "0x36ECFC0", VA = "0x1836EE3C0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels);

		// Token: 0x06000524 RID: 1316
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x36EE8D0", Offset = "0x36ED4D0", VA = "0x1836EE8D0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate);

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x36E4FB0", Offset = "0x36E3BB0", VA = "0x1836E4FB0")]
		[PreserveSig]
		private static extern IntPtr CRIWAREA322B0F8(IntPtr player, int capacity, int max_path, bool stopOnEmpty);

		// Token: 0x06000526 RID: 1318
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x36E50E0", Offset = "0x36E3CE0", VA = "0x1836E50E0")]
		[PreserveSig]
		private static extern void CRIWAREE236F449(IntPtr pool);

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x36E5060", Offset = "0x36E3C60", VA = "0x1836E5060")]
		[PreserveSig]
		private static extern int CRIWAREB37289C3(IntPtr pool);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x36E4E00", Offset = "0x36E3A00", VA = "0x1836E4E00")]
		[PreserveSig]
		private static extern int CRIWARE37386F0F(IntPtr pool);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x36E5230", Offset = "0x36E3E30", VA = "0x1836E5230")]
		[PreserveSig]
		private static extern void CRIWAREEFFAFF4A(IntPtr pool);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x36E5160", Offset = "0x36E3D60", VA = "0x1836E5160")]
		[PreserveSig]
		private static extern bool CRIWAREE4291791(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path);

		// Token: 0x0600052B RID: 1323
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x36E4E80", Offset = "0x36E3A80", VA = "0x1836E4E80")]
		[PreserveSig]
		private static extern bool CRIWARE523ADE9C(IntPtr pool, IntPtr binder, int id, bool repeat);

		// Token: 0x0600052C RID: 1324
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x36E4BD0", Offset = "0x36E37D0", VA = "0x1836E4BD0")]
		[PreserveSig]
		private static extern bool CRIWARE07FBFC2E(IntPtr pool, byte[] buffer, int size, bool repeat);

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x36E4C90", Offset = "0x36E3890", VA = "0x1836E4C90")]
		[PreserveSig]
		private static extern bool CRIWARE07FBFC2E(IntPtr pool, IntPtr buffer, int size, bool repeat);

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x36E4D40", Offset = "0x36E3940", VA = "0x1836E4D40")]
		[PreserveSig]
		private static extern bool CRIWARE1F4B8024(IntPtr pool, IntPtr acbhn, string name, bool repeat);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x36E4F30", Offset = "0x36E3B30", VA = "0x1836E4F30")]
		[PreserveSig]
		private static extern void CRIWARE5649DC21(IntPtr pool);

		// Token: 0x06000530 RID: 1328
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x36EED10", Offset = "0x36ED910", VA = "0x1836EED10")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms);

		// Token: 0x06000531 RID: 1329
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x36EEC80", Offset = "0x36ED880", VA = "0x1836EEC80")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetStartTimeMicro(IntPtr player, long startTimeUs);

		// Token: 0x06000532 RID: 1330
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x36EEB60", Offset = "0x36ED760", VA = "0x1836EEB60")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms);

		// Token: 0x06000533 RID: 1331
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x36EC850", Offset = "0x36EB450", VA = "0x1836EC850")]
		[PreserveSig]
		private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count);

		// Token: 0x06000534 RID: 1332
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x36EF410", Offset = "0x36EE010", VA = "0x1836EF410")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Update(IntPtr player, uint id);

		// Token: 0x06000535 RID: 1333
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x36EF390", Offset = "0x36EDF90", VA = "0x1836EF390")]
		[PreserveSig]
		private static extern void criAtomExPlayer_UpdateAll(IntPtr player);

		// Token: 0x06000536 RID: 1334
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x36ECC30", Offset = "0x36EB830", VA = "0x1836ECC30")]
		[PreserveSig]
		private static extern void criAtomExPlayer_ResetParameters(IntPtr player);

		// Token: 0x06000537 RID: 1335
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x36EC3A0", Offset = "0x36EAFA0", VA = "0x1836EC3A0")]
		[PreserveSig]
		private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id);

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x36EC4C0", Offset = "0x36EB0C0", VA = "0x1836EC4C0")]
		[PreserveSig]
		private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id);

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x36EC430", Offset = "0x36EB030", VA = "0x1836EC430")]
		[PreserveSig]
		private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id);

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x36EC550", Offset = "0x36EB150", VA = "0x1836EC550")]
		[PreserveSig]
		private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x36EB850", Offset = "0x36EA450", VA = "0x1836EB850")]
		[PreserveSig]
		private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id);

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x36EEF50", Offset = "0x36EDB50", VA = "0x1836EEF50")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume);

		// Token: 0x0600053D RID: 1341
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x36EE690", Offset = "0x36ED290", VA = "0x1836EE690")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch);

		// Token: 0x0600053E RID: 1342
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x36EE720", Offset = "0x36ED320", VA = "0x1836EE720")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio);

		// Token: 0x0600053F RID: 1343
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x36EE450", Offset = "0x36ED050", VA = "0x1836EE450")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle);

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x36EE4E0", Offset = "0x36ED0E0", VA = "0x1836EE4E0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance);

		// Token: 0x06000541 RID: 1345
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x36EE570", Offset = "0x36ED170", VA = "0x1836EE570")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume);

		// Token: 0x06000542 RID: 1346
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x36EE600", Offset = "0x36ED200", VA = "0x1836EE600")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType);

		// Token: 0x06000543 RID: 1347
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x36EEAB0", Offset = "0x36ED6B0", VA = "0x1836EEAB0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level);

		// Token: 0x06000544 RID: 1348
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x36ED3A0", Offset = "0x36EBFA0", VA = "0x1836ED3A0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level);

		// Token: 0x06000545 RID: 1349
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x36ED1A0", Offset = "0x36EBDA0", VA = "0x1836ED1A0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level);

		// Token: 0x06000546 RID: 1350
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x36EC1C0", Offset = "0x36EADC0", VA = "0x1836EC1C0")]
		[PreserveSig]
		private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level);

		// Token: 0x06000547 RID: 1351
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x36ED300", Offset = "0x36EBF00", VA = "0x1836ED300")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset);

		// Token: 0x06000548 RID: 1352
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x36ED250", Offset = "0x36EBE50", VA = "0x1836ED250")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset);

		// Token: 0x06000549 RID: 1353
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x36EC270", Offset = "0x36EAE70", VA = "0x1836EC270")]
		[PreserveSig]
		private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset);

		// Token: 0x0600054A RID: 1354
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x36ED040", Offset = "0x36EBC40", VA = "0x1836ED040")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high);

		// Token: 0x0600054B RID: 1355
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x36ED0E0", Offset = "0x36EBCE0", VA = "0x1836ED0E0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q);

		// Token: 0x0600054C RID: 1356
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x36EEEC0", Offset = "0x36EDAC0", VA = "0x1836EEEC0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority);

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x36EEDA0", Offset = "0x36ED9A0", VA = "0x1836EEDA0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x36ECE60", Offset = "0x36EBA60", VA = "0x1836ECE60")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value);

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x36ECF00", Offset = "0x36EBB00", VA = "0x1836ECF00")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x36ECDD0", Offset = "0x36EB9D0", VA = "0x1836ECDD0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x36ECD40", Offset = "0x36EB940", VA = "0x1836ECD40")]
		[PreserveSig]
		private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x36ED440", Offset = "0x36EC040", VA = "0x1836ED440")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id);

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x36ED4D0", Offset = "0x36EC0D0", VA = "0x1836ED4D0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name);

		// Token: 0x06000554 RID: 1364
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x36EF270", Offset = "0x36EDE70", VA = "0x1836EF270")]
		[PreserveSig]
		private static extern void criAtomExPlayer_UnsetCategory(IntPtr player);

		// Token: 0x06000555 RID: 1365
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x36ED800", Offset = "0x36EC400", VA = "0x1836ED800")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority);

		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x36EE7B0", Offset = "0x36ED3B0", VA = "0x1836EE7B0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms);

		// Token: 0x06000557 RID: 1367
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x36EDB10", Offset = "0x36EC710", VA = "0x1836EDB10")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms);

		// Token: 0x06000558 RID: 1368
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x36EDCD0", Offset = "0x36EC8D0", VA = "0x1836EDCD0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms);

		// Token: 0x06000559 RID: 1369
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x36EDC40", Offset = "0x36EC840", VA = "0x1836EDC40")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms);

		// Token: 0x0600055A RID: 1370
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x36EDE00", Offset = "0x36ECA00", VA = "0x1836EDE00")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms);

		// Token: 0x0600055B RID: 1371
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x36EDE90", Offset = "0x36ECA90", VA = "0x1836EDE90")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level);

		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x36EBAA0", Offset = "0x36EA6A0", VA = "0x1836EBAA0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size);

		// Token: 0x0600055D RID: 1373
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x36EBA00", Offset = "0x36EA600", VA = "0x1836EBA00")]
		[PreserveSig]
		private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName);

		// Token: 0x0600055E RID: 1374
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x36EBEF0", Offset = "0x36EAAF0", VA = "0x1836EBEF0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName);

		// Token: 0x0600055F RID: 1375
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x36EBF90", Offset = "0x36EAB90", VA = "0x1836EBF90")]
		[PreserveSig]
		private static extern void criAtomExPlayer_DetachFader(IntPtr player);

		// Token: 0x06000560 RID: 1376
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x36EE0D0", Offset = "0x36ECCD0", VA = "0x1836EE0D0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms);

		// Token: 0x06000561 RID: 1377
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x36EDFB0", Offset = "0x36ECBB0", VA = "0x1836EDFB0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms);

		// Token: 0x06000562 RID: 1378
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x36EDF20", Offset = "0x36ECB20", VA = "0x1836EDF20")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms);

		// Token: 0x06000563 RID: 1379
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x36EE040", Offset = "0x36ECC40", VA = "0x1836EE040")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms);

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x36EC6D0", Offset = "0x36EB2D0", VA = "0x1836EC6D0")]
		[PreserveSig]
		private static extern bool criAtomExPlayer_IsFading(IntPtr player);

		// Token: 0x06000565 RID: 1381
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x36ECBB0", Offset = "0x36EB7B0", VA = "0x1836ECBB0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player);

		// Token: 0x06000566 RID: 1382
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x36EE330", Offset = "0x36ECF30", VA = "0x1836EE330")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no);

		// Token: 0x06000567 RID: 1383
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x36EC120", Offset = "0x36EAD20", VA = "0x1836EC120")]
		[PreserveSig]
		private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info);

		// Token: 0x06000568 RID: 1384
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x36EE210", Offset = "0x36ECE10", VA = "0x1836EE210")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index);

		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x36EE9F0", Offset = "0x36ED5F0", VA = "0x1836EE9F0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label);

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x36EF2F0", Offset = "0x36EDEF0", VA = "0x1836EF2F0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector);

		// Token: 0x0600056B RID: 1387
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x36EBCE0", Offset = "0x36EA8E0", VA = "0x1836EBCE0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player);

		// Token: 0x0600056C RID: 1388
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x36EEBF0", Offset = "0x36ED7F0", VA = "0x1836EEBF0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type);

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x36EE840", Offset = "0x36ED440", VA = "0x1836EE840")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed);

		// Token: 0x0600056E RID: 1390
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x36E52B0", Offset = "0x36E3EB0", VA = "0x1836E52B0")]
		[PreserveSig]
		private static extern void CRIWAREF8C9436A(IntPtr player, bool sw);

		// Token: 0x0600056F RID: 1391
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x36ECFB0", Offset = "0x36EBBB0", VA = "0x1836ECFB0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id);

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x36ED9D0", Offset = "0x36EC5D0", VA = "0x1836ED9D0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value);

		// Token: 0x06000571 RID: 1393
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x36EBB50", Offset = "0x36EA750", VA = "0x1836EBB50")]
		[PreserveSig]
		private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween);

		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x36EC090", Offset = "0x36EAC90", VA = "0x1836EC090")]
		[PreserveSig]
		private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween);

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x36EC010", Offset = "0x36EAC10", VA = "0x1836EC010")]
		[PreserveSig]
		private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x36EDA70", Offset = "0x36EC670", VA = "0x1836EDA70")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeAttackCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x36EDBA0", Offset = "0x36EC7A0", VA = "0x1836EDBA0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeDecayCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x36EDD60", Offset = "0x36EC960", VA = "0x1836EDD60")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetEnvelopeReleaseCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x36EB8E0", Offset = "0x36EA4E0", VA = "0x1836EB8E0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_AddOutputPort(IntPtr player, IntPtr outputPort);

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x36EC9F0", Offset = "0x36EB5F0", VA = "0x1836EC9F0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_RemoveOutputPort(IntPtr player, IntPtr outputPort);

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x36EBBE0", Offset = "0x36EA7E0", VA = "0x1836EBBE0")]
		[PreserveSig]
		private static extern void criAtomExPlayer_ClearOutputPorts(IntPtr player);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x36EB970", Offset = "0x36EA570", VA = "0x1836EB970")]
		[PreserveSig]
		private static extern void criAtomExPlayer_AddPreferredOutputPort(IntPtr player, IntPtr outputPort);

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x36ECB20", Offset = "0x36EB720", VA = "0x1836ECB20")]
		[PreserveSig]
		private static extern void criAtomExPlayer_RemovePreferredOutputPort(IntPtr player, IntPtr outputPort);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x36ECA80", Offset = "0x36EB680", VA = "0x1836ECA80")]
		[PreserveSig]
		private static extern void criAtomExPlayer_RemovePreferredOutputPortByName(IntPtr player, string name);

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x36EBC60", Offset = "0x36EA860", VA = "0x1836EBC60")]
		[PreserveSig]
		private static extern void criAtomExPlayer_ClearPreferredOutputPorts(IntPtr player);

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x36EE960", Offset = "0x36ED560", VA = "0x1836EE960")]
		[PreserveSig]
		private static extern void criAtomExPlayer_SetScheduleTime(IntPtr player, long schedule_time);

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasExistingNativeHandle;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr entryPoolHandle;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _entryPoolCapacity;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int max_path;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly uint MaxOutputPorts;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IntPtr handle;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		public enum Status
		{
			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			Stop,
			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			Prep,
			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			Playing,
			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			PlayEnd,
			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			Error
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		internal struct Config
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000580 RID: 1408 RVA: 0x0000377C File Offset: 0x0000197C
			[Token(Token = "0x1700005A")]
			public static CriAtomExPlayer.Config Default
			{
				[Token(Token = "0x6000580")]
				[Address(RVA = "0x36DEE20", Offset = "0x36DDA20", VA = "0x1836DEE20")]
				get
				{
					return default(CriAtomExPlayer.Config);
				}
			}

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxPathStrings;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxPath;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int maxAisacs;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool updatesTime;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool enableAudioSyncedTimer;
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		public enum TimeStretchParameterId
		{
			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			Ratio,
			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			FrameTime,
			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			Quality
		}

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		public enum PitchShifterParameterId
		{
			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			Pitch,
			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			Formant,
			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			Mode
		}
	}
}
