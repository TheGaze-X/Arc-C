using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200130E RID: 4878
	[Token(Token = "0x200130E")]
	public class ShopRecommendTemplateParam
	{
		// Token: 0x06007287 RID: 29319 RVA: 0x00032E68 File Offset: 0x00031068
		[Token(Token = "0x6007287")]
		[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420", Slot = "4")]
		public virtual bool ShouldSerializenormalGiftParam()
		{
			return default(bool);
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00032E80 File Offset: 0x00031080
		[Token(Token = "0x6007288")]
		[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770", Slot = "5")]
		public virtual bool ShouldSerializenormalSkinParam()
		{
			return default(bool);
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x00032E98 File Offset: 0x00031098
		[Token(Token = "0x6007289")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60", Slot = "6")]
		public virtual bool ShouldSerializenormalFurnParam()
		{
			return default(bool);
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x00032EB0 File Offset: 0x000310B0
		[Token(Token = "0x600728A")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "7")]
		public virtual bool ShouldSerializereturnSkinParam()
		{
			return default(bool);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendTemplateParam()
		{
		}

		// Token: 0x04006C1E RID: 27678
		[Token(Token = "0x4006C1E")]
		[FieldOffset(Offset = "0x10")]
		public ShopRecommendTemplateNormalGiftParam normalGiftParam;

		// Token: 0x04006C1F RID: 27679
		[Token(Token = "0x4006C1F")]
		[FieldOffset(Offset = "0x18")]
		public ShopRecommendTemplateNormalSkinParam normalSkinParam;

		// Token: 0x04006C20 RID: 27680
		[Token(Token = "0x4006C20")]
		[FieldOffset(Offset = "0x20")]
		public ShopRecommendTemplateNormalFurnParam normalFurnParam;

		// Token: 0x04006C21 RID: 27681
		[Token(Token = "0x4006C21")]
		[FieldOffset(Offset = "0x28")]
		public ShopRecommendTemplateReturnSkinParam returnSkinParam;
	}
}
