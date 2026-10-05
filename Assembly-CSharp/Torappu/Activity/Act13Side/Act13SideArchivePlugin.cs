using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079CB RID: 31179
	[Token(Token = "0x20079CB")]
	public class Act13SideArchivePlugin : ActArchivePlugin
	{
		// Token: 0x0602BBAD RID: 179117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBAD")]
		[Address(RVA = "0x27968D0", Offset = "0x27954D0", VA = "0x1827968D0", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x0602BBAE RID: 179118 RVA: 0x000DD058 File Offset: 0x000DB258
		[Token(Token = "0x602BBAE")]
		[Address(RVA = "0x2796A30", Offset = "0x2795630", VA = "0x182796A30", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x0602BBAF RID: 179119 RVA: 0x000DD070 File Offset: 0x000DB270
		[Token(Token = "0x602BBAF")]
		[Address(RVA = "0x2797210", Offset = "0x2795E10", VA = "0x182797210", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x0602BBB0 RID: 179120 RVA: 0x000DD088 File Offset: 0x000DB288
		[Token(Token = "0x602BBB0")]
		[Address(RVA = "0x2796A90", Offset = "0x2795690", VA = "0x182796A90", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0602BBB1 RID: 179121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBB1")]
		[Address(RVA = "0x27972A0", Offset = "0x2795EA0", VA = "0x1827972A0", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x0602BBB2 RID: 179122 RVA: 0x000DD0A0 File Offset: 0x000DB2A0
		[Token(Token = "0x602BBB2")]
		[Address(RVA = "0x27974E0", Offset = "0x27960E0", VA = "0x1827974E0")]
		private Act13SideArchivePrestigeUnlockCond _GetPrestigeUnlockConditionParam(Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return default(Act13SideArchivePrestigeUnlockCond);
		}

		// Token: 0x0602BBB3 RID: 179123 RVA: 0x000DD0B8 File Offset: 0x000DB2B8
		[Token(Token = "0x602BBB3")]
		[Address(RVA = "0x2797860", Offset = "0x2796460", VA = "0x182797860")]
		private Act13SideArchiveStageUnlockCond _GetStageUnlockConditionParam(Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return default(Act13SideArchiveStageUnlockCond);
		}

		// Token: 0x0602BBB4 RID: 179124 RVA: 0x000DD0D0 File Offset: 0x000DB2D0
		[Token(Token = "0x602BBB4")]
		[Address(RVA = "0x2797590", Offset = "0x2796190", VA = "0x182797590")]
		private bool _GetPrestigeUnlockStatus(string archiveId, Act13SideData data, Act13SideArchivePrestigeUnlockCond param, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0602BBB5 RID: 179125 RVA: 0x000DD0E8 File Offset: 0x000DB2E8
		[Token(Token = "0x602BBB5")]
		[Address(RVA = "0x2797A30", Offset = "0x2796630", VA = "0x182797A30")]
		private bool _GetStageUnlockStatus(string archiveId, Act13SideData data, Act13SideArchiveStageUnlockCond param, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0602BBB6 RID: 179126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBB6")]
		[Address(RVA = "0x2797C80", Offset = "0x2796880", VA = "0x182797C80")]
		public Act13SideArchivePlugin()
		{
		}

		// Token: 0x0403F43F RID: 259135
		[Token(Token = "0x403F43F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x0403F440 RID: 259136
		[Token(Token = "0x403F440")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0403F441 RID: 259137
		[Token(Token = "0x403F441")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0403F442 RID: 259138
		[Token(Token = "0x403F442")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x0403F443 RID: 259139
		[Token(Token = "0x403F443")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x0403F444 RID: 259140
		[Token(Token = "0x403F444")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetPrestigeUnlockConditionParam;

		// Token: 0x0403F445 RID: 259141
		[Token(Token = "0x403F445")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetStageUnlockConditionParam;

		// Token: 0x0403F446 RID: 259142
		[Token(Token = "0x403F446")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPrestigeUnlockStatus;

		// Token: 0x0403F447 RID: 259143
		[Token(Token = "0x403F447")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetStageUnlockStatus;

		// Token: 0x0403F448 RID: 259144
		[Token(Token = "0x403F448")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079CC RID: 31180
		[Token(Token = "0x20079CC")]
		public class Act13sideArchiveMusicPlugin : ActArchivePlugin.IActArchiveMusicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602BBB7 RID: 179127 RVA: 0x000DD100 File Offset: 0x000DB300
			[Token(Token = "0x602BBB7")]
			[Address(RVA = "0x2799D50", Offset = "0x2798950", VA = "0x182799D50", Slot = "4")]
			public bool SetHomeTheme(string archiveId, string gameMusicId, long bgmInstId)
			{
				return default(bool);
			}

			// Token: 0x0602BBB8 RID: 179128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BBB8")]
			[Address(RVA = "0x2799BA0", Offset = "0x27987A0", VA = "0x182799BA0", Slot = "5")]
			public string GetHomeTheme(string archiveId)
			{
				return null;
			}

			// Token: 0x0602BBB9 RID: 179129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBB9")]
			[Address(RVA = "0x2799ED0", Offset = "0x2798AD0", VA = "0x182799ED0")]
			public Act13sideArchiveMusicPlugin()
			{
			}

			// Token: 0x0403F449 RID: 259145
			[Token(Token = "0x403F449")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHomeTheme;

			// Token: 0x0403F44A RID: 259146
			[Token(Token = "0x403F44A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetHomeTheme;

			// Token: 0x0403F44B RID: 259147
			[Token(Token = "0x403F44B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020079CD RID: 31181
		[Token(Token = "0x20079CD")]
		public class Act13sideArchiveNewsPlugin : ActArchivePlugin.IActArchiveNewsPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602BBBA RID: 179130 RVA: 0x000DD118 File Offset: 0x000DB318
			[Token(Token = "0x602BBBA")]
			[Address(RVA = "0x2799F30", Offset = "0x2798B30", VA = "0x182799F30", Slot = "4")]
			public int GetNewsParamT(string archiveId)
			{
				return 0;
			}

			// Token: 0x0602BBBB RID: 179131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBBB")]
			[Address(RVA = "0x279A110", Offset = "0x2798D10", VA = "0x18279A110")]
			public Act13sideArchiveNewsPlugin()
			{
			}

			// Token: 0x0403F44C RID: 259148
			[Token(Token = "0x403F44C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetNewsParamT;

			// Token: 0x0403F44D RID: 259149
			[Token(Token = "0x403F44D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
