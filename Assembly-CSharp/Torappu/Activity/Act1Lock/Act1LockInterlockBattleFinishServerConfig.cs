using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007869 RID: 30825
	[Token(Token = "0x2007869")]
	public class Act1LockInterlockBattleFinishServerConfig : FinishBattleServiceConfig<Act1LockInterlockBattleFinishRequest, Act1LockInterlockBattleFinishResponse>
	{
		// Token: 0x0602B338 RID: 176952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B338")]
		[Address(RVA = "0x2708B30", Offset = "0x2707730", VA = "0x182708B30", Slot = "9")]
		public override void OnParseRequest(Act1LockInterlockBattleFinishRequest request)
		{
		}

		// Token: 0x0602B339 RID: 176953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B339")]
		[Address(RVA = "0x2708BA0", Offset = "0x27077A0", VA = "0x182708BA0")]
		public Act1LockInterlockBattleFinishServerConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x0403E75C RID: 255836
		[Token(Token = "0x403E75C")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;
	}
}
