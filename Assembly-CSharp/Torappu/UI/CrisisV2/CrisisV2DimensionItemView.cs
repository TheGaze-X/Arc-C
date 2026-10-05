using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A1 RID: 22945
	[Token(Token = "0x20059A1")]
	public class CrisisV2DimensionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021726 RID: 136998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021726")]
		[Address(RVA = "0x1BBF2C0", Offset = "0x1BBDEC0", VA = "0x181BBF2C0")]
		public void Render(int dimension, int score)
		{
		}

		// Token: 0x06021727 RID: 136999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021727")]
		[Address(RVA = "0x1BBF440", Offset = "0x1BBE040", VA = "0x181BBF440")]
		public CrisisV2DimensionItemView()
		{
		}

		// Token: 0x0402DA52 RID: 186962
		[Token(Token = "0x402DA52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgDimension;

		// Token: 0x0402DA53 RID: 186963
		[Token(Token = "0x402DA53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _dimensionAtlas;

		// Token: 0x0402DA54 RID: 186964
		[Token(Token = "0x402DA54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0402DA55 RID: 186965
		[Token(Token = "0x402DA55")]
		private const string DIMENSION_SQUARE_ICON_NAME = "icon_dimension_square_{0}";

		// Token: 0x0402DA56 RID: 186966
		[Token(Token = "0x402DA56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DA57 RID: 186967
		[Token(Token = "0x402DA57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
