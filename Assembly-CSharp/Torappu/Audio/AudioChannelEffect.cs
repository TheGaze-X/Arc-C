using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EaseFunctions;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001F9E RID: 8094
	[Token(Token = "0x2001F9E")]
	public class AudioChannelEffect : IHotfixable
	{
		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x0600C91A RID: 51482 RVA: 0x000490E0 File Offset: 0x000472E0
		[Token(Token = "0x170017D4")]
		public bool isWholeChannels
		{
			[Token(Token = "0x600C91A")]
			[Address(RVA = "0x3496950", Offset = "0x3495550", VA = "0x183496950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C91B RID: 51483 RVA: 0x000490F8 File Offset: 0x000472F8
		[Token(Token = "0x600C91B")]
		[Address(RVA = "0x34965D0", Offset = "0x34951D0", VA = "0x1834965D0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600C91C RID: 51484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C91C")]
		[Address(RVA = "0x3496730", Offset = "0x3495330", VA = "0x183496730")]
		public void SetEffectInputParam(AudioChannelEffect.EffectInputParam effectInputParam)
		{
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C91D")]
		[Address(RVA = "0x34966B0", Offset = "0x34952B0", VA = "0x1834966B0")]
		public void ReverseEffectWithTargetProperty(AudioChannelEffectProperty effectProperty)
		{
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C91E")]
		[Address(RVA = "0x3496640", Offset = "0x3495240", VA = "0x183496640")]
		public void ReverseAllPropertyEffect()
		{
		}

		// Token: 0x0600C91F RID: 51487 RVA: 0x00049110 File Offset: 0x00047310
		[Token(Token = "0x600C91F")]
		[Address(RVA = "0x34964C0", Offset = "0x34950C0", VA = "0x1834964C0")]
		public AudioChannelEffect.AudioEffectBaseValueParam GetEffectValueParam(string channelName, AudioChannelEffectProperty effectProperty)
		{
			return default(AudioChannelEffect.AudioEffectBaseValueParam);
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C920")]
		[Address(RVA = "0x34968F0", Offset = "0x34954F0", VA = "0x1834968F0")]
		public AudioChannelEffect()
		{
		}

		// Token: 0x0400CFBA RID: 53178
		[Token(Token = "0x400CFBA")]
		[FieldOffset(Offset = "0x10")]
		private int m_sequenceNum;

		// Token: 0x0400CFBB RID: 53179
		[Token(Token = "0x400CFBB")]
		[FieldOffset(Offset = "0x18")]
		private AudioChannelEffect.ParamDict m_paramDict;

		// Token: 0x0400CFBC RID: 53180
		[Token(Token = "0x400CFBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isWholeChannels;

		// Token: 0x0400CFBD RID: 53181
		[Token(Token = "0x400CFBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0400CFBE RID: 53182
		[Token(Token = "0x400CFBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEffectInputParam;

		// Token: 0x0400CFBF RID: 53183
		[Token(Token = "0x400CFBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReverseEffectWithTargetProperty;

		// Token: 0x0400CFC0 RID: 53184
		[Token(Token = "0x400CFC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReverseAllPropertyEffect;

		// Token: 0x0400CFC1 RID: 53185
		[Token(Token = "0x400CFC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEffectValueParam;

		// Token: 0x0400CFC2 RID: 53186
		[Token(Token = "0x400CFC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F9F RID: 8095
		[Token(Token = "0x2001F9F")]
		public struct AudioEffectBaseValueParam : IHotfixable
		{
			// Token: 0x170017D5 RID: 6101
			// (get) Token: 0x0600C921 RID: 51489 RVA: 0x00049128 File Offset: 0x00047328
			// (set) Token: 0x0600C922 RID: 51490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170017D5")]
			public bool isEmpty
			{
				[Token(Token = "0x600C921")]
				[Address(RVA = "0x349F690", Offset = "0x349E290", VA = "0x18349F690")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x600C922")]
				[Address(RVA = "0x349F720", Offset = "0x349E320", VA = "0x18349F720")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600C923 RID: 51491 RVA: 0x00049140 File Offset: 0x00047340
			[Token(Token = "0x600C923")]
			[Address(RVA = "0x349F2D0", Offset = "0x349DED0", VA = "0x18349F2D0")]
			public bool IsSameValue(AudioChannelEffect.AudioEffectBaseValueParam param)
			{
				return default(bool);
			}

			// Token: 0x0600C924 RID: 51492 RVA: 0x00049158 File Offset: 0x00047358
			[Token(Token = "0x600C924")]
			[Address(RVA = "0x349F1B0", Offset = "0x349DDB0", VA = "0x18349F1B0")]
			public AudioChannelEffect.AudioEffectBaseValueParam GeneReverseBaseValueParam()
			{
				return default(AudioChannelEffect.AudioEffectBaseValueParam);
			}

			// Token: 0x0400CFC3 RID: 53187
			[Token(Token = "0x400CFC3")]
			[FieldOffset(Offset = "0x0")]
			public static AudioChannelEffect.AudioEffectBaseValueParam EMPTY;

			// Token: 0x0400CFC4 RID: 53188
			[Token(Token = "0x400CFC4")]
			[FieldOffset(Offset = "0x28")]
			public static AudioChannelEffect.AudioEffectBaseValueParam LINEAR_PARAM;

			// Token: 0x0400CFC5 RID: 53189
			[Token(Token = "0x400CFC5")]
			[FieldOffset(Offset = "0x0")]
			public float defaultValue;

			// Token: 0x0400CFC6 RID: 53190
			[Token(Token = "0x400CFC6")]
			[FieldOffset(Offset = "0x4")]
			public float targetValue;

			// Token: 0x0400CFC7 RID: 53191
			[Token(Token = "0x400CFC7")]
			[FieldOffset(Offset = "0x8")]
			public float duration;

			// Token: 0x0400CFC8 RID: 53192
			[Token(Token = "0x400CFC8")]
			[FieldOffset(Offset = "0xC")]
			public float delay;

			// Token: 0x0400CFC9 RID: 53193
			[Token(Token = "0x400CFC9")]
			[FieldOffset(Offset = "0x10")]
			public Interpolator.EaseType easeType;

			// Token: 0x0400CFCA RID: 53194
			[Token(Token = "0x400CFCA")]
			[FieldOffset(Offset = "0x14")]
			public float reverseDuration;

			// Token: 0x0400CFCB RID: 53195
			[Token(Token = "0x400CFCB")]
			[FieldOffset(Offset = "0x18")]
			public Interpolator.EaseType reverseEaseType;

			// Token: 0x0400CFCC RID: 53196
			[Token(Token = "0x400CFCC")]
			[FieldOffset(Offset = "0x1C")]
			public bool removeWhenFinish;

			// Token: 0x0400CFCD RID: 53197
			[Token(Token = "0x400CFCD")]
			[FieldOffset(Offset = "0x20")]
			public int sequenceNum;

			// Token: 0x0400CFCF RID: 53199
			[Token(Token = "0x400CFCF")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0400CFD0 RID: 53200
			[Token(Token = "0x400CFD0")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_isEmpty;

			// Token: 0x0400CFD1 RID: 53201
			[Token(Token = "0x400CFD1")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_IsSameValue;

			// Token: 0x0400CFD2 RID: 53202
			[Token(Token = "0x400CFD2")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_GeneReverseBaseValueParam;
		}

		// Token: 0x02001FA0 RID: 8096
		[Token(Token = "0x2001FA0")]
		public struct EffectInputParam : IHotfixable
		{
			// Token: 0x0600C926 RID: 51494 RVA: 0x00049170 File Offset: 0x00047370
			[Token(Token = "0x600C926")]
			[Address(RVA = "0x34A81D0", Offset = "0x34A6DD0", VA = "0x1834A81D0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0400CFD3 RID: 53203
			[Token(Token = "0x400CFD3")]
			[FieldOffset(Offset = "0x0")]
			public static AudioChannelEffect.EffectInputParam EMPTY;

			// Token: 0x0400CFD4 RID: 53204
			[Token(Token = "0x400CFD4")]
			[FieldOffset(Offset = "0x0")]
			public AudioChannelEffect.AudioEffectBaseValueParam effectParam;

			// Token: 0x0400CFD5 RID: 53205
			[Token(Token = "0x400CFD5")]
			[FieldOffset(Offset = "0x28")]
			public AudioChannelEffectProperty effectProperty;

			// Token: 0x0400CFD6 RID: 53206
			[Token(Token = "0x400CFD6")]
			[FieldOffset(Offset = "0x2C")]
			public bool isWholeChannels;

			// Token: 0x0400CFD7 RID: 53207
			[Token(Token = "0x400CFD7")]
			[FieldOffset(Offset = "0x30")]
			public List<string> channels;

			// Token: 0x0400CFD8 RID: 53208
			[Token(Token = "0x400CFD8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}

		// Token: 0x02001FA1 RID: 8097
		[Token(Token = "0x2001FA1")]
		private class EffectChannelRelatedParam : IHotfixable
		{
			// Token: 0x0600C928 RID: 51496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C928")]
			[Address(RVA = "0x34A7FE0", Offset = "0x34A6BE0", VA = "0x1834A7FE0")]
			public void SetEffectInputParam(AudioChannelEffect.AudioEffectBaseValueParam newEffectBaseParam, AudioChannelEffectProperty property)
			{
			}

			// Token: 0x0600C929 RID: 51497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C929")]
			[Address(RVA = "0x34A7E00", Offset = "0x34A6A00", VA = "0x1834A7E00")]
			public void ReverseEffectWithTargetProperty(AudioChannelEffectProperty effectProperty, int sequenceNum)
			{
			}

			// Token: 0x0600C92A RID: 51498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C92A")]
			[Address(RVA = "0x34A79B0", Offset = "0x34A65B0", VA = "0x1834A79B0")]
			public void ReverseAllPropertyEffect(int sequenceNum)
			{
			}

			// Token: 0x0600C92B RID: 51499 RVA: 0x00049188 File Offset: 0x00047388
			[Token(Token = "0x600C92B")]
			[Address(RVA = "0x34A7860", Offset = "0x34A6460", VA = "0x1834A7860")]
			public AudioChannelEffect.AudioEffectBaseValueParam GetEffectValueParam(AudioChannelEffectProperty effectProperty)
			{
				return default(AudioChannelEffect.AudioEffectBaseValueParam);
			}

			// Token: 0x0600C92C RID: 51500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C92C")]
			[Address(RVA = "0x34A8170", Offset = "0x34A6D70", VA = "0x1834A8170")]
			public EffectChannelRelatedParam()
			{
			}

			// Token: 0x0400CFD9 RID: 53209
			[Token(Token = "0x400CFD9")]
			[FieldOffset(Offset = "0x10")]
			public EnumIntStructDictionary<AudioChannelEffectProperty, AudioChannelEffect.AudioEffectBaseValueParam> propertyParamMap;

			// Token: 0x0400CFDA RID: 53210
			[Token(Token = "0x400CFDA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetEffectInputParam;

			// Token: 0x0400CFDB RID: 53211
			[Token(Token = "0x400CFDB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ReverseEffectWithTargetProperty;

			// Token: 0x0400CFDC RID: 53212
			[Token(Token = "0x400CFDC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ReverseAllPropertyEffect;

			// Token: 0x0400CFDD RID: 53213
			[Token(Token = "0x400CFDD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetEffectValueParam;

			// Token: 0x0400CFDE RID: 53214
			[Token(Token = "0x400CFDE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001FA2 RID: 8098
		[Token(Token = "0x2001FA2")]
		private class ParamDict : IHotfixable
		{
			// Token: 0x0600C92D RID: 51501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C92D")]
			[Address(RVA = "0x34B06B0", Offset = "0x34AF2B0", VA = "0x1834B06B0")]
			public ParamDict(AudioChannelEffect closure)
			{
			}

			// Token: 0x0600C92E RID: 51502 RVA: 0x000491A0 File Offset: 0x000473A0
			[Token(Token = "0x600C92E")]
			[Address(RVA = "0x34AFE00", Offset = "0x34AEA00", VA = "0x1834AFE00")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x170017D6 RID: 6102
			// (get) Token: 0x0600C92F RID: 51503 RVA: 0x000491B8 File Offset: 0x000473B8
			[Token(Token = "0x170017D6")]
			public bool isWholeChannels
			{
				[Token(Token = "0x600C92F")]
				[Address(RVA = "0x34B0780", Offset = "0x34AF380", VA = "0x1834B0780")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600C930 RID: 51504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C930")]
			[Address(RVA = "0x34B0280", Offset = "0x34AEE80", VA = "0x1834B0280")]
			public void SetEffectInputParam(AudioChannelEffect.EffectInputParam effectInputParam)
			{
			}

			// Token: 0x0600C931 RID: 51505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C931")]
			[Address(RVA = "0x34B0080", Offset = "0x34AEC80", VA = "0x1834B0080")]
			public void ReverseEffectWithTargetProperty(AudioChannelEffectProperty effectProperty)
			{
			}

			// Token: 0x0600C932 RID: 51506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C932")]
			[Address(RVA = "0x34AFE80", Offset = "0x34AEA80", VA = "0x1834AFE80")]
			public void ReverseAllPropertyEffect()
			{
			}

			// Token: 0x0600C933 RID: 51507 RVA: 0x000491D0 File Offset: 0x000473D0
			[Token(Token = "0x600C933")]
			[Address(RVA = "0x34AFC70", Offset = "0x34AE870", VA = "0x1834AFC70")]
			public AudioChannelEffect.AudioEffectBaseValueParam GetEffectValueParam(string channelName, AudioChannelEffectProperty effectProperty)
			{
				return default(AudioChannelEffect.AudioEffectBaseValueParam);
			}

			// Token: 0x0400CFDF RID: 53215
			[Token(Token = "0x400CFDF")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, AudioChannelEffect.EffectChannelRelatedParam> m_effectChannelParamDict;

			// Token: 0x0400CFE0 RID: 53216
			[Token(Token = "0x400CFE0")]
			[FieldOffset(Offset = "0x18")]
			private AudioChannelEffect.EffectChannelRelatedParam m_wholeChannelParam;

			// Token: 0x0400CFE1 RID: 53217
			[Token(Token = "0x400CFE1")]
			[FieldOffset(Offset = "0x20")]
			private AudioChannelEffect m_closure;

			// Token: 0x0400CFE2 RID: 53218
			[Token(Token = "0x400CFE2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CFE3 RID: 53219
			[Token(Token = "0x400CFE3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x0400CFE4 RID: 53220
			[Token(Token = "0x400CFE4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isWholeChannels;

			// Token: 0x0400CFE5 RID: 53221
			[Token(Token = "0x400CFE5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetEffectInputParam;

			// Token: 0x0400CFE6 RID: 53222
			[Token(Token = "0x400CFE6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ReverseEffectWithTargetProperty;

			// Token: 0x0400CFE7 RID: 53223
			[Token(Token = "0x400CFE7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ReverseAllPropertyEffect;

			// Token: 0x0400CFE8 RID: 53224
			[Token(Token = "0x400CFE8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetEffectValueParam;
		}
	}
}
