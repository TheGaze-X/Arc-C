using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200707C RID: 28796
	[Token(Token = "0x200707C")]
	public interface IActMultiV3PrepareMainSquadPanelProcEvent
	{
		// Token: 0x06028E51 RID: 167505
		[Token(Token = "0x6028E51")]
		void SetCharInSquad(int instId, bool inSquad);

		// Token: 0x06028E52 RID: 167506
		[Token(Token = "0x6028E52")]
		void ToNextProc();

		// Token: 0x06028E53 RID: 167507
		[Token(Token = "0x6028E53")]
		void JumpToEndProc();

		// Token: 0x06028E54 RID: 167508
		[Token(Token = "0x6028E54")]
		void SaveSquad();

		// Token: 0x06028E55 RID: 167509
		[Token(Token = "0x6028E55")]
		void CheckReserveVisible();

		// Token: 0x06028E56 RID: 167510
		[Token(Token = "0x6028E56")]
		void SetReady(bool isReady);

		// Token: 0x06028E57 RID: 167511
		[Token(Token = "0x6028E57")]
		void SetCharSkill(int instId, string skillId);

		// Token: 0x06028E58 RID: 167512
		[Token(Token = "0x6028E58")]
		void SetCharEquip(int instId, string equipId);

		// Token: 0x06028E59 RID: 167513
		[Token(Token = "0x6028E59")]
		void SwitchShowSkill();
	}
}
