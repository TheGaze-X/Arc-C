using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054B1 RID: 21681
	[Token(Token = "0x20054B1")]
	public class RoguelikeCharSelectSkillGroupViewModel : IHotfixable
	{
		// Token: 0x0601FE4B RID: 130635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE4B")]
		[Address(RVA = "0x1A00F20", Offset = "0x19FFB20", VA = "0x181A00F20")]
		public RoguelikeCharSelectSkillItemViewModel AchieveSkillModelById(string skillId)
		{
			return null;
		}

		// Token: 0x0601FE4C RID: 130636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE4C")]
		[Address(RVA = "0x1A01020", Offset = "0x19FFC20", VA = "0x181A01020")]
		public RoguelikeCharSelectSkillGroupViewModel()
		{
		}

		// Token: 0x0402B047 RID: 176199
		[Token(Token = "0x402B047")]
		[FieldOffset(Offset = "0x10")]
		public bool ableToSelectSkill;

		// Token: 0x0402B048 RID: 176200
		[Token(Token = "0x402B048")]
		[FieldOffset(Offset = "0x11")]
		public bool isSelfChar;

		// Token: 0x0402B049 RID: 176201
		[Token(Token = "0x402B049")]
		[FieldOffset(Offset = "0x12")]
		public bool isUpGraded;

		// Token: 0x0402B04A RID: 176202
		[Token(Token = "0x402B04A")]
		[FieldOffset(Offset = "0x18")]
		public string selectedSkillId;

		// Token: 0x0402B04B RID: 176203
		[Token(Token = "0x402B04B")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeCharSelectSkillItemViewModel[] skills;

		// Token: 0x0402B04C RID: 176204
		[Token(Token = "0x402B04C")]
		[FieldOffset(Offset = "0x28")]
		public int skillAllLevel;

		// Token: 0x0402B04D RID: 176205
		[Token(Token = "0x402B04D")]
		[FieldOffset(Offset = "0x30")]
		public string charId;

		// Token: 0x0402B04E RID: 176206
		[Token(Token = "0x402B04E")]
		[FieldOffset(Offset = "0x38")]
		public bool isEnabled;

		// Token: 0x0402B04F RID: 176207
		[Token(Token = "0x402B04F")]
		[FieldOffset(Offset = "0x40")]
		public string disableText;

		// Token: 0x0402B050 RID: 176208
		[Token(Token = "0x402B050")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AchieveSkillModelById;

		// Token: 0x0402B051 RID: 176209
		[Token(Token = "0x402B051")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
