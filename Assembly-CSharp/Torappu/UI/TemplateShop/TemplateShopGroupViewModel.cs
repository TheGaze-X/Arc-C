using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6C RID: 15724
	[Token(Token = "0x2003D6C")]
	public class TemplateShopGroupViewModel
	{
		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x060187BF RID: 100287 RVA: 0x0009A8F0 File Offset: 0x00098AF0
		[Token(Token = "0x17003A71")]
		public bool buyAllFlag
		{
			[Token(Token = "0x60187BF")]
			[Address(RVA = "0x10F4A30", Offset = "0x10F3630", VA = "0x1810F4A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x060187C0 RID: 100288 RVA: 0x0009A908 File Offset: 0x00098B08
		[Token(Token = "0x17003A72")]
		public bool isUnlocked
		{
			[Token(Token = "0x60187C0")]
			[Address(RVA = "0x10F4B10", Offset = "0x10F3710", VA = "0x1810F4B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060187C1 RID: 100289 RVA: 0x0009A920 File Offset: 0x00098B20
		[Token(Token = "0x60187C1")]
		[Address(RVA = "0x10F48C0", Offset = "0x10F34C0", VA = "0x1810F48C0")]
		public bool IsGoodAllSoldout()
		{
			return default(bool);
		}

		// Token: 0x060187C2 RID: 100290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C2")]
		[Address(RVA = "0x10F49A0", Offset = "0x10F35A0", VA = "0x1810F49A0")]
		public TemplateShopGroupViewModel()
		{
		}

		// Token: 0x0401DFE3 RID: 122851
		[Token(Token = "0x401DFE3")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401DFE4 RID: 122852
		[Token(Token = "0x401DFE4")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x0401DFE5 RID: 122853
		[Token(Token = "0x401DFE5")]
		[FieldOffset(Offset = "0x20")]
		public string preGroupId;

		// Token: 0x0401DFE6 RID: 122854
		[Token(Token = "0x401DFE6")]
		[FieldOffset(Offset = "0x28")]
		public string unlockString;

		// Token: 0x0401DFE7 RID: 122855
		[Token(Token = "0x401DFE7")]
		[FieldOffset(Offset = "0x30")]
		public List<TemplateCommonShopGoodViewModel> goodList;

		// Token: 0x0401DFE8 RID: 122856
		[Token(Token = "0x401DFE8")]
		[FieldOffset(Offset = "0x38")]
		public bool preGroupBuyAllFlag;

		// Token: 0x0401DFE9 RID: 122857
		[Token(Token = "0x401DFE9")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isUnlocked;
	}
}
