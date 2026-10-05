using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004739 RID: 18233
	[Token(Token = "0x2004739")]
	public class RecruitAttainDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA1F RID: 113183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1F")]
		[Address(RVA = "0x14F4610", Offset = "0x14F3210", VA = "0x1814F4610")]
		public void Render(string poolId, GachaDetailData.GachaAvailChar availChar, string param)
		{
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA20")]
		[Address(RVA = "0x14F4CC0", Offset = "0x14F38C0", VA = "0x1814F4CC0")]
		public RecruitAttainDetailView()
		{
		}

		// Token: 0x04023D57 RID: 146775
		[Token(Token = "0x4023D57")]
		private const float PREFERED_HEIGHT_1 = 260f;

		// Token: 0x04023D58 RID: 146776
		[Token(Token = "0x4023D58")]
		private const float PREFERED_HEIGHT_2 = 490f;

		// Token: 0x04023D59 RID: 146777
		[Token(Token = "0x4023D59")]
		private const float VIEW_PORT_Y_1 = 235f;

		// Token: 0x04023D5A RID: 146778
		[Token(Token = "0x4023D5A")]
		private const float VIEW_PORT_Y_2 = 458f;

		// Token: 0x04023D5B RID: 146779
		[Token(Token = "0x4023D5B")]
		private const int NORMAL_BOTTOM = 0;

		// Token: 0x04023D5C RID: 146780
		[Token(Token = "0x4023D5C")]
		private const int MULTILINE_BOTTOM = 45;

		// Token: 0x04023D5D RID: 146781
		[Token(Token = "0x4023D5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _starSprite;

		// Token: 0x04023D5E RID: 146782
		[Token(Token = "0x4023D5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTotal;

		// Token: 0x04023D5F RID: 146783
		[Token(Token = "0x4023D5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle1;

		// Token: 0x04023D60 RID: 146784
		[Token(Token = "0x4023D60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle2;

		// Token: 0x04023D61 RID: 146785
		[Token(Token = "0x4023D61")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RecruitAttainItemAdapter _adapter;

		// Token: 0x04023D62 RID: 146786
		[Token(Token = "0x4023D62")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LayoutElement _element;

		// Token: 0x04023D63 RID: 146787
		[Token(Token = "0x4023D63")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x04023D64 RID: 146788
		[Token(Token = "0x4023D64")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Graphic _scrollViewBg;

		// Token: 0x04023D65 RID: 146789
		[Token(Token = "0x4023D65")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelImgBlack;

		// Token: 0x04023D66 RID: 146790
		[Token(Token = "0x4023D66")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GridLayoutGroup _attainCharLayout;

		// Token: 0x04023D67 RID: 146791
		[Token(Token = "0x4023D67")]
		[FieldOffset(Offset = "0x68")]
		private List<string> m_attainCharList;

		// Token: 0x04023D68 RID: 146792
		[Token(Token = "0x4023D68")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_charIdList;

		// Token: 0x04023D69 RID: 146793
		[Token(Token = "0x4023D69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D6A RID: 146794
		[Token(Token = "0x4023D6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
