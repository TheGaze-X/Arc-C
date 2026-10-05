using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C02 RID: 11266
	[Token(Token = "0x2002C02")]
	public class UberEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x06013071 RID: 77937 RVA: 0x00074658 File Offset: 0x00072858
		[Token(Token = "0x170029E4")]
		private bool recalculatePlaybackSpeed
		{
			[Token(Token = "0x6013071")]
			[Address(RVA = "0xAEEA70", Offset = "0xAED670", VA = "0x180AEEA70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06013072 RID: 77938 RVA: 0x00074670 File Offset: 0x00072870
		[Token(Token = "0x170029E5")]
		protected override float playbackSpeed
		{
			[Token(Token = "0x6013072")]
			[Address(RVA = "0xAEE8F0", Offset = "0xAED4F0", VA = "0x180AEE8F0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06013073 RID: 77939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013073")]
		[Address(RVA = "0xAEE0A0", Offset = "0xAECCA0", VA = "0x180AEE0A0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013074 RID: 77940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013074")]
		[Address(RVA = "0xAEE530", Offset = "0xAED130", VA = "0x180AEE530", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013075 RID: 77941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013075")]
		[Address(RVA = "0xAEE300", Offset = "0xAECF00", VA = "0x180AEE300", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013076 RID: 77942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013076")]
		[Address(RVA = "0xAEE410", Offset = "0xAED010", VA = "0x180AEE410", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013077 RID: 77943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013077")]
		[Address(RVA = "0xAEE620", Offset = "0xAED220", VA = "0x180AEE620", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013078 RID: 77944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013078")]
		[Address(RVA = "0xAEDF90", Offset = "0xAECB90", VA = "0x180AEDF90", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013079 RID: 77945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013079")]
		protected void _GatherEffects<T>(List<string> effects, T[] options) where T : UberEffectEmitter.EffectOptions
		{
		}

		// Token: 0x0601307A RID: 77946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601307A")]
		[Address(RVA = "0xAEE780", Offset = "0xAED380", VA = "0x180AEE780")]
		public UberEffectEmitter()
		{
		}

		// Token: 0x0601307B RID: 77947 RVA: 0x00074688 File Offset: 0x00072888
		[Token(Token = "0x601307B")]
		[Address(RVA = "0xAEE770", Offset = "0xAED370", VA = "0x180AEE770")]
		private float <>xLuaBaseProxy_get_playbackSpeed()
		{
			return 0f;
		}

		// Token: 0x0601307C RID: 77948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601307C")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0601307D RID: 77949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601307D")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601307E RID: 77950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601307E")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601307F RID: 77951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601307F")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06013080 RID: 77952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013080")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040157E4 RID: 88036
		[Token(Token = "0x40157E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UberEffectEmitter.HitEffectOptions[] _hitEffects;

		// Token: 0x040157E5 RID: 88037
		[Token(Token = "0x40157E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UberEffectEmitter.CastEffectOptions[] _castEffects;

		// Token: 0x040157E6 RID: 88038
		[Token(Token = "0x40157E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UberEffectEmitter.AttachEffectOptions[] _attachEffects;

		// Token: 0x040157E7 RID: 88039
		[Token(Token = "0x40157E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UberEffectEmitter.InputTargetEffectOptions[] _inputTargetEffects;

		// Token: 0x040157E8 RID: 88040
		[Token(Token = "0x40157E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UberEffectEmitter.CastTargetEffectOptions[] _castTargetEffects;

		// Token: 0x040157E9 RID: 88041
		[Token(Token = "0x40157E9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _convertCastEndToAttachFinish;

		// Token: 0x040157EA RID: 88042
		[Token(Token = "0x40157EA")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _recalculatePlaybackSpeed;

		// Token: 0x040157EB RID: 88043
		[Token(Token = "0x40157EB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Inspect("recalculatePlaybackSpeed")]
		private float _preDelayFactor;

		// Token: 0x040157EC RID: 88044
		[Token(Token = "0x40157EC")]
		[FieldOffset(Offset = "0x50")]
		protected List<UberEffectEmitter.EffectOptions> m_allEffects;

		// Token: 0x040157ED RID: 88045
		[Token(Token = "0x40157ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_recalculatePlaybackSpeed;

		// Token: 0x040157EE RID: 88046
		[Token(Token = "0x40157EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playbackSpeed;

		// Token: 0x040157EF RID: 88047
		[Token(Token = "0x40157EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040157F0 RID: 88048
		[Token(Token = "0x40157F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040157F1 RID: 88049
		[Token(Token = "0x40157F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040157F2 RID: 88050
		[Token(Token = "0x40157F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040157F3 RID: 88051
		[Token(Token = "0x40157F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040157F4 RID: 88052
		[Token(Token = "0x40157F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040157F5 RID: 88053
		[Token(Token = "0x40157F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GatherEffects;

		// Token: 0x040157F6 RID: 88054
		[Token(Token = "0x40157F6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C03 RID: 11267
		[Token(Token = "0x2002C03")]
		[Serializable]
		public class EffectOptions
		{
			// Token: 0x170029E6 RID: 10726
			// (get) Token: 0x06013081 RID: 77953 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06013082 RID: 77954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170029E6")]
			[Inspect("isSingle")]
			public string effect
			{
				[Token(Token = "0x6013081")]
				[Address(RVA = "0xAE27C0", Offset = "0xAE13C0", VA = "0x180AE27C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6013082")]
				[Address(RVA = "0xAE28C0", Offset = "0xAE14C0", VA = "0x180AE28C0")]
				set
				{
				}
			}

			// Token: 0x170029E7 RID: 10727
			// (get) Token: 0x06013083 RID: 77955 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06013084 RID: 77956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170029E7")]
			[Inspect("isSingle", false)]
			[Collection(typeof(SharedConsts.Direction))]
			public string[] effects
			{
				[Token(Token = "0x6013083")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x6013084")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x170029E8 RID: 10728
			// (get) Token: 0x06013085 RID: 77957 RVA: 0x000746A0 File Offset: 0x000728A0
			[Token(Token = "0x170029E8")]
			public bool isSingle
			{
				[Token(Token = "0x6013085")]
				[Address(RVA = "0x9262F0", Offset = "0x924EF0", VA = "0x1809262F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170029E9 RID: 10729
			// (get) Token: 0x06013086 RID: 77958 RVA: 0x000746B8 File Offset: 0x000728B8
			[Token(Token = "0x170029E9")]
			protected float playbackSpeed
			{
				[Token(Token = "0x6013086")]
				[Address(RVA = "0xAE2870", Offset = "0xAE1470", VA = "0x180AE2870")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170029EA RID: 10730
			// (get) Token: 0x06013087 RID: 77959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029EA")]
			protected Entity owner
			{
				[Token(Token = "0x6013087")]
				[Address(RVA = "0xAE2850", Offset = "0xAE1450", VA = "0x180AE2850")]
				get
				{
					return null;
				}
			}

			// Token: 0x170029EB RID: 10731
			// (get) Token: 0x06013088 RID: 77960 RVA: 0x000746D0 File Offset: 0x000728D0
			[Token(Token = "0x170029EB")]
			protected KeyValuePair<Vector2, ObjectPtr<Entity>> inputTarget
			{
				[Token(Token = "0x6013088")]
				[Address(RVA = "0xAE27F0", Offset = "0xAE13F0", VA = "0x180AE27F0")]
				get
				{
					return default(KeyValuePair<Vector2, ObjectPtr<Entity>>);
				}
			}

			// Token: 0x170029EC RID: 10732
			// (get) Token: 0x06013089 RID: 77961 RVA: 0x000746E8 File Offset: 0x000728E8
			[Token(Token = "0x170029EC")]
			protected bool isFirstAttack
			{
				[Token(Token = "0x6013089")]
				[Address(RVA = "0xAE2830", Offset = "0xAE1430", VA = "0x180AE2830")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170029ED RID: 10733
			// (get) Token: 0x0601308A RID: 77962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029ED")]
			protected List<ObjectPtr<Entity>> castTargets
			{
				[Token(Token = "0x601308A")]
				[Address(RVA = "0xAE27A0", Offset = "0xAE13A0", VA = "0x180AE27A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170029EE RID: 10734
			// (get) Token: 0x0601308B RID: 77963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029EE")]
			protected List<ObjectPtr<Effect>> allEffects
			{
				[Token(Token = "0x601308B")]
				[Address(RVA = "0xAE2710", Offset = "0xAE1310", VA = "0x180AE2710")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601308C RID: 77964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601308C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "4")]
			public virtual void Init(UberEffectEmitter holder)
			{
			}

			// Token: 0x0601308D RID: 77965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601308D")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public virtual void OnCastOnTarget(Entity target)
			{
			}

			// Token: 0x0601308E RID: 77966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601308E")]
			[Address(RVA = "0xAE1EE0", Offset = "0xAE0AE0", VA = "0x180AE1EE0", Slot = "6")]
			public virtual void OnCastStart()
			{
			}

			// Token: 0x0601308F RID: 77967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601308F")]
			[Address(RVA = "0xAE1ED0", Offset = "0xAE0AD0", VA = "0x180AE1ED0", Slot = "7")]
			public virtual void OnCastFinish(Ability.FinishReason reason)
			{
			}

			// Token: 0x06013090 RID: 77968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013090")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public virtual void OnEvent(AbilityStandard.Event ev)
			{
			}

			// Token: 0x06013091 RID: 77969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013091")]
			[Address(RVA = "0xAE2420", Offset = "0xAE1020", VA = "0x180AE2420")]
			protected void _ClearAllEffects()
			{
			}

			// Token: 0x06013092 RID: 77970 RVA: 0x00074700 File Offset: 0x00072900
			[Token(Token = "0x6013092")]
			[Address(RVA = "0xAE1FE0", Offset = "0xAE0BE0", VA = "0x180AE1FE0")]
			protected bool TryGetEffect(out string effect)
			{
				return default(bool);
			}

			// Token: 0x06013093 RID: 77971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6013093")]
			[Address(RVA = "0xAE1E00", Offset = "0xAE0A00", VA = "0x180AE1E00")]
			protected Entity GetInputTargetAsEntity()
			{
				return null;
			}

			// Token: 0x06013094 RID: 77972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013094")]
			[Address(RVA = "0xAE1CC0", Offset = "0xAE08C0", VA = "0x180AE1CC0")]
			public void GatherEffects(List<string> effects)
			{
			}

			// Token: 0x06013095 RID: 77973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6013095")]
			[Address(RVA = "0xAE1F50", Offset = "0xAE0B50", VA = "0x180AE1F50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06013096 RID: 77974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013096")]
			[Address(RVA = "0xAE26B0", Offset = "0xAE12B0", VA = "0x180AE26B0")]
			public EffectOptions()
			{
			}

			// Token: 0x040157F7 RID: 88055
			[Token(Token = "0x40157F7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public UberEffectEmitter.EffectOptions.DirectionType _directionType;

			// Token: 0x040157F8 RID: 88056
			[Token(Token = "0x40157F8")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			private string[] _effects;

			// Token: 0x040157F9 RID: 88057
			[Token(Token = "0x40157F9")]
			[FieldOffset(Offset = "0x20")]
			protected UberEffectEmitter m_holder;

			// Token: 0x040157FA RID: 88058
			[Token(Token = "0x40157FA")]
			[FieldOffset(Offset = "0x28")]
			protected List<ObjectPtr<Effect>> m_allEffects;

			// Token: 0x02002C04 RID: 11268
			[Token(Token = "0x2002C04")]
			public enum DirectionType
			{
				// Token: 0x040157FC RID: 88060
				[Token(Token = "0x40157FC")]
				NONE,
				// Token: 0x040157FD RID: 88061
				[Token(Token = "0x40157FD")]
				L_OR_R,
				// Token: 0x040157FE RID: 88062
				[Token(Token = "0x40157FE")]
				U_OR_D,
				// Token: 0x040157FF RID: 88063
				[Token(Token = "0x40157FF")]
				FOUR_DIR,
				// Token: 0x04015800 RID: 88064
				[Token(Token = "0x4015800")]
				UD_OR_LR,
				// Token: 0x04015801 RID: 88065
				[Token(Token = "0x4015801")]
				FOUR_DIR_FIXED
			}
		}

		// Token: 0x02002C05 RID: 11269
		[Token(Token = "0x2002C05")]
		[Serializable]
		public class HitEffectOptions : UberEffectEmitter.EffectOptions
		{
			// Token: 0x170029EF RID: 10735
			// (get) Token: 0x06013097 RID: 77975 RVA: 0x00074718 File Offset: 0x00072918
			[Token(Token = "0x170029EF")]
			public bool oneshot
			{
				[Token(Token = "0x6013097")]
				[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06013098 RID: 77976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013098")]
			[Address(RVA = "0xAE5400", Offset = "0xAE4000", VA = "0x180AE5400", Slot = "4")]
			public override void Init(UberEffectEmitter holder)
			{
			}

			// Token: 0x06013099 RID: 77977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013099")]
			[Address(RVA = "0xAE5BA0", Offset = "0xAE47A0", VA = "0x180AE5BA0", Slot = "6")]
			public override void OnCastStart()
			{
			}

			// Token: 0x0601309A RID: 77978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601309A")]
			[Address(RVA = "0xAE5490", Offset = "0xAE4090", VA = "0x180AE5490", Slot = "7")]
			public override void OnCastFinish(Ability.FinishReason reason)
			{
			}

			// Token: 0x0601309B RID: 77979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601309B")]
			[Address(RVA = "0xAE54D0", Offset = "0xAE40D0", VA = "0x180AE54D0", Slot = "5")]
			public override void OnCastOnTarget(Entity target)
			{
			}

			// Token: 0x0601309C RID: 77980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601309C")]
			[Address(RVA = "0xAE5C60", Offset = "0xAE4860", VA = "0x180AE5C60", Slot = "8")]
			public override void OnEvent(AbilityStandard.Event ev)
			{
			}

			// Token: 0x0601309D RID: 77981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601309D")]
			[Address(RVA = "0xAE5C80", Offset = "0xAE4880", VA = "0x180AE5C80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0601309E RID: 77982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601309E")]
			[Address(RVA = "0xAE5D30", Offset = "0xAE4930", VA = "0x180AE5D30")]
			private void _ClearEffects()
			{
			}

			// Token: 0x0601309F RID: 77983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601309F")]
			[Address(RVA = "0xAE5E90", Offset = "0xAE4A90", VA = "0x180AE5E90")]
			public HitEffectOptions()
			{
			}

			// Token: 0x04015802 RID: 88066
			[Token(Token = "0x4015802")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _oneshot;

			// Token: 0x04015803 RID: 88067
			[Token(Token = "0x4015803")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			[Inspect("oneshot", Condition = false)]
			private AbilityStandard.Event _endEvent;

			// Token: 0x04015804 RID: 88068
			[Token(Token = "0x4015804")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private bool _onlyOnce;

			// Token: 0x04015805 RID: 88069
			[Token(Token = "0x4015805")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			[Tooltip("Use 'faceTo' rather than 'faceVector' as input of CreateEffect().")]
			private bool _useFourDirectionalFace;

			// Token: 0x04015806 RID: 88070
			[Token(Token = "0x4015806")]
			[FieldOffset(Offset = "0x3A")]
			[SerializeField]
			private bool _useOwnerToTargetDirection;

			// Token: 0x04015807 RID: 88071
			[Token(Token = "0x4015807")]
			[FieldOffset(Offset = "0x3B")]
			[SerializeField]
			private bool _playIfNotInputTarget;

			// Token: 0x04015808 RID: 88072
			[Token(Token = "0x4015808")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private bool _playOnlyIfInputTarget;

			// Token: 0x04015809 RID: 88073
			[Token(Token = "0x4015809")]
			[FieldOffset(Offset = "0x3D")]
			private bool m_casted;

			// Token: 0x0401580A RID: 88074
			[Token(Token = "0x401580A")]
			[FieldOffset(Offset = "0x40")]
			private List<ObjectPtr<Effect>> m_effects;
		}

		// Token: 0x02002C06 RID: 11270
		[Token(Token = "0x2002C06")]
		[Serializable]
		public class CastEffectOptions : UberEffectEmitter.EffectOptions
		{
			// Token: 0x170029F0 RID: 10736
			// (get) Token: 0x060130A0 RID: 77984 RVA: 0x00074730 File Offset: 0x00072930
			[Token(Token = "0x170029F0")]
			public bool oneshot
			{
				[Token(Token = "0x60130A0")]
				[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060130A1 RID: 77985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A1")]
			[Address(RVA = "0xB17B40", Offset = "0xB16740", VA = "0x180B17B40", Slot = "4")]
			public override void Init(UberEffectEmitter holder)
			{
			}

			// Token: 0x060130A2 RID: 77986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A2")]
			[Address(RVA = "0xB17C10", Offset = "0xB16810", VA = "0x180B17C10", Slot = "6")]
			public override void OnCastStart()
			{
			}

			// Token: 0x060130A3 RID: 77987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A3")]
			[Address(RVA = "0xB17BD0", Offset = "0xB167D0", VA = "0x180B17BD0", Slot = "7")]
			public override void OnCastFinish(Ability.FinishReason reason)
			{
			}

			// Token: 0x060130A4 RID: 77988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A4")]
			[Address(RVA = "0xB17C80", Offset = "0xB16880", VA = "0x180B17C80", Slot = "8")]
			public override void OnEvent(AbilityStandard.Event ev)
			{
			}

			// Token: 0x060130A5 RID: 77989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60130A5")]
			[Address(RVA = "0xB18080", Offset = "0xB16C80", VA = "0x180B18080", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060130A6 RID: 77990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60130A6")]
			[Address(RVA = "0xB179E0", Offset = "0xB165E0", VA = "0x180B179E0", Slot = "9")]
			protected virtual Effect CreateEffect(string effect)
			{
				return null;
			}

			// Token: 0x060130A7 RID: 77991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A7")]
			[Address(RVA = "0xB17E10", Offset = "0xB16A10", VA = "0x180B17E10", Slot = "10")]
			protected virtual void PlayEffect()
			{
			}

			// Token: 0x060130A8 RID: 77992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A8")]
			[Address(RVA = "0xB18390", Offset = "0xB16F90", VA = "0x180B18390")]
			private void _ClearEffects()
			{
			}

			// Token: 0x060130A9 RID: 77993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130A9")]
			[Address(RVA = "0xB184F0", Offset = "0xB170F0", VA = "0x180B184F0")]
			public CastEffectOptions()
			{
			}

			// Token: 0x0401580B RID: 88075
			[Token(Token = "0x401580B")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _oneshot;

			// Token: 0x0401580C RID: 88076
			[Token(Token = "0x401580C")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private AbilityStandard.Event _startEvent;

			// Token: 0x0401580D RID: 88077
			[Token(Token = "0x401580D")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			[Inspect("oneshot", Condition = false)]
			private AbilityStandard.Event _endEvent;

			// Token: 0x0401580E RID: 88078
			[Token(Token = "0x401580E")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private bool _onlyOnce;

			// Token: 0x0401580F RID: 88079
			[Token(Token = "0x401580F")]
			[FieldOffset(Offset = "0x3D")]
			[SerializeField]
			[Tooltip("Use 'faceTo' rather than 'faceVector' as input of CreateEffect().")]
			private bool _useFourDirectionalFace;

			// Token: 0x04015810 RID: 88080
			[Token(Token = "0x4015810")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private float _delayIfFirstAttack;

			// Token: 0x04015811 RID: 88081
			[Token(Token = "0x4015811")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private string _hookEffectAfterFirstAttack;

			// Token: 0x04015812 RID: 88082
			[Token(Token = "0x4015812")]
			[FieldOffset(Offset = "0x50")]
			private bool m_casted;

			// Token: 0x04015813 RID: 88083
			[Token(Token = "0x4015813")]
			[FieldOffset(Offset = "0x58")]
			protected List<ObjectPtr<Effect>> m_effects;
		}

		// Token: 0x02002C07 RID: 11271
		[Token(Token = "0x2002C07")]
		[Serializable]
		public class AttachEffectOptions : UberEffectEmitter.EffectOptions
		{
			// Token: 0x060130AA RID: 77994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130AA")]
			[Address(RVA = "0xB14330", Offset = "0xB12F30", VA = "0x180B14330", Slot = "8")]
			public override void OnEvent(AbilityStandard.Event ev)
			{
			}

			// Token: 0x060130AB RID: 77995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130AB")]
			[Address(RVA = "0xB145F0", Offset = "0xB131F0", VA = "0x180B145F0")]
			private void _ClearEffect()
			{
			}

			// Token: 0x060130AC RID: 77996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130AC")]
			[Address(RVA = "0xB146A0", Offset = "0xB132A0", VA = "0x180B146A0")]
			public AttachEffectOptions()
			{
			}

			// Token: 0x04015814 RID: 88084
			[Token(Token = "0x4015814")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _onlyAttachOnDummy;

			// Token: 0x04015815 RID: 88085
			[Token(Token = "0x4015815")]
			[FieldOffset(Offset = "0x38")]
			private ObjectPtr<Effect> m_effect;
		}

		// Token: 0x02002C08 RID: 11272
		[Token(Token = "0x2002C08")]
		[Serializable]
		public class InputTargetEffectOptions : UberEffectEmitter.CastEffectOptions
		{
			// Token: 0x060130AD RID: 77997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60130AD")]
			[Address(RVA = "0xB1B5F0", Offset = "0xB1A1F0", VA = "0x180B1B5F0", Slot = "9")]
			protected override Effect CreateEffect(string effect)
			{
				return null;
			}

			// Token: 0x060130AE RID: 77998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130AE")]
			[Address(RVA = "0xB184F0", Offset = "0xB170F0", VA = "0x180B184F0")]
			public InputTargetEffectOptions()
			{
			}

			// Token: 0x04015816 RID: 88086
			[Token(Token = "0x4015816")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private bool _useInputPos;
		}

		// Token: 0x02002C09 RID: 11273
		[Token(Token = "0x2002C09")]
		[Serializable]
		public class CastTargetEffectOptions : UberEffectEmitter.CastEffectOptions
		{
			// Token: 0x060130AF RID: 77999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130AF")]
			[Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "10")]
			protected override void PlayEffect()
			{
			}

			// Token: 0x060130B0 RID: 78000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130B0")]
			[Address(RVA = "0xB184F0", Offset = "0xB170F0", VA = "0x180B184F0")]
			public CastTargetEffectOptions()
			{
			}
		}
	}
}
