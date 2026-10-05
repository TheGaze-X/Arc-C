using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039E8 RID: 14824
	[Token(Token = "0x20039E8")]
	public class UISimpleDropdownDialog : UICommonDropdownDialog, IHotfixable
	{
		// Token: 0x0601768E RID: 95886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601768E")]
		[Address(RVA = "0xFC5280", Offset = "0xFC3E80", VA = "0x180FC5280", Slot = "21")]
		protected override void OnDialogInit()
		{
		}

		// Token: 0x0601768F RID: 95887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601768F")]
		[Address(RVA = "0xFC54D0", Offset = "0xFC40D0", VA = "0x180FC54D0", Slot = "22")]
		protected override void OnDialogRender(UICommonDropdownDialog.InnerInput input)
		{
		}

		// Token: 0x06017690 RID: 95888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017690")]
		[Address(RVA = "0xFC56B0", Offset = "0xFC42B0", VA = "0x180FC56B0")]
		private void _FocusToItem(int targetIndex)
		{
		}

		// Token: 0x06017691 RID: 95889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017691")]
		[Address(RVA = "0xFC5980", Offset = "0xFC4580", VA = "0x180FC5980")]
		public UISimpleDropdownDialog()
		{
		}

		// Token: 0x06017692 RID: 95890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017692")]
		[Address(RVA = "0xFC0C20", Offset = "0xFBF820", VA = "0x180FC0C20")]
		private void <>xLuaBaseProxy_OnDialogInit()
		{
		}

		// Token: 0x0401C463 RID: 115811
		[Token(Token = "0x401C463")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401C464 RID: 115812
		[Token(Token = "0x401C464")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Focus")]
		private VerticalLayoutGroup _layout;

		// Token: 0x0401C465 RID: 115813
		[Token(Token = "0x401C465")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Focus")]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0401C466 RID: 115814
		[Token(Token = "0x401C466")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Focus")]
		private UILayoutDimensionListener _listener;

		// Token: 0x0401C467 RID: 115815
		[Token(Token = "0x401C467")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0401C468 RID: 115816
		[Token(Token = "0x401C468")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cachedFocusIndex;

		// Token: 0x0401C469 RID: 115817
		[Token(Token = "0x401C469")]
		[FieldOffset(Offset = "0xCC")]
		private float m_cachedItemHeight;

		// Token: 0x0401C46A RID: 115818
		[Token(Token = "0x401C46A")]
		[FieldOffset(Offset = "0xD0")]
		private UISimpleDropdownDialog.Adapter m_adapter;

		// Token: 0x0401C46B RID: 115819
		[Token(Token = "0x401C46B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDialogInit;

		// Token: 0x0401C46C RID: 115820
		[Token(Token = "0x401C46C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDialogRender;

		// Token: 0x0401C46D RID: 115821
		[Token(Token = "0x401C46D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FocusToItem;

		// Token: 0x0401C46E RID: 115822
		[Token(Token = "0x401C46E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039E9 RID: 14825
		[Token(Token = "0x20039E9")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06017693 RID: 95891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017693")]
			[Address(RVA = "0xFB0D70", Offset = "0xFAF970", VA = "0x180FB0D70")]
			public Adapter(UISimpleDropdownDialog closure)
			{
			}

			// Token: 0x17003811 RID: 14353
			// (get) Token: 0x06017694 RID: 95892 RVA: 0x00096570 File Offset: 0x00094770
			[Token(Token = "0x17003811")]
			public override int count
			{
				[Token(Token = "0x6017694")]
				[Address(RVA = "0xFB0DF0", Offset = "0xFAF9F0", VA = "0x180FB0DF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06017695 RID: 95893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017695")]
			[Address(RVA = "0xFB0A10", Offset = "0xFAF610", VA = "0x180FB0A10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401C46F RID: 115823
			[Token(Token = "0x401C46F")]
			[FieldOffset(Offset = "0x20")]
			private UISimpleDropdownDialog m_closure;

			// Token: 0x0401C470 RID: 115824
			[Token(Token = "0x401C470")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C471 RID: 115825
			[Token(Token = "0x401C471")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401C472 RID: 115826
			[Token(Token = "0x401C472")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020039EA RID: 14826
		[Token(Token = "0x20039EA")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06017696 RID: 95894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017696")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(UISimpleDropdownDialog closure)
			{
			}

			// Token: 0x06017697 RID: 95895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017697")]
			[Address(RVA = "0xFB1DD0", Offset = "0xFB09D0", VA = "0x180FB1DD0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401C473 RID: 115827
			[Token(Token = "0x401C473")]
			[FieldOffset(Offset = "0x10")]
			private UISimpleDropdownDialog m_closure;
		}
	}
}
