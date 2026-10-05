using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F4 RID: 18932
	[Token(Token = "0x20049F4")]
	public class InformantChoiceEndView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C80F RID: 116751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C80F")]
		[Address(RVA = "0x15F4730", Offset = "0x15F3330", VA = "0x1815F4730")]
		public void Render(InformantChoiceEndViewModel viewModel)
		{
		}

		// Token: 0x0601C810 RID: 116752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C810")]
		[Address(RVA = "0x15F49A0", Offset = "0x15F35A0", VA = "0x1815F49A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C811 RID: 116753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C811")]
		[Address(RVA = "0x15F46B0", Offset = "0x15F32B0", VA = "0x1815F46B0")]
		public void EventOnNextRound()
		{
		}

		// Token: 0x0601C812 RID: 116754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C812")]
		[Address(RVA = "0x15F4630", Offset = "0x15F3230", VA = "0x1815F4630")]
		public void EventOnCheckOut()
		{
		}

		// Token: 0x0601C813 RID: 116755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C813")]
		[Address(RVA = "0x15F4B00", Offset = "0x15F3700", VA = "0x1815F4B00")]
		private void _TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601C814 RID: 116756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C814")]
		[Address(RVA = "0x15F4C10", Offset = "0x15F3810", VA = "0x1815F4C10")]
		public InformantChoiceEndView()
		{
		}

		// Token: 0x0402557D RID: 152957
		[Token(Token = "0x402557D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Keeper")]
		private Text _keeperDialog;

		// Token: 0x0402557E RID: 152958
		[Token(Token = "0x402557E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Insight")]
		private InformantInsightBarView _insightBar;

		// Token: 0x0402557F RID: 152959
		[Token(Token = "0x402557F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Settle")]
		private GameObject _objNextRoundBtn;

		// Token: 0x04025580 RID: 152960
		[Token(Token = "0x4025580")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Settle")]
		private GameObject _objCheckoutBtn;

		// Token: 0x04025581 RID: 152961
		[Token(Token = "0x4025581")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04025582 RID: 152962
		[Token(Token = "0x4025582")]
		[FieldOffset(Offset = "0x48")]
		private int m_enterSeqNum;

		// Token: 0x04025583 RID: 152963
		[Token(Token = "0x4025583")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isInited;

		// Token: 0x04025584 RID: 152964
		[Token(Token = "0x4025584")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025585 RID: 152965
		[Token(Token = "0x4025585")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025586 RID: 152966
		[Token(Token = "0x4025586")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnNextRound;

		// Token: 0x04025587 RID: 152967
		[Token(Token = "0x4025587")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCheckOut;

		// Token: 0x04025588 RID: 152968
		[Token(Token = "0x4025588")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterTutorialGo;

		// Token: 0x04025589 RID: 152969
		[Token(Token = "0x4025589")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
