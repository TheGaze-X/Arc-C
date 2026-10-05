using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Audio.Engine;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FBC RID: 8124
	[Token(Token = "0x2001FBC")]
	[Serializable]
	public class SoundFXBank : Bank
	{
		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x000493E0 File Offset: 0x000475E0
		// (set) Token: 0x0600C9CC RID: 51660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017E6")]
		public MixerDesc mixerDesc
		{
			[Token(Token = "0x600C9CB")]
			[Address(RVA = "0x34B2B80", Offset = "0x34B1780", VA = "0x1834B2B80")]
			[CompilerGenerated]
			get
			{
				return default(MixerDesc);
			}
			[Token(Token = "0x600C9CC")]
			[Address(RVA = "0x34B2C00", Offset = "0x34B1800", VA = "0x1834B2C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9CD")]
		[Address(RVA = "0x34B22A0", Offset = "0x34B0EA0", VA = "0x1834B22A0", Slot = "4")]
		public override AudioAtom Play(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9CE")]
		[Address(RVA = "0x34B2770", Offset = "0x34B1370", VA = "0x1834B2770", Slot = "5")]
		public override void Preload(string persistTag)
		{
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9CF")]
		[Address(RVA = "0x34B1E90", Offset = "0x34B0A90", VA = "0x1834B1E90", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x000493F8 File Offset: 0x000475F8
		[Token(Token = "0x600C9D0")]
		[Address(RVA = "0x34B2160", Offset = "0x34B0D60", VA = "0x1834B2160")]
		public static MixerDesc ParseMixer(string bankName, string customMixerGroup)
		{
			return default(MixerDesc);
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9D1")]
		[Address(RVA = "0x34B2920", Offset = "0x34B1520", VA = "0x1834B2920")]
		private SoundFXBank.SoundFX _GenerateWeightedRandomSound()
		{
			return null;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9D2")]
		[Address(RVA = "0x34B2AE0", Offset = "0x34B16E0", VA = "0x1834B2AE0")]
		public SoundFXBank()
		{
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9D3")]
		[Address(RVA = "0x34A5FE0", Offset = "0x34A4BE0", VA = "0x1834A5FE0")]
		private void <>xLuaBaseProxy_Preload(string P0)
		{
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9D4")]
		[Address(RVA = "0x34A6890", Offset = "0x34A5490", VA = "0x1834A6890")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0400D234 RID: 53812
		[Token(Token = "0x400D234")]
		[FieldOffset(Offset = "0x30")]
		private float m_totalWeight;

		// Token: 0x0400D236 RID: 53814
		[Token(Token = "0x400D236")]
		[FieldOffset(Offset = "0x50")]
		public SoundFXBank.SoundFX[] sounds;

		// Token: 0x0400D237 RID: 53815
		[Token(Token = "0x400D237")]
		[FieldOffset(Offset = "0x58")]
		public int maxSoundAllowed;

		// Token: 0x0400D238 RID: 53816
		[Token(Token = "0x400D238")]
		[FieldOffset(Offset = "0x5C")]
		public bool popOldest;

		// Token: 0x0400D239 RID: 53817
		[Token(Token = "0x400D239")]
		[FieldOffset(Offset = "0x60")]
		public string customMixerGroup;

		// Token: 0x0400D23A RID: 53818
		[Token(Token = "0x400D23A")]
		[FieldOffset(Offset = "0x68")]
		public bool loop;

		// Token: 0x0400D23B RID: 53819
		[Token(Token = "0x400D23B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mixerDesc;

		// Token: 0x0400D23C RID: 53820
		[Token(Token = "0x400D23C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mixerDesc;

		// Token: 0x0400D23D RID: 53821
		[Token(Token = "0x400D23D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400D23E RID: 53822
		[Token(Token = "0x400D23E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Preload;

		// Token: 0x0400D23F RID: 53823
		[Token(Token = "0x400D23F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D240 RID: 53824
		[Token(Token = "0x400D240")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ParseMixer;

		// Token: 0x0400D241 RID: 53825
		[Token(Token = "0x400D241")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateWeightedRandomSound;

		// Token: 0x0400D242 RID: 53826
		[Token(Token = "0x400D242")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001FBD RID: 8125
		[Token(Token = "0x2001FBD")]
		[Serializable]
		public class SoundFX : ISoundInfo, IAudioInfo
		{
			// Token: 0x170017E7 RID: 6119
			// (get) Token: 0x0600C9D5 RID: 51669 RVA: 0x00049410 File Offset: 0x00047610
			[Token(Token = "0x170017E7")]
			public float randomVolume
			{
				[Token(Token = "0x600C9D5")]
				[Address(RVA = "0x34B3910", Offset = "0x34B2510", VA = "0x1834B3910")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170017E8 RID: 6120
			// (get) Token: 0x0600C9D6 RID: 51670 RVA: 0x00049428 File Offset: 0x00047628
			[Token(Token = "0x170017E8")]
			public float randomPitch
			{
				[Token(Token = "0x600C9D6")]
				[Address(RVA = "0x34B38F0", Offset = "0x34B24F0", VA = "0x1834B38F0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600C9D7 RID: 51671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C9D7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			public string GetAsset()
			{
				return null;
			}

			// Token: 0x0600C9D8 RID: 51672 RVA: 0x00049440 File Offset: 0x00047640
			[Token(Token = "0x600C9D8")]
			[Address(RVA = "0x34B3070", Offset = "0x34B1C70", VA = "0x1834B3070", Slot = "5")]
			public MixerDesc GetMixer()
			{
				return default(MixerDesc);
			}

			// Token: 0x0600C9D9 RID: 51673 RVA: 0x00049458 File Offset: 0x00047658
			[Token(Token = "0x600C9D9")]
			[Address(RVA = "0x34B31F0", Offset = "0x34B1DF0", VA = "0x1834B31F0", Slot = "6")]
			public bool Loop()
			{
				return default(bool);
			}

			// Token: 0x0600C9DA RID: 51674 RVA: 0x00049470 File Offset: 0x00047670
			[Token(Token = "0x600C9DA")]
			[Address(RVA = "0x34B34E0", Offset = "0x34B20E0", VA = "0x1834B34E0", Slot = "7")]
			public float SpatialBlend()
			{
				return 0f;
			}

			// Token: 0x0600C9DB RID: 51675 RVA: 0x00049488 File Offset: 0x00047688
			[Token(Token = "0x600C9DB")]
			[Address(RVA = "0x34B3170", Offset = "0x34B1D70", VA = "0x1834B3170", Slot = "8")]
			public bool IsSameAudio(IAudioInfo other)
			{
				return default(bool);
			}

			// Token: 0x0600C9DC RID: 51676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C9DC")]
			[Address(RVA = "0x34B3200", Offset = "0x34B1E00", VA = "0x1834B3200")]
			public AudioChannel Play(SoundFXBank bank, Vector3 position)
			{
				return null;
			}

			// Token: 0x0600C9DD RID: 51677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C9DD")]
			[Address(RVA = "0x34B3410", Offset = "0x34B2010", VA = "0x1834B3410")]
			public void Preload(SoundFXBank bank, string persistTag)
			{
			}

			// Token: 0x0600C9DE RID: 51678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C9DE")]
			[Address(RVA = "0x34B3500", Offset = "0x34B2100", VA = "0x1834B3500")]
			private void _SetAudioChannel(AudioChannel audioChannel, Vector3 position)
			{
			}

			// Token: 0x0600C9DF RID: 51679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C9DF")]
			[Address(RVA = "0x34B38C0", Offset = "0x34B24C0", VA = "0x1834B38C0")]
			public SoundFX()
			{
			}

			// Token: 0x0400D243 RID: 53827
			[Token(Token = "0x400D243")]
			[FieldOffset(Offset = "0x10")]
			private SoundFXBank m_runtimeBank;

			// Token: 0x0400D244 RID: 53828
			[Token(Token = "0x400D244")]
			[FieldOffset(Offset = "0x18")]
			public string asset;

			// Token: 0x0400D245 RID: 53829
			[Token(Token = "0x400D245")]
			[FieldOffset(Offset = "0x20")]
			public float weight;

			// Token: 0x0400D246 RID: 53830
			[Token(Token = "0x400D246")]
			[FieldOffset(Offset = "0x24")]
			public bool important;

			// Token: 0x0400D247 RID: 53831
			[Token(Token = "0x400D247")]
			[FieldOffset(Offset = "0x25")]
			public bool is2D;

			// Token: 0x0400D248 RID: 53832
			[Token(Token = "0x400D248")]
			[FieldOffset(Offset = "0x28")]
			public float delay;

			// Token: 0x0400D249 RID: 53833
			[Token(Token = "0x400D249")]
			[FieldOffset(Offset = "0x2C")]
			public float minPitch;

			// Token: 0x0400D24A RID: 53834
			[Token(Token = "0x400D24A")]
			[FieldOffset(Offset = "0x30")]
			public float maxPitch;

			// Token: 0x0400D24B RID: 53835
			[Token(Token = "0x400D24B")]
			[FieldOffset(Offset = "0x34")]
			public float minVolume;

			// Token: 0x0400D24C RID: 53836
			[Token(Token = "0x400D24C")]
			[FieldOffset(Offset = "0x38")]
			public float maxVolume;

			// Token: 0x0400D24D RID: 53837
			[Token(Token = "0x400D24D")]
			[FieldOffset(Offset = "0x3C")]
			public bool ignoreTimeScale;
		}
	}
}
