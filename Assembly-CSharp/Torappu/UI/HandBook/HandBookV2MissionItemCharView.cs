using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006710 RID: 26384
	[Token(Token = "0x2006710")]
	public class HandBookV2MissionItemCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DCE RID: 155086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DCE")]
		[Address(RVA = "0x20E4C90", Offset = "0x20E3890", VA = "0x1820E4C90")]
		public void Render(int favorAvg, HandBookV2MissionListItemModel.CharacterFavorData characterFavorData)
		{
		}

		// Token: 0x06025DCF RID: 155087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DCF")]
		[Address(RVA = "0x20E4ED0", Offset = "0x20E3AD0", VA = "0x1820E4ED0")]
		public HandBookV2MissionItemCharView()
		{
		}

		// Token: 0x040353F0 RID: 218096
		[Token(Token = "0x40353F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalGo;

		// Token: 0x040353F1 RID: 218097
		[Token(Token = "0x40353F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040353F2 RID: 218098
		[Token(Token = "0x40353F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDisplayNumber;

		// Token: 0x040353F3 RID: 218099
		[Token(Token = "0x40353F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x040353F4 RID: 218100
		[Token(Token = "0x40353F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _greyGo;

		// Token: 0x040353F5 RID: 218101
		[Token(Token = "0x40353F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnknown;

		// Token: 0x040353F6 RID: 218102
		[Token(Token = "0x40353F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _sliderGo;

		// Token: 0x040353F7 RID: 218103
		[Token(Token = "0x40353F7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rtSlider;

		// Token: 0x040353F8 RID: 218104
		[Token(Token = "0x40353F8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _sliderMin;

		// Token: 0x040353F9 RID: 218105
		[Token(Token = "0x40353F9")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _sliderMax;

		// Token: 0x040353FA RID: 218106
		[Token(Token = "0x40353FA")]
		private const int FAVOR_MAX = 200;

		// Token: 0x040353FB RID: 218107
		[Token(Token = "0x40353FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040353FC RID: 218108
		[Token(Token = "0x40353FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
