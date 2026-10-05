using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002998 RID: 10648
	[Token(Token = "0x2002998")]
	public class HarpoonRenderer : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x060119F4 RID: 72180 RVA: 0x0006C408 File Offset: 0x0006A608
		[Token(Token = "0x170026E7")]
		private bool hookStartPoint
		{
			[Token(Token = "0x60119F4")]
			[Address(RVA = "0x974A60", Offset = "0x973660", VA = "0x180974A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060119F5 RID: 72181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F5")]
		[Address(RVA = "0x973480", Offset = "0x972080", VA = "0x180973480", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119F6 RID: 72182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F6")]
		[Address(RVA = "0x974010", Offset = "0x972C10", VA = "0x180974010", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x060119F7 RID: 72183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F7")]
		[Address(RVA = "0x973FB0", Offset = "0x972BB0", VA = "0x180973FB0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x060119F8 RID: 72184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F8")]
		[Address(RVA = "0x974160", Offset = "0x972D60", VA = "0x180974160", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119F9 RID: 72185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F9")]
		[Address(RVA = "0x974540", Offset = "0x973140", VA = "0x180974540")]
		private void _UpdatePosition()
		{
		}

		// Token: 0x060119FA RID: 72186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119FA")]
		[Address(RVA = "0x974310", Offset = "0x972F10", VA = "0x180974310")]
		private void Update()
		{
		}

		// Token: 0x060119FB RID: 72187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119FB")]
		[Address(RVA = "0x9733E0", Offset = "0x971FE0", VA = "0x1809733E0", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060119FC RID: 72188 RVA: 0x0006C420 File Offset: 0x0006A620
		[Token(Token = "0x60119FC")]
		[Address(RVA = "0x9743A0", Offset = "0x972FA0", VA = "0x1809743A0")]
		private bool _TryHookStartPoint(out MountPoint startPoint)
		{
			return default(bool);
		}

		// Token: 0x060119FD RID: 72189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119FD")]
		[Address(RVA = "0x974950", Offset = "0x973550", VA = "0x180974950")]
		public HarpoonRenderer()
		{
		}

		// Token: 0x060119FE RID: 72190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119FE")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119FF RID: 72191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119FF")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A00 RID: 72192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A00")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011A01 RID: 72193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A01")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013B8B RID: 80779
		[Token(Token = "0x4013B8B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _mainEffect;

		// Token: 0x04013B8C RID: 80780
		[Token(Token = "0x4013B8C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _throwEffect;

		// Token: 0x04013B8D RID: 80781
		[Token(Token = "0x4013B8D")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _includeInactive;

		// Token: 0x04013B8E RID: 80782
		[Token(Token = "0x4013B8E")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _useEndPointAsStartPos;

		// Token: 0x04013B8F RID: 80783
		[Token(Token = "0x4013B8F")]
		[FieldOffset(Offset = "0x33")]
		[SerializeField]
		private bool _hookStartPoint;

		// Token: 0x04013B90 RID: 80784
		[Token(Token = "0x4013B90")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Inspect("hookStartPoint")]
		private Entity.MountPointType _hookedStartPointType;

		// Token: 0x04013B91 RID: 80785
		[Token(Token = "0x4013B91")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _finishOnMountPointInvalid;

		// Token: 0x04013B92 RID: 80786
		[Token(Token = "0x4013B92")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _spawnOnSource;

		// Token: 0x04013B93 RID: 80787
		[Token(Token = "0x4013B93")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _independentUpdateAfterReached;

		// Token: 0x04013B94 RID: 80788
		[Token(Token = "0x4013B94")]
		[FieldOffset(Offset = "0x3B")]
		[SerializeField]
		private bool _useHitAsEndPoint;

		// Token: 0x04013B95 RID: 80789
		[Token(Token = "0x4013B95")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _followProjectile;

		// Token: 0x04013B96 RID: 80790
		[Token(Token = "0x4013B96")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _onlyUpdateEnd;

		// Token: 0x04013B97 RID: 80791
		[Token(Token = "0x4013B97")]
		[FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool _useOffsetByProjectileDirection;

		// Token: 0x04013B98 RID: 80792
		[Token(Token = "0x4013B98")]
		[FieldOffset(Offset = "0x40")]
		protected ObjectPtr<Effect> m_mainEffect;

		// Token: 0x04013B99 RID: 80793
		[Token(Token = "0x4013B99")]
		[FieldOffset(Offset = "0x50")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04013B9A RID: 80794
		[Token(Token = "0x4013B9A")]
		[FieldOffset(Offset = "0x58")]
		private MountPoint m_startMountPoint;

		// Token: 0x04013B9B RID: 80795
		[Token(Token = "0x4013B9B")]
		[FieldOffset(Offset = "0x60")]
		private MountPoint m_endMountPoint;

		// Token: 0x04013B9C RID: 80796
		[Token(Token = "0x4013B9C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isProjectileReached;

		// Token: 0x04013B9D RID: 80797
		[Token(Token = "0x4013B9D")]
		[FieldOffset(Offset = "0x70")]
		private Vector3[] m_positions;

		// Token: 0x04013B9E RID: 80798
		[Token(Token = "0x4013B9E")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 m_startPosOffset;

		// Token: 0x04013B9F RID: 80799
		[Token(Token = "0x4013B9F")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 m_endPosOffset;

		// Token: 0x04013BA0 RID: 80800
		[Token(Token = "0x4013BA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hookStartPoint;

		// Token: 0x04013BA1 RID: 80801
		[Token(Token = "0x4013BA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013BA2 RID: 80802
		[Token(Token = "0x4013BA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013BA3 RID: 80803
		[Token(Token = "0x4013BA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013BA4 RID: 80804
		[Token(Token = "0x4013BA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013BA5 RID: 80805
		[Token(Token = "0x4013BA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdatePosition;

		// Token: 0x04013BA6 RID: 80806
		[Token(Token = "0x4013BA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04013BA7 RID: 80807
		[Token(Token = "0x4013BA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013BA8 RID: 80808
		[Token(Token = "0x4013BA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryHookStartPoint;

		// Token: 0x04013BA9 RID: 80809
		[Token(Token = "0x4013BA9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
