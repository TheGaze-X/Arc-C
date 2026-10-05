using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x0200446B RID: 17515
	[Token(Token = "0x200446B")]
	public class RoguelikeEntryBottomItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AC6A RID: 109674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6A")]
		[Address(RVA = "0x13D6310", Offset = "0x13D4F10", VA = "0x1813D6310")]
		public void Render(RoguelikeEntryItemViewModel model, bool isFocusItem)
		{
		}

		// Token: 0x0601AC6B RID: 109675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6B")]
		[Address(RVA = "0x13D6210", Offset = "0x13D4E10", VA = "0x1813D6210")]
		public void OnItemSelectClicked()
		{
		}

		// Token: 0x0601AC6C RID: 109676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6C")]
		[Address(RVA = "0x13D6110", Offset = "0x13D4D10", VA = "0x1813D6110")]
		public void OnEntryClicked()
		{
		}

		// Token: 0x0601AC6D RID: 109677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6D")]
		[Address(RVA = "0x13D6800", Offset = "0x13D5400", VA = "0x1813D6800")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AC6E RID: 109678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6E")]
		[Address(RVA = "0x13D6920", Offset = "0x13D5520", VA = "0x1813D6920")]
		public RoguelikeEntryBottomItemView()
		{
		}

		// Token: 0x04022399 RID: 140185
		[Token(Token = "0x4022399")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402239A RID: 140186
		[Token(Token = "0x402239A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0402239B RID: 140187
		[Token(Token = "0x402239B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTopic;

		// Token: 0x0402239C RID: 140188
		[Token(Token = "0x402239C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBpName;

		// Token: 0x0402239D RID: 140189
		[Token(Token = "0x402239D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textBpLevel;

		// Token: 0x0402239E RID: 140190
		[Token(Token = "0x402239E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBpMax;

		// Token: 0x0402239F RID: 140191
		[Token(Token = "0x402239F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgMedal;

		// Token: 0x040223A0 RID: 140192
		[Token(Token = "0x40223A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMedal;

		// Token: 0x040223A1 RID: 140193
		[Token(Token = "0x40223A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _panelEntry;

		// Token: 0x040223A2 RID: 140194
		[Token(Token = "0x40223A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelCannotEntry;

		// Token: 0x040223A3 RID: 140195
		[Token(Token = "0x40223A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelOnBattle;

		// Token: 0x040223A4 RID: 140196
		[Token(Token = "0x40223A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MaskableGraphic _imgOnBattle;

		// Token: 0x040223A5 RID: 140197
		[Token(Token = "0x40223A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSelectedBtn;

		// Token: 0x040223A6 RID: 140198
		[Token(Token = "0x40223A6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _panelUnselectedBtn;

		// Token: 0x040223A7 RID: 140199
		[Token(Token = "0x40223A7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelDLCUpdate;

		// Token: 0x040223A8 RID: 140200
		[Token(Token = "0x40223A8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelReviewUpdate;

		// Token: 0x040223A9 RID: 140201
		[Token(Token = "0x40223A9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040223AA RID: 140202
		[Token(Token = "0x40223AA")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040223AB RID: 140203
		[Token(Token = "0x40223AB")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTopicId;

		// Token: 0x040223AC RID: 140204
		[Token(Token = "0x40223AC")]
		[FieldOffset(Offset = "0xC0")]
		private UISwitchTween m_switchTween;

		// Token: 0x040223AD RID: 140205
		[Token(Token = "0x40223AD")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x040223AE RID: 140206
		[Token(Token = "0x40223AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040223AF RID: 140207
		[Token(Token = "0x40223AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnItemSelectClicked;

		// Token: 0x040223B0 RID: 140208
		[Token(Token = "0x40223B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEntryClicked;

		// Token: 0x040223B1 RID: 140209
		[Token(Token = "0x40223B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040223B2 RID: 140210
		[Token(Token = "0x40223B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
