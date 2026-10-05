using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D82 RID: 15746
	[Token(Token = "0x2003D82")]
	public interface ITemplateMissionConfirmServiceConfig<TResponse> : IHotfixable
	{
		// Token: 0x060187EA RID: 100330
		[Token(Token = "0x60187EA")]
		void SendConfirmMissionService(Action<TResponse> onProceed);
	}
}
