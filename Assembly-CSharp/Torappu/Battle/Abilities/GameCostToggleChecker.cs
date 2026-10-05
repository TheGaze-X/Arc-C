using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5D RID: 11101
	[Token(Token = "0x2002B5D")]
	public class GameCostToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A30 RID: 76336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A30")]
		[Address(RVA = "0xAA1170", Offset = "0xA9FD70", VA = "0x180AA1170", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A31")]
		[Address(RVA = "0xAA1230", Offset = "0xA9FE30", VA = "0x180AA1230", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x000722B8 File Offset: 0x000704B8
		[Token(Token = "0x6012A32")]
		[Address(RVA = "0xAA1110", Offset = "0xA9FD10", VA = "0x180AA1110", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A33 RID: 76339 RVA: 0x000722D0 File Offset: 0x000704D0
		[Token(Token = "0x6012A33")]
		[Address(RVA = "0xAA12B0", Offset = "0xA9FEB0", VA = "0x180AA12B0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A34 RID: 76340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A34")]
		[Address(RVA = "0xAA1400", Offset = "0xAA0000", VA = "0x180AA1400")]
		public GameCostToggleChecker()
		{
		}

		// Token: 0x06012A35 RID: 76341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A35")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015100 RID: 86272
		[Token(Token = "0x4015100")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _minCost;

		// Token: 0x04015101 RID: 86273
		[Token(Token = "0x4015101")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxCost;

		// Token: 0x04015102 RID: 86274
		[Token(Token = "0x4015102")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _toggleIfMaxGameCost;

		// Token: 0x04015103 RID: 86275
		[Token(Token = "0x4015103")]
		[FieldOffset(Offset = "0x2C")]
		private int m_minCost;

		// Token: 0x04015104 RID: 86276
		[Token(Token = "0x4015104")]
		[FieldOffset(Offset = "0x30")]
		private int m_maxCost;

		// Token: 0x04015105 RID: 86277
		[Token(Token = "0x4015105")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015106 RID: 86278
		[Token(Token = "0x4015106")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015107 RID: 86279
		[Token(Token = "0x4015107")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015108 RID: 86280
		[Token(Token = "0x4015108")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015109 RID: 86281
		[Token(Token = "0x4015109")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
