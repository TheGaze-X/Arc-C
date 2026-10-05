using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014AB RID: 5291
	[Token(Token = "0x20014AB")]
	public interface IServerStepModeHost
	{
		// Token: 0x06007A20 RID: 31264
		[Token(Token = "0x6007A20")]
		ServerStepModeHelper.SettingData GetSetting();

		// Token: 0x06007A21 RID: 31265
		[Token(Token = "0x6007A21")]
		float GetPing();

		// Token: 0x06007A22 RID: 31266
		[Token(Token = "0x6007A22")]
		bool NextFrame(bool additional = false);

		// Token: 0x06007A23 RID: 31267
		[Token(Token = "0x6007A23")]
		void UpdateStep(ServerStepModeHelper.IStepData stepData);

		// Token: 0x06007A24 RID: 31268
		[Token(Token = "0x6007A24")]
		void ReleaseStepData(ServerStepModeHelper.IStepData stepData);

		// Token: 0x06007A25 RID: 31269
		[Token(Token = "0x6007A25")]
		void OnRefreshSpeed(float currentSpeed, float curDelayTime);
	}
}
