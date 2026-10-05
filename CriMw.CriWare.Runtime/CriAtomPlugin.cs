using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public static class CriAtomPlugin
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void Log(string log)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x1700000D")]
		public static bool isInitialized
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x36D2980", Offset = "0x36D1580", VA = "0x1836D2980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000006")]
		public static event Action OnBeforeInitialize
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x36D2680", Offset = "0x36D1280", VA = "0x1836D2680")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x36D2AE0", Offset = "0x36D16E0", VA = "0x1836D2AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000007")]
		public static event Action OnInitialized
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x36D2880", Offset = "0x36D1480", VA = "0x1836D2880")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x36D2CE0", Offset = "0x36D18E0", VA = "0x1836D2CE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000008")]
		public static event Action OnBeforeFinalize
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x36D2580", Offset = "0x36D1180", VA = "0x1836D2580")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x36D29E0", Offset = "0x36D15E0", VA = "0x1836D29E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000009")]
		public static event Action OnFinalized
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x36D2780", Offset = "0x36D1380", VA = "0x1836D2780")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x36D2BE0", Offset = "0x36D17E0", VA = "0x1836D2BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x36D07B0", Offset = "0x36CF3B0", VA = "0x1836D07B0")]
		public static void ExecuteQueuedCueLinkCallbacks()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x36D0880", Offset = "0x36CF480", VA = "0x1836D0880")]
		public static void ExecuteQueuedEventCallbacks()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x36D06E0", Offset = "0x36CF2E0", VA = "0x1836D06E0")]
		public static void ExecuteQueuedBeatSyncCallbacks()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x36D0D10", Offset = "0x36CF910", VA = "0x1836D0D10")]
		public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x36D2130", Offset = "0x36D0D30", VA = "0x1836D2130")]
		public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x36D2060", Offset = "0x36D0C60", VA = "0x1836D2060")]
		public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x36D1D50", Offset = "0x36D0950", VA = "0x1836D1D50")]
		public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x36D1FA0", Offset = "0x36D0BA0", VA = "0x1836D1FA0")]
		public static void SetConfigAdditionalParameters_PC(long buffering_time_pc, bool use_microsoft_spatial_sound)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x36D1EE0", Offset = "0x36D0AE0", VA = "0x1836D1EE0")]
		public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x36D1E00", Offset = "0x36D0A00", VA = "0x1836D1E00")]
		public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x36D1C40", Offset = "0x36D0840", VA = "0x1836D1C40")]
		public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices, int num_mp4_streaming_voices)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports, int num_mp4_streaming_voices)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_SWITCH2(int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x36D2350", Offset = "0x36D0F50", VA = "0x1836D2350")]
		public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x36D1470", Offset = "0x36D0070", VA = "0x1836D1470")]
		public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig)
		{
			return 0;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x36D1600", Offset = "0x36D0200", VA = "0x1836D1600")]
		public static void InitializeLibrary()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x36D1A90", Offset = "0x36D0690", VA = "0x1836D1A90")]
		public static bool IsLibraryInitialized()
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x36D0950", Offset = "0x36CF550", VA = "0x1836D0950")]
		public static void FinalizeLibrary()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x36D1B30", Offset = "0x36D0730", VA = "0x1836D1B30")]
		public static void Pause(bool pause)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x36D0E70", Offset = "0x36CFA70", VA = "0x1836D0E70")]
		public static Common.CpuUsage GetCpuUsage()
		{
			return default(Common.CpuUsage);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x36D13D0", Offset = "0x36CFFD0", VA = "0x1836D13D0")]
		public static int GetOutputSamplingRate()
		{
			return 0;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x36D1330", Offset = "0x36CFF30", VA = "0x1836D1330")]
		public static int GetOutputChannels()
		{
			return 0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsInitializedForPcmOutput()
		{
			return default(bool);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x36D1210", Offset = "0x36CFE10", VA = "0x1836D1210")]
		public static ushort GetLoopCountParameterId()
		{
			return 0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x36D14B0", Offset = "0x36D00B0", VA = "0x1836D14B0")]
		public static bool GetWaveSamples(CriAtomExAcb acb, string cueName, short[] decodeLpcmBuffer)
		{
			return default(bool);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x36D04C0", Offset = "0x36CF0C0", VA = "0x1836D04C0")]
		public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x36D1170", Offset = "0x36CFD70", VA = "0x1836D1170")]
		public static CriAtomPlugin.FileOpenCondition GetFileOpenCondition()
		{
			return default(CriAtomPlugin.FileOpenCondition);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x36D0470", Offset = "0x36CF070", VA = "0x1836D0470")]
		[MonoPInvokeCallback(typeof(CriAtomPlugin.CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1)
		{
			return 0UL;
		}

		// Token: 0x060000B1 RID: 177
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x36CF430", Offset = "0x36CE030", VA = "0x1836CF430")]
		[PreserveSig]
		private static extern bool CRIWARE0DC87E1B(IntPtr acbHn, string cue_name, IntPtr decode_lpcm_buffer, long decodeLpcmBufferLength);

		// Token: 0x060000B2 RID: 178
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x36CFC00", Offset = "0x36CE800", VA = "0x1836CFC00")]
		[PreserveSig]
		private static extern void CRIWARE93D0F200(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode);

		// Token: 0x060000B3 RID: 179
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x36D0370", Offset = "0x36CEF70", VA = "0x1836D0370")]
		[PreserveSig]
		private static extern void CRIWAREF8609254(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval);

		// Token: 0x060000B4 RID: 180
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x36CFEA0", Offset = "0x36CEAA0", VA = "0x1836CFEA0")]
		[PreserveSig]
		private static extern void CRIWAREB038D089(bool enable_user_pcm_out_mode);

		// Token: 0x060000B5 RID: 181
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x36D0190", Offset = "0x36CED90", VA = "0x1836D0190")]
		[PreserveSig]
		private static extern void CRIWAREF387ABE9(long buffering_time_pc, bool use_microsoft_spatial_sound);

		// Token: 0x060000B6 RID: 182
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x36CFA90", Offset = "0x36CE690", VA = "0x1836CFA90")]
		[PreserveSig]
		private static extern void CRIWARE8556AA6E(int output, int pulse_latency_usec);

		// Token: 0x060000B7 RID: 183
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x36D0220", Offset = "0x36CEE20", VA = "0x1836D0220")]
		[PreserveSig]
		private static extern void CRIWAREF39C9ED5(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling);

		// Token: 0x060000B8 RID: 184
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x36CF6F0", Offset = "0x36CE2F0", VA = "0x1836CF6F0")]
		[PreserveSig]
		private static extern void CRIWARE4047B2C6(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type);

		// Token: 0x060000B9 RID: 185
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x36CF570", Offset = "0x36CE170", VA = "0x1836CF570")]
		[PreserveSig]
		private static extern void CRIWARE2DD8CA72();

		// Token: 0x060000BA RID: 186
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x36CF680", Offset = "0x36CE280", VA = "0x1836CF680")]
		[PreserveSig]
		public static extern bool CRIWARE398C7D3B();

		// Token: 0x060000BB RID: 187
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x36CFF20", Offset = "0x36CEB20", VA = "0x1836CFF20")]
		[PreserveSig]
		private static extern void CRIWAREC582BA6C();

		// Token: 0x060000BC RID: 188
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x36CF4F0", Offset = "0x36CE0F0", VA = "0x1836CF4F0")]
		[PreserveSig]
		private static extern void CRIWARE12A7B67D(bool pause);

		// Token: 0x060000BD RID: 189
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x36D0400", Offset = "0x36CF000", VA = "0x1836D0400")]
		[PreserveSig]
		public static extern uint CRIWAREF9C76501();

		// Token: 0x060000BE RID: 190
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x36CF930", Offset = "0x36CE530", VA = "0x1836CF930")]
		[PreserveSig]
		public static extern void CRIWARE7379256E(int code);

		// Token: 0x060000BF RID: 191
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x36CF5E0", Offset = "0x36CE1E0", VA = "0x1836CF5E0")]
		[PreserveSig]
		public static extern void CRIWARE327AA439(IntPtr cbfunc, string separator_string);

		// Token: 0x060000C0 RID: 192
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x36D0110", Offset = "0x36CED10", VA = "0x1836D0110")]
		[PreserveSig]
		public static extern void CRIWAREEC96E4D7(IntPtr cbfunc);

		// Token: 0x060000C1 RID: 193
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x36CFDC0", Offset = "0x36CE9C0", VA = "0x1836CFDC0")]
		[PreserveSig]
		private static extern void CRIWARE9D7B85D0();

		// Token: 0x060000C2 RID: 194
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x36CFF90", Offset = "0x36CEB90", VA = "0x1836CFF90")]
		[PreserveSig]
		public static extern void CRIWAREC6A6ABD9(IntPtr cbfunc);

		// Token: 0x060000C3 RID: 195
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x36D00A0", Offset = "0x36CECA0", VA = "0x1836D00A0")]
		[PreserveSig]
		private static extern void CRIWAREE53FFB06();

		// Token: 0x060000C4 RID: 196
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x36CF840", Offset = "0x36CE440", VA = "0x1836CF840")]
		[PreserveSig]
		public static extern void CRIWARE43BC08E6(IntPtr cbfunc);

		// Token: 0x060000C5 RID: 197
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x36CF9B0", Offset = "0x36CE5B0", VA = "0x1836CF9B0")]
		[PreserveSig]
		private static extern void CRIWARE78D4DCD5();

		// Token: 0x060000C6 RID: 198
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x36D0010", Offset = "0x36CEC10", VA = "0x1836D0010")]
		[PreserveSig]
		private static extern void CRIWARED100DE47(int sampling_rate_for_memory, int sampling_rate_for_streaming);

		// Token: 0x060000C7 RID: 199
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x36CF8C0", Offset = "0x36CE4C0", VA = "0x1836CF8C0")]
		[PreserveSig]
		public static extern void CRIWARE5C426122();

		// Token: 0x060000C8 RID: 200
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x36CFE30", Offset = "0x36CEA30", VA = "0x1836CFE30")]
		[PreserveSig]
		public static extern void CRIWARE9E6FE8C6();

		// Token: 0x060000C9 RID: 201
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x36D02D0", Offset = "0x36CEED0", VA = "0x1836D02D0")]
		[PreserveSig]
		public static extern void CRIWAREF824542E(IntPtr acb_hn, CriAtomPlugin.CallbackFromNativeDelegate func, IntPtr obj);

		// Token: 0x060000CA RID: 202
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x36CF7C0", Offset = "0x36CE3C0", VA = "0x1836CF7C0")]
		[PreserveSig]
		public static extern ushort CRIWARE42CC4C11(int id);

		// Token: 0x060000CB RID: 203
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x36CFA20", Offset = "0x36CE620", VA = "0x1836CFA20")]
		[PreserveSig]
		private static extern bool CRIWARE7F398A3A();

		// Token: 0x060000CC RID: 204
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x36CFB20", Offset = "0x36CE720", VA = "0x1836CFB20")]
		[PreserveSig]
		private static extern int CRIWARE8BDF4875();

		// Token: 0x060000CD RID: 205
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x36CFB90", Offset = "0x36CE790", VA = "0x1836CFB90")]
		[PreserveSig]
		private static extern int CRIWARE912275C3();

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int initializationCount;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<IntPtr> effectInterfaceList;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static bool isConfigured;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static float timeSinceStartup;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Common.CpuUsage cpuUsage;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static ushort CRIATOMPARAMETER2_ID_INVALID;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static ulong temporalStorage;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public struct FileOpenCondition
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000CF RID: 207 RVA: 0x000023B4 File Offset: 0x000005B4
			[Token(Token = "0x1700000E")]
			public bool CanLoadAcf
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x36DB250", Offset = "0x36D9E50", VA = "0x1836DB250")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x000023CC File Offset: 0x000005CC
			[Token(Token = "0x1700000F")]
			public bool CanLoadAcb
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x36DB1D0", Offset = "0x36D9DD0", VA = "0x1836DB1D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x000023E4 File Offset: 0x000005E4
			[Token(Token = "0x17000010")]
			public bool CanLoadAcbWithAwb
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x36DB1A0", Offset = "0x36D9DA0", VA = "0x1836DB1A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x000023FC File Offset: 0x000005FC
			[Token(Token = "0x17000011")]
			public bool CanAttachAwb
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x36DB120", Offset = "0x36D9D20", VA = "0x1836DB120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int freeBindsCount;

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int freeFilesCount;

			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int freeLoadersCount;
		}

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000D4 RID: 212
		[Token(Token = "0x2000012")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);
	}
}
