using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A17 RID: 18967
	[Token(Token = "0x2004A17")]
	public class InformantInsightBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C896 RID: 116886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C896")]
		[Address(RVA = "0x15FD9A0", Offset = "0x15FC5A0", VA = "0x1815FD9A0")]
		public void Render(InformantInsightBarModel model, bool isFastMode = true, float duration = 0.65f, float delay = 0.85f)
		{
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C897")]
		[Address(RVA = "0x15FDC30", Offset = "0x15FC830", VA = "0x1815FDC30")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601C898 RID: 116888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C898")]
		[Address(RVA = "0x15FDE60", Offset = "0x15FCA60", VA = "0x1815FDE60")]
		public InformantInsightBarView()
		{
		}

		// Token: 0x040256BE RID: 153278
		[Token(Token = "0x40256BE")]
		private const float DEFAULT_DURATION = 0.65f;

		// Token: 0x040256BF RID: 153279
		[Token(Token = "0x40256BF")]
		private const float DEFAULT_DELAY = 0.85f;

		// Token: 0x040256C0 RID: 153280
		[Token(Token = "0x40256C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ThreeStateToggle _patienceItemView;

		// Token: 0x040256C1 RID: 153281
		[Token(Token = "0x40256C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InformantInsightBarSliderItemView _trustItemView;

		// Token: 0x040256C2 RID: 153282
		[Token(Token = "0x40256C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InformantInsightBarSliderItemView _attentionItemView;

		// Token: 0x040256C3 RID: 153283
		[Token(Token = "0x40256C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040256C4 RID: 153284
		[Token(Token = "0x40256C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x040256C5 RID: 153285
		[Token(Token = "0x40256C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
