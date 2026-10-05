using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F0 RID: 21232
	[Token(Token = "0x20052F0")]
	public class RoguelikeFriendProfessionTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F50D RID: 128269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F50D")]
		[Address(RVA = "0x1908FB0", Offset = "0x1907BB0", VA = "0x181908FB0")]
		public void Render(bool isActive, ProfessionCategory profession)
		{
		}

		// Token: 0x0601F50E RID: 128270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F50E")]
		[Address(RVA = "0x1909090", Offset = "0x1907C90", VA = "0x181909090")]
		public RoguelikeFriendProfessionTabView()
		{
		}

		// Token: 0x0402A131 RID: 172337
		[Token(Token = "0x402A131")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _selectStateToggle;

		// Token: 0x0402A132 RID: 172338
		[Token(Token = "0x402A132")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _selectedProfessionImg;

		// Token: 0x0402A133 RID: 172339
		[Token(Token = "0x402A133")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _unselectedProfessionImg;

		// Token: 0x0402A134 RID: 172340
		[Token(Token = "0x402A134")]
		[FieldOffset(Offset = "0x30")]
		private ProfessionCategory m_professionCategory;

		// Token: 0x0402A135 RID: 172341
		[Token(Token = "0x402A135")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A136 RID: 172342
		[Token(Token = "0x402A136")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
