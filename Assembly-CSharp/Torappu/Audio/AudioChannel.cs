using System;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.Audio.Engine;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001F9C RID: 8092
	[Token(Token = "0x2001F9C")]
	public class AudioChannel : IReusable, IHotfixable
	{
		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x0600C8FB RID: 51451 RVA: 0x00049008 File Offset: 0x00047208
		// (set) Token: 0x0600C8FC RID: 51452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017CE")]
		public float volume
		{
			[Token(Token = "0x600C8FB")]
			[Address(RVA = "0x3498150", Offset = "0x3496D50", VA = "0x183498150")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C8FC")]
			[Address(RVA = "0x34983C0", Offset = "0x3496FC0", VA = "0x1834983C0")]
			set
			{
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x0600C8FD RID: 51453 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C8FE RID: 51454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017CF")]
		public string name
		{
			[Token(Token = "0x600C8FD")]
			[Address(RVA = "0x3497F80", Offset = "0x3496B80", VA = "0x183497F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C8FE")]
			[Address(RVA = "0x34981B0", Offset = "0x3496DB0", VA = "0x1834981B0")]
			set
			{
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x0600C8FF RID: 51455 RVA: 0x00049020 File Offset: 0x00047220
		// (set) Token: 0x0600C900 RID: 51456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017D0")]
		public float pitch
		{
			[Token(Token = "0x600C8FF")]
			[Address(RVA = "0x3498010", Offset = "0x3496C10", VA = "0x183498010")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C900")]
			[Address(RVA = "0x3498250", Offset = "0x3496E50", VA = "0x183498250")]
			set
			{
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x0600C901 RID: 51457 RVA: 0x00049038 File Offset: 0x00047238
		// (set) Token: 0x0600C902 RID: 51458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017D1")]
		public Vector3 position
		{
			[Token(Token = "0x600C901")]
			[Address(RVA = "0x34980A0", Offset = "0x3496CA0", VA = "0x1834980A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600C902")]
			[Address(RVA = "0x34982F0", Offset = "0x3496EF0", VA = "0x1834982F0")]
			set
			{
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x0600C903 RID: 51459 RVA: 0x00049050 File Offset: 0x00047250
		[Token(Token = "0x170017D2")]
		public bool isPlaying
		{
			[Token(Token = "0x600C903")]
			[Address(RVA = "0x3497E60", Offset = "0x3496A60", VA = "0x183497E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x0600C904 RID: 51460 RVA: 0x00049068 File Offset: 0x00047268
		[Token(Token = "0x170017D3")]
		public float length
		{
			[Token(Token = "0x600C904")]
			[Address(RVA = "0x3497EF0", Offset = "0x3496AF0", VA = "0x183497EF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C905")]
		[Address(RVA = "0x3496DE0", Offset = "0x34959E0", VA = "0x183496DE0")]
		public string LogAudioMixer()
		{
			return null;
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x00049080 File Offset: 0x00047280
		[Token(Token = "0x600C906")]
		[Address(RVA = "0x3496B10", Offset = "0x3495710", VA = "0x183496B10")]
		public float GetCurrentTimePercent()
		{
			return 0f;
		}

		// Token: 0x0600C907 RID: 51463 RVA: 0x00049098 File Offset: 0x00047298
		[Token(Token = "0x600C907")]
		[Address(RVA = "0x3496A30", Offset = "0x3495630", VA = "0x183496A30")]
		public ChannelPlayStatus GetChannelPlayStatus()
		{
			return default(ChannelPlayStatus);
		}

		// Token: 0x0600C908 RID: 51464 RVA: 0x000490B0 File Offset: 0x000472B0
		[Token(Token = "0x600C908")]
		[Address(RVA = "0x3496C10", Offset = "0x3495810", VA = "0x183496C10")]
		public ValueBundle GetUserData()
		{
			return default(ValueBundle);
		}

		// Token: 0x0600C909 RID: 51465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C909")]
		[Address(RVA = "0x34978B0", Offset = "0x34964B0", VA = "0x1834978B0")]
		public void TweenVolume(float targetVolume, float duration, float delay = 0f, Interpolator.EaseType easeType = Interpolator.EaseType.linear)
		{
		}

		// Token: 0x0600C90A RID: 51466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90A")]
		[Address(RVA = "0x34976D0", Offset = "0x34962D0", VA = "0x1834976D0")]
		public void StopTweenVolume()
		{
		}

		// Token: 0x0600C90B RID: 51467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90B")]
		[Address(RVA = "0x3497730", Offset = "0x3496330", VA = "0x183497730")]
		public void Stop(float duration = 0f, Interpolator.EaseType easeType = Interpolator.EaseType.linear)
		{
		}

		// Token: 0x0600C90C RID: 51468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90C")]
		[Address(RVA = "0x3497CE0", Offset = "0x34968E0", VA = "0x183497CE0")]
		private void _UpdateVolumes()
		{
		}

		// Token: 0x0600C90D RID: 51469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90D")]
		[Address(RVA = "0x3496C90", Offset = "0x3495890", VA = "0x183496C90")]
		public void Init(Transform parent, AudioEngine engine)
		{
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90E")]
		[Address(RVA = "0x3496F10", Offset = "0x3495B10", VA = "0x183496F10", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C90F")]
		[Address(RVA = "0x3496FB0", Offset = "0x3495BB0", VA = "0x183496FB0", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x0600C910 RID: 51472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C910")]
		[Address(RVA = "0x34979A0", Offset = "0x34965A0", VA = "0x1834979A0")]
		public void Update()
		{
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x000490C8 File Offset: 0x000472C8
		[Token(Token = "0x600C911")]
		[Address(RVA = "0x3497B10", Offset = "0x3496710", VA = "0x183497B10")]
		private bool _GetVolumeBlenderValue()
		{
			return default(bool);
		}

		// Token: 0x0600C912 RID: 51474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C912")]
		public void PlayAudio<TAudioParam>(TAudioParam param, AudioAsset asset, float delay, ValueBundle userData) where TAudioParam : IPlayAudioParam
		{
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C913")]
		[Address(RVA = "0x34972C0", Offset = "0x3495EC0", VA = "0x1834972C0")]
		public void PlayMusicWithSyncStatus(MusicParam param, AudioAsset asset, ChannelPlayStatus channelPlayStatus, ValueBundle userData)
		{
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C914")]
		[Address(RVA = "0x3497C50", Offset = "0x3496850", VA = "0x183497C50")]
		private void _Stop()
		{
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C915")]
		[Address(RVA = "0x3497BD0", Offset = "0x34967D0", VA = "0x183497BD0")]
		public void _ResetBlenders()
		{
		}

		// Token: 0x0600C916 RID: 51478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C916")]
		[Address(RVA = "0x34975C0", Offset = "0x34961C0", VA = "0x1834975C0")]
		public void PopulateAudioEffect(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C917")]
		[Address(RVA = "0x3496E90", Offset = "0x3495A90", VA = "0x183496E90")]
		public void ManualRefreshVolumeTweenBlender()
		{
		}

		// Token: 0x0600C918 RID: 51480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C918")]
		[Address(RVA = "0x34969C0", Offset = "0x34955C0", VA = "0x1834969C0")]
		public void ClearAllEffect()
		{
		}

		// Token: 0x0600C919 RID: 51481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C919")]
		[Address(RVA = "0x3497D90", Offset = "0x3496990", VA = "0x183497D90")]
		public AudioChannel()
		{
		}

		// Token: 0x0400CF8A RID: 53130
		[Token(Token = "0x400CF8A")]
		[FieldOffset(Offset = "0x10")]
		private AudioPlayback m_playback;

		// Token: 0x0400CF8B RID: 53131
		[Token(Token = "0x400CF8B")]
		[FieldOffset(Offset = "0x18")]
		private AudioEngine m_engine;

		// Token: 0x0400CF8C RID: 53132
		[Token(Token = "0x400CF8C")]
		[FieldOffset(Offset = "0x20")]
		private float m_currentBaseVolume;

		// Token: 0x0400CF8D RID: 53133
		[Token(Token = "0x400CF8D")]
		[FieldOffset(Offset = "0x24")]
		private float m_tweenStartVolume;

		// Token: 0x0400CF8E RID: 53134
		[Token(Token = "0x400CF8E")]
		[FieldOffset(Offset = "0x28")]
		private float m_tweenTargetVolume;

		// Token: 0x0400CF8F RID: 53135
		[Token(Token = "0x400CF8F")]
		[FieldOffset(Offset = "0x2C")]
		private float m_tweenStartTime;

		// Token: 0x0400CF90 RID: 53136
		[Token(Token = "0x400CF90")]
		[FieldOffset(Offset = "0x30")]
		private float m_tweenEndTime;

		// Token: 0x0400CF91 RID: 53137
		[Token(Token = "0x400CF91")]
		[FieldOffset(Offset = "0x34")]
		private bool m_stopWhenTweenEnd;

		// Token: 0x0400CF92 RID: 53138
		[Token(Token = "0x400CF92")]
		[FieldOffset(Offset = "0x38")]
		private Interpolator.EasingFunction m_easingFunction;

		// Token: 0x0400CF93 RID: 53139
		[Token(Token = "0x400CF93")]
		[FieldOffset(Offset = "0x40")]
		private ValueBundle m_userData;

		// Token: 0x0400CF94 RID: 53140
		[Token(Token = "0x400CF94")]
		[FieldOffset(Offset = "0x60")]
		public Action onChannelRecycled;

		// Token: 0x0400CF95 RID: 53141
		[Token(Token = "0x400CF95")]
		[FieldOffset(Offset = "0x68")]
		private AudioVolumeTweenBlender m_volumeTweenBlender;

		// Token: 0x0400CF96 RID: 53142
		[Token(Token = "0x400CF96")]
		[FieldOffset(Offset = "0x70")]
		private float m_cacheVolumeBlenderValue;

		// Token: 0x0400CF97 RID: 53143
		[Token(Token = "0x400CF97")]
		[FieldOffset(Offset = "0x78")]
		public IAudioInfo audioInfo;

		// Token: 0x0400CF98 RID: 53144
		[Token(Token = "0x400CF98")]
		[FieldOffset(Offset = "0x80")]
		public AudioAsset loadedAsset;

		// Token: 0x0400CF99 RID: 53145
		[Token(Token = "0x400CF99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_volume;

		// Token: 0x0400CF9A RID: 53146
		[Token(Token = "0x400CF9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_volume;

		// Token: 0x0400CF9B RID: 53147
		[Token(Token = "0x400CF9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0400CF9C RID: 53148
		[Token(Token = "0x400CF9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0400CF9D RID: 53149
		[Token(Token = "0x400CF9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pitch;

		// Token: 0x0400CF9E RID: 53150
		[Token(Token = "0x400CF9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_pitch;

		// Token: 0x0400CF9F RID: 53151
		[Token(Token = "0x400CF9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x0400CFA0 RID: 53152
		[Token(Token = "0x400CFA0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_position;

		// Token: 0x0400CFA1 RID: 53153
		[Token(Token = "0x400CFA1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x0400CFA2 RID: 53154
		[Token(Token = "0x400CFA2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_length;

		// Token: 0x0400CFA3 RID: 53155
		[Token(Token = "0x400CFA3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LogAudioMixer;

		// Token: 0x0400CFA4 RID: 53156
		[Token(Token = "0x400CFA4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCurrentTimePercent;

		// Token: 0x0400CFA5 RID: 53157
		[Token(Token = "0x400CFA5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetChannelPlayStatus;

		// Token: 0x0400CFA6 RID: 53158
		[Token(Token = "0x400CFA6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetUserData;

		// Token: 0x0400CFA7 RID: 53159
		[Token(Token = "0x400CFA7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TweenVolume;

		// Token: 0x0400CFA8 RID: 53160
		[Token(Token = "0x400CFA8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_StopTweenVolume;

		// Token: 0x0400CFA9 RID: 53161
		[Token(Token = "0x400CFA9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400CFAA RID: 53162
		[Token(Token = "0x400CFAA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateVolumes;

		// Token: 0x0400CFAB RID: 53163
		[Token(Token = "0x400CFAB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400CFAC RID: 53164
		[Token(Token = "0x400CFAC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0400CFAD RID: 53165
		[Token(Token = "0x400CFAD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400CFAE RID: 53166
		[Token(Token = "0x400CFAE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400CFAF RID: 53167
		[Token(Token = "0x400CFAF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetVolumeBlenderValue;

		// Token: 0x0400CFB0 RID: 53168
		[Token(Token = "0x400CFB0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_PlayAudio;

		// Token: 0x0400CFB1 RID: 53169
		[Token(Token = "0x400CFB1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_PlayMusicWithSyncStatus;

		// Token: 0x0400CFB2 RID: 53170
		[Token(Token = "0x400CFB2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Stop;

		// Token: 0x0400CFB3 RID: 53171
		[Token(Token = "0x400CFB3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ResetBlenders;

		// Token: 0x0400CFB4 RID: 53172
		[Token(Token = "0x400CFB4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_PopulateAudioEffect;

		// Token: 0x0400CFB5 RID: 53173
		[Token(Token = "0x400CFB5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ManualRefreshVolumeTweenBlender;

		// Token: 0x0400CFB6 RID: 53174
		[Token(Token = "0x400CFB6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ClearAllEffect;

		// Token: 0x0400CFB7 RID: 53175
		[Token(Token = "0x400CFB7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
