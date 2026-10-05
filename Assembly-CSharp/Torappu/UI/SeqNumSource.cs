using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020039AC RID: 14764
	[Token(Token = "0x20039AC")]
	public struct SeqNumSource
	{
		// Token: 0x0601756E RID: 95598 RVA: 0x00096168 File Offset: 0x00094368
		[Token(Token = "0x601756E")]
		[Address(RVA = "0xFB5AB0", Offset = "0xFB46B0", VA = "0x180FB5AB0")]
		public static SeqNumSource Create()
		{
			return default(SeqNumSource);
		}

		// Token: 0x0601756F RID: 95599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601756F")]
		[Address(RVA = "0xFB5B00", Offset = "0xFB4700", VA = "0x180FB5B00")]
		public void TriggerAction()
		{
		}

		// Token: 0x0401C2CC RID: 115404
		[Token(Token = "0x401C2CC")]
		[FieldOffset(Offset = "0x0")]
		private static int s_nextActionId;

		// Token: 0x0401C2CD RID: 115405
		[Token(Token = "0x401C2CD")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isValid;

		// Token: 0x0401C2CE RID: 115406
		[Token(Token = "0x401C2CE")]
		[FieldOffset(Offset = "0x4")]
		private int m_actionId;

		// Token: 0x0401C2CF RID: 115407
		[Token(Token = "0x401C2CF")]
		[FieldOffset(Offset = "0x8")]
		private int m_seqNum;

		// Token: 0x020039AD RID: 14765
		[Token(Token = "0x20039AD")]
		public enum SyncResult
		{
			// Token: 0x0401C2D1 RID: 115409
			[Token(Token = "0x401C2D1")]
			NOT_CHANGE,
			// Token: 0x0401C2D2 RID: 115410
			[Token(Token = "0x401C2D2")]
			INIT_CHANGE,
			// Token: 0x0401C2D3 RID: 115411
			[Token(Token = "0x401C2D3")]
			ACTION_CHANGE,
			// Token: 0x0401C2D4 RID: 115412
			[Token(Token = "0x401C2D4")]
			SEQ_CHANGE
		}

		// Token: 0x020039AE RID: 14766
		[Token(Token = "0x20039AE")]
		public struct Checker
		{
			// Token: 0x06017570 RID: 95600 RVA: 0x00096180 File Offset: 0x00094380
			[Token(Token = "0x6017570")]
			[Address(RVA = "0xFB0E90", Offset = "0xFAFA90", VA = "0x180FB0E90")]
			public SeqNumSource.SyncResult SyncSource(in SeqNumSource source)
			{
				return SeqNumSource.SyncResult.NOT_CHANGE;
			}

			// Token: 0x06017571 RID: 95601 RVA: 0x00096198 File Offset: 0x00094398
			[Token(Token = "0x6017571")]
			[Address(RVA = "0xFB0E70", Offset = "0xFAFA70", VA = "0x180FB0E70")]
			public bool SyncSourceAndChanged(in SeqNumSource source)
			{
				return default(bool);
			}

			// Token: 0x0401C2D5 RID: 115413
			[Token(Token = "0x401C2D5")]
			[FieldOffset(Offset = "0x0")]
			private int m_cacheActionId;

			// Token: 0x0401C2D6 RID: 115414
			[Token(Token = "0x401C2D6")]
			[FieldOffset(Offset = "0x4")]
			private int m_cacheSeqNum;
		}
	}
}
