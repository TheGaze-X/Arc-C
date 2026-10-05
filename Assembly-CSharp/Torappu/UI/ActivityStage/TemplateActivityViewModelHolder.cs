using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA6 RID: 27814
	[Token(Token = "0x2006CA6")]
	public class TemplateActivityViewModelHolder
	{
		// Token: 0x06027ADC RID: 162524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ADC")]
		[Address(RVA = "0x22E8920", Offset = "0x22E7520", VA = "0x1822E8920")]
		public TemplateActivityViewModelHolder()
		{
		}

		// Token: 0x04038465 RID: 230501
		[Token(Token = "0x4038465")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, TemplateActivityViewModel> viewModelDict;

		// Token: 0x04038466 RID: 230502
		[Token(Token = "0x4038466")]
		[FieldOffset(Offset = "0x18")]
		public List<string> toRefreshParamList;
	}
}
