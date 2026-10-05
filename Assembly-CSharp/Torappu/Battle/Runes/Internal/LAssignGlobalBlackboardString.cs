using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E6 RID: 10470
	[Token(Token = "0x20028E6")]
	public class LAssignGlobalBlackboardString : BasicLevelRune
	{
		// Token: 0x0601166B RID: 71275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601166B")]
		[Address(RVA = "0x93CCF0", Offset = "0x93B8F0", VA = "0x18093CCF0")]
		protected LAssignGlobalBlackboardString()
		{
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0601166C RID: 71276 RVA: 0x0006B118 File Offset: 0x00069318
		[Token(Token = "0x1700267A")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601166C")]
			[Address(RVA = "0x93CDB0", Offset = "0x93B9B0", VA = "0x18093CDB0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601166D RID: 71277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601166D")]
		[Address(RVA = "0x93CA10", Offset = "0x93B610", VA = "0x18093CA10", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601166E RID: 71278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601166E")]
		[Address(RVA = "0x93CC00", Offset = "0x93B800", VA = "0x18093CC00", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x04013720 RID: 79648
		[Token(Token = "0x4013720")]
		[FieldOffset(Offset = "0x0")]
		private static string defaultChannel;

		// Token: 0x04013721 RID: 79649
		[Token(Token = "0x4013721")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013722 RID: 79650
		[Token(Token = "0x4013722")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013723 RID: 79651
		[Token(Token = "0x4013723")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013724 RID: 79652
		[Token(Token = "0x4013724")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
