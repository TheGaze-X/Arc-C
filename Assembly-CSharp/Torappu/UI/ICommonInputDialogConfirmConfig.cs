using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020035B0 RID: 13744
	[Token(Token = "0x20035B0")]
	public interface ICommonInputDialogConfirmConfig : IHotfixable
	{
		// Token: 0x06015DF1 RID: 89585
		[Token(Token = "0x6015DF1")]
		void OnConfirm(ValueBundle param, string inputText, Action callback);

		// Token: 0x06015DF2 RID: 89586
		[Token(Token = "0x6015DF2")]
		string OnInputFieldValueChange(string input);

		// Token: 0x06015DF3 RID: 89587
		[Token(Token = "0x6015DF3")]
		string OnInputFieldEndEdit(string input);
	}
}
