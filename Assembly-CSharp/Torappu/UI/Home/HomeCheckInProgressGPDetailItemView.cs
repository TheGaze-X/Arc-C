using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE9 RID: 19433
	[Token(Token = "0x2004BE9")]
	public class HomeCheckInProgressGPDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D342 RID: 119618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D342")]
		[Address(RVA = "0x16C38B0", Offset = "0x16C24B0", VA = "0x1816C38B0")]
		public void Render(int index, ProgressCheckInItem model, int currCheckInDay)
		{
		}

		// Token: 0x0601D343 RID: 119619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D343")]
		[Address(RVA = "0x16C3B50", Offset = "0x16C2750", VA = "0x1816C3B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D344 RID: 119620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D344")]
		[Address(RVA = "0x16C3C70", Offset = "0x16C2870", VA = "0x1816C3C70")]
		public HomeCheckInProgressGPDetailItemView()
		{
		}

		// Token: 0x040265A2 RID: 157090
		[Token(Token = "0x40265A2")]
		private const float ALPHA_COMPLETE = 0.5f;

		// Token: 0x040265A3 RID: 157091
		[Token(Token = "0x40265A3")]
		private const float ALPHA_UNCOMPLETE = 1f;

		// Token: 0x040265A4 RID: 157092
		[Token(Token = "0x40265A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040265A5 RID: 157093
		[Token(Token = "0x40265A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDay;

		// Token: 0x040265A6 RID: 157094
		[Token(Token = "0x40265A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroupComplete;

		// Token: 0x040265A7 RID: 157095
		[Token(Token = "0x40265A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x040265A8 RID: 157096
		[Token(Token = "0x40265A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSplitLine;

		// Token: 0x040265A9 RID: 157097
		[Token(Token = "0x40265A9")]
		[FieldOffset(Offset = "0x40")]
		private HomeCheckInProgressGPDetailItemView.Adapter m_adapter;

		// Token: 0x040265AA RID: 157098
		[Token(Token = "0x40265AA")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040265AB RID: 157099
		[Token(Token = "0x40265AB")]
		[FieldOffset(Offset = "0x50")]
		private List<ISharedItemModel> m_rewardList;

		// Token: 0x040265AC RID: 157100
		[Token(Token = "0x40265AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040265AD RID: 157101
		[Token(Token = "0x40265AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040265AE RID: 157102
		[Token(Token = "0x40265AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BEA RID: 19434
		[Token(Token = "0x2004BEA")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D345 RID: 119621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D345")]
			[Address(RVA = "0x16B7120", Offset = "0x16B5D20", VA = "0x1816B7120")]
			public Adapter(HomeCheckInProgressGPDetailItemView closure)
			{
			}

			// Token: 0x170044AF RID: 17583
			// (get) Token: 0x0601D346 RID: 119622 RVA: 0x000AAE08 File Offset: 0x000A9008
			[Token(Token = "0x170044AF")]
			public override int count
			{
				[Token(Token = "0x601D346")]
				[Address(RVA = "0x16B76B0", Offset = "0x16B62B0", VA = "0x1816B76B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D347 RID: 119623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D347")]
			[Address(RVA = "0x16B62B0", Offset = "0x16B4EB0", VA = "0x1816B62B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040265AF RID: 157103
			[Token(Token = "0x40265AF")]
			[FieldOffset(Offset = "0x20")]
			private HomeCheckInProgressGPDetailItemView m_closure;

			// Token: 0x040265B0 RID: 157104
			[Token(Token = "0x40265B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040265B1 RID: 157105
			[Token(Token = "0x40265B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040265B2 RID: 157106
			[Token(Token = "0x40265B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
