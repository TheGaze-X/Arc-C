using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC0 RID: 23488
	[Token(Token = "0x2005BC0")]
	public class CommonFriendAssistItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060220FE RID: 139518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220FE")]
		[Address(RVA = "0x1C8AA00", Offset = "0x1C89600", VA = "0x181C8AA00")]
		public void Render(CommonFriendAssistViewModel.FriendItemModel model, CommonFriendAssistItem.ICtrl ctrl)
		{
		}

		// Token: 0x060220FF RID: 139519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220FF")]
		[Address(RVA = "0x1C8B360", Offset = "0x1C89F60", VA = "0x181C8B360")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022100 RID: 139520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022100")]
		[Address(RVA = "0x1C8A820", Offset = "0x1C89420", VA = "0x181C8A820")]
		public void EventOnCharDetailClick()
		{
		}

		// Token: 0x06022101 RID: 139521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022101")]
		[Address(RVA = "0x1C8A700", Offset = "0x1C89300", VA = "0x181C8A700")]
		public void EventOnApplyAssist()
		{
		}

		// Token: 0x06022102 RID: 139522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022102")]
		[Address(RVA = "0x1C8A960", Offset = "0x1C89560", VA = "0x181C8A960")]
		public void EventOnFriendAvatarClick()
		{
		}

		// Token: 0x06022103 RID: 139523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022103")]
		[Address(RVA = "0x1C8B5B0", Offset = "0x1C8A1B0", VA = "0x181C8B5B0")]
		public CommonFriendAssistItem()
		{
		}

		// Token: 0x0402EB6D RID: 191341
		[Token(Token = "0x402EB6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0402EB6E RID: 191342
		[Token(Token = "0x402EB6E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _charNameText;

		// Token: 0x0402EB6F RID: 191343
		[Token(Token = "0x402EB6F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charLevelText;

		// Token: 0x0402EB70 RID: 191344
		[Token(Token = "0x402EB70")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x0402EB71 RID: 191345
		[Token(Token = "0x402EB71")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x0402EB72 RID: 191346
		[Token(Token = "0x402EB72")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noskillPanel;

		// Token: 0x0402EB73 RID: 191347
		[Token(Token = "0x402EB73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _skillPanel;

		// Token: 0x0402EB74 RID: 191348
		[Token(Token = "0x402EB74")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _skillImg;

		// Token: 0x0402EB75 RID: 191349
		[Token(Token = "0x402EB75")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _skillLevelBkg;

		// Token: 0x0402EB76 RID: 191350
		[Token(Token = "0x402EB76")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _normalLevelColor;

		// Token: 0x0402EB77 RID: 191351
		[Token(Token = "0x402EB77")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _limitLevelColor;

		// Token: 0x0402EB78 RID: 191352
		[Token(Token = "0x402EB78")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _skillLevelText;

		// Token: 0x0402EB79 RID: 191353
		[Token(Token = "0x402EB79")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _skillSpecializedImg;

		// Token: 0x0402EB7A RID: 191354
		[Token(Token = "0x402EB7A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _noEquipPanel;

		// Token: 0x0402EB7B RID: 191355
		[Token(Token = "0x402EB7B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _equipPanel;

		// Token: 0x0402EB7C RID: 191356
		[Token(Token = "0x402EB7C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipIconPrefab;

		// Token: 0x0402EB7D RID: 191357
		[Token(Token = "0x402EB7D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _equipIconContainer;

		// Token: 0x0402EB7E RID: 191358
		[Token(Token = "0x402EB7E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _equipIconScale;

		// Token: 0x0402EB7F RID: 191359
		[Token(Token = "0x402EB7F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _equipLevelPanel;

		// Token: 0x0402EB80 RID: 191360
		[Token(Token = "0x402EB80")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _equipLevelText;

		// Token: 0x0402EB81 RID: 191361
		[Token(Token = "0x402EB81")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0402EB82 RID: 191362
		[Token(Token = "0x402EB82")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x0402EB83 RID: 191363
		[Token(Token = "0x402EB83")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0402EB84 RID: 191364
		[Token(Token = "0x402EB84")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _friendLevelText;

		// Token: 0x0402EB85 RID: 191365
		[Token(Token = "0x402EB85")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _panelNoteObject;

		// Token: 0x0402EB86 RID: 191366
		[Token(Token = "0x402EB86")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelNameObject;

		// Token: 0x0402EB87 RID: 191367
		[Token(Token = "0x402EB87")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _aliasText;

		// Token: 0x0402EB88 RID: 191368
		[Token(Token = "0x402EB88")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _nickNameText;

		// Token: 0x0402EB89 RID: 191369
		[Token(Token = "0x402EB89")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _nickNumText;

		// Token: 0x0402EB8A RID: 191370
		[Token(Token = "0x402EB8A")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text _outlineText;

		// Token: 0x0402EB8B RID: 191371
		[Token(Token = "0x402EB8B")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _requestFriendObject;

		// Token: 0x0402EB8C RID: 191372
		[Token(Token = "0x402EB8C")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _requestSystemObject;

		// Token: 0x0402EB8D RID: 191373
		[Token(Token = "0x402EB8D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0402EB8E RID: 191374
		[Token(Token = "0x402EB8E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0402EB8F RID: 191375
		[Token(Token = "0x402EB8F")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Text _textLockedExtra;

		// Token: 0x0402EB90 RID: 191376
		[Token(Token = "0x402EB90")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Image _bkgLocked;

		// Token: 0x0402EB91 RID: 191377
		[Token(Token = "0x402EB91")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Image _iconLocked;

		// Token: 0x0402EB92 RID: 191378
		[Token(Token = "0x402EB92")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _starFriendMask;

		// Token: 0x0402EB93 RID: 191379
		[Token(Token = "0x402EB93")]
		[FieldOffset(Offset = "0x158")]
		private bool m_isCharShowMultiSlot;

		// Token: 0x0402EB94 RID: 191380
		[Token(Token = "0x402EB94")]
		[FieldOffset(Offset = "0x160")]
		private CommonFriendAssistViewModel.FriendItemModel m_cacheModel;

		// Token: 0x0402EB95 RID: 191381
		[Token(Token = "0x402EB95")]
		[FieldOffset(Offset = "0x168")]
		private SquadAssistData m_cacheData;

		// Token: 0x0402EB96 RID: 191382
		[Token(Token = "0x402EB96")]
		[FieldOffset(Offset = "0x170")]
		private CommonFriendAssistItem.ICtrl m_ctrl;

		// Token: 0x0402EB97 RID: 191383
		[Token(Token = "0x402EB97")]
		[FieldOffset(Offset = "0x178")]
		private SharedCharData m_sharedChar;

		// Token: 0x0402EB98 RID: 191384
		[Token(Token = "0x402EB98")]
		[FieldOffset(Offset = "0x180")]
		private bool m_locked;

		// Token: 0x0402EB99 RID: 191385
		[Token(Token = "0x402EB99")]
		[FieldOffset(Offset = "0x181")]
		private bool m_inited;

		// Token: 0x0402EB9A RID: 191386
		[Token(Token = "0x402EB9A")]
		[FieldOffset(Offset = "0x188")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402EB9B RID: 191387
		[Token(Token = "0x402EB9B")]
		[FieldOffset(Offset = "0x190")]
		private UICommonEquipTypeIcon m_equipIcon;

		// Token: 0x0402EB9C RID: 191388
		[Token(Token = "0x402EB9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EB9D RID: 191389
		[Token(Token = "0x402EB9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EB9E RID: 191390
		[Token(Token = "0x402EB9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCharDetailClick;

		// Token: 0x0402EB9F RID: 191391
		[Token(Token = "0x402EB9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnApplyAssist;

		// Token: 0x0402EBA0 RID: 191392
		[Token(Token = "0x402EBA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnFriendAvatarClick;

		// Token: 0x0402EBA1 RID: 191393
		[Token(Token = "0x402EBA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BC1 RID: 23489
		[Token(Token = "0x2005BC1")]
		public interface ICtrl
		{
			// Token: 0x06022104 RID: 139524
			[Token(Token = "0x6022104")]
			void ApplyAssist(CommonFriendAssistViewModel.FriendItemModel model);

			// Token: 0x06022105 RID: 139525
			[Token(Token = "0x6022105")]
			void ShowFriendAvatar(string uid);
		}
	}
}
