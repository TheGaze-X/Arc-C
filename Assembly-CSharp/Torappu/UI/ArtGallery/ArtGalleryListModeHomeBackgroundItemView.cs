using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200660F RID: 26127
	[Token(Token = "0x200660F")]
	public class ArtGalleryListModeHomeBackgroundItemView : ArtGalleryListModeItemViewBase
	{
		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x06025881 RID: 153729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058A5")]
		protected override IArtGalleryDisplayItemViewModel displayItemViewModel
		{
			[Token(Token = "0x6025881")]
			[Address(RVA = "0x2084A80", Offset = "0x2083680", VA = "0x182084A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025882 RID: 153730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025882")]
		[Address(RVA = "0x2084780", Offset = "0x2083380", VA = "0x182084780", Slot = "5")]
		public override void Render(IArtGalleryDisplayItemViewModel artGalleryDisplayItemViewModel)
		{
		}

		// Token: 0x06025883 RID: 153731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025883")]
		[Address(RVA = "0x20849E0", Offset = "0x20835E0", VA = "0x1820849E0")]
		public ArtGalleryListModeHomeBackgroundItemView()
		{
		}

		// Token: 0x04034B85 RID: 215941
		[Token(Token = "0x4034B85")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034B86 RID: 215942
		[Token(Token = "0x4034B86")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04034B87 RID: 215943
		[Token(Token = "0x4034B87")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x04034B88 RID: 215944
		[Token(Token = "0x4034B88")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCurSelect;

		// Token: 0x04034B89 RID: 215945
		[Token(Token = "0x4034B89")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelMultiForm;

		// Token: 0x04034B8A RID: 215946
		[Token(Token = "0x4034B8A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelMusic;

		// Token: 0x04034B8B RID: 215947
		[Token(Token = "0x4034B8B")]
		[FieldOffset(Offset = "0x68")]
		private ArtGalleryDisplayHomeBackgroundItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B8C RID: 215948
		[Token(Token = "0x4034B8C")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034B8D RID: 215949
		[Token(Token = "0x4034B8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayItemViewModel;

		// Token: 0x04034B8E RID: 215950
		[Token(Token = "0x4034B8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034B8F RID: 215951
		[Token(Token = "0x4034B8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
