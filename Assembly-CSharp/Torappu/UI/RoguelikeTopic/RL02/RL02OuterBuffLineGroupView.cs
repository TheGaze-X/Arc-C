using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004611 RID: 17937
	[Token(Token = "0x2004611")]
	public class RL02OuterBuffLineGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B438 RID: 111672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B438")]
		[Address(RVA = "0x14656E0", Offset = "0x14642E0", VA = "0x1814656E0")]
		public void OnInit()
		{
		}

		// Token: 0x0601B439 RID: 111673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B439")]
		[Address(RVA = "0x1465840", Offset = "0x1464440", VA = "0x181465840")]
		public void Render(List<RL02OuterBuffLineItemModel> viewModel)
		{
		}

		// Token: 0x0601B43A RID: 111674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B43A")]
		[Address(RVA = "0x14658C0", Offset = "0x14644C0", VA = "0x1814658C0")]
		public RL02OuterBuffLineGroupView()
		{
		}

		// Token: 0x040232E6 RID: 144102
		[Token(Token = "0x40232E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040232E7 RID: 144103
		[Token(Token = "0x40232E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL02OuterBuffLineItemView _prefabLineItem;

		// Token: 0x040232E8 RID: 144104
		[Token(Token = "0x40232E8")]
		[FieldOffset(Offset = "0x28")]
		private RL02OuterBuffLineGroupView.Adapter m_adapter;

		// Token: 0x040232E9 RID: 144105
		[Token(Token = "0x40232E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040232EA RID: 144106
		[Token(Token = "0x40232EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040232EB RID: 144107
		[Token(Token = "0x40232EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004612 RID: 17938
		[Token(Token = "0x2004612")]
		private class Adapter : IHotfixable
		{
			// Token: 0x0601B43B RID: 111675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B43B")]
			[Address(RVA = "0x145A600", Offset = "0x1459200", VA = "0x18145A600")]
			public Adapter(RL02OuterBuffLineGroupView closure)
			{
			}

			// Token: 0x0601B43C RID: 111676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B43C")]
			[Address(RVA = "0x145A180", Offset = "0x1458D80", VA = "0x18145A180")]
			public void RefreshView(List<RL02OuterBuffLineItemModel> viewModelList)
			{
			}

			// Token: 0x0601B43D RID: 111677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B43D")]
			[Address(RVA = "0x145A0D0", Offset = "0x1458CD0", VA = "0x18145A0D0")]
			private RL02OuterBuffLineItemView GetView(int position)
			{
				return null;
			}

			// Token: 0x0601B43E RID: 111678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B43E")]
			[Address(RVA = "0x145A400", Offset = "0x1459000", VA = "0x18145A400")]
			private void _UpdateViewInstance(int position, RL02OuterBuffLineItemView view)
			{
			}

			// Token: 0x040232EC RID: 144108
			[Token(Token = "0x40232EC")]
			[FieldOffset(Offset = "0x10")]
			private RL02OuterBuffLineGroupView m_closure;

			// Token: 0x040232ED RID: 144109
			[Token(Token = "0x40232ED")]
			[FieldOffset(Offset = "0x18")]
			private List<RL02OuterBuffLineItemView> m_views;

			// Token: 0x040232EE RID: 144110
			[Token(Token = "0x40232EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040232EF RID: 144111
			[Token(Token = "0x40232EF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x040232F0 RID: 144112
			[Token(Token = "0x40232F0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetView;

			// Token: 0x040232F1 RID: 144113
			[Token(Token = "0x40232F1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__UpdateViewInstance;
		}
	}
}
