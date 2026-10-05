using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	public class FileDownloader : IDisposable
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x556A2C0", Offset = "0x5568EC0", VA = "0x18556A2C0")]
		public FileDownloader()
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x5569B50", Offset = "0x5568750", VA = "0x185569B50")]
		public void DownloadFile(FileDownloader.Options options)
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x5569A70", Offset = "0x5568670", VA = "0x185569A70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x5569C40", Offset = "0x5568840", VA = "0x185569C40")]
		public FileDownloader.CancelletionInfo InterruptAll()
		{
			return null;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x556A1D0", Offset = "0x5568DD0", VA = "0x18556A1D0")]
		private void _TryStartDownload(FileDownloader.Options options)
		{
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x5569E50", Offset = "0x5568A50", VA = "0x185569E50")]
		private void _CheckPendingTasks(FileDownloader.DownloadProcHandler handler)
		{
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x5569C50", Offset = "0x5568850", VA = "0x185569C50")]
		private FileDownloader.CancelletionInfo _CancelAllTasks()
		{
			return null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x556A030", Offset = "0x5568C30", VA = "0x18556A030")]
		private void _StartDownloadTask(FileDownloader.Options options)
		{
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x5569F20", Offset = "0x5568B20", VA = "0x185569F20")]
		private IEnumerator _DownloadFileTask(FileDownloader.DownloadTaskInput input)
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x5569FB0", Offset = "0x5568BB0", VA = "0x185569FB0")]
		private IEnumerator _DownloadFile(FileDownloader.DownloadTaskInput input)
		{
			return null;
		}

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		private const int MAX_CONNECTION_NUM = 2;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		private const int CONNECTION_TIMEOUT = 20;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		private const float CLIENT_PAUSE_THRESHOLD = 0.5f;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isDispose;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isInterrupting;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x12")]
		public bool allowProfile;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x18")]
		private List<FileDownloader.DownloadProcHandler> m_downloadingTasks;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x20")]
		private Queue<FileDownloader.Options> m_pendingTasks;

		// Token: 0x02000202 RID: 514
		[Token(Token = "0x2000202")]
		public enum DownloadState
		{
			// Token: 0x04000BDF RID: 3039
			[Token(Token = "0x4000BDF")]
			CONNECTING,
			// Token: 0x04000BE0 RID: 3040
			[Token(Token = "0x4000BE0")]
			DOWNLOADING,
			// Token: 0x04000BE1 RID: 3041
			[Token(Token = "0x4000BE1")]
			RENAMING,
			// Token: 0x04000BE2 RID: 3042
			[Token(Token = "0x4000BE2")]
			COMPLETE,
			// Token: 0x04000BE3 RID: 3043
			[Token(Token = "0x4000BE3")]
			ERROR
		}

		// Token: 0x02000203 RID: 515
		[Token(Token = "0x2000203")]
		public class CancelletionInfo
		{
			// Token: 0x06000C22 RID: 3106 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x5564EE0", Offset = "0x5563AE0", VA = "0x185564EE0")]
			public static FileDownloader.CancelletionInfo FileDownloader_Create(FileDownloader context)
			{
				return null;
			}

			// Token: 0x06000C23 RID: 3107 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x5564FF0", Offset = "0x5563BF0", VA = "0x185564FF0")]
			public IEnumerator WaitForFinish()
			{
				return null;
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x5565070", Offset = "0x5563C70", VA = "0x185565070")]
			public CancelletionInfo()
			{
			}

			// Token: 0x04000BE4 RID: 3044
			[Token(Token = "0x4000BE4")]
			[FieldOffset(Offset = "0x10")]
			private List<FileDownloader.DownloadProcHandler> m_downloadingTasks;
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		private class DownloadProcHandler
		{
			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000081D4 File Offset: 0x000063D4
			// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000129")]
			public long downloadSize
			{
				[Token(Token = "0x6000C2C")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000C2D")]
				[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000081EC File Offset: 0x000063EC
			[Token(Token = "0x1700012A")]
			public bool isContinue
			{
				[Token(Token = "0x6000C2E")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00008204 File Offset: 0x00006404
			[Token(Token = "0x1700012B")]
			public bool isNotRunning
			{
				[Token(Token = "0x6000C2F")]
				[Address(RVA = "0x5569920", Offset = "0x5568520", VA = "0x185569920")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x5569860", Offset = "0x5568460", VA = "0x185569860")]
			public void Cancel()
			{
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			public void FileDownloader_BindTask(DownloadFileTask task)
			{
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x0000821C File Offset: 0x0000641C
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x5569910", Offset = "0x5568510", VA = "0x185569910")]
			public bool UpdateDownloadSize(long newSize)
			{
				return default(bool);
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
			public DownloadProcHandler()
			{
			}

			// Token: 0x04000BEA RID: 3050
			[Token(Token = "0x4000BEA")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isContinue;

			// Token: 0x04000BEB RID: 3051
			[Token(Token = "0x4000BEB")]
			[FieldOffset(Offset = "0x18")]
			private DownloadFileTask m_internalTask;

			// Token: 0x04000BED RID: 3053
			[Token(Token = "0x4000BED")]
			[FieldOffset(Offset = "0x28")]
			public FileDownloader.DownloadState state;
		}

		// Token: 0x02000206 RID: 518
		[Token(Token = "0x2000206")]
		private class DownloadTaskInput
		{
			// Token: 0x06000C34 RID: 3124 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DownloadTaskInput()
			{
			}

			// Token: 0x04000BEE RID: 3054
			[Token(Token = "0x4000BEE")]
			[FieldOffset(Offset = "0x10")]
			public FileDownloader.DownloadProcHandler downloadHandler;

			// Token: 0x04000BEF RID: 3055
			[Token(Token = "0x4000BEF")]
			[FieldOffset(Offset = "0x18")]
			public FileDownloader.Options options;
		}

		// Token: 0x02000207 RID: 519
		[Token(Token = "0x2000207")]
		public interface IDownloadMessage
		{
		}

		// Token: 0x02000208 RID: 520
		[Token(Token = "0x2000208")]
		public enum DownloadMsgType
		{
			// Token: 0x04000BF1 RID: 3057
			[Token(Token = "0x4000BF1")]
			SIZE = 1,
			// Token: 0x04000BF2 RID: 3058
			[Token(Token = "0x4000BF2")]
			FINISH
		}

		// Token: 0x02000209 RID: 521
		[Token(Token = "0x2000209")]
		public struct DownloadSizeMessage : FileDownloader.IDownloadMessage
		{
			// Token: 0x04000BF3 RID: 3059
			[Token(Token = "0x4000BF3")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000BF4 RID: 3060
			[Token(Token = "0x4000BF4")]
			[FieldOffset(Offset = "0x8")]
			public long downloadSize;
		}

		// Token: 0x0200020A RID: 522
		[Token(Token = "0x200020A")]
		public struct DownloadFinishMessage : FileDownloader.IDownloadMessage
		{
			// Token: 0x04000BF5 RID: 3061
			[Token(Token = "0x4000BF5")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000BF6 RID: 3062
			[Token(Token = "0x4000BF6")]
			[FieldOffset(Offset = "0x8")]
			public FileDownloader.Options options;

			// Token: 0x04000BF7 RID: 3063
			[Token(Token = "0x4000BF7")]
			[FieldOffset(Offset = "0x40")]
			public bool isSucceed;
		}

		// Token: 0x0200020B RID: 523
		[Token(Token = "0x200020B")]
		public struct Options
		{
			// Token: 0x06000C35 RID: 3125 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x55725F0", Offset = "0x55711F0", VA = "0x1855725F0")]
			public void TryDownloadSizeMsg(long curSize)
			{
			}

			// Token: 0x06000C36 RID: 3126 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x55724C0", Offset = "0x55710C0", VA = "0x1855724C0")]
			public void TryDownloadFinishMsg(bool isSuc)
			{
			}

			// Token: 0x04000BF8 RID: 3064
			[Token(Token = "0x4000BF8")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000BF9 RID: 3065
			[Token(Token = "0x4000BF9")]
			[FieldOffset(Offset = "0x8")]
			public string targetPath;

			// Token: 0x04000BFA RID: 3066
			[Token(Token = "0x4000BFA")]
			[FieldOffset(Offset = "0x10")]
			public string url;

			// Token: 0x04000BFB RID: 3067
			[Token(Token = "0x4000BFB")]
			[FieldOffset(Offset = "0x18")]
			public bool allowResume;

			// Token: 0x04000BFC RID: 3068
			[Token(Token = "0x4000BFC")]
			[FieldOffset(Offset = "0x20")]
			public long totalSize;

			// Token: 0x04000BFD RID: 3069
			[Token(Token = "0x4000BFD")]
			[FieldOffset(Offset = "0x28")]
			public int taskCode;

			// Token: 0x04000BFE RID: 3070
			[Token(Token = "0x4000BFE")]
			[FieldOffset(Offset = "0x2C")]
			public int messageFlags;

			// Token: 0x04000BFF RID: 3071
			[Token(Token = "0x4000BFF")]
			[FieldOffset(Offset = "0x30")]
			public Queue<FileDownloader.IDownloadMessage> messageQueue;
		}
	}
}
