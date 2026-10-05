using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054B0 RID: 21680
	[Token(Token = "0x20054B0")]
	public class RoguelikeCharSelectSkillItemViewModel : SkillItemViewModel
	{
		// Token: 0x0601FE4A RID: 130634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE4A")]
		[Address(RVA = "0x1A01080", Offset = "0x19FFC80", VA = "0x181A01080")]
		public RoguelikeCharSelectSkillItemViewModel()
		{
		}

		// Token: 0x0402B044 RID: 176196
		[Token(Token = "0x402B044")]
		[FieldOffset(Offset = "0x88")]
		public bool isEnabled;

		// Token: 0x0402B045 RID: 176197
		[Token(Token = "0x402B045")]
		[FieldOffset(Offset = "0x90")]
		public string disableText;

		// Token: 0x0402B046 RID: 176198
		[Token(Token = "0x402B046")]
		[FieldOffset(Offset = "0x98")]
		public bool isShowSpecLevel;
	}
}
