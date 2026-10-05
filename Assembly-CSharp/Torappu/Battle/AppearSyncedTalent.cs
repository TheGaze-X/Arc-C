using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002469 RID: 9321
	[Token(Token = "0x2002469")]
	public class AppearSyncedTalent : Talent
	{
		// Token: 0x0600EFD4 RID: 61396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD4")]
		[Address(RVA = "0x66A030", Offset = "0x668C30", VA = "0x18066A030", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600EFD5 RID: 61397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD5")]
		[Address(RVA = "0x66A1F0", Offset = "0x668DF0", VA = "0x18066A1F0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD6")]
		[Address(RVA = "0x66A490", Offset = "0x669090", VA = "0x18066A490")]
		private void _OnAppearOrDisappear(object arg)
		{
		}

		// Token: 0x0600EFD7 RID: 61399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD7")]
		[Address(RVA = "0x66A650", Offset = "0x669250", VA = "0x18066A650")]
		public AppearSyncedTalent()
		{
		}

		// Token: 0x0600EFD8 RID: 61400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD8")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600EFD9 RID: 61401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD9")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401093B RID: 67899
		[Token(Token = "0x401093B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401093C RID: 67900
		[Token(Token = "0x401093C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401093D RID: 67901
		[Token(Token = "0x401093D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAppearOrDisappear;

		// Token: 0x0401093E RID: 67902
		[Token(Token = "0x401093E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
