using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024FE RID: 9470
	[Token(Token = "0x20024FE")]
	public class BlockedBaseSelector : AdvancedSelector
	{
		// Token: 0x0600F3E5 RID: 62437 RVA: 0x00059EF8 File Offset: 0x000580F8
		[Token(Token = "0x600F3E5")]
		[Address(RVA = "0x6B5420", Offset = "0x6B4020", VA = "0x1806B5420", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3E6 RID: 62438 RVA: 0x00059F10 File Offset: 0x00058110
		[Token(Token = "0x600F3E6")]
		[Address(RVA = "0x6B55A0", Offset = "0x6B41A0", VA = "0x1806B55A0")]
		private bool _ValidateWithTargetFree(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3E7 RID: 62439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3E7")]
		[Address(RVA = "0x6B56B0", Offset = "0x6B42B0", VA = "0x1806B56B0")]
		public BlockedBaseSelector()
		{
		}

		// Token: 0x0600F3E8 RID: 62440 RVA: 0x00059F28 File Offset: 0x00058128
		[Token(Token = "0x600F3E8")]
		[Address(RVA = "0x60C700", Offset = "0x60B300", VA = "0x18060C700")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E13 RID: 69139
		[Token(Token = "0x4010E13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E14 RID: 69140
		[Token(Token = "0x4010E14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ValidateWithTargetFree;

		// Token: 0x04010E15 RID: 69141
		[Token(Token = "0x4010E15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
