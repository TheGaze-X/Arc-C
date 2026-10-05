using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200244D RID: 9293
	[Token(Token = "0x200244D")]
	public class FeverCommonBehaviour : FeverBehaviour
	{
		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600EE5E RID: 61022 RVA: 0x00057720 File Offset: 0x00055920
		[Token(Token = "0x17001EE8")]
		private FP feverTime
		{
			[Token(Token = "0x600EE5E")]
			[Address(RVA = "0x64AEB0", Offset = "0x649AB0", VA = "0x18064AEB0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x00057738 File Offset: 0x00055938
		[Token(Token = "0x17001EE9")]
		protected override bool isDirectlyJoinFeverTypeSkill
		{
			[Token(Token = "0x600EE5F")]
			[Address(RVA = "0x64AFB0", Offset = "0x649BB0", VA = "0x18064AFB0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE60 RID: 61024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE60")]
		[Address(RVA = "0x649620", Offset = "0x648220", VA = "0x180649620", Slot = "5")]
		public override void AssignData(Blackboard blackboard)
		{
		}

		// Token: 0x0600EE61 RID: 61025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE61")]
		[Address(RVA = "0x64A9B0", Offset = "0x6495B0", VA = "0x18064A9B0")]
		private void _Reset()
		{
		}

		// Token: 0x0600EE62 RID: 61026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE62")]
		[Address(RVA = "0x64A270", Offset = "0x648E70", VA = "0x18064A270", Slot = "6")]
		public override void OnCastSucceed()
		{
		}

		// Token: 0x0600EE63 RID: 61027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE63")]
		[Address(RVA = "0x64A440", Offset = "0x649040", VA = "0x18064A440", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x0600EE64 RID: 61028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE64")]
		[Address(RVA = "0x64A5D0", Offset = "0x6491D0", VA = "0x18064A5D0", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EE65 RID: 61029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE65")]
		[Address(RVA = "0x649EB0", Offset = "0x648AB0", VA = "0x180649EB0", Slot = "25")]
		protected override void OnBeforeJoinFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE66 RID: 61030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE66")]
		[Address(RVA = "0x64A380", Offset = "0x648F80", VA = "0x18064A380", Slot = "26")]
		protected override void OnJoinFeverFail(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE67 RID: 61031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE67")]
		[Address(RVA = "0x64A6F0", Offset = "0x6492F0", VA = "0x18064A6F0")]
		private void _RecoverSpCost()
		{
		}

		// Token: 0x0600EE68 RID: 61032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE68")]
		[Address(RVA = "0x64AA70", Offset = "0x649670", VA = "0x18064AA70")]
		private void _RevertRecoverSpCost()
		{
		}

		// Token: 0x0600EE69 RID: 61033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE69")]
		[Address(RVA = "0x6497C0", Offset = "0x6483C0", VA = "0x1806497C0", Slot = "27")]
		protected override void OnAfterJoinFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE6A RID: 61034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE6A")]
		[Address(RVA = "0x649F90", Offset = "0x648B90", VA = "0x180649F90", Slot = "28")]
		protected override void OnBeforeLeaveFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE6B RID: 61035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE6B")]
		[Address(RVA = "0x649C10", Offset = "0x648810", VA = "0x180649C10", Slot = "29")]
		protected override void OnAfterLeaveFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE6C RID: 61036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE6C")]
		[Address(RVA = "0x64ACF0", Offset = "0x6498F0", VA = "0x18064ACF0")]
		public FeverCommonBehaviour()
		{
		}

		// Token: 0x0600EE6D RID: 61037 RVA: 0x00057750 File Offset: 0x00055950
		[Token(Token = "0x600EE6D")]
		[Address(RVA = "0x6493C0", Offset = "0x647FC0", VA = "0x1806493C0")]
		private bool <>xLuaBaseProxy_get_isDirectlyJoinFeverTypeSkill()
		{
			return default(bool);
		}

		// Token: 0x0600EE6E RID: 61038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE6E")]
		[Address(RVA = "0x64A6B0", Offset = "0x6492B0", VA = "0x18064A6B0")]
		private void <>xLuaBaseProxy_AssignData(Blackboard P0)
		{
		}

		// Token: 0x0600EE6F RID: 61039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE6F")]
		[Address(RVA = "0x64A6C0", Offset = "0x6492C0", VA = "0x18064A6C0")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x0600EE70 RID: 61040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE70")]
		[Address(RVA = "0x64A6D0", Offset = "0x6492D0", VA = "0x18064A6D0")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0600EE71 RID: 61041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE71")]
		[Address(RVA = "0x64A6E0", Offset = "0x6492E0", VA = "0x18064A6E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EE72 RID: 61042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE72")]
		[Address(RVA = "0x647C10", Offset = "0x646810", VA = "0x180647C10")]
		private void <>xLuaBaseProxy_OnBeforeJoinFever(bool P0)
		{
		}

		// Token: 0x0600EE73 RID: 61043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE73")]
		[Address(RVA = "0x648070", Offset = "0x646C70", VA = "0x180648070")]
		private void <>xLuaBaseProxy_OnJoinFeverFail(bool P0)
		{
		}

		// Token: 0x0600EE74 RID: 61044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE74")]
		[Address(RVA = "0x647B50", Offset = "0x646750", VA = "0x180647B50")]
		private void <>xLuaBaseProxy_OnAfterJoinFever(bool P0)
		{
		}

		// Token: 0x0600EE75 RID: 61045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE75")]
		[Address(RVA = "0x647C70", Offset = "0x646870", VA = "0x180647C70")]
		private void <>xLuaBaseProxy_OnBeforeLeaveFever(bool P0)
		{
		}

		// Token: 0x0600EE76 RID: 61046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE76")]
		[Address(RVA = "0x647BB0", Offset = "0x6467B0", VA = "0x180647BB0")]
		private void <>xLuaBaseProxy_OnAfterLeaveFever(bool P0)
		{
		}

		// Token: 0x040107AD RID: 67501
		[Token(Token = "0x40107AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x040107AE RID: 67502
		[Token(Token = "0x40107AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuffData[] _buffAfterFever;

		// Token: 0x040107AF RID: 67503
		[Token(Token = "0x40107AF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _updateAbilityCooldown;

		// Token: 0x040107B0 RID: 67504
		[Token(Token = "0x40107B0")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _tryJoinFeverOnSkillStart;

		// Token: 0x040107B1 RID: 67505
		[Token(Token = "0x40107B1")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		private bool _continusCastWhenInFever;

		// Token: 0x040107B2 RID: 67506
		[Token(Token = "0x40107B2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TargetValidator _validator;

		// Token: 0x040107B3 RID: 67507
		[Token(Token = "0x40107B3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _updateCoolDownIfInterrupt;

		// Token: 0x040107B4 RID: 67508
		[Token(Token = "0x40107B4")]
		[FieldOffset(Offset = "0x78")]
		private FP m_spBeforeFever;

		// Token: 0x040107B5 RID: 67509
		[Token(Token = "0x40107B5")]
		[FieldOffset(Offset = "0x80")]
		private List<ObjectPtr<Buff>> m_buffs;

		// Token: 0x040107B6 RID: 67510
		[Token(Token = "0x40107B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_feverTime;

		// Token: 0x040107B7 RID: 67511
		[Token(Token = "0x40107B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isDirectlyJoinFeverTypeSkill;

		// Token: 0x040107B8 RID: 67512
		[Token(Token = "0x40107B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040107B9 RID: 67513
		[Token(Token = "0x40107B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x040107BA RID: 67514
		[Token(Token = "0x40107BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x040107BB RID: 67515
		[Token(Token = "0x40107BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x040107BC RID: 67516
		[Token(Token = "0x40107BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040107BD RID: 67517
		[Token(Token = "0x40107BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBeforeJoinFever;

		// Token: 0x040107BE RID: 67518
		[Token(Token = "0x40107BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnJoinFeverFail;

		// Token: 0x040107BF RID: 67519
		[Token(Token = "0x40107BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RecoverSpCost;

		// Token: 0x040107C0 RID: 67520
		[Token(Token = "0x40107C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RevertRecoverSpCost;

		// Token: 0x040107C1 RID: 67521
		[Token(Token = "0x40107C1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnAfterJoinFever;

		// Token: 0x040107C2 RID: 67522
		[Token(Token = "0x40107C2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBeforeLeaveFever;

		// Token: 0x040107C3 RID: 67523
		[Token(Token = "0x40107C3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnAfterLeaveFever;

		// Token: 0x040107C4 RID: 67524
		[Token(Token = "0x40107C4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
