using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007780 RID: 30592
	[Token(Token = "0x2007780")]
	public class Act1VHalfIdleStuffDepotMainView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x0602AF77 RID: 175991 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AF76 RID: 175990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064BB")]
		public Action<Act1VHalfIdleStuffDepotItemViewModel> onItemClick
		{
			[Token(Token = "0x602AF77")]
			[Address(RVA = "0x26D5140", Offset = "0x26D3D40", VA = "0x1826D5140")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AF76")]
			[Address(RVA = "0x26D51A0", Offset = "0x26D3DA0", VA = "0x1826D51A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AF78 RID: 175992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF78")]
		[Address(RVA = "0x26D4F40", Offset = "0x26D3B40", VA = "0x1826D4F40")]
		public void Render(Act1VHalfIdleStuffDepotViewModel viewModel)
		{
		}

		// Token: 0x0602AF79 RID: 175993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF79")]
		[Address(RVA = "0x26D50E0", Offset = "0x26D3CE0", VA = "0x1826D50E0")]
		public Act1VHalfIdleStuffDepotMainView()
		{
		}

		// Token: 0x0403DFFC RID: 253948
		[Token(Token = "0x403DFFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleStuffDepotItemListAdapter _adapter;

		// Token: 0x0403DFFD RID: 253949
		[Token(Token = "0x403DFFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DFFF RID: 253951
		[Token(Token = "0x403DFFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403E000 RID: 253952
		[Token(Token = "0x403E000")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403E001 RID: 253953
		[Token(Token = "0x403E001")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E002 RID: 253954
		[Token(Token = "0x403E002")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
