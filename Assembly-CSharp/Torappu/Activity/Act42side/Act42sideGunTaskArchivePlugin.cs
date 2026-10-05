using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200730B RID: 29451
	[Token(Token = "0x200730B")]
	public class Act42sideGunTaskArchivePlugin : ActArchivePlugin, IHotfixable
	{
		// Token: 0x06029A77 RID: 170615 RVA: 0x000D6248 File Offset: 0x000D4448
		[Token(Token = "0x6029A77")]
		[Address(RVA = "0x2515FA0", Offset = "0x2514BA0", VA = "0x182515FA0", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x06029A78 RID: 170616 RVA: 0x000D6260 File Offset: 0x000D4460
		[Token(Token = "0x6029A78")]
		[Address(RVA = "0x2516300", Offset = "0x2514F00", VA = "0x182516300", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x06029A79 RID: 170617 RVA: 0x000D6278 File Offset: 0x000D4478
		[Token(Token = "0x6029A79")]
		[Address(RVA = "0x2516000", Offset = "0x2514C00", VA = "0x182516000", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x06029A7A RID: 170618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A7A")]
		[Address(RVA = "0x2516390", Offset = "0x2514F90", VA = "0x182516390", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x06029A7B RID: 170619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A7B")]
		[Address(RVA = "0x2515EC0", Offset = "0x2514AC0", VA = "0x182515EC0", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x06029A7C RID: 170620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A7C")]
		[Address(RVA = "0x2516700", Offset = "0x2515300", VA = "0x182516700")]
		public Act42sideGunTaskArchivePlugin()
		{
		}

		// Token: 0x0403B966 RID: 244070
		[Token(Token = "0x403B966")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0403B967 RID: 244071
		[Token(Token = "0x403B967")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0403B968 RID: 244072
		[Token(Token = "0x403B968")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x0403B969 RID: 244073
		[Token(Token = "0x403B969")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x0403B96A RID: 244074
		[Token(Token = "0x403B96A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x0403B96B RID: 244075
		[Token(Token = "0x403B96B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200730C RID: 29452
		[Token(Token = "0x200730C")]
		public class GunTaskArchiveChallengeBookPlguin : ActArchivePlugin.IActArchiveChallengeBookPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06029A7D RID: 170621 RVA: 0x000D6290 File Offset: 0x000D4490
			[Token(Token = "0x6029A7D")]
			[Address(RVA = "0x251B8D0", Offset = "0x251A4D0", VA = "0x18251B8D0", Slot = "4")]
			public bool NeedClosePageOnBack(string archiveId)
			{
				return default(bool);
			}

			// Token: 0x06029A7E RID: 170622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029A7E")]
			[Address(RVA = "0x251B810", Offset = "0x251A410", VA = "0x18251B810", Slot = "5")]
			public string GetArchiveTrackType(string archiveId)
			{
				return null;
			}

			// Token: 0x06029A7F RID: 170623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A7F")]
			[Address(RVA = "0x251B940", Offset = "0x251A540", VA = "0x18251B940")]
			public GunTaskArchiveChallengeBookPlguin()
			{
			}

			// Token: 0x0403B96C RID: 244076
			[Token(Token = "0x403B96C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NeedClosePageOnBack;

			// Token: 0x0403B96D RID: 244077
			[Token(Token = "0x403B96D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetArchiveTrackType;

			// Token: 0x0403B96E RID: 244078
			[Token(Token = "0x403B96E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
