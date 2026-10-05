using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x02002923 RID: 10531
	[Token(Token = "0x2002923")]
	public class RelicLevelPredefinedData : IHotfixable
	{
		// Token: 0x06011770 RID: 71536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011770")]
		[Address(RVA = "0x944B00", Offset = "0x943700", VA = "0x180944B00")]
		public RelicLevelPredefinedData(LevelData.PredefinedData data)
		{
		}

		// Token: 0x06011771 RID: 71537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011771")]
		[Address(RVA = "0x9449A0", Offset = "0x9435A0", VA = "0x1809449A0")]
		public LevelData.PredefinedData ConvertToLevelPredefinedData()
		{
			return null;
		}

		// Token: 0x0401385A RID: 79962
		[Token(Token = "0x401385A")]
		[FieldOffset(Offset = "0x10")]
		public List<LevelData.PredefinedData.PredefinedCharacter> characterInsts;

		// Token: 0x0401385B RID: 79963
		[Token(Token = "0x401385B")]
		[FieldOffset(Offset = "0x18")]
		public List<LevelData.PredefinedData.PredefinedCharacter> tokenInsts;

		// Token: 0x0401385C RID: 79964
		[Token(Token = "0x401385C")]
		[FieldOffset(Offset = "0x20")]
		public List<LevelData.PredefinedData.PredefinedCard> characterCards;

		// Token: 0x0401385D RID: 79965
		[Token(Token = "0x401385D")]
		[FieldOffset(Offset = "0x28")]
		public List<LevelData.PredefinedData.PredefinedTokenCard> tokenCards;

		// Token: 0x0401385E RID: 79966
		[Token(Token = "0x401385E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401385F RID: 79967
		[Token(Token = "0x401385F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConvertToLevelPredefinedData;
	}
}
