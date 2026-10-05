using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;

namespace Torappu.UI
{
	// Token: 0x020035BB RID: 13755
	[Token(Token = "0x20035BB")]
	public interface ICommonSquadMsgReceiver : IHotfixable, IValueMsgReceiver
	{
		// Token: 0x06015E22 RID: 89634
		[Token(Token = "0x6015E22")]
		void SendMsg(int key, ValueBundle msg);

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x06015E23 RID: 89635
		[Token(Token = "0x17003484")]
		CommonSquadGroupViewModel commonSquadGroupViewModel { [Token(Token = "0x6015E23")] get; }

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x06015E24 RID: 89636
		[Token(Token = "0x17003485")]
		TemplateCharSelectController.InputParam paramToSelectState { [Token(Token = "0x6015E24")] get; }

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x06015E25 RID: 89637
		[Token(Token = "0x17003486")]
		CommonCharSelectCustomization charSelectCustomization { [Token(Token = "0x6015E25")] get; }

		// Token: 0x06015E26 RID: 89638
		[Token(Token = "0x6015E26")]
		IStateEngine GetSupportStateEngine();

		// Token: 0x06015E27 RID: 89639
		[Token(Token = "0x6015E27")]
		void NotifyUpdate();
	}
}
