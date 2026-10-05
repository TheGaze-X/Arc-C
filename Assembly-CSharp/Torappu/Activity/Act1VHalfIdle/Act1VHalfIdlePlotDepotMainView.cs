using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200775D RID: 30557
	[Token(Token = "0x200775D")]
	public class Act1VHalfIdlePlotDepotMainView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AEB6 RID: 175798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB6")]
		[Address(RVA = "0x26B3070", Offset = "0x26B1C70", VA = "0x1826B3070")]
		public void Render(Act1VHalfIdlePlotDepotViewModel viewModel)
		{
		}

		// Token: 0x0602AEB7 RID: 175799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB7")]
		[Address(RVA = "0x26B3260", Offset = "0x26B1E60", VA = "0x1826B3260")]
		private void _OnItemClicked(string plotId)
		{
		}

		// Token: 0x0602AEB8 RID: 175800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB8")]
		[Address(RVA = "0x26B3370", Offset = "0x26B1F70", VA = "0x1826B3370")]
		public Act1VHalfIdlePlotDepotMainView()
		{
		}

		// Token: 0x0403DE89 RID: 253577
		[Token(Token = "0x403DE89")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfidlePlotBackpackCardItemAdapter _adapter;

		// Token: 0x0403DE8A RID: 253578
		[Token(Token = "0x403DE8A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DE8B RID: 253579
		[Token(Token = "0x403DE8B")]
		[FieldOffset(Offset = "0x28")]
		private UICompDialogFinder m_compDialogFinder;

		// Token: 0x0403DE8C RID: 253580
		[Token(Token = "0x403DE8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE8D RID: 253581
		[Token(Token = "0x403DE8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403DE8E RID: 253582
		[Token(Token = "0x403DE8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
