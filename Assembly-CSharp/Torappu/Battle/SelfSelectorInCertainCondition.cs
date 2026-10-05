using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200252A RID: 9514
	[Token(Token = "0x200252A")]
	public class SelfSelectorInCertainCondition : SelfSelector
	{
		// Token: 0x0600F58A RID: 62858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F58A")]
		[Address(RVA = "0x6DA9D0", Offset = "0x6D95D0", VA = "0x1806DA9D0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F58B RID: 62859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F58B")]
		[Address(RVA = "0x6DAAF0", Offset = "0x6D96F0", VA = "0x1806DAAF0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F58C RID: 62860 RVA: 0x0005B3F8 File Offset: 0x000595F8
		[Token(Token = "0x600F58C")]
		[Address(RVA = "0x6DAD20", Offset = "0x6D9920", VA = "0x1806DAD20")]
		private bool _CheckSelfMeetCertainConditions()
		{
			return default(bool);
		}

		// Token: 0x0600F58D RID: 62861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F58D")]
		[Address(RVA = "0x6DB060", Offset = "0x6D9C60", VA = "0x1806DB060")]
		public SelfSelectorInCertainCondition()
		{
		}

		// Token: 0x0600F58E RID: 62862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F58E")]
		[Address(RVA = "0x6DAC00", Offset = "0x6D9800", VA = "0x1806DAC00")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F58F RID: 62863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F58F")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x04011037 RID: 69687
		[Token(Token = "0x4011037")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _checkHpRatioCondition;

		// Token: 0x04011038 RID: 69688
		[Token(Token = "0x4011038")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxRatio;

		// Token: 0x04011039 RID: 69689
		[Token(Token = "0x4011039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _checkNotContainBuffs;

		// Token: 0x0401103A RID: 69690
		[Token(Token = "0x401103A")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _checkContainBuffs;

		// Token: 0x0401103B RID: 69691
		[Token(Token = "0x401103B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _buffKeys;

		// Token: 0x0401103C RID: 69692
		[Token(Token = "0x401103C")]
		[FieldOffset(Offset = "0x48")]
		private FP m_maxRatio;

		// Token: 0x0401103D RID: 69693
		[Token(Token = "0x401103D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x0401103E RID: 69694
		[Token(Token = "0x401103E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401103F RID: 69695
		[Token(Token = "0x401103F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckSelfMeetCertainConditions;

		// Token: 0x04011040 RID: 69696
		[Token(Token = "0x4011040")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
