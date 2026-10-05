using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B1 RID: 10673
	[Token(Token = "0x20029B1")]
	public class SequenceEffectBehaviour : EffectBehaviour
	{
		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x06011AD2 RID: 72402 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
		[Token(Token = "0x170026F9")]
		private bool useAbilityPlaybackSpeed
		{
			[Token(Token = "0x6011AD2")]
			[Address(RVA = "0x9871A0", Offset = "0x985DA0", VA = "0x1809871A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x06011AD3 RID: 72403 RVA: 0x0006C5E8 File Offset: 0x0006A7E8
		[Token(Token = "0x170026FA")]
		private bool enableOverloadEffect
		{
			[Token(Token = "0x6011AD3")]
			[Address(RVA = "0x987140", Offset = "0x985D40", VA = "0x180987140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06011AD4 RID: 72404 RVA: 0x0006C600 File Offset: 0x0006A800
		[Token(Token = "0x170026FB")]
		private float abilityPlaybackSpeed
		{
			[Token(Token = "0x6011AD4")]
			[Address(RVA = "0x987070", Offset = "0x985C70", VA = "0x180987070")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06011AD5 RID: 72405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD5")]
		[Address(RVA = "0x986E20", Offset = "0x985A20", VA = "0x180986E20", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011AD6 RID: 72406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD6")]
		[Address(RVA = "0x9867A0", Offset = "0x9853A0", VA = "0x1809867A0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011AD7 RID: 72407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD7")]
		[Address(RVA = "0x9866B0", Offset = "0x9852B0", VA = "0x1809866B0", Slot = "16")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011AD8 RID: 72408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD8")]
		[Address(RVA = "0x987010", Offset = "0x985C10", VA = "0x180987010")]
		public SequenceEffectBehaviour()
		{
		}

		// Token: 0x06011AD9 RID: 72409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD9")]
		[Address(RVA = "0x987000", Offset = "0x985C00", VA = "0x180987000")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011ADA RID: 72410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADA")]
		[Address(RVA = "0x9812E0", Offset = "0x97FEE0", VA = "0x1809812E0")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADB")]
		[Address(RVA = "0x986FF0", Offset = "0x985BF0", VA = "0x180986FF0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04013CED RID: 81133
		[Token(Token = "0x4013CED")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _useAbilityPlaybackSpeed;

		// Token: 0x04013CEE RID: 81134
		[Token(Token = "0x4013CEE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Inspect("useAbilityPlaybackSpeed")]
		private string _customAbilityAlias;

		// Token: 0x04013CEF RID: 81135
		[Token(Token = "0x4013CEF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int _effectGroupStartIndex;

		// Token: 0x04013CF0 RID: 81136
		[Token(Token = "0x4013CF0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SequenceEffectBehaviour.EffectGroup[] _effectGroups;

		// Token: 0x04013CF1 RID: 81137
		[Token(Token = "0x4013CF1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _enableOverloadEffect;

		// Token: 0x04013CF2 RID: 81138
		[Token(Token = "0x4013CF2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Inspect("enableOverloadEffect")]
		private SequenceEffectBehaviour.EffectGroup[] _overloadGroups;

		// Token: 0x04013CF3 RID: 81139
		[Token(Token = "0x4013CF3")]
		[FieldOffset(Offset = "0xC8")]
		private int m_currentEffectGroupIndex;

		// Token: 0x04013CF4 RID: 81140
		[Token(Token = "0x4013CF4")]
		[FieldOffset(Offset = "0xD0")]
		private AbilityStandard m_ability;

		// Token: 0x04013CF5 RID: 81141
		[Token(Token = "0x4013CF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useAbilityPlaybackSpeed;

		// Token: 0x04013CF6 RID: 81142
		[Token(Token = "0x4013CF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enableOverloadEffect;

		// Token: 0x04013CF7 RID: 81143
		[Token(Token = "0x4013CF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_abilityPlaybackSpeed;

		// Token: 0x04013CF8 RID: 81144
		[Token(Token = "0x4013CF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013CF9 RID: 81145
		[Token(Token = "0x4013CF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013CFA RID: 81146
		[Token(Token = "0x4013CFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013CFB RID: 81147
		[Token(Token = "0x4013CFB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029B2 RID: 10674
		[Token(Token = "0x20029B2")]
		[Serializable]
		public struct EffectGroup
		{
			// Token: 0x04013CFC RID: 81148
			[Token(Token = "0x4013CFC")]
			[FieldOffset(Offset = "0x0")]
			public string[] effectsWhenHit;
		}
	}
}
