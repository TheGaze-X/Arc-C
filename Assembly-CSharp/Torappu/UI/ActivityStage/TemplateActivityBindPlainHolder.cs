using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA4 RID: 27812
	[Token(Token = "0x2006CA4")]
	public class TemplateActivityBindPlainHolder : PlainClassDataBinder<TemplateActivityViewModelProperty>
	{
		// Token: 0x06027AD7 RID: 162519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AD7")]
		[Address(RVA = "0x22D6430", Offset = "0x22D5030", VA = "0x1822D6430", Slot = "5")]
		public override void OnValueChanged(TemplateActivityViewModelProperty property)
		{
		}

		// Token: 0x06027AD8 RID: 162520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AD8")]
		[Address(RVA = "0x22D6670", Offset = "0x22D5270", VA = "0x1822D6670")]
		public TemplateActivityBindPlainHolder()
		{
		}

		// Token: 0x0403845D RID: 230493
		[Token(Token = "0x403845D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<IBaseActViewBinder>> binderDict;

		// Token: 0x0403845E RID: 230494
		[Token(Token = "0x403845E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403845F RID: 230495
		[Token(Token = "0x403845F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
