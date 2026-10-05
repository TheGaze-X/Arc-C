using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CEA RID: 27882
	[Token(Token = "0x2006CEA")]
	public class TemplateActivityMedalViewModel : TemplateActivityViewModel
	{
		// Token: 0x06027C15 RID: 162837 RVA: 0x000CF3F0 File Offset: 0x000CD5F0
		[Token(Token = "0x6027C15")]
		[Address(RVA = "0x22FA6E0", Offset = "0x22F92E0", VA = "0x1822FA6E0")]
		public TemplateActivityMedalViewModel.MedalProgress GetMedalProgress()
		{
			return default(TemplateActivityMedalViewModel.MedalProgress);
		}

		// Token: 0x06027C16 RID: 162838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C16")]
		[Address(RVA = "0x22FA820", Offset = "0x22F9420", VA = "0x1822FA820")]
		public TemplateActivityMedalViewModel(object param)
		{
		}

		// Token: 0x04038616 RID: 230934
		[Token(Token = "0x4038616")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_bindMedalList;

		// Token: 0x04038617 RID: 230935
		[Token(Token = "0x4038617")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMedalProgress;

		// Token: 0x04038618 RID: 230936
		[Token(Token = "0x4038618")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CEB RID: 27883
		[Token(Token = "0x2006CEB")]
		public struct MedalProgress
		{
			// Token: 0x04038619 RID: 230937
			[Token(Token = "0x4038619")]
			[FieldOffset(Offset = "0x0")]
			public int medalCount;

			// Token: 0x0403861A RID: 230938
			[Token(Token = "0x403861A")]
			[FieldOffset(Offset = "0x4")]
			public int medalSum;
		}
	}
}
