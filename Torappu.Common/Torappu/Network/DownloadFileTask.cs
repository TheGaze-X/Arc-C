using System;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	public class DownloadFileTask : IDisposable
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x5568D20", Offset = "0x5567920", VA = "0x185568D20")]
		public static DownloadFileTask StartDownloadTask(DownloadFileTask.Options options)
		{
			return null;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x000080E4 File Offset: 0x000062E4
		[Token(Token = "0x1700011E")]
		public long downloadSize
		{
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000080FC File Offset: 0x000062FC
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700011F")]
		public long targetFileSize
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x35378E0", Offset = "0x35364E0", VA = "0x1835378E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00008114 File Offset: 0x00006314
		[Token(Token = "0x17000120")]
		public bool isFinished
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0000812C File Offset: 0x0000632C
		[Token(Token = "0x17000121")]
		public bool isError
		{
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000122")]
		public string errorMessage
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00008144 File Offset: 0x00006344
		[Token(Token = "0x17000123")]
		public bool isConnectionTimeout
		{
			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x55693E0", Offset = "0x5567FE0", VA = "0x1855693E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x5568C70", Offset = "0x5567870", VA = "0x185568C70")]
		public void Abort()
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x5569160", Offset = "0x5567D60", VA = "0x185569160")]
		private void _OnResponseFragments(HTTPRequest request, HTTPResponse response)
		{
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x5568C90", Offset = "0x5567890", VA = "0x185568C90", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x55693B0", Offset = "0x5567FB0", VA = "0x1855693B0")]
		private static void _TryAbortRequest(HTTPRequest request)
		{
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DownloadFileTask()
		{
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		private const int DOWNLOAD_FRAGMENT_SIZE = 1048576;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		private const int DEFAULT_CON_TIMEOUT = 20;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x10")]
		private FileStream m_fstream;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x18")]
		private HTTPRequest m_request;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isError;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x21")]
		private bool m_isFinished;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x22")]
		private bool m_isDisposed;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x28")]
		private long m_downloadSize;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x30")]
		private DownloadFileTask.Options m_options;

		// Token: 0x020001FF RID: 511
		[Token(Token = "0x20001FF")]
		public struct Options
		{
			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0000815C File Offset: 0x0000635C
			[Token(Token = "0x17000124")]
			public bool allowResume
			{
				[Token(Token = "0x6000C10")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00008174 File Offset: 0x00006374
			[Token(Token = "0x17000125")]
			public long totalSize
			{
				[Token(Token = "0x6000C11")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x55724B0", Offset = "0x55710B0", VA = "0x1855724B0")]
			public void SetAllowResume(long totalSize)
			{
			}

			// Token: 0x04000BCC RID: 3020
			[Token(Token = "0x4000BCC")]
			[FieldOffset(Offset = "0x0")]
			private bool m_allowResume;

			// Token: 0x04000BCD RID: 3021
			[Token(Token = "0x4000BCD")]
			[FieldOffset(Offset = "0x8")]
			private long m_totalSize;

			// Token: 0x04000BCE RID: 3022
			[Token(Token = "0x4000BCE")]
			[FieldOffset(Offset = "0x10")]
			public string url;

			// Token: 0x04000BCF RID: 3023
			[Token(Token = "0x4000BCF")]
			[FieldOffset(Offset = "0x18")]
			public string cachedFilePath;

			// Token: 0x04000BD0 RID: 3024
			[Token(Token = "0x4000BD0")]
			[FieldOffset(Offset = "0x20")]
			public int connectionTimeout;
		}
	}
}
