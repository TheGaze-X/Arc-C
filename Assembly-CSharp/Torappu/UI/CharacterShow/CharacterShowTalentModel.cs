using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE3 RID: 24035
	[Token(Token = "0x2005DE3")]
	public class CharacterShowTalentModel : IHotfixable
	{
		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x06022D54 RID: 142676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005271")]
		public string name
		{
			[Token(Token = "0x6022D54")]
			[Address(RVA = "0x1D704A0", Offset = "0x1D6F0A0", VA = "0x181D704A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x06022D55 RID: 142677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005272")]
		public string desc
		{
			[Token(Token = "0x6022D55")]
			[Address(RVA = "0x1D70380", Offset = "0x1D6EF80", VA = "0x181D70380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x06022D56 RID: 142678 RVA: 0x000BF280 File Offset: 0x000BD480
		[Token(Token = "0x17005273")]
		public CharacterData.UnlockCondition initUnlockCondition
		{
			[Token(Token = "0x6022D56")]
			[Address(RVA = "0x1D70430", Offset = "0x1D6F030", VA = "0x181D70430")]
			get
			{
				return default(CharacterData.UnlockCondition);
			}
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x06022D57 RID: 142679 RVA: 0x000BF298 File Offset: 0x000BD498
		[Token(Token = "0x17005274")]
		public CharacterShowTalentModel.UnlockType unlockType
		{
			[Token(Token = "0x6022D57")]
			[Address(RVA = "0x1D70590", Offset = "0x1D6F190", VA = "0x181D70590")]
			get
			{
				return CharacterShowTalentModel.UnlockType.NONE;
			}
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x06022D58 RID: 142680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005275")]
		public string tokenKey
		{
			[Token(Token = "0x6022D58")]
			[Address(RVA = "0x1D70530", Offset = "0x1D6F130", VA = "0x181D70530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022D59 RID: 142681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D59")]
		[Address(RVA = "0x1D70070", Offset = "0x1D6EC70", VA = "0x181D70070")]
		public void LoadData(TalentData initTalentData, TalentData finalTalentData)
		{
		}

		// Token: 0x06022D5A RID: 142682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D5A")]
		[Address(RVA = "0x1D701B0", Offset = "0x1D6EDB0", VA = "0x181D701B0")]
		public void LoadEquipNewTalent(EquipTalentData equipTalentData)
		{
		}

		// Token: 0x06022D5B RID: 142683 RVA: 0x000BF2B0 File Offset: 0x000BD4B0
		[Token(Token = "0x6022D5B")]
		[Address(RVA = "0x1D70260", Offset = "0x1D6EE60", VA = "0x181D70260")]
		private CharacterShowTalentModel.UnlockType _UpdateUnlockType(TalentData initTalentData)
		{
			return CharacterShowTalentModel.UnlockType.NONE;
		}

		// Token: 0x06022D5C RID: 142684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D5C")]
		[Address(RVA = "0x1D70320", Offset = "0x1D6EF20", VA = "0x181D70320")]
		public CharacterShowTalentModel()
		{
		}

		// Token: 0x0402FF15 RID: 196373
		[Token(Token = "0x402FF15")]
		[FieldOffset(Offset = "0x10")]
		private CharacterShowTalentModel.UnlockType m_unlockType;

		// Token: 0x0402FF16 RID: 196374
		[Token(Token = "0x402FF16")]
		[FieldOffset(Offset = "0x18")]
		private TalentData m_initTalentData;

		// Token: 0x0402FF17 RID: 196375
		[Token(Token = "0x402FF17")]
		[FieldOffset(Offset = "0x20")]
		private TalentData m_finalTalentData;

		// Token: 0x0402FF18 RID: 196376
		[Token(Token = "0x402FF18")]
		[FieldOffset(Offset = "0x28")]
		private string m_tokenKey;

		// Token: 0x0402FF19 RID: 196377
		[Token(Token = "0x402FF19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402FF1A RID: 196378
		[Token(Token = "0x402FF1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402FF1B RID: 196379
		[Token(Token = "0x402FF1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initUnlockCondition;

		// Token: 0x0402FF1C RID: 196380
		[Token(Token = "0x402FF1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_unlockType;

		// Token: 0x0402FF1D RID: 196381
		[Token(Token = "0x402FF1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tokenKey;

		// Token: 0x0402FF1E RID: 196382
		[Token(Token = "0x402FF1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FF1F RID: 196383
		[Token(Token = "0x402FF1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadEquipNewTalent;

		// Token: 0x0402FF20 RID: 196384
		[Token(Token = "0x402FF20")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateUnlockType;

		// Token: 0x0402FF21 RID: 196385
		[Token(Token = "0x402FF21")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DE4 RID: 24036
		[Token(Token = "0x2005DE4")]
		public enum UnlockType
		{
			// Token: 0x0402FF23 RID: 196387
			[Token(Token = "0x402FF23")]
			NONE,
			// Token: 0x0402FF24 RID: 196388
			[Token(Token = "0x402FF24")]
			LEVEL_UP,
			// Token: 0x0402FF25 RID: 196389
			[Token(Token = "0x402FF25")]
			EVOLVE_ONE,
			// Token: 0x0402FF26 RID: 196390
			[Token(Token = "0x402FF26")]
			EVOLVE_TWO,
			// Token: 0x0402FF27 RID: 196391
			[Token(Token = "0x402FF27")]
			UPDATE_EQUIP
		}
	}
}
