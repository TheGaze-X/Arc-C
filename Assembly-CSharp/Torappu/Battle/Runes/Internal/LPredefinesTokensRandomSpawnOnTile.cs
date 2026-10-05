using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DF RID: 10463
	[Token(Token = "0x20028DF")]
	public class LPredefinesTokensRandomSpawnOnTile : BasicLevelRune
	{
		// Token: 0x06011643 RID: 71235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011643")]
		[Address(RVA = "0x9433D0", Offset = "0x941FD0", VA = "0x1809433D0")]
		protected LPredefinesTokensRandomSpawnOnTile()
		{
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x06011644 RID: 71236 RVA: 0x0006B040 File Offset: 0x00069240
		[Token(Token = "0x17002673")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011644")]
			[Address(RVA = "0x943470", Offset = "0x942070", VA = "0x180943470", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011645 RID: 71237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011645")]
		[Address(RVA = "0x942BE0", Offset = "0x9417E0", VA = "0x180942BE0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011646 RID: 71238 RVA: 0x0006B058 File Offset: 0x00069258
		[Token(Token = "0x6011646")]
		[Address(RVA = "0x9432C0", Offset = "0x941EC0", VA = "0x1809432C0")]
		private bool _CheckPosValid(LevelData.PredefinedData.PredefinedCharacter token, GridPosition tilePos)
		{
			return default(bool);
		}

		// Token: 0x06011647 RID: 71239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011647")]
		[Address(RVA = "0x943260", Offset = "0x941E60", VA = "0x180943260", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136FC RID: 79612
		[Token(Token = "0x40136FC")]
		[FieldOffset(Offset = "0x20")]
		private LevelData.PredefinedData.PredefinedCharacter[] m_tokenInsts;

		// Token: 0x040136FD RID: 79613
		[Token(Token = "0x40136FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136FE RID: 79614
		[Token(Token = "0x40136FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136FF RID: 79615
		[Token(Token = "0x40136FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013700 RID: 79616
		[Token(Token = "0x4013700")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckPosValid;

		// Token: 0x04013701 RID: 79617
		[Token(Token = "0x4013701")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
