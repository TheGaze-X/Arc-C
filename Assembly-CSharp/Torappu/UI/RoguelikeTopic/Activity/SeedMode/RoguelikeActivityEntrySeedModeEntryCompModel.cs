using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x0200469B RID: 18075
	[Token(Token = "0x200469B")]
	public class RoguelikeActivityEntrySeedModeEntryCompModel : RoguelikeTopicActivityEntryCompBaseModel
	{
		// Token: 0x0601B6D3 RID: 112339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D3")]
		[Address(RVA = "0x14AFC30", Offset = "0x14AE830", VA = "0x1814AFC30", Slot = "4")]
		protected override void _LoadModel(string inputTopicId, string inputRlActId)
		{
		}

		// Token: 0x0601B6D4 RID: 112340 RVA: 0x000A5270 File Offset: 0x000A3470
		[Token(Token = "0x601B6D4")]
		[Address(RVA = "0x14AFAA0", Offset = "0x14AE6A0", VA = "0x1814AFAA0", Slot = "5")]
		public override bool CheckIsActivityEnabledForCreateGame()
		{
			return default(bool);
		}

		// Token: 0x0601B6D5 RID: 112341 RVA: 0x000A5288 File Offset: 0x000A3488
		[Token(Token = "0x601B6D5")]
		[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "6")]
		public override RoguelikeTopicMode GetActivityValidMode()
		{
			return RoguelikeTopicMode.NONE;
		}

		// Token: 0x0601B6D6 RID: 112342 RVA: 0x000A52A0 File Offset: 0x000A34A0
		[Token(Token = "0x601B6D6")]
		[Address(RVA = "0x14AFBD0", Offset = "0x14AE7D0", VA = "0x1814AFBD0")]
		public bool CheckSeedModeActEnd()
		{
			return default(bool);
		}

		// Token: 0x0601B6D7 RID: 112343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeActivityEntrySeedModeEntryCompModel()
		{
		}

		// Token: 0x040237A5 RID: 145317
		[Token(Token = "0x40237A5")]
		[FieldOffset(Offset = "0x20")]
		public bool isEnabled;

		// Token: 0x040237A6 RID: 145318
		[Token(Token = "0x40237A6")]
		[FieldOffset(Offset = "0x21")]
		public bool isNew;

		// Token: 0x040237A7 RID: 145319
		[Token(Token = "0x40237A7")]
		[FieldOffset(Offset = "0x22")]
		public bool isLock;

		// Token: 0x040237A8 RID: 145320
		[Token(Token = "0x40237A8")]
		[FieldOffset(Offset = "0x28")]
		public string timeStr;

		// Token: 0x040237A9 RID: 145321
		[Token(Token = "0x40237A9")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeTopicMode validMode;

		// Token: 0x040237AA RID: 145322
		[Token(Token = "0x40237AA")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeActivitySeedModeData.RoguelikeActivitySeedModeConstData constData;

		// Token: 0x040237AB RID: 145323
		[Token(Token = "0x40237AB")]
		[FieldOffset(Offset = "0x40")]
		private long m_endTime;
	}
}
