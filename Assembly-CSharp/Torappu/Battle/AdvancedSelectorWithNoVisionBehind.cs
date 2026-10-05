using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F3 RID: 9459
	[Token(Token = "0x20024F3")]
	public class AdvancedSelectorWithNoVisionBehind : AdvancedSelector
	{
		// Token: 0x0600F3AD RID: 62381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3AD")]
		[Address(RVA = "0x69F7B0", Offset = "0x69E3B0", VA = "0x18069F7B0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3AE RID: 62382 RVA: 0x00059E08 File Offset: 0x00058008
		[Token(Token = "0x600F3AE")]
		[Address(RVA = "0x69F900", Offset = "0x69E500", VA = "0x18069F900")]
		private bool _HasVisionBehind(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600F3AF RID: 62383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3AF")]
		[Address(RVA = "0x69FBD0", Offset = "0x69E7D0", VA = "0x18069FBD0")]
		public AdvancedSelectorWithNoVisionBehind()
		{
		}

		// Token: 0x0600F3B0 RID: 62384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B0")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DCD RID: 69069
		[Token(Token = "0x4010DCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DCE RID: 69070
		[Token(Token = "0x4010DCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HasVisionBehind;

		// Token: 0x04010DCF RID: 69071
		[Token(Token = "0x4010DCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
