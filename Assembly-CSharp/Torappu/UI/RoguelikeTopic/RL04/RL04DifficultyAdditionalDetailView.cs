using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046C4 RID: 18116
	[Token(Token = "0x20046C4")]
	public class RL04DifficultyAdditionalDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B78C RID: 112524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78C")]
		[Address(RVA = "0x14C3450", Offset = "0x14C2050", VA = "0x1814C3450")]
		public void Render(RoguelikeTopicModeViewProperty property, int diffIdx)
		{
		}

		// Token: 0x0601B78D RID: 112525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78D")]
		[Address(RVA = "0x14C3680", Offset = "0x14C2280", VA = "0x1814C3680")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B78E RID: 112526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78E")]
		[Address(RVA = "0x14C33A0", Offset = "0x14C1FA0", VA = "0x1814C33A0")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601B78F RID: 112527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78F")]
		[Address(RVA = "0x14C37A0", Offset = "0x14C23A0", VA = "0x1814C37A0")]
		public RL04DifficultyAdditionalDetailView()
		{
		}

		// Token: 0x0402391E RID: 145694
		[Token(Token = "0x402391E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0402391F RID: 145695
		[Token(Token = "0x402391F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04023920 RID: 145696
		[Token(Token = "0x4023920")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _addDesc;

		// Token: 0x04023921 RID: 145697
		[Token(Token = "0x4023921")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeTopicModeViewProperty m_cachedProperty;

		// Token: 0x04023922 RID: 145698
		[Token(Token = "0x4023922")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x04023923 RID: 145699
		[Token(Token = "0x4023923")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023924 RID: 145700
		[Token(Token = "0x4023924")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04023925 RID: 145701
		[Token(Token = "0x4023925")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x04023926 RID: 145702
		[Token(Token = "0x4023926")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
