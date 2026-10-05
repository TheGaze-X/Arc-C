using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200386E RID: 14446
	[Token(Token = "0x200386E")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIGuideController
	{
		// Token: 0x06016DF3 RID: 93683 RVA: 0x000936C0 File Offset: 0x000918C0
		[Token(Token = "0x6016DF3")]
		[Address(RVA = "0xF5F4A0", Offset = "0xF5E0A0", VA = "0x180F5F4A0")]
		public static bool CheckIfUnlocked(UILockTarget target)
		{
			return default(bool);
		}

		// Token: 0x06016DF4 RID: 93684 RVA: 0x000936D8 File Offset: 0x000918D8
		[Token(Token = "0x6016DF4")]
		[Address(RVA = "0xF5F420", Offset = "0xF5E020", VA = "0x180F5F420")]
		public static bool CheckIfGuideAutoShow(UIGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x000936F0 File Offset: 0x000918F0
		[Token(Token = "0x6016DF5")]
		[Address(RVA = "0xF5F3B0", Offset = "0xF5DFB0", VA = "0x180F5F3B0")]
		public static bool CheckIfGuideAutoShow(UIGuideTarget target, string subsignal)
		{
			return default(bool);
		}

		// Token: 0x06016DF6 RID: 93686 RVA: 0x00093708 File Offset: 0x00091908
		[Token(Token = "0x6016DF6")]
		[Address(RVA = "0xF5FA10", Offset = "0xF5E610", VA = "0x180F5FA10")]
		private static bool _CheckIfGuideAutoShow(UIGuideTarget target, string subsignal)
		{
			return default(bool);
		}

		// Token: 0x06016DF7 RID: 93687 RVA: 0x00093720 File Offset: 0x00091920
		[Token(Token = "0x6016DF7")]
		[Address(RVA = "0xF5F5A0", Offset = "0xF5E1A0", VA = "0x180F5F5A0")]
		public static bool ConsumeGuideAutoShow(UIGuideTarget target, bool showAnyway = false)
		{
			return default(bool);
		}

		// Token: 0x06016DF8 RID: 93688 RVA: 0x00093738 File Offset: 0x00091938
		[Token(Token = "0x6016DF8")]
		[Address(RVA = "0xF5F630", Offset = "0xF5E230", VA = "0x180F5F630")]
		public static bool ConsumeGuideAutoShow(UIGuideTarget target, string subsignal, bool showAnyway = false)
		{
			return default(bool);
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x00093750 File Offset: 0x00091950
		[Token(Token = "0x6016DF9")]
		[Address(RVA = "0xF5FAE0", Offset = "0xF5E6E0", VA = "0x180F5FAE0")]
		private static bool _ConsumeGuideAutoShow(UIGuideTarget target, string subsignal, bool showAnyway)
		{
			return default(bool);
		}

		// Token: 0x06016DFA RID: 93690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DFA")]
		[Address(RVA = "0xF5F6D0", Offset = "0xF5E2D0", VA = "0x180F5F6D0")]
		public static string GetLockedStageCode(UILockTarget lockTarget)
		{
			return null;
		}

		// Token: 0x06016DFB RID: 93691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DFB")]
		[Address(RVA = "0xF5F770", Offset = "0xF5E370", VA = "0x180F5F770")]
		public static string GetLockedToastContent(UILockTarget lockTarget, bool withColor = true)
		{
			return null;
		}

		// Token: 0x06016DFC RID: 93692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DFC")]
		[Address(RVA = "0xF5F8E0", Offset = "0xF5E4E0", VA = "0x180F5F8E0")]
		public static void ToastOnLockedItemClicked(UILockTarget lockTarget)
		{
		}

		// Token: 0x06016DFD RID: 93693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DFD")]
		[Address(RVA = "0xF5F880", Offset = "0xF5E480", VA = "0x180F5F880")]
		public static string LockTargetToStageId(UILockTarget target)
		{
			return null;
		}

		// Token: 0x06016DFE RID: 93694 RVA: 0x00093768 File Offset: 0x00091968
		[Token(Token = "0x6016DFE")]
		[Address(RVA = "0xF5FCF0", Offset = "0xF5E8F0", VA = "0x180F5FCF0")]
		private static bool _IsStagePast(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06016DFF RID: 93695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DFF")]
		[Address(RVA = "0xF5FC00", Offset = "0xF5E800", VA = "0x180F5FC00")]
		private static string _GenGuideBookKey(UIGuideTarget target, string subsignal)
		{
			return null;
		}

		// Token: 0x06016E00 RID: 93696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E00")]
		[Address(RVA = "0xF5FD90", Offset = "0xF5E990", VA = "0x180F5FD90")]
		private static string _LockTargetToStageId(UILockTarget target)
		{
			return null;
		}

		// Token: 0x0401B996 RID: 113046
		[Token(Token = "0x401B996")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfUnlocked;

		// Token: 0x0401B997 RID: 113047
		[Token(Token = "0x401B997")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfGuideAutoShow;

		// Token: 0x0401B998 RID: 113048
		[Token(Token = "0x401B998")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_CheckIfGuideAutoShow;

		// Token: 0x0401B999 RID: 113049
		[Token(Token = "0x401B999")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfGuideAutoShow;

		// Token: 0x0401B99A RID: 113050
		[Token(Token = "0x401B99A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeGuideAutoShow;

		// Token: 0x0401B99B RID: 113051
		[Token(Token = "0x401B99B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_ConsumeGuideAutoShow;

		// Token: 0x0401B99C RID: 113052
		[Token(Token = "0x401B99C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConsumeGuideAutoShow;

		// Token: 0x0401B99D RID: 113053
		[Token(Token = "0x401B99D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLockedStageCode;

		// Token: 0x0401B99E RID: 113054
		[Token(Token = "0x401B99E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLockedToastContent;

		// Token: 0x0401B99F RID: 113055
		[Token(Token = "0x401B99F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ToastOnLockedItemClicked;

		// Token: 0x0401B9A0 RID: 113056
		[Token(Token = "0x401B9A0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LockTargetToStageId;

		// Token: 0x0401B9A1 RID: 113057
		[Token(Token = "0x401B9A1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsStagePast;

		// Token: 0x0401B9A2 RID: 113058
		[Token(Token = "0x401B9A2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenGuideBookKey;

		// Token: 0x0401B9A3 RID: 113059
		[Token(Token = "0x401B9A3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LockTargetToStageId;
	}
}
