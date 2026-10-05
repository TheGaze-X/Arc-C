using System;
using Il2CppDummyDll;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF9 RID: 15353
	[Token(Token = "0x2003BF9")]
	public class UniEquipArchiveEquipTypeViewModel
	{
		// Token: 0x06018038 RID: 98360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018038")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipArchiveEquipTypeViewModel()
		{
		}

		// Token: 0x0401D1BD RID: 119229
		[Token(Token = "0x401D1BD")]
		[FieldOffset(Offset = "0x10")]
		public string equipTypeName;

		// Token: 0x0401D1BE RID: 119230
		[Token(Token = "0x401D1BE")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0401D1BF RID: 119231
		[Token(Token = "0x401D1BF")]
		[FieldOffset(Offset = "0x20")]
		public UniEquipData data;

		// Token: 0x0401D1C0 RID: 119232
		[Token(Token = "0x401D1C0")]
		[FieldOffset(Offset = "0x28")]
		public PlayerCharEquipInfo playerEquip;

		// Token: 0x0401D1C1 RID: 119233
		[Token(Token = "0x401D1C1")]
		[FieldOffset(Offset = "0x30")]
		public bool isValid;
	}
}
