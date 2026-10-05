using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A1C RID: 18972
	[Token(Token = "0x2004A1C")]
	public class InformantMilestoneItemView : TemplateActivityCommonMileStoneItemView, IHotfixable
	{
		// Token: 0x0601C8A9 RID: 116905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8A9")]
		[Address(RVA = "0x15FEF40", Offset = "0x15FDB40", VA = "0x1815FEF40", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0601C8AA RID: 116906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AA")]
		[Address(RVA = "0x15FF020", Offset = "0x15FDC20", VA = "0x1815FF020")]
		public InformantMilestoneItemView()
		{
		}

		// Token: 0x0601C8AB RID: 116907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AB")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x040256DA RID: 153306
		[Token(Token = "0x40256DA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x040256DB RID: 153307
		[Token(Token = "0x40256DB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x040256DC RID: 153308
		[Token(Token = "0x40256DC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelConfirmed;

		// Token: 0x040256DD RID: 153309
		[Token(Token = "0x40256DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040256DE RID: 153310
		[Token(Token = "0x40256DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
