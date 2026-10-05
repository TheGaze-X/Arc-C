using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C57 RID: 15447
	[Token(Token = "0x2003C57")]
	public class TuningArchivePlugin : ActArchivePlugin, IHotfixable
	{
		// Token: 0x06018240 RID: 98880 RVA: 0x00099828 File Offset: 0x00097A28
		[Token(Token = "0x6018240")]
		[Address(RVA = "0x108F500", Offset = "0x108E100", VA = "0x18108F500", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x06018241 RID: 98881 RVA: 0x00099840 File Offset: 0x00097A40
		[Token(Token = "0x6018241")]
		[Address(RVA = "0x108F8A0", Offset = "0x108E4A0", VA = "0x18108F8A0", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x06018242 RID: 98882 RVA: 0x00099858 File Offset: 0x00097A58
		[Token(Token = "0x6018242")]
		[Address(RVA = "0x108F560", Offset = "0x108E160", VA = "0x18108F560", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x06018243 RID: 98883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018243")]
		[Address(RVA = "0x108F930", Offset = "0x108E530", VA = "0x18108F930", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x06018244 RID: 98884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018244")]
		[Address(RVA = "0x108F420", Offset = "0x108E020", VA = "0x18108F420", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x06018245 RID: 98885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018245")]
		[Address(RVA = "0x108FC70", Offset = "0x108E870", VA = "0x18108FC70")]
		public TuningArchivePlugin()
		{
		}

		// Token: 0x0401D59A RID: 120218
		[Token(Token = "0x401D59A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0401D59B RID: 120219
		[Token(Token = "0x401D59B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0401D59C RID: 120220
		[Token(Token = "0x401D59C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x0401D59D RID: 120221
		[Token(Token = "0x401D59D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x0401D59E RID: 120222
		[Token(Token = "0x401D59E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x0401D59F RID: 120223
		[Token(Token = "0x401D59F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C58 RID: 15448
		[Token(Token = "0x2003C58")]
		public class TuningArchiveChallengeBookPlguin : ActArchivePlugin.IActArchiveChallengeBookPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06018246 RID: 98886 RVA: 0x00099870 File Offset: 0x00097A70
			[Token(Token = "0x6018246")]
			[Address(RVA = "0x108F350", Offset = "0x108DF50", VA = "0x18108F350", Slot = "4")]
			public bool NeedClosePageOnBack(string archiveId)
			{
				return default(bool);
			}

			// Token: 0x06018247 RID: 98887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018247")]
			[Address(RVA = "0x108F2C0", Offset = "0x108DEC0", VA = "0x18108F2C0", Slot = "5")]
			public string GetArchiveTrackType(string archiveId)
			{
				return null;
			}

			// Token: 0x06018248 RID: 98888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018248")]
			[Address(RVA = "0x108F3C0", Offset = "0x108DFC0", VA = "0x18108F3C0")]
			public TuningArchiveChallengeBookPlguin()
			{
			}

			// Token: 0x0401D5A0 RID: 120224
			[Token(Token = "0x401D5A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NeedClosePageOnBack;

			// Token: 0x0401D5A1 RID: 120225
			[Token(Token = "0x401D5A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetArchiveTrackType;

			// Token: 0x0401D5A2 RID: 120226
			[Token(Token = "0x401D5A2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
