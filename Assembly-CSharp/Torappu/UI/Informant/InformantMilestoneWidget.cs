using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A1D RID: 18973
	[Token(Token = "0x2004A1D")]
	public class InformantMilestoneWidget : TemplateActivityMilestoneWidget, IHotfixable
	{
		// Token: 0x0601C8AC RID: 116908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AC")]
		[Address(RVA = "0x15FF570", Offset = "0x15FE170", VA = "0x1815FF570", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0601C8AD RID: 116909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AD")]
		[Address(RVA = "0x15FF9B0", Offset = "0x15FE5B0", VA = "0x1815FF9B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C8AE RID: 116910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AE")]
		[Address(RVA = "0x15FFB20", Offset = "0x15FE720", VA = "0x1815FFB20")]
		public InformantMilestoneWidget()
		{
		}

		// Token: 0x040256DF RID: 153311
		[Token(Token = "0x40256DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Font _textFont;

		// Token: 0x040256E0 RID: 153312
		[Token(Token = "0x40256E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x040256E1 RID: 153313
		[Token(Token = "0x40256E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InformantMilestoneGrandRewardView _grandRewardPrefab;

		// Token: 0x040256E2 RID: 153314
		[Token(Token = "0x40256E2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform[] _grandRewardContainer;

		// Token: 0x040256E3 RID: 153315
		[Token(Token = "0x40256E3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelConfirmAll;

		// Token: 0x040256E4 RID: 153316
		[Token(Token = "0x40256E4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelCannotConfirmAll;

		// Token: 0x040256E5 RID: 153317
		[Token(Token = "0x40256E5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040256E6 RID: 153318
		[Token(Token = "0x40256E6")]
		[FieldOffset(Offset = "0x50")]
		private List<InformantMilestoneGrandRewardView> m_rewardViewList;

		// Token: 0x040256E7 RID: 153319
		[Token(Token = "0x40256E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040256E8 RID: 153320
		[Token(Token = "0x40256E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040256E9 RID: 153321
		[Token(Token = "0x40256E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
