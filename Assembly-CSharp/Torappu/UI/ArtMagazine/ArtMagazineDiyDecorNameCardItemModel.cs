using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006579 RID: 25977
	[Token(Token = "0x2006579")]
	public class ArtMagazineDiyDecorNameCardItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x060255B4 RID: 153012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700583F")]
		public override string id
		{
			[Token(Token = "0x60255B4")]
			[Address(RVA = "0x20455D0", Offset = "0x20441D0", VA = "0x1820455D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x060255B5 RID: 153013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005840")]
		public override string itemId
		{
			[Token(Token = "0x60255B5")]
			[Address(RVA = "0x2045630", Offset = "0x2044230", VA = "0x182045630", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x060255B6 RID: 153014 RVA: 0x000C79E0 File Offset: 0x000C5BE0
		[Token(Token = "0x17005841")]
		public override ItemType itemType
		{
			[Token(Token = "0x60255B6")]
			[Address(RVA = "0x2045690", Offset = "0x2044290", VA = "0x182045690", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x060255B7 RID: 153015 RVA: 0x000C79F8 File Offset: 0x000C5BF8
		[Token(Token = "0x17005842")]
		public override int templateId
		{
			[Token(Token = "0x60255B7")]
			[Address(RVA = "0x2045750", Offset = "0x2044350", VA = "0x182045750", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x060255B8 RID: 153016 RVA: 0x000C7A10 File Offset: 0x000C5C10
		[Token(Token = "0x17005843")]
		public override int sortId
		{
			[Token(Token = "0x60255B8")]
			[Address(RVA = "0x20456F0", Offset = "0x20442F0", VA = "0x1820456F0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060255B9 RID: 153017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255B9")]
		[Address(RVA = "0x2045440", Offset = "0x2044040", VA = "0x182045440")]
		public void LoadData(string ncSkinId, int tmpl, long getTs)
		{
		}

		// Token: 0x060255BA RID: 153018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255BA")]
		[Address(RVA = "0x2045530", Offset = "0x2044130", VA = "0x182045530")]
		public ArtMagazineDiyDecorNameCardItemModel()
		{
		}

		// Token: 0x040346C1 RID: 214721
		[Token(Token = "0x40346C1")]
		[FieldOffset(Offset = "0x10")]
		public long getTs;

		// Token: 0x040346C2 RID: 214722
		[Token(Token = "0x40346C2")]
		[FieldOffset(Offset = "0x18")]
		private string m_nameCardSkinId;

		// Token: 0x040346C3 RID: 214723
		[Token(Token = "0x40346C3")]
		[FieldOffset(Offset = "0x20")]
		private int m_sortId;

		// Token: 0x040346C4 RID: 214724
		[Token(Token = "0x40346C4")]
		[FieldOffset(Offset = "0x24")]
		private int m_tmpl;

		// Token: 0x040346C5 RID: 214725
		[Token(Token = "0x40346C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x040346C6 RID: 214726
		[Token(Token = "0x40346C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x040346C7 RID: 214727
		[Token(Token = "0x40346C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x040346C8 RID: 214728
		[Token(Token = "0x40346C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x040346C9 RID: 214729
		[Token(Token = "0x40346C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x040346CA RID: 214730
		[Token(Token = "0x40346CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346CB RID: 214731
		[Token(Token = "0x40346CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
