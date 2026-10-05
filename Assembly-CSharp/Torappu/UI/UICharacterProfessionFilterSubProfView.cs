using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200351B RID: 13595
	[Token(Token = "0x200351B")]
	public class UICharacterProfessionFilterSubProfView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015ACC RID: 88780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACC")]
		[Address(RVA = "0xE40810", Offset = "0xE3F410", VA = "0x180E40810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015ACD RID: 88781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACD")]
		[Address(RVA = "0xE404D0", Offset = "0xE3F0D0", VA = "0x180E404D0")]
		public void Render(UICharacterProfessionFilterViewModel model, bool isOpen)
		{
		}

		// Token: 0x06015ACE RID: 88782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACE")]
		[Address(RVA = "0xE409A0", Offset = "0xE3F5A0", VA = "0x180E409A0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x06015ACF RID: 88783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACF")]
		[Address(RVA = "0xE40B80", Offset = "0xE3F780", VA = "0x180E40B80")]
		public UICharacterProfessionFilterSubProfView()
		{
		}

		// Token: 0x0401A03D RID: 106557
		[Token(Token = "0x401A03D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterProfessionFilterSubProfItem _allItem;

		// Token: 0x0401A03E RID: 106558
		[Token(Token = "0x401A03E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401A03F RID: 106559
		[Token(Token = "0x401A03F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401A040 RID: 106560
		[Token(Token = "0x401A040")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public ILoadAsset assetLoader;

		// Token: 0x0401A041 RID: 106561
		[Token(Token = "0x401A041")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<string, bool> onSubProfessionClick;

		// Token: 0x0401A042 RID: 106562
		[Token(Token = "0x401A042")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401A043 RID: 106563
		[Token(Token = "0x401A043")]
		[FieldOffset(Offset = "0x41")]
		private bool m_isOpen;

		// Token: 0x0401A044 RID: 106564
		[Token(Token = "0x401A044")]
		[FieldOffset(Offset = "0x44")]
		private ProfessionCategory m_prof;

		// Token: 0x0401A045 RID: 106565
		[Token(Token = "0x401A045")]
		[FieldOffset(Offset = "0x48")]
		private UICharacterProfessionFilterSubProfView.Adapter m_adapter;

		// Token: 0x0401A046 RID: 106566
		[Token(Token = "0x401A046")]
		[FieldOffset(Offset = "0x50")]
		private UICharacterProfessionFilterViewModel m_cachedModel;

		// Token: 0x0401A047 RID: 106567
		[Token(Token = "0x401A047")]
		[FieldOffset(Offset = "0x58")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0401A048 RID: 106568
		[Token(Token = "0x401A048")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A049 RID: 106569
		[Token(Token = "0x401A049")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A04A RID: 106570
		[Token(Token = "0x401A04A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x0401A04B RID: 106571
		[Token(Token = "0x401A04B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200351C RID: 13596
		[Token(Token = "0x200351C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06015AD0 RID: 88784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015AD0")]
			[Address(RVA = "0xE2BCF0", Offset = "0xE2A8F0", VA = "0x180E2BCF0")]
			public Adapter(UICharacterProfessionFilterSubProfView closure)
			{
			}

			// Token: 0x1700337F RID: 13183
			// (get) Token: 0x06015AD1 RID: 88785 RVA: 0x0008D660 File Offset: 0x0008B860
			[Token(Token = "0x1700337F")]
			public override int count
			{
				[Token(Token = "0x6015AD1")]
				[Address(RVA = "0xE2BDF0", Offset = "0xE2A9F0", VA = "0x180E2BDF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015AD2 RID: 88786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015AD2")]
			[Address(RVA = "0xE2BA80", Offset = "0xE2A680", VA = "0x180E2BA80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401A04C RID: 106572
			[Token(Token = "0x401A04C")]
			[FieldOffset(Offset = "0x20")]
			private UICharacterProfessionFilterSubProfView m_closure;

			// Token: 0x0401A04D RID: 106573
			[Token(Token = "0x401A04D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A04E RID: 106574
			[Token(Token = "0x401A04E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401A04F RID: 106575
			[Token(Token = "0x401A04F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200351D RID: 13597
		[Token(Token = "0x200351D")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06015AD3 RID: 88787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015AD3")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(UICharacterProfessionFilterSubProfView closure)
			{
			}

			// Token: 0x06015AD4 RID: 88788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015AD4")]
			[Address(RVA = "0xE39640", Offset = "0xE38240", VA = "0x180E39640", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401A050 RID: 106576
			[Token(Token = "0x401A050")]
			[FieldOffset(Offset = "0x10")]
			private UICharacterProfessionFilterSubProfView m_closure;
		}
	}
}
