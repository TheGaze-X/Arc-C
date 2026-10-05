using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public class CriFsLoadFileRequest : CriFsRequest
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006F")]
		public string path
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000070")]
		public byte[] bytes
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x36F8390", Offset = "0x36F6F90", VA = "0x1836F8390")]
		public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize)
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x36F7A10", Offset = "0x36F6610", VA = "0x1836F7A10", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x36F7C20", Offset = "0x36F6820", VA = "0x1836F7C20", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x36F8200", Offset = "0x36F6E00", VA = "0x1836F8200", Slot = "8")]
		public override void Update()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x36F7D00", Offset = "0x36F6900", VA = "0x1836F7D00")]
		private void UpdateBinder()
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x36F7D70", Offset = "0x36F6970", VA = "0x1836F7D70")]
		private void UpdateLoader()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x36F7B00", Offset = "0x36F6700", VA = "0x1836F7B00")]
		private void OnError()
		{
		}

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x50")]
		private CriFsLoadFileRequest.Phase phase;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x58")]
		private CriFsBinder refBinder;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x60")]
		private CriFsBinder newBinder;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x68")]
		private uint bindId;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x70")]
		private CriFsLoader loader;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x78")]
		private int readUnitSize;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x80")]
		private long fileSize;

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		private enum Phase
		{
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			Stop,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			Bind,
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			Load,
			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			Done,
			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			Error
		}
	}
}
