using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD6 RID: 23510
	[Token(Token = "0x2005BD6")]
	public abstract class TemplateCharSelectDetailViewModel : IHotfixable
	{
		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06022176 RID: 139638
		[Token(Token = "0x17004FCD")]
		public abstract TemplateCharSelectCardViewModel targetChar { [Token(Token = "0x6022176")] get; }

		// Token: 0x06022177 RID: 139639
		[Token(Token = "0x6022177")]
		public abstract void UpdateWithChar(TemplateCharSelectCardViewModel charModel, bool forceUpdate);

		// Token: 0x06022178 RID: 139640
		[Token(Token = "0x6022178")]
		public abstract void Reset(TemplateCharSelectModelResetData data);

		// Token: 0x06022179 RID: 139641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022179")]
		[Address(RVA = "0x1C9CA50", Offset = "0x1C9B650", VA = "0x181C9CA50", Slot = "7")]
		public virtual void Resume()
		{
		}

		// Token: 0x0602217A RID: 139642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602217A")]
		[Address(RVA = "0x1C9CAB0", Offset = "0x1C9B6B0", VA = "0x181C9CAB0")]
		protected TemplateCharSelectDetailViewModel()
		{
		}

		// Token: 0x0402EC40 RID: 191552
		[Token(Token = "0x402EC40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Resume;

		// Token: 0x0402EC41 RID: 191553
		[Token(Token = "0x402EC41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
