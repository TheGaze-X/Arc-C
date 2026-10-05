using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C4A RID: 27722
	[Token(Token = "0x2006C4A")]
	public class ArchiveTotemListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x0602791D RID: 162077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602791E RID: 162078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D7D")]
		public ArchiveTotemController controller
		{
			[Token(Token = "0x602791D")]
			[Address(RVA = "0x22C2DE0", Offset = "0x22C19E0", VA = "0x1822C2DE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602791E")]
			[Address(RVA = "0x22C2E50", Offset = "0x22C1A50", VA = "0x1822C2E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602791F RID: 162079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602791F")]
		[Address(RVA = "0x22C2760", Offset = "0x22C1360", VA = "0x1822C2760")]
		public void ItemClickEvent()
		{
		}

		// Token: 0x06027920 RID: 162080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027920")]
		[Address(RVA = "0x22C2860", Offset = "0x22C1460", VA = "0x1822C2860")]
		public void Render(TotemItemModel model, string selectedItem, bool showSwitchAnim)
		{
		}

		// Token: 0x06027921 RID: 162081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027921")]
		[Address(RVA = "0x22C2BD0", Offset = "0x22C17D0", VA = "0x1822C2BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027922 RID: 162082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027922")]
		[Address(RVA = "0x22C2D60", Offset = "0x22C1960", VA = "0x1822C2D60")]
		public ArchiveTotemListItemView()
		{
		}

		// Token: 0x040381D2 RID: 229842
		[Token(Token = "0x40381D2")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly Color ATTAINED_COLOR;

		// Token: 0x040381D3 RID: 229843
		[Token(Token = "0x40381D3")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public static readonly Color UNATTAINED_COLOR;

		// Token: 0x040381D4 RID: 229844
		[Token(Token = "0x40381D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040381D5 RID: 229845
		[Token(Token = "0x40381D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x040381D6 RID: 229846
		[Token(Token = "0x40381D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x040381D7 RID: 229847
		[Token(Token = "0x40381D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x040381D8 RID: 229848
		[Token(Token = "0x40381D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x040381D9 RID: 229849
		[Token(Token = "0x40381D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _button;

		// Token: 0x040381DA RID: 229850
		[Token(Token = "0x40381DA")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040381DB RID: 229851
		[Token(Token = "0x40381DB")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveTotemListItemView.ArchiveTotemListItemSwitchTween m_switchTween;

		// Token: 0x040381DC RID: 229852
		[Token(Token = "0x40381DC")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_finder;

		// Token: 0x040381DD RID: 229853
		[Token(Token = "0x40381DD")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedId;

		// Token: 0x040381DF RID: 229855
		[Token(Token = "0x40381DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040381E0 RID: 229856
		[Token(Token = "0x40381E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040381E1 RID: 229857
		[Token(Token = "0x40381E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ItemClickEvent;

		// Token: 0x040381E2 RID: 229858
		[Token(Token = "0x40381E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040381E3 RID: 229859
		[Token(Token = "0x40381E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040381E4 RID: 229860
		[Token(Token = "0x40381E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C4B RID: 27723
		[Token(Token = "0x2006C4B")]
		private class ArchiveTotemListItemSwitchTween : UISwitchTween
		{
			// Token: 0x06027924 RID: 162084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027924")]
			[Address(RVA = "0x22C26E0", Offset = "0x22C12E0", VA = "0x1822C26E0")]
			public ArchiveTotemListItemSwitchTween(ArchiveTotemListItemView closure)
			{
			}

			// Token: 0x06027925 RID: 162085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027925")]
			[Address(RVA = "0x22C23B0", Offset = "0x22C0FB0", VA = "0x1822C23B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06027926 RID: 162086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027926")]
			[Address(RVA = "0x22C24B0", Offset = "0x22C10B0", VA = "0x1822C24B0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06027927 RID: 162087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027927")]
			[Address(RVA = "0x22C2600", Offset = "0x22C1200", VA = "0x1822C2600", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06027928 RID: 162088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027928")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040381E5 RID: 229861
			[Token(Token = "0x40381E5")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveTotemListItemView m_closure;

			// Token: 0x040381E6 RID: 229862
			[Token(Token = "0x40381E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040381E7 RID: 229863
			[Token(Token = "0x40381E7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040381E8 RID: 229864
			[Token(Token = "0x40381E8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040381E9 RID: 229865
			[Token(Token = "0x40381E9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
