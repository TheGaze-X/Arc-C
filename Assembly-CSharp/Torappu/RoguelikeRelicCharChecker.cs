using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200142E RID: 5166
	[Token(Token = "0x200142E")]
	public class RoguelikeRelicCharChecker : IHotfixable
	{
		// Token: 0x06007794 RID: 30612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007794")]
		[Address(RVA = "0x253A9F0", Offset = "0x25395F0", VA = "0x18253A9F0")]
		public RoguelikeRelicCharChecker(List<RoguelikeGameRelicCheckType> checkTypes, List<RoguelikeGameRelicCheckParam> checkParams)
		{
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00035AD8 File Offset: 0x00033CD8
		[Token(Token = "0x6007795")]
		[Address(RVA = "0x253A0A0", Offset = "0x2538CA0", VA = "0x18253A0A0")]
		public bool Verify(PlayerRoguelikeV2.CurrentData.Char charData)
		{
			return default(bool);
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x00035AF0 File Offset: 0x00033CF0
		[Token(Token = "0x6007796")]
		[Address(RVA = "0x253A5F0", Offset = "0x25391F0", VA = "0x18253A5F0")]
		private bool _Check(PlayerRoguelikeV2.CurrentData.Char charData, RoguelikeGameRelicCheckType checkType, RoguelikeGameRelicCheckParam checkParam)
		{
			return default(bool);
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00035B08 File Offset: 0x00033D08
		[Token(Token = "0x6007797")]
		[Address(RVA = "0x253A200", Offset = "0x2538E00", VA = "0x18253A200")]
		private bool _CheckProfession(PlayerRoguelikeV2.CurrentData.Char charData, RoguelikeGameRelicCheckParam checkParam)
		{
			return default(bool);
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00035B20 File Offset: 0x00033D20
		[Token(Token = "0x6007798")]
		[Address(RVA = "0x253A340", Offset = "0x2538F40", VA = "0x18253A340")]
		private bool _CheckSubProfession(PlayerRoguelikeV2.CurrentData.Char charData, RoguelikeGameRelicCheckParam checkParam)
		{
			return default(bool);
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00035B38 File Offset: 0x00033D38
		[Token(Token = "0x6007799")]
		[Address(RVA = "0x253A4A0", Offset = "0x25390A0", VA = "0x18253A4A0")]
		private bool _CheckUpgrade(PlayerRoguelikeV2.CurrentData.Char charData, RoguelikeGameRelicCheckParam checkParam)
		{
			return default(bool);
		}

		// Token: 0x04007506 RID: 29958
		[Token(Token = "0x4007506")]
		[FieldOffset(Offset = "0x10")]
		private List<RoguelikeGameRelicCheckType> m_checkTypes;

		// Token: 0x04007507 RID: 29959
		[Token(Token = "0x4007507")]
		[FieldOffset(Offset = "0x18")]
		private List<RoguelikeGameRelicCheckParam> m_checkParams;

		// Token: 0x04007508 RID: 29960
		[Token(Token = "0x4007508")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007509 RID: 29961
		[Token(Token = "0x4007509")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Verify;

		// Token: 0x0400750A RID: 29962
		[Token(Token = "0x400750A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Check;

		// Token: 0x0400750B RID: 29963
		[Token(Token = "0x400750B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckProfession;

		// Token: 0x0400750C RID: 29964
		[Token(Token = "0x400750C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckSubProfession;

		// Token: 0x0400750D RID: 29965
		[Token(Token = "0x400750D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckUpgrade;
	}
}
