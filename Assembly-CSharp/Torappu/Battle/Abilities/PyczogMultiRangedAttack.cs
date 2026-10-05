using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ABD RID: 10941
	[Token(Token = "0x2002ABD")]
	public class PyczogMultiRangedAttack : MultiRangedAttack
	{
		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0601236E RID: 74606 RVA: 0x0006FA20 File Offset: 0x0006DC20
		[Token(Token = "0x170027F3")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x601236E")]
			[Address(RVA = "0xA471A0", Offset = "0xA45DA0", VA = "0x180A471A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601236F RID: 74607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601236F")]
		[Address(RVA = "0xA464E0", Offset = "0xA450E0", VA = "0x180A464E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012370 RID: 74608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012370")]
		[Address(RVA = "0xA46300", Offset = "0xA44F00", VA = "0x180A46300", Slot = "101")]
		protected override void DealWithFaceDirection()
		{
		}

		// Token: 0x06012371 RID: 74609 RVA: 0x0006FA38 File Offset: 0x0006DC38
		[Token(Token = "0x6012371")]
		[Address(RVA = "0xA46430", Offset = "0xA45030", VA = "0x180A46430", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012372 RID: 74610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012372")]
		[Address(RVA = "0xA46CD0", Offset = "0xA458D0", VA = "0x180A46CD0")]
		private void _UpdateTargetDirection()
		{
		}

		// Token: 0x06012373 RID: 74611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012373")]
		[Address(RVA = "0xA46710", Offset = "0xA45310", VA = "0x180A46710")]
		private void _EmitRemainingProjectiles()
		{
		}

		// Token: 0x06012374 RID: 74612 RVA: 0x0006FA50 File Offset: 0x0006DC50
		[Token(Token = "0x6012374")]
		[Address(RVA = "0xA46A20", Offset = "0xA45620", VA = "0x180A46A20")]
		private bool _RotateProjectile(int projectileIndex, int rotateIndex)
		{
			return default(bool);
		}

		// Token: 0x06012375 RID: 74613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012375")]
		[Address(RVA = "0xA470D0", Offset = "0xA45CD0", VA = "0x180A470D0")]
		public PyczogMultiRangedAttack()
		{
		}

		// Token: 0x06012377 RID: 74615 RVA: 0x0006FA68 File Offset: 0x0006DC68
		[Token(Token = "0x6012377")]
		[Address(RVA = "0xA3CEF0", Offset = "0xA3BAF0", VA = "0x180A3CEF0")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012378 RID: 74616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012378")]
		[Address(RVA = "0xA3E9A0", Offset = "0xA3D5A0", VA = "0x180A3E9A0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012379 RID: 74617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012379")]
		[Address(RVA = "0xA46700", Offset = "0xA45300", VA = "0x180A46700")]
		private void <>xLuaBaseProxy_DealWithFaceDirection()
		{
		}

		// Token: 0x0601237A RID: 74618 RVA: 0x0006FA80 File Offset: 0x0006DC80
		[Token(Token = "0x601237A")]
		[Address(RVA = "0xA3CED0", Offset = "0xA3BAD0", VA = "0x180A3CED0")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x0401499C RID: 84380
		[Token(Token = "0x401499C")]
		[FieldOffset(Offset = "0x2D8")]
		private int m_maxProjectileCount;

		// Token: 0x0401499D RID: 84381
		[Token(Token = "0x401499D")]
		[FieldOffset(Offset = "0x2DC")]
		private int m_emittedProjectileCount;

		// Token: 0x0401499E RID: 84382
		[Token(Token = "0x401499E")]
		[FieldOffset(Offset = "0x2E0")]
		private List<float> m_projectileRotates;

		// Token: 0x0401499F RID: 84383
		[Token(Token = "0x401499F")]
		[FieldOffset(Offset = "0x2E8")]
		private SharedConsts.Direction m_targetDirection;

		// Token: 0x040149A0 RID: 84384
		[Token(Token = "0x40149A0")]
		[FieldOffset(Offset = "0x0")]
		public static float UP;

		// Token: 0x040149A1 RID: 84385
		[Token(Token = "0x40149A1")]
		[FieldOffset(Offset = "0x4")]
		public static float RIGHT;

		// Token: 0x040149A2 RID: 84386
		[Token(Token = "0x40149A2")]
		[FieldOffset(Offset = "0x8")]
		public static float DOWN;

		// Token: 0x040149A3 RID: 84387
		[Token(Token = "0x40149A3")]
		[FieldOffset(Offset = "0xC")]
		public static float LEFT;

		// Token: 0x040149A4 RID: 84388
		[Token(Token = "0x40149A4")]
		[FieldOffset(Offset = "0x10")]
		public static float[] DirectionAngle;

		// Token: 0x040149A5 RID: 84389
		[Token(Token = "0x40149A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x040149A6 RID: 84390
		[Token(Token = "0x40149A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040149A7 RID: 84391
		[Token(Token = "0x40149A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealWithFaceDirection;

		// Token: 0x040149A8 RID: 84392
		[Token(Token = "0x40149A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040149A9 RID: 84393
		[Token(Token = "0x40149A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateTargetDirection;

		// Token: 0x040149AA RID: 84394
		[Token(Token = "0x40149AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EmitRemainingProjectiles;

		// Token: 0x040149AB RID: 84395
		[Token(Token = "0x40149AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RotateProjectile;

		// Token: 0x040149AC RID: 84396
		[Token(Token = "0x40149AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
