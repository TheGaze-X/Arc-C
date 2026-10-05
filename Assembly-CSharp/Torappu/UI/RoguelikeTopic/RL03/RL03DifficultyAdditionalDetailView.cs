using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045B0 RID: 17840
	[Token(Token = "0x20045B0")]
	public class RL03DifficultyAdditionalDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B257 RID: 111191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B257")]
		[Address(RVA = "0x1445D40", Offset = "0x1444940", VA = "0x181445D40")]
		public void Render(RoguelikeTopicModeViewProperty property, int diffIdx)
		{
		}

		// Token: 0x0601B258 RID: 111192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B258")]
		[Address(RVA = "0x1445F70", Offset = "0x1444B70", VA = "0x181445F70")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B259 RID: 111193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B259")]
		[Address(RVA = "0x1445C90", Offset = "0x1444890", VA = "0x181445C90")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601B25A RID: 111194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25A")]
		[Address(RVA = "0x14460A0", Offset = "0x1444CA0", VA = "0x1814460A0")]
		public RL03DifficultyAdditionalDetailView()
		{
		}

		// Token: 0x04022F2F RID: 143151
		[Token(Token = "0x4022F2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x04022F30 RID: 143152
		[Token(Token = "0x4022F30")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022F31 RID: 143153
		[Token(Token = "0x4022F31")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _addDesc;

		// Token: 0x04022F32 RID: 143154
		[Token(Token = "0x4022F32")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeTopicModeViewProperty m_cachedProperty;

		// Token: 0x04022F33 RID: 143155
		[Token(Token = "0x4022F33")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x04022F34 RID: 143156
		[Token(Token = "0x4022F34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022F35 RID: 143157
		[Token(Token = "0x4022F35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04022F36 RID: 143158
		[Token(Token = "0x4022F36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x04022F37 RID: 143159
		[Token(Token = "0x4022F37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
