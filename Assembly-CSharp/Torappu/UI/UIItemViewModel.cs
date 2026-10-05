using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200371F RID: 14111
	[Token(Token = "0x200371F")]
	public class UIItemViewModel : ISharedItemModel
	{
		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0601666D RID: 91757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601666E RID: 91758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035B7")]
		public IItemViewModelPlugin extPlugin
		{
			[Token(Token = "0x601666D")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601666E")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0601666F RID: 91759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035B8")]
		public Sprite iconSprite
		{
			[Token(Token = "0x601666F")]
			[Address(RVA = "0xED46A0", Offset = "0xED32A0", VA = "0x180ED46A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016670 RID: 91760 RVA: 0x000911A0 File Offset: 0x0008F3A0
		[Token(Token = "0x6016670")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06016671 RID: 91761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016671")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06016672 RID: 91762 RVA: 0x000911B8 File Offset: 0x0008F3B8
		[Token(Token = "0x6016672")]
		[Address(RVA = "0xED1D70", Offset = "0xED0970", VA = "0x180ED1D70", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06016673 RID: 91763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016673")]
		[Address(RVA = "0xED2560", Offset = "0xED1160", VA = "0x180ED2560", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x06016674 RID: 91764 RVA: 0x000911D0 File Offset: 0x0008F3D0
		[Token(Token = "0x6016674")]
		[Address(RVA = "0xED1D80", Offset = "0xED0980", VA = "0x180ED1D80")]
		public bool HasValidTs()
		{
			return default(bool);
		}

		// Token: 0x06016675 RID: 91765 RVA: 0x000911E8 File Offset: 0x0008F3E8
		[Token(Token = "0x6016675")]
		[Address(RVA = "0xED1D30", Offset = "0xED0930", VA = "0x180ED1D30")]
		public int GetExp()
		{
			return 0;
		}

		// Token: 0x06016676 RID: 91766 RVA: 0x00091200 File Offset: 0x0008F400
		[Token(Token = "0x6016676")]
		[Address(RVA = "0xED1CF0", Offset = "0xED08F0", VA = "0x180ED1CF0")]
		public int GetAp()
		{
			return 0;
		}

		// Token: 0x06016677 RID: 91767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016677")]
		[Address(RVA = "0xED1D90", Offset = "0xED0990", VA = "0x180ED1D90")]
		public void LoadGameData(string itemId, ItemType itemType)
		{
		}

		// Token: 0x06016678 RID: 91768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016678")]
		[Address(RVA = "0xED23A0", Offset = "0xED0FA0", VA = "0x180ED23A0")]
		public void LoadSpritesIfNeeded()
		{
		}

		// Token: 0x06016679 RID: 91769 RVA: 0x00091218 File Offset: 0x0008F418
		[Token(Token = "0x6016679")]
		public bool CheckPlugin<T>() where T : IItemViewModelPlugin
		{
			return default(bool);
		}

		// Token: 0x0601667A RID: 91770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601667A")]
		[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
		public void SetPlugin(IItemViewModelPlugin plugin)
		{
		}

		// Token: 0x0601667B RID: 91771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601667B")]
		public T GetPlugin<T>() where T : class, IItemViewModelPlugin
		{
			return null;
		}

		// Token: 0x0601667C RID: 91772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601667C")]
		public T GetPluginNotNull<T>() where T : class, IItemViewModelPlugin, new()
		{
			return null;
		}

		// Token: 0x0601667D RID: 91773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601667D")]
		[Address(RVA = "0xED2E10", Offset = "0xED1A10", VA = "0x180ED2E10")]
		private void _LoadDataItem(string itemId, ItemType itemType)
		{
		}

		// Token: 0x0601667E RID: 91774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601667E")]
		[Address(RVA = "0xED43A0", Offset = "0xED2FA0", VA = "0x180ED43A0")]
		private void _SortStageDropList()
		{
		}

		// Token: 0x0601667F RID: 91775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601667F")]
		[Address(RVA = "0xED32A0", Offset = "0xED1EA0", VA = "0x180ED32A0")]
		private void _LoadFurnitureAsItem(string itemId)
		{
		}

		// Token: 0x06016680 RID: 91776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016680")]
		[Address(RVA = "0xED2A60", Offset = "0xED1660", VA = "0x180ED2A60")]
		private void _LoadCharAsItem(string charId)
		{
		}

		// Token: 0x06016681 RID: 91777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016681")]
		[Address(RVA = "0xED3F30", Offset = "0xED2B30", VA = "0x180ED3F30")]
		private void _LoadSkinAsItem(string skinId)
		{
		}

		// Token: 0x06016682 RID: 91778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016682")]
		[Address(RVA = "0xED3B90", Offset = "0xED2790", VA = "0x180ED3B90")]
		private void _LoadPlayerAvatarItem(string itemId)
		{
		}

		// Token: 0x06016683 RID: 91779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016683")]
		[Address(RVA = "0xED2C50", Offset = "0xED1850", VA = "0x180ED2C50")]
		private void _LoadCharmItem(string itemId)
		{
		}

		// Token: 0x06016684 RID: 91780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016684")]
		[Address(RVA = "0xED3D80", Offset = "0xED2980", VA = "0x180ED3D80")]
		private void _LoadSandboxV2Item(string sandboxPermItemId)
		{
		}

		// Token: 0x06016685 RID: 91781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016685")]
		[Address(RVA = "0xED26C0", Offset = "0xED12C0", VA = "0x180ED26C0")]
		private void _LoadAct1VHalfIdleItem(string halfItemId)
		{
		}

		// Token: 0x06016686 RID: 91782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016686")]
		[Address(RVA = "0xED2820", Offset = "0xED1420", VA = "0x180ED2820")]
		private void _LoadCarItem(string itemId)
		{
		}

		// Token: 0x06016687 RID: 91783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016687")]
		[Address(RVA = "0xED34C0", Offset = "0xED20C0", VA = "0x180ED34C0")]
		private void _LoadHomeBackgroundItem(string itemId)
		{
		}

		// Token: 0x06016688 RID: 91784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016688")]
		[Address(RVA = "0xED3670", Offset = "0xED2270", VA = "0x180ED3670")]
		private void _LoadHomeThemeItem(string itemId)
		{
		}

		// Token: 0x06016689 RID: 91785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016689")]
		[Address(RVA = "0xED39F0", Offset = "0xED25F0", VA = "0x180ED39F0")]
		private void _LoadNameCardSkinItem(string itemId)
		{
		}

		// Token: 0x0601668A RID: 91786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601668A")]
		[Address(RVA = "0xED3810", Offset = "0xED2410", VA = "0x180ED3810")]
		private void _LoadMagazineLeafItem(string leafId)
		{
		}

		// Token: 0x0601668B RID: 91787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601668B")]
		[Address(RVA = "0xED41C0", Offset = "0xED2DC0", VA = "0x180ED41C0")]
		private void _LoadStickerItem(string stickerId)
		{
		}

		// Token: 0x0601668C RID: 91788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601668C")]
		[Address(RVA = "0xED2570", Offset = "0xED1170", VA = "0x180ED2570")]
		private void _AddMetaValue(string key, int val)
		{
		}

		// Token: 0x0601668D RID: 91789 RVA: 0x00091230 File Offset: 0x0008F430
		[Token(Token = "0x601668D")]
		[Address(RVA = "0xED2640", Offset = "0xED1240", VA = "0x180ED2640")]
		private int _GetMetaValue(string key)
		{
			return 0;
		}

		// Token: 0x0601668E RID: 91790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601668E")]
		[Address(RVA = "0xED1B70", Offset = "0xED0770", VA = "0x180ED1B70")]
		public static UIItemViewModel FromSharedItemGetModel(ISharedItemModel from)
		{
			return null;
		}

		// Token: 0x0601668F RID: 91791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601668F")]
		[Address(RVA = "0xED2300", Offset = "0xED0F00", VA = "0x180ED2300")]
		public static void LoadPotentialDetail(UIItemViewModel cardModel, CharacterData data)
		{
		}

		// Token: 0x06016690 RID: 91792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016690")]
		[Address(RVA = "0xED4670", Offset = "0xED3270", VA = "0x180ED4670")]
		public UIItemViewModel()
		{
		}

		// Token: 0x0401AF1F RID: 110367
		[Token(Token = "0x401AF1F")]
		public const long UNLIMITED_VALID_TS = 0L;

		// Token: 0x0401AF20 RID: 110368
		[Token(Token = "0x401AF20")]
		private const string GAIN_EXP = "gainExp";

		// Token: 0x0401AF21 RID: 110369
		[Token(Token = "0x401AF21")]
		private const string GAIN_AP = "gainAp";

		// Token: 0x0401AF22 RID: 110370
		[Token(Token = "0x401AF22")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0401AF23 RID: 110371
		[Token(Token = "0x401AF23")]
		[FieldOffset(Offset = "0x18")]
		public string itemIconId;

		// Token: 0x0401AF24 RID: 110372
		[Token(Token = "0x401AF24")]
		[FieldOffset(Offset = "0x20")]
		public string stackIconId;

		// Token: 0x0401AF25 RID: 110373
		[Token(Token = "0x401AF25")]
		[FieldOffset(Offset = "0x28")]
		public ItemType type;

		// Token: 0x0401AF26 RID: 110374
		[Token(Token = "0x401AF26")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x0401AF27 RID: 110375
		[Token(Token = "0x401AF27")]
		[FieldOffset(Offset = "0x38")]
		public string description;

		// Token: 0x0401AF28 RID: 110376
		[Token(Token = "0x401AF28")]
		[FieldOffset(Offset = "0x40")]
		public string usage;

		// Token: 0x0401AF29 RID: 110377
		[Token(Token = "0x401AF29")]
		[FieldOffset(Offset = "0x48")]
		public string obtainApproach;

		// Token: 0x0401AF2A RID: 110378
		[Token(Token = "0x401AF2A")]
		[FieldOffset(Offset = "0x50")]
		public int sortId;

		// Token: 0x0401AF2B RID: 110379
		[Token(Token = "0x401AF2B")]
		[FieldOffset(Offset = "0x54")]
		public ItemRarity rarity;

		// Token: 0x0401AF2C RID: 110380
		[Token(Token = "0x401AF2C")]
		[FieldOffset(Offset = "0x58")]
		public RarityRank charRarity;

		// Token: 0x0401AF2D RID: 110381
		[Token(Token = "0x401AF2D")]
		[FieldOffset(Offset = "0x5C")]
		public ItemClassifyType classifyType;

		// Token: 0x0401AF2E RID: 110382
		[Token(Token = "0x401AF2E")]
		[FieldOffset(Offset = "0x60")]
		public int furnitureRarity;

		// Token: 0x0401AF2F RID: 110383
		[Token(Token = "0x401AF2F")]
		[FieldOffset(Offset = "0x64")]
		public CharmRarity charmRarity;

		// Token: 0x0401AF30 RID: 110384
		[Token(Token = "0x401AF30")]
		[FieldOffset(Offset = "0x68")]
		public List<KeyValuePair<string, OccPer>> dropMap;

		// Token: 0x0401AF31 RID: 110385
		[Token(Token = "0x401AF31")]
		[FieldOffset(Offset = "0x70")]
		public List<ItemData.StageDropInfo> stageDrop;

		// Token: 0x0401AF32 RID: 110386
		[Token(Token = "0x401AF32")]
		[FieldOffset(Offset = "0x78")]
		public List<ItemData.BuildingProductInfo> buildingProduct;

		// Token: 0x0401AF33 RID: 110387
		[Token(Token = "0x401AF33")]
		[FieldOffset(Offset = "0x80")]
		public List<ItemData.VoucherRelateInfo> voucherRelate;

		// Token: 0x0401AF34 RID: 110388
		[Token(Token = "0x401AF34")]
		[FieldOffset(Offset = "0x88")]
		public List<ItemData.ShopRelateInfo> shopRelateInfo;

		// Token: 0x0401AF35 RID: 110389
		[Token(Token = "0x401AF35")]
		[FieldOffset(Offset = "0x90")]
		public List<ItemBundle> itemPackContent;

		// Token: 0x0401AF36 RID: 110390
		[Token(Token = "0x401AF36")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<string, int> m_metaValue;

		// Token: 0x0401AF37 RID: 110391
		[Token(Token = "0x401AF37")]
		[FieldOffset(Offset = "0xA0")]
		public bool hideInItemGet;

		// Token: 0x0401AF39 RID: 110393
		[Token(Token = "0x401AF39")]
		[FieldOffset(Offset = "0xB0")]
		public long maxItemCount;

		// Token: 0x0401AF3A RID: 110394
		[Token(Token = "0x401AF3A")]
		[FieldOffset(Offset = "0xB8")]
		public long selectedCount;

		// Token: 0x0401AF3B RID: 110395
		[Token(Token = "0x401AF3B")]
		[FieldOffset(Offset = "0xC0")]
		public long requireCount;

		// Token: 0x0401AF3C RID: 110396
		[Token(Token = "0x401AF3C")]
		[FieldOffset(Offset = "0xC8")]
		public long itemCount;

		// Token: 0x0401AF3D RID: 110397
		[Token(Token = "0x401AF3D")]
		[FieldOffset(Offset = "0xD0")]
		public long validTs;

		// Token: 0x0401AF3E RID: 110398
		[Token(Token = "0x401AF3E")]
		[FieldOffset(Offset = "0xD8")]
		public int instId;

		// Token: 0x0401AF3F RID: 110399
		[Token(Token = "0x401AF3F")]
		[FieldOffset(Offset = "0xE0")]
		private string m_loadedId;

		// Token: 0x0401AF40 RID: 110400
		[Token(Token = "0x401AF40")]
		[FieldOffset(Offset = "0xE8")]
		private string m_loadedIconId;

		// Token: 0x0401AF41 RID: 110401
		[Token(Token = "0x401AF41")]
		[FieldOffset(Offset = "0xF0")]
		private ItemRarity m_loadedRarity;

		// Token: 0x0401AF42 RID: 110402
		[Token(Token = "0x401AF42")]
		[FieldOffset(Offset = "0xF8")]
		private Sprite m_iconSprite;
	}
}
