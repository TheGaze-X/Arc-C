using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E24 RID: 15908
	[Token(Token = "0x2003E24")]
	public abstract class SquadHomeStartBattleServicePluginBase : IHotfixable
	{
		// Token: 0x06018BBF RID: 101311
		[Token(Token = "0x6018BBF")]
		public abstract IStartBattleServiceConfig CreateStartBattleServiceConfig();

		// Token: 0x06018BC0 RID: 101312
		[Token(Token = "0x6018BC0")]
		public abstract void SetParams(SquadHomeStartBattleServicePluginBase.Param param);

		// Token: 0x06018BC1 RID: 101313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BC1")]
		[Address(RVA = "0x1142700", Offset = "0x1141300", VA = "0x181142700")]
		protected SquadHomeStartBattleServicePluginBase()
		{
		}

		// Token: 0x0401E62D RID: 124461
		[Token(Token = "0x401E62D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E25 RID: 15909
		[Token(Token = "0x2003E25")]
		public class Param
		{
			// Token: 0x06018BC2 RID: 101314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BC2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401E62E RID: 124462
			[Token(Token = "0x401E62E")]
			[FieldOffset(Offset = "0x10")]
			public bool usePracticeTicket;

			// Token: 0x0401E62F RID: 124463
			[Token(Token = "0x401E62F")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x0401E630 RID: 124464
			[Token(Token = "0x401E630")]
			[FieldOffset(Offset = "0x20")]
			public CommonStartBattleRequest.SquadModel squad;

			// Token: 0x0401E631 RID: 124465
			[Token(Token = "0x401E631")]
			[FieldOffset(Offset = "0x28")]
			public SquadFriendData assistFriend;

			// Token: 0x0401E632 RID: 124466
			[Token(Token = "0x401E632")]
			[FieldOffset(Offset = "0x30")]
			public bool isReplay;

			// Token: 0x0401E633 RID: 124467
			[Token(Token = "0x401E633")]
			[FieldOffset(Offset = "0x38")]
			public long startTs;

			// Token: 0x0401E634 RID: 124468
			[Token(Token = "0x401E634")]
			[FieldOffset(Offset = "0x40")]
			public bool isRetro;

			// Token: 0x0401E635 RID: 124469
			[Token(Token = "0x401E635")]
			[FieldOffset(Offset = "0x44")]
			public int pry;

			// Token: 0x0401E636 RID: 124470
			[Token(Token = "0x401E636")]
			[FieldOffset(Offset = "0x48")]
			public string groupId;

			// Token: 0x0401E637 RID: 124471
			[Token(Token = "0x401E637")]
			[FieldOffset(Offset = "0x50")]
			public bool isMultiBattle;

			// Token: 0x0401E638 RID: 124472
			[Token(Token = "0x401E638")]
			[FieldOffset(Offset = "0x54")]
			public int multipleBattleTimes;
		}
	}
}
