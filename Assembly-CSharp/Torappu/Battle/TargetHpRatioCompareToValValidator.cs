using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258F RID: 9615
	[Token(Token = "0x200258F")]
	public class TargetHpRatioCompareToValValidator : TargetValidator
	{
		// Token: 0x0600F7E3 RID: 63459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E3")]
		[Address(RVA = "0x7156A0", Offset = "0x7142A0", VA = "0x1807156A0", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		[Token(Token = "0x600F7E4")]
		[Address(RVA = "0x7157B0", Offset = "0x7143B0", VA = "0x1807157B0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E5")]
		[Address(RVA = "0x7158D0", Offset = "0x7144D0", VA = "0x1807158D0")]
		public TargetHpRatioCompareToValValidator()
		{
		}

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E6")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		[Token(Token = "0x600F7E7")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401137B RID: 70523
		[Token(Token = "0x401137B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _defaultValue;

		// Token: 0x0401137C RID: 70524
		[Token(Token = "0x401137C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _hpRatioKey;

		// Token: 0x0401137D RID: 70525
		[Token(Token = "0x401137D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CompareType _type;

		// Token: 0x0401137E RID: 70526
		[Token(Token = "0x401137E")]
		[FieldOffset(Offset = "0xA8")]
		private FP m_hpRatio;

		// Token: 0x0401137F RID: 70527
		[Token(Token = "0x401137F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011380 RID: 70528
		[Token(Token = "0x4011380")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011381 RID: 70529
		[Token(Token = "0x4011381")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
