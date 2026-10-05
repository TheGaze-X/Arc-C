using System;
using Il2CppDummyDll;
using Torappu.UI.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E94 RID: 20116
	[Token(Token = "0x2004E94")]
	public class FifthAnnivExploreCarouselItem : UICommonCarouselItem
	{
		// Token: 0x0601E037 RID: 122935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E037")]
		[Address(RVA = "0x17B3AE0", Offset = "0x17B26E0", VA = "0x1817B3AE0")]
		public void Render(FifthAnnivExploreCarouselViewModel.Item viewModel)
		{
		}

		// Token: 0x0601E038 RID: 122936 RVA: 0x000AD2E0 File Offset: 0x000AB4E0
		[Token(Token = "0x601E038")]
		[Address(RVA = "0x17B3A40", Offset = "0x17B2640", VA = "0x1817B3A40", Slot = "4")]
		public override float GetWidth()
		{
			return 0f;
		}

		// Token: 0x0601E039 RID: 122937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E039")]
		[Address(RVA = "0x17B3C50", Offset = "0x17B2850", VA = "0x1817B3C50")]
		public FifthAnnivExploreCarouselItem()
		{
		}

		// Token: 0x04027E52 RID: 163410
		[Token(Token = "0x4027E52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _isNew;

		// Token: 0x04027E53 RID: 163411
		[Token(Token = "0x4027E53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _carouselText;

		// Token: 0x04027E54 RID: 163412
		[Token(Token = "0x4027E54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _isNewLength;

		// Token: 0x04027E55 RID: 163413
		[Token(Token = "0x4027E55")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _baseLength;

		// Token: 0x04027E56 RID: 163414
		[Token(Token = "0x4027E56")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerator m_textGenerator;

		// Token: 0x04027E57 RID: 163415
		[Token(Token = "0x4027E57")]
		[FieldOffset(Offset = "0x38")]
		private FifthAnnivExploreCarouselViewModel.Item m_item;

		// Token: 0x04027E58 RID: 163416
		[Token(Token = "0x4027E58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027E59 RID: 163417
		[Token(Token = "0x4027E59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWidth;

		// Token: 0x04027E5A RID: 163418
		[Token(Token = "0x4027E5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
