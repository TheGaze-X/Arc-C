using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074DF RID: 29919
	[Token(Token = "0x20074DF")]
	public class Act25sideArchivePlugin : ActArchivePlugin, IHotfixable
	{
		// Token: 0x0602A2D8 RID: 172760 RVA: 0x000D7A18 File Offset: 0x000D5C18
		[Token(Token = "0x602A2D8")]
		[Address(RVA = "0x25C66E0", Offset = "0x25C52E0", VA = "0x1825C66E0", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x0602A2D9 RID: 172761 RVA: 0x000D7A30 File Offset: 0x000D5C30
		[Token(Token = "0x602A2D9")]
		[Address(RVA = "0x25C6820", Offset = "0x25C5420", VA = "0x1825C6820", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x0602A2DA RID: 172762 RVA: 0x000D7A48 File Offset: 0x000D5C48
		[Token(Token = "0x602A2DA")]
		[Address(RVA = "0x25C6740", Offset = "0x25C5340", VA = "0x1825C6740", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0602A2DB RID: 172763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A2DB")]
		[Address(RVA = "0x25C68B0", Offset = "0x25C54B0", VA = "0x1825C68B0", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x0602A2DC RID: 172764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2DC")]
		[Address(RVA = "0x25C6600", Offset = "0x25C5200", VA = "0x1825C6600", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x0602A2DD RID: 172765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2DD")]
		[Address(RVA = "0x25C6AF0", Offset = "0x25C56F0", VA = "0x1825C6AF0")]
		public Act25sideArchivePlugin()
		{
		}

		// Token: 0x0403C98D RID: 248205
		[Token(Token = "0x403C98D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0403C98E RID: 248206
		[Token(Token = "0x403C98E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0403C98F RID: 248207
		[Token(Token = "0x403C98F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x0403C990 RID: 248208
		[Token(Token = "0x403C990")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x0403C991 RID: 248209
		[Token(Token = "0x403C991")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x0403C992 RID: 248210
		[Token(Token = "0x403C992")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074E0 RID: 29920
		[Token(Token = "0x20074E0")]
		public class Act25sideArchivePicPlugin : ActArchivePlugin.IActArchivePicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602A2DE RID: 172766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A2DE")]
			[Address(RVA = "0x25C6480", Offset = "0x25C5080", VA = "0x1825C6480", Slot = "5")]
			public string GetHomeKV(string archiveId)
			{
				return null;
			}

			// Token: 0x0602A2DF RID: 172767 RVA: 0x000D7A60 File Offset: 0x000D5C60
			[Token(Token = "0x602A2DF")]
			[Address(RVA = "0x25C6510", Offset = "0x25C5110", VA = "0x1825C6510", Slot = "4")]
			public bool SetHomeKV(string archiveId, string kvId)
			{
				return default(bool);
			}

			// Token: 0x0602A2E0 RID: 172768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2E0")]
			[Address(RVA = "0x25C65A0", Offset = "0x25C51A0", VA = "0x1825C65A0")]
			public Act25sideArchivePicPlugin()
			{
			}

			// Token: 0x0403C993 RID: 248211
			[Token(Token = "0x403C993")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetHomeKV;

			// Token: 0x0403C994 RID: 248212
			[Token(Token = "0x403C994")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetHomeKV;

			// Token: 0x0403C995 RID: 248213
			[Token(Token = "0x403C995")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
