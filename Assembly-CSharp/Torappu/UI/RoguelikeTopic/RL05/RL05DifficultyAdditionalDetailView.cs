using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x0200458D RID: 17805
	[Token(Token = "0x200458D")]
	public class RL05DifficultyAdditionalDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B1B6 RID: 111030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B6")]
		[Address(RVA = "0x142FC50", Offset = "0x142E850", VA = "0x18142FC50")]
		public void Render(RoguelikeTopicModeViewProperty property, int diffIdx)
		{
		}

		// Token: 0x0601B1B7 RID: 111031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B7")]
		[Address(RVA = "0x142FEC0", Offset = "0x142EAC0", VA = "0x18142FEC0")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B1B8 RID: 111032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B8")]
		[Address(RVA = "0x142FB40", Offset = "0x142E740", VA = "0x18142FB40")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601B1B9 RID: 111033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B9")]
		[Address(RVA = "0x142FFE0", Offset = "0x142EBE0", VA = "0x18142FFE0")]
		public RL05DifficultyAdditionalDetailView()
		{
		}

		// Token: 0x04022DF6 RID: 142838
		[Token(Token = "0x4022DF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x04022DF7 RID: 142839
		[Token(Token = "0x4022DF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022DF8 RID: 142840
		[Token(Token = "0x4022DF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _addDesc;

		// Token: 0x04022DF9 RID: 142841
		[Token(Token = "0x4022DF9")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeTopicModeViewProperty m_cachedProperty;

		// Token: 0x04022DFA RID: 142842
		[Token(Token = "0x4022DFA")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x04022DFB RID: 142843
		[Token(Token = "0x4022DFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022DFC RID: 142844
		[Token(Token = "0x4022DFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04022DFD RID: 142845
		[Token(Token = "0x4022DFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x04022DFE RID: 142846
		[Token(Token = "0x4022DFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
