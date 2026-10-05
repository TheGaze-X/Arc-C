using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005359 RID: 21337
	[Token(Token = "0x2005359")]
	public class RoguelikeTopicInnerTaskViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F743 RID: 128835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F743")]
		[Address(RVA = "0x1935B30", Offset = "0x1934730", VA = "0x181935B30", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F744 RID: 128836 RVA: 0x000B1FA8 File Offset: 0x000B01A8
		[Token(Token = "0x601F744")]
		[Address(RVA = "0x1935E70", Offset = "0x1934A70", VA = "0x181935E70")]
		private bool _LoadChallengeTaskInfos(RoguelikeTopicChallenge challengeData, List<PlayerRoguelikeV2.CurrentData.PlayerStatus.InnerMission> playerInnerTask, out bool isCompleted)
		{
			return default(bool);
		}

		// Token: 0x0601F745 RID: 128837 RVA: 0x000B1FC0 File Offset: 0x000B01C0
		[Token(Token = "0x601F745")]
		[Address(RVA = "0x19361B0", Offset = "0x1934DB0", VA = "0x1819361B0")]
		private bool _LoadMonthTaskInfos(RoguelikeTopicMonthSquad monthSquadData, List<PlayerRoguelikeV2.CurrentData.PlayerStatus.InnerMission> playerInnerTask, out bool isCompleted)
		{
			return default(bool);
		}

		// Token: 0x0601F746 RID: 128838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F746")]
		[Address(RVA = "0x1936460", Offset = "0x1935060", VA = "0x181936460")]
		public RoguelikeTopicInnerTaskViewModel()
		{
		}

		// Token: 0x0601F747 RID: 128839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F747")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A528 RID: 173352
		[Token(Token = "0x402A528")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeTopicInnerTaskViewModel.TaskInfo> taskInfos;

		// Token: 0x0402A529 RID: 173353
		[Token(Token = "0x402A529")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicMode topicMode;

		// Token: 0x0402A52A RID: 173354
		[Token(Token = "0x402A52A")]
		[FieldOffset(Offset = "0x24")]
		public bool isCompleted;

		// Token: 0x0402A52B RID: 173355
		[Token(Token = "0x402A52B")]
		[FieldOffset(Offset = "0x25")]
		public bool isValid;

		// Token: 0x0402A52C RID: 173356
		[Token(Token = "0x402A52C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A52D RID: 173357
		[Token(Token = "0x402A52D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadChallengeTaskInfos;

		// Token: 0x0402A52E RID: 173358
		[Token(Token = "0x402A52E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadMonthTaskInfos;

		// Token: 0x0402A52F RID: 173359
		[Token(Token = "0x402A52F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200535A RID: 21338
		[Token(Token = "0x200535A")]
		public class TaskInfo : IHotfixable
		{
			// Token: 0x0601F748 RID: 128840 RVA: 0x000B1FD8 File Offset: 0x000B01D8
			[Token(Token = "0x601F748")]
			[Address(RVA = "0x1936A90", Offset = "0x1935690", VA = "0x181936A90")]
			public bool IsCompleted()
			{
				return default(bool);
			}

			// Token: 0x0601F749 RID: 128841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F749")]
			[Address(RVA = "0x1936AF0", Offset = "0x19356F0", VA = "0x181936AF0")]
			public TaskInfo()
			{
			}

			// Token: 0x0402A530 RID: 173360
			[Token(Token = "0x402A530")]
			[FieldOffset(Offset = "0x10")]
			public int totalProgress;

			// Token: 0x0402A531 RID: 173361
			[Token(Token = "0x402A531")]
			[FieldOffset(Offset = "0x14")]
			public int currProgress;

			// Token: 0x0402A532 RID: 173362
			[Token(Token = "0x402A532")]
			[FieldOffset(Offset = "0x18")]
			public string taskDesc;

			// Token: 0x0402A533 RID: 173363
			[Token(Token = "0x402A533")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsCompleted;

			// Token: 0x0402A534 RID: 173364
			[Token(Token = "0x402A534")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
