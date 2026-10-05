using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200449E RID: 17566
	[Token(Token = "0x200449E")]
	public class RoguelikeTopicBattlePassRewardOverviewView : DataBinder<RoguelikeTopicBattlePassPurchaseOverviewProperty>
	{
		// Token: 0x0601AD3D RID: 109885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD3D")]
		[Address(RVA = "0x13F9C00", Offset = "0x13F8800", VA = "0x1813F9C00")]
		public void Init(RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601AD3E RID: 109886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD3E")]
		[Address(RVA = "0x13F9C80", Offset = "0x13F8880", VA = "0x1813F9C80", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicBattlePassPurchaseOverviewProperty property)
		{
		}

		// Token: 0x0601AD3F RID: 109887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD3F")]
		[Address(RVA = "0x13F9D90", Offset = "0x13F8990", VA = "0x1813F9D90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD40 RID: 109888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD40")]
		[Address(RVA = "0x13F9E10", Offset = "0x13F8A10", VA = "0x1813F9E10")]
		public RoguelikeTopicBattlePassRewardOverviewView()
		{
		}

		// Token: 0x04022583 RID: 140675
		[Token(Token = "0x4022583")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewListView _listView;

		// Token: 0x04022584 RID: 140676
		[Token(Token = "0x4022584")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeTopicBattlePassStyle m_style;

		// Token: 0x04022585 RID: 140677
		[Token(Token = "0x4022585")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04022586 RID: 140678
		[Token(Token = "0x4022586")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022587 RID: 140679
		[Token(Token = "0x4022587")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022588 RID: 140680
		[Token(Token = "0x4022588")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022589 RID: 140681
		[Token(Token = "0x4022589")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
