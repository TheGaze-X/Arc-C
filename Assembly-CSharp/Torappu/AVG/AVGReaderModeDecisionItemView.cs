using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F63 RID: 8035
	[Token(Token = "0x2001F63")]
	public class AVGReaderModeDecisionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C7B2 RID: 51122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B2")]
		[Address(RVA = "0x348CDD0", Offset = "0x348B9D0", VA = "0x18348CDD0")]
		public void Render(string optionText, bool isSelected, bool isClickable, Action onClickCallback, int fontSize = 0)
		{
		}

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B3")]
		[Address(RVA = "0x348CF70", Offset = "0x348BB70", VA = "0x18348CF70")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B4")]
		[Address(RVA = "0x348CD60", Offset = "0x348B960", VA = "0x18348CD60")]
		public void EventOnDecisionClicked()
		{
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B5")]
		[Address(RVA = "0x348D050", Offset = "0x348BC50", VA = "0x18348D050")]
		public AVGReaderModeDecisionItemView()
		{
		}

		// Token: 0x0400CDC9 RID: 52681
		[Token(Token = "0x400CDC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _decisionText;

		// Token: 0x0400CDCA RID: 52682
		[Token(Token = "0x400CDCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400CDCB RID: 52683
		[Token(Token = "0x400CDCB")]
		[FieldOffset(Offset = "0x28")]
		private Action m_onclick;

		// Token: 0x0400CDCC RID: 52684
		[Token(Token = "0x400CDCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400CDCD RID: 52685
		[Token(Token = "0x400CDCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetInteractable;

		// Token: 0x0400CDCE RID: 52686
		[Token(Token = "0x400CDCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnDecisionClicked;

		// Token: 0x0400CDCF RID: 52687
		[Token(Token = "0x400CDCF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
