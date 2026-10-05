using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002992 RID: 10642
	[Token(Token = "0x2002992")]
	public class EffectBehaviour : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x060119C1 RID: 72129 RVA: 0x0006C390 File Offset: 0x0006A590
		[Token(Token = "0x170026E6")]
		private bool IsReplaceMainEffectWhenReach
		{
			[Token(Token = "0x60119C1")]
			[Address(RVA = "0x970EA0", Offset = "0x96FAA0", VA = "0x180970EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060119C2 RID: 72130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C2")]
		[Address(RVA = "0x96F1B0", Offset = "0x96DDB0", VA = "0x18096F1B0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119C3 RID: 72131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C3")]
		[Address(RVA = "0x96F9F0", Offset = "0x96E5F0", VA = "0x18096F9F0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x060119C4 RID: 72132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C4")]
		[Address(RVA = "0x970650", Offset = "0x96F250", VA = "0x180970650", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x060119C5 RID: 72133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C5")]
		[Address(RVA = "0x970970", Offset = "0x96F570", VA = "0x180970970", Slot = "8")]
		public override void OnProjectileTrigger()
		{
		}

		// Token: 0x060119C6 RID: 72134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C6")]
		[Address(RVA = "0x970B30", Offset = "0x96F730", VA = "0x180970B30", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119C7 RID: 72135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C7")]
		[Address(RVA = "0x970110", Offset = "0x96ED10", VA = "0x180970110", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x060119C8 RID: 72136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C8")]
		[Address(RVA = "0x96F320", Offset = "0x96DF20", VA = "0x18096F320", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x060119C9 RID: 72137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C9")]
		[Address(RVA = "0x970C10", Offset = "0x96F810", VA = "0x180970C10")]
		protected void _GetNewEffectIfHooked(ref string effectKey)
		{
		}

		// Token: 0x060119CA RID: 72138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CA")]
		[Address(RVA = "0x96F020", Offset = "0x96DC20", VA = "0x18096F020", Slot = "16")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060119CB RID: 72139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CB")]
		[Address(RVA = "0x970D60", Offset = "0x96F960", VA = "0x180970D60")]
		public EffectBehaviour()
		{
		}

		// Token: 0x060119CC RID: 72140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CC")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119CD RID: 72141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CD")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x060119CE RID: 72142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CE")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x060119CF RID: 72143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119CF")]
		[Address(RVA = "0x970C00", Offset = "0x96F800", VA = "0x180970C00")]
		private void <>xLuaBaseProxy_OnProjectileTrigger()
		{
		}

		// Token: 0x060119D0 RID: 72144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D0")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060119D1 RID: 72145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D1")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x060119D2 RID: 72146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D2")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04013B38 RID: 80696
		[Token(Token = "0x4013B38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _effectsWhenStart;

		// Token: 0x04013B39 RID: 80697
		[Token(Token = "0x4013B39")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] _effectsWhenReached;

		// Token: 0x04013B3A RID: 80698
		[Token(Token = "0x4013B3A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _effectsWhenHit;

		// Token: 0x04013B3B RID: 80699
		[Token(Token = "0x4013B3B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _effectsToTargetWhenStart;

		// Token: 0x04013B3C RID: 80700
		[Token(Token = "0x4013B3C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _effectsToTileWhenStart;

		// Token: 0x04013B3D RID: 80701
		[Token(Token = "0x4013B3D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string[] _effectsWhenStop;

		// Token: 0x04013B3E RID: 80702
		[Token(Token = "0x4013B3E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string[] _effectOnTrigger;

		// Token: 0x04013B3F RID: 80703
		[Token(Token = "0x4013B3F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool _onlyPlayHitEffectOnTraceTarget;

		// Token: 0x04013B40 RID: 80704
		[Token(Token = "0x4013B40")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		protected bool _onlyPlayHitEffectOnNotTraceTarget;

		// Token: 0x04013B41 RID: 80705
		[Token(Token = "0x4013B41")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		private bool _onlyPlayHitEffectOnce;

		// Token: 0x04013B42 RID: 80706
		[Token(Token = "0x4013B42")]
		[FieldOffset(Offset = "0x63")]
		[SerializeField]
		protected bool _clearHitEffectOnStop;

		// Token: 0x04013B43 RID: 80707
		[Token(Token = "0x4013B43")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool _clearPlayEffectOnStop;

		// Token: 0x04013B44 RID: 80708
		[Token(Token = "0x4013B44")]
		[FieldOffset(Offset = "0x65")]
		[SerializeField]
		private bool _clearEffectsOnTileOnStop;

		// Token: 0x04013B45 RID: 80709
		[Token(Token = "0x4013B45")]
		[FieldOffset(Offset = "0x66")]
		[SerializeField]
		private bool _clearReachedEffectWhenStop;

		// Token: 0x04013B46 RID: 80710
		[Token(Token = "0x4013B46")]
		[FieldOffset(Offset = "0x67")]
		[SerializeField]
		private bool _alwaysPlayStartEffects;

		// Token: 0x04013B47 RID: 80711
		[Token(Token = "0x4013B47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _playStartEffectOnlyOnProjectile;

		// Token: 0x04013B48 RID: 80712
		[Token(Token = "0x4013B48")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _useSourceFaceVector;

		// Token: 0x04013B49 RID: 80713
		[Token(Token = "0x4013B49")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		protected bool _useSourceFaceVectorOnHit;

		// Token: 0x04013B4A RID: 80714
		[Token(Token = "0x4013B4A")]
		[FieldOffset(Offset = "0x6B")]
		[SerializeField]
		[Tooltip("When projectile reaches target, force its effect's height to entity's Ground level")]
		private bool _forceReachTargetGround;

		// Token: 0x04013B4B RID: 80715
		[Token(Token = "0x4013B4B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Tooltip("Follow target's height until invalid, then force its effect's height to entity's Ground level")]
		private bool _followTargetGround;

		// Token: 0x04013B4C RID: 80716
		[Token(Token = "0x4013B4C")]
		[FieldOffset(Offset = "0x6D")]
		[SerializeField]
		private bool _replaceMainEffectWhenReach;

		// Token: 0x04013B4D RID: 80717
		[Token(Token = "0x4013B4D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Inspect("IsReplaceMainEffectWhenReach")]
		private string _mainEffectToReplace;

		// Token: 0x04013B4E RID: 80718
		[Token(Token = "0x4013B4E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _useTraceTargetWhenReach;

		// Token: 0x04013B4F RID: 80719
		[Token(Token = "0x4013B4F")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _setReachEffectOnProjectile;

		// Token: 0x04013B50 RID: 80720
		[Token(Token = "0x4013B50")]
		[FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool _syncEffectScaleViaProjectile;

		// Token: 0x04013B51 RID: 80721
		[Token(Token = "0x4013B51")]
		[FieldOffset(Offset = "0x7C")]
		private float m_targetGroundPosZ;

		// Token: 0x04013B52 RID: 80722
		[Token(Token = "0x4013B52")]
		[FieldOffset(Offset = "0x80")]
		private ILocatable m_target;

		// Token: 0x04013B53 RID: 80723
		[Token(Token = "0x4013B53")]
		[FieldOffset(Offset = "0x88")]
		private int m_hitEffectCount;

		// Token: 0x04013B54 RID: 80724
		[Token(Token = "0x4013B54")]
		[FieldOffset(Offset = "0x90")]
		protected List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04013B55 RID: 80725
		[Token(Token = "0x4013B55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsReplaceMainEffectWhenReach;

		// Token: 0x04013B56 RID: 80726
		[Token(Token = "0x4013B56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B57 RID: 80727
		[Token(Token = "0x4013B57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013B58 RID: 80728
		[Token(Token = "0x4013B58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013B59 RID: 80729
		[Token(Token = "0x4013B59")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileTrigger;

		// Token: 0x04013B5A RID: 80730
		[Token(Token = "0x4013B5A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B5B RID: 80731
		[Token(Token = "0x4013B5B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013B5C RID: 80732
		[Token(Token = "0x4013B5C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013B5D RID: 80733
		[Token(Token = "0x4013B5D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetNewEffectIfHooked;

		// Token: 0x04013B5E RID: 80734
		[Token(Token = "0x4013B5E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013B5F RID: 80735
		[Token(Token = "0x4013B5F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
