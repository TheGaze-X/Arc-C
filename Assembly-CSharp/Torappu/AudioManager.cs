using System;
using System.Collections;
using System.Collections.Generic;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.Audio.Engine;
using Torappu.ObjectPool;
using Torappu.Setting;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	public class AudioManager : PersistentSingleton<AudioManager>, IHotfixable, ISingletonNotAutoCreate
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0002CF70 File Offset: 0x0002B170
		// (set) Token: 0x06004BF4 RID: 19444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C8")]
		public static float musicVolume
		{
			[Token(Token = "0x6004BF3")]
			[Address(RVA = "0x17856C0", Offset = "0x17842C0", VA = "0x1817856C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BF4")]
			[Address(RVA = "0x1785C90", Offset = "0x1784890", VA = "0x181785C90")]
			set
			{
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0002CF88 File Offset: 0x0002B188
		// (set) Token: 0x06004BF6 RID: 19446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C9")]
		public static float fxVolume
		{
			[Token(Token = "0x6004BF5")]
			[Address(RVA = "0x1785590", Offset = "0x1784190", VA = "0x181785590")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BF6")]
			[Address(RVA = "0x1785C00", Offset = "0x1784800", VA = "0x181785C00")]
			set
			{
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CA")]
		public static float voiceVolume
		{
			[Token(Token = "0x6004BF7")]
			[Address(RVA = "0x1785790", Offset = "0x1784390", VA = "0x181785790")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BF8")]
			[Address(RVA = "0x1785D20", Offset = "0x1784920", VA = "0x181785D20")]
			set
			{
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CB")]
		public static AudioManager.SnapshotParam currentSnapshotParam
		{
			[Token(Token = "0x6004BF9")]
			[Address(RVA = "0x1785520", Offset = "0x1784120", VA = "0x181785520")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		public List<IRefCountedPoolItem> inspectAudioAssets
		{
			[Token(Token = "0x6004BFA")]
			[Address(RVA = "0x1785660", Offset = "0x1784260", VA = "0x181785660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		public UnityEvent<bool> OnFocusChange
		{
			[Token(Token = "0x6004BFB")]
			[Address(RVA = "0x17852E0", Offset = "0x1783EE0", VA = "0x1817852E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x177FCD0", Offset = "0x177E8D0", VA = "0x18177FCD0")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x177FBD0", Offset = "0x177E7D0", VA = "0x18177FBD0")]
		public static void Init()
		{
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x1781BA0", Offset = "0x17807A0", VA = "0x181781BA0")]
		public static void StopGroupMusicWithFade(string channelName, AudioManager.AudioFadeParam audioFadeParam)
		{
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x177F8F0", Offset = "0x177E4F0", VA = "0x18177F8F0")]
		public static AudioChannel GetChannel(string channelName)
		{
			return null;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x177FB70", Offset = "0x177E770", VA = "0x18177FB70")]
		public static AudioChannel GetMusicChannel()
		{
			return null;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x1781B00", Offset = "0x1780700", VA = "0x181781B00")]
		public static void StopChannel(string channelName, float fadeDuration = 0f)
		{
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x1781DF0", Offset = "0x17809F0", VA = "0x181781DF0")]
		public static void StopMusic(float fadeDuration = 0f)
		{
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x1782010", Offset = "0x1780C10", VA = "0x181782010")]
		public static void TransitionToDefaultSnapshot(float duration, float delay = 0f)
		{
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x1782270", Offset = "0x1780E70", VA = "0x181782270")]
		public static bool TransitionToSnapshot(string snapshot, float duration, float delay = 0f)
		{
			return default(bool);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x17817A0", Offset = "0x17803A0", VA = "0x1817817A0")]
		public static void SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation)
		{
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x177FC50", Offset = "0x177E850", VA = "0x18177FC50")]
		public static bool IsAudioChannelActive(string channelName)
		{
			return default(bool);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x177F640", Offset = "0x177E240", VA = "0x18177F640")]
		public static void ApplyChannelEffect(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x17816A0", Offset = "0x17802A0", VA = "0x1817816A0")]
		public static void RemoveChannelEffect(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x177F7F0", Offset = "0x177E3F0", VA = "0x18177F7F0")]
		public static void ClearAllChannelEffects()
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		public ObjectPool<AudioChannel> channelPool
		{
			[Token(Token = "0x6004C0A")]
			[Address(RVA = "0x1785460", Offset = "0x1784060", VA = "0x181785460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		public Dictionary<string, AudioChannel> channels
		{
			[Token(Token = "0x6004C0B")]
			[Address(RVA = "0x17854C0", Offset = "0x17840C0", VA = "0x1817854C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		// (set) Token: 0x06004C0D RID: 19469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D0")]
		private float _musicVolume
		{
			[Token(Token = "0x6004C0C")]
			[Address(RVA = "0x17853A0", Offset = "0x1783FA0", VA = "0x1817853A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C0D")]
			[Address(RVA = "0x17859E0", Offset = "0x17845E0", VA = "0x1817859E0")]
			set
			{
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x0002D000 File Offset: 0x0002B200
		// (set) Token: 0x06004C0F RID: 19471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D1")]
		private float _fxVolume
		{
			[Token(Token = "0x6004C0E")]
			[Address(RVA = "0x1785340", Offset = "0x1783F40", VA = "0x181785340")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C0F")]
			[Address(RVA = "0x17858D0", Offset = "0x17844D0", VA = "0x1817858D0")]
			set
			{
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x0002D018 File Offset: 0x0002B218
		// (set) Token: 0x06004C11 RID: 19473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D2")]
		private float _voiceVolume
		{
			[Token(Token = "0x6004C10")]
			[Address(RVA = "0x1785400", Offset = "0x1784000", VA = "0x181785400")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C11")]
			[Address(RVA = "0x1785AF0", Offset = "0x17846F0", VA = "0x181785AF0")]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x0002D030 File Offset: 0x0002B230
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D3")]
		public bool IsMuteAudio
		{
			[Token(Token = "0x6004C12")]
			[Address(RVA = "0x1785280", Offset = "0x1783E80", VA = "0x181785280")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0x1785860", Offset = "0x1784460", VA = "0x181785860")]
			set
			{
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x17832A0", Offset = "0x1781EA0", VA = "0x1817832A0")]
		private void _Init()
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x1782F80", Offset = "0x1781B80", VA = "0x181782F80")]
		private AudioChannelEffect _GenerateMuteAudioChannelEffect()
		{
			return null;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x17835F0", Offset = "0x17821F0", VA = "0x1817835F0")]
		private void _OnNoBGMWhenHideSettingChange(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x1782D70", Offset = "0x1781970", VA = "0x181782D70")]
		private AudioChannel _CreateChannel()
		{
			return null;
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x1784C40", Offset = "0x1783840", VA = "0x181784C40")]
		private void _StopMusicWithFade(string channelName, AudioManager.AudioFadeParam audioFadeParam)
		{
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x1784660", Offset = "0x1783260", VA = "0x181784660")]
		private void _SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation)
		{
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x17843A0", Offset = "0x1782FA0", VA = "0x1817843A0")]
		private void _RecycleChannel(AudioChannel channel)
		{
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x1782B00", Offset = "0x1781700", VA = "0x181782B00")]
		private void _ApplyChannelEffect(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x1784440", Offset = "0x1783040", VA = "0x181784440")]
		private void _RemoveChannelEffect(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x1784DB0", Offset = "0x17839B0", VA = "0x181784DB0")]
		private void _UpdateChannelEffects()
		{
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x17847A0", Offset = "0x17833A0", VA = "0x1817847A0")]
		private void _SetVolumeAndGlobalChannelEffects(AudioChannel targetChannel, float volume)
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x1782BD0", Offset = "0x17817D0", VA = "0x181782BD0")]
		private void _ClearAllChannelEffects()
		{
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x1783590", Offset = "0x1782190", VA = "0x181783590")]
		private void _OnAudioOptionsChanged()
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x1783510", Offset = "0x1782110", VA = "0x181783510")]
		private void _OnAudioConfigChanged(bool isDeviceChanged)
		{
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x17836E0", Offset = "0x17822E0", VA = "0x1817836E0")]
		private void _OnSettingChange(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x1780190", Offset = "0x177ED90", VA = "0x181780190", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x1782790", Offset = "0x1781390", VA = "0x181782790")]
		private void Update()
		{
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x1783100", Offset = "0x1781D00", VA = "0x181783100")]
		private void _InitEngine()
		{
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x1780A40", Offset = "0x177F640", VA = "0x181780A40")]
		public static void OnReloadBanks()
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x0002D048 File Offset: 0x0002B248
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x177FA20", Offset = "0x177E620", VA = "0x18177FA20")]
		public static float GetMixerParam(string name, float defaultVal = 0f)
		{
			return 0f;
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x17819E0", Offset = "0x17805E0", VA = "0x1817819E0")]
		public static void SetMixerParam(string name, float value)
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x1781260", Offset = "0x177FE60", VA = "0x181781260")]
		public static AudioChannel PlayVoice(string voicePath, AudioManager.AudioPlayOption playOptions)
		{
			return null;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x1780B90", Offset = "0x177F790", VA = "0x181780B90")]
		public static AudioChannel PlayMusicForAVG(string intro, string loop, AudioManager.AudioPlayOption playOptions)
		{
			return null;
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x1780FF0", Offset = "0x177FBF0", VA = "0x181780FF0")]
		public static AudioChannel PlaySoundForAVG(string asset, bool loop, AudioManager.AudioPlayOption playOptions)
		{
			return null;
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2C")]
		public static AudioChannel PlayAudio<TParam>(TParam audioParam, AudioManager.AudioPlayOption options) where TParam : IPlayAudioParam
		{
			return null;
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2D")]
		private AudioChannel _PlayAudio<TParam>(TParam audioParam, AudioManager.AudioPlayOption options) where TParam : IPlayAudioParam
		{
			return null;
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x1780DF0", Offset = "0x177F9F0", VA = "0x181780DF0")]
		public static AudioChannel PlayMusicWithSyncChannel(MusicParam audioParam, AudioManager.AudioPlayOption options, AudioManager.AudioFadeParam audioFadeParam, string channelNameToSync)
		{
			return null;
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x1783CB0", Offset = "0x17828B0", VA = "0x181783CB0")]
		private AudioChannel _PlayMusicWithSyncChannel(MusicParam audioParam, AudioManager.AudioPlayOption options, AudioManager.AudioFadeParam audioFadeParam, string channelNameToSync)
		{
			return null;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x0002D060 File Offset: 0x0002B260
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x17820A0", Offset = "0x1780CA0", VA = "0x1817820A0")]
		public static bool TransitionToSnapshot(string[] snapshots, float[] weights, float duration, float delay = 0f)
		{
			return default(bool);
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x1782550", Offset = "0x1781150", VA = "0x181782550")]
		public static IEnumerator UnloadAll(float duration = 0f, Interpolator.EaseType easeType = Interpolator.EaseType.linear)
		{
			return null;
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x1784990", Offset = "0x1783590", VA = "0x181784990")]
		private IEnumerator _StopAllChannels(float duration, Interpolator.EaseType easeType)
		{
			return null;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C33")]
		public static void PreloadAudio<TParam>(TParam param) where TParam : IPlayAudioParam
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x17814B0", Offset = "0x17800B0", VA = "0x1817814B0")]
		public static void PreloadVoice(string voicePath, string persistTag)
		{
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C35")]
		public void _PreloadAudio<TParam>(TParam param) where TParam : IPlayAudioParam
		{
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x1782610", Offset = "0x1781210", VA = "0x181782610")]
		public static void UnloadPreloadedAudios(string persistTag)
		{
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x1781F00", Offset = "0x1780B00", VA = "0x181781F00")]
		public static void StopPreloadedAudios(string persistTag)
		{
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x1782E30", Offset = "0x1781A30", VA = "0x181782E30")]
		private AudioAssetRefCollection _EnsureAudioAssetsRefCache(string persistTag)
		{
			return null;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x1784A70", Offset = "0x1783670", VA = "0x181784A70")]
		private void _StopChannelsWithAssets(AudioAssetRefCollection assetsRef)
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x1785090", Offset = "0x1783C90", VA = "0x181785090")]
		public AudioManager()
		{
		}

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		public const string SNAPSHOT_DEFAULT = "Default";

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		public const string CHANNEL_MUSIC = "MUSIC";

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		private const string CHANNEL_AUTO = "AUTO_";

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x18")]
		private UnityEvent<bool> m_onFocusChange;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x0")]
		private static string[] s_singleSnapshot;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x8")]
		private static float[] s_singleWeight;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x20")]
		private AudioOptions m_audioOptions;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_audioSourcesHolder;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x30")]
		private Component m_listener;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPool<AudioChannel> m_channelPool;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, AudioChannel> m_channels;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x48")]
		private int m_allocatedChannelID;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x50")]
		private List<AudioChannel> m_tempChannelsToRemove;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<AudioChannelEffect> m_channelEffects;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x60")]
		private float m_musicVolume;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x64")]
		private float m_fxVolume;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x68")]
		private float m_voiceVolume;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x70")]
		private AudioManager.SnapshotParam m_currentSnapshotParam;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x78")]
		private AudioChannelEffect m_muteChannelEffect;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isMuteAudio;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x88")]
		private AudioEngine m_engine;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x90")]
		private AudioAssetRefCollection m_assetsCache;

		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_musicVolume;

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_musicVolume;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fxVolume;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_fxVolume;

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_voiceVolume;

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_voiceVolume;

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentSnapshotParam;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_inspectAudioAssets;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_OnFocusChange;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnApplicationFocus;

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_StopGroupMusicWithFade;

		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetChannel;

		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetMusicChannel;

		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_StopChannel;

		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StopMusic;

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TransitionToDefaultSnapshot;

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_TransitionToSnapshot;

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetListenerPosition;

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsAudioChannelActive;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ApplyChannelEffect;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RemoveChannelEffect;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ClearAllChannelEffects;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_channelPool;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_channels;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get__musicVolume;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set__musicVolume;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get__fxVolume;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set__fxVolume;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get__voiceVolume;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set__voiceVolume;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_IsMuteAudio;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_IsMuteAudio;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GenerateMuteAudioChannelEffect;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnNoBGMWhenHideSettingChange;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CreateChannel;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__StopMusicWithFade;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SetListenerPosition;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__RecycleChannel;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ApplyChannelEffect;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__RemoveChannelEffect;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__UpdateChannelEffects;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__SetVolumeAndGlobalChannelEffects;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__ClearAllChannelEffects;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__OnAudioOptionsChanged;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnAudioConfigChanged;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnSettingChange;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__InitEngine;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnReloadBanks;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_GetMixerParam;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_SetMixerParam;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_PlayVoice;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_PlayMusicForAVG;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_PlaySoundForAVG;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_PlayAudio;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__PlayAudio;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_PlayMusicWithSyncChannel;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__PlayMusicWithSyncChannel;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix1_TransitionToSnapshot;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_UnloadAll;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__StopAllChannels;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_PreloadAudio;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_PreloadVoice;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__PreloadAudio;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_UnloadPreloadedAudios;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_StopPreloadedAudios;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__EnsureAudioAssetsRefCache;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__StopChannelsWithAssets;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000478 RID: 1144
		[Token(Token = "0x2000478")]
		public enum FXCategory
		{
			// Token: 0x0400101F RID: 4127
			[Token(Token = "0x400101F")]
			FX_UI,
			// Token: 0x04001020 RID: 4128
			[Token(Token = "0x4001020")]
			FX_BATTLE
		}

		// Token: 0x02000479 RID: 1145
		[Token(Token = "0x2000479")]
		public struct AudioFadeParam : IHotfixable
		{
			// Token: 0x06004C3B RID: 19515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C3B")]
			[Address(RVA = "0x177F510", Offset = "0x177E110", VA = "0x18177F510")]
			public void SetCommonDuration(float duration)
			{
			}

			// Token: 0x04001021 RID: 4129
			[Token(Token = "0x4001021")]
			[FieldOffset(Offset = "0x0")]
			public static AudioManager.AudioFadeParam EMPTY;

			// Token: 0x04001022 RID: 4130
			[Token(Token = "0x4001022")]
			[FieldOffset(Offset = "0x10")]
			public static AudioManager.AudioFadeParam LINEAR_PARAM;

			// Token: 0x04001023 RID: 4131
			[Token(Token = "0x4001023")]
			[FieldOffset(Offset = "0x0")]
			public Interpolator.EaseType fadeinEaseType;

			// Token: 0x04001024 RID: 4132
			[Token(Token = "0x4001024")]
			[FieldOffset(Offset = "0x4")]
			public float fadeinDuration;

			// Token: 0x04001025 RID: 4133
			[Token(Token = "0x4001025")]
			[FieldOffset(Offset = "0x8")]
			public Interpolator.EaseType fadeoutEaseType;

			// Token: 0x04001026 RID: 4134
			[Token(Token = "0x4001026")]
			[FieldOffset(Offset = "0xC")]
			public float fadeoutDuration;

			// Token: 0x04001027 RID: 4135
			[Token(Token = "0x4001027")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetCommonDuration;
		}

		// Token: 0x0200047A RID: 1146
		[Token(Token = "0x200047A")]
		public struct AudioPlayOption : IHotfixable
		{
			// Token: 0x06004C3D RID: 19517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C3D")]
			[Address(RVA = "0x1785DB0", Offset = "0x17849B0", VA = "0x181785DB0")]
			public void SetCommonAudioParam(float volume, float crossFadeDuration, float delay, Interpolator.EaseType fadeEaseType = Interpolator.EaseType.linear)
			{
			}

			// Token: 0x04001028 RID: 4136
			[Token(Token = "0x4001028")]
			[FieldOffset(Offset = "0x0")]
			public static AudioManager.AudioPlayOption DEFAULT;

			// Token: 0x04001029 RID: 4137
			[Token(Token = "0x4001029")]
			[FieldOffset(Offset = "0x40")]
			public static AudioManager.AudioPlayOption MUSIC_DEFAULT;

			// Token: 0x0400102A RID: 4138
			[Token(Token = "0x400102A")]
			[FieldOffset(Offset = "0x0")]
			public float volume;

			// Token: 0x0400102B RID: 4139
			[Token(Token = "0x400102B")]
			[FieldOffset(Offset = "0x4")]
			public float crossFadeDuration;

			// Token: 0x0400102C RID: 4140
			[Token(Token = "0x400102C")]
			[FieldOffset(Offset = "0x8")]
			public Interpolator.EaseType fadeEaseType;

			// Token: 0x0400102D RID: 4141
			[Token(Token = "0x400102D")]
			[FieldOffset(Offset = "0xC")]
			public float delay;

			// Token: 0x0400102E RID: 4142
			[Token(Token = "0x400102E")]
			[FieldOffset(Offset = "0x10")]
			public string channel;

			// Token: 0x0400102F RID: 4143
			[Token(Token = "0x400102F")]
			[FieldOffset(Offset = "0x18")]
			public bool forceReplay;

			// Token: 0x04001030 RID: 4144
			[Token(Token = "0x4001030")]
			[FieldOffset(Offset = "0x20")]
			public ValueBundle userData;

			// Token: 0x04001031 RID: 4145
			[Token(Token = "0x4001031")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_SetCommonAudioParam;
		}

		// Token: 0x0200047B RID: 1147
		[Token(Token = "0x200047B")]
		public class SnapshotParam
		{
			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06004C3F RID: 19519 RVA: 0x0002D078 File Offset: 0x0002B278
			[Token(Token = "0x170001D4")]
			public bool IsValid
			{
				[Token(Token = "0x6004C3F")]
				[Address(RVA = "0x1793340", Offset = "0x1791F40", VA = "0x181793340")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004C40 RID: 19520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C40")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SnapshotParam()
			{
			}

			// Token: 0x04001032 RID: 4146
			[Token(Token = "0x4001032")]
			[FieldOffset(Offset = "0x10")]
			public string[] snapshots;

			// Token: 0x04001033 RID: 4147
			[Token(Token = "0x4001033")]
			[FieldOffset(Offset = "0x18")]
			public float[] weights;
		}
	}
}
