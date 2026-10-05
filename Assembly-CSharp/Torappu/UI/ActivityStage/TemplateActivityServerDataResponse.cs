using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CE1 RID: 27873
	[Token(Token = "0x2006CE1")]
	public abstract class TemplateActivityServerDataResponse<DataWrapper> : PlayerDeltaResponse
	{
		// Token: 0x06027C06 RID: 162822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C06")]
		protected TemplateActivityServerDataResponse()
		{
		}

		// Token: 0x040385F6 RID: 230902
		[Token(Token = "0x40385F6")]
		[FieldOffset(Offset = "0x0")]
		public DataWrapper data;
	}
}
