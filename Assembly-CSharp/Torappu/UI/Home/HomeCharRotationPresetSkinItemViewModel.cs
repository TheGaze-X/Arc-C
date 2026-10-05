using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF4 RID: 19188
	[Token(Token = "0x2004AF4")]
	public class HomeCharRotationPresetSkinItemViewModel : IComparable<HomeCharRotationPresetSkinItemViewModel>, IHotfixable
	{
		// Token: 0x0601CD27 RID: 118055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD27")]
		[Address(RVA = "0x1644810", Offset = "0x1643410", VA = "0x181644810")]
		public void LoadData(CharUISkinStruct skin, string uniqueSkinTag)
		{
		}

		// Token: 0x0601CD28 RID: 118056 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		[Token(Token = "0x601CD28")]
		[Address(RVA = "0x1644690", Offset = "0x1643290", VA = "0x181644690", Slot = "4")]
		public int CompareTo(HomeCharRotationPresetSkinItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601CD29 RID: 118057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD29")]
		[Address(RVA = "0x1644B50", Offset = "0x1643750", VA = "0x181644B50")]
		public HomeCharRotationPresetSkinItemViewModel()
		{
		}

		// Token: 0x04025D1C RID: 154908
		[Token(Token = "0x4025D1C")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04025D1D RID: 154909
		[Token(Token = "0x4025D1D")]
		[FieldOffset(Offset = "0x18")]
		public bool showSpDynIllust;

		// Token: 0x04025D1E RID: 154910
		[Token(Token = "0x4025D1E")]
		[FieldOffset(Offset = "0x20")]
		public string uniqueSkinTag;

		// Token: 0x04025D1F RID: 154911
		[Token(Token = "0x4025D1F")]
		[FieldOffset(Offset = "0x28")]
		public RarityRank charRarityRank;

		// Token: 0x04025D20 RID: 154912
		[Token(Token = "0x4025D20")]
		[FieldOffset(Offset = "0x30")]
		public string avatarId;

		// Token: 0x04025D21 RID: 154913
		[Token(Token = "0x4025D21")]
		[FieldOffset(Offset = "0x38")]
		public string skinName;

		// Token: 0x04025D22 RID: 154914
		[Token(Token = "0x4025D22")]
		[FieldOffset(Offset = "0x40")]
		public string charName;

		// Token: 0x04025D23 RID: 154915
		[Token(Token = "0x4025D23")]
		[FieldOffset(Offset = "0x48")]
		public int skinSortId;

		// Token: 0x04025D24 RID: 154916
		[Token(Token = "0x4025D24")]
		[FieldOffset(Offset = "0x4C")]
		public bool isProfileSkin;

		// Token: 0x04025D25 RID: 154917
		[Token(Token = "0x4025D25")]
		[FieldOffset(Offset = "0x50")]
		public int charSelectedSkinCount;

		// Token: 0x04025D26 RID: 154918
		[Token(Token = "0x4025D26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025D27 RID: 154919
		[Token(Token = "0x4025D27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04025D28 RID: 154920
		[Token(Token = "0x4025D28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
