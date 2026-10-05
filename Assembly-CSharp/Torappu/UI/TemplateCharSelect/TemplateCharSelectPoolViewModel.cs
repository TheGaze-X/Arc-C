using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE1 RID: 23521
	[Token(Token = "0x2005BE1")]
	public abstract class TemplateCharSelectPoolViewModel : IHotfixable
	{
		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x060221A3 RID: 139683
		[Token(Token = "0x17004FD2")]
		public abstract List<TemplateCharSelectCardViewModel> selectedCharList { [Token(Token = "0x60221A3")] get; }

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x060221A4 RID: 139684
		[Token(Token = "0x17004FD3")]
		public abstract TemplateCharSelectCardViewModel lastSelectedChar { [Token(Token = "0x60221A4")] get; }

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x060221A5 RID: 139685
		[Token(Token = "0x17004FD4")]
		public abstract HashSet<string> validSubProfessionIds { [Token(Token = "0x60221A5")] get; }

		// Token: 0x060221A6 RID: 139686
		[Token(Token = "0x60221A6")]
		public abstract void Reset(TemplateCharSelectModelResetData data);

		// Token: 0x060221A7 RID: 139687
		[Token(Token = "0x60221A7")]
		public abstract void Resume();

		// Token: 0x060221A8 RID: 139688
		[Token(Token = "0x60221A8")]
		public abstract bool SelectChar(int instId);

		// Token: 0x060221A9 RID: 139689
		[Token(Token = "0x60221A9")]
		public abstract void ClearAllSelect();

		// Token: 0x060221AA RID: 139690
		[Token(Token = "0x60221AA")]
		public abstract void ApplyShuffle(TemplateCharSelectShuffleViewModel shuffleViewModel);

		// Token: 0x060221AB RID: 139691
		[Token(Token = "0x60221AB")]
		public abstract List<TemplateCharSelectCardViewModel> GetShuffleResult();

		// Token: 0x060221AC RID: 139692
		[Token(Token = "0x60221AC")]
		public abstract string GetCharIdByInstId(int instId);

		// Token: 0x060221AD RID: 139693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221AD")]
		[Address(RVA = "0x1C9E9E0", Offset = "0x1C9D5E0", VA = "0x181C9E9E0")]
		protected TemplateCharSelectPoolViewModel()
		{
		}

		// Token: 0x0402EC67 RID: 191591
		[Token(Token = "0x402EC67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
