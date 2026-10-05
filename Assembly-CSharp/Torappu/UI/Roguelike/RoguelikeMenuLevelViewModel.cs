using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200534B RID: 21323
	[Token(Token = "0x200534B")]
	public class RoguelikeMenuLevelViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F712 RID: 128786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F712")]
		[Address(RVA = "0x1928750", Offset = "0x1927350", VA = "0x181928750", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F713 RID: 128787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F713")]
		[Address(RVA = "0x1928A90", Offset = "0x1927690", VA = "0x181928A90")]
		private void _LoadNormalNextLevelInfo(string theme)
		{
		}

		// Token: 0x0601F714 RID: 128788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F714")]
		[Address(RVA = "0x1928B90", Offset = "0x1927790", VA = "0x181928B90")]
		private void _LoadSpecialNextLevelInfo(string theme, RoguelikeTopicMode mode, string predefinedId, int modeGrade)
		{
		}

		// Token: 0x0601F715 RID: 128789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F715")]
		[Address(RVA = "0x1928CB0", Offset = "0x19278B0", VA = "0x181928CB0")]
		public RoguelikeMenuLevelViewModel()
		{
		}

		// Token: 0x0601F716 RID: 128790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F716")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4C5 RID: 173253
		[Token(Token = "0x402A4C5")]
		[FieldOffset(Offset = "0x18")]
		public int maxLevel;

		// Token: 0x0402A4C6 RID: 173254
		[Token(Token = "0x402A4C6")]
		[FieldOffset(Offset = "0x1C")]
		public int currLevel;

		// Token: 0x0402A4C7 RID: 173255
		[Token(Token = "0x402A4C7")]
		[FieldOffset(Offset = "0x20")]
		public int currExp;

		// Token: 0x0402A4C8 RID: 173256
		[Token(Token = "0x402A4C8")]
		[FieldOffset(Offset = "0x24")]
		public int nextExp;

		// Token: 0x0402A4C9 RID: 173257
		[Token(Token = "0x402A4C9")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicDetailConst.PlayerLevelData nextLevelData;

		// Token: 0x0402A4CA RID: 173258
		[Token(Token = "0x402A4CA")]
		[FieldOffset(Offset = "0x30")]
		public bool isUseSpExpStyle;

		// Token: 0x0402A4CB RID: 173259
		[Token(Token = "0x402A4CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4CC RID: 173260
		[Token(Token = "0x402A4CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadNormalNextLevelInfo;

		// Token: 0x0402A4CD RID: 173261
		[Token(Token = "0x402A4CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSpecialNextLevelInfo;

		// Token: 0x0402A4CE RID: 173262
		[Token(Token = "0x402A4CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
