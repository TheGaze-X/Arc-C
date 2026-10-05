using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004474 RID: 17524
	[Token(Token = "0x2004474")]
	public class RoguelikeTopicArchivePlugin : ActArchivePlugin
	{
		// Token: 0x0601AC8C RID: 109708 RVA: 0x000A3548 File Offset: 0x000A1748
		[Token(Token = "0x601AC8C")]
		[Address(RVA = "0x13EEEC0", Offset = "0x13EDAC0", VA = "0x1813EEEC0", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x0601AC8D RID: 109709 RVA: 0x000A3560 File Offset: 0x000A1760
		[Token(Token = "0x601AC8D")]
		[Address(RVA = "0x13EF5B0", Offset = "0x13EE1B0", VA = "0x1813EF5B0", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x0601AC8E RID: 109710 RVA: 0x000A3578 File Offset: 0x000A1778
		[Token(Token = "0x601AC8E")]
		[Address(RVA = "0x13EEF20", Offset = "0x13EDB20", VA = "0x1813EEF20", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0601AC8F RID: 109711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC8F")]
		[Address(RVA = "0x13EF700", Offset = "0x13EE300", VA = "0x1813EF700", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x0601AC90 RID: 109712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC90")]
		[Address(RVA = "0x13EECE0", Offset = "0x13ED8E0", VA = "0x1813EECE0", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x0601AC91 RID: 109713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC91")]
		[Address(RVA = "0x13EFB10", Offset = "0x13EE710", VA = "0x1813EFB10")]
		public RoguelikeTopicArchivePlugin()
		{
		}

		// Token: 0x040223FA RID: 140282
		[Token(Token = "0x40223FA")]
		public const string KEY_IS_FROM_ROGUELIKE_ENTRY = "is_from_roguelike_entry";

		// Token: 0x040223FB RID: 140283
		[Token(Token = "0x40223FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x040223FC RID: 140284
		[Token(Token = "0x40223FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x040223FD RID: 140285
		[Token(Token = "0x40223FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x040223FE RID: 140286
		[Token(Token = "0x40223FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x040223FF RID: 140287
		[Token(Token = "0x40223FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x04022400 RID: 140288
		[Token(Token = "0x4022400")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004475 RID: 17525
		[Token(Token = "0x2004475")]
		private class RoguelikeTopicArchiveMusicPlugin : ActArchivePlugin.IActArchiveMusicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0601AC92 RID: 109714 RVA: 0x000A3590 File Offset: 0x000A1790
			[Token(Token = "0x601AC92")]
			[Address(RVA = "0x13EE940", Offset = "0x13ED540", VA = "0x1813EE940", Slot = "4")]
			public bool SetHomeTheme(string archiveId, string gameMusicId, long bgmInstId)
			{
				return default(bool);
			}

			// Token: 0x0601AC93 RID: 109715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AC93")]
			[Address(RVA = "0x13EE790", Offset = "0x13ED390", VA = "0x1813EE790", Slot = "5")]
			public string GetHomeTheme(string archiveId)
			{
				return null;
			}

			// Token: 0x0601AC94 RID: 109716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC94")]
			[Address(RVA = "0x13EEAC0", Offset = "0x13ED6C0", VA = "0x1813EEAC0")]
			public RoguelikeTopicArchiveMusicPlugin()
			{
			}

			// Token: 0x04022401 RID: 140289
			[Token(Token = "0x4022401")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHomeTheme;

			// Token: 0x04022402 RID: 140290
			[Token(Token = "0x4022402")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetHomeTheme;

			// Token: 0x04022403 RID: 140291
			[Token(Token = "0x4022403")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004476 RID: 17526
		[Token(Token = "0x2004476")]
		private class RoguelikeTopicArchivePicPlugin : ActArchivePlugin.IActArchivePicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0601AC95 RID: 109717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AC95")]
			[Address(RVA = "0x13EEB20", Offset = "0x13ED720", VA = "0x1813EEB20", Slot = "5")]
			public string GetHomeKV(string archiveId)
			{
				return null;
			}

			// Token: 0x0601AC96 RID: 109718 RVA: 0x000A35A8 File Offset: 0x000A17A8
			[Token(Token = "0x601AC96")]
			[Address(RVA = "0x13EEBC0", Offset = "0x13ED7C0", VA = "0x1813EEBC0", Slot = "4")]
			public bool SetHomeKV(string archiveId, string kvId)
			{
				return default(bool);
			}

			// Token: 0x0601AC97 RID: 109719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC97")]
			[Address(RVA = "0x13EEC80", Offset = "0x13ED880", VA = "0x1813EEC80")]
			public RoguelikeTopicArchivePicPlugin()
			{
			}

			// Token: 0x04022404 RID: 140292
			[Token(Token = "0x4022404")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetHomeKV;

			// Token: 0x04022405 RID: 140293
			[Token(Token = "0x4022405")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetHomeKV;

			// Token: 0x04022406 RID: 140294
			[Token(Token = "0x4022406")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004477 RID: 17527
		[Token(Token = "0x2004477")]
		private class RoguelikeTopicArchiveChallengeBookPlugin : ActArchivePlugin.IActArchiveChallengeBookPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0601AC98 RID: 109720 RVA: 0x000A35C0 File Offset: 0x000A17C0
			[Token(Token = "0x601AC98")]
			[Address(RVA = "0x13EE6C0", Offset = "0x13ED2C0", VA = "0x1813EE6C0", Slot = "4")]
			public bool NeedClosePageOnBack(string archiveId)
			{
				return default(bool);
			}

			// Token: 0x0601AC99 RID: 109721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AC99")]
			[Address(RVA = "0x13EE630", Offset = "0x13ED230", VA = "0x1813EE630", Slot = "5")]
			public string GetArchiveTrackType(string archiveId)
			{
				return null;
			}

			// Token: 0x0601AC9A RID: 109722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC9A")]
			[Address(RVA = "0x13EE730", Offset = "0x13ED330", VA = "0x1813EE730")]
			public RoguelikeTopicArchiveChallengeBookPlugin()
			{
			}

			// Token: 0x04022407 RID: 140295
			[Token(Token = "0x4022407")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NeedClosePageOnBack;

			// Token: 0x04022408 RID: 140296
			[Token(Token = "0x4022408")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetArchiveTrackType;

			// Token: 0x04022409 RID: 140297
			[Token(Token = "0x4022409")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
