using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	[Serializable]
	public class CriAtomConfig
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x36DF080", Offset = "0x36DDC80", VA = "0x1836DF080")]
		public CriAtomConfig()
		{
		}

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x10")]
		public string acfFileName;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x18")]
		public int maxVirtualVoices;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x1C")]
		public int maxVoiceLimitGroups;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x20")]
		public int maxCategories;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x24")]
		public int maxAisacs;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x28")]
		public int maxBusSends;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x2C")]
		public int maxSequenceEventsPerFrame;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x30")]
		public int maxBeatSyncCallbacksPerFrame;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x34")]
		public int maxCueLinkCallbacksPerFrame;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x38")]
		public CriAtomConfig.StandardVoicePoolConfig standardVoicePoolConfig;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x40")]
		public CriAtomConfig.HcaMxVoicePoolConfig hcaMxVoicePoolConfig;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x48")]
		public int outputSamplingRate;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x4C")]
		public bool usesInGamePreview;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x50")]
		public CriAtomConfig.InGamePreviewSwitchMode inGamePreviewMode;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x54")]
		public bool switchInitializeSocket;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x55")]
		public bool switch2InitializeSocket;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x58")]
		public CriAtomConfig.InGamePreviewConfig inGamePreviewConfig;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x60")]
		public float serverFrequency;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x64")]
		public CriAtom.SpeakerMapping speakerMapping;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x68")]
		public int asrOutputChannels;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x6C")]
		public bool useRandomSeedWithTime;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x70")]
		public int categoriesPerPlayback;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x74")]
		public int maxFaders;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x78")]
		public int maxBuses;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x7C")]
		public float maxPitch;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x80")]
		public int maxParameterBlocks;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x84")]
		public CriAtomEx.SoundRendererType soundRendererType;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x88")]
		public bool keepPlayingSoundOnPause;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x89")]
		public bool enableSonicSync;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x8A")]
		public bool enableAtomSoundDisabledMode;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x8B")]
		public bool enableAtomSoundDisabledModeLinux;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x90")]
		public CriAtomConfig.EditorPcmOutputConfig editorPcmOutputConfig;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x98")]
		public int pcBufferingTime;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x9C")]
		public bool useMicrosoftSpatialSound;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0xA0")]
		public CriAtomConfig.LinuxOutput linuxOutput;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0xA4")]
		public int linuxPulseLatencyUsec;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0xA8")]
		public bool iosEnableSonicSync;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0xAC")]
		public int iosBufferingTime;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0xB0")]
		public bool iosOverrideIPodMusic;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0xB1")]
		public bool iosEnableOSNotificationHandling;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0xB2")]
		public bool androidEnableSonicSync;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0xB4")]
		public int androidBufferingTime;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0xB8")]
		public int androidStartBufferingTime;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0xC0")]
		public CriAtomConfig.AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0xC8")]
		public bool androidUsesAndroidFastMixer;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0xC9")]
		public bool androidForceToUseAsrForDefaultPlayback;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0xCA")]
		public bool androidUsesAAudio;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0xCC")]
		public int androidStreamType;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0xD0")]
		public CriAtomConfig.VitaManaVoicePoolConfig vitaManaVoicePoolConfig;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0xD8")]
		public CriAtomConfig.VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0xE0")]
		public CriAtomConfig.Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0xE8")]
		public CriAtomConfig.Ps5PortConfig ps5PortConfig;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0xF0")]
		public int ps5Mp3StreamingVoices;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0xF4")]
		public bool switchEnableSonicSync;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0xF8")]
		public CriAtomConfig.SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x100")]
		public CriAtomConfig.Switch2OpusVoicePoolConfig switch2OpusVoicePoolConfig;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x108")]
		public CriAtomConfig.Ps4Audio3dConfig ps4Audio3dConfig;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x110")]
		public int ps4Mp3StreamingVoices;

		// Token: 0x020000EB RID: 235
		[Token(Token = "0x20000EB")]
		[Serializable]
		public class StandardVoicePoolConfig
		{
			// Token: 0x060007BB RID: 1979 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x3708920", Offset = "0x3707520", VA = "0x183708920")]
			public StandardVoicePoolConfig()
			{
			}

			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000EC RID: 236
		[Token(Token = "0x20000EC")]
		[Serializable]
		public class HcaMxVoicePoolConfig
		{
			// Token: 0x060007BC RID: 1980 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HcaMxVoicePoolConfig()
			{
			}

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000ED RID: 237
		[Token(Token = "0x20000ED")]
		[Serializable]
		public enum InGamePreviewSwitchMode
		{
			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			Disable,
			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			Enable,
			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			FollowBuildSetting,
			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			Default
		}

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x20000EE")]
		[Serializable]
		public class InGamePreviewConfig
		{
			// Token: 0x060007BD RID: 1981 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x37076B0", Offset = "0x37062B0", VA = "0x1837076B0")]
			public InGamePreviewConfig()
			{
			}

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			[FieldOffset(Offset = "0x10")]
			public int maxPreviewObjects;

			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			[FieldOffset(Offset = "0x14")]
			public int communicationBufferSize;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[FieldOffset(Offset = "0x18")]
			public int playbackPositionUpdateInterval;
		}

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x20000EF")]
		[Serializable]
		public class EditorPcmOutputConfig
		{
			// Token: 0x060007BE RID: 1982 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x3707430", Offset = "0x3706030", VA = "0x183707430")]
			public EditorPcmOutputConfig()
			{
			}

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			[FieldOffset(Offset = "0x10")]
			public bool enable;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			[FieldOffset(Offset = "0x14")]
			public int bufferLength;
		}

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		public enum LinuxOutput
		{
			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			Default,
			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x400046F")]
			PulseAudio,
			// Token: 0x04000470 RID: 1136
			[Token(Token = "0x4000470")]
			ALSA
		}

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x20000F1")]
		[Serializable]
		public class AndroidLowLatencyStandardVoicePoolConfig
		{
			// Token: 0x060007BF RID: 1983 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AndroidLowLatencyStandardVoicePoolConfig()
			{
			}

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x4000471")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x04000472 RID: 1138
			[Token(Token = "0x4000472")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000F2 RID: 242
		[Token(Token = "0x20000F2")]
		[Serializable]
		public class VitaManaVoicePoolConfig
		{
			// Token: 0x060007C0 RID: 1984 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x3708DE0", Offset = "0x37079E0", VA = "0x183708DE0")]
			public VitaManaVoicePoolConfig()
			{
			}

			// Token: 0x04000473 RID: 1139
			[Token(Token = "0x4000473")]
			[FieldOffset(Offset = "0x10")]
			public int numberOfManaDecoders;
		}

		// Token: 0x020000F3 RID: 243
		[Token(Token = "0x20000F3")]
		[Serializable]
		public class VitaAtrac9VoicePoolConfig
		{
			// Token: 0x060007C1 RID: 1985 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VitaAtrac9VoicePoolConfig()
			{
			}

			// Token: 0x04000474 RID: 1140
			[Token(Token = "0x4000474")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x4000475")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000F4 RID: 244
		[Token(Token = "0x20000F4")]
		[Serializable]
		public class Ps4Atrac9VoicePoolConfig
		{
			// Token: 0x060007C2 RID: 1986 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Ps4Atrac9VoicePoolConfig()
			{
			}

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x4000476")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000F5 RID: 245
		[Token(Token = "0x20000F5")]
		[Serializable]
		public class Ps5PortConfig
		{
			// Token: 0x060007C3 RID: 1987 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x3708860", Offset = "0x3707460", VA = "0x183708860")]
			public Ps5PortConfig()
			{
			}

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0x10")]
			public int maxChannelPorts;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x14")]
			public int maxObjectPorts;
		}

		// Token: 0x020000F6 RID: 246
		[Token(Token = "0x20000F6")]
		[Serializable]
		public class SwitchOpusVoicePoolConfig
		{
			// Token: 0x060007C4 RID: 1988 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SwitchOpusVoicePoolConfig()
			{
			}

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000F7 RID: 247
		[Token(Token = "0x20000F7")]
		[Serializable]
		public class Switch2OpusVoicePoolConfig
		{
			// Token: 0x060007C5 RID: 1989 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Switch2OpusVoicePoolConfig()
			{
			}

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			[FieldOffset(Offset = "0x10")]
			public int memoryVoices;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			[FieldOffset(Offset = "0x14")]
			public int streamingVoices;
		}

		// Token: 0x020000F8 RID: 248
		[Token(Token = "0x20000F8")]
		[Serializable]
		public class Ps4Audio3dConfig
		{
			// Token: 0x060007C6 RID: 1990 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x37087F0", Offset = "0x37073F0", VA = "0x1837087F0")]
			public Ps4Audio3dConfig()
			{
			}

			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			[FieldOffset(Offset = "0x10")]
			public bool useAudio3D;

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			[FieldOffset(Offset = "0x18")]
			public CriAtomConfig.Ps4Audio3dConfig.VoicePoolConfig voicePoolConfig;

			// Token: 0x020000F9 RID: 249
			[Token(Token = "0x20000F9")]
			[Serializable]
			public class VoicePoolConfig
			{
				// Token: 0x060007C7 RID: 1991 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public VoicePoolConfig()
				{
				}

				// Token: 0x04000480 RID: 1152
				[Token(Token = "0x4000480")]
				[FieldOffset(Offset = "0x10")]
				public int memoryVoices;

				// Token: 0x04000481 RID: 1153
				[Token(Token = "0x4000481")]
				[FieldOffset(Offset = "0x14")]
				public int streamingVoices;
			}
		}
	}
}
