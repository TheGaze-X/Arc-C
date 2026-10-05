using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BEB RID: 23531
	[Token(Token = "0x2005BEB")]
	public abstract class TemplateCharSelectSubViewBase : DataBinder<TemplateCharSelectMainProperty>
	{
		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x060221D6 RID: 139734 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060221D7 RID: 139735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FD8")]
		private protected ITemplateCharSelectCtrl controller
		{
			[Token(Token = "0x60221D6")]
			[Address(RVA = "0x1C9F220", Offset = "0x1C9DE20", VA = "0x181C9F220")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60221D7")]
			[Address(RVA = "0x1C9F2E0", Offset = "0x1C9DEE0", VA = "0x181C9F2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x060221D8 RID: 139736 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060221D9 RID: 139737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FD9")]
		private protected TemplateCharSelectMainViewModel mainModel
		{
			[Token(Token = "0x60221D8")]
			[Address(RVA = "0x1C9F280", Offset = "0x1C9DE80", VA = "0x181C9F280")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60221D9")]
			[Address(RVA = "0x1C9F360", Offset = "0x1C9DF60", VA = "0x181C9F360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060221DA RID: 139738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221DA")]
		[Address(RVA = "0x1C9EF40", Offset = "0x1C9DB40", VA = "0x181C9EF40")]
		public void Init(ITemplateCharSelectCtrl ctrl)
		{
		}

		// Token: 0x060221DB RID: 139739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221DB")]
		[Address(RVA = "0x1C9EFF0", Offset = "0x1C9DBF0", VA = "0x181C9EFF0", Slot = "7")]
		public override void OnValueChanged(TemplateCharSelectMainProperty property)
		{
		}

		// Token: 0x060221DC RID: 139740
		[Token(Token = "0x60221DC")]
		public abstract void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel);

		// Token: 0x060221DD RID: 139741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221DD")]
		[Address(RVA = "0x1C9F150", Offset = "0x1C9DD50", VA = "0x181C9F150", Slot = "9")]
		public virtual void RegisterTutorialGO()
		{
		}

		// Token: 0x060221DE RID: 139742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221DE")]
		[Address(RVA = "0x1C9F1B0", Offset = "0x1C9DDB0", VA = "0x181C9F1B0")]
		protected TemplateCharSelectSubViewBase()
		{
		}

		// Token: 0x0402EC83 RID: 191619
		[Token(Token = "0x402EC83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0402EC84 RID: 191620
		[Token(Token = "0x402EC84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0402EC85 RID: 191621
		[Token(Token = "0x402EC85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mainModel;

		// Token: 0x0402EC86 RID: 191622
		[Token(Token = "0x402EC86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_mainModel;

		// Token: 0x0402EC87 RID: 191623
		[Token(Token = "0x402EC87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402EC88 RID: 191624
		[Token(Token = "0x402EC88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EC89 RID: 191625
		[Token(Token = "0x402EC89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0402EC8A RID: 191626
		[Token(Token = "0x402EC8A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
