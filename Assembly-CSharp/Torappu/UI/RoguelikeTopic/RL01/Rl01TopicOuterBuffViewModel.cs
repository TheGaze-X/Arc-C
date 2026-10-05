using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004667 RID: 18023
	[Token(Token = "0x2004667")]
	public class Rl01TopicOuterBuffViewModel : IHotfixable
	{
		// Token: 0x0601B5DB RID: 112091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5DB")]
		[Address(RVA = "0x14AF6F0", Offset = "0x14AE2F0", VA = "0x1814AF6F0")]
		public void LoadData()
		{
		}

		// Token: 0x0601B5DC RID: 112092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5DC")]
		[Address(RVA = "0x14AF7B0", Offset = "0x14AE3B0", VA = "0x1814AF7B0")]
		public void SetNodeSelected(string buffId)
		{
		}

		// Token: 0x0601B5DD RID: 112093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5DD")]
		[Address(RVA = "0x14AF930", Offset = "0x14AE530", VA = "0x1814AF930")]
		public Rl01TopicOuterBuffViewModel()
		{
		}

		// Token: 0x040235D7 RID: 144855
		[Token(Token = "0x40235D7")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x040235D8 RID: 144856
		[Token(Token = "0x40235D8")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicOuterBuffListProperty buffListProperty;

		// Token: 0x040235D9 RID: 144857
		[Token(Token = "0x40235D9")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicOuterBuffSkillTreeProperty skillTreeProperty;

		// Token: 0x040235DA RID: 144858
		[Token(Token = "0x40235DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040235DB RID: 144859
		[Token(Token = "0x40235DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetNodeSelected;

		// Token: 0x040235DC RID: 144860
		[Token(Token = "0x40235DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
