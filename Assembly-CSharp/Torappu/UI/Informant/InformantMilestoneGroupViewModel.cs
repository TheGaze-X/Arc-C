using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A1A RID: 18970
	[Token(Token = "0x2004A1A")]
	public class InformantMilestoneGroupViewModel : TemplateActivityMilestoneGroupViewModel, IHotfixable
	{
		// Token: 0x0601C8A7 RID: 116903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8A7")]
		[Address(RVA = "0x15FECA0", Offset = "0x15FD8A0", VA = "0x1815FECA0")]
		public InformantMilestoneGroupViewModel(object param)
		{
		}

		// Token: 0x040256D6 RID: 153302
		[Token(Token = "0x40256D6")]
		[FieldOffset(Offset = "0xC0")]
		public List<InformantMilestoneGroupViewModel.InformantMilestoneDisplayRewardModel> displayRewardModelList;

		// Token: 0x040256D7 RID: 153303
		[Token(Token = "0x40256D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A1B RID: 18971
		[Token(Token = "0x2004A1B")]
		public class InformantMilestoneDisplayRewardModel
		{
			// Token: 0x0601C8A8 RID: 116904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C8A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InformantMilestoneDisplayRewardModel()
			{
			}

			// Token: 0x040256D8 RID: 153304
			[Token(Token = "0x40256D8")]
			[FieldOffset(Offset = "0x10")]
			public string itemName;

			// Token: 0x040256D9 RID: 153305
			[Token(Token = "0x40256D9")]
			[FieldOffset(Offset = "0x18")]
			public int point;
		}
	}
}
