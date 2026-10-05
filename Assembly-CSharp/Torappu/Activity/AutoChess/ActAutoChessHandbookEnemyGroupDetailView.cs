using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007123 RID: 28963
	[Token(Token = "0x2007123")]
	public class ActAutoChessHandbookEnemyGroupDetailView : ActAutoChessHandbookDetailBaseView, IHotfixable
	{
		// Token: 0x06029230 RID: 168496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029230")]
		[Address(RVA = "0x2484A50", Offset = "0x2483650", VA = "0x182484A50", Slot = "8")]
		protected override void Render(ActAutoChessHandbookViewModel model)
		{
		}

		// Token: 0x06029231 RID: 168497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029231")]
		[Address(RVA = "0x2484970", Offset = "0x2483570", VA = "0x182484970")]
		public void EventOnEnemyDetailClicked()
		{
		}

		// Token: 0x06029232 RID: 168498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029232")]
		[Address(RVA = "0x2484C30", Offset = "0x2483830", VA = "0x182484C30")]
		public ActAutoChessHandbookEnemyGroupDetailView()
		{
		}

		// Token: 0x0403ABE9 RID: 240617
		[Token(Token = "0x403ABE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403ABEA RID: 240618
		[Token(Token = "0x403ABEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403ABEB RID: 240619
		[Token(Token = "0x403ABEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403ABEC RID: 240620
		[Token(Token = "0x403ABEC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActAutoChessHandbookEnemyGroupDetailListAdapter _adapter;

		// Token: 0x0403ABED RID: 240621
		[Token(Token = "0x403ABED")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403ABEE RID: 240622
		[Token(Token = "0x403ABEE")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedId;

		// Token: 0x0403ABEF RID: 240623
		[Token(Token = "0x403ABEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABF0 RID: 240624
		[Token(Token = "0x403ABF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDetailClicked;

		// Token: 0x0403ABF1 RID: 240625
		[Token(Token = "0x403ABF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
