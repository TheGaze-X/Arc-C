using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043A7 RID: 17319
	[Token(Token = "0x20043A7")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2BattleRuneUtil
	{
		// Token: 0x0601A934 RID: 108852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A934")]
		[Address(RVA = "0x13A8080", Offset = "0x13A6C80", VA = "0x1813A8080")]
		public static IRuneDataHolder GetSandboxRunes(SandboxV2Data data, PlayerSandboxV2 playerSandboxV2, List<int> instIds, [Optional] List<string> monthlyRuneIds, [Optional] string nodeId)
		{
			return null;
		}

		// Token: 0x0601A935 RID: 108853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A935")]
		[Address(RVA = "0x13A8D90", Offset = "0x13A7990", VA = "0x1813A8D90")]
		private static void _ParseNodeRune(PlayerSandboxV2 playerSandboxV2, string nodeId, ref List<string> runes)
		{
		}

		// Token: 0x0601A936 RID: 108854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A936")]
		[Address(RVA = "0x13A85D0", Offset = "0x13A71D0", VA = "0x1813A85D0")]
		private static void _ParseInstRune(SandboxV2Data data, PlayerSandboxV2 playerSandboxV2, List<int> instIds, ref List<RuneTable.PackedRuneData> result)
		{
		}

		// Token: 0x0601A937 RID: 108855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A937")]
		[Address(RVA = "0x13A83C0", Offset = "0x13A6FC0", VA = "0x1813A83C0")]
		private static void _AppendRunesByRuneIds(List<string> runeIds, SandboxV2Data data, ref List<RuneTable.PackedRuneData> runeDatas)
		{
		}

		// Token: 0x04021DCC RID: 138700
		[Token(Token = "0x4021DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSandboxRunes;

		// Token: 0x04021DCD RID: 138701
		[Token(Token = "0x4021DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ParseNodeRune;

		// Token: 0x04021DCE RID: 138702
		[Token(Token = "0x4021DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ParseInstRune;

		// Token: 0x04021DCF RID: 138703
		[Token(Token = "0x4021DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AppendRunesByRuneIds;
	}
}
