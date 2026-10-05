using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	internal abstract class ConnectionBase : IDisposable
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052B")]
		public string ServerAddress
		{
			[Token(Token = "0x6002602")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002603")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000106E0 File Offset: 0x0000E8E0
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052C")]
		public HTTPConnectionStates State
		{
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return HTTPConnectionStates.Initial;
			}
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x1700052D")]
		public bool IsFree
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x5381900", Offset = "0x5380500", VA = "0x185381900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x1700052E")]
		public bool IsActive
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x53818E0", Offset = "0x53804E0", VA = "0x1853818E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052F")]
		public HTTPRequest CurrentRequest
		{
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002609")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x17000530")]
		public virtual bool IsRemovable
		{
			[Token(Token = "0x600260A")]
			[Address(RVA = "0x5381920", Offset = "0x5380520", VA = "0x185381920", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00010740 File Offset: 0x0000E940
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000531")]
		public DateTime StartTime
		{
			[Token(Token = "0x600260B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600260C")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x00010758 File Offset: 0x0000E958
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000532")]
		public DateTime TimedOutStart
		{
			[Token(Token = "0x600260D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600260E")]
			[Address(RVA = "0x53810F0", Offset = "0x537FCF0", VA = "0x1853810F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000533")]
		protected HTTPProxy Proxy
		{
			[Token(Token = "0x600260F")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002610")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x17000534")]
		public bool HasProxy
		{
			[Token(Token = "0x6002611")]
			[Address(RVA = "0x1FF9020", Offset = "0x1FF7C20", VA = "0x181FF9020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000535")]
		public Uri LastProcessedUri
		{
			[Token(Token = "0x6002612")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002613")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x53817D0", Offset = "0x53803D0", VA = "0x1853817D0")]
		public ConnectionBase(string serverAddress)
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x5381850", Offset = "0x5380450", VA = "0x185381850")]
		public ConnectionBase(string serverAddress, bool threaded)
		{
		}

		// Token: 0x06002616 RID: 9750
		[Token(Token = "0x6002616")]
		internal abstract void Abort(HTTPConnectionStates hTTPConnectionStates);

		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x5381570", Offset = "0x5380170", VA = "0x185381570")]
		internal void Process(HTTPRequest request)
		{
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void ThreadFunc(object param)
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x5381330", Offset = "0x537FF30", VA = "0x185381330")]
		internal void HandleProgressCallback()
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x5381230", Offset = "0x537FE30", VA = "0x185381230")]
		internal void HandleCallback()
		{
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x5381790", Offset = "0x5380390", VA = "0x185381790")]
		internal void Recycle(HTTPConnectionRecycledDelegate onConnectionRecycled)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x53816E0", Offset = "0x53802E0", VA = "0x1853816E0")]
		protected void RecycleNow()
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x00010788 File Offset: 0x0000E988
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000536")]
		private protected bool IsDisposed
		{
			[Token(Token = "0x600261D")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600261E")]
			[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x53811B0", Offset = "0x537FDB0", VA = "0x1853811B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x5381220", Offset = "0x537FE20", VA = "0x185381220", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x48")]
		protected DateTime LastProcessTime;

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x50")]
		protected HTTPConnectionRecycledDelegate OnConnectionRecycled;

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x58")]
		private bool IsThreaded;
	}
}
