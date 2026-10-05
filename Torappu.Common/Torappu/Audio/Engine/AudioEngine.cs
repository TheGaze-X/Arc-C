using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Engine
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public abstract class AudioEngine : IHotfixable
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00008F54 File Offset: 0x00007154
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x557DC70", Offset = "0x557C870", VA = "0x18557DC70", Slot = "4")]
		public virtual SoundParam CreateVoiceSound(string voicePath)
		{
			return default(SoundParam);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00008F6C File Offset: 0x0000716C
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x557DA30", Offset = "0x557C630", VA = "0x18557DA30", Slot = "5")]
		public virtual SoundParam CreateSoundForAVG(string path, bool loop)
		{
			return default(SoundParam);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00008F84 File Offset: 0x00007184
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x557D7B0", Offset = "0x557C3B0", VA = "0x18557D7B0", Slot = "6")]
		public virtual MusicParam CreateMusicForAVG(string intro, string loop)
		{
			return default(MusicParam);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DEE")]
		private TInfo _GetOrCreateCustomInfo<TInfo, T1, T2>(string signal, T1 p1, T2 p2, AudioEngine.AudioInfoCreator<TInfo, T1, T2> infoCreator) where TInfo : class, IAudioInfo
		{
			return null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x557E800", Offset = "0x557D400", VA = "0x18557E800")]
		private static AssetSoundInfo _AVGSoundFXCreator(string path, bool loop)
		{
			return null;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x557E890", Offset = "0x557D490", VA = "0x18557E890")]
		private static AssetSoundInfo _VoiceSoundCreator(string path, bool loop)
		{
			return null;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x557E720", Offset = "0x557D320", VA = "0x18557E720")]
		private static AssetMusicInfo _AVGMusicCreator(string intro, string loop)
		{
			return null;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00008F9C File Offset: 0x0000719C
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x557DF00", Offset = "0x557CB00", VA = "0x18557DF00")]
		public float GetMixerParam(string name, float defaultVal)
		{
			return 0f;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x557E640", Offset = "0x557D240", VA = "0x18557E640")]
		public void SetMixerParam(string name, float value)
		{
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x557E090", Offset = "0x557CC90", VA = "0x18557E090")]
		protected void ListenOnReloadBanks(AudioEngine.IOnReloadBanks listener)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000DF5 RID: 3573
		[Token(Token = "0x170001A5")]
		public abstract AudioAssetManager assetMgr { [Token(Token = "0x6000DF5")] get; }

		// Token: 0x06000DF6 RID: 3574
		[Token(Token = "0x6000DF6")]
		public abstract AudioPlayback CreatePlayback();

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000DF7 RID: 3575
		[Token(Token = "0x170001A6")]
		public abstract AudioEngineType engineType { [Token(Token = "0x6000DF7")] get; }

		// Token: 0x06000DF8 RID: 3576
		[Token(Token = "0x6000DF8")]
		protected abstract bool GetMixerParamImpl(string name, out float value);

		// Token: 0x06000DF9 RID: 3577
		[Token(Token = "0x6000DF9")]
		protected abstract void SetMixerParamImpl(string name, float value);

		// Token: 0x06000DFA RID: 3578
		[Token(Token = "0x6000DFA")]
		public abstract bool TransitionToSnapshot(SnapshotTransition transition);

		// Token: 0x06000DFB RID: 3579
		[Token(Token = "0x6000DFB")]
		public abstract Component CreateAudioListener(GameObject listenerObj);

		// Token: 0x06000DFC RID: 3580 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x557E190", Offset = "0x557CD90", VA = "0x18557E190", Slot = "14")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x557E1F0", Offset = "0x557CDF0", VA = "0x18557E1F0", Slot = "15")]
		protected virtual void OnReloadBanks()
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x557E130", Offset = "0x557CD30", VA = "0x18557E130", Slot = "16")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A7")]
		private protected object customData
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x557EAC0", Offset = "0x557D6C0", VA = "0x18557EAC0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x557EB20", Offset = "0x557D720", VA = "0x18557EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x557E010", Offset = "0x557CC10", VA = "0x18557E010")]
		public void Init()
		{
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x557E270", Offset = "0x557CE70", VA = "0x18557E270")]
		public void ReloadBanks(object data)
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x557DE10", Offset = "0x557CA10", VA = "0x18557DE10")]
		public void Dispose()
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x557E920", Offset = "0x557D520", VA = "0x18557E920")]
		protected AudioEngine()
		{
		}

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		private const string SOUND_LOOP_SUFFIX = "@loop";

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		public const float TIMEEPS = 0.01f;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, IAudioInfo> m_customInfoCache;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> m_concatStringCache;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, float> m_mixerParams;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<AudioEngine.IOnReloadBanks> m_reloadBanksListeners;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate281 __Hotfix0_CreateVoiceSound;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate282 __Hotfix0_CreateSoundForAVG;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate283 __Hotfix0_CreateMusicForAVG;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate284 __Hotfix0__AVGSoundFXCreator;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate284 __Hotfix0__VoiceSoundCreator;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate285 __Hotfix0__AVGMusicCreator;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate286 __Hotfix0_GetMixerParam;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate287 __Hotfix0_SetMixerParam;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ListenOnReloadBanks;

		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnInit;

		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnReloadBanks;

		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnDispose;

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate132 __Hotfix0_get_customData;

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate0 __Hotfix0_set_customData;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Init;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ReloadBanks;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000265 RID: 613
		[Token(Token = "0x2000265")]
		public interface IOnReloadBanks
		{
			// Token: 0x06000E05 RID: 3589
			[Token(Token = "0x6000E05")]
			void OnReloadBanks();
		}

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x06000E07 RID: 3591
		[Token(Token = "0x2000266")]
		protected delegate TInfo AudioInfoCreator<TInfo, P1, P2>(P1 param1, P2 param2) where TInfo : IAudioInfo;
	}
}
