using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002496 RID: 9366
	[Token(Token = "0x2002496")]
	public class SilenceableTalent : Talent
	{
		// Token: 0x0600F0DF RID: 61663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0DF")]
		[Address(RVA = "0x696940", Offset = "0x695540", VA = "0x180696940", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0E0 RID: 61664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E0")]
		[Address(RVA = "0x696BD0", Offset = "0x6957D0", VA = "0x180696BD0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0E1 RID: 61665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E1")]
		[Address(RVA = "0x696FB0", Offset = "0x695BB0", VA = "0x180696FB0")]
		private void _UpdateInternalAbilityAttachStatus(bool isManuallyAttached)
		{
		}

		// Token: 0x0600F0E2 RID: 61666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E2")]
		[Address(RVA = "0x696F30", Offset = "0x695B30", VA = "0x180696F30")]
		private void _OnAbnormalFlagPossiblyChanged(AbnormalFlag abnormalFlag)
		{
		}

		// Token: 0x0600F0E3 RID: 61667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E3")]
		[Address(RVA = "0x696D80", Offset = "0x695980", VA = "0x180696D80", Slot = "28")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600F0E4 RID: 61668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E4")]
		[Address(RVA = "0x6971A0", Offset = "0x695DA0", VA = "0x1806971A0")]
		public SilenceableTalent()
		{
		}

		// Token: 0x0600F0E5 RID: 61669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E5")]
		[Address(RVA = "0x694060", Offset = "0x692C60", VA = "0x180694060")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0E6 RID: 61670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E6")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F0E7 RID: 61671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E7")]
		[Address(RVA = "0x696F20", Offset = "0x695B20", VA = "0x180696F20")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x04010A80 RID: 68224
		[Token(Token = "0x4010A80")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _isSilenceable;

		// Token: 0x04010A81 RID: 68225
		[Token(Token = "0x4010A81")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isManuallyAttached;

		// Token: 0x04010A82 RID: 68226
		[Token(Token = "0x4010A82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A83 RID: 68227
		[Token(Token = "0x4010A83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A84 RID: 68228
		[Token(Token = "0x4010A84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateInternalAbilityAttachStatus;

		// Token: 0x04010A85 RID: 68229
		[Token(Token = "0x4010A85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnAbnormalFlagPossiblyChanged;

		// Token: 0x04010A86 RID: 68230
		[Token(Token = "0x4010A86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04010A87 RID: 68231
		[Token(Token = "0x4010A87")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
