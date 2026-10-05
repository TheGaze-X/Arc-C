using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003905 RID: 14597
	[Token(Token = "0x2003905")]
	public abstract class UISimpleRecycleLayoutItemView<T> : UISimpleRecycleLayoutItemView where T : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0601713A RID: 94522 RVA: 0x00094C80 File Offset: 0x00092E80
		// (set) Token: 0x0601713B RID: 94523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700371F")]
		private protected int index
		{
			[Token(Token = "0x601713A")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x601713B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601713C RID: 94524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601713C")]
		protected sealed override void Render(UISimpleRecycleLayoutItemViewModel model, ValueBundle value, int idx)
		{
		}

		// Token: 0x0601713D RID: 94525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601713D")]
		protected virtual void OnRender(T viewModel, ValueBundle value)
		{
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601713E")]
		protected UISimpleRecycleLayoutItemView()
		{
		}

		// Token: 0x0401BD98 RID: 114072
		[Token(Token = "0x401BD98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x0401BD99 RID: 114073
		[Token(Token = "0x401BD99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x0401BD9A RID: 114074
		[Token(Token = "0x401BD9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401BD9B RID: 114075
		[Token(Token = "0x401BD9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401BD9C RID: 114076
		[Token(Token = "0x401BD9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
