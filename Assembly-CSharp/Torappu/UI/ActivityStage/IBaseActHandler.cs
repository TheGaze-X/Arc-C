using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C96 RID: 27798
	[Token(Token = "0x2006C96")]
	public interface IBaseActHandler : IHotfixable
	{
		// Token: 0x06027A81 RID: 162433
		[Token(Token = "0x6027A81")]
		TemplateActivityViewModel GetViewModel(string param);

		// Token: 0x06027A82 RID: 162434
		[Token(Token = "0x6027A82")]
		string GetActId();

		// Token: 0x06027A83 RID: 162435
		[Token(Token = "0x6027A83")]
		void OnDataUpdated(string param);

		// Token: 0x06027A84 RID: 162436
		[Token(Token = "0x6027A84")]
		void Bind(IBaseActViewBinder binder, string param);

		// Token: 0x06027A85 RID: 162437
		[Token(Token = "0x6027A85")]
		void UnBind(IBaseActViewBinder binder, string param);

		// Token: 0x06027A86 RID: 162438
		[Token(Token = "0x6027A86")]
		bool CheckIfActivityIsOpen();

		// Token: 0x06027A87 RID: 162439
		[Token(Token = "0x6027A87")]
		TemplateActivityLifeCycleViewModel.ActState GetCurrentState();
	}
}
