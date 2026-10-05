using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x0200155F RID: 5471
	[Token(Token = "0x200155F")]
	public class MultiplayerBattleLogMgr : Singleton<MultiplayerBattleLogMgr>
	{
		// Token: 0x06007D18 RID: 32024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D18")]
		[Address(RVA = "0x2843620", Offset = "0x2842220", VA = "0x182843620")]
		public static void StartNewBattle()
		{
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D19")]
		[Address(RVA = "0x28432C0", Offset = "0x2841EC0", VA = "0x1828432C0")]
		public static void GetLogQueue(Queue<MultiplayerBattleLogMgr.LogItem> queue)
		{
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1A")]
		[Address(RVA = "0x2843730", Offset = "0x2842330", VA = "0x182843730")]
		public static void UpdateCurrentLogPath(string path)
		{
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1B")]
		[Address(RVA = "0x28433F0", Offset = "0x2841FF0", VA = "0x1828433F0")]
		public static void SetCurrentLogNeedToUpload(string remotePath, bool toPrivate, string actID)
		{
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x00037770 File Offset: 0x00035970
		[Token(Token = "0x6007D1C")]
		[Address(RVA = "0x28431D0", Offset = "0x2841DD0", VA = "0x1828431D0")]
		public static bool CheckNeedUpload()
		{
			return default(bool);
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06007D1D RID: 32029 RVA: 0x00037788 File Offset: 0x00035988
		[Token(Token = "0x17000EE8")]
		public static int count
		{
			[Token(Token = "0x6007D1D")]
			[Address(RVA = "0x2844080", Offset = "0x2842C80", VA = "0x182844080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1E")]
		[Address(RVA = "0x2843500", Offset = "0x2842100", VA = "0x182843500")]
		public static void SetLogUploaded(string remotePath)
		{
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1F")]
		[Address(RVA = "0x2843230", Offset = "0x2841E30", VA = "0x182843230")]
		public static void ClearAllLog()
		{
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE9")]
		private static string storageFile
		{
			[Token(Token = "0x6007D20")]
			[Address(RVA = "0x2844110", Offset = "0x2842D10", VA = "0x182844110")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D21")]
		[Address(RVA = "0x2843E40", Offset = "0x2842A40", VA = "0x182843E40")]
		private MultiplayerBattleLogMgr()
		{
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D22")]
		[Address(RVA = "0x2843C00", Offset = "0x2842800", VA = "0x182843C00")]
		private void _SetLogUploaded(string remotePath)
		{
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D23")]
		[Address(RVA = "0x28437D0", Offset = "0x28423D0", VA = "0x1828437D0")]
		private void _DoSave()
		{
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D24")]
		[Address(RVA = "0x2843CB0", Offset = "0x28428B0", VA = "0x182843CB0")]
		private void _TrySaveCurrent()
		{
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x000377A0 File Offset: 0x000359A0
		[Token(Token = "0x6007D25")]
		[Address(RVA = "0x28439E0", Offset = "0x28425E0", VA = "0x1828439E0")]
		private int _IndexOf(string remotePath)
		{
			return 0;
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x000377B8 File Offset: 0x000359B8
		[Token(Token = "0x6007D26")]
		[Address(RVA = "0x2843AF0", Offset = "0x28426F0", VA = "0x182843AF0")]
		private bool _NeedUpload(string fileName)
		{
			return default(bool);
		}

		// Token: 0x04007DCC RID: 32204
		[Token(Token = "0x4007DCC")]
		[FieldOffset(Offset = "0x10")]
		private MultiplayerBattleLogMgr.LogItem m_cur;

		// Token: 0x04007DCD RID: 32205
		[Token(Token = "0x4007DCD")]
		[FieldOffset(Offset = "0x30")]
		private List<MultiplayerBattleLogMgr.LogItem> m_waitForUpload;

		// Token: 0x04007DCE RID: 32206
		[Token(Token = "0x4007DCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_StartNewBattle;

		// Token: 0x04007DCF RID: 32207
		[Token(Token = "0x4007DCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetLogQueue;

		// Token: 0x04007DD0 RID: 32208
		[Token(Token = "0x4007DD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCurrentLogPath;

		// Token: 0x04007DD1 RID: 32209
		[Token(Token = "0x4007DD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCurrentLogNeedToUpload;

		// Token: 0x04007DD2 RID: 32210
		[Token(Token = "0x4007DD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckNeedUpload;

		// Token: 0x04007DD3 RID: 32211
		[Token(Token = "0x4007DD3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04007DD4 RID: 32212
		[Token(Token = "0x4007DD4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetLogUploaded;

		// Token: 0x04007DD5 RID: 32213
		[Token(Token = "0x4007DD5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearAllLog;

		// Token: 0x04007DD6 RID: 32214
		[Token(Token = "0x4007DD6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_storageFile;

		// Token: 0x04007DD7 RID: 32215
		[Token(Token = "0x4007DD7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007DD8 RID: 32216
		[Token(Token = "0x4007DD8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetLogUploaded;

		// Token: 0x04007DD9 RID: 32217
		[Token(Token = "0x4007DD9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoSave;

		// Token: 0x04007DDA RID: 32218
		[Token(Token = "0x4007DDA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TrySaveCurrent;

		// Token: 0x04007DDB RID: 32219
		[Token(Token = "0x4007DDB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IndexOf;

		// Token: 0x04007DDC RID: 32220
		[Token(Token = "0x4007DDC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__NeedUpload;

		// Token: 0x02001560 RID: 5472
		[Token(Token = "0x2001560")]
		public struct LogItem
		{
			// Token: 0x04007DDD RID: 32221
			[Token(Token = "0x4007DDD")]
			[FieldOffset(Offset = "0x0")]
			public string activityID;

			// Token: 0x04007DDE RID: 32222
			[Token(Token = "0x4007DDE")]
			[FieldOffset(Offset = "0x8")]
			public string remotePath;

			// Token: 0x04007DDF RID: 32223
			[Token(Token = "0x4007DDF")]
			[FieldOffset(Offset = "0x10")]
			public string localPath;

			// Token: 0x04007DE0 RID: 32224
			[Token(Token = "0x4007DE0")]
			[FieldOffset(Offset = "0x18")]
			public bool toPrivate;
		}
	}
}
