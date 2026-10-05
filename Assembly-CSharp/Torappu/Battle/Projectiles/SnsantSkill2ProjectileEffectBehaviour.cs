using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B9 RID: 10681
	[Token(Token = "0x20029B9")]
	public class SnsantSkill2ProjectileEffectBehaviour : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06011AFA RID: 72442 RVA: 0x0006C618 File Offset: 0x0006A818
		[Token(Token = "0x170026FC")]
		private bool hookStartPoint
		{
			[Token(Token = "0x6011AFA")]
			[Address(RVA = "0x98B010", Offset = "0x989C10", VA = "0x18098B010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011AFB RID: 72443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AFB")]
		[Address(RVA = "0x989230", Offset = "0x987E30", VA = "0x180989230", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AFC RID: 72444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AFC")]
		[Address(RVA = "0x98A550", Offset = "0x989150", VA = "0x18098A550")]
		private void _HarpoonInit(ILocatable start)
		{
		}

		// Token: 0x06011AFD RID: 72445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AFD")]
		[Address(RVA = "0x989360", Offset = "0x987F60", VA = "0x180989360", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011AFE RID: 72446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AFE")]
		[Address(RVA = "0x989B80", Offset = "0x988780", VA = "0x180989B80", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011AFF RID: 72447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AFF")]
		[Address(RVA = "0x989470", Offset = "0x988070", VA = "0x180989470", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011B00 RID: 72448 RVA: 0x0006C630 File Offset: 0x0006A830
		[Token(Token = "0x6011B00")]
		[Address(RVA = "0x98AD60", Offset = "0x989960", VA = "0x18098AD60")]
		private bool _TryHookStartPoint(out MountPoint startPoint)
		{
			return default(bool);
		}

		// Token: 0x06011B01 RID: 72449 RVA: 0x0006C648 File Offset: 0x0006A848
		[Token(Token = "0x6011B01")]
		[Address(RVA = "0x98A9D0", Offset = "0x9895D0", VA = "0x18098A9D0")]
		private bool _RefreshTargetAndEffect()
		{
			return default(bool);
		}

		// Token: 0x06011B02 RID: 72450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B02")]
		[Address(RVA = "0x989DE0", Offset = "0x9889E0", VA = "0x180989DE0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B03 RID: 72451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B03")]
		[Address(RVA = "0x98A1B0", Offset = "0x988DB0", VA = "0x18098A1B0")]
		private void _DoEffectMovement()
		{
		}

		// Token: 0x06011B04 RID: 72452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B04")]
		[Address(RVA = "0x989140", Offset = "0x987D40", VA = "0x180989140", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011B05 RID: 72453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B05")]
		[Address(RVA = "0x98AF00", Offset = "0x989B00", VA = "0x18098AF00")]
		public SnsantSkill2ProjectileEffectBehaviour()
		{
		}

		// Token: 0x06011B06 RID: 72454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B06")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B07 RID: 72455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B07")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011B08 RID: 72456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B08")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011B09 RID: 72457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B09")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011B0A RID: 72458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0A")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D26 RID: 81190
		[Token(Token = "0x4013D26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _effectsWhenReached;

		// Token: 0x04013D27 RID: 81191
		[Token(Token = "0x4013D27")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _movingEffectsWhenReached;

		// Token: 0x04013D28 RID: 81192
		[Token(Token = "0x4013D28")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _initMovingEffectWithMainEffect;

		// Token: 0x04013D29 RID: 81193
		[Token(Token = "0x4013D29")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _harpoonEffect;

		// Token: 0x04013D2A RID: 81194
		[Token(Token = "0x4013D2A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _harpoonHeight;

		// Token: 0x04013D2B RID: 81195
		[Token(Token = "0x4013D2B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _adjustRangeEffectOffset;

		// Token: 0x04013D2C RID: 81196
		[Token(Token = "0x4013D2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _hookStartPoint;

		// Token: 0x04013D2D RID: 81197
		[Token(Token = "0x4013D2D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Inspect("hookStartPoint")]
		private Entity.MountPointType _hookedStartPointType;

		// Token: 0x04013D2E RID: 81198
		[Token(Token = "0x4013D2E")]
		private const float MAX_PULL_SQR_DIST = 100f;

		// Token: 0x04013D2F RID: 81199
		[Token(Token = "0x4013D2F")]
		[FieldOffset(Offset = "0x58")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04013D30 RID: 81200
		[Token(Token = "0x4013D30")]
		[FieldOffset(Offset = "0x60")]
		private MountPoint m_startMountPoint;

		// Token: 0x04013D31 RID: 81201
		[Token(Token = "0x4013D31")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] m_positions;

		// Token: 0x04013D32 RID: 81202
		[Token(Token = "0x4013D32")]
		[FieldOffset(Offset = "0x70")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04013D33 RID: 81203
		[Token(Token = "0x4013D33")]
		[FieldOffset(Offset = "0x78")]
		private bool m_targetIsMarkedEnemy;

		// Token: 0x04013D34 RID: 81204
		[Token(Token = "0x4013D34")]
		[FieldOffset(Offset = "0x80")]
		private Enemy m_markedEnemy;

		// Token: 0x04013D35 RID: 81205
		[Token(Token = "0x4013D35")]
		[FieldOffset(Offset = "0x88")]
		private ObjectPtr<Effect> m_cachedMovingEffect;

		// Token: 0x04013D36 RID: 81206
		[Token(Token = "0x4013D36")]
		[FieldOffset(Offset = "0x98")]
		private uint m_traceTargetUid;

		// Token: 0x04013D37 RID: 81207
		[Token(Token = "0x4013D37")]
		[FieldOffset(Offset = "0x9C")]
		private float m_cachedSqrDist;

		// Token: 0x04013D38 RID: 81208
		[Token(Token = "0x4013D38")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_forceInactiveMainEffect;

		// Token: 0x04013D39 RID: 81209
		[Token(Token = "0x4013D39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hookStartPoint;

		// Token: 0x04013D3A RID: 81210
		[Token(Token = "0x4013D3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D3B RID: 81211
		[Token(Token = "0x4013D3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HarpoonInit;

		// Token: 0x04013D3C RID: 81212
		[Token(Token = "0x4013D3C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013D3D RID: 81213
		[Token(Token = "0x4013D3D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D3E RID: 81214
		[Token(Token = "0x4013D3E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013D3F RID: 81215
		[Token(Token = "0x4013D3F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryHookStartPoint;

		// Token: 0x04013D40 RID: 81216
		[Token(Token = "0x4013D40")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshTargetAndEffect;

		// Token: 0x04013D41 RID: 81217
		[Token(Token = "0x4013D41")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D42 RID: 81218
		[Token(Token = "0x4013D42")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoEffectMovement;

		// Token: 0x04013D43 RID: 81219
		[Token(Token = "0x4013D43")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013D44 RID: 81220
		[Token(Token = "0x4013D44")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
