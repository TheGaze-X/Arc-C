using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB7 RID: 20407
	[Token(Token = "0x2004FB7")]
	public class EnemyDuelBetButton : AbstractEnemyDuelBetButton
	{
		// Token: 0x0601E510 RID: 124176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E510")]
		[Address(RVA = "0x17F81A0", Offset = "0x17F6DA0", VA = "0x1817F81A0", Slot = "4")]
		protected override void SetSelected(AbstractEnemyDuelBetButton.ShowType showType, bool isInit)
		{
		}

		// Token: 0x0601E511 RID: 124177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E511")]
		[Address(RVA = "0x17F8060", Offset = "0x17F6C60", VA = "0x1817F8060")]
		public void OnClicked()
		{
		}

		// Token: 0x0601E512 RID: 124178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E512")]
		[Address(RVA = "0x17F82E0", Offset = "0x17F6EE0", VA = "0x1817F82E0")]
		public EnemyDuelBetButton()
		{
		}

		// Token: 0x040287C1 RID: 165825
		[Token(Token = "0x40287C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlMask;

		// Token: 0x040287C2 RID: 165826
		[Token(Token = "0x40287C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x040287C3 RID: 165827
		[Token(Token = "0x40287C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imgArrowDeco;

		// Token: 0x040287C4 RID: 165828
		[Token(Token = "0x40287C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlSelected;

		// Token: 0x040287C5 RID: 165829
		[Token(Token = "0x40287C5")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040287C6 RID: 165830
		[Token(Token = "0x40287C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x040287C7 RID: 165831
		[Token(Token = "0x40287C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x040287C8 RID: 165832
		[Token(Token = "0x40287C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
