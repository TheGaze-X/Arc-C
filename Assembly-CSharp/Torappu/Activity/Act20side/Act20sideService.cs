using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007631 RID: 30257
	[Token(Token = "0x2007631")]
	public class Act20sideService : IHotfixable
	{
		// Token: 0x0602A98D RID: 174477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A98D")]
		[Address(RVA = "0x265ADE0", Offset = "0x26599E0", VA = "0x18265ADE0")]
		public Act20sideService()
		{
		}

		// Token: 0x0403D53F RID: 251199
		[Token(Token = "0x403D53F")]
		public const string CAR_COMPETITION_START = "/activity/typeAct20side/competitionStart";

		// Token: 0x0403D540 RID: 251200
		[Token(Token = "0x403D540")]
		public const string CAR_COMPETITION_FINISH = "/activity/typeAct20side/competitionFinish";

		// Token: 0x0403D541 RID: 251201
		[Token(Token = "0x403D541")]
		public const string RETRO_CAR_COMPETITION_START = "/retro/typeAct20side/competitionStart";

		// Token: 0x0403D542 RID: 251202
		[Token(Token = "0x403D542")]
		public const string RETRO_CAR_COMPETITION_FINISH = "/retro/typeAct20side/competitionFinish";

		// Token: 0x0403D543 RID: 251203
		[Token(Token = "0x403D543")]
		public const string CAR_EXHIBITION_JUDGE = "/activity/typeAct20side/judge";

		// Token: 0x0403D544 RID: 251204
		[Token(Token = "0x403D544")]
		public const string CAR_EXHIBITION_PICK = "/activity/typeAct20side/pick";

		// Token: 0x0403D545 RID: 251205
		[Token(Token = "0x403D545")]
		public const string CAR_CONFIRM_CAR = "/car/confirmBattleCar";

		// Token: 0x0403D546 RID: 251206
		[Token(Token = "0x403D546")]
		public const string CAR_CONFIRM_EXHI_CAR = "/activity/typeAct20side/confirmExhiCar";

		// Token: 0x0403D547 RID: 251207
		[Token(Token = "0x403D547")]
		public const string CAR_MILESTONE_CLAIM_ALL = "/activity/typeAct20side/quickGetMilestoneAward";

		// Token: 0x0403D548 RID: 251208
		[Token(Token = "0x403D548")]
		public const string CAR_COLLECTION_RECYCLE = "/activity/typeAct20side/quickRecycle";

		// Token: 0x0403D549 RID: 251209
		[Token(Token = "0x403D549")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
