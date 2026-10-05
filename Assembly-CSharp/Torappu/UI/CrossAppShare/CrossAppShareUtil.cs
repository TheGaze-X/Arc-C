using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058EC RID: 22764
	[Token(Token = "0x20058EC")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CrossAppShareUtil
	{
		// Token: 0x06021312 RID: 135954 RVA: 0x000B8DD0 File Offset: 0x000B6FD0
		[Token(Token = "0x6021312")]
		[Address(RVA = "0x1B79A10", Offset = "0x1B78610", VA = "0x181B79A10")]
		public static bool CheckBtnInTimeByMissionId(string missionId, bool inactiveBtn)
		{
			return default(bool);
		}

		// Token: 0x06021313 RID: 135955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021313")]
		[Address(RVA = "0x1B79B80", Offset = "0x1B78780", VA = "0x181B79B80")]
		public static string LoadCrossAppShareMissionId(string actId)
		{
			return null;
		}

		// Token: 0x0402D364 RID: 185188
		[Token(Token = "0x402D364")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBtnInTimeByMissionId;

		// Token: 0x0402D365 RID: 185189
		[Token(Token = "0x402D365")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCrossAppShareMissionId;
	}
}
