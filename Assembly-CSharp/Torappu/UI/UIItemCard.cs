using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003725 RID: 14117
	[Token(Token = "0x2003725")]
	public class UIItemCard : MonoBehaviour, UIItemDescFloat.IItemCard, IHotfixable
	{
		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x060166AB RID: 91819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035BA")]
		public UIItemViewModel model
		{
			[Token(Token = "0x60166AB")]
			[Address(RVA = "0xEE3B80", Offset = "0xEE2780", VA = "0x180EE3B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060166AC RID: 91820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166AC")]
		[Address(RVA = "0xEE1B00", Offset = "0xEE0700", VA = "0x180EE1B00")]
		private void OnEnable()
		{
		}

		// Token: 0x060166AD RID: 91821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166AD")]
		[Address(RVA = "0xEE1A80", Offset = "0xEE0680", VA = "0x180EE1A80")]
		private void OnDisable()
		{
		}

		// Token: 0x060166AE RID: 91822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166AE")]
		[Address(RVA = "0xEE1D90", Offset = "0xEE0990", VA = "0x180EE1D90")]
		public void Render(int index, UIItemViewModel viewModel)
		{
		}

		// Token: 0x060166AF RID: 91823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166AF")]
		[Address(RVA = "0xEE2CA0", Offset = "0xEE18A0", VA = "0x180EE2CA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060166B0 RID: 91824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166B0")]
		[Address(RVA = "0xEE1910", Offset = "0xEE0510", VA = "0x180EE1910")]
		public void CloseBtnTransition()
		{
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x060166B1 RID: 91825 RVA: 0x000912D8 File Offset: 0x0008F4D8
		// (set) Token: 0x060166B2 RID: 91826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035BB")]
		public Color mainColor
		{
			[Token(Token = "0x60166B1")]
			[Address(RVA = "0xEE3AB0", Offset = "0xEE26B0", VA = "0x180EE3AB0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60166B2")]
			[Address(RVA = "0xEE41B0", Offset = "0xEE2DB0", VA = "0x180EE41B0")]
			set
			{
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x060166B3 RID: 91827 RVA: 0x000912F0 File Offset: 0x0008F4F0
		// (set) Token: 0x060166B4 RID: 91828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035BC")]
		public float blockFadeDuration
		{
			[Token(Token = "0x60166B3")]
			[Address(RVA = "0xEE3830", Offset = "0xEE2430", VA = "0x180EE3830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60166B4")]
			[Address(RVA = "0xEE3E00", Offset = "0xEE2A00", VA = "0x180EE3E00")]
			set
			{
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x060166B5 RID: 91829 RVA: 0x00091308 File Offset: 0x0008F508
		// (set) Token: 0x060166B6 RID: 91830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035BD")]
		public bool enableValidTime
		{
			[Token(Token = "0x60166B5")]
			[Address(RVA = "0xEE3980", Offset = "0xEE2580", VA = "0x180EE3980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166B6")]
			[Address(RVA = "0xEE4050", Offset = "0xEE2C50", VA = "0x180EE4050")]
			set
			{
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x060166B7 RID: 91831 RVA: 0x00091320 File Offset: 0x0008F520
		// (set) Token: 0x060166B8 RID: 91832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035BE")]
		public bool showItemNum
		{
			[Token(Token = "0x60166B7")]
			[Address(RVA = "0xEE3D80", Offset = "0xEE2980", VA = "0x180EE3D80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166B8")]
			[Address(RVA = "0xEE4560", Offset = "0xEE3160", VA = "0x180EE4560")]
			set
			{
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x060166B9 RID: 91833 RVA: 0x00091338 File Offset: 0x0008F538
		// (set) Token: 0x060166BA RID: 91834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035BF")]
		public bool showItemEmptyNum
		{
			[Token(Token = "0x60166B9")]
			[Address(RVA = "0xEE3C80", Offset = "0xEE2880", VA = "0x180EE3C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166BA")]
			[Address(RVA = "0xEE4430", Offset = "0xEE3030", VA = "0x180EE4430")]
			set
			{
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x060166BB RID: 91835 RVA: 0x00091350 File Offset: 0x0008F550
		// (set) Token: 0x060166BC RID: 91836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C0")]
		public bool showItemName
		{
			[Token(Token = "0x60166BB")]
			[Address(RVA = "0xEE3D00", Offset = "0xEE2900", VA = "0x180EE3D00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166BC")]
			[Address(RVA = "0xEE44C0", Offset = "0xEE30C0", VA = "0x180EE44C0")]
			set
			{
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x060166BD RID: 91837 RVA: 0x00091368 File Offset: 0x0008F568
		// (set) Token: 0x060166BE RID: 91838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C1")]
		public bool showBackground
		{
			[Token(Token = "0x60166BD")]
			[Address(RVA = "0xEE3C00", Offset = "0xEE2800", VA = "0x180EE3C00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166BE")]
			[Address(RVA = "0xEE4320", Offset = "0xEE2F20", VA = "0x180EE4320")]
			set
			{
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x060166BF RID: 91839 RVA: 0x00091380 File Offset: 0x0008F580
		// (set) Token: 0x060166C0 RID: 91840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C2")]
		public bool isCardClickable
		{
			[Token(Token = "0x60166BF")]
			[Address(RVA = "0xEE3A00", Offset = "0xEE2600", VA = "0x180EE3A00", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166C0")]
			[Address(RVA = "0xEE40F0", Offset = "0xEE2CF0", VA = "0x180EE40F0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x060166C1 RID: 91841 RVA: 0x00091398 File Offset: 0x0008F598
		// (set) Token: 0x060166C2 RID: 91842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C3")]
		public bool enableCardClickAudio
		{
			[Token(Token = "0x60166C1")]
			[Address(RVA = "0xEE38F0", Offset = "0xEE24F0", VA = "0x180EE38F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60166C2")]
			[Address(RVA = "0xEE3FB0", Offset = "0xEE2BB0", VA = "0x180EE3FB0")]
			set
			{
			}
		}

		// Token: 0x060166C3 RID: 91843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166C3")]
		[Address(RVA = "0xEE1B80", Offset = "0xEE0780", VA = "0x180EE1B80")]
		public void OnScaleChange(float scale)
		{
		}

		// Token: 0x060166C4 RID: 91844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166C4")]
		[Address(RVA = "0xEE19F0", Offset = "0xEE05F0", VA = "0x180EE19F0")]
		public void EventOnReduceBtnClick()
		{
		}

		// Token: 0x060166C5 RID: 91845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166C5")]
		[Address(RVA = "0xEE2EE0", Offset = "0xEE1AE0", VA = "0x180EE2EE0")]
		private void _OnItemClicked()
		{
		}

		// Token: 0x060166C6 RID: 91846 RVA: 0x000913B0 File Offset: 0x0008F5B0
		[Token(Token = "0x60166C6")]
		[Address(RVA = "0xEE2F70", Offset = "0xEE1B70", VA = "0x180EE2F70")]
		private bool _OnItemLongPressed()
		{
			return default(bool);
		}

		// Token: 0x060166C7 RID: 91847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166C7")]
		[Address(RVA = "0xEE3010", Offset = "0xEE1C10", VA = "0x180EE3010")]
		private void _OnValidTimeExcceeded()
		{
		}

		// Token: 0x060166C8 RID: 91848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166C8")]
		[Address(RVA = "0xEE1C20", Offset = "0xEE0820", VA = "0x180EE1C20")]
		public static string ParseItemCount(long count, long maxCount = -1L)
		{
			return null;
		}

		// Token: 0x060166C9 RID: 91849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166C9")]
		[Address(RVA = "0xEE2B10", Offset = "0xEE1710", VA = "0x180EE2B10")]
		private Sprite _GetMaterialBkgSprite(UIItemViewModel itemModel)
		{
			return null;
		}

		// Token: 0x060166CA RID: 91850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166CA")]
		[Address(RVA = "0xEE27F0", Offset = "0xEE13F0", VA = "0x180EE27F0")]
		private Sprite _GetCharBkgSprite(UIItemViewModel itemModel)
		{
			return null;
		}

		// Token: 0x060166CB RID: 91851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166CB")]
		[Address(RVA = "0xEE2A60", Offset = "0xEE1660", VA = "0x180EE2A60")]
		private Sprite _GetFurnitureBkgSprite(UIItemViewModel itemModel)
		{
			return null;
		}

		// Token: 0x060166CC RID: 91852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166CC")]
		[Address(RVA = "0xEE2980", Offset = "0xEE1580", VA = "0x180EE2980")]
		private Sprite _GetCharmBkgSprite(UIItemViewModel itemModel)
		{
			return null;
		}

		// Token: 0x060166CD RID: 91853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166CD")]
		[Address(RVA = "0xEE3340", Offset = "0xEE1F40", VA = "0x180EE3340")]
		private void _UpdateNameShowState()
		{
		}

		// Token: 0x060166CE RID: 91854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166CE")]
		[Address(RVA = "0xEE30A0", Offset = "0xEE1CA0", VA = "0x180EE30A0")]
		private void _UpdateBackgroundShowState()
		{
		}

		// Token: 0x060166CF RID: 91855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166CF")]
		[Address(RVA = "0xEE3130", Offset = "0xEE1D30", VA = "0x180EE3130")]
		private void _UpdateItemNumVisibleState()
		{
		}

		// Token: 0x060166D0 RID: 91856 RVA: 0x000913C8 File Offset: 0x0008F5C8
		[Token(Token = "0x60166D0")]
		[Address(RVA = "0xEE2730", Offset = "0xEE1330", VA = "0x180EE2730")]
		private bool _CheckIfNoCountType(ItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x060166D1 RID: 91857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166D1")]
		[Address(RVA = "0xEE33C0", Offset = "0xEE1FC0", VA = "0x180EE33C0")]
		private void _UpdateValidTimeSystem(bool isItemCardEnabled)
		{
		}

		// Token: 0x060166D2 RID: 91858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166D2")]
		[Address(RVA = "0xEE3740", Offset = "0xEE2340", VA = "0x180EE3740")]
		public UIItemCard()
		{
		}

		// Token: 0x0401AF66 RID: 110438
		[Token(Token = "0x401AF66")]
		private const int FURNI_RARITY_LOW = 1;

		// Token: 0x0401AF67 RID: 110439
		[Token(Token = "0x401AF67")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_ZERO_COUNT;

		// Token: 0x0401AF68 RID: 110440
		[Token(Token = "0x401AF68")]
		[FieldOffset(Offset = "0x10")]
		private static ItemType[] NO_COUNT_TYPE_GROUP;

		// Token: 0x0401AF69 RID: 110441
		[Token(Token = "0x401AF69")]
		private const int LARGE_ITEM_NUM = 10000;

		// Token: 0x0401AF6A RID: 110442
		[Token(Token = "0x401AF6A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Material")]
		private Text _textMatNum;

		// Token: 0x0401AF6B RID: 110443
		[Token(Token = "0x401AF6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Material")]
		private Image _imageMatBkg;

		// Token: 0x0401AF6C RID: 110444
		[Token(Token = "0x401AF6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Material")]
		private Image _imageMatIcon;

		// Token: 0x0401AF6D RID: 110445
		[Token(Token = "0x401AF6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Material")]
		private GameObject _panelMatNum;

		// Token: 0x0401AF6E RID: 110446
		[Token(Token = "0x401AF6E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Furniture")]
		private Image _imageFurniBkg;

		// Token: 0x0401AF6F RID: 110447
		[Token(Token = "0x401AF6F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Furniture")]
		private Image _imageFurniIcon;

		// Token: 0x0401AF70 RID: 110448
		[Token(Token = "0x401AF70")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Char")]
		private Image _imageCharAvatar;

		// Token: 0x0401AF71 RID: 110449
		[Token(Token = "0x401AF71")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Char")]
		private Image _imageCharBkg;

		// Token: 0x0401AF72 RID: 110450
		[Token(Token = "0x401AF72")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Char")]
		private GameObject _panelChar;

		// Token: 0x0401AF73 RID: 110451
		[Token(Token = "0x401AF73")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Graphic _cardRaycaster;

		// Token: 0x0401AF74 RID: 110452
		[Token(Token = "0x401AF74")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0401AF75 RID: 110453
		[Token(Token = "0x401AF75")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0401AF76 RID: 110454
		[Token(Token = "0x401AF76")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UILongPressButton _button;

		// Token: 0x0401AF77 RID: 110455
		[Token(Token = "0x401AF77")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _colorHandler;

		// Token: 0x0401AF78 RID: 110456
		[Token(Token = "0x401AF78")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelItemName;

		// Token: 0x0401AF79 RID: 110457
		[Token(Token = "0x401AF79")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR1;

		// Token: 0x0401AF7A RID: 110458
		[Token(Token = "0x401AF7A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR2;

		// Token: 0x0401AF7B RID: 110459
		[Token(Token = "0x401AF7B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR3;

		// Token: 0x0401AF7C RID: 110460
		[Token(Token = "0x401AF7C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR4;

		// Token: 0x0401AF7D RID: 110461
		[Token(Token = "0x401AF7D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR5;

		// Token: 0x0401AF7E RID: 110462
		[Token(Token = "0x401AF7E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Bkg Mat")]
		private Sprite _bkgMatR6;

		// Token: 0x0401AF7F RID: 110463
		[Token(Token = "0x401AF7F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Bkg Furni")]
		private Sprite _bkgFurniR1;

		// Token: 0x0401AF80 RID: 110464
		[Token(Token = "0x401AF80")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Bkg Furni")]
		private Sprite _bkgFurniR2;

		// Token: 0x0401AF81 RID: 110465
		[Token(Token = "0x401AF81")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR1;

		// Token: 0x0401AF82 RID: 110466
		[Token(Token = "0x401AF82")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR2;

		// Token: 0x0401AF83 RID: 110467
		[Token(Token = "0x401AF83")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR3;

		// Token: 0x0401AF84 RID: 110468
		[Token(Token = "0x401AF84")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR4;

		// Token: 0x0401AF85 RID: 110469
		[Token(Token = "0x401AF85")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR5;

		// Token: 0x0401AF86 RID: 110470
		[Token(Token = "0x401AF86")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Bkg Char")]
		private Sprite _bkgCharR6;

		// Token: 0x0401AF87 RID: 110471
		[Token(Token = "0x401AF87")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Skin")]
		private GameObject _panelSkin;

		// Token: 0x0401AF88 RID: 110472
		[Token(Token = "0x401AF88")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Skin")]
		private Image _imageSkin;

		// Token: 0x0401AF89 RID: 110473
		[Token(Token = "0x401AF89")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Player Avatar")]
		private GameObject _panelPlayerAvatar;

		// Token: 0x0401AF8A RID: 110474
		[Token(Token = "0x401AF8A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Player Avatar")]
		private Image _imagePlayerAvatar;

		// Token: 0x0401AF8B RID: 110475
		[Token(Token = "0x401AF8B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Charm")]
		private Image _imageCharmBkg;

		// Token: 0x0401AF8C RID: 110476
		[Token(Token = "0x401AF8C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Charm")]
		private Image _imageCharmIcon;

		// Token: 0x0401AF8D RID: 110477
		[Token(Token = "0x401AF8D")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Charm")]
		private Sprite[] _charmBkgs;

		// Token: 0x0401AF8E RID: 110478
		[Token(Token = "0x401AF8E")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Medal")]
		private Image _imageMedalBkg;

		// Token: 0x0401AF8F RID: 110479
		[Token(Token = "0x401AF8F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Medal")]
		private Image _imageMedalIcon;

		// Token: 0x0401AF90 RID: 110480
		[Token(Token = "0x401AF90")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("BackGround")]
		private GameObject _panelBackGround;

		// Token: 0x0401AF91 RID: 110481
		[Token(Token = "0x401AF91")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("BackGround")]
		private Image _imageBackGround;

		// Token: 0x0401AF92 RID: 110482
		[Token(Token = "0x401AF92")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Time")]
		private Transform _countDownContainer;

		// Token: 0x0401AF93 RID: 110483
		[Token(Token = "0x401AF93")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Time")]
		private UIItemTimeCountDown _countDownTimeItem;

		// Token: 0x0401AF94 RID: 110484
		[Token(Token = "0x401AF94")]
		[FieldOffset(Offset = "0x168")]
		private UIItemTimeCountDown m_countDownItem;

		// Token: 0x0401AF95 RID: 110485
		[Token(Token = "0x401AF95")]
		[FieldOffset(Offset = "0x170")]
		private int m_itemIndexCache;

		// Token: 0x0401AF96 RID: 110486
		[Token(Token = "0x401AF96")]
		[FieldOffset(Offset = "0x178")]
		private UIItemViewModel m_itemModelCache;

		// Token: 0x0401AF97 RID: 110487
		[Token(Token = "0x401AF97")]
		[FieldOffset(Offset = "0x180")]
		private bool m_isInited;

		// Token: 0x0401AF98 RID: 110488
		[Token(Token = "0x401AF98")]
		[FieldOffset(Offset = "0x181")]
		private bool m_showItemNumByOption;

		// Token: 0x0401AF99 RID: 110489
		[Token(Token = "0x401AF99")]
		[FieldOffset(Offset = "0x182")]
		private bool m_showItemEmptyNum;

		// Token: 0x0401AF9A RID: 110490
		[Token(Token = "0x401AF9A")]
		[FieldOffset(Offset = "0x188")]
		private UIItemCard.ViewCache m_viewCache;

		// Token: 0x0401AF9B RID: 110491
		[Token(Token = "0x401AF9B")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_showItemName;

		// Token: 0x0401AF9C RID: 110492
		[Token(Token = "0x401AF9C")]
		[FieldOffset(Offset = "0x1A1")]
		private bool m_showBackground;

		// Token: 0x0401AF9D RID: 110493
		[Token(Token = "0x401AF9D")]
		[FieldOffset(Offset = "0x1A2")]
		private bool m_enableValidTime;

		// Token: 0x0401AF9E RID: 110494
		[Token(Token = "0x401AF9E")]
		[FieldOffset(Offset = "0x1A3")]
		private bool m_isWatchingTime;

		// Token: 0x0401AF9F RID: 110495
		[Token(Token = "0x401AF9F")]
		[FieldOffset(Offset = "0x1A8")]
		[NonSerialized]
		public Action<int> onItemClick;

		// Token: 0x0401AFA0 RID: 110496
		[Token(Token = "0x401AFA0")]
		[FieldOffset(Offset = "0x1B0")]
		[NonSerialized]
		public Func<int, bool> onItemLongPressed;

		// Token: 0x0401AFA1 RID: 110497
		[Token(Token = "0x401AFA1")]
		[FieldOffset(Offset = "0x1B8")]
		[NonSerialized]
		public Action<int> onBtnReduceClick;

		// Token: 0x0401AFA2 RID: 110498
		[Token(Token = "0x401AFA2")]
		[FieldOffset(Offset = "0x1C0")]
		[NonSerialized]
		public Action<int> onItemTimeout;

		// Token: 0x0401AFA3 RID: 110499
		[Token(Token = "0x401AFA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x0401AFA4 RID: 110500
		[Token(Token = "0x401AFA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401AFA5 RID: 110501
		[Token(Token = "0x401AFA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401AFA6 RID: 110502
		[Token(Token = "0x401AFA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401AFA7 RID: 110503
		[Token(Token = "0x401AFA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AFA8 RID: 110504
		[Token(Token = "0x401AFA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CloseBtnTransition;

		// Token: 0x0401AFA9 RID: 110505
		[Token(Token = "0x401AFA9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_mainColor;

		// Token: 0x0401AFAA RID: 110506
		[Token(Token = "0x401AFAA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_mainColor;

		// Token: 0x0401AFAB RID: 110507
		[Token(Token = "0x401AFAB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_blockFadeDuration;

		// Token: 0x0401AFAC RID: 110508
		[Token(Token = "0x401AFAC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_blockFadeDuration;

		// Token: 0x0401AFAD RID: 110509
		[Token(Token = "0x401AFAD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_enableValidTime;

		// Token: 0x0401AFAE RID: 110510
		[Token(Token = "0x401AFAE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_enableValidTime;

		// Token: 0x0401AFAF RID: 110511
		[Token(Token = "0x401AFAF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_showItemNum;

		// Token: 0x0401AFB0 RID: 110512
		[Token(Token = "0x401AFB0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_showItemNum;

		// Token: 0x0401AFB1 RID: 110513
		[Token(Token = "0x401AFB1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_showItemEmptyNum;

		// Token: 0x0401AFB2 RID: 110514
		[Token(Token = "0x401AFB2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_showItemEmptyNum;

		// Token: 0x0401AFB3 RID: 110515
		[Token(Token = "0x401AFB3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_showItemName;

		// Token: 0x0401AFB4 RID: 110516
		[Token(Token = "0x401AFB4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_showItemName;

		// Token: 0x0401AFB5 RID: 110517
		[Token(Token = "0x401AFB5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_showBackground;

		// Token: 0x0401AFB6 RID: 110518
		[Token(Token = "0x401AFB6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_showBackground;

		// Token: 0x0401AFB7 RID: 110519
		[Token(Token = "0x401AFB7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isCardClickable;

		// Token: 0x0401AFB8 RID: 110520
		[Token(Token = "0x401AFB8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_isCardClickable;

		// Token: 0x0401AFB9 RID: 110521
		[Token(Token = "0x401AFB9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_enableCardClickAudio;

		// Token: 0x0401AFBA RID: 110522
		[Token(Token = "0x401AFBA")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_enableCardClickAudio;

		// Token: 0x0401AFBB RID: 110523
		[Token(Token = "0x401AFBB")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnScaleChange;

		// Token: 0x0401AFBC RID: 110524
		[Token(Token = "0x401AFBC")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnReduceBtnClick;

		// Token: 0x0401AFBD RID: 110525
		[Token(Token = "0x401AFBD")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0401AFBE RID: 110526
		[Token(Token = "0x401AFBE")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnItemLongPressed;

		// Token: 0x0401AFBF RID: 110527
		[Token(Token = "0x401AFBF")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnValidTimeExcceeded;

		// Token: 0x0401AFC0 RID: 110528
		[Token(Token = "0x401AFC0")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ParseItemCount;

		// Token: 0x0401AFC1 RID: 110529
		[Token(Token = "0x401AFC1")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetMaterialBkgSprite;

		// Token: 0x0401AFC2 RID: 110530
		[Token(Token = "0x401AFC2")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GetCharBkgSprite;

		// Token: 0x0401AFC3 RID: 110531
		[Token(Token = "0x401AFC3")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GetFurnitureBkgSprite;

		// Token: 0x0401AFC4 RID: 110532
		[Token(Token = "0x401AFC4")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetCharmBkgSprite;

		// Token: 0x0401AFC5 RID: 110533
		[Token(Token = "0x401AFC5")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__UpdateNameShowState;

		// Token: 0x0401AFC6 RID: 110534
		[Token(Token = "0x401AFC6")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UpdateBackgroundShowState;

		// Token: 0x0401AFC7 RID: 110535
		[Token(Token = "0x401AFC7")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UpdateItemNumVisibleState;

		// Token: 0x0401AFC8 RID: 110536
		[Token(Token = "0x401AFC8")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckIfNoCountType;

		// Token: 0x0401AFC9 RID: 110537
		[Token(Token = "0x401AFC9")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__UpdateValidTimeSystem;

		// Token: 0x0401AFCA RID: 110538
		[Token(Token = "0x401AFCA")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003726 RID: 14118
		[Token(Token = "0x2003726")]
		private struct ViewCache
		{
			// Token: 0x060166D4 RID: 91860 RVA: 0x000913E0 File Offset: 0x0008F5E0
			[Token(Token = "0x60166D4")]
			[Address(RVA = "0xEEF010", Offset = "0xEEDC10", VA = "0x180EEF010")]
			public static UIItemCard.ViewCache CreateInst(UIItemViewModel model)
			{
				return default(UIItemCard.ViewCache);
			}

			// Token: 0x0401AFCB RID: 110539
			[Token(Token = "0x401AFCB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIItemCard.ViewCache EMPTY;

			// Token: 0x0401AFCC RID: 110540
			[Token(Token = "0x401AFCC")]
			[FieldOffset(Offset = "0x0")]
			public ItemType type;

			// Token: 0x0401AFCD RID: 110541
			[Token(Token = "0x401AFCD")]
			[FieldOffset(Offset = "0x8")]
			public string itemId;

			// Token: 0x0401AFCE RID: 110542
			[Token(Token = "0x401AFCE")]
			[FieldOffset(Offset = "0x10")]
			public long count;
		}

		// Token: 0x02003727 RID: 14119
		[Token(Token = "0x2003727")]
		[Serializable]
		private struct TimeStyleConfig
		{
			// Token: 0x0401AFCF RID: 110543
			[Token(Token = "0x401AFCF")]
			[FieldOffset(Offset = "0x0")]
			public Color bkg;

			// Token: 0x0401AFD0 RID: 110544
			[Token(Token = "0x401AFD0")]
			[FieldOffset(Offset = "0x10")]
			public Color icon;

			// Token: 0x0401AFD1 RID: 110545
			[Token(Token = "0x401AFD1")]
			[FieldOffset(Offset = "0x20")]
			public Color text;
		}
	}
}
