using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F06 RID: 24326
	[Token(Token = "0x2005F06")]
	public class CharacterInfoPotentialStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060233F5 RID: 144373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F5")]
		[Address(RVA = "0x1DC2280", Offset = "0x1DC0E80", VA = "0x181DC2280")]
		public void LoadData(CharacterPotentialPage.Param param)
		{
		}

		// Token: 0x060233F6 RID: 144374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F6")]
		[Address(RVA = "0x1DC2530", Offset = "0x1DC1130", VA = "0x181DC2530")]
		public void RefreshData()
		{
		}

		// Token: 0x060233F7 RID: 144375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F7")]
		[Address(RVA = "0x1DC2740", Offset = "0x1DC1340", VA = "0x181DC2740")]
		public CharacterInfoPotentialStateBean()
		{
		}

		// Token: 0x04030906 RID: 198918
		[Token(Token = "0x4030906")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04030907 RID: 198919
		[Token(Token = "0x4030907")]
		[FieldOffset(Offset = "0x18")]
		public PlayerCharacter playerChar;

		// Token: 0x04030908 RID: 198920
		[Token(Token = "0x4030908")]
		[FieldOffset(Offset = "0x20")]
		public CharacterData charData;

		// Token: 0x04030909 RID: 198921
		[Token(Token = "0x4030909")]
		[FieldOffset(Offset = "0x28")]
		public CharacterInfoPotentialViewModel potentialViewModel;

		// Token: 0x0403090A RID: 198922
		[Token(Token = "0x403090A")]
		[FieldOffset(Offset = "0x30")]
		public bool ignoreNoClassicHint;

		// Token: 0x0403090B RID: 198923
		[Token(Token = "0x403090B")]
		[FieldOffset(Offset = "0x31")]
		public bool showFadeInAnim;

		// Token: 0x0403090C RID: 198924
		[Token(Token = "0x403090C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403090D RID: 198925
		[Token(Token = "0x403090D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403090E RID: 198926
		[Token(Token = "0x403090E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
