using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B21 RID: 27425
	[Token(Token = "0x2006B21")]
	public class ArchiveCapsuleListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x0602734B RID: 160587 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602734C RID: 160588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA6")]
		public ArchiveCapsuleController controller
		{
			[Token(Token = "0x602734B")]
			[Address(RVA = "0x2265170", Offset = "0x2263D70", VA = "0x182265170")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602734C")]
			[Address(RVA = "0x22651D0", Offset = "0x2263DD0", VA = "0x1822651D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602734D RID: 160589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602734D")]
		[Address(RVA = "0x2264FF0", Offset = "0x2263BF0", VA = "0x182264FF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602734E RID: 160590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602734E")]
		[Address(RVA = "0x2264CC0", Offset = "0x22638C0", VA = "0x182264CC0")]
		public void OnCapsuleItemClicked()
		{
		}

		// Token: 0x0602734F RID: 160591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602734F")]
		[Address(RVA = "0x2264DE0", Offset = "0x22639E0", VA = "0x182264DE0")]
		public void Render(CapsuleItemModel itemModel, Sprite itemIcon, string selectItemId = "")
		{
		}

		// Token: 0x06027350 RID: 160592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027350")]
		[Address(RVA = "0x2265110", Offset = "0x2263D10", VA = "0x182265110")]
		public ArchiveCapsuleListItemView()
		{
		}

		// Token: 0x04037787 RID: 227207
		[Token(Token = "0x4037787")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04037788 RID: 227208
		[Token(Token = "0x4037788")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04037789 RID: 227209
		[Token(Token = "0x4037789")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0403778A RID: 227210
		[Token(Token = "0x403778A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403778B RID: 227211
		[Token(Token = "0x403778B")]
		[FieldOffset(Offset = "0x38")]
		private CapsuleItemModel m_cachedModel;

		// Token: 0x0403778C RID: 227212
		[Token(Token = "0x403778C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403778D RID: 227213
		[Token(Token = "0x403778D")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveCapsuleListItemView.ArchiveCapsuleListItemSwitchTween m_switchTween;

		// Token: 0x0403778F RID: 227215
		[Token(Token = "0x403778F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037790 RID: 227216
		[Token(Token = "0x4037790")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037791 RID: 227217
		[Token(Token = "0x4037791")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037792 RID: 227218
		[Token(Token = "0x4037792")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCapsuleItemClicked;

		// Token: 0x04037793 RID: 227219
		[Token(Token = "0x4037793")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037794 RID: 227220
		[Token(Token = "0x4037794")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B22 RID: 27426
		[Token(Token = "0x2006B22")]
		private class ArchiveCapsuleListItemSwitchTween : UISwitchTween
		{
			// Token: 0x06027351 RID: 160593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027351")]
			[Address(RVA = "0x2264C40", Offset = "0x2263840", VA = "0x182264C40")]
			public ArchiveCapsuleListItemSwitchTween(ArchiveCapsuleListItemView closure)
			{
			}

			// Token: 0x06027352 RID: 160594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027352")]
			[Address(RVA = "0x22648E0", Offset = "0x22634E0", VA = "0x1822648E0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06027353 RID: 160595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027353")]
			[Address(RVA = "0x2264A60", Offset = "0x2263660", VA = "0x182264A60", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06027354 RID: 160596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027354")]
			[Address(RVA = "0x2264B80", Offset = "0x2263780", VA = "0x182264B80", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06027356 RID: 160598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027356")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04037795 RID: 227221
			[Token(Token = "0x4037795")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveCapsuleListItemView m_closure;

			// Token: 0x04037796 RID: 227222
			[Token(Token = "0x4037796")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037797 RID: 227223
			[Token(Token = "0x4037797")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037798 RID: 227224
			[Token(Token = "0x4037798")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037799 RID: 227225
			[Token(Token = "0x4037799")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
