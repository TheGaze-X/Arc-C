using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002174 RID: 8564
	[Token(Token = "0x2002174")]
	public interface IBattleBGMModule : IHotfixable, IDisposable
	{
		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x0600D2F6 RID: 54006 RVA: 0x0004C080 File Offset: 0x0004A280
		[Token(Token = "0x1700195B")]
		BattleBGMLevel level
		{
			[Token(Token = "0x600D2F6")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "0")]
			get
			{
				return BattleBGMLevel.CHARACTER_FEVER;
			}
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2F7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "1")]
		void OnMute(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2F8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "2")]
		void OnResume(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2F9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "3")]
		void OnInterrupt(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}
	}
}
