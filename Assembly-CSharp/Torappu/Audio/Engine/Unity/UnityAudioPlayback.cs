using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using XLua;

namespace Torappu.Audio.Engine.Unity
{
	// Token: 0x02001FD1 RID: 8145
	[Token(Token = "0x2001FD1")]
	public class UnityAudioPlayback : AudioPlayback
	{
		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600CA2B RID: 51755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017ED")]
		private UnityAudioSchedule audioSchedule
		{
			[Token(Token = "0x600CA2B")]
			[Address(RVA = "0x34B99B0", Offset = "0x34B85B0", VA = "0x1834B99B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600CA2C RID: 51756 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA2D RID: 51757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017EE")]
		public override string name
		{
			[Token(Token = "0x600CA2C")]
			[Address(RVA = "0x34B9DB0", Offset = "0x34B89B0", VA = "0x1834B9DB0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600CA2D")]
			[Address(RVA = "0x34B9F60", Offset = "0x34B8B60", VA = "0x1834B9F60", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x0600CA2E RID: 51758 RVA: 0x000495D8 File Offset: 0x000477D8
		// (set) Token: 0x0600CA2F RID: 51759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017EF")]
		public override float pitch
		{
			[Token(Token = "0x600CA2E")]
			[Address(RVA = "0x34B9E20", Offset = "0x34B8A20", VA = "0x1834B9E20", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600CA2F")]
			[Address(RVA = "0x34B9FE0", Offset = "0x34B8BE0", VA = "0x1834B9FE0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x000495F0 File Offset: 0x000477F0
		// (set) Token: 0x0600CA31 RID: 51761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017F0")]
		public override Vector3 position
		{
			[Token(Token = "0x600CA30")]
			[Address(RVA = "0x34B9EC0", Offset = "0x34B8AC0", VA = "0x1834B9EC0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600CA31")]
			[Address(RVA = "0x34BA0C0", Offset = "0x34B8CC0", VA = "0x1834BA0C0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x00049608 File Offset: 0x00047808
		[Token(Token = "0x170017F1")]
		public override float currentTime
		{
			[Token(Token = "0x600CA32")]
			[Address(RVA = "0x34B9AA0", Offset = "0x34B86A0", VA = "0x1834B9AA0", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x0600CA33 RID: 51763 RVA: 0x00049620 File Offset: 0x00047820
		[Token(Token = "0x170017F2")]
		public override float length
		{
			[Token(Token = "0x600CA33")]
			[Address(RVA = "0x34B9C40", Offset = "0x34B8840", VA = "0x1834B9C40", Slot = "10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA34")]
		[Address(RVA = "0x34B7A30", Offset = "0x34B6630", VA = "0x1834B7A30", Slot = "18")]
		protected override void OnInit(Transform parent)
		{
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA35")]
		[Address(RVA = "0x34B7E90", Offset = "0x34B6A90", VA = "0x1834B7E90", Slot = "19")]
		public override void OnReuse()
		{
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA36")]
		[Address(RVA = "0x34B7C50", Offset = "0x34B6850", VA = "0x1834B7C50", Slot = "20")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x00049638 File Offset: 0x00047838
		[Token(Token = "0x600CA37")]
		[Address(RVA = "0x34B7860", Offset = "0x34B6460", VA = "0x1834B7860", Slot = "17")]
		public override bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA38")]
		[Address(RVA = "0x34B8310", Offset = "0x34B6F10", VA = "0x1834B8310", Slot = "12")]
		public override void PlaySound(ISoundInfo sound, AudioPlayback.PlayOptions options)
		{
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA39")]
		[Address(RVA = "0x34B8110", Offset = "0x34B6D10", VA = "0x1834B8110", Slot = "13")]
		public override void PlayMusic(IMusicInfo music, AudioPlayback.PlayOptions options)
		{
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA3A")]
		[Address(RVA = "0x34B7F00", Offset = "0x34B6B00", VA = "0x1834B7F00", Slot = "14")]
		public override void PlayMusicSyncStatus(IMusicInfo music, AudioPlayback.PlayOptions options, ChannelPlayStatus status)
		{
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA3B")]
		[Address(RVA = "0x34B8540", Offset = "0x34B7140", VA = "0x1834B8540", Slot = "16")]
		public override void SetVolume(float volume)
		{
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA3C")]
		[Address(RVA = "0x34B8620", Offset = "0x34B7220", VA = "0x1834B8620", Slot = "15")]
		public override void Stop()
		{
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x00049650 File Offset: 0x00047850
		[Token(Token = "0x600CA3D")]
		[Address(RVA = "0x34B7790", Offset = "0x34B6390", VA = "0x1834B7790", Slot = "21")]
		public override ChannelPlayStatus GetChannelPlayStatus()
		{
			return default(ChannelPlayStatus);
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA3E")]
		[Address(RVA = "0x34B7970", Offset = "0x34B6570", VA = "0x1834B7970", Slot = "22")]
		public override string LogAudioMixer()
		{
			return null;
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x00049668 File Offset: 0x00047868
		[Token(Token = "0x600CA3F")]
		[Address(RVA = "0x34B87C0", Offset = "0x34B73C0", VA = "0x1834B87C0")]
		private bool _FindActiveSourceIndex(out int index, out int targetSamples)
		{
			return default(bool);
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA40")]
		[Address(RVA = "0x34B9330", Offset = "0x34B7F30", VA = "0x1834B9330")]
		private static void _PrepareClipInput(AudioAsset asset, ref string[] clipKeys, ref AudioClip[] clips, out int clipCount)
		{
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA41")]
		[Address(RVA = "0x34B8FA0", Offset = "0x34B7BA0", VA = "0x1834B8FA0")]
		private void _PrepareAudioSources(int count)
		{
		}

		// Token: 0x0600CA42 RID: 51778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA42")]
		[Address(RVA = "0x34B8990", Offset = "0x34B7590", VA = "0x1834B8990")]
		private void _PlayAudioImpl(int clipCount, bool loop, float delay)
		{
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA43")]
		[Address(RVA = "0x34B8C60", Offset = "0x34B7860", VA = "0x1834B8C60")]
		private void _PlayAudioWithTargetStats(int clipCount, bool loop, ChannelPlayStatus channelPlayStatus)
		{
		}

		// Token: 0x0600CA44 RID: 51780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA44")]
		[Address(RVA = "0x34B9690", Offset = "0x34B8290", VA = "0x1834B9690")]
		private void _UpdateSoundProperties(ISoundInfo sound)
		{
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA45")]
		[Address(RVA = "0x34B9530", Offset = "0x34B8130", VA = "0x1834B9530")]
		private void _UpdateMusicProperties(IMusicInfo music)
		{
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA46")]
		[Address(RVA = "0x34B9420", Offset = "0x34B8020", VA = "0x1834B9420")]
		private void _UpdateAudioSourceStatus(float spatialBlend, AudioMixerGroup mixerGroup)
		{
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA47")]
		[Address(RVA = "0x34B86E0", Offset = "0x34B72E0", VA = "0x1834B86E0")]
		private UnityAudioPlayback.ChannelAudioSource _CreateAudioSource()
		{
			return null;
		}

		// Token: 0x0600CA48 RID: 51784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA48")]
		[Address(RVA = "0x34B9920", Offset = "0x34B8520", VA = "0x1834B9920")]
		public UnityAudioPlayback()
		{
		}

		// Token: 0x0400D2BE RID: 53950
		[Token(Token = "0x400D2BE")]
		[FieldOffset(Offset = "0x18")]
		private double m_realStartDspTime;

		// Token: 0x0400D2BF RID: 53951
		[Token(Token = "0x400D2BF")]
		[FieldOffset(Offset = "0x20")]
		public int loadedClipCount;

		// Token: 0x0400D2C0 RID: 53952
		[Token(Token = "0x400D2C0")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_gameObject;

		// Token: 0x0400D2C1 RID: 53953
		[Token(Token = "0x400D2C1")]
		[FieldOffset(Offset = "0x30")]
		private UnityAudioPlayback.ChannelAudioSource[] m_audioSources;

		// Token: 0x0400D2C2 RID: 53954
		[Token(Token = "0x400D2C2")]
		[FieldOffset(Offset = "0x38")]
		private AudioClip[] m_clips;

		// Token: 0x0400D2C3 RID: 53955
		[Token(Token = "0x400D2C3")]
		[FieldOffset(Offset = "0x40")]
		private string[] m_clipKeys;

		// Token: 0x0400D2C4 RID: 53956
		[Token(Token = "0x400D2C4")]
		[FieldOffset(Offset = "0x48")]
		private MixerDesc m_descCache;

		// Token: 0x0400D2C5 RID: 53957
		[Token(Token = "0x400D2C5")]
		[FieldOffset(Offset = "0x60")]
		private UnityAudioSchedule m_audioSchedule;

		// Token: 0x0400D2C6 RID: 53958
		[Token(Token = "0x400D2C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_audioSchedule;

		// Token: 0x0400D2C7 RID: 53959
		[Token(Token = "0x400D2C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0400D2C8 RID: 53960
		[Token(Token = "0x400D2C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0400D2C9 RID: 53961
		[Token(Token = "0x400D2C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_pitch;

		// Token: 0x0400D2CA RID: 53962
		[Token(Token = "0x400D2CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_pitch;

		// Token: 0x0400D2CB RID: 53963
		[Token(Token = "0x400D2CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x0400D2CC RID: 53964
		[Token(Token = "0x400D2CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_position;

		// Token: 0x0400D2CD RID: 53965
		[Token(Token = "0x400D2CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x0400D2CE RID: 53966
		[Token(Token = "0x400D2CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_length;

		// Token: 0x0400D2CF RID: 53967
		[Token(Token = "0x400D2CF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D2D0 RID: 53968
		[Token(Token = "0x400D2D0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x0400D2D1 RID: 53969
		[Token(Token = "0x400D2D1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400D2D2 RID: 53970
		[Token(Token = "0x400D2D2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsPlaying;

		// Token: 0x0400D2D3 RID: 53971
		[Token(Token = "0x400D2D3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PlaySound;

		// Token: 0x0400D2D4 RID: 53972
		[Token(Token = "0x400D2D4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PlayMusic;

		// Token: 0x0400D2D5 RID: 53973
		[Token(Token = "0x400D2D5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_PlayMusicSyncStatus;

		// Token: 0x0400D2D6 RID: 53974
		[Token(Token = "0x400D2D6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetVolume;

		// Token: 0x0400D2D7 RID: 53975
		[Token(Token = "0x400D2D7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D2D8 RID: 53976
		[Token(Token = "0x400D2D8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetChannelPlayStatus;

		// Token: 0x0400D2D9 RID: 53977
		[Token(Token = "0x400D2D9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LogAudioMixer;

		// Token: 0x0400D2DA RID: 53978
		[Token(Token = "0x400D2DA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__FindActiveSourceIndex;

		// Token: 0x0400D2DB RID: 53979
		[Token(Token = "0x400D2DB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PrepareClipInput;

		// Token: 0x0400D2DC RID: 53980
		[Token(Token = "0x400D2DC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PrepareAudioSources;

		// Token: 0x0400D2DD RID: 53981
		[Token(Token = "0x400D2DD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PlayAudioImpl;

		// Token: 0x0400D2DE RID: 53982
		[Token(Token = "0x400D2DE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__PlayAudioWithTargetStats;

		// Token: 0x0400D2DF RID: 53983
		[Token(Token = "0x400D2DF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateSoundProperties;

		// Token: 0x0400D2E0 RID: 53984
		[Token(Token = "0x400D2E0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateMusicProperties;

		// Token: 0x0400D2E1 RID: 53985
		[Token(Token = "0x400D2E1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateAudioSourceStatus;

		// Token: 0x0400D2E2 RID: 53986
		[Token(Token = "0x400D2E2")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CreateAudioSource;

		// Token: 0x0400D2E3 RID: 53987
		[Token(Token = "0x400D2E3")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001FD2 RID: 8146
		[Token(Token = "0x2001FD2")]
		public class ChannelAudioSource
		{
			// Token: 0x0600CA49 RID: 51785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA49")]
			[Address(RVA = "0x34A6D00", Offset = "0x34A5900", VA = "0x1834A6D00")]
			public void OnAllocate()
			{
			}

			// Token: 0x0600CA4A RID: 51786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA4A")]
			[Address(RVA = "0x34A6DB0", Offset = "0x34A59B0", VA = "0x1834A6DB0")]
			public void OnRecycle()
			{
			}

			// Token: 0x0600CA4B RID: 51787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA4B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ChannelAudioSource()
			{
			}

			// Token: 0x0400D2E4 RID: 53988
			[Token(Token = "0x400D2E4")]
			[FieldOffset(Offset = "0x10")]
			public AudioSource audioSource;

			// Token: 0x0400D2E5 RID: 53989
			[Token(Token = "0x400D2E5")]
			[FieldOffset(Offset = "0x18")]
			public string loadedKey;
		}
	}
}
