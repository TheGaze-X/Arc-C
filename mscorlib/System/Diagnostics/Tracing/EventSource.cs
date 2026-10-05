using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public class EventSource : System.IDisposable
	{
		// Token: 0x06002B6C RID: 11116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x4C5AE20", Offset = "0x4C59A20", VA = "0x184C5AE20")]
		protected EventSource()
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public EventSource(string eventSourceName)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x4C5DBC0", Offset = "0x4C5C7C0", VA = "0x184C5DBC0")]
		internal EventSource(System.Guid eventSourceGuid, string eventSourceName)
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x170006AC RID: 1708
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AC")]
		private string Name
		{
			[Token(Token = "0x6002B70")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00018018 File Offset: 0x00016218
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00018030 File Offset: 0x00016230
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			return default(bool);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x4C5D690", Offset = "0x4C5C290", VA = "0x184C5D690", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x4C5D890", Offset = "0x4C5C490", VA = "0x184C5D890")]
		protected void WriteEvent(int eventId, int arg1)
		{
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x4C5DA90", Offset = "0x4C5C690", VA = "0x184C5DA90")]
		protected void WriteEvent(int eventId, int arg1, int arg2)
		{
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x4C5D700", Offset = "0x4C5C300", VA = "0x184C5D700")]
		protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void WriteEvent(int eventId, params object[] args)
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x4C5D950", Offset = "0x4C5C550", VA = "0x184C5D950")]
		protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.CLSCompliant(false)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
		}

		// Token: 0x020005B1 RID: 1457
		[Token(Token = "0x20005B1")]
		protected internal struct EventData
		{
			// Token: 0x170006AD RID: 1709
			// (set) Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AD")]
			public System.IntPtr DataPointer
			{
				[Token(Token = "0x6002B7B")]
				[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
				[System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170006AE RID: 1710
			// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AE")]
			public int Size
			{
				[Token(Token = "0x6002B7C")]
				[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
				[System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170006AF RID: 1711
			// (set) Token: 0x06002B7D RID: 11133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AF")]
			internal int Reserved
			{
				[Token(Token = "0x6002B7D")]
				[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
				[System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
				}
			}
		}
	}
}
