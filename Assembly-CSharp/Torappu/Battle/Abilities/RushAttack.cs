using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ACC RID: 10956
	[Token(Token = "0x2002ACC")]
	public class RushAttack : AbstractAnimatedAbility
	{
		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x060123FA RID: 74746 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		[Token(Token = "0x17002803")]
		private Vector2 faceDir
		{
			[Token(Token = "0x60123FA")]
			[Address(RVA = "0xA5CDA0", Offset = "0xA5B9A0", VA = "0x180A5CDA0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060123FB RID: 74747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123FB")]
		[Address(RVA = "0xA5C280", Offset = "0xA5AE80", VA = "0x180A5C280", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060123FC RID: 74748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123FC")]
		[Address(RVA = "0xA5C3E0", Offset = "0xA5AFE0", VA = "0x180A5C3E0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060123FD RID: 74749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123FD")]
		[Address(RVA = "0xA5C550", Offset = "0xA5B150", VA = "0x180A5C550", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060123FE RID: 74750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123FE")]
		[Address(RVA = "0xA5C370", Offset = "0xA5AF70", VA = "0x180A5C370", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060123FF RID: 74751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123FF")]
		[Address(RVA = "0xA5C470", Offset = "0xA5B070", VA = "0x180A5C470", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012400 RID: 74752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012400")]
		[Address(RVA = "0xA5C650", Offset = "0xA5B250", VA = "0x180A5C650", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012401 RID: 74753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012401")]
		[Address(RVA = "0xA5C700", Offset = "0xA5B300", VA = "0x180A5C700")]
		public void SetRush(Vector2 targetPos, Entity target)
		{
		}

		// Token: 0x06012402 RID: 74754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012402")]
		[Address(RVA = "0xA5CA40", Offset = "0xA5B640", VA = "0x180A5CA40")]
		private void _moveByTarget(float deltaTime)
		{
		}

		// Token: 0x06012403 RID: 74755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012403")]
		[Address(RVA = "0xA5C9D0", Offset = "0xA5B5D0", VA = "0x180A5C9D0")]
		public RushAttack()
		{
		}

		// Token: 0x06012404 RID: 74756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012404")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012405 RID: 74757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012405")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012406 RID: 74758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012406")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012407 RID: 74759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012407")]
		[Address(RVA = "0xA4B060", Offset = "0xA49C60", VA = "0x180A4B060")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x04014A3C RID: 84540
		[Token(Token = "0x4014A3C")]
		[FieldOffset(Offset = "0x1C8")]
		private Enemy m_enemy;

		// Token: 0x04014A3D RID: 84541
		[Token(Token = "0x4014A3D")]
		[FieldOffset(Offset = "0x1D0")]
		private float m_speed;

		// Token: 0x04014A3E RID: 84542
		[Token(Token = "0x4014A3E")]
		[FieldOffset(Offset = "0x1D4")]
		private bool m_isRushing;

		// Token: 0x04014A3F RID: 84543
		[Token(Token = "0x4014A3F")]
		[FieldOffset(Offset = "0x1D8")]
		private Vector2 m_targetMapPos;

		// Token: 0x04014A40 RID: 84544
		[Token(Token = "0x4014A40")]
		[FieldOffset(Offset = "0x1E0")]
		private Vector2 m_oriMapPos;

		// Token: 0x04014A41 RID: 84545
		[Token(Token = "0x4014A41")]
		[FieldOffset(Offset = "0x1E8")]
		private Entity m_target;

		// Token: 0x04014A42 RID: 84546
		[Token(Token = "0x4014A42")]
		[FieldOffset(Offset = "0x1F0")]
		private Vector2 m_direction;

		// Token: 0x04014A43 RID: 84547
		[Token(Token = "0x4014A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_faceDir;

		// Token: 0x04014A44 RID: 84548
		[Token(Token = "0x4014A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A45 RID: 84549
		[Token(Token = "0x4014A45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014A46 RID: 84550
		[Token(Token = "0x4014A46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014A47 RID: 84551
		[Token(Token = "0x4014A47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014A48 RID: 84552
		[Token(Token = "0x4014A48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014A49 RID: 84553
		[Token(Token = "0x4014A49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014A4A RID: 84554
		[Token(Token = "0x4014A4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetRush;

		// Token: 0x04014A4B RID: 84555
		[Token(Token = "0x4014A4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__moveByTarget;

		// Token: 0x04014A4C RID: 84556
		[Token(Token = "0x4014A4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
