using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using Torappu.CharWord;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.LipSync
{
	// Token: 0x02001468 RID: 5224
	[Token(Token = "0x2001468")]
	public class LipSyncSpineBlendAnimation : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x00036630 File Offset: 0x00034830
		// (set) Token: 0x060078D7 RID: 30935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E6F")]
		public VoiceQuery voiceQuery
		{
			[Token(Token = "0x60078D6")]
			[Address(RVA = "0x263BDF0", Offset = "0x263A9F0", VA = "0x18263BDF0")]
			get
			{
				return default(VoiceQuery);
			}
			[Token(Token = "0x60078D7")]
			[Address(RVA = "0x263BE70", Offset = "0x263AA70", VA = "0x18263BE70")]
			set
			{
			}
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00036648 File Offset: 0x00034848
		[Token(Token = "0x60078D8")]
		[Address(RVA = "0x2639860", Offset = "0x2638460", VA = "0x182639860")]
		public float GetPlayingDuration()
		{
			return 0f;
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00036660 File Offset: 0x00034860
		[Token(Token = "0x60078D9")]
		[Address(RVA = "0x26398C0", Offset = "0x26384C0", VA = "0x1826398C0")]
		public float GetPlayingTime()
		{
			return 0f;
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00036678 File Offset: 0x00034878
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0x2639710", Offset = "0x2638310", VA = "0x182639710")]
		public float GetActionDuration(int actIdx)
		{
			return 0f;
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DB")]
		[Address(RVA = "0x26394B0", Offset = "0x26380B0", VA = "0x1826394B0")]
		private void Awake()
		{
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DC")]
		[Address(RVA = "0x2639A10", Offset = "0x2638610", VA = "0x182639A10")]
		private void Update()
		{
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DD")]
		[Address(RVA = "0x2639920", Offset = "0x2638520", VA = "0x182639920")]
		public void Play(int actionIdx, bool loop)
		{
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DE")]
		[Address(RVA = "0x263B2F0", Offset = "0x2639EF0", VA = "0x18263B2F0")]
		private void _Play()
		{
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DF")]
		[Address(RVA = "0x263A370", Offset = "0x2638F70", VA = "0x18263A370")]
		private void _CheckAndPlayVoiceAnimations()
		{
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E0")]
		[Address(RVA = "0x263B9A0", Offset = "0x263A5A0", VA = "0x18263B9A0")]
		private void _UpdateVolume()
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E1")]
		[Address(RVA = "0x263BAC0", Offset = "0x263A6C0", VA = "0x18263BAC0")]
		private void _UpdateVowels()
		{
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0x263B840", Offset = "0x263A440", VA = "0x18263B840")]
		private void _UpdateMouthCloseBlending()
		{
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E3")]
		[Address(RVA = "0x263B5B0", Offset = "0x263A1B0", VA = "0x18263B5B0")]
		private void _ResetMouthAnimation()
		{
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0x263AFE0", Offset = "0x2639BE0", VA = "0x18263AFE0")]
		private void _OnSpineAnimationComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00036690 File Offset: 0x00034890
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0x263AF70", Offset = "0x2639B70", VA = "0x18263AF70")]
		private bool _IsVoiceTooLow()
		{
			return default(bool);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E6")]
		[Address(RVA = "0x263B6D0", Offset = "0x263A2D0", VA = "0x18263B6D0")]
		private void _SetMouthAnimation()
		{
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x000366A8 File Offset: 0x000348A8
		[Token(Token = "0x60078E7")]
		[Address(RVA = "0x263A4C0", Offset = "0x26390C0", VA = "0x18263A4C0")]
		private bool _CheckCharWordDataValid(ICharWordData charWordData)
		{
			return default(bool);
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E8")]
		[Address(RVA = "0x263A920", Offset = "0x2639520", VA = "0x18263A920")]
		private BakedData _GetBakedData(ICharWordData charWordData, VoiceLangType voiceLangType)
		{
			return null;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E9")]
		[Address(RVA = "0x263B0F0", Offset = "0x2639CF0", VA = "0x18263B0F0")]
		private BakedData.BakedDataJson _ParseLipSyncBakedData(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x000366C0 File Offset: 0x000348C0
		[Token(Token = "0x60078EA")]
		[Address(RVA = "0x263A720", Offset = "0x2639320", VA = "0x18263A720")]
		private static VoiceLangManager.VoicePath _GetBakedDataPath(VoiceLangType langType, string voiceAsset)
		{
			return default(VoiceLangManager.VoicePath);
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078EB")]
		[Address(RVA = "0x263A610", Offset = "0x2639210", VA = "0x18263A610")]
		private static string _GetBakedDataPathByGroupType(VoiceLangGroupType groupType, string voiceAsset)
		{
			return null;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078EC")]
		[Address(RVA = "0x263BBF0", Offset = "0x263A7F0", VA = "0x18263BBF0")]
		public LipSyncSpineBlendAnimation()
		{
		}

		// Token: 0x040076D9 RID: 30425
		[Token(Token = "0x40076D9")]
		private const int ACTION_ANIMATION_LAYER = 0;

		// Token: 0x040076DA RID: 30426
		[Token(Token = "0x40076DA")]
		private const int MOUTH_ANIMATION_LAYER = 1;

		// Token: 0x040076DB RID: 30427
		[Token(Token = "0x40076DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DynIllustSpecial _dynIllust;

		// Token: 0x040076DC RID: 30428
		[Token(Token = "0x40076DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _scaleBoneName;

		// Token: 0x040076DD RID: 30429
		[Token(Token = "0x40076DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minVolume;

		// Token: 0x040076DE RID: 30430
		[Token(Token = "0x40076DE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxVolume;

		// Token: 0x040076DF RID: 30431
		[Token(Token = "0x40076DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 0.3f)]
		private float _smoothness;

		// Token: 0x040076E0 RID: 30432
		[Token(Token = "0x40076E0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _volumeMultiplier;

		// Token: 0x040076E1 RID: 30433
		[Token(Token = "0x40076E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lowerLimitX;

		// Token: 0x040076E2 RID: 30434
		[Token(Token = "0x40076E2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _lowerLimitY;

		// Token: 0x040076E3 RID: 30435
		[Token(Token = "0x40076E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public float _higherLimitX;

		// Token: 0x040076E4 RID: 30436
		[Token(Token = "0x40076E4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float _higherLimitY;

		// Token: 0x040076E5 RID: 30437
		[Token(Token = "0x40076E5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float _maxLimitedVolume;

		// Token: 0x040076E6 RID: 30438
		[Token(Token = "0x40076E6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _defaultMixDuration;

		// Token: 0x040076E7 RID: 30439
		[Token(Token = "0x40076E7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _minDetectVolume;

		// Token: 0x040076E8 RID: 30440
		[Token(Token = "0x40076E8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _mouthAlphaThreshold;

		// Token: 0x040076E9 RID: 30441
		[Token(Token = "0x40076E9")]
		[FieldOffset(Offset = "0x58")]
		private SkeletonAnimation m_skeletonAnimation;

		// Token: 0x040076EA RID: 30442
		[Token(Token = "0x40076EA")]
		[FieldOffset(Offset = "0x60")]
		private LipSyncSpineBlendAnimation.BlendAnimationInfo m_blendAnimationInfo;

		// Token: 0x040076EB RID: 30443
		[Token(Token = "0x40076EB")]
		[FieldOffset(Offset = "0x68")]
		private string m_currMouthAnimName;

		// Token: 0x040076EC RID: 30444
		[Token(Token = "0x40076EC")]
		[FieldOffset(Offset = "0x70")]
		private TrackEntry m_trackMouth;

		// Token: 0x040076ED RID: 30445
		[Token(Token = "0x40076ED")]
		[FieldOffset(Offset = "0x78")]
		private Bone m_boneScale;

		// Token: 0x040076EE RID: 30446
		[Token(Token = "0x40076EE")]
		[FieldOffset(Offset = "0x80")]
		private LipSyncInfo m_info;

		// Token: 0x040076EF RID: 30447
		[Token(Token = "0x40076EF")]
		[FieldOffset(Offset = "0x98")]
		private float m_volume;

		// Token: 0x040076F0 RID: 30448
		[Token(Token = "0x40076F0")]
		[FieldOffset(Offset = "0x9C")]
		private float m_rawVolume;

		// Token: 0x040076F1 RID: 30449
		[Token(Token = "0x40076F1")]
		[FieldOffset(Offset = "0xA0")]
		private float m_openCloseVelocity;

		// Token: 0x040076F2 RID: 30450
		[Token(Token = "0x40076F2")]
		[FieldOffset(Offset = "0xA4")]
		private int m_currActionIdx;

		// Token: 0x040076F3 RID: 30451
		[Token(Token = "0x40076F3")]
		[FieldOffset(Offset = "0xA8")]
		private int m_currSubLipSyncIdx;

		// Token: 0x040076F4 RID: 30452
		[Token(Token = "0x40076F4")]
		[FieldOffset(Offset = "0xAC")]
		private float m_currActionDuration;

		// Token: 0x040076F5 RID: 30453
		[Token(Token = "0x40076F5")]
		[FieldOffset(Offset = "0xB0")]
		private float m_currActionTime;

		// Token: 0x040076F6 RID: 30454
		[Token(Token = "0x40076F6")]
		[FieldOffset(Offset = "0xB4")]
		private float m_totalActionTime;

		// Token: 0x040076F7 RID: 30455
		[Token(Token = "0x40076F7")]
		[FieldOffset(Offset = "0xB8")]
		private ICharWordData m_wordData;

		// Token: 0x040076F8 RID: 30456
		[Token(Token = "0x40076F8")]
		[FieldOffset(Offset = "0xC0")]
		private BakedData m_bakedData;

		// Token: 0x040076F9 RID: 30457
		[Token(Token = "0x40076F9")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<string, BakedData> m_bakedDatas;

		// Token: 0x040076FA RID: 30458
		[Token(Token = "0x40076FA")]
		[FieldOffset(Offset = "0xD0")]
		private VoiceQuery m_voiceQuery;

		// Token: 0x040076FB RID: 30459
		[Token(Token = "0x40076FB")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_loop;

		// Token: 0x040076FC RID: 30460
		[Token(Token = "0x40076FC")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_fadeToCloseMouthBegin;

		// Token: 0x040076FD RID: 30461
		[Token(Token = "0x40076FD")]
		[FieldOffset(Offset = "0xF4")]
		private float m_currFadeMouthTime;

		// Token: 0x040076FE RID: 30462
		[Token(Token = "0x40076FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_voiceQuery;

		// Token: 0x040076FF RID: 30463
		[Token(Token = "0x40076FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_voiceQuery;

		// Token: 0x04007700 RID: 30464
		[Token(Token = "0x4007700")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayingDuration;

		// Token: 0x04007701 RID: 30465
		[Token(Token = "0x4007701")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlayingTime;

		// Token: 0x04007702 RID: 30466
		[Token(Token = "0x4007702")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActionDuration;

		// Token: 0x04007703 RID: 30467
		[Token(Token = "0x4007703")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04007704 RID: 30468
		[Token(Token = "0x4007704")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04007705 RID: 30469
		[Token(Token = "0x4007705")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04007706 RID: 30470
		[Token(Token = "0x4007706")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x04007707 RID: 30471
		[Token(Token = "0x4007707")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckAndPlayVoiceAnimations;

		// Token: 0x04007708 RID: 30472
		[Token(Token = "0x4007708")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateVolume;

		// Token: 0x04007709 RID: 30473
		[Token(Token = "0x4007709")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateVowels;

		// Token: 0x0400770A RID: 30474
		[Token(Token = "0x400770A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateMouthCloseBlending;

		// Token: 0x0400770B RID: 30475
		[Token(Token = "0x400770B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetMouthAnimation;

		// Token: 0x0400770C RID: 30476
		[Token(Token = "0x400770C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSpineAnimationComplete;

		// Token: 0x0400770D RID: 30477
		[Token(Token = "0x400770D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsVoiceTooLow;

		// Token: 0x0400770E RID: 30478
		[Token(Token = "0x400770E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetMouthAnimation;

		// Token: 0x0400770F RID: 30479
		[Token(Token = "0x400770F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckCharWordDataValid;

		// Token: 0x04007710 RID: 30480
		[Token(Token = "0x4007710")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetBakedData;

		// Token: 0x04007711 RID: 30481
		[Token(Token = "0x4007711")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ParseLipSyncBakedData;

		// Token: 0x04007712 RID: 30482
		[Token(Token = "0x4007712")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetBakedDataPath;

		// Token: 0x04007713 RID: 30483
		[Token(Token = "0x4007713")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetBakedDataPathByGroupType;

		// Token: 0x04007714 RID: 30484
		[Token(Token = "0x4007714")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001469 RID: 5225
		[Token(Token = "0x2001469")]
		public class BlendAnimationInfo
		{
			// Token: 0x060078ED RID: 30957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BlendAnimationInfo()
			{
			}

			// Token: 0x04007715 RID: 30485
			[Token(Token = "0x4007715")]
			[FieldOffset(Offset = "0x10")]
			public float weight;

			// Token: 0x04007716 RID: 30486
			[Token(Token = "0x4007716")]
			[FieldOffset(Offset = "0x14")]
			public float weightVelocity;
		}
	}
}
