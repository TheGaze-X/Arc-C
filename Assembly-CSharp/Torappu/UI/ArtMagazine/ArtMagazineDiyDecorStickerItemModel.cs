using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657B RID: 25979
	[Token(Token = "0x200657B")]
	public class ArtMagazineDiyDecorStickerItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x060255C6 RID: 153030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005848")]
		public override string id
		{
			[Token(Token = "0x60255C6")]
			[Address(RVA = "0x2046670", Offset = "0x2045270", VA = "0x182046670", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x060255C7 RID: 153031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005849")]
		public override string itemId
		{
			[Token(Token = "0x60255C7")]
			[Address(RVA = "0x20466D0", Offset = "0x20452D0", VA = "0x1820466D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x060255C8 RID: 153032 RVA: 0x000C7A88 File Offset: 0x000C5C88
		[Token(Token = "0x1700584A")]
		public override ItemType itemType
		{
			[Token(Token = "0x60255C8")]
			[Address(RVA = "0x2046730", Offset = "0x2045330", VA = "0x182046730", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x060255C9 RID: 153033 RVA: 0x000C7AA0 File Offset: 0x000C5CA0
		[Token(Token = "0x1700584B")]
		public override int templateId
		{
			[Token(Token = "0x60255C9")]
			[Address(RVA = "0x20467F0", Offset = "0x20453F0", VA = "0x1820467F0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x060255CA RID: 153034 RVA: 0x000C7AB8 File Offset: 0x000C5CB8
		[Token(Token = "0x1700584C")]
		public override int sortId
		{
			[Token(Token = "0x60255CA")]
			[Address(RVA = "0x2046790", Offset = "0x2045390", VA = "0x182046790", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060255CB RID: 153035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255CB")]
		[Address(RVA = "0x20464A0", Offset = "0x20450A0", VA = "0x1820464A0")]
		public void LoadData(string stickerId, long getTs)
		{
		}

		// Token: 0x060255CC RID: 153036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255CC")]
		[Address(RVA = "0x20465D0", Offset = "0x20451D0", VA = "0x1820465D0")]
		public ArtMagazineDiyDecorStickerItemModel()
		{
		}

		// Token: 0x040346DB RID: 214747
		[Token(Token = "0x40346DB")]
		[FieldOffset(Offset = "0x10")]
		public string stickerPicId;

		// Token: 0x040346DC RID: 214748
		[Token(Token = "0x40346DC")]
		[FieldOffset(Offset = "0x18")]
		public long getTs;

		// Token: 0x040346DD RID: 214749
		[Token(Token = "0x40346DD")]
		[FieldOffset(Offset = "0x20")]
		private string m_stickerId;

		// Token: 0x040346DE RID: 214750
		[Token(Token = "0x40346DE")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x040346DF RID: 214751
		[Token(Token = "0x40346DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x040346E0 RID: 214752
		[Token(Token = "0x40346E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x040346E1 RID: 214753
		[Token(Token = "0x40346E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x040346E2 RID: 214754
		[Token(Token = "0x40346E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x040346E3 RID: 214755
		[Token(Token = "0x40346E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x040346E4 RID: 214756
		[Token(Token = "0x40346E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346E5 RID: 214757
		[Token(Token = "0x40346E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
