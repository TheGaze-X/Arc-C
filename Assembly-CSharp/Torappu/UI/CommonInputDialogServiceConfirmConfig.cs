using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035B1 RID: 13745
	[Token(Token = "0x20035B1")]
	public abstract class CommonInputDialogServiceConfirmConfig<TRequest, TResponse> : ICommonInputDialogConfirmConfig, IHotfixable where TResponse : PlayerDeltaResponse
	{
		// Token: 0x06015DF4 RID: 89588
		[Token(Token = "0x6015DF4")]
		protected abstract TRequest ParseRequest(ValueBundle param, string inputText);

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x06015DF5 RID: 89589
		[Token(Token = "0x1700347F")]
		protected abstract string serviceCode { [Token(Token = "0x6015DF5")] get; }

		// Token: 0x06015DF6 RID: 89590
		[Token(Token = "0x6015DF6")]
		protected abstract bool OnValidateResponse(ValueBundle param, string inputText, TResponse response);

		// Token: 0x06015DF7 RID: 89591
		[Token(Token = "0x6015DF7")]
		public abstract string OnInputFieldValueChange(string input);

		// Token: 0x06015DF8 RID: 89592
		[Token(Token = "0x6015DF8")]
		public abstract string OnInputFieldEndEdit(string input);

		// Token: 0x06015DF9 RID: 89593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DF9")]
		public void OnConfirm(ValueBundle param, string inputText, Action callback)
		{
		}

		// Token: 0x06015DFA RID: 89594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DFA")]
		protected CommonInputDialogServiceConfirmConfig()
		{
		}

		// Token: 0x0401A4CB RID: 107723
		[Token(Token = "0x401A4CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0401A4CC RID: 107724
		[Token(Token = "0x401A4CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
