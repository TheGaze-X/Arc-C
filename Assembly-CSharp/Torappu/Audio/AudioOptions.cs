using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FAA RID: 8106
	[Token(Token = "0x2001FAA")]
	[CreateAssetMenu(menuName = "Torappu/Options/AudioOptions")]
	public class AudioOptions : SingletonScriptableObject<AudioOptions>, IHotfixable
	{
		// Token: 0x1400006A RID: 106
		// (add) Token: 0x0600C94E RID: 51534 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600C94F RID: 51535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006A")]
		public event Action onOptionsChanged
		{
			[Token(Token = "0x600C94E")]
			[Address(RVA = "0x34A1060", Offset = "0x349FC60", VA = "0x1834A1060")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600C94F")]
			[Address(RVA = "0x34A1720", Offset = "0x34A0320", VA = "0x1834A1720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600C950 RID: 51536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017D8")]
		protected AudioMixerHolder activeMixerHolder
		{
			[Token(Token = "0x600C950")]
			[Address(RVA = "0x34A1140", Offset = "0x349FD40", VA = "0x1834A1140")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x0600C951 RID: 51537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017D9")]
		public AudioMixer mainMixer
		{
			[Token(Token = "0x600C951")]
			[Address(RVA = "0x34A1460", Offset = "0x34A0060", VA = "0x1834A1460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x0600C952 RID: 51538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DA")]
		public AudioMixerGroup musicGroup
		{
			[Token(Token = "0x600C952")]
			[Address(RVA = "0x34A1510", Offset = "0x34A0110", VA = "0x1834A1510")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x0600C953 RID: 51539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DB")]
		public AudioMixerGroup voiceGroup
		{
			[Token(Token = "0x600C953")]
			[Address(RVA = "0x34A1670", Offset = "0x34A0270", VA = "0x1834A1670")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x0600C954 RID: 51540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DC")]
		public AudioMixerGroup fxGroup
		{
			[Token(Token = "0x600C954")]
			[Address(RVA = "0x34A1250", Offset = "0x349FE50", VA = "0x1834A1250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600C955 RID: 51541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DD")]
		public AudioMixerGroup uiFxGroup
		{
			[Token(Token = "0x600C955")]
			[Address(RVA = "0x34A15C0", Offset = "0x34A01C0", VA = "0x1834A15C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DE")]
		public AudioMixerGroup importantUIFxGroup
		{
			[Token(Token = "0x600C956")]
			[Address(RVA = "0x34A13B0", Offset = "0x349FFB0", VA = "0x1834A13B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600C957 RID: 51543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DF")]
		public AudioMixerGroup battleFxGroup
		{
			[Token(Token = "0x600C957")]
			[Address(RVA = "0x34A11A0", Offset = "0x349FDA0", VA = "0x1834A11A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600C958 RID: 51544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017E0")]
		public AudioMixerGroup importantBattleFxGroup
		{
			[Token(Token = "0x600C958")]
			[Address(RVA = "0x34A1300", Offset = "0x349FF00", VA = "0x1834A1300")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C959")]
		[Address(RVA = "0x34A0E30", Offset = "0x349FA30", VA = "0x1834A0E30")]
		public AudioMixerGroup SelectMixerGroup(MixerDesc.Category category, bool important)
		{
			return null;
		}

		// Token: 0x0600C95A RID: 51546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C95A")]
		[Address(RVA = "0x34A0FF0", Offset = "0x349FBF0", VA = "0x1834A0FF0")]
		public AudioOptions()
		{
		}

		// Token: 0x0400D017 RID: 53271
		[Token(Token = "0x400D017")]
		private const string CONFIG_RES_PATH = "Audio/Sound_Beta_2/[X]Configs/main_mixer_holder";

		// Token: 0x0400D018 RID: 53272
		[Token(Token = "0x400D018")]
		[FieldOffset(Offset = "0x18")]
		public string[] musicVolumeParams;

		// Token: 0x0400D019 RID: 53273
		[Token(Token = "0x400D019")]
		[FieldOffset(Offset = "0x20")]
		public string[] voiceVolumeParams;

		// Token: 0x0400D01A RID: 53274
		[Token(Token = "0x400D01A")]
		[FieldOffset(Offset = "0x28")]
		public string[] fxVolumeParams;

		// Token: 0x0400D01B RID: 53275
		[Token(Token = "0x400D01B")]
		[FieldOffset(Offset = "0x30")]
		public int channelPreloadSize;

		// Token: 0x0400D01C RID: 53276
		[Token(Token = "0x400D01C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ReadOnly]
		[Tooltip("Used as the default mixer if main_mixer not loaded from dyn assets")]
		private AudioMixerHolder _staticLinkHolder;

		// Token: 0x0400D01E RID: 53278
		[Token(Token = "0x400D01E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onOptionsChanged;

		// Token: 0x0400D01F RID: 53279
		[Token(Token = "0x400D01F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onOptionsChanged;

		// Token: 0x0400D020 RID: 53280
		[Token(Token = "0x400D020")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activeMixerHolder;

		// Token: 0x0400D021 RID: 53281
		[Token(Token = "0x400D021")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mainMixer;

		// Token: 0x0400D022 RID: 53282
		[Token(Token = "0x400D022")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_musicGroup;

		// Token: 0x0400D023 RID: 53283
		[Token(Token = "0x400D023")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_voiceGroup;

		// Token: 0x0400D024 RID: 53284
		[Token(Token = "0x400D024")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_fxGroup;

		// Token: 0x0400D025 RID: 53285
		[Token(Token = "0x400D025")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_uiFxGroup;

		// Token: 0x0400D026 RID: 53286
		[Token(Token = "0x400D026")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_importantUIFxGroup;

		// Token: 0x0400D027 RID: 53287
		[Token(Token = "0x400D027")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_battleFxGroup;

		// Token: 0x0400D028 RID: 53288
		[Token(Token = "0x400D028")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_importantBattleFxGroup;

		// Token: 0x0400D029 RID: 53289
		[Token(Token = "0x400D029")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SelectMixerGroup;

		// Token: 0x0400D02A RID: 53290
		[Token(Token = "0x400D02A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
