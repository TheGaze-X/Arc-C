using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049B3 RID: 18867
	[Token(Token = "0x20049B3")]
	public class LongTermCheckInBottomItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C6D4 RID: 116436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D4")]
		[Address(RVA = "0x15E2EF0", Offset = "0x15E1AF0", VA = "0x1815E2EF0")]
		public void Render(int currIndex, int totalCount, int selectIndex)
		{
		}

		// Token: 0x0601C6D5 RID: 116437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D5")]
		[Address(RVA = "0x15E2FC0", Offset = "0x15E1BC0", VA = "0x1815E2FC0")]
		public LongTermCheckInBottomItemView()
		{
		}

		// Token: 0x040253D6 RID: 152534
		[Token(Token = "0x40253D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelItem;

		// Token: 0x040253D7 RID: 152535
		[Token(Token = "0x40253D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLastItem;

		// Token: 0x040253D8 RID: 152536
		[Token(Token = "0x40253D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateFadeSwitcher _twoStateToggle;

		// Token: 0x040253D9 RID: 152537
		[Token(Token = "0x40253D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040253DA RID: 152538
		[Token(Token = "0x40253DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
