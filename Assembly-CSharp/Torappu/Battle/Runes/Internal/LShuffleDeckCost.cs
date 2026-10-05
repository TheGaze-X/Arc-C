using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E1 RID: 10465
	[Token(Token = "0x20028E1")]
	public class LShuffleDeckCost : BasicLevelRune
	{
		// Token: 0x0601164E RID: 71246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601164E")]
		[Address(RVA = "0x943840", Offset = "0x942440", VA = "0x180943840")]
		protected LShuffleDeckCost()
		{
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0601164F RID: 71247 RVA: 0x0006B088 File Offset: 0x00069288
		[Token(Token = "0x17002675")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601164F")]
			[Address(RVA = "0x9438E0", Offset = "0x9424E0", VA = "0x1809438E0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011650 RID: 71248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011650")]
		[Address(RVA = "0x9434D0", Offset = "0x9420D0", VA = "0x1809434D0", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011651 RID: 71249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011651")]
		[Address(RVA = "0x943750", Offset = "0x942350", VA = "0x180943750", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011652 RID: 71250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011652")]
		[Address(RVA = "0x9437E0", Offset = "0x9423E0", VA = "0x1809437E0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011653 RID: 71251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011653")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x04013707 RID: 79623
		[Token(Token = "0x4013707")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013708 RID: 79624
		[Token(Token = "0x4013708")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013709 RID: 79625
		[Token(Token = "0x4013709")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x0401370A RID: 79626
		[Token(Token = "0x401370A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x0401370B RID: 79627
		[Token(Token = "0x401370B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
