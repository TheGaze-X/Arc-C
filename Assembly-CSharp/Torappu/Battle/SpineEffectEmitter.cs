using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F6 RID: 8694
	[Token(Token = "0x20021F6")]
	public class SpineEffectEmitter : MonoBehaviour, IEffectSource, IHotfixable
	{
		// Token: 0x0600D994 RID: 55700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D994")]
		[Address(RVA = "0x35EE5E0", Offset = "0x35ED1E0", VA = "0x1835EE5E0")]
		public void Init(Unit owner)
		{
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D995")]
		[Address(RVA = "0x35EE660", Offset = "0x35ED260", VA = "0x1835EE660")]
		public void PlayEffect(int index)
		{
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D996")]
		[Address(RVA = "0x35EE410", Offset = "0x35ED010", VA = "0x1835EE410", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D997")]
		[Address(RVA = "0x35EE8E0", Offset = "0x35ED4E0", VA = "0x1835EE8E0")]
		public SpineEffectEmitter()
		{
		}

		// Token: 0x0400EAD0 RID: 60112
		[Token(Token = "0x400EAD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpineEffectEmitter.SpineEffectPreset[] _spineEffectPresets;

		// Token: 0x0400EAD1 RID: 60113
		[Token(Token = "0x400EAD1")]
		[FieldOffset(Offset = "0x20")]
		private Unit m_owner;

		// Token: 0x0400EAD2 RID: 60114
		[Token(Token = "0x400EAD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EAD3 RID: 60115
		[Token(Token = "0x400EAD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayEffect;

		// Token: 0x0400EAD4 RID: 60116
		[Token(Token = "0x400EAD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400EAD5 RID: 60117
		[Token(Token = "0x400EAD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021F7 RID: 8695
		[Token(Token = "0x20021F7")]
		[Serializable]
		public class SpineEffectPreset
		{
			// Token: 0x17001AD8 RID: 6872
			// (get) Token: 0x0600D998 RID: 55704 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D999 RID: 55705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001AD8")]
			[Inspect("isSingle")]
			public string effect
			{
				[Token(Token = "0x600D998")]
				[Address(RVA = "0x35EEE60", Offset = "0x35EDA60", VA = "0x1835EEE60")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D999")]
				[Address(RVA = "0x35EEEA0", Offset = "0x35EDAA0", VA = "0x1835EEEA0")]
				set
				{
				}
			}

			// Token: 0x17001AD9 RID: 6873
			// (get) Token: 0x0600D99A RID: 55706 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D99B RID: 55707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001AD9")]
			[Inspect("isSingle", false)]
			[Collection(typeof(SharedConsts.Direction))]
			public string[] effects
			{
				[Token(Token = "0x600D99A")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x600D99B")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				set
				{
				}
			}

			// Token: 0x17001ADA RID: 6874
			// (get) Token: 0x0600D99C RID: 55708 RVA: 0x0004F008 File Offset: 0x0004D208
			[Token(Token = "0x17001ADA")]
			public bool isSingle
			{
				[Token(Token = "0x600D99C")]
				[Address(RVA = "0x35EEE90", Offset = "0x35EDA90", VA = "0x1835EEE90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600D99D RID: 55709 RVA: 0x0004F020 File Offset: 0x0004D220
			[Token(Token = "0x600D99D")]
			[Address(RVA = "0x35EED10", Offset = "0x35ED910", VA = "0x1835EED10")]
			private SharedConsts.Direction _GetDirection(Entity entity)
			{
				return SharedConsts.Direction.UP;
			}

			// Token: 0x0600D99E RID: 55710 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D99E")]
			[Address(RVA = "0x35EEA80", Offset = "0x35ED680", VA = "0x1835EEA80")]
			public string GetEffect(Entity owner)
			{
				return null;
			}

			// Token: 0x0600D99F RID: 55711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D99F")]
			[Address(RVA = "0x35EE940", Offset = "0x35ED540", VA = "0x1835EE940")]
			public void GatherEffects(List<string> effects)
			{
			}

			// Token: 0x0600D9A0 RID: 55712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9A0")]
			[Address(RVA = "0x35EEE00", Offset = "0x35EDA00", VA = "0x1835EEE00")]
			public SpineEffectPreset()
			{
			}

			// Token: 0x0400EAD6 RID: 60118
			[Token(Token = "0x400EAD6")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			// Token: 0x0400EAD7 RID: 60119
			[Token(Token = "0x400EAD7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SpineEffectEmitter.SpineEffectPreset.DirectionType _directionType;

			// Token: 0x0400EAD8 RID: 60120
			[Token(Token = "0x400EAD8")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public bool createAtWorldPos;

			// Token: 0x0400EAD9 RID: 60121
			[Token(Token = "0x400EAD9")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private string[] _effects;

			// Token: 0x020021F8 RID: 8696
			[Token(Token = "0x20021F8")]
			public enum DirectionType
			{
				// Token: 0x0400EADB RID: 60123
				[Token(Token = "0x400EADB")]
				NONE,
				// Token: 0x0400EADC RID: 60124
				[Token(Token = "0x400EADC")]
				L_OR_R,
				// Token: 0x0400EADD RID: 60125
				[Token(Token = "0x400EADD")]
				U_OR_D,
				// Token: 0x0400EADE RID: 60126
				[Token(Token = "0x400EADE")]
				FOUR_DIR,
				// Token: 0x0400EADF RID: 60127
				[Token(Token = "0x400EADF")]
				UD_OR_LR
			}
		}
	}
}
