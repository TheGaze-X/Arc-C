using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B36 RID: 27446
	[Token(Token = "0x2006B36")]
	public class ArchiveChaosListItemView : MonoBehaviour
	{
		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x060273BF RID: 160703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273C0 RID: 160704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB7")]
		public ArchiveChaosController controller
		{
			[Token(Token = "0x60273BF")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273C0")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060273C1 RID: 160705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273C1")]
		[Address(RVA = "0x2269760", Offset = "0x2268360", VA = "0x182269760")]
		public void ItemClickEvent()
		{
		}

		// Token: 0x060273C2 RID: 160706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273C2")]
		[Address(RVA = "0x2269800", Offset = "0x2268400", VA = "0x182269800")]
		public void Render(ChaosItemModel model, string selectedItemId, bool showSwitchAnim)
		{
		}

		// Token: 0x060273C3 RID: 160707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273C3")]
		[Address(RVA = "0x2269AB0", Offset = "0x22686B0", VA = "0x182269AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060273C4 RID: 160708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273C4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ArchiveChaosListItemView()
		{
		}

		// Token: 0x04037835 RID: 227381
		[Token(Token = "0x4037835")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ATTAINED_COLOR;

		// Token: 0x04037836 RID: 227382
		[Token(Token = "0x4037836")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color UNATTAINED_COLOR;

		// Token: 0x04037837 RID: 227383
		[Token(Token = "0x4037837")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x04037838 RID: 227384
		[Token(Token = "0x4037838")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x04037839 RID: 227385
		[Token(Token = "0x4037839")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0403783A RID: 227386
		[Token(Token = "0x403783A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _button;

		// Token: 0x0403783B RID: 227387
		[Token(Token = "0x403783B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403783C RID: 227388
		[Token(Token = "0x403783C")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveChaosListItemView.ArchiveChaosListItemSwitchTween m_switchTween;

		// Token: 0x0403783D RID: 227389
		[Token(Token = "0x403783D")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedId;

		// Token: 0x02006B37 RID: 27447
		[Token(Token = "0x2006B37")]
		private class ArchiveChaosListItemSwitchTween : UISwitchTween
		{
			// Token: 0x060273C6 RID: 160710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60273C6")]
			[Address(RVA = "0x22696E0", Offset = "0x22682E0", VA = "0x1822696E0")]
			public ArchiveChaosListItemSwitchTween(ArchiveChaosListItemView closure)
			{
			}

			// Token: 0x060273C7 RID: 160711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60273C7")]
			[Address(RVA = "0x22693B0", Offset = "0x2267FB0", VA = "0x1822693B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060273C8 RID: 160712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60273C8")]
			[Address(RVA = "0x22694B0", Offset = "0x22680B0", VA = "0x1822694B0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060273C9 RID: 160713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60273C9")]
			[Address(RVA = "0x2269600", Offset = "0x2268200", VA = "0x182269600", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060273CA RID: 160714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60273CA")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403783F RID: 227391
			[Token(Token = "0x403783F")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveChaosListItemView m_closure;

			// Token: 0x04037840 RID: 227392
			[Token(Token = "0x4037840")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037841 RID: 227393
			[Token(Token = "0x4037841")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037842 RID: 227394
			[Token(Token = "0x4037842")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037843 RID: 227395
			[Token(Token = "0x4037843")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
