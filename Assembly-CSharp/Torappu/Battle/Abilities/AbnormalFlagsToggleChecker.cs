using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B4D RID: 11085
	[Token(Token = "0x2002B4D")]
	public class AbnormalFlagsToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x060129B7 RID: 76215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B7")]
		[Address(RVA = "0xA95BB0", Offset = "0xA947B0", VA = "0x180A95BB0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129B8 RID: 76216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B8")]
		[Address(RVA = "0xA95C10", Offset = "0xA94810", VA = "0x180A95C10", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x060129B9 RID: 76217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B9")]
		[Address(RVA = "0xA95F20", Offset = "0xA94B20", VA = "0x180A95F20", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060129BA RID: 76218 RVA: 0x00071EF8 File Offset: 0x000700F8
		[Token(Token = "0x60129BA")]
		[Address(RVA = "0xA95B50", Offset = "0xA94750", VA = "0x180A95B50", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129BB RID: 76219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129BB")]
		[Address(RVA = "0xA964D0", Offset = "0xA950D0", VA = "0x180A964D0")]
		private void _OnAbnormalFlagDirty(object arg)
		{
		}

		// Token: 0x060129BC RID: 76220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129BC")]
		[Address(RVA = "0xA96400", Offset = "0xA95000", VA = "0x180A96400")]
		private void _OnAbnormalComboDirty(AbnormalCombo combo)
		{
		}

		// Token: 0x060129BD RID: 76221 RVA: 0x00071F10 File Offset: 0x00070110
		[Token(Token = "0x60129BD")]
		[Address(RVA = "0xA96210", Offset = "0xA94E10", VA = "0x180A96210")]
		private bool _CheckToggled()
		{
			return default(bool);
		}

		// Token: 0x060129BE RID: 76222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129BE")]
		[Address(RVA = "0xA965A0", Offset = "0xA951A0", VA = "0x180A965A0")]
		public AbnormalFlagsToggleChecker()
		{
		}

		// Token: 0x060129BF RID: 76223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129BF")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x060129C0 RID: 76224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129C0")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04015048 RID: 86088
		[Token(Token = "0x4015048")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AbnormalFlag> _abnormalFlags;

		// Token: 0x04015049 RID: 86089
		[Token(Token = "0x4015049")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AbnormalCombo> _abnormalCombos;

		// Token: 0x0401504A RID: 86090
		[Token(Token = "0x401504A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _disableWhenAbnormalFlag;

		// Token: 0x0401504B RID: 86091
		[Token(Token = "0x401504B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401504C RID: 86092
		[Token(Token = "0x401504C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401504D RID: 86093
		[Token(Token = "0x401504D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401504E RID: 86094
		[Token(Token = "0x401504E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401504F RID: 86095
		[Token(Token = "0x401504F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAbnormalFlagDirty;

		// Token: 0x04015050 RID: 86096
		[Token(Token = "0x4015050")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAbnormalComboDirty;

		// Token: 0x04015051 RID: 86097
		[Token(Token = "0x4015051")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckToggled;

		// Token: 0x04015052 RID: 86098
		[Token(Token = "0x4015052")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
