using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068FF RID: 26879
	[Token(Token = "0x20068FF")]
	public class StageMainlineDiffGroupDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602680C RID: 157708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602680C")]
		[Address(RVA = "0x21A0130", Offset = "0x219ED30", VA = "0x1821A0130")]
		public void OnClick()
		{
		}

		// Token: 0x0602680D RID: 157709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602680D")]
		[Address(RVA = "0x21A01B0", Offset = "0x219EDB0", VA = "0x1821A01B0")]
		public void Render(ZoneViewModel zoneViewModel, ZoneViewModel.DiffInfo diffInfo)
		{
		}

		// Token: 0x0602680E RID: 157710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602680E")]
		[Address(RVA = "0x21A06B0", Offset = "0x219F2B0", VA = "0x1821A06B0")]
		public StageMainlineDiffGroupDetailItem()
		{
		}

		// Token: 0x0403641B RID: 222235
		[Token(Token = "0x403641B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _startButton;

		// Token: 0x0403641C RID: 222236
		[Token(Token = "0x403641C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _normalStartButton;

		// Token: 0x0403641D RID: 222237
		[Token(Token = "0x403641D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _toughStartButton;

		// Token: 0x0403641E RID: 222238
		[Token(Token = "0x403641E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _normalBackShiningColor;

		// Token: 0x0403641F RID: 222239
		[Token(Token = "0x403641F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _toughBackShiningColor;

		// Token: 0x04036420 RID: 222240
		[Token(Token = "0x4036420")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _selectColor;

		// Token: 0x04036421 RID: 222241
		[Token(Token = "0x4036421")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04036422 RID: 222242
		[Token(Token = "0x4036422")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _buttonState;

		// Token: 0x04036423 RID: 222243
		[Token(Token = "0x4036423")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _lockColorMask;

		// Token: 0x04036424 RID: 222244
		[Token(Token = "0x4036424")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x04036425 RID: 222245
		[Token(Token = "0x4036425")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _lockState;

		// Token: 0x04036426 RID: 222246
		[Token(Token = "0x4036426")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _clickBtn;

		// Token: 0x04036427 RID: 222247
		[Token(Token = "0x4036427")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _diffIcon;

		// Token: 0x04036428 RID: 222248
		[Token(Token = "0x4036428")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _diffName;

		// Token: 0x04036429 RID: 222249
		[Token(Token = "0x4036429")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAtlasImage _backImage;

		// Token: 0x0403642A RID: 222250
		[Token(Token = "0x403642A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAtlasObject _atlasHub;

		// Token: 0x0403642B RID: 222251
		[Token(Token = "0x403642B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _commonBack;

		// Token: 0x0403642C RID: 222252
		[Token(Token = "0x403642C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _toughBack;

		// Token: 0x0403642D RID: 222253
		[Token(Token = "0x403642D")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public Action<StageDiffGroup> diffGroupEvent;

		// Token: 0x0403642E RID: 222254
		[Token(Token = "0x403642E")]
		[FieldOffset(Offset = "0xC8")]
		private ZoneViewModel.DiffInfo m_cacheDiffInfo;

		// Token: 0x0403642F RID: 222255
		[Token(Token = "0x403642F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04036430 RID: 222256
		[Token(Token = "0x4036430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036431 RID: 222257
		[Token(Token = "0x4036431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
