using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B4E RID: 11086
	[Token(Token = "0x2002B4E")]
	public class Act27SideChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x060129C1 RID: 76225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129C1")]
		[Address(RVA = "0xA966A0", Offset = "0xA952A0", VA = "0x180A966A0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129C2 RID: 76226 RVA: 0x00071F28 File Offset: 0x00070128
		[Token(Token = "0x60129C2")]
		[Address(RVA = "0xA96640", Offset = "0xA95240", VA = "0x180A96640", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129C3 RID: 76227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129C3")]
		[Address(RVA = "0xA96790", Offset = "0xA95390", VA = "0x180A96790", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060129C4 RID: 76228 RVA: 0x00071F40 File Offset: 0x00070140
		[Token(Token = "0x60129C4")]
		[Address(RVA = "0xA968B0", Offset = "0xA954B0", VA = "0x180A968B0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x060129C5 RID: 76229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129C5")]
		[Address(RVA = "0xA96980", Offset = "0xA95580", VA = "0x180A96980")]
		public Act27SideChecker()
		{
		}

		// Token: 0x060129C6 RID: 76230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129C6")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015053 RID: 86099
		[Token(Token = "0x4015053")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act27SideBattleManager.MechanismSideType _targetSideType;

		// Token: 0x04015054 RID: 86100
		[Token(Token = "0x4015054")]
		[FieldOffset(Offset = "0x28")]
		private Act27SideBattleManager m_manager;

		// Token: 0x04015055 RID: 86101
		[Token(Token = "0x4015055")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015056 RID: 86102
		[Token(Token = "0x4015056")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015057 RID: 86103
		[Token(Token = "0x4015057")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015058 RID: 86104
		[Token(Token = "0x4015058")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015059 RID: 86105
		[Token(Token = "0x4015059")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
