using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258B RID: 9611
	[Token(Token = "0x200258B")]
	public class ProjectileValidator : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600F7D5 RID: 63445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D5")]
		[Address(RVA = "0x7132F0", Offset = "0x711EF0", VA = "0x1807132F0", Slot = "4")]
		public virtual void SetData(Entity owner, Blackboard blackboard)
		{
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x0005CC28 File Offset: 0x0005AE28
		[Token(Token = "0x600F7D6")]
		[Address(RVA = "0x713390", Offset = "0x711F90", VA = "0x180713390")]
		public bool VerifyTarget(Entity owner, Projectile target)
		{
			return default(bool);
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D7")]
		[Address(RVA = "0x713560", Offset = "0x712160", VA = "0x180713560")]
		public ProjectileValidator()
		{
		}

		// Token: 0x04011365 RID: 70501
		[Token(Token = "0x4011365")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04011366 RID: 70502
		[Token(Token = "0x4011366")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _verifyProjectileType;

		// Token: 0x04011367 RID: 70503
		[Token(Token = "0x4011367")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Projectile.ProjectileType _projectileType;

		// Token: 0x04011368 RID: 70504
		[Token(Token = "0x4011368")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _graphicExclude;

		// Token: 0x04011369 RID: 70505
		[Token(Token = "0x4011369")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _projectileKeys;

		// Token: 0x0401136A RID: 70506
		[Token(Token = "0x401136A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _onlySourceIsMe;

		// Token: 0x0401136B RID: 70507
		[Token(Token = "0x401136B")]
		[FieldOffset(Offset = "0x34")]
		private SideType m_targetSideMask;

		// Token: 0x0401136C RID: 70508
		[Token(Token = "0x401136C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401136D RID: 70509
		[Token(Token = "0x401136D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x0401136E RID: 70510
		[Token(Token = "0x401136E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
