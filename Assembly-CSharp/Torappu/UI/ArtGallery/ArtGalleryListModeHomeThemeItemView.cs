using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006610 RID: 26128
	[Token(Token = "0x2006610")]
	public class ArtGalleryListModeHomeThemeItemView : ArtGalleryListModeItemViewBase
	{
		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x06025884 RID: 153732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058A6")]
		protected override IArtGalleryDisplayItemViewModel displayItemViewModel
		{
			[Token(Token = "0x6025884")]
			[Address(RVA = "0x2084E60", Offset = "0x2083A60", VA = "0x182084E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025885 RID: 153733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025885")]
		[Address(RVA = "0x2084B50", Offset = "0x2083750", VA = "0x182084B50", Slot = "5")]
		public override void Render(IArtGalleryDisplayItemViewModel artGalleryDisplayItemViewModel)
		{
		}

		// Token: 0x06025886 RID: 153734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025886")]
		[Address(RVA = "0x2084DC0", Offset = "0x20839C0", VA = "0x182084DC0")]
		public ArtGalleryListModeHomeThemeItemView()
		{
		}

		// Token: 0x04034B90 RID: 215952
		[Token(Token = "0x4034B90")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034B91 RID: 215953
		[Token(Token = "0x4034B91")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04034B92 RID: 215954
		[Token(Token = "0x4034B92")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x04034B93 RID: 215955
		[Token(Token = "0x4034B93")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCurSelect;

		// Token: 0x04034B94 RID: 215956
		[Token(Token = "0x4034B94")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelMultiForm;

		// Token: 0x04034B95 RID: 215957
		[Token(Token = "0x4034B95")]
		[FieldOffset(Offset = "0x60")]
		private ArtGalleryDisplayHomeThemeItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B96 RID: 215958
		[Token(Token = "0x4034B96")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034B97 RID: 215959
		[Token(Token = "0x4034B97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayItemViewModel;

		// Token: 0x04034B98 RID: 215960
		[Token(Token = "0x4034B98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034B99 RID: 215961
		[Token(Token = "0x4034B99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
