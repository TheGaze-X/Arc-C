using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.Resource;
using XLua;

namespace Torappu.CharWord
{
	// Token: 0x02001791 RID: 6033
	[Token(Token = "0x2001791")]
	[LuaCallCSharp(GenFlag.No)]
	public class VoiceManager : Singleton<VoiceManager>, IResourceListener
	{
		// Token: 0x06009870 RID: 39024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009870")]
		[Address(RVA = "0x3134BB0", Offset = "0x31337B0", VA = "0x183134BB0")]
		private VoiceManager()
		{
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009871")]
		[Address(RVA = "0x3132A40", Offset = "0x3131640", VA = "0x183132A40", Slot = "4")]
		public void OnResourceListUpdate(bool isInit)
		{
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06009872 RID: 39026 RVA: 0x0003B5B0 File Offset: 0x000397B0
		[Token(Token = "0x17001058")]
		public bool isPlaying
		{
			[Token(Token = "0x6009872")]
			[Address(RVA = "0x3134D00", Offset = "0x3133900", VA = "0x183134D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x0003B5C8 File Offset: 0x000397C8
		[Token(Token = "0x6009873")]
		[Address(RVA = "0x3132830", Offset = "0x3131430", VA = "0x183132830")]
		public float GetCurrentTimePercent()
		{
			return 0f;
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0003B5E0 File Offset: 0x000397E0
		[Token(Token = "0x6009874")]
		[Address(RVA = "0x31328C0", Offset = "0x31314C0", VA = "0x1831328C0")]
		public VoiceManager.PlayingStatus GetPlayingStatus()
		{
			return default(VoiceManager.PlayingStatus);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0003B5F8 File Offset: 0x000397F8
		[Token(Token = "0x6009875")]
		[Address(RVA = "0x3132B10", Offset = "0x3131710", VA = "0x183132B10")]
		public VoiceManager.PlayResult PlayRandomLoadingVoice(bool overlapFlag, float crossfade = 0.1f, float delay = 0f)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0003B610 File Offset: 0x00039810
		[Token(Token = "0x6009876")]
		[Address(RVA = "0x3133310", Offset = "0x3131F10", VA = "0x183133310")]
		public VoiceManager.PlayResult PlayRandomVoice(IList<VoiceQuery> queryList, CharWordShowType showType, bool overlapFlag, float crossfade = 0.1f, float delay = 0f)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0003B628 File Offset: 0x00039828
		[Token(Token = "0x6009877")]
		[Address(RVA = "0x31337D0", Offset = "0x31323D0", VA = "0x1831337D0")]
		public VoiceManager.PlayResult PlayRandomVoice(VoiceQuery query, CharWordShowType showType, bool overlapFlag, float crossfade = 0.1f, float delay = 0f)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0003B640 File Offset: 0x00039840
		[Token(Token = "0x6009878")]
		[Address(RVA = "0x3133C70", Offset = "0x3132870", VA = "0x183133C70")]
		public VoiceManager.PlayResult PlayRandomVoice(VoiceQuery query, IList<CharWordShowType> showTypes, bool overlapFlag, float crossfade = 0.1f, float delay = 0f)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0003B658 File Offset: 0x00039858
		[Token(Token = "0x6009879")]
		[Address(RVA = "0x3132F10", Offset = "0x3131B10", VA = "0x183132F10")]
		public VoiceManager.PlayResult PlayRandomVoiceWithVoiceLangType(VoiceQuery query, CharWordShowType showType, bool overlapFlag, float crossfade = 0.1f, float delay = 0f)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0003B670 File Offset: 0x00039870
		[Token(Token = "0x600987A")]
		[Address(RVA = "0x31342A0", Offset = "0x3132EA0", VA = "0x1831342A0")]
		public VoiceManager.PlayResult PlayVoice(ICharWordData charwordData, bool overlapFlag, float crossfade = 0.1f, float delay = 0f, bool enableLipSync = true)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0003B688 File Offset: 0x00039888
		[Token(Token = "0x600987B")]
		[Address(RVA = "0x31340A0", Offset = "0x3132CA0", VA = "0x1831340A0")]
		public VoiceManager.PlayResult PlayVoiceWithVoiceLangType(ICharWordData charWordData, VoiceLangType langType, bool overlapFlag, float crossFade = 0.1f, float delay = 0f, bool enableLipSync = true)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0003B6A0 File Offset: 0x000398A0
		[Token(Token = "0x600987C")]
		[Address(RVA = "0x3134920", Offset = "0x3133520", VA = "0x183134920")]
		private VoiceManager.PlayResult _PlayVoiceImpl(ICharWordData charWordData, VoiceLangType voiceLangType, string voicePath, float crossFade, float delay, bool enableLipSync)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987D")]
		[Address(RVA = "0x3134780", Offset = "0x3133380", VA = "0x183134780")]
		public void StopVoice(float duration = 0.3f)
		{
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987E")]
		[Address(RVA = "0x3134490", Offset = "0x3133090", VA = "0x183134490")]
		public void PreloadAssets(VoiceQuery query, IList<CharWordShowType> showType)
		{
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987F")]
		[Address(RVA = "0x3134820", Offset = "0x3133420", VA = "0x183134820")]
		public void UnloadPreloadedAssets()
		{
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x0003B6B8 File Offset: 0x000398B8
		[Token(Token = "0x6009880")]
		[Address(RVA = "0x31326F0", Offset = "0x31312F0", VA = "0x1831326F0")]
		public bool CheckVoiceAvailable(string path)
		{
			return default(bool);
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x0003B6D0 File Offset: 0x000398D0
		[Token(Token = "0x6009881")]
		[Address(RVA = "0x31324C0", Offset = "0x31310C0", VA = "0x1831324C0")]
		public bool CheckVoiceAvailable(VoiceQuery query, CharWordShowType showType)
		{
			return default(bool);
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009882")]
		[Address(RVA = "0x3134890", Offset = "0x3133490", VA = "0x183134890")]
		private void _ClearCache(bool isInit)
		{
		}

		// Token: 0x04008E58 RID: 36440
		[Token(Token = "0x4008E58")]
		private const string AUDIO_CHANNEL_VOICE = "voice";

		// Token: 0x04008E59 RID: 36441
		[Token(Token = "0x4008E59")]
		private const float CROSSFADE_DURATION = 0.1f;

		// Token: 0x04008E5A RID: 36442
		[Token(Token = "0x4008E5A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, bool> m_avaliableDict;

		// Token: 0x04008E5B RID: 36443
		[Token(Token = "0x4008E5B")]
		[FieldOffset(Offset = "0x18")]
		private List<CharWordData> m_randomBuffer;

		// Token: 0x04008E5C RID: 36444
		[Token(Token = "0x4008E5C")]
		[FieldOffset(Offset = "0x20")]
		private List<CharWordData> m_filterBuffer;

		// Token: 0x04008E5D RID: 36445
		[Token(Token = "0x4008E5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008E5E RID: 36446
		[Token(Token = "0x4008E5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResourceListUpdate;

		// Token: 0x04008E5F RID: 36447
		[Token(Token = "0x4008E5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x04008E60 RID: 36448
		[Token(Token = "0x4008E60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentTimePercent;

		// Token: 0x04008E61 RID: 36449
		[Token(Token = "0x4008E61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPlayingStatus;

		// Token: 0x04008E62 RID: 36450
		[Token(Token = "0x4008E62")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayRandomLoadingVoice;

		// Token: 0x04008E63 RID: 36451
		[Token(Token = "0x4008E63")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayRandomVoice;

		// Token: 0x04008E64 RID: 36452
		[Token(Token = "0x4008E64")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_PlayRandomVoice;

		// Token: 0x04008E65 RID: 36453
		[Token(Token = "0x4008E65")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix2_PlayRandomVoice;

		// Token: 0x04008E66 RID: 36454
		[Token(Token = "0x4008E66")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PlayRandomVoiceWithVoiceLangType;

		// Token: 0x04008E67 RID: 36455
		[Token(Token = "0x4008E67")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayVoice;

		// Token: 0x04008E68 RID: 36456
		[Token(Token = "0x4008E68")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PlayVoiceWithVoiceLangType;

		// Token: 0x04008E69 RID: 36457
		[Token(Token = "0x4008E69")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayVoiceImpl;

		// Token: 0x04008E6A RID: 36458
		[Token(Token = "0x4008E6A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_StopVoice;

		// Token: 0x04008E6B RID: 36459
		[Token(Token = "0x4008E6B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PreloadAssets;

		// Token: 0x04008E6C RID: 36460
		[Token(Token = "0x4008E6C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UnloadPreloadedAssets;

		// Token: 0x04008E6D RID: 36461
		[Token(Token = "0x4008E6D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckVoiceAvailable;

		// Token: 0x04008E6E RID: 36462
		[Token(Token = "0x4008E6E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_CheckVoiceAvailable;

		// Token: 0x04008E6F RID: 36463
		[Token(Token = "0x4008E6F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearCache;

		// Token: 0x02001792 RID: 6034
		[Token(Token = "0x2001792")]
		public struct PlayResult
		{
			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x06009883 RID: 39043 RVA: 0x0003B6E8 File Offset: 0x000398E8
			[Token(Token = "0x17001059")]
			public bool isSucceed
			{
				[Token(Token = "0x6009883")]
				[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x06009884 RID: 39044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700105A")]
			public string charIdOrNull
			{
				[Token(Token = "0x6009884")]
				[Address(RVA = "0x3147C90", Offset = "0x3146890", VA = "0x183147C90")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009885 RID: 39045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009885")]
			[Address(RVA = "0x3147C50", Offset = "0x3146850", VA = "0x183147C50")]
			public PlayResult(ICharWordData data, AudioChannel channel)
			{
			}

			// Token: 0x04008E70 RID: 36464
			[Token(Token = "0x4008E70")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VoiceManager.PlayResult NULL;

			// Token: 0x04008E71 RID: 36465
			[Token(Token = "0x4008E71")]
			[FieldOffset(Offset = "0x0")]
			public ICharWordData data;

			// Token: 0x04008E72 RID: 36466
			[Token(Token = "0x4008E72")]
			[FieldOffset(Offset = "0x8")]
			public float length;
		}

		// Token: 0x02001793 RID: 6035
		[Token(Token = "0x2001793")]
		public struct PlayingStatus
		{
			// Token: 0x06009887 RID: 39047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009887")]
			[Address(RVA = "0x3147CE0", Offset = "0x31468E0", VA = "0x183147CE0")]
			public string GetWordKey()
			{
				return null;
			}

			// Token: 0x04008E73 RID: 36467
			[Token(Token = "0x4008E73")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VoiceManager.PlayingStatus EMPTY;

			// Token: 0x04008E74 RID: 36468
			[Token(Token = "0x4008E74")]
			[FieldOffset(Offset = "0x0")]
			public bool isPlaying;

			// Token: 0x04008E75 RID: 36469
			[Token(Token = "0x4008E75")]
			[FieldOffset(Offset = "0x4")]
			public float timePercent;

			// Token: 0x04008E76 RID: 36470
			[Token(Token = "0x4008E76")]
			[FieldOffset(Offset = "0x8")]
			public VoiceLangType voiceLangType;

			// Token: 0x04008E77 RID: 36471
			[Token(Token = "0x4008E77")]
			[FieldOffset(Offset = "0x10")]
			public ICharWordData wordData;
		}
	}
}
