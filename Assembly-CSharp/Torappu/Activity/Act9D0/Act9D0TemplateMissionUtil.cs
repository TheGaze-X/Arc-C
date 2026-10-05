using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007154 RID: 29012
	[Token(Token = "0x2007154")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act9D0TemplateMissionUtil
	{
		// Token: 0x0602930F RID: 168719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602930F")]
		[Address(RVA = "0x24A5B20", Offset = "0x24A4720", VA = "0x1824A5B20")]
		public static TemplateMissionCoinViewModel GenMissionCoinViewModel()
		{
			return null;
		}

		// Token: 0x06029310 RID: 168720 RVA: 0x000D4B98 File Offset: 0x000D2D98
		[Token(Token = "0x6029310")]
		[Address(RVA = "0x24A5C00", Offset = "0x24A4800", VA = "0x1824A5C00")]
		private static int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x0403AD10 RID: 240912
		[Token(Token = "0x403AD10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenMissionCoinViewModel;

		// Token: 0x0403AD11 RID: 240913
		[Token(Token = "0x403AD11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetCoinCount;
	}
}
