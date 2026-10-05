using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006948 RID: 26952
	[Token(Token = "0x2006948")]
	public class StageAdditionalBtnPanelHolder : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026961 RID: 158049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026961")]
		[Address(RVA = "0x21A7690", Offset = "0x21A6290", VA = "0x1821A7690", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026962 RID: 158050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026962")]
		[Address(RVA = "0x21A7890", Offset = "0x21A6490", VA = "0x1821A7890")]
		private StageAdditionalBtnPanel _EnsurePanel(ZoneData zoneData)
		{
			return null;
		}

		// Token: 0x06026963 RID: 158051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026963")]
		[Address(RVA = "0x21A7B80", Offset = "0x21A6780", VA = "0x1821A7B80")]
		public StageAdditionalBtnPanelHolder()
		{
		}

		// Token: 0x04036707 RID: 222983
		[Token(Token = "0x4036707")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04036708 RID: 222984
		[Token(Token = "0x4036708")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedPanelId;

		// Token: 0x04036709 RID: 222985
		[Token(Token = "0x4036709")]
		[FieldOffset(Offset = "0x38")]
		private StageAdditionalBtnPanel m_panel;

		// Token: 0x0403670A RID: 222986
		[Token(Token = "0x403670A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403670B RID: 222987
		[Token(Token = "0x403670B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsurePanel;

		// Token: 0x0403670C RID: 222988
		[Token(Token = "0x403670C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
