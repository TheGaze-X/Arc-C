using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004432 RID: 17458
	[Token(Token = "0x2004432")]
	public interface ISandboxV2SquadPanelContext
	{
		// Token: 0x0601AAA6 RID: 109222
		[Token(Token = "0x601AAA6")]
		void OpenDineState(int charInstId);

		// Token: 0x0601AAA7 RID: 109223
		[Token(Token = "0x601AAA7")]
		void OpenCharSelectState(SandboxV2AdminCharSelectStateBean.OpenOption option);

		// Token: 0x0601AAA8 RID: 109224
		[Token(Token = "0x601AAA8")]
		void OpenToolSelectState(SandboxV2ToolSelectStateBean.Input toolSelectInput);

		// Token: 0x0601AAA9 RID: 109225
		[Token(Token = "0x601AAA9")]
		void OpenWorkbenchDialog(SandboxV2WorkbenchMakeDialog.Options options);

		// Token: 0x0601AAAA RID: 109226
		[Token(Token = "0x601AAAA")]
		DataBinder<SandboxV2SquadGroupProp> GetBinderView();

		// Token: 0x0601AAAB RID: 109227
		[Token(Token = "0x601AAAB")]
		bool IsStateStable();

		// Token: 0x0601AAAC RID: 109228
		[Token(Token = "0x601AAAC")]
		bool IsRepoShow();

		// Token: 0x0601AAAD RID: 109229
		[Token(Token = "0x601AAAD")]
		bool IsNaviPanelShow();

		// Token: 0x0601AAAE RID: 109230
		[Token(Token = "0x601AAAE")]
		SandboxV2SquadPanelShowMode GetPanelShowMode();
	}
}
