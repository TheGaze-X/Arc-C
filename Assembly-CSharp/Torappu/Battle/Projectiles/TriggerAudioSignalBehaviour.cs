using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C1 RID: 10689
	[Token(Token = "0x20029C1")]
	public class TriggerAudioSignalBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x06011B37 RID: 72503 RVA: 0x0006C660 File Offset: 0x0006A860
		[Token(Token = "0x170026FD")]
		private bool useAbilityPlaybackSpeed
		{
			[Token(Token = "0x6011B37")]
			[Address(RVA = "0x98EB50", Offset = "0x98D750", VA = "0x18098EB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x06011B38 RID: 72504 RVA: 0x0006C678 File Offset: 0x0006A878
		[Token(Token = "0x170026FE")]
		private float abilityPlaybackSpeed
		{
			[Token(Token = "0x6011B38")]
			[Address(RVA = "0x98EA90", Offset = "0x98D690", VA = "0x18098EA90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06011B39 RID: 72505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011B39")]
		[Address(RVA = "0x98E950", Offset = "0x98D550", VA = "0x18098E950")]
		private IEnumerator _DoEmitAudioSignal(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06011B3A RID: 72506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3A")]
		[Address(RVA = "0x98E420", Offset = "0x98D020", VA = "0x18098E420", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011B3B RID: 72507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3B")]
		[Address(RVA = "0x98E710", Offset = "0x98D310", VA = "0x18098E710", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011B3C RID: 72508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3C")]
		[Address(RVA = "0x98E8C0", Offset = "0x98D4C0", VA = "0x18098E8C0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011B3D RID: 72509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3D")]
		[Address(RVA = "0x98EA30", Offset = "0x98D630", VA = "0x18098EA30")]
		public TriggerAudioSignalBehaviour()
		{
		}

		// Token: 0x06011B3E RID: 72510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3E")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011B3F RID: 72511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B3F")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011B40 RID: 72512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B40")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013D86 RID: 81286
		[Token(Token = "0x4013D86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _preDelay;

		// Token: 0x04013D87 RID: 81287
		[Token(Token = "0x4013D87")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _useAbilityPlaybackSpeed;

		// Token: 0x04013D88 RID: 81288
		[Token(Token = "0x4013D88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("useAbilityPlaybackSpeed")]
		private string _customAbilityAlias;

		// Token: 0x04013D89 RID: 81289
		[Token(Token = "0x4013D89")]
		[FieldOffset(Offset = "0x38")]
		private AbilityStandard m_standardAbility;

		// Token: 0x04013D8A RID: 81290
		[Token(Token = "0x4013D8A")]
		[FieldOffset(Offset = "0x40")]
		private float m_preDelay;

		// Token: 0x04013D8B RID: 81291
		[Token(Token = "0x4013D8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useAbilityPlaybackSpeed;

		// Token: 0x04013D8C RID: 81292
		[Token(Token = "0x4013D8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_abilityPlaybackSpeed;

		// Token: 0x04013D8D RID: 81293
		[Token(Token = "0x4013D8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoEmitAudioSignal;

		// Token: 0x04013D8E RID: 81294
		[Token(Token = "0x4013D8E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013D8F RID: 81295
		[Token(Token = "0x4013D8F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013D90 RID: 81296
		[Token(Token = "0x4013D90")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D91 RID: 81297
		[Token(Token = "0x4013D91")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
