using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public class DelaySwitchTween : UISwitchTween
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x552F160", Offset = "0x552DD60", VA = "0x18552F160", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x552F210", Offset = "0x552DE10", VA = "0x18552F210", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x552F2C0", Offset = "0x552DEC0", VA = "0x18552F2C0", Slot = "11")]
		protected override void OnResetOperation(UISwitchTween.ResetStage stage)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x552F400", Offset = "0x552E000", VA = "0x18552F400")]
		public DelaySwitchTween()
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x552F3A0", Offset = "0x552DFA0", VA = "0x18552F3A0")]
		private void <>xLuaBaseProxy_OnResetOperation(UISwitchTween.ResetStage P0)
		{
		}

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x48")]
		private DelaySwitchTween.Builder m_builder;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfHide;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfShow;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate174 __Hotfix0_OnResetOperation;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200016C RID: 364
		[Token(Token = "0x200016C")]
		public struct Builder
		{
			// Token: 0x060008C9 RID: 2249 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x552EE90", Offset = "0x552DA90", VA = "0x18552EE90")]
			public DelaySwitchTween Build()
			{
				return null;
			}

			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			[FieldOffset(Offset = "0x0")]
			public UISwitchTween.Durations delay;

			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x8")]
			public Action<bool> callback;
		}
	}
}
