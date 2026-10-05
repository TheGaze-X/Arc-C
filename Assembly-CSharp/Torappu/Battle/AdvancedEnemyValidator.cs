using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002579 RID: 9593
	[Token(Token = "0x2002579")]
	public class AdvancedEnemyValidator : TargetValidator
	{
		// Token: 0x0600F798 RID: 63384 RVA: 0x0005C8E0 File Offset: 0x0005AAE0
		[Token(Token = "0x600F798")]
		[Address(RVA = "0x6EF3D0", Offset = "0x6EDFD0", VA = "0x1806EF3D0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F799")]
		[Address(RVA = "0x6EF650", Offset = "0x6EE250", VA = "0x1806EF650")]
		public AdvancedEnemyValidator()
		{
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		[Token(Token = "0x600F79A")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401131B RID: 70427
		[Token(Token = "0x401131B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private EnemyLevelMask _enemyLevelMask;

		// Token: 0x0401131C RID: 70428
		[Token(Token = "0x401131C")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private MotionMask _motionMask;

		// Token: 0x0401131D RID: 70429
		[Token(Token = "0x401131D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _allowNoneApplyWay;

		// Token: 0x0401131E RID: 70430
		[Token(Token = "0x401131E")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private SourceApplyWay _applyWay;

		// Token: 0x0401131F RID: 70431
		[Token(Token = "0x401131F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _checkIsBlockedByOwner;

		// Token: 0x04011320 RID: 70432
		[Token(Token = "0x4011320")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011321 RID: 70433
		[Token(Token = "0x4011321")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
