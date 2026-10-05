using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ABC RID: 10940
	[Token(Token = "0x2002ABC")]
	public class NoTargetRangedAttack : MultiRangedAttack
	{
		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06012367 RID: 74599 RVA: 0x0006F9D8 File Offset: 0x0006DBD8
		[Token(Token = "0x170027F2")]
		public bool isSectorProjectileMovement
		{
			[Token(Token = "0x6012367")]
			[Address(RVA = "0xA46280", Offset = "0xA44E80", VA = "0x180A46280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012368 RID: 74600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012368")]
		[Address(RVA = "0xA45CD0", Offset = "0xA448D0", VA = "0x180A45CD0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012369 RID: 74601 RVA: 0x0006F9F0 File Offset: 0x0006DBF0
		[Token(Token = "0x6012369")]
		[Address(RVA = "0xA45500", Offset = "0xA44100", VA = "0x180A45500", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0601236A RID: 74602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601236A")]
		[Address(RVA = "0xA461A0", Offset = "0xA44DA0", VA = "0x180A461A0")]
		public NoTargetRangedAttack()
		{
		}

		// Token: 0x0601236C RID: 74604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601236C")]
		[Address(RVA = "0xA3E9A0", Offset = "0xA3D5A0", VA = "0x180A3E9A0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601236D RID: 74605 RVA: 0x0006FA08 File Offset: 0x0006DC08
		[Token(Token = "0x601236D")]
		[Address(RVA = "0xA3CED0", Offset = "0xA3BAD0", VA = "0x180A3CED0")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x0401498A RID: 84362
		[Token(Token = "0x401498A")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		[Group("ProjectileMovement")]
		private bool _loadFromBlackboard;

		// Token: 0x0401498B RID: 84363
		[Token(Token = "0x401498B")]
		[FieldOffset(Offset = "0x2D9")]
		[SerializeField]
		[Group("ProjectileMovement")]
		private bool _isSectorProjectileMovement;

		// Token: 0x0401498C RID: 84364
		[Token(Token = "0x401498C")]
		[FieldOffset(Offset = "0x2DC")]
		[Inspect("isSectorProjectileMovement")]
		[SerializeField]
		[Group("ProjectileMovement")]
		private float _startRotateAngleZ;

		// Token: 0x0401498D RID: 84365
		[Token(Token = "0x401498D")]
		[FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		[Group("ProjectileMovement")]
		[Inspect("isSectorProjectileMovement")]
		private float _endRotateAngleZ;

		// Token: 0x0401498E RID: 84366
		[Token(Token = "0x401498E")]
		[FieldOffset(Offset = "0x2E4")]
		[SerializeField]
		[Group("ProjectileMovement")]
		[Inspect("isSectorProjectileMovement")]
		private int _projectileNum;

		// Token: 0x0401498F RID: 84367
		[Token(Token = "0x401498F")]
		[FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		[Group("ProjectileMovement")]
		[Inspect("isSectorProjectileMovement")]
		private SharedConsts.Direction _mainDirction;

		// Token: 0x04014990 RID: 84368
		[Token(Token = "0x4014990")]
		[FieldOffset(Offset = "0x2EC")]
		[SerializeField]
		[Group("ProjectileMovement")]
		[Inspect("isSectorProjectileMovement", false)]
		private float _perOffset;

		// Token: 0x04014991 RID: 84369
		[Token(Token = "0x4014991")]
		[FieldOffset(Offset = "0x0")]
		public static float UP;

		// Token: 0x04014992 RID: 84370
		[Token(Token = "0x4014992")]
		[FieldOffset(Offset = "0x4")]
		public static float RIGHT;

		// Token: 0x04014993 RID: 84371
		[Token(Token = "0x4014993")]
		[FieldOffset(Offset = "0x8")]
		public static float DOWN;

		// Token: 0x04014994 RID: 84372
		[Token(Token = "0x4014994")]
		[FieldOffset(Offset = "0xC")]
		public static float LEFT;

		// Token: 0x04014995 RID: 84373
		[Token(Token = "0x4014995")]
		[FieldOffset(Offset = "0x10")]
		public static float[] DirectionAngle;

		// Token: 0x04014996 RID: 84374
		[Token(Token = "0x4014996")]
		[FieldOffset(Offset = "0x2F0")]
		private List<Vector3> m_sectorProjectileRotateDirections;

		// Token: 0x04014997 RID: 84375
		[Token(Token = "0x4014997")]
		[FieldOffset(Offset = "0x2F8")]
		private float _startOffset;

		// Token: 0x04014998 RID: 84376
		[Token(Token = "0x4014998")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isSectorProjectileMovement;

		// Token: 0x04014999 RID: 84377
		[Token(Token = "0x4014999")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401499A RID: 84378
		[Token(Token = "0x401499A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x0401499B RID: 84379
		[Token(Token = "0x401499B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
