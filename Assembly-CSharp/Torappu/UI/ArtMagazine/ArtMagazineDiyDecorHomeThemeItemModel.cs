using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006577 RID: 25975
	[Token(Token = "0x2006577")]
	public class ArtMagazineDiyDecorHomeThemeItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x060255A2 RID: 152994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005836")]
		public override string id
		{
			[Token(Token = "0x60255A2")]
			[Address(RVA = "0x2044890", Offset = "0x2043490", VA = "0x182044890", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x060255A3 RID: 152995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005837")]
		public override string itemId
		{
			[Token(Token = "0x60255A3")]
			[Address(RVA = "0x20448F0", Offset = "0x20434F0", VA = "0x1820448F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x060255A4 RID: 152996 RVA: 0x000C7938 File Offset: 0x000C5B38
		[Token(Token = "0x17005838")]
		public override ItemType itemType
		{
			[Token(Token = "0x60255A4")]
			[Address(RVA = "0x2044950", Offset = "0x2043550", VA = "0x182044950", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x060255A5 RID: 152997 RVA: 0x000C7950 File Offset: 0x000C5B50
		[Token(Token = "0x17005839")]
		public override int templateId
		{
			[Token(Token = "0x60255A5")]
			[Address(RVA = "0x2044A10", Offset = "0x2043610", VA = "0x182044A10", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x060255A6 RID: 152998 RVA: 0x000C7968 File Offset: 0x000C5B68
		[Token(Token = "0x1700583A")]
		public override int sortId
		{
			[Token(Token = "0x60255A6")]
			[Address(RVA = "0x20449B0", Offset = "0x20435B0", VA = "0x1820449B0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060255A7 RID: 152999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255A7")]
		[Address(RVA = "0x20446F0", Offset = "0x20432F0", VA = "0x1820446F0")]
		public void LoadData(string homeThemeId, long getTs)
		{
		}

		// Token: 0x060255A8 RID: 153000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255A8")]
		[Address(RVA = "0x20447F0", Offset = "0x20433F0", VA = "0x1820447F0")]
		public ArtMagazineDiyDecorHomeThemeItemModel()
		{
		}

		// Token: 0x040346A7 RID: 214695
		[Token(Token = "0x40346A7")]
		[FieldOffset(Offset = "0x10")]
		public string themePicId;

		// Token: 0x040346A8 RID: 214696
		[Token(Token = "0x40346A8")]
		[FieldOffset(Offset = "0x18")]
		public long getTs;

		// Token: 0x040346A9 RID: 214697
		[Token(Token = "0x40346A9")]
		[FieldOffset(Offset = "0x20")]
		private string m_homeThemeId;

		// Token: 0x040346AA RID: 214698
		[Token(Token = "0x40346AA")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x040346AB RID: 214699
		[Token(Token = "0x40346AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x040346AC RID: 214700
		[Token(Token = "0x40346AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x040346AD RID: 214701
		[Token(Token = "0x40346AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x040346AE RID: 214702
		[Token(Token = "0x40346AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x040346AF RID: 214703
		[Token(Token = "0x40346AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x040346B0 RID: 214704
		[Token(Token = "0x40346B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346B1 RID: 214705
		[Token(Token = "0x40346B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
