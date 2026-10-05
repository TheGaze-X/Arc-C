using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED7 RID: 28375
	[Token(Token = "0x2006ED7")]
	public class ActMultiV3GuideBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x06028555 RID: 165205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028555")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ActMultiV3GuideBattleFinishRequest()
		{
		}

		// Token: 0x0403954A RID: 234826
		[Token(Token = "0x403954A")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x0403954B RID: 234827
		[Token(Token = "0x403954B")]
		[FieldOffset(Offset = "0x28")]
		public bool giveUp;

		// Token: 0x0403954C RID: 234828
		[Token(Token = "0x403954C")]
		[FieldOffset(Offset = "0x30")]
		public NormalGuideStatus normal;

		// Token: 0x0403954D RID: 234829
		[Token(Token = "0x403954D")]
		[FieldOffset(Offset = "0x38")]
		public FootballGuideStatus football;

		// Token: 0x0403954E RID: 234830
		[Token(Token = "0x403954E")]
		[FieldOffset(Offset = "0x40")]
		public DefenceGuideStatus defence;

		// Token: 0x0403954F RID: 234831
		[Token(Token = "0x403954F")]
		[FieldOffset(Offset = "0x48")]
		public RaftGuideStatus raft;
	}
}
