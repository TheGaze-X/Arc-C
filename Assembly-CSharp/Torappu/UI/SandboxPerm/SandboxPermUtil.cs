using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x0200400F RID: 16399
	[Token(Token = "0x200400F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxPermUtil
	{
		// Token: 0x06019656 RID: 104022 RVA: 0x0009DEA8 File Offset: 0x0009C0A8
		[Token(Token = "0x6019656")]
		[Address(RVA = "0x1219CB0", Offset = "0x12188B0", VA = "0x181219CB0")]
		public static bool ReturnFuncOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x06019657 RID: 104023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019657")]
		[Address(RVA = "0x12197B0", Offset = "0x12183B0", VA = "0x1812197B0")]
		public static List<string> FindValidSandboxs()
		{
			return null;
		}

		// Token: 0x06019658 RID: 104024 RVA: 0x0009DEC0 File Offset: 0x0009C0C0
		[Token(Token = "0x6019658")]
		[Address(RVA = "0x1219330", Offset = "0x1217F30", VA = "0x181219330")]
		public static bool CheckIfSandboxInPlayerData(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06019659 RID: 104025 RVA: 0x0009DED8 File Offset: 0x0009C0D8
		[Token(Token = "0x6019659")]
		[Address(RVA = "0x1219B70", Offset = "0x1218770", VA = "0x181219B70")]
		public static bool IsTopicAccessible(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601965A RID: 104026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601965A")]
		[Address(RVA = "0x1219A00", Offset = "0x1218600", VA = "0x181219A00")]
		public static string GetSandboxTopicDisplayId(string topicId, long currTs)
		{
			return null;
		}

		// Token: 0x0601965B RID: 104027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601965B")]
		[Address(RVA = "0x1219640", Offset = "0x1218240", VA = "0x181219640")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601965C RID: 104028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601965C")]
		[Address(RVA = "0x12193F0", Offset = "0x1217FF0", VA = "0x1812193F0")]
		public static void ConsumeExpiredEntryTrackPoint()
		{
		}

		// Token: 0x0601965D RID: 104029 RVA: 0x0009DEF0 File Offset: 0x0009C0F0
		[Token(Token = "0x601965D")]
		[Address(RVA = "0x1219BF0", Offset = "0x12187F0", VA = "0x181219BF0")]
		public static bool NeedPermModeMonthTrackPoint(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601965E RID: 104030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601965E")]
		[Address(RVA = "0x1219580", Offset = "0x1218180", VA = "0x181219580")]
		public static void ConsumePermModeMonthTrackPoint(string topicId)
		{
		}

		// Token: 0x0401F983 RID: 129411
		[Token(Token = "0x401F983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnFuncOpenFlag;

		// Token: 0x0401F984 RID: 129412
		[Token(Token = "0x401F984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindValidSandboxs;

		// Token: 0x0401F985 RID: 129413
		[Token(Token = "0x401F985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfSandboxInPlayerData;

		// Token: 0x0401F986 RID: 129414
		[Token(Token = "0x401F986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTopicAccessible;

		// Token: 0x0401F987 RID: 129415
		[Token(Token = "0x401F987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSandboxTopicDisplayId;

		// Token: 0x0401F988 RID: 129416
		[Token(Token = "0x401F988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0401F989 RID: 129417
		[Token(Token = "0x401F989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConsumeExpiredEntryTrackPoint;

		// Token: 0x0401F98A RID: 129418
		[Token(Token = "0x401F98A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NeedPermModeMonthTrackPoint;

		// Token: 0x0401F98B RID: 129419
		[Token(Token = "0x401F98B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumePermModeMonthTrackPoint;
	}
}
