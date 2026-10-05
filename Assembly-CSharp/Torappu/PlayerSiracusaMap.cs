using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2000B52")]
	public class PlayerSiracusaMap
	{
		// Token: 0x060067F8 RID: 26616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0x1EFE450", Offset = "0x1EFD050", VA = "0x181EFE450")]
		public PlayerSiracusaMap()
		{
		}

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[FieldOffset(Offset = "0x10")]
		public string select;

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerSiracusaMap.CharCard> card;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSiracusaMap.Opera opera;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> area;

		// Token: 0x02000B53 RID: 2899
		[Token(Token = "0x2000B53")]
		public enum CharCardItemEnum
		{
			// Token: 0x04003C71 RID: 15473
			[Token(Token = "0x4003C71")]
			NONE,
			// Token: 0x04003C72 RID: 15474
			[Token(Token = "0x4003C72")]
			UNUSED,
			// Token: 0x04003C73 RID: 15475
			[Token(Token = "0x4003C73")]
			USED
		}

		// Token: 0x02000B54 RID: 2900
		[Token(Token = "0x2000B54")]
		public enum StateEnum
		{
			// Token: 0x04003C75 RID: 15477
			[Token(Token = "0x4003C75")]
			NONE,
			// Token: 0x04003C76 RID: 15478
			[Token(Token = "0x4003C76")]
			DOING,
			// Token: 0x04003C77 RID: 15479
			[Token(Token = "0x4003C77")]
			COMPLETED
		}

		// Token: 0x02000B55 RID: 2901
		[Token(Token = "0x2000B55")]
		public enum CharCardStatus
		{
			// Token: 0x04003C79 RID: 15481
			[Token(Token = "0x4003C79")]
			NONE,
			// Token: 0x04003C7A RID: 15482
			[Token(Token = "0x4003C7A")]
			NEW,
			// Token: 0x04003C7B RID: 15483
			[Token(Token = "0x4003C7B")]
			DOING,
			// Token: 0x04003C7C RID: 15484
			[Token(Token = "0x4003C7C")]
			COMPLETED
		}

		// Token: 0x02000B56 RID: 2902
		[Token(Token = "0x2000B56")]
		public enum TaskRingStatus
		{
			// Token: 0x04003C7E RID: 15486
			[Token(Token = "0x4003C7E")]
			NONE,
			// Token: 0x04003C7F RID: 15487
			[Token(Token = "0x4003C7F")]
			DOING,
			// Token: 0x04003C80 RID: 15488
			[Token(Token = "0x4003C80")]
			TAKE_REWARD,
			// Token: 0x04003C81 RID: 15489
			[Token(Token = "0x4003C81")]
			COMPLETED
		}

		// Token: 0x02000B57 RID: 2903
		[Token(Token = "0x2000B57")]
		public enum OperaState
		{
			// Token: 0x04003C83 RID: 15491
			[Token(Token = "0x4003C83")]
			UNRELEASED,
			// Token: 0x04003C84 RID: 15492
			[Token(Token = "0x4003C84")]
			RELEASE,
			// Token: 0x04003C85 RID: 15493
			[Token(Token = "0x4003C85")]
			RELEASED
		}

		// Token: 0x02000B58 RID: 2904
		[Token(Token = "0x2000B58")]
		public class BattleProgress
		{
			// Token: 0x060067F9 RID: 26617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleProgress()
			{
			}

			// Token: 0x04003C86 RID: 15494
			[Token(Token = "0x4003C86")]
			[FieldOffset(Offset = "0x10")]
			public int value;

			// Token: 0x04003C87 RID: 15495
			[Token(Token = "0x4003C87")]
			[FieldOffset(Offset = "0x14")]
			public int target;
		}

		// Token: 0x02000B59 RID: 2905
		[Token(Token = "0x2000B59")]
		public class TaskInfo
		{
			// Token: 0x060067FA RID: 26618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FA")]
			[Address(RVA = "0x1F02590", Offset = "0x1F01190", VA = "0x181F02590")]
			public TaskInfo()
			{
			}

			// Token: 0x04003C88 RID: 15496
			[Token(Token = "0x4003C88")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSiracusaMap.StateEnum state;

			// Token: 0x04003C89 RID: 15497
			[Token(Token = "0x4003C89")]
			[FieldOffset(Offset = "0x18")]
			public List<string> option;

			// Token: 0x04003C8A RID: 15498
			[Token(Token = "0x4003C8A")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSiracusaMap.BattleProgress progress;
		}

		// Token: 0x02000B5A RID: 2906
		[Token(Token = "0x2000B5A")]
		public class TaskRing
		{
			// Token: 0x060067FB RID: 26619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FB")]
			[Address(RVA = "0x1F02650", Offset = "0x1F01250", VA = "0x181F02650")]
			public TaskRing()
			{
			}

			// Token: 0x04003C8B RID: 15499
			[Token(Token = "0x4003C8B")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerSiracusaMap.TaskInfo> task;

			// Token: 0x04003C8C RID: 15500
			[Token(Token = "0x4003C8C")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSiracusaMap.TaskRingStatus state;
		}

		// Token: 0x02000B5B RID: 2907
		[Token(Token = "0x2000B5B")]
		public class CharCard
		{
			// Token: 0x060067FC RID: 26620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FC")]
			[Address(RVA = "0x1EE7690", Offset = "0x1EE6290", VA = "0x181EE7690")]
			public CharCard()
			{
			}

			// Token: 0x04003C8D RID: 15501
			[Token(Token = "0x4003C8D")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerSiracusaMap.CharCardItemEnum> item;

			// Token: 0x04003C8E RID: 15502
			[Token(Token = "0x4003C8E")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerSiracusaMap.TaskRing> taskRing;

			// Token: 0x04003C8F RID: 15503
			[Token(Token = "0x4003C8F")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSiracusaMap.CharCardStatus state;
		}

		// Token: 0x02000B5C RID: 2908
		[Token(Token = "0x2000B5C")]
		public class Opera
		{
			// Token: 0x060067FD RID: 26621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FD")]
			[Address(RVA = "0x1EECB00", Offset = "0x1EEB700", VA = "0x181EECB00")]
			public Opera()
			{
			}

			// Token: 0x04003C90 RID: 15504
			[Token(Token = "0x4003C90")]
			[FieldOffset(Offset = "0x10")]
			public int total;

			// Token: 0x04003C91 RID: 15505
			[Token(Token = "0x4003C91")]
			[FieldOffset(Offset = "0x18")]
			public string show;

			// Token: 0x04003C92 RID: 15506
			[Token(Token = "0x4003C92")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerSiracusaMap.OperaState> release;

			// Token: 0x04003C93 RID: 15507
			[Token(Token = "0x4003C93")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> like;
		}
	}
}
