using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006585 RID: 25989
	[Token(Token = "0x2006585")]
	public class ArtMagazineDiySkinItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x06025615 RID: 153109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700585F")]
		public override string id
		{
			[Token(Token = "0x6025615")]
			[Address(RVA = "0x20523A0", Offset = "0x2050FA0", VA = "0x1820523A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x06025616 RID: 153110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005860")]
		public override string itemId
		{
			[Token(Token = "0x6025616")]
			[Address(RVA = "0x2052400", Offset = "0x2051000", VA = "0x182052400", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x06025617 RID: 153111 RVA: 0x000C7BD8 File Offset: 0x000C5DD8
		[Token(Token = "0x17005861")]
		public override ItemType itemType
		{
			[Token(Token = "0x6025617")]
			[Address(RVA = "0x2052460", Offset = "0x2051060", VA = "0x182052460", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x06025618 RID: 153112 RVA: 0x000C7BF0 File Offset: 0x000C5DF0
		[Token(Token = "0x17005862")]
		public override int templateId
		{
			[Token(Token = "0x6025618")]
			[Address(RVA = "0x2052520", Offset = "0x2051120", VA = "0x182052520", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x06025619 RID: 153113 RVA: 0x000C7C08 File Offset: 0x000C5E08
		[Token(Token = "0x17005863")]
		public override int sortId
		{
			[Token(Token = "0x6025619")]
			[Address(RVA = "0x20524C0", Offset = "0x20510C0", VA = "0x1820524C0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602561A RID: 153114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602561A")]
		[Address(RVA = "0x2052020", Offset = "0x2050C20", VA = "0x182052020")]
		public void LoadData(string skinId, string skinTag, long ts)
		{
		}

		// Token: 0x0602561B RID: 153115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602561B")]
		[Address(RVA = "0x2052300", Offset = "0x2050F00", VA = "0x182052300")]
		public ArtMagazineDiySkinItemModel()
		{
		}

		// Token: 0x04034730 RID: 214832
		[Token(Token = "0x4034730")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04034731 RID: 214833
		[Token(Token = "0x4034731")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x04034732 RID: 214834
		[Token(Token = "0x4034732")]
		[FieldOffset(Offset = "0x20")]
		public string uniqueSkinTag;

		// Token: 0x04034733 RID: 214835
		[Token(Token = "0x4034733")]
		[FieldOffset(Offset = "0x28")]
		public bool isSpSkin;

		// Token: 0x04034734 RID: 214836
		[Token(Token = "0x4034734")]
		[FieldOffset(Offset = "0x2C")]
		public RarityRank charRarity;

		// Token: 0x04034735 RID: 214837
		[Token(Token = "0x4034735")]
		[FieldOffset(Offset = "0x30")]
		public ProfessionCategory charProfession;

		// Token: 0x04034736 RID: 214838
		[Token(Token = "0x4034736")]
		[FieldOffset(Offset = "0x38")]
		public long getTs;

		// Token: 0x04034737 RID: 214839
		[Token(Token = "0x4034737")]
		[FieldOffset(Offset = "0x40")]
		public int skinSortId;

		// Token: 0x04034738 RID: 214840
		[Token(Token = "0x4034738")]
		[FieldOffset(Offset = "0x48")]
		public string portraitId;

		// Token: 0x04034739 RID: 214841
		[Token(Token = "0x4034739")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0403473A RID: 214842
		[Token(Token = "0x403473A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0403473B RID: 214843
		[Token(Token = "0x403473B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x0403473C RID: 214844
		[Token(Token = "0x403473C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x0403473D RID: 214845
		[Token(Token = "0x403473D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403473E RID: 214846
		[Token(Token = "0x403473E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403473F RID: 214847
		[Token(Token = "0x403473F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
