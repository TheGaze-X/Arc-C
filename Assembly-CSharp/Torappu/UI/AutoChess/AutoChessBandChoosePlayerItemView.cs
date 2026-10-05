using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200628F RID: 25231
	[Token(Token = "0x200628F")]
	public class AutoChessBandChoosePlayerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024617 RID: 149015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024617")]
		[Address(RVA = "0x1F23EA0", Offset = "0x1F22AA0", VA = "0x181F23EA0")]
		public void Render(AutoChessBandChoosePlayerModel model, int index, bool isBandSelected)
		{
		}

		// Token: 0x06024618 RID: 149016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024618")]
		[Address(RVA = "0x1F24440", Offset = "0x1F23040", VA = "0x181F24440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024619 RID: 149017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024619")]
		[Address(RVA = "0x1F23DC0", Offset = "0x1F229C0", VA = "0x181F23DC0")]
		public void EventOnBandClicked()
		{
		}

		// Token: 0x0602461A RID: 149018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602461A")]
		[Address(RVA = "0x1F24610", Offset = "0x1F23210", VA = "0x181F24610")]
		public AutoChessBandChoosePlayerItemView()
		{
		}

		// Token: 0x040329AA RID: 207274
		[Token(Token = "0x40329AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelName;

		// Token: 0x040329AB RID: 207275
		[Token(Token = "0x40329AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textNickname;

		// Token: 0x040329AC RID: 207276
		[Token(Token = "0x40329AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNickNum;

		// Token: 0x040329AD RID: 207277
		[Token(Token = "0x40329AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAlias;

		// Token: 0x040329AE RID: 207278
		[Token(Token = "0x40329AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textAlias;

		// Token: 0x040329AF RID: 207279
		[Token(Token = "0x40329AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x040329B0 RID: 207280
		[Token(Token = "0x40329B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgCardSkin;

		// Token: 0x040329B1 RID: 207281
		[Token(Token = "0x40329B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgMedalIcon;

		// Token: 0x040329B2 RID: 207282
		[Token(Token = "0x40329B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x040329B3 RID: 207283
		[Token(Token = "0x40329B3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelSelectedVictor;

		// Token: 0x040329B4 RID: 207284
		[Token(Token = "0x40329B4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgBandIcon;

		// Token: 0x040329B5 RID: 207285
		[Token(Token = "0x40329B5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelWaiting;

		// Token: 0x040329B6 RID: 207286
		[Token(Token = "0x40329B6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSelecting;

		// Token: 0x040329B7 RID: 207287
		[Token(Token = "0x40329B7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelQuit;

		// Token: 0x040329B8 RID: 207288
		[Token(Token = "0x40329B8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelMiss;

		// Token: 0x040329B9 RID: 207289
		[Token(Token = "0x40329B9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x040329BA RID: 207290
		[Token(Token = "0x40329BA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040329BB RID: 207291
		[Token(Token = "0x40329BB")]
		[FieldOffset(Offset = "0xA8")]
		private UISwitchTween m_switchTween;

		// Token: 0x040329BC RID: 207292
		[Token(Token = "0x40329BC")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x040329BD RID: 207293
		[Token(Token = "0x40329BD")]
		[FieldOffset(Offset = "0xB8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x040329BE RID: 207294
		[Token(Token = "0x40329BE")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040329BF RID: 207295
		[Token(Token = "0x40329BF")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedIndex;

		// Token: 0x040329C0 RID: 207296
		[Token(Token = "0x40329C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040329C1 RID: 207297
		[Token(Token = "0x40329C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040329C2 RID: 207298
		[Token(Token = "0x40329C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBandClicked;

		// Token: 0x040329C3 RID: 207299
		[Token(Token = "0x40329C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
