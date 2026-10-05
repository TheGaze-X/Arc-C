using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A2E RID: 23086
	[Token(Token = "0x2005A2E")]
	public class UIPortraitChooseCharGroupView : DataBinder<UIPortraitChooseCharProperty>, IHotfixable
	{
		// Token: 0x060219DF RID: 137695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219DF")]
		[Address(RVA = "0x1C15E30", Offset = "0x1C14A30", VA = "0x181C15E30", Slot = "7")]
		public override void OnValueChanged(UIPortraitChooseCharProperty property)
		{
		}

		// Token: 0x060219E0 RID: 137696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E0")]
		[Address(RVA = "0x1C16080", Offset = "0x1C14C80", VA = "0x181C16080")]
		public UIPortraitChooseCharGroupView()
		{
		}

		// Token: 0x0402DF71 RID: 188273
		[Token(Token = "0x402DF71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0402DF72 RID: 188274
		[Token(Token = "0x402DF72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelectCharCount;

		// Token: 0x0402DF73 RID: 188275
		[Token(Token = "0x402DF73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSelectChar;

		// Token: 0x0402DF74 RID: 188276
		[Token(Token = "0x402DF74")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTotalCount;

		// Token: 0x0402DF75 RID: 188277
		[Token(Token = "0x402DF75")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIPortraitChooseCharAdapter _adapter;

		// Token: 0x0402DF76 RID: 188278
		[Token(Token = "0x402DF76")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedSequence;

		// Token: 0x0402DF77 RID: 188279
		[Token(Token = "0x402DF77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DF78 RID: 188280
		[Token(Token = "0x402DF78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
