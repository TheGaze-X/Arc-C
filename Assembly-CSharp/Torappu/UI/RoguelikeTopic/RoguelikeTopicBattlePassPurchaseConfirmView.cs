using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004486 RID: 17542
	[Token(Token = "0x2004486")]
	public class RoguelikeTopicBattlePassPurchaseConfirmView : DataBinder<RoguelikeTopicBattlePassPurchaseOverviewProperty>
	{
		// Token: 0x0601ACD4 RID: 109780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD4")]
		[Address(RVA = "0x13F4E50", Offset = "0x13F3A50", VA = "0x1813F4E50")]
		public void Init(RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601ACD5 RID: 109781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD5")]
		[Address(RVA = "0x13F4ED0", Offset = "0x13F3AD0", VA = "0x1813F4ED0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicBattlePassPurchaseOverviewProperty property)
		{
		}

		// Token: 0x0601ACD6 RID: 109782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD6")]
		[Address(RVA = "0x13F51A0", Offset = "0x13F3DA0", VA = "0x1813F51A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACD7 RID: 109783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD7")]
		[Address(RVA = "0x13F52D0", Offset = "0x13F3ED0", VA = "0x1813F52D0")]
		public RoguelikeTopicBattlePassPurchaseConfirmView()
		{
		}

		// Token: 0x04022497 RID: 140439
		[Token(Token = "0x4022497")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewListView _listView;

		// Token: 0x04022498 RID: 140440
		[Token(Token = "0x4022498")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevelDetail;

		// Token: 0x04022499 RID: 140441
		[Token(Token = "0x4022499")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0402249A RID: 140442
		[Token(Token = "0x402249A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgConfirm;

		// Token: 0x0402249B RID: 140443
		[Token(Token = "0x402249B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _iconBuy;

		// Token: 0x0402249C RID: 140444
		[Token(Token = "0x402249C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _btnConfirmText;

		// Token: 0x0402249D RID: 140445
		[Token(Token = "0x402249D")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicBattlePassStyle m_style;

		// Token: 0x0402249E RID: 140446
		[Token(Token = "0x402249E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0402249F RID: 140447
		[Token(Token = "0x402249F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040224A0 RID: 140448
		[Token(Token = "0x40224A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040224A1 RID: 140449
		[Token(Token = "0x40224A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040224A2 RID: 140450
		[Token(Token = "0x40224A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
