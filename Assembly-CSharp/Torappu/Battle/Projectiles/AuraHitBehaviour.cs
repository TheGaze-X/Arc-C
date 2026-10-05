using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002987 RID: 10631
	[Token(Token = "0x2002987")]
	public class AuraHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0601195E RID: 72030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026DB")]
		public HashSet<Entity> validTargets
		{
			[Token(Token = "0x601195E")]
			[Address(RVA = "0x968000", Offset = "0x966C00", VA = "0x180968000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0601195F RID: 72031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026DC")]
		protected Range rangeToLoad
		{
			[Token(Token = "0x601195F")]
			[Address(RVA = "0x967FA0", Offset = "0x966BA0", VA = "0x180967FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x06011960 RID: 72032 RVA: 0x0006C1F8 File Offset: 0x0006A3F8
		[Token(Token = "0x170026DD")]
		protected bool onlyCheckHitWhenReachTarget
		{
			[Token(Token = "0x6011960")]
			[Address(RVA = "0x967F40", Offset = "0x966B40", VA = "0x180967F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x06011961 RID: 72033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026DE")]
		private AuraAbility.TargetEnterExitHandler eeHandler
		{
			[Token(Token = "0x6011961")]
			[Address(RVA = "0x967D80", Offset = "0x966980", VA = "0x180967D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011962 RID: 72034 RVA: 0x0006C210 File Offset: 0x0006A410
		[Token(Token = "0x6011962")]
		[Address(RVA = "0x9675D0", Offset = "0x9661D0", VA = "0x1809675D0")]
		private bool _DoTargetEnter(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06011963 RID: 72035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011963")]
		[Address(RVA = "0x967880", Offset = "0x966480", VA = "0x180967880")]
		private void _DoTargetExit(Entity target)
		{
		}

		// Token: 0x06011964 RID: 72036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011964")]
		[Address(RVA = "0x967220", Offset = "0x965E20", VA = "0x180967220")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x06011965 RID: 72037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011965")]
		[Address(RVA = "0x967430", Offset = "0x966030", VA = "0x180967430")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x06011966 RID: 72038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011966")]
		[Address(RVA = "0x9670F0", Offset = "0x965CF0", VA = "0x1809670F0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011967 RID: 72039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011967")]
		[Address(RVA = "0x966C10", Offset = "0x965810", VA = "0x180966C10", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011968 RID: 72040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011968")]
		[Address(RVA = "0x967AD0", Offset = "0x9666D0", VA = "0x180967AD0")]
		private void _InitCollisionHandler()
		{
		}

		// Token: 0x06011969 RID: 72041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011969")]
		[Address(RVA = "0x967980", Offset = "0x966580", VA = "0x180967980")]
		private void _EnableColliders(bool enabled)
		{
		}

		// Token: 0x0601196A RID: 72042 RVA: 0x0006C228 File Offset: 0x0006A428
		[Token(Token = "0x601196A")]
		[Address(RVA = "0x967B70", Offset = "0x966770", VA = "0x180967B70")]
		private bool _VerifyTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0601196B RID: 72043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601196B")]
		[Address(RVA = "0x967C70", Offset = "0x966870", VA = "0x180967C70")]
		public AuraHitBehaviour()
		{
		}

		// Token: 0x0601196C RID: 72044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601196C")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0601196D RID: 72045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601196D")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x04013A89 RID: 80521
		[Token(Token = "0x4013A89")]
		private const int TRIGGER_TICK = 10;

		// Token: 0x04013A8A RID: 80522
		[Token(Token = "0x4013A8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x04013A8B RID: 80523
		[Token(Token = "0x4013A8B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("We use |Range| only to initialize the colliders.")]
		private Range _rangeToLoad;

		// Token: 0x04013A8C RID: 80524
		[Token(Token = "0x4013A8C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TargetValidator _targetValidator;

		// Token: 0x04013A8D RID: 80525
		[Token(Token = "0x4013A8D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _onlyCheckHitWhenReachTarget;

		// Token: 0x04013A8E RID: 80526
		[Token(Token = "0x4013A8E")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _hitTargetNoDamage;

		// Token: 0x04013A8F RID: 80527
		[Token(Token = "0x4013A8F")]
		[FieldOffset(Offset = "0x9C")]
		private int m_layerMask;

		// Token: 0x04013A90 RID: 80528
		[Token(Token = "0x4013A90")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_collisionHandlerInited;

		// Token: 0x04013A91 RID: 80529
		[Token(Token = "0x4013A91")]
		[FieldOffset(Offset = "0xA8")]
		private List<Collider2D> m_colliders;

		// Token: 0x04013A92 RID: 80530
		[Token(Token = "0x4013A92")]
		[FieldOffset(Offset = "0xB0")]
		private AuraAbility.TargetEnterExitHandler m_eeHandler;

		// Token: 0x04013A94 RID: 80532
		[Token(Token = "0x4013A94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_validTargets;

		// Token: 0x04013A95 RID: 80533
		[Token(Token = "0x4013A95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_rangeToLoad;

		// Token: 0x04013A96 RID: 80534
		[Token(Token = "0x4013A96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onlyCheckHitWhenReachTarget;

		// Token: 0x04013A97 RID: 80535
		[Token(Token = "0x4013A97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_eeHandler;

		// Token: 0x04013A98 RID: 80536
		[Token(Token = "0x4013A98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoTargetEnter;

		// Token: 0x04013A99 RID: 80537
		[Token(Token = "0x4013A99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoTargetExit;

		// Token: 0x04013A9A RID: 80538
		[Token(Token = "0x4013A9A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04013A9B RID: 80539
		[Token(Token = "0x4013A9B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTriggerExit2D;

		// Token: 0x04013A9C RID: 80540
		[Token(Token = "0x4013A9C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013A9D RID: 80541
		[Token(Token = "0x4013A9D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013A9E RID: 80542
		[Token(Token = "0x4013A9E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitCollisionHandler;

		// Token: 0x04013A9F RID: 80543
		[Token(Token = "0x4013A9F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnableColliders;

		// Token: 0x04013AA0 RID: 80544
		[Token(Token = "0x4013AA0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__VerifyTarget;

		// Token: 0x04013AA1 RID: 80545
		[Token(Token = "0x4013AA1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
