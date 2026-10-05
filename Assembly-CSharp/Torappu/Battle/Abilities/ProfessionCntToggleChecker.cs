using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B62 RID: 11106
	[Token(Token = "0x2002B62")]
	public class ProfessionCntToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A4E RID: 76366 RVA: 0x000723D8 File Offset: 0x000705D8
		[Token(Token = "0x6012A4E")]
		[Address(RVA = "0xAA2C80", Offset = "0xAA1880", VA = "0x180AA2C80", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A4F RID: 76367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A4F")]
		[Address(RVA = "0xAA2CE0", Offset = "0xAA18E0", VA = "0x180AA2CE0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A50")]
		[Address(RVA = "0xAA2D90", Offset = "0xAA1990", VA = "0x180AA2D90", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x06012A51 RID: 76369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A51")]
		[Address(RVA = "0xAA2FB0", Offset = "0xAA1BB0", VA = "0x180AA2FB0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x000723F0 File Offset: 0x000705F0
		[Token(Token = "0x6012A52")]
		[Address(RVA = "0xAA31D0", Offset = "0xAA1DD0", VA = "0x180AA31D0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A53 RID: 76371 RVA: 0x00072408 File Offset: 0x00070608
		[Token(Token = "0x6012A53")]
		[Address(RVA = "0xAA38A0", Offset = "0xAA24A0", VA = "0x180AA38A0")]
		private int _CheckProfessionCount()
		{
			return 0;
		}

		// Token: 0x06012A54 RID: 76372 RVA: 0x00072420 File Offset: 0x00070620
		[Token(Token = "0x6012A54")]
		[Address(RVA = "0xAA3500", Offset = "0xAA2100", VA = "0x180AA3500")]
		private int _CheckMaxSameProfessionCount()
		{
			return 0;
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x00072438 File Offset: 0x00070638
		[Token(Token = "0x6012A55")]
		[Address(RVA = "0xAA3260", Offset = "0xAA1E60", VA = "0x180AA3260")]
		private int _CheckMaxDifferentProfessionCount()
		{
			return 0;
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A56")]
		[Address(RVA = "0xAA3B90", Offset = "0xAA2790", VA = "0x180AA3B90")]
		private void _OnCharacterChanged(object arg)
		{
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x00072450 File Offset: 0x00070650
		[Token(Token = "0x6012A57")]
		[Address(RVA = "0xAA3A50", Offset = "0xAA2650", VA = "0x180AA3A50")]
		private bool _CheckProfession(Unit target)
		{
			return default(bool);
		}

		// Token: 0x06012A58 RID: 76376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A58")]
		[Address(RVA = "0xAA3D10", Offset = "0xAA2910", VA = "0x180AA3D10")]
		public ProfessionCntToggleChecker()
		{
		}

		// Token: 0x06012A59 RID: 76377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A59")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012A5A RID: 76378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A5A")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04015130 RID: 86320
		[Token(Token = "0x4015130")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private ProfessionCategory _professionMask;

		// Token: 0x04015131 RID: 86321
		[Token(Token = "0x4015131")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minCount;

		// Token: 0x04015132 RID: 86322
		[Token(Token = "0x4015132")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _forceToggleFlag;

		// Token: 0x04015133 RID: 86323
		[Token(Token = "0x4015133")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _checkMaxSameProfessionCount;

		// Token: 0x04015134 RID: 86324
		[Token(Token = "0x4015134")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _checkMaxDifferentProfessionCount;

		// Token: 0x04015135 RID: 86325
		[Token(Token = "0x4015135")]
		[FieldOffset(Offset = "0x2C")]
		private int m_conditionCount;

		// Token: 0x04015136 RID: 86326
		[Token(Token = "0x4015136")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<ProfessionCategory, int> m_professionCount;

		// Token: 0x04015137 RID: 86327
		[Token(Token = "0x4015137")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015138 RID: 86328
		[Token(Token = "0x4015138")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015139 RID: 86329
		[Token(Token = "0x4015139")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401513A RID: 86330
		[Token(Token = "0x401513A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401513B RID: 86331
		[Token(Token = "0x401513B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x0401513C RID: 86332
		[Token(Token = "0x401513C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckProfessionCount;

		// Token: 0x0401513D RID: 86333
		[Token(Token = "0x401513D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckMaxSameProfessionCount;

		// Token: 0x0401513E RID: 86334
		[Token(Token = "0x401513E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckMaxDifferentProfessionCount;

		// Token: 0x0401513F RID: 86335
		[Token(Token = "0x401513F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCharacterChanged;

		// Token: 0x04015140 RID: 86336
		[Token(Token = "0x4015140")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckProfession;

		// Token: 0x04015141 RID: 86337
		[Token(Token = "0x4015141")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
