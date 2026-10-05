using System;
using System.IO;
using BestHTTP.PlatformSupport.TcpClient.General;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	internal sealed class HTTPConnection : ConnectionBase
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x1700053E")]
		public override bool IsRemovable
		{
			[Token(Token = "0x6002638")]
			[Address(RVA = "0x5385F30", Offset = "0x5384B30", VA = "0x185385F30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x5382370", Offset = "0x5380F70", VA = "0x185382370")]
		internal HTTPConnection(string serverAddress)
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x5384620", Offset = "0x5383220", VA = "0x185384620", Slot = "7")]
		protected override void ThreadFunc(object param)
		{
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x5382520", Offset = "0x5381120", VA = "0x185382520")]
		private void Connect()
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00010890 File Offset: 0x0000EA90
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x5383F60", Offset = "0x5382B60", VA = "0x185383F60")]
		private bool Receive()
		{
			return default(bool);
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x5383A60", Offset = "0x5382660", VA = "0x185383A60")]
		private bool LoadFromCache(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x5385B40", Offset = "0x5384740", VA = "0x185385B40")]
		private bool TryLoadAllFromCache()
		{
			return default(bool);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x5385DB0", Offset = "0x53849B0", VA = "0x185385DB0")]
		private void TryStoreInCache()
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x53838E0", Offset = "0x53824E0", VA = "0x1853838E0")]
		private Uri GetRedirectUri(string location)
		{
			return null;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x5382380", Offset = "0x5380F80", VA = "0x185382380", Slot = "6")]
		internal override void Abort(HTTPConnectionStates newState)
		{
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002642")]
		[Address(RVA = "0x53823F0", Offset = "0x5380FF0", VA = "0x1853823F0")]
		private void Close()
		{
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002643")]
		[Address(RVA = "0x53838C0", Offset = "0x53824C0", VA = "0x1853838C0", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04001548 RID: 5448
		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x60")]
		private TcpClient Client;

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x68")]
		private Stream Stream;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x70")]
		private KeepAliveHeader KeepAlive;
	}
}
