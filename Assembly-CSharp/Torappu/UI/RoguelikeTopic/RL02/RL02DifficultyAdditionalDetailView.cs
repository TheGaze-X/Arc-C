using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x020045FC RID: 17916
	[Token(Token = "0x20045FC")]
	public class RL02DifficultyAdditionalDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B3BC RID: 111548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BC")]
		[Address(RVA = "0x145D7D0", Offset = "0x145C3D0", VA = "0x18145D7D0")]
		public void Render(RoguelikeTopicDifficultyViewModel difficulty)
		{
		}

		// Token: 0x0601B3BD RID: 111549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BD")]
		[Address(RVA = "0x145D990", Offset = "0x145C590", VA = "0x18145D990")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BE")]
		[Address(RVA = "0x145D770", Offset = "0x145C370", VA = "0x18145D770")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601B3BF RID: 111551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BF")]
		[Address(RVA = "0x145DA10", Offset = "0x145C610", VA = "0x18145DA10")]
		public RL02DifficultyAdditionalDetailView()
		{
		}

		// Token: 0x040231E5 RID: 143845
		[Token(Token = "0x40231E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x040231E6 RID: 143846
		[Token(Token = "0x40231E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _addDesc;

		// Token: 0x040231E7 RID: 143847
		[Token(Token = "0x40231E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040231E8 RID: 143848
		[Token(Token = "0x40231E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x040231E9 RID: 143849
		[Token(Token = "0x40231E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x040231EA RID: 143850
		[Token(Token = "0x40231EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
