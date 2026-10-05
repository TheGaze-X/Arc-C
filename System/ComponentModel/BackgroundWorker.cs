using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	[DefaultEvent("DoWork")]
	public class BackgroundWorker : Component
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x5120E70", Offset = "0x511FA70", VA = "0x185120E70")]
		public BackgroundWorker()
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x5120460", Offset = "0x511F060", VA = "0x185120460")]
		private void AsyncOperationCompleted(object arg)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x170001B2")]
		public bool CancellationPending
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x5120540", Offset = "0x511F140", VA = "0x185120540")]
		public void CancelAsync()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060008B8 RID: 2232 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060008B9 RID: 2233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public event DoWorkEventHandler DoWork
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5120F60", Offset = "0x511FB60", VA = "0x185120F60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x5121150", Offset = "0x511FD50", VA = "0x185121150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x170001B3")]
		public bool IsBusy
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x5121140", Offset = "0x511FD40", VA = "0x185121140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x51205B0", Offset = "0x511F1B0", VA = "0x1851205B0", Slot = "16")]
		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4E4A2D0", Offset = "0x4E48ED0", VA = "0x184E4A2D0", Slot = "17")]
		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x51205D0", Offset = "0x511F1D0", VA = "0x1851205D0", Slot = "18")]
		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public event ProgressChangedEventHandler ProgressChanged
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x5121000", Offset = "0x511FC00", VA = "0x185121000")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x51211F0", Offset = "0x511FDF0", VA = "0x1851211F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x51205F0", Offset = "0x511F1F0", VA = "0x1851205F0")]
		private void ProgressReporter(object arg)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x51208D0", Offset = "0x511F4D0", VA = "0x1851208D0")]
		public void ReportProgress(int percentProgress)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x51206D0", Offset = "0x511F2D0", VA = "0x1851206D0")]
		public void ReportProgress(int percentProgress, object userState)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x51208E0", Offset = "0x511F4E0", VA = "0x1851208E0")]
		public void RunWorkerAsync()
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x51208F0", Offset = "0x511F4F0", VA = "0x1851208F0")]
		public void RunWorkerAsync(object argument)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public event RunWorkerCompletedEventHandler RunWorkerCompleted
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x51210A0", Offset = "0x511FCA0", VA = "0x1851210A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x5121290", Offset = "0x511FE90", VA = "0x185121290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00005448 File Offset: 0x00003648
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B4")]
		public bool WorkerReportsProgress
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00005460 File Offset: 0x00003660
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B5")]
		public bool WorkerSupportsCancellation
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x5120C20", Offset = "0x511F820", VA = "0x185120C20")]
		private void WorkerThreadStart(object argument)
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x28")]
		private bool _canCancelWorker;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x29")]
		private bool _workerReportsProgress;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x2A")]
		private bool _cancellationPending;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x2B")]
		private bool _isRunning;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x30")]
		private AsyncOperation _asyncOperation;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x38")]
		private readonly SendOrPostCallback _operationCompleted;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x40")]
		private readonly SendOrPostCallback _progressReporter;
	}
}
