using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073C4 RID: 29636
	[Token(Token = "0x20073C4")]
	[Hotfix(HotfixFlag.Stateless)]
	internal class Act3D5Mgr
	{
		// Token: 0x06029DE7 RID: 171495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DE7")]
		[Address(RVA = "0x256DDC0", Offset = "0x256C9C0", VA = "0x18256DDC0")]
		public static ActivityTable.BasicData FindBasicInfo(string actId)
		{
			return null;
		}

		// Token: 0x06029DE8 RID: 171496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DE8")]
		[Address(RVA = "0x256DFE0", Offset = "0x256CBE0", VA = "0x18256DFE0")]
		public static UIItemViewModel FindPointRewardItem(string actId)
		{
			return null;
		}

		// Token: 0x06029DE9 RID: 171497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DE9")]
		[Address(RVA = "0x256E1A0", Offset = "0x256CDA0", VA = "0x18256E1A0")]
		public static MissionGroup GetMissionGroup(string actId)
		{
			return null;
		}

		// Token: 0x06029DEA RID: 171498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DEA")]
		[Address(RVA = "0x256DEC0", Offset = "0x256CAC0", VA = "0x18256DEC0")]
		public static MissionData FindMission(string missionId)
		{
			return null;
		}

		// Token: 0x06029DEB RID: 171499 RVA: 0x000D6DA0 File Offset: 0x000D4FA0
		[Token(Token = "0x6029DEB")]
		[Address(RVA = "0x256D8A0", Offset = "0x256C4A0", VA = "0x18256D8A0")]
		public static bool CheckRewardCanGet(string actId)
		{
			return default(bool);
		}

		// Token: 0x06029DEC RID: 171500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DEC")]
		[Address(RVA = "0x256E2D0", Offset = "0x256CED0", VA = "0x18256E2D0")]
		public Act3D5Mgr()
		{
		}

		// Token: 0x0403C010 RID: 245776
		[Token(Token = "0x403C010")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindBasicInfo;

		// Token: 0x0403C011 RID: 245777
		[Token(Token = "0x403C011")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindPointRewardItem;

		// Token: 0x0403C012 RID: 245778
		[Token(Token = "0x403C012")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMissionGroup;

		// Token: 0x0403C013 RID: 245779
		[Token(Token = "0x403C013")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindMission;

		// Token: 0x0403C014 RID: 245780
		[Token(Token = "0x403C014")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckRewardCanGet;

		// Token: 0x0403C015 RID: 245781
		[Token(Token = "0x403C015")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
