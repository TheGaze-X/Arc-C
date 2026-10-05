using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F1E RID: 24350
	[Token(Token = "0x2005F1E")]
	public class CharacterLvlupVoucherViewModel : IHotfixable
	{
		// Token: 0x06023460 RID: 144480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023460")]
		[Address(RVA = "0x1DCC350", Offset = "0x1DCAF50", VA = "0x181DCC350")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, string voucherItemId)
		{
		}

		// Token: 0x06023461 RID: 144481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023461")]
		[Address(RVA = "0x1DCC650", Offset = "0x1DCB250", VA = "0x181DCC650")]
		public CharacterLvlupVoucherViewModel()
		{
		}

		// Token: 0x040309F5 RID: 199157
		[Token(Token = "0x40309F5")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase evolvePhase;

		// Token: 0x040309F6 RID: 199158
		[Token(Token = "0x40309F6")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x040309F7 RID: 199159
		[Token(Token = "0x40309F7")]
		[FieldOffset(Offset = "0x20")]
		public int potentialRank;

		// Token: 0x040309F8 RID: 199160
		[Token(Token = "0x40309F8")]
		[FieldOffset(Offset = "0x24")]
		public int mainSkillLvl;

		// Token: 0x040309F9 RID: 199161
		[Token(Token = "0x40309F9")]
		[FieldOffset(Offset = "0x28")]
		public string powerId;

		// Token: 0x040309FA RID: 199162
		[Token(Token = "0x40309FA")]
		[FieldOffset(Offset = "0x30")]
		public string charName;

		// Token: 0x040309FB RID: 199163
		[Token(Token = "0x40309FB")]
		[FieldOffset(Offset = "0x38")]
		public string charNickName;

		// Token: 0x040309FC RID: 199164
		[Token(Token = "0x40309FC")]
		[FieldOffset(Offset = "0x40")]
		public RarityRank rarity;

		// Token: 0x040309FD RID: 199165
		[Token(Token = "0x40309FD")]
		[FieldOffset(Offset = "0x48")]
		private PlayerCharacter m_playerChar;

		// Token: 0x040309FE RID: 199166
		[Token(Token = "0x40309FE")]
		[FieldOffset(Offset = "0x50")]
		private CharacterData m_charData;

		// Token: 0x040309FF RID: 199167
		[Token(Token = "0x40309FF")]
		[FieldOffset(Offset = "0x58")]
		public UplevelAttribute currentAttr;

		// Token: 0x04030A00 RID: 199168
		[Token(Token = "0x4030A00")]
		[FieldOffset(Offset = "0x68")]
		public int currentLevel;

		// Token: 0x04030A01 RID: 199169
		[Token(Token = "0x4030A01")]
		[FieldOffset(Offset = "0x6C")]
		public UplevelAttribute maxAttr;

		// Token: 0x04030A02 RID: 199170
		[Token(Token = "0x4030A02")]
		[FieldOffset(Offset = "0x7C")]
		public int maxLevel;

		// Token: 0x04030A03 RID: 199171
		[Token(Token = "0x4030A03")]
		[FieldOffset(Offset = "0x80")]
		public RequireViewModel requireViewModel;

		// Token: 0x04030A04 RID: 199172
		[Token(Token = "0x4030A04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A05 RID: 199173
		[Token(Token = "0x4030A05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
