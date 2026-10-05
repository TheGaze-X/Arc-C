using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003906 RID: 14598
	[Token(Token = "0x2003906")]
	public abstract class UISimpleRecycleLayoutItemViewModel : IHotfixable
	{
		// Token: 0x0601713F RID: 94527
		[Token(Token = "0x601713F")]
		public abstract string GetViewType();

		// Token: 0x06017140 RID: 94528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017140")]
		[Address(RVA = "0xF7F160", Offset = "0xF7DD60", VA = "0x180F7F160", Slot = "5")]
		public virtual void OnViewDetached(UISimpleRecycleLayoutItemView.VirtualView host)
		{
		}

		// Token: 0x06017141 RID: 94529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017141")]
		[Address(RVA = "0xF7F1C0", Offset = "0xF7DDC0", VA = "0x180F7F1C0")]
		protected UISimpleRecycleLayoutItemViewModel()
		{
		}

		// Token: 0x0401BD9D RID: 114077
		[Token(Token = "0x401BD9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0401BD9E RID: 114078
		[Token(Token = "0x401BD9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
