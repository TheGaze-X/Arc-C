using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F0 RID: 18928
	[Token(Token = "0x20049F0")]
	public class InformantMilestonePointItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C7FE RID: 116734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FE")]
		[Address(RVA = "0x15FF1B0", Offset = "0x15FDDB0", VA = "0x1815FF1B0")]
		public void Render(int count)
		{
		}

		// Token: 0x0601C7FF RID: 116735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FF")]
		[Address(RVA = "0x15FF3A0", Offset = "0x15FDFA0", VA = "0x1815FF3A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C800 RID: 116736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C800")]
		[Address(RVA = "0x15FF4C0", Offset = "0x15FE0C0", VA = "0x1815FF4C0")]
		public InformantMilestonePointItemView()
		{
		}

		// Token: 0x0402555E RID: 152926
		[Token(Token = "0x402555E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _digitItemList;

		// Token: 0x0402555F RID: 152927
		[Token(Token = "0x402555F")]
		[FieldOffset(Offset = "0x20")]
		private InformantMilestonePointItemView.ItemListAdapter m_digitItemListAdapter;

		// Token: 0x04025560 RID: 152928
		[Token(Token = "0x4025560")]
		[FieldOffset(Offset = "0x28")]
		private List<int> m_digitList;

		// Token: 0x04025561 RID: 152929
		[Token(Token = "0x4025561")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04025562 RID: 152930
		[Token(Token = "0x4025562")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025563 RID: 152931
		[Token(Token = "0x4025563")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025564 RID: 152932
		[Token(Token = "0x4025564")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049F1 RID: 18929
		[Token(Token = "0x20049F1")]
		private class ItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601C801 RID: 116737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C801")]
			[Address(RVA = "0x16027F0", Offset = "0x16013F0", VA = "0x1816027F0")]
			public ItemListAdapter(InformantMilestonePointItemView closure)
			{
			}

			// Token: 0x1700436B RID: 17259
			// (get) Token: 0x0601C802 RID: 116738 RVA: 0x000A8918 File Offset: 0x000A6B18
			[Token(Token = "0x1700436B")]
			public override int count
			{
				[Token(Token = "0x601C802")]
				[Address(RVA = "0x1602870", Offset = "0x1601470", VA = "0x181602870", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C803 RID: 116739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C803")]
			[Address(RVA = "0x16025A0", Offset = "0x16011A0", VA = "0x1816025A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025565 RID: 152933
			[Token(Token = "0x4025565")]
			[FieldOffset(Offset = "0x20")]
			private InformantMilestonePointItemView m_closure;

			// Token: 0x04025566 RID: 152934
			[Token(Token = "0x4025566")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025567 RID: 152935
			[Token(Token = "0x4025567")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025568 RID: 152936
			[Token(Token = "0x4025568")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
