using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA3 RID: 27811
	[Token(Token = "0x2006CA3")]
	public class TemplateActivityBindHolder : DataBinder<TemplateActivityViewModelProperty>
	{
		// Token: 0x06027AD5 RID: 162517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AD5")]
		[Address(RVA = "0x22D6120", Offset = "0x22D4D20", VA = "0x1822D6120", Slot = "7")]
		public override void OnValueChanged(TemplateActivityViewModelProperty property)
		{
		}

		// Token: 0x06027AD6 RID: 162518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AD6")]
		[Address(RVA = "0x22D6360", Offset = "0x22D4F60", VA = "0x1822D6360")]
		public TemplateActivityBindHolder()
		{
		}

		// Token: 0x0403845A RID: 230490
		[Token(Token = "0x403845A")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Dictionary<string, List<IBaseActViewBinder>> binderDict;

		// Token: 0x0403845B RID: 230491
		[Token(Token = "0x403845B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403845C RID: 230492
		[Token(Token = "0x403845C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
