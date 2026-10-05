using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;

namespace Torappu.Multiplayer.Mode.Replay
{
	// Token: 0x020015D5 RID: 5589
	[Token(Token = "0x20015D5")]
	public class MultiplayerBattleVideoJson : IMultiplayerBattleVideo
	{
		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x00037EF0 File Offset: 0x000360F0
		[Token(Token = "0x17000F15")]
		public int stepCount
		{
			[Token(Token = "0x6007EDA")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EDB")]
		[Address(RVA = "0x2893B70", Offset = "0x2892770", VA = "0x182893B70", Slot = "7")]
		public StepData GetStep(uint stepSeq)
		{
			return null;
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDC")]
		[Address(RVA = "0x2893EB0", Offset = "0x2892AB0", VA = "0x182893EB0", Slot = "4")]
		public void ReadBattleInfo(BattleInfo bi)
		{
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void ReadTeamInfo(TeamInfo ti)
		{
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x00037F08 File Offset: 0x00036108
		[Token(Token = "0x6007EDE")]
		[Address(RVA = "0x2894270", Offset = "0x2892E70", VA = "0x182894270")]
		private int _GetCheckSeq(uint stepSeq)
		{
			return 0;
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EDF")]
		[Address(RVA = "0x2893AA0", Offset = "0x28926A0", VA = "0x182893AA0")]
		public static MultiplayerBattleVideoJson CreateFromFile(string jsonPath)
		{
			return null;
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EE0")]
		[Address(RVA = "0x2893B10", Offset = "0x2892710", VA = "0x182893B10")]
		public static MultiplayerBattleVideoJson CreateFromJsonStr(string jsonContent)
		{
			return null;
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MultiplayerBattleVideoJson()
		{
		}

		// Token: 0x04008083 RID: 32899
		[Token(Token = "0x4008083")]
		[FieldOffset(Offset = "0x10")]
		public string stage_id;

		// Token: 0x04008084 RID: 32900
		[Token(Token = "0x4008084")]
		[FieldOffset(Offset = "0x18")]
		public int stage_seed;

		// Token: 0x04008085 RID: 32901
		[Token(Token = "0x4008085")]
		[FieldOffset(Offset = "0x1C")]
		public int start_ts;

		// Token: 0x04008086 RID: 32902
		[Token(Token = "0x4008086")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MultiplayerBattleVideoJson.JsonPlayer> players;

		// Token: 0x04008087 RID: 32903
		[Token(Token = "0x4008087")]
		[FieldOffset(Offset = "0x28")]
		public int step_seq;

		// Token: 0x04008088 RID: 32904
		[Token(Token = "0x4008088")]
		[FieldOffset(Offset = "0x30")]
		public MultiplayerBattleVideoJson.JsonStep[] arr_step;

		// Token: 0x04008089 RID: 32905
		[Token(Token = "0x4008089")]
		[FieldOffset(Offset = "0x38")]
		public uint[] arr_check_seq;

		// Token: 0x020015D6 RID: 5590
		[Token(Token = "0x20015D6")]
		public class JsonPlayer
		{
			// Token: 0x06007EE2 RID: 32482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public JsonPlayer()
			{
			}

			// Token: 0x0400808A RID: 32906
			[Token(Token = "0x400808A")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0400808B RID: 32907
			[Token(Token = "0x400808B")]
			[FieldOffset(Offset = "0x18")]
			public TeamProtocol.SquadItem[] squad;

			// Token: 0x0400808C RID: 32908
			[Token(Token = "0x400808C")]
			[FieldOffset(Offset = "0x20")]
			public int position;

			// Token: 0x0400808D RID: 32909
			[Token(Token = "0x400808D")]
			[FieldOffset(Offset = "0x28")]
			public string buff_id;

			// Token: 0x0400808E RID: 32910
			[Token(Token = "0x400808E")]
			[FieldOffset(Offset = "0x30")]
			public int fail;
		}

		// Token: 0x020015D7 RID: 5591
		[Token(Token = "0x20015D7")]
		public class JsonAction
		{
			// Token: 0x06007EE3 RID: 32483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public JsonAction()
			{
			}

			// Token: 0x0400808F RID: 32911
			[Token(Token = "0x400808F")]
			[FieldOffset(Offset = "0x10")]
			public int side;

			// Token: 0x04008090 RID: 32912
			[Token(Token = "0x4008090")]
			[FieldOffset(Offset = "0x14")]
			public int operate;

			// Token: 0x04008091 RID: 32913
			[Token(Token = "0x4008091")]
			[FieldOffset(Offset = "0x18")]
			public int[] int32_params;

			// Token: 0x04008092 RID: 32914
			[Token(Token = "0x4008092")]
			[FieldOffset(Offset = "0x20")]
			public string[] string_params;
		}

		// Token: 0x020015D8 RID: 5592
		[Token(Token = "0x20015D8")]
		public class JsonStep
		{
			// Token: 0x06007EE4 RID: 32484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public JsonStep()
			{
			}

			// Token: 0x04008093 RID: 32915
			[Token(Token = "0x4008093")]
			[FieldOffset(Offset = "0x10")]
			public uint seq;

			// Token: 0x04008094 RID: 32916
			[Token(Token = "0x4008094")]
			[FieldOffset(Offset = "0x14")]
			public uint span_ms;

			// Token: 0x04008095 RID: 32917
			[Token(Token = "0x4008095")]
			[FieldOffset(Offset = "0x18")]
			public MultiplayerBattleVideoJson.JsonAction[] actions;

			// Token: 0x04008096 RID: 32918
			[Token(Token = "0x4008096")]
			[FieldOffset(Offset = "0x20")]
			public int check_seq;
		}
	}
}
