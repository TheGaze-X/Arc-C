using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004696 RID: 18070
	[Token(Token = "0x2004696")]
	public abstract class RoguelikeTopicActivityEntryCompBaseModel
	{
		// Token: 0x0601B6BB RID: 112315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6BB")]
		[Address(RVA = "0x14B1600", Offset = "0x14B0200", VA = "0x1814B1600")]
		public void LoadModel(string inputTopicId, string inputRlActId)
		{
		}

		// Token: 0x0601B6BC RID: 112316
		[Token(Token = "0x601B6BC")]
		protected abstract void _LoadModel(string inputTopicId, string inputRlActId);

		// Token: 0x0601B6BD RID: 112317
		[Token(Token = "0x601B6BD")]
		public abstract bool CheckIsActivityEnabledForCreateGame();

		// Token: 0x0601B6BE RID: 112318
		[Token(Token = "0x601B6BE")]
		public abstract RoguelikeTopicMode GetActivityValidMode();

		// Token: 0x0601B6BF RID: 112319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6BF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RoguelikeTopicActivityEntryCompBaseModel()
		{
		}

		// Token: 0x0402378B RID: 145291
		[Token(Token = "0x402378B")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402378C RID: 145292
		[Token(Token = "0x402378C")]
		[FieldOffset(Offset = "0x18")]
		public string rlActId;
	}
}
