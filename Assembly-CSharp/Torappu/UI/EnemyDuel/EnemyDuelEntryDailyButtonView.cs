using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F90 RID: 20368
	[Token(Token = "0x2004F90")]
	public class EnemyDuelEntryDailyButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E492 RID: 124050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E492")]
		[Address(RVA = "0x17FBEC0", Offset = "0x17FAAC0", VA = "0x1817FBEC0")]
		public void Render(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E493 RID: 124051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E493")]
		[Address(RVA = "0x17FBE20", Offset = "0x17FAA20", VA = "0x1817FBE20")]
		public void OnClick()
		{
		}

		// Token: 0x0601E494 RID: 124052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E494")]
		[Address(RVA = "0x17FBFF0", Offset = "0x17FABF0", VA = "0x1817FBFF0")]
		public EnemyDuelEntryDailyButtonView()
		{
		}

		// Token: 0x040286B2 RID: 165554
		[Token(Token = "0x40286B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelOnAct;

		// Token: 0x040286B3 RID: 165555
		[Token(Token = "0x40286B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelOnFull;

		// Token: 0x040286B4 RID: 165556
		[Token(Token = "0x40286B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelOnEnd;

		// Token: 0x040286B5 RID: 165557
		[Token(Token = "0x40286B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x040286B6 RID: 165558
		[Token(Token = "0x40286B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x040286B7 RID: 165559
		[Token(Token = "0x40286B7")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040286B8 RID: 165560
		[Token(Token = "0x40286B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040286B9 RID: 165561
		[Token(Token = "0x40286B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040286BA RID: 165562
		[Token(Token = "0x40286BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
