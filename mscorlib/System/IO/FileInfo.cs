using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	[System.Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x4C78CA0", Offset = "0x4C778A0", VA = "0x184C78CA0")]
		private FileInfo()
		{
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319E")]
		[Address(RVA = "0x4C78A40", Offset = "0x4C77640", VA = "0x184C78A40")]
		public FileInfo(string fileName)
		{
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x4C78B50", Offset = "0x4C77750", VA = "0x184C78B50")]
		internal FileInfo(string originalPath, [System.Runtime.InteropServices.Optional] string fullPath, [System.Runtime.InteropServices.Optional] string fileName, bool isNormalized = false)
		{
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x0001AA18 File Offset: 0x00018C18
		[Token(Token = "0x170007EF")]
		public long Length
		{
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x4C78CB0", Offset = "0x4C778B0", VA = "0x184C78CB0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0x4C789D0", Offset = "0x4C775D0", VA = "0x184C789D0")]
		public StreamWriter CreateText()
		{
			return null;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031A2")]
		[Address(RVA = "0x4C78960", Offset = "0x4C77560", VA = "0x184C78960")]
		public StreamWriter AppendText()
		{
			return null;
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A3")]
		[Address(RVA = "0x4C77520", Offset = "0x4C76120", VA = "0x184C77520")]
		private FileInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007F0")]
		public override string Name
		{
			[Token(Token = "0x60031A4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "9")]
			get
			{
				return null;
			}
		}
	}
}
