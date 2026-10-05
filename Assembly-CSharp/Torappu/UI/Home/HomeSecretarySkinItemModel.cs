using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B7F RID: 19327
	[Token(Token = "0x2004B7F")]
	public class HomeSecretarySkinItemModel : IHotfixable, IComparable<HomeSecretarySkinItemModel>
	{
		// Token: 0x0601D16B RID: 119147 RVA: 0x000AA598 File Offset: 0x000A8798
		[Token(Token = "0x601D16B")]
		[Address(RVA = "0x16A8620", Offset = "0x16A7220", VA = "0x1816A8620", Slot = "4")]
		public int CompareTo(HomeSecretarySkinItemModel other)
		{
			return 0;
		}

		// Token: 0x0601D16C RID: 119148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D16C")]
		[Address(RVA = "0x16A8740", Offset = "0x16A7340", VA = "0x1816A8740")]
		public HomeSecretarySkinItemModel()
		{
		}

		// Token: 0x040262C3 RID: 156355
		[Token(Token = "0x40262C3")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x040262C4 RID: 156356
		[Token(Token = "0x40262C4")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x040262C5 RID: 156357
		[Token(Token = "0x40262C5")]
		[FieldOffset(Offset = "0x20")]
		public string uniqueSkinTag;

		// Token: 0x040262C6 RID: 156358
		[Token(Token = "0x40262C6")]
		[FieldOffset(Offset = "0x28")]
		public bool isEvolveSkin;

		// Token: 0x040262C7 RID: 156359
		[Token(Token = "0x40262C7")]
		[FieldOffset(Offset = "0x2C")]
		public EvolvePhase evolveSkinPhase;

		// Token: 0x040262C8 RID: 156360
		[Token(Token = "0x40262C8")]
		[FieldOffset(Offset = "0x30")]
		public bool isDynSkin;

		// Token: 0x040262C9 RID: 156361
		[Token(Token = "0x40262C9")]
		[FieldOffset(Offset = "0x31")]
		public bool showSpDynIllust;

		// Token: 0x040262CA RID: 156362
		[Token(Token = "0x40262CA")]
		[FieldOffset(Offset = "0x38")]
		public string skinGroupId;

		// Token: 0x040262CB RID: 156363
		[Token(Token = "0x40262CB")]
		[FieldOffset(Offset = "0x40")]
		public string avatarId;

		// Token: 0x040262CC RID: 156364
		[Token(Token = "0x40262CC")]
		[FieldOffset(Offset = "0x48")]
		public string charNickName;

		// Token: 0x040262CD RID: 156365
		[Token(Token = "0x40262CD")]
		[FieldOffset(Offset = "0x50")]
		public string charRealName;

		// Token: 0x040262CE RID: 156366
		[Token(Token = "0x40262CE")]
		[FieldOffset(Offset = "0x58")]
		public string skinName;

		// Token: 0x040262CF RID: 156367
		[Token(Token = "0x40262CF")]
		[FieldOffset(Offset = "0x60")]
		public RarityRank charRarity;

		// Token: 0x040262D0 RID: 156368
		[Token(Token = "0x40262D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040262D1 RID: 156369
		[Token(Token = "0x40262D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
