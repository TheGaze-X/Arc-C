using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class CriFsWebInstallRequest : CriFsInstallRequest
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x36FC490", Offset = "0x36FB090", VA = "0x1836FC490", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x36FC480", Offset = "0x36FB080", VA = "0x1836FC480")]
		public bool GetCRC32(out uint ret_val)
		{
			return default(bool);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x36FC730", Offset = "0x36FB330", VA = "0x1836FC730")]
		public CriFsWebInstallRequest(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x36FC4B0", Offset = "0x36FB0B0", VA = "0x1836FC4B0", Slot = "8")]
		public override void Update()
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x36FC3E0", Offset = "0x36FAFE0", VA = "0x1836FC3E0", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x58")]
		private CriFsWebInstaller installer;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x60")]
		private uint crc32;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x64")]
		private bool crc32_set;
	}
}
