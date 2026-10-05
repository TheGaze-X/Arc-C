using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x02001562 RID: 5474
	[Token(Token = "0x2001562")]
	public class MultiplayerLogUploader : SingletonMonoBehaviour<MultiplayerLogUploader>
	{
		// Token: 0x06007D28 RID: 32040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D28")]
		[Address(RVA = "0x2844BB0", Offset = "0x28437B0", VA = "0x182844BB0")]
		public static void TryStartUpload()
		{
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D29")]
		[Address(RVA = "0x2844850", Offset = "0x2843450", VA = "0x182844850")]
		public void InitIfNot()
		{
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2A")]
		[Address(RVA = "0x2844990", Offset = "0x2843590", VA = "0x182844990", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2B")]
		[Address(RVA = "0x28453E0", Offset = "0x2843FE0", VA = "0x1828453E0")]
		private void _TryUploadNext()
		{
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2C")]
		[Address(RVA = "0x2845100", Offset = "0x2843D00", VA = "0x182845100")]
		private void _SendToServer(string actID, string sceneID, string localPath)
		{
		}

		// Token: 0x06007D2D RID: 32045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2D")]
		[Address(RVA = "0x2844E50", Offset = "0x2843A50", VA = "0x182844E50")]
		private void _PostToPrivateServer(string remotePath, string localPath)
		{
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D2E")]
		[Address(RVA = "0x2844D20", Offset = "0x2843920", VA = "0x182844D20")]
		private string _CompressContent(Stream logFile)
		{
			return null;
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2F")]
		[Address(RVA = "0x2844C90", Offset = "0x2843890", VA = "0x182844C90")]
		private void _Close()
		{
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D30")]
		[Address(RVA = "0x28448B0", Offset = "0x28434B0", VA = "0x1828448B0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D31")]
		[Address(RVA = "0x2845560", Offset = "0x2844160", VA = "0x182845560")]
		public MultiplayerLogUploader()
		{
		}

		// Token: 0x04007DEA RID: 32234
		[Token(Token = "0x4007DEA")]
		[FieldOffset(Offset = "0x0")]
		public static bool s_closedByServer;

		// Token: 0x04007DEB RID: 32235
		[Token(Token = "0x4007DEB")]
		private const int MAX_LOG_LENGTH = 204800;

		// Token: 0x04007DEC RID: 32236
		[Token(Token = "0x4007DEC")]
		[FieldOffset(Offset = "0x18")]
		private HttpUpload m_uploader;

		// Token: 0x04007DED RID: 32237
		[Token(Token = "0x4007DED")]
		[FieldOffset(Offset = "0x20")]
		private bool m_enableCompress;

		// Token: 0x04007DEE RID: 32238
		[Token(Token = "0x4007DEE")]
		[FieldOffset(Offset = "0x28")]
		private Queue<MultiplayerBattleLogMgr.LogItem> m_logs;

		// Token: 0x04007DEF RID: 32239
		[Token(Token = "0x4007DEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryStartUpload;

		// Token: 0x04007DF0 RID: 32240
		[Token(Token = "0x4007DF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04007DF1 RID: 32241
		[Token(Token = "0x4007DF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04007DF2 RID: 32242
		[Token(Token = "0x4007DF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryUploadNext;

		// Token: 0x04007DF3 RID: 32243
		[Token(Token = "0x4007DF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendToServer;

		// Token: 0x04007DF4 RID: 32244
		[Token(Token = "0x4007DF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PostToPrivateServer;

		// Token: 0x04007DF5 RID: 32245
		[Token(Token = "0x4007DF5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CompressContent;

		// Token: 0x04007DF6 RID: 32246
		[Token(Token = "0x4007DF6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Close;

		// Token: 0x04007DF7 RID: 32247
		[Token(Token = "0x4007DF7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04007DF8 RID: 32248
		[Token(Token = "0x4007DF8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
