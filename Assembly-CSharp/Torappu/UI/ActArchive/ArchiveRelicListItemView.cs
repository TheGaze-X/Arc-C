using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C08 RID: 27656
	[Token(Token = "0x2006C08")]
	public class ArchiveRelicListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x060277DC RID: 161756 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277DD RID: 161757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D33")]
		public ArchiveRelicController controller
		{
			[Token(Token = "0x60277DC")]
			[Address(RVA = "0x22B0A40", Offset = "0x22AF640", VA = "0x1822B0A40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277DD")]
			[Address(RVA = "0x22B0AB0", Offset = "0x22AF6B0", VA = "0x1822B0AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060277DE RID: 161758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277DE")]
		[Address(RVA = "0x22B0820", Offset = "0x22AF420", VA = "0x1822B0820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060277DF RID: 161759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277DF")]
		[Address(RVA = "0x22B02B0", Offset = "0x22AEEB0", VA = "0x1822B02B0")]
		public void OnRelicItemClicked()
		{
		}

		// Token: 0x060277E0 RID: 161760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277E0")]
		[Address(RVA = "0x22B03A0", Offset = "0x22AEFA0", VA = "0x1822B03A0")]
		public void Render(RelicItemModel itemModel, string selectItemId = "", bool showAnim = false)
		{
		}

		// Token: 0x060277E1 RID: 161761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277E1")]
		[Address(RVA = "0x22B09C0", Offset = "0x22AF5C0", VA = "0x1822B09C0")]
		public ArchiveRelicListItemView()
		{
		}

		// Token: 0x04037FAA RID: 229290
		[Token(Token = "0x4037FAA")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly Color UNATTAIN_COLOR;

		// Token: 0x04037FAB RID: 229291
		[Token(Token = "0x4037FAB")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public static readonly Color ATTAIN_COLOR;

		// Token: 0x04037FAC RID: 229292
		[Token(Token = "0x4037FAC")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public static readonly Color LOCKED_COLOR;

		// Token: 0x04037FAD RID: 229293
		[Token(Token = "0x4037FAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04037FAE RID: 229294
		[Token(Token = "0x4037FAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04037FAF RID: 229295
		[Token(Token = "0x4037FAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04037FB0 RID: 229296
		[Token(Token = "0x4037FB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroupSelected;

		// Token: 0x04037FB1 RID: 229297
		[Token(Token = "0x4037FB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04037FB2 RID: 229298
		[Token(Token = "0x4037FB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNormalBg;

		// Token: 0x04037FB3 RID: 229299
		[Token(Token = "0x4037FB3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSpBg;

		// Token: 0x04037FB4 RID: 229300
		[Token(Token = "0x4037FB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04037FB5 RID: 229301
		[Token(Token = "0x4037FB5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _button;

		// Token: 0x04037FB6 RID: 229302
		[Token(Token = "0x4037FB6")]
		[FieldOffset(Offset = "0x60")]
		private RelicItemModel m_cachedModel;

		// Token: 0x04037FB7 RID: 229303
		[Token(Token = "0x4037FB7")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04037FB8 RID: 229304
		[Token(Token = "0x4037FB8")]
		[FieldOffset(Offset = "0x70")]
		private ArchiveRelicListItemView.ArchiveRelicListItemSwitchTween m_switchTween;

		// Token: 0x04037FBA RID: 229306
		[Token(Token = "0x4037FBA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037FBB RID: 229307
		[Token(Token = "0x4037FBB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037FBC RID: 229308
		[Token(Token = "0x4037FBC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037FBD RID: 229309
		[Token(Token = "0x4037FBD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRelicItemClicked;

		// Token: 0x04037FBE RID: 229310
		[Token(Token = "0x4037FBE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037FBF RID: 229311
		[Token(Token = "0x4037FBF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C09 RID: 27657
		[Token(Token = "0x2006C09")]
		private class ArchiveRelicListItemSwitchTween : UISwitchTween
		{
			// Token: 0x060277E3 RID: 161763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60277E3")]
			[Address(RVA = "0x22B0230", Offset = "0x22AEE30", VA = "0x1822B0230")]
			public ArchiveRelicListItemSwitchTween(ArchiveRelicListItemView closure)
			{
			}

			// Token: 0x060277E4 RID: 161764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60277E4")]
			[Address(RVA = "0x22AFEC0", Offset = "0x22AEAC0", VA = "0x1822AFEC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060277E5 RID: 161765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60277E5")]
			[Address(RVA = "0x22AFFD0", Offset = "0x22AEBD0", VA = "0x1822AFFD0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060277E6 RID: 161766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60277E6")]
			[Address(RVA = "0x22B0130", Offset = "0x22AED30", VA = "0x1822B0130", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060277E7 RID: 161767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60277E7")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04037FC0 RID: 229312
			[Token(Token = "0x4037FC0")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveRelicListItemView m_closure;

			// Token: 0x04037FC1 RID: 229313
			[Token(Token = "0x4037FC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037FC2 RID: 229314
			[Token(Token = "0x4037FC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037FC3 RID: 229315
			[Token(Token = "0x4037FC3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037FC4 RID: 229316
			[Token(Token = "0x4037FC4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
