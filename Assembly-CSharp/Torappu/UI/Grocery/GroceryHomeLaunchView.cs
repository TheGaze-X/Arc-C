using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CB0 RID: 19632
	[Token(Token = "0x2004CB0")]
	public class GroceryHomeLaunchView : DataBinder<GroceryHomeProperty>, IHotfixable
	{
		// Token: 0x0601D6BF RID: 120511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BF")]
		[Address(RVA = "0x16F5E40", Offset = "0x16F4A40", VA = "0x1816F5E40", Slot = "7")]
		public override void OnValueChanged(GroceryHomeProperty property)
		{
		}

		// Token: 0x0601D6C0 RID: 120512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C0")]
		[Address(RVA = "0x16F5D70", Offset = "0x16F4970", VA = "0x1816F5D70")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x0601D6C1 RID: 120513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C1")]
		[Address(RVA = "0x16F5F50", Offset = "0x16F4B50", VA = "0x1816F5F50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D6C2 RID: 120514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C2")]
		[Address(RVA = "0x16F61B0", Offset = "0x16F4DB0", VA = "0x1816F61B0")]
		public GroceryHomeLaunchView()
		{
		}

		// Token: 0x04026C16 RID: 158742
		[Token(Token = "0x4026C16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04026C17 RID: 158743
		[Token(Token = "0x4026C17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _contentGoodGroup;

		// Token: 0x04026C18 RID: 158744
		[Token(Token = "0x4026C18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04026C19 RID: 158745
		[Token(Token = "0x4026C19")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04026C1A RID: 158746
		[Token(Token = "0x4026C1A")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04026C1B RID: 158747
		[Token(Token = "0x4026C1B")]
		[FieldOffset(Offset = "0x48")]
		private List<GroceryHomeLaunchPanelGoodGroupModel> m_cachedGroupList;

		// Token: 0x04026C1C RID: 158748
		[Token(Token = "0x4026C1C")]
		[FieldOffset(Offset = "0x50")]
		private GroceryHomeLaunchView.Adapter m_adapter;

		// Token: 0x04026C1D RID: 158749
		[Token(Token = "0x4026C1D")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026C1E RID: 158750
		[Token(Token = "0x4026C1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026C1F RID: 158751
		[Token(Token = "0x4026C1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x04026C20 RID: 158752
		[Token(Token = "0x4026C20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026C21 RID: 158753
		[Token(Token = "0x4026C21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CB1 RID: 19633
		[Token(Token = "0x2004CB1")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D6C3 RID: 120515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6C3")]
			[Address(RVA = "0x16F4560", Offset = "0x16F3160", VA = "0x1816F4560")]
			public Adapter(GroceryHomeLaunchView closure)
			{
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0601D6C4 RID: 120516 RVA: 0x000AB678 File Offset: 0x000A9878
			[Token(Token = "0x17004502")]
			public override int count
			{
				[Token(Token = "0x601D6C4")]
				[Address(RVA = "0x16F45E0", Offset = "0x16F31E0", VA = "0x1816F45E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D6C5 RID: 120517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D6C5")]
			[Address(RVA = "0x16F43B0", Offset = "0x16F2FB0", VA = "0x1816F43B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026C22 RID: 158754
			[Token(Token = "0x4026C22")]
			[FieldOffset(Offset = "0x20")]
			private GroceryHomeLaunchView m_closure;

			// Token: 0x04026C23 RID: 158755
			[Token(Token = "0x4026C23")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026C24 RID: 158756
			[Token(Token = "0x4026C24")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026C25 RID: 158757
			[Token(Token = "0x4026C25")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
