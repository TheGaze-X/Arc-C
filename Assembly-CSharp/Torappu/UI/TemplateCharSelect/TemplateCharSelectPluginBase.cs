using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE0 RID: 23520
	[Token(Token = "0x2005BE0")]
	public abstract class TemplateCharSelectPluginBase : ITemplateCharSelectPlugin, IHotfixable
	{
		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06022197 RID: 139671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022198 RID: 139672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FD0")]
		private protected ITemplateCharSelectCtrlHost host
		{
			[Token(Token = "0x6022197")]
			[Address(RVA = "0x1C9E880", Offset = "0x1C9D480", VA = "0x181C9E880")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6022198")]
			[Address(RVA = "0x1C9E960", Offset = "0x1C9D560", VA = "0x181C9E960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06022199 RID: 139673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602219A RID: 139674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FD1")]
		private protected string actId
		{
			[Token(Token = "0x6022199")]
			[Address(RVA = "0x1C9E820", Offset = "0x1C9D420", VA = "0x181C9E820")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602219A")]
			[Address(RVA = "0x1C9E8E0", Offset = "0x1C9D4E0", VA = "0x181C9E8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602219B RID: 139675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602219B")]
		[Address(RVA = "0x1C9E540", Offset = "0x1C9D140", VA = "0x181C9E540", Slot = "9")]
		public virtual void OnInitCharSelect(TemplateCharSelectController.InputParam inputParam, ITemplateCharSelectCtrlHost host)
		{
		}

		// Token: 0x0602219C RID: 139676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602219C")]
		[Address(RVA = "0x1C9E450", Offset = "0x1C9D050", VA = "0x181C9E450", Slot = "10")]
		public virtual void OnCharClick(int instId, string charId)
		{
		}

		// Token: 0x0602219D RID: 139677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602219D")]
		[Address(RVA = "0x1C9E690", Offset = "0x1C9D290", VA = "0x181C9E690", Slot = "11")]
		public virtual void OnSetCharAttribute(TemplateCharSelectCardViewModel targetChar, int key, ValueBundle value)
		{
		}

		// Token: 0x0602219E RID: 139678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602219E")]
		[Address(RVA = "0x1C9E4D0", Offset = "0x1C9D0D0", VA = "0x181C9E4D0", Slot = "12")]
		public virtual void OnConfirm(Action done)
		{
		}

		// Token: 0x0602219F RID: 139679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602219F")]
		[Address(RVA = "0x1C9E2C0", Offset = "0x1C9CEC0", VA = "0x181C9E2C0", Slot = "13")]
		public virtual void OnCancel(Action done)
		{
		}

		// Token: 0x060221A0 RID: 139680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221A0")]
		[Address(RVA = "0x1C9E3C0", Offset = "0x1C9CFC0", VA = "0x181C9E3C0", Slot = "14")]
		protected virtual void OnChangeCharSkill(TemplateCharSelectCardViewModel targetChar, ValueBundle value)
		{
		}

		// Token: 0x060221A1 RID: 139681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221A1")]
		[Address(RVA = "0x1C9E330", Offset = "0x1C9CF30", VA = "0x181C9E330", Slot = "15")]
		protected virtual void OnChangeCharEquip(TemplateCharSelectCardViewModel targetChar, ValueBundle value)
		{
		}

		// Token: 0x060221A2 RID: 139682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221A2")]
		[Address(RVA = "0x1C9E7C0", Offset = "0x1C9D3C0", VA = "0x181C9E7C0")]
		protected TemplateCharSelectPluginBase()
		{
		}

		// Token: 0x0402EC5B RID: 191579
		[Token(Token = "0x402EC5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_host;

		// Token: 0x0402EC5C RID: 191580
		[Token(Token = "0x402EC5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_host;

		// Token: 0x0402EC5D RID: 191581
		[Token(Token = "0x402EC5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0402EC5E RID: 191582
		[Token(Token = "0x402EC5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0402EC5F RID: 191583
		[Token(Token = "0x402EC5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInitCharSelect;

		// Token: 0x0402EC60 RID: 191584
		[Token(Token = "0x402EC60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCharClick;

		// Token: 0x0402EC61 RID: 191585
		[Token(Token = "0x402EC61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSetCharAttribute;

		// Token: 0x0402EC62 RID: 191586
		[Token(Token = "0x402EC62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0402EC63 RID: 191587
		[Token(Token = "0x402EC63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402EC64 RID: 191588
		[Token(Token = "0x402EC64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnChangeCharSkill;

		// Token: 0x0402EC65 RID: 191589
		[Token(Token = "0x402EC65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnChangeCharEquip;

		// Token: 0x0402EC66 RID: 191590
		[Token(Token = "0x402EC66")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
