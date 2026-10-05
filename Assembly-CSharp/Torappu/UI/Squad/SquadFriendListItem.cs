using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E18 RID: 15896
	[Token(Token = "0x2003E18")]
	public class SquadFriendListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B94 RID: 101268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B94")]
		[Address(RVA = "0x113B700", Offset = "0x113A300", VA = "0x18113B700")]
		public void Render(SquadFriendListItem.Params param)
		{
		}

		// Token: 0x06018B95 RID: 101269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B95")]
		[Address(RVA = "0x113C600", Offset = "0x113B200", VA = "0x18113C600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B96 RID: 101270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B96")]
		[Address(RVA = "0x113B570", Offset = "0x113A170", VA = "0x18113B570")]
		public void OnApplyAssist()
		{
		}

		// Token: 0x06018B97 RID: 101271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B97")]
		[Address(RVA = "0x113B610", Offset = "0x113A210", VA = "0x18113B610")]
		public void OnFriendAvatarClick()
		{
		}

		// Token: 0x06018B98 RID: 101272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B98")]
		[Address(RVA = "0x113C850", Offset = "0x113B450", VA = "0x18113C850")]
		public SquadFriendListItem()
		{
		}

		// Token: 0x0401E59A RID: 124314
		[Token(Token = "0x401E59A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0401E59B RID: 124315
		[Token(Token = "0x401E59B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _charNameText;

		// Token: 0x0401E59C RID: 124316
		[Token(Token = "0x401E59C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charLevelText;

		// Token: 0x0401E59D RID: 124317
		[Token(Token = "0x401E59D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _specMaxPart;

		// Token: 0x0401E59E RID: 124318
		[Token(Token = "0x401E59E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x0401E59F RID: 124319
		[Token(Token = "0x401E59F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x0401E5A0 RID: 124320
		[Token(Token = "0x401E5A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _noskillPanel;

		// Token: 0x0401E5A1 RID: 124321
		[Token(Token = "0x401E5A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _skillPanel;

		// Token: 0x0401E5A2 RID: 124322
		[Token(Token = "0x401E5A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _skillImg;

		// Token: 0x0401E5A3 RID: 124323
		[Token(Token = "0x401E5A3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _skillLevelBkg;

		// Token: 0x0401E5A4 RID: 124324
		[Token(Token = "0x401E5A4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _normalLevelColor;

		// Token: 0x0401E5A5 RID: 124325
		[Token(Token = "0x401E5A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _limitLevelColor;

		// Token: 0x0401E5A6 RID: 124326
		[Token(Token = "0x401E5A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _skillLevelText;

		// Token: 0x0401E5A7 RID: 124327
		[Token(Token = "0x401E5A7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _skillSpecializedImg;

		// Token: 0x0401E5A8 RID: 124328
		[Token(Token = "0x401E5A8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _noEquipPanel;

		// Token: 0x0401E5A9 RID: 124329
		[Token(Token = "0x401E5A9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _equipPanel;

		// Token: 0x0401E5AA RID: 124330
		[Token(Token = "0x401E5AA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipIconPrefab;

		// Token: 0x0401E5AB RID: 124331
		[Token(Token = "0x401E5AB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _equipIconContainer;

		// Token: 0x0401E5AC RID: 124332
		[Token(Token = "0x401E5AC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _equipIconScale;

		// Token: 0x0401E5AD RID: 124333
		[Token(Token = "0x401E5AD")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _equipLevelPanel;

		// Token: 0x0401E5AE RID: 124334
		[Token(Token = "0x401E5AE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _equipLevelText;

		// Token: 0x0401E5AF RID: 124335
		[Token(Token = "0x401E5AF")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0401E5B0 RID: 124336
		[Token(Token = "0x401E5B0")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x0401E5B1 RID: 124337
		[Token(Token = "0x401E5B1")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0401E5B2 RID: 124338
		[Token(Token = "0x401E5B2")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _friendLevelText;

		// Token: 0x0401E5B3 RID: 124339
		[Token(Token = "0x401E5B3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelNoteObject;

		// Token: 0x0401E5B4 RID: 124340
		[Token(Token = "0x401E5B4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _panelNameObject;

		// Token: 0x0401E5B5 RID: 124341
		[Token(Token = "0x401E5B5")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _aliasText;

		// Token: 0x0401E5B6 RID: 124342
		[Token(Token = "0x401E5B6")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _nickNameText;

		// Token: 0x0401E5B7 RID: 124343
		[Token(Token = "0x401E5B7")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text _nickNumText;

		// Token: 0x0401E5B8 RID: 124344
		[Token(Token = "0x401E5B8")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text _outlineText;

		// Token: 0x0401E5B9 RID: 124345
		[Token(Token = "0x401E5B9")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _requestFriendObject;

		// Token: 0x0401E5BA RID: 124346
		[Token(Token = "0x401E5BA")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _requestSystemObject;

		// Token: 0x0401E5BB RID: 124347
		[Token(Token = "0x401E5BB")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0401E5BC RID: 124348
		[Token(Token = "0x401E5BC")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0401E5BD RID: 124349
		[Token(Token = "0x401E5BD")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Text _textLockedExtra;

		// Token: 0x0401E5BE RID: 124350
		[Token(Token = "0x401E5BE")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Image _bkgLocked;

		// Token: 0x0401E5BF RID: 124351
		[Token(Token = "0x401E5BF")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Image _iconLocked;

		// Token: 0x0401E5C0 RID: 124352
		[Token(Token = "0x401E5C0")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private UIAtlasImage _crisisV2Img;

		// Token: 0x0401E5C1 RID: 124353
		[Token(Token = "0x401E5C1")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Text _crisisV2Score;

		// Token: 0x0401E5C2 RID: 124354
		[Token(Token = "0x401E5C2")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _starFriendBgMask;

		// Token: 0x0401E5C3 RID: 124355
		[Token(Token = "0x401E5C3")]
		[FieldOffset(Offset = "0x170")]
		private UIFriendEvent m_uiFriendEvent;

		// Token: 0x0401E5C4 RID: 124356
		[Token(Token = "0x401E5C4")]
		[FieldOffset(Offset = "0x178")]
		private SquadAssistData m_cacheData;

		// Token: 0x0401E5C5 RID: 124357
		[Token(Token = "0x401E5C5")]
		[FieldOffset(Offset = "0x180")]
		private SharedCharData m_sharedChar;

		// Token: 0x0401E5C6 RID: 124358
		[Token(Token = "0x401E5C6")]
		[FieldOffset(Offset = "0x188")]
		private bool m_isFriend;

		// Token: 0x0401E5C7 RID: 124359
		[Token(Token = "0x401E5C7")]
		[FieldOffset(Offset = "0x189")]
		private bool m_locked;

		// Token: 0x0401E5C8 RID: 124360
		[Token(Token = "0x401E5C8")]
		[FieldOffset(Offset = "0x18A")]
		private bool m_inited;

		// Token: 0x0401E5C9 RID: 124361
		[Token(Token = "0x401E5C9")]
		[FieldOffset(Offset = "0x190")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0401E5CA RID: 124362
		[Token(Token = "0x401E5CA")]
		[FieldOffset(Offset = "0x198")]
		private UICommonEquipTypeIcon m_equipIcon;

		// Token: 0x0401E5CB RID: 124363
		[Token(Token = "0x401E5CB")]
		[FieldOffset(Offset = "0x1A0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E5CC RID: 124364
		[Token(Token = "0x401E5CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E5CD RID: 124365
		[Token(Token = "0x401E5CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E5CE RID: 124366
		[Token(Token = "0x401E5CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnApplyAssist;

		// Token: 0x0401E5CF RID: 124367
		[Token(Token = "0x401E5CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFriendAvatarClick;

		// Token: 0x0401E5D0 RID: 124368
		[Token(Token = "0x401E5D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E19 RID: 15897
		[Token(Token = "0x2003E19")]
		public struct LockedStyle
		{
			// Token: 0x0401E5D1 RID: 124369
			[Token(Token = "0x401E5D1")]
			[FieldOffset(Offset = "0x0")]
			public string lockedText;

			// Token: 0x0401E5D2 RID: 124370
			[Token(Token = "0x401E5D2")]
			[FieldOffset(Offset = "0x8")]
			public string extraText;

			// Token: 0x0401E5D3 RID: 124371
			[Token(Token = "0x401E5D3")]
			[FieldOffset(Offset = "0x10")]
			public Color textBkgColor;

			// Token: 0x0401E5D4 RID: 124372
			[Token(Token = "0x401E5D4")]
			[FieldOffset(Offset = "0x20")]
			public Color iconColor;
		}

		// Token: 0x02003E1A RID: 15898
		[Token(Token = "0x2003E1A")]
		public struct Params
		{
			// Token: 0x0401E5D5 RID: 124373
			[Token(Token = "0x401E5D5")]
			[FieldOffset(Offset = "0x0")]
			public SquadAssistData assistData;

			// Token: 0x0401E5D6 RID: 124374
			[Token(Token = "0x401E5D6")]
			[FieldOffset(Offset = "0x8")]
			public EvolvePhaseAndLevel maxEvolvePhaseAndLevel;

			// Token: 0x0401E5D7 RID: 124375
			[Token(Token = "0x401E5D7")]
			[FieldOffset(Offset = "0x10")]
			public UIFriendEvent eventApplyAssist;

			// Token: 0x0401E5D8 RID: 124376
			[Token(Token = "0x401E5D8")]
			[FieldOffset(Offset = "0x18")]
			public SquadFriendAssistState.IPlugin statePlugin;
		}
	}
}
