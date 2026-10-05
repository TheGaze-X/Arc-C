using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x0200747D RID: 29821
	[Token(Token = "0x200747D")]
	public class Act35sideMilestoneWidget : TemplateActivityMilestoneWidget, IHotfixable
	{
		// Token: 0x0602A0F1 RID: 172273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F1")]
		[Address(RVA = "0x25C2420", Offset = "0x25C1020", VA = "0x1825C2420", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x0602A0F2 RID: 172274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F2")]
		[Address(RVA = "0x25C2780", Offset = "0x25C1380", VA = "0x1825C2780")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A0F3 RID: 172275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F3")]
		[Address(RVA = "0x25C2950", Offset = "0x25C1550", VA = "0x1825C2950")]
		public Act35sideMilestoneWidget()
		{
		}

		// Token: 0x0403C59A RID: 247194
		[Token(Token = "0x403C59A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403C59B RID: 247195
		[Token(Token = "0x403C59B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403C59C RID: 247196
		[Token(Token = "0x403C59C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objMax;

		// Token: 0x0403C59D RID: 247197
		[Token(Token = "0x403C59D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objExp;

		// Token: 0x0403C59E RID: 247198
		[Token(Token = "0x403C59E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403C59F RID: 247199
		[Token(Token = "0x403C59F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform[] _grandRewardContainer;

		// Token: 0x0403C5A0 RID: 247200
		[Token(Token = "0x403C5A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act35sideMilestoneDisplayRewardItemView _prefabGrandReward;

		// Token: 0x0403C5A1 RID: 247201
		[Token(Token = "0x403C5A1")]
		[FieldOffset(Offset = "0x50")]
		private List<Act35sideMilestoneDisplayRewardItemView> m_grandRewardViewList;

		// Token: 0x0403C5A2 RID: 247202
		[Token(Token = "0x403C5A2")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403C5A3 RID: 247203
		[Token(Token = "0x403C5A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C5A4 RID: 247204
		[Token(Token = "0x403C5A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C5A5 RID: 247205
		[Token(Token = "0x403C5A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
