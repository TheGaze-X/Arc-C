using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007342 RID: 29506
	[Token(Token = "0x2007342")]
	public class Act42D0NormalStartServiceConfig : CrisisStartBattleServiceConfig<Act42D0NormalBattleStartRequest, Act42D0NormalBattleStartResponse>
	{
		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x06029BB2 RID: 170930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006285")]
		protected override string serviceCode
		{
			[Token(Token = "0x6029BB2")]
			[Address(RVA = "0x2561E80", Offset = "0x2560A80", VA = "0x182561E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029BB3 RID: 170931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BB3")]
		[Address(RVA = "0x2561DB0", Offset = "0x25609B0", VA = "0x182561DB0")]
		public Act42D0NormalStartServiceConfig(string actId, string stageId, List<string> buffList)
		{
		}

		// Token: 0x06029BB4 RID: 170932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BB4")]
		[Address(RVA = "0x2561CC0", Offset = "0x25608C0", VA = "0x182561CC0", Slot = "6")]
		protected override Act42D0NormalBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403BBB6 RID: 244662
		[Token(Token = "0x403BBB6")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x0403BBB7 RID: 244663
		[Token(Token = "0x403BBB7")]
		[FieldOffset(Offset = "0x28")]
		private string m_stageId;

		// Token: 0x0403BBB8 RID: 244664
		[Token(Token = "0x403BBB8")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_buffList;

		// Token: 0x0403BBB9 RID: 244665
		[Token(Token = "0x403BBB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403BBBA RID: 244666
		[Token(Token = "0x403BBBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403BBBB RID: 244667
		[Token(Token = "0x403BBBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
