using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Network;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CDD RID: 27869
	[Token(Token = "0x2006CDD")]
	public abstract class TemplateActivityDataFromServerViewModel<TRequest, TResponse, DataWrapper> : TemplateActivityViewModel, ITemplateActivityDataFromServer where TRequest : TemplateActivityServerDataRequest where TResponse : TemplateActivityServerDataResponse<DataWrapper>
	{
		// Token: 0x06027BF3 RID: 162803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BF3")]
		protected TemplateActivityDataFromServerViewModel(object param)
		{
		}

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x06027BF4 RID: 162804
		[Token(Token = "0x17005DD8")]
		protected abstract string serviceCode { [Token(Token = "0x6027BF4")] get; }

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x06027BF5 RID: 162805
		[Token(Token = "0x17005DD9")]
		protected abstract TRequest request { [Token(Token = "0x6027BF5")] get; }

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x06027BF6 RID: 162806
		[Token(Token = "0x17005DDA")]
		protected abstract TemplateActivityDataFromServer<DataWrapper> dataFromServer { [Token(Token = "0x6027BF6")] get; }

		// Token: 0x06027BF7 RID: 162807
		[Token(Token = "0x6027BF7")]
		protected abstract void DoWhenHaveData(DataWrapper dataWrapper);

		// Token: 0x06027BF8 RID: 162808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027BF8")]
		public IEnumerator TryFetchDataFromServer()
		{
			return null;
		}

		// Token: 0x06027BF9 RID: 162809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BF9")]
		private void _DoSendFetchDataService()
		{
		}

		// Token: 0x06027BFA RID: 162810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BFA")]
		private void _OnFetchServerDataSucceed(TResponse response)
		{
		}

		// Token: 0x06027BFB RID: 162811 RVA: 0x000CF378 File Offset: 0x000CD578
		[Token(Token = "0x6027BFB")]
		private static bool _OnFetchServerDataFail(ResponseError error)
		{
			return default(bool);
		}

		// Token: 0x040385E9 RID: 230889
		[Token(Token = "0x40385E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040385EA RID: 230890
		[Token(Token = "0x40385EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryFetchDataFromServer;

		// Token: 0x040385EB RID: 230891
		[Token(Token = "0x40385EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoSendFetchDataService;

		// Token: 0x040385EC RID: 230892
		[Token(Token = "0x40385EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnFetchServerDataSucceed;

		// Token: 0x040385ED RID: 230893
		[Token(Token = "0x40385ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnFetchServerDataFail;
	}
}
