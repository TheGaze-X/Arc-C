using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007655 RID: 30293
	[Token(Token = "0x2007655")]
	public class Act20sideCarCompItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A9CB RID: 174539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9CB")]
		[Address(RVA = "0x2650690", Offset = "0x264F290", VA = "0x182650690")]
		public void OnClick()
		{
		}

		// Token: 0x0602A9CC RID: 174540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9CC")]
		[Address(RVA = "0x2650AA0", Offset = "0x264F6A0", VA = "0x182650AA0")]
		private void _UpdateTrackPoint(string compId)
		{
		}

		// Token: 0x0602A9CD RID: 174541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9CD")]
		[Address(RVA = "0x2650720", Offset = "0x264F320", VA = "0x182650720")]
		public void RenderViewModel(CartCompViewModel viewModel)
		{
		}

		// Token: 0x0602A9CE RID: 174542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9CE")]
		[Address(RVA = "0x2650BA0", Offset = "0x264F7A0", VA = "0x182650BA0")]
		public Act20sideCarCompItem()
		{
		}

		// Token: 0x0403D5B7 RID: 251319
		[Token(Token = "0x403D5B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x0403D5B8 RID: 251320
		[Token(Token = "0x403D5B8")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public UIStringEvent compSelectEvent;

		// Token: 0x0403D5B9 RID: 251321
		[Token(Token = "0x403D5B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _rarityFrameImg;

		// Token: 0x0403D5BA RID: 251322
		[Token(Token = "0x403D5BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasObject _rarityFrameHolder;

		// Token: 0x0403D5BB RID: 251323
		[Token(Token = "0x403D5BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403D5BC RID: 251324
		[Token(Token = "0x403D5BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403D5BD RID: 251325
		[Token(Token = "0x403D5BD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _commonTrackPoint;

		// Token: 0x0403D5BE RID: 251326
		[Token(Token = "0x403D5BE")]
		[FieldOffset(Offset = "0x50")]
		private TrackPointViewProperty m_updatedTrackPointProperty;

		// Token: 0x0403D5BF RID: 251327
		[Token(Token = "0x403D5BF")]
		[FieldOffset(Offset = "0x58")]
		private CartCompViewModel m_viewModel;

		// Token: 0x0403D5C0 RID: 251328
		[Token(Token = "0x403D5C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403D5C1 RID: 251329
		[Token(Token = "0x403D5C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x0403D5C2 RID: 251330
		[Token(Token = "0x403D5C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0403D5C3 RID: 251331
		[Token(Token = "0x403D5C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
