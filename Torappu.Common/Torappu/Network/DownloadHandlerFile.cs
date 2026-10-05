using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Torappu.Network
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	public class DownloadHandlerFile : DownloadHandlerScript
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x5569750", Offset = "0x5568350", VA = "0x185569750")]
		public DownloadHandlerFile(string targetFilePath, FileMode fileMode)
		{
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0000818C File Offset: 0x0000638C
		[Token(Token = "0x17000126")]
		public bool isError
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x55697D0", Offset = "0x55683D0", VA = "0x1855697D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000081A4 File Offset: 0x000063A4
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x5569550", Offset = "0x5568150", VA = "0x185569550", Slot = "9")]
		protected override bool ReceiveData(byte[] data, int dataLength)
		{
			return default(bool);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x55694B0", Offset = "0x55680B0", VA = "0x1855694B0", Slot = "12")]
		protected override void CompleteContent()
		{
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x5569400", Offset = "0x5568000", VA = "0x185569400")]
		public void Close()
		{
		}

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x18")]
		private string m_targetFilePath;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x20")]
		private FileStream m_fileStream;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x28")]
		private FileMode m_fileMode;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isClosed;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_isError;
	}
}
