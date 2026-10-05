using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActArchive;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079A7 RID: 31143
	[Token(Token = "0x20079A7")]
	public class Act17sideArchivePlugin : ActArchivePlugin, IHotfixable
	{
		// Token: 0x0602BB04 RID: 178948 RVA: 0x000DCDB8 File Offset: 0x000DAFB8
		[Token(Token = "0x602BB04")]
		[Address(RVA = "0x27A2320", Offset = "0x27A0F20", VA = "0x1827A2320", Slot = "4")]
		public override ActArchiveType GetArchiveEntryType()
		{
			return ActArchiveType.NONE;
		}

		// Token: 0x0602BB05 RID: 178949 RVA: 0x000DCDD0 File Offset: 0x000DAFD0
		[Token(Token = "0x602BB05")]
		[Address(RVA = "0x27A27B0", Offset = "0x27A13B0", VA = "0x1827A27B0", Slot = "5")]
		public override bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType)
		{
			return default(bool);
		}

		// Token: 0x0602BB06 RID: 178950 RVA: 0x000DCDE8 File Offset: 0x000DAFE8
		[Token(Token = "0x602BB06")]
		[Address(RVA = "0x27A2380", Offset = "0x27A0F80", VA = "0x1827A2380", Slot = "6")]
		public override bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast)
		{
			return default(bool);
		}

		// Token: 0x0602BB07 RID: 178951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB07")]
		[Address(RVA = "0x27A2840", Offset = "0x27A1440", VA = "0x1827A2840", Slot = "7")]
		public override List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId)
		{
			return null;
		}

		// Token: 0x0602BB08 RID: 178952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB08")]
		[Address(RVA = "0x27A2240", Offset = "0x27A0E40", VA = "0x1827A2240", Slot = "8")]
		public override void ConstructCompPlugin()
		{
		}

		// Token: 0x0602BB09 RID: 178953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB09")]
		[Address(RVA = "0x27A2A80", Offset = "0x27A1680", VA = "0x1827A2A80")]
		public Act17sideArchivePlugin()
		{
		}

		// Token: 0x0403F352 RID: 258898
		[Token(Token = "0x403F352")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetArchiveEntryType;

		// Token: 0x0403F353 RID: 258899
		[Token(Token = "0x403F353")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetArchiveItemValidStatus;

		// Token: 0x0403F354 RID: 258900
		[Token(Token = "0x403F354")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetArchiveItemLockStatus;

		// Token: 0x0403F355 RID: 258901
		[Token(Token = "0x403F355")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSceneParamToState;

		// Token: 0x0403F356 RID: 258902
		[Token(Token = "0x403F356")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConstructCompPlugin;

		// Token: 0x0403F357 RID: 258903
		[Token(Token = "0x403F357")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079A8 RID: 31144
		[Token(Token = "0x20079A8")]
		private class Act17sideArchiveMusicPlugin : ActArchivePlugin.IActArchiveMusicPlugin, ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602BB0A RID: 178954 RVA: 0x000DCE00 File Offset: 0x000DB000
			[Token(Token = "0x602BB0A")]
			[Address(RVA = "0x27A2060", Offset = "0x27A0C60", VA = "0x1827A2060", Slot = "4")]
			public bool SetHomeTheme(string archiveId, string gameMusicId, long bgmInstId)
			{
				return default(bool);
			}

			// Token: 0x0602BB0B RID: 178955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BB0B")]
			[Address(RVA = "0x27A1EB0", Offset = "0x27A0AB0", VA = "0x1827A1EB0", Slot = "5")]
			public string GetHomeTheme(string archiveId)
			{
				return null;
			}

			// Token: 0x0602BB0C RID: 178956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB0C")]
			[Address(RVA = "0x27A21E0", Offset = "0x27A0DE0", VA = "0x1827A21E0")]
			public Act17sideArchiveMusicPlugin()
			{
			}

			// Token: 0x0403F358 RID: 258904
			[Token(Token = "0x403F358")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHomeTheme;

			// Token: 0x0403F359 RID: 258905
			[Token(Token = "0x403F359")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetHomeTheme;

			// Token: 0x0403F35A RID: 258906
			[Token(Token = "0x403F35A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
