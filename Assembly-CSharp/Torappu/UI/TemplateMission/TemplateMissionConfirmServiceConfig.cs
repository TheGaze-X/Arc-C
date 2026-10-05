using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D83 RID: 15747
	[Token(Token = "0x2003D83")]
	[Hotfix(HotfixFlag.Stateless)]
	public abstract class TemplateMissionConfirmServiceConfig<TRequest, TResponse> : ITemplateMissionConfirmServiceConfig<TResponse>, IHotfixable where TResponse : TemplateMissionCommonConfirmResponse
	{
		// Token: 0x060187EB RID: 100331
		[Token(Token = "0x60187EB")]
		protected abstract TRequest ParseRequest();

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x060187EC RID: 100332
		[Token(Token = "0x17003A77")]
		protected abstract string serviceCode { [Token(Token = "0x60187EC")] get; }

		// Token: 0x060187ED RID: 100333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187ED")]
		public void SendConfirmMissionService(Action<TResponse> onProceed)
		{
		}

		// Token: 0x060187EE RID: 100334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187EE")]
		protected TemplateMissionConfirmServiceConfig()
		{
		}

		// Token: 0x0401E033 RID: 122931
		[Token(Token = "0x401E033")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendConfirmMissionService;

		// Token: 0x0401E034 RID: 122932
		[Token(Token = "0x401E034")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
