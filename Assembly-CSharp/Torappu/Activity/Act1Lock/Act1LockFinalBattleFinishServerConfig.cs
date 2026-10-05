using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200786F RID: 30831
	[Token(Token = "0x200786F")]
	public class Act1LockFinalBattleFinishServerConfig : FinishBattleServiceConfig<Act1LockFinalBattleFinishRequest, Act1LockFinalBattleFinishResponse>
	{
		// Token: 0x0602B343 RID: 176963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B343")]
		[Address(RVA = "0x2708830", Offset = "0x2707430", VA = "0x182708830", Slot = "9")]
		public override void OnParseRequest(Act1LockFinalBattleFinishRequest request)
		{
		}

		// Token: 0x0602B344 RID: 176964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B344")]
		[Address(RVA = "0x27088A0", Offset = "0x27074A0", VA = "0x1827088A0")]
		public Act1LockFinalBattleFinishServerConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x0403E76D RID: 255853
		[Token(Token = "0x403E76D")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;
	}
}
