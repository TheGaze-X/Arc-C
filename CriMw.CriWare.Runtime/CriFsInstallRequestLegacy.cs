using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	public class CriFsInstallRequestLegacy : CriFsInstallRequest
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x36F6550", Offset = "0x36F5150", VA = "0x1836F6550", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x36F6870", Offset = "0x36F5470", VA = "0x1836F6870")]
		public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate, int installBufferSize)
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x36F6620", Offset = "0x36F5220", VA = "0x1836F6620", Slot = "8")]
		public override void Update()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x36F64B0", Offset = "0x36F50B0", VA = "0x1836F64B0", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x58")]
		private CriFsInstaller installer;
	}
}
