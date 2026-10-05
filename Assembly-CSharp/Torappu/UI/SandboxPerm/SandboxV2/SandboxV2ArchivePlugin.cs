using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200410D RID: 16653
	[Token(Token = "0x200410D")]
	public class SandboxV2ArchivePlugin : ActArchivePlugin
	{
		// Token: 0x06019BED RID: 105453 RVA: 0x0009F480 File Offset: 0x0009D680
		[Token(Token = "0x6019BED")]
		[Address(RVA = "0x12959C0", Offset = "0x12945C0", VA = "0x1812959C0", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x06019BEE RID: 105454 RVA: 0x0009F498 File Offset: 0x0009D698
		[Token(Token = "0x6019BEE")]
		[Address(RVA = "0x1295CD0", Offset = "0x12948D0", VA = "0x181295CD0", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x06019BEF RID: 105455 RVA: 0x0009F4B0 File Offset: 0x0009D6B0
		[Token(Token = "0x6019BEF")]
		[Address(RVA = "0x1295A20", Offset = "0x1294620", VA = "0x181295A20", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x06019BF0 RID: 105456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019BF0")]
		[Address(RVA = "0x1295D60", Offset = "0x1294960", VA = "0x181295D60", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x06019BF1 RID: 105457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BF1")]
		[Address(RVA = "0x12957E0", Offset = "0x12943E0", VA = "0x1812957E0", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x06019BF2 RID: 105458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BF2")]
		[Address(RVA = "0x1296170", Offset = "0x1294D70", VA = "0x181296170")]
		public SandboxV2ArchivePlugin()
		{
		}

		// Token: 0x0402041C RID: 132124
		[Token(Token = "0x402041C")]
		public const string KEY_IS_FROM_SANDBOX_V2_DUNGEON = "is_from_sandbox_v2_dungeon";

		// Token: 0x0402041D RID: 132125
		[Token(Token = "0x402041D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0402041E RID: 132126
		[Token(Token = "0x402041E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0402041F RID: 132127
		[Token(Token = "0x402041F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x04020420 RID: 132128
		[Token(Token = "0x4020420")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x04020421 RID: 132129
		[Token(Token = "0x4020421")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x04020422 RID: 132130
		[Token(Token = "0x4020422")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200410E RID: 16654
		[Token(Token = "0x200410E")]
		private class SandboxV2ArchiveAchievementPlugin : ActArchivePlugin.IActArchiveAchievementPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06019BF3 RID: 105459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BF3")]
			[Address(RVA = "0x12941A0", Offset = "0x1292DA0", VA = "0x1812941A0", Slot = "4")]
			public Dictionary<string, ArchiveAchievementListFilterViewModel> GetFilters(string archiveId)
			{
				return null;
			}

			// Token: 0x06019BF4 RID: 105460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BF4")]
			[Address(RVA = "0x12943C0", Offset = "0x1292FC0", VA = "0x1812943C0")]
			public SandboxV2ArchiveAchievementPlugin()
			{
			}

			// Token: 0x04020423 RID: 132131
			[Token(Token = "0x4020423")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFilters;

			// Token: 0x04020424 RID: 132132
			[Token(Token = "0x4020424")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200410F RID: 16655
		[Token(Token = "0x200410F")]
		private class SandboxV2ArchiveMusicPlugin : ActArchivePlugin.IActArchiveMusicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06019BF5 RID: 105461 RVA: 0x0009F4C8 File Offset: 0x0009D6C8
			[Token(Token = "0x6019BF5")]
			[Address(RVA = "0x12956F0", Offset = "0x12942F0", VA = "0x1812956F0", Slot = "4")]
			public bool SetHomeTheme(string archiveId, string gameMusicId, long bgmInstId)
			{
				return default(bool);
			}

			// Token: 0x06019BF6 RID: 105462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BF6")]
			[Address(RVA = "0x1295610", Offset = "0x1294210", VA = "0x181295610", Slot = "5")]
			public string GetHomeTheme(string archiveId)
			{
				return null;
			}

			// Token: 0x06019BF7 RID: 105463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BF7")]
			[Address(RVA = "0x1295780", Offset = "0x1294380", VA = "0x181295780")]
			public SandboxV2ArchiveMusicPlugin()
			{
			}

			// Token: 0x04020425 RID: 132133
			[Token(Token = "0x4020425")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHomeTheme;

			// Token: 0x04020426 RID: 132134
			[Token(Token = "0x4020426")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetHomeTheme;

			// Token: 0x04020427 RID: 132135
			[Token(Token = "0x4020427")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004110 RID: 16656
		[Token(Token = "0x2004110")]
		private class SandboxV2ArchiveEntryPlugin : ActArchivePlugin.IActArchiveEntryPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06019BF8 RID: 105464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BF8")]
			[Address(RVA = "0x12954D0", Offset = "0x12940D0", VA = "0x1812954D0", Slot = "4")]
			public string GetEntryMusicId(string archiveId)
			{
				return null;
			}

			// Token: 0x06019BF9 RID: 105465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BF9")]
			[Address(RVA = "0x12955B0", Offset = "0x12941B0", VA = "0x1812955B0")]
			public SandboxV2ArchiveEntryPlugin()
			{
			}

			// Token: 0x04020428 RID: 132136
			[Token(Token = "0x4020428")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetEntryMusicId;

			// Token: 0x04020429 RID: 132137
			[Token(Token = "0x4020429")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
