using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077B6 RID: 30646
	[Token(Token = "0x20077B6")]
	public class Act1VHalfIdleIncomeGraphView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B059 RID: 176217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B059")]
		[Address(RVA = "0x26D2EE0", Offset = "0x26D1AE0", VA = "0x1826D2EE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B05A RID: 176218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B05A")]
		[Address(RVA = "0x26D2CF0", Offset = "0x26D18F0", VA = "0x1826D2CF0")]
		public void Render(Act1VHalfIdleIncomeGraphViewModel viewModel)
		{
		}

		// Token: 0x0602B05B RID: 176219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B05B")]
		[Address(RVA = "0x26D3000", Offset = "0x26D1C00", VA = "0x1826D3000")]
		public Act1VHalfIdleIncomeGraphView()
		{
		}

		// Token: 0x0403E1D5 RID: 254421
		[Token(Token = "0x403E1D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x0403E1D6 RID: 254422
		[Token(Token = "0x403E1D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unitTextObj;

		// Token: 0x0403E1D7 RID: 254423
		[Token(Token = "0x403E1D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _backDecoObj;

		// Token: 0x0403E1D8 RID: 254424
		[Token(Token = "0x403E1D8")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403E1D9 RID: 254425
		[Token(Token = "0x403E1D9")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdleIncomeGraphViewModel m_graphViewModel;

		// Token: 0x0403E1DA RID: 254426
		[Token(Token = "0x403E1DA")]
		[FieldOffset(Offset = "0x40")]
		private Act1VHalfIdleIncomeGraphView.ItemAdapter m_itemAdapter;

		// Token: 0x0403E1DB RID: 254427
		[Token(Token = "0x403E1DB")]
		[FieldOffset(Offset = "0x48")]
		public int m_cacheCompareAnimSeqNum;

		// Token: 0x0403E1DC RID: 254428
		[Token(Token = "0x403E1DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E1DD RID: 254429
		[Token(Token = "0x403E1DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E1DE RID: 254430
		[Token(Token = "0x403E1DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077B7 RID: 30647
		[Token(Token = "0x20077B7")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B05C RID: 176220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B05C")]
			[Address(RVA = "0x26D7610", Offset = "0x26D6210", VA = "0x1826D7610")]
			public ItemAdapter(Act1VHalfIdleIncomeGraphView view)
			{
			}

			// Token: 0x170064C7 RID: 25799
			// (get) Token: 0x0602B05D RID: 176221 RVA: 0x000DAA00 File Offset: 0x000D8C00
			[Token(Token = "0x170064C7")]
			public override int count
			{
				[Token(Token = "0x602B05D")]
				[Address(RVA = "0x26D7690", Offset = "0x26D6290", VA = "0x1826D7690", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B05E RID: 176222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B05E")]
			[Address(RVA = "0x26D7350", Offset = "0x26D5F50", VA = "0x1826D7350", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E1DF RID: 254431
			[Token(Token = "0x403E1DF")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleIncomeGraphView m_view;

			// Token: 0x0403E1E0 RID: 254432
			[Token(Token = "0x403E1E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E1E1 RID: 254433
			[Token(Token = "0x403E1E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E1E2 RID: 254434
			[Token(Token = "0x403E1E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
