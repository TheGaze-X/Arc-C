using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	public class CriFsBindRequest : CriFsRequest
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000076")]
		public string path
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000077")]
		public uint bindId
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x36F40C0", Offset = "0x36F2CC0", VA = "0x1836F40C0")]
		public CriFsBindRequest(CriFsBindRequest.BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x36F4040", Offset = "0x36F2C40", VA = "0x1836F4040", Slot = "8")]
		public override void Update()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x36F3FF0", Offset = "0x36F2BF0", VA = "0x1836F3FF0", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		public enum BindType
		{
			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			Cpk,
			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			Directory,
			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			File
		}
	}
}
