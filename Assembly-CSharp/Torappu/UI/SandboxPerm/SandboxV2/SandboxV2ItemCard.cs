using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004120 RID: 16672
	[Token(Token = "0x2004120")]
	public class SandboxV2ItemCard : MonoBehaviour, UIItemDescFloat.IItemCard, IHotfixable
	{
		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x06019C31 RID: 105521 RVA: 0x0009F528 File Offset: 0x0009D728
		// (set) Token: 0x06019C32 RID: 105522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D67")]
		public int index
		{
			[Token(Token = "0x6019C31")]
			[Address(RVA = "0x12B5480", Offset = "0x12B4080", VA = "0x1812B5480")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019C32")]
			[Address(RVA = "0x12B55E0", Offset = "0x12B41E0", VA = "0x1812B55E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019C33 RID: 105523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C33")]
		[Address(RVA = "0x12B44F0", Offset = "0x12B30F0", VA = "0x1812B44F0")]
		public void Render(int idx, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06019C34 RID: 105524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C34")]
		[Address(RVA = "0x12B4C40", Offset = "0x12B3840", VA = "0x1812B4C40")]
		public void SetOption(SandboxV2ItemCard.Option option)
		{
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x06019C35 RID: 105525 RVA: 0x0009F540 File Offset: 0x0009D740
		// (set) Token: 0x06019C36 RID: 105526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D68")]
		public float scale
		{
			[Token(Token = "0x6019C35")]
			[Address(RVA = "0x12B5570", Offset = "0x12B4170", VA = "0x1812B5570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6019C36")]
			[Address(RVA = "0x12B56F0", Offset = "0x12B42F0", VA = "0x1812B56F0")]
			set
			{
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x06019C37 RID: 105527 RVA: 0x0009F558 File Offset: 0x0009D758
		// (set) Token: 0x06019C38 RID: 105528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D69")]
		public bool isCardClickable
		{
			[Token(Token = "0x6019C37")]
			[Address(RVA = "0x12B54E0", Offset = "0x12B40E0", VA = "0x1812B54E0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019C38")]
			[Address(RVA = "0x12B5650", Offset = "0x12B4250", VA = "0x1812B5650", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06019C39 RID: 105529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C39")]
		[Address(RVA = "0x12B50C0", Offset = "0x12B3CC0", VA = "0x1812B50C0")]
		private Sprite _GetRarityBkg(ItemRarity rarity)
		{
			return null;
		}

		// Token: 0x06019C3A RID: 105530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C3A")]
		[Address(RVA = "0x12B51D0", Offset = "0x12B3DD0", VA = "0x1812B51D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019C3B RID: 105531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C3B")]
		[Address(RVA = "0x12B4430", Offset = "0x12B3030", VA = "0x1812B4430")]
		public void EventReduceBtnClick()
		{
		}

		// Token: 0x06019C3C RID: 105532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C3C")]
		[Address(RVA = "0x12B4F30", Offset = "0x12B3B30", VA = "0x1812B4F30")]
		private void _EventOnClick()
		{
		}

		// Token: 0x06019C3D RID: 105533 RVA: 0x0009F570 File Offset: 0x0009D770
		[Token(Token = "0x6019C3D")]
		[Address(RVA = "0x12B4FF0", Offset = "0x12B3BF0", VA = "0x1812B4FF0")]
		private bool _EventOnLongClick()
		{
			return default(bool);
		}

		// Token: 0x06019C3E RID: 105534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C3E")]
		[Address(RVA = "0x12B4EC0", Offset = "0x12B3AC0", VA = "0x1812B4EC0")]
		public GameObject TutorialOnly_GetButtonGO()
		{
			return null;
		}

		// Token: 0x06019C3F RID: 105535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C3F")]
		[Address(RVA = "0x12B53C0", Offset = "0x12B3FC0", VA = "0x1812B53C0")]
		public SandboxV2ItemCard()
		{
		}

		// Token: 0x040204A7 RID: 132263
		[Token(Token = "0x40204A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rarityBkg;

		// Token: 0x040204A8 RID: 132264
		[Token(Token = "0x40204A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040204A9 RID: 132265
		[Token(Token = "0x40204A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _num;

		// Token: 0x040204AA RID: 132266
		[Token(Token = "0x40204AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _numNode;

		// Token: 0x040204AB RID: 132267
		[Token(Token = "0x40204AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILongPressButtonEx _pressBtn;

		// Token: 0x040204AC RID: 132268
		[Token(Token = "0x40204AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Graphic _pressRaycaster;

		// Token: 0x040204AD RID: 132269
		[Token(Token = "0x40204AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x040204AE RID: 132270
		[Token(Token = "0x40204AE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("FOOD")]
		private GameObject _existGour;

		// Token: 0x040204AF RID: 132271
		[Token(Token = "0x40204AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("FOOD")]
		private GameObject _existIngred;

		// Token: 0x040204B0 RID: 132272
		[Token(Token = "0x40204B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ProdNum")]
		private GameObject _prodNumNode;

		// Token: 0x040204B1 RID: 132273
		[Token(Token = "0x40204B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ProdNum")]
		private Text _prodNum;

		// Token: 0x040204B2 RID: 132274
		[Token(Token = "0x40204B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("ProdNum")]
		private GameObject _emptyLabel;

		// Token: 0x040204B3 RID: 132275
		[Token(Token = "0x40204B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("ProdNum")]
		private GameObject _emptyLine;

		// Token: 0x040204B4 RID: 132276
		[Token(Token = "0x40204B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Select")]
		private Image _selectNode;

		// Token: 0x040204B5 RID: 132277
		[Token(Token = "0x40204B5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Select")]
		private GameObject _reduceBtn;

		// Token: 0x040204B6 RID: 132278
		[Token(Token = "0x40204B6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Select")]
		private Text _selectNum;

		// Token: 0x040204B7 RID: 132279
		[Token(Token = "0x40204B7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_none;

		// Token: 0x040204B8 RID: 132280
		[Token(Token = "0x40204B8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_t1;

		// Token: 0x040204B9 RID: 132281
		[Token(Token = "0x40204B9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_t2;

		// Token: 0x040204BA RID: 132282
		[Token(Token = "0x40204BA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_t3;

		// Token: 0x040204BB RID: 132283
		[Token(Token = "0x40204BB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_t4;

		// Token: 0x040204BC RID: 132284
		[Token(Token = "0x40204BC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_t5;

		// Token: 0x040204BD RID: 132285
		[Token(Token = "0x40204BD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("RarityBKG")]
		private Sprite _rarity_sp;

		// Token: 0x040204BE RID: 132286
		[Token(Token = "0x40204BE")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_init;

		// Token: 0x040204BF RID: 132287
		[Token(Token = "0x40204BF")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxV2ItemCard.Option m_option;

		// Token: 0x040204C0 RID: 132288
		[Token(Token = "0x40204C0")]
		[FieldOffset(Offset = "0xF8")]
		private UIItemViewModel m_cachedModel;

		// Token: 0x040204C1 RID: 132289
		[Token(Token = "0x40204C1")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public Action<int> onItemClick;

		// Token: 0x040204C2 RID: 132290
		[Token(Token = "0x40204C2")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		public Func<int, bool> onItemLongClick;

		// Token: 0x040204C3 RID: 132291
		[Token(Token = "0x40204C3")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public Action<int> onReduceClick;

		// Token: 0x040204C4 RID: 132292
		[Token(Token = "0x40204C4")]
		private const string RED = "#c3452c";

		// Token: 0x040204C5 RID: 132293
		[Token(Token = "0x40204C5")]
		private const string NEED_COUNT_HTML_ENOUGH = "<color=#d6d560>{0}</color><color=#a8a8a8>/{1}</color>";

		// Token: 0x040204C6 RID: 132294
		[Token(Token = "0x40204C6")]
		private const string NEED_COUNT_HTML_SHORT = "<color=#c3452c>{0}</color><color=#a8a8a8>/{1}</color>";

		// Token: 0x040204C7 RID: 132295
		[Token(Token = "0x40204C7")]
		private const string PROD_COUNT_HTML_SHORT = "<color=#ffffff>{0}</color><color=#a8a8a8>/{1}</color>";

		// Token: 0x040204C8 RID: 132296
		[Token(Token = "0x40204C8")]
		private const int MAX_COUNT = 9999;

		// Token: 0x040204CA RID: 132298
		[Token(Token = "0x40204CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x040204CB RID: 132299
		[Token(Token = "0x40204CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x040204CC RID: 132300
		[Token(Token = "0x40204CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040204CD RID: 132301
		[Token(Token = "0x40204CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetOption;

		// Token: 0x040204CE RID: 132302
		[Token(Token = "0x40204CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x040204CF RID: 132303
		[Token(Token = "0x40204CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x040204D0 RID: 132304
		[Token(Token = "0x40204D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isCardClickable;

		// Token: 0x040204D1 RID: 132305
		[Token(Token = "0x40204D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isCardClickable;

		// Token: 0x040204D2 RID: 132306
		[Token(Token = "0x40204D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetRarityBkg;

		// Token: 0x040204D3 RID: 132307
		[Token(Token = "0x40204D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040204D4 RID: 132308
		[Token(Token = "0x40204D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventReduceBtnClick;

		// Token: 0x040204D5 RID: 132309
		[Token(Token = "0x40204D5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnClick;

		// Token: 0x040204D6 RID: 132310
		[Token(Token = "0x40204D6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnLongClick;

		// Token: 0x040204D7 RID: 132311
		[Token(Token = "0x40204D7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetButtonGO;

		// Token: 0x040204D8 RID: 132312
		[Token(Token = "0x40204D8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004121 RID: 16673
		[Token(Token = "0x2004121")]
		public enum CountShowType
		{
			// Token: 0x040204DA RID: 132314
			[Token(Token = "0x40204DA")]
			NONE,
			// Token: 0x040204DB RID: 132315
			[Token(Token = "0x40204DB")]
			HIDE = 0,
			// Token: 0x040204DC RID: 132316
			[Token(Token = "0x40204DC")]
			SINGLE_SHOW,
			// Token: 0x040204DD RID: 132317
			[Token(Token = "0x40204DD")]
			MULTI_SHOW,
			// Token: 0x040204DE RID: 132318
			[Token(Token = "0x40204DE")]
			PLUS_PREFIX = 4,
			// Token: 0x040204DF RID: 132319
			[Token(Token = "0x40204DF")]
			SHOW = 3
		}

		// Token: 0x02004122 RID: 16674
		[Token(Token = "0x2004122")]
		public enum SelectShowType
		{
			// Token: 0x040204E1 RID: 132321
			[Token(Token = "0x40204E1")]
			NONE,
			// Token: 0x040204E2 RID: 132322
			[Token(Token = "0x40204E2")]
			SHOW_COUNT,
			// Token: 0x040204E3 RID: 132323
			[Token(Token = "0x40204E3")]
			SHOW_REDUCE_BTN,
			// Token: 0x040204E4 RID: 132324
			[Token(Token = "0x40204E4")]
			DEFAULT
		}

		// Token: 0x02004123 RID: 16675
		[Token(Token = "0x2004123")]
		public enum MaxCountUsage
		{
			// Token: 0x040204E6 RID: 132326
			[Token(Token = "0x40204E6")]
			NONE,
			// Token: 0x040204E7 RID: 132327
			[Token(Token = "0x40204E7")]
			NEED,
			// Token: 0x040204E8 RID: 132328
			[Token(Token = "0x40204E8")]
			MAX_PRODUCE
		}

		// Token: 0x02004124 RID: 16676
		[Token(Token = "0x2004124")]
		public struct Option
		{
			// Token: 0x040204E9 RID: 132329
			[Token(Token = "0x40204E9")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2ItemCard.CountShowType countShowType;

			// Token: 0x040204EA RID: 132330
			[Token(Token = "0x40204EA")]
			[FieldOffset(Offset = "0x4")]
			public SandboxV2ItemCard.SelectShowType selectShowType;

			// Token: 0x040204EB RID: 132331
			[Token(Token = "0x40204EB")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2ItemCard.MaxCountUsage maxCountUsage;

			// Token: 0x040204EC RID: 132332
			[Token(Token = "0x40204EC")]
			[FieldOffset(Offset = "0xC")]
			public bool hideBkg;

			// Token: 0x040204ED RID: 132333
			[Token(Token = "0x40204ED")]
			[FieldOffset(Offset = "0x10")]
			public string selectClr;

			// Token: 0x040204EE RID: 132334
			[Token(Token = "0x40204EE")]
			[FieldOffset(Offset = "0x18")]
			public float scale;

			// Token: 0x040204EF RID: 132335
			[Token(Token = "0x40204EF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SandboxV2ItemCard.Option Default;
		}
	}
}
