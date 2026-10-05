using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	internal class ServicePointScheduler
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		private ServicePoint ServicePoint
		{
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x1700050D")]
		public int MaxIdleTime
		{
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170B")]
		[Address(RVA = "0x508BC60", Offset = "0x508A860", VA = "0x18508BC60")]
		public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
		{
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x508B6B0", Offset = "0x508A2B0", VA = "0x18508B6B0")]
		public void Run()
		{
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x508B5D0", Offset = "0x508A1D0", VA = "0x18508B5D0")]
		private Task RunScheduler()
		{
			return null;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x508A980", Offset = "0x5089580", VA = "0x18508A980")]
		private void Cleanup()
		{
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x508B390", Offset = "0x5089F90", VA = "0x18508B390")]
		private void RunSchedulerIteration()
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x508AF50", Offset = "0x5089B50", VA = "0x18508AF50")]
		private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation)
		{
			return default(bool);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x508AB50", Offset = "0x5089750", VA = "0x18508AB50")]
		private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x508B780", Offset = "0x508A380", VA = "0x18508B780")]
		private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			return default(bool);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x508B2C0", Offset = "0x5089EC0", VA = "0x18508B2C0")]
		private void RemoveOperation(WebOperation operation)
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x508B1F0", Offset = "0x5089DF0", VA = "0x18508B1F0")]
		private void RemoveIdleConnection(WebConnection connection)
		{
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x508ABA0", Offset = "0x50897A0", VA = "0x18508ABA0")]
		private void FinalCleanup()
		{
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x508B990", Offset = "0x508A590", VA = "0x18508B990")]
		public void SendRequest(WebOperation operation, string groupName)
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x508ACE0", Offset = "0x50898E0", VA = "0x18508ACE0")]
		private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			return null;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x508AF40", Offset = "0x5089B40", VA = "0x18508AF40")]
		private void OnConnectionCreated(WebConnection connection)
		{
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x508AF10", Offset = "0x5089B10", VA = "0x18508AF10")]
		private void OnConnectionClosed(WebConnection connection)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x508BB40", Offset = "0x508A740", VA = "0x18508BB40")]
		public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
		{
			return null;
		}

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x18")]
		private int running;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x1C")]
		private int maxIdleTime;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x20")]
		private ServicePointScheduler.AsyncManualResetEvent schedulerEvent;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x28")]
		private ServicePointScheduler.ConnectionGroup defaultGroup;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x38")]
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations;

		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x40")]
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections;

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x48")]
		private int currentConnections;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x4C")]
		private int connectionLimit;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x50")]
		private DateTime idleSince;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x0")]
		private static int nextId;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x58")]
		public readonly int ID;

		// Token: 0x02000336 RID: 822
		[Token(Token = "0x2000336")]
		private class ConnectionGroup
		{
			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x0600171C RID: 5916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700050E")]
			public ServicePointScheduler Scheduler
			{
				[Token(Token = "0x600171C")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600171D RID: 5917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x5083EA0", Offset = "0x5082AA0", VA = "0x185083EA0")]
			public ConnectionGroup(ServicePointScheduler scheduler, string name)
			{
			}

			// Token: 0x0600171E RID: 5918 RVA: 0x0000A908 File Offset: 0x00008B08
			[Token(Token = "0x600171E")]
			[Address(RVA = "0x5083D90", Offset = "0x5082990", VA = "0x185083D90")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600171F RID: 5919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x5083E00", Offset = "0x5082A00", VA = "0x185083E00")]
			public void RemoveConnection(WebConnection connection)
			{
			}

			// Token: 0x06001720 RID: 5920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001720")]
			[Address(RVA = "0x5083660", Offset = "0x5082260", VA = "0x185083660")]
			public void Cleanup()
			{
			}

			// Token: 0x06001721 RID: 5921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x5083920", Offset = "0x5082520", VA = "0x185083920")]
			public void EnqueueOperation(WebOperation operation)
			{
			}

			// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001722")]
			[Address(RVA = "0x5083C70", Offset = "0x5082870", VA = "0x185083C70")]
			public WebOperation GetNextOperation()
			{
				return null;
			}

			// Token: 0x06001723 RID: 5923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x5083980", Offset = "0x5082580", VA = "0x185083980")]
			public WebConnection FindIdleConnection(WebOperation operation)
			{
				return null;
			}

			// Token: 0x06001724 RID: 5924 RVA: 0x0000A920 File Offset: 0x00008B20
			[Token(Token = "0x6001724")]
			[Address(RVA = "0x5083750", Offset = "0x5082350", VA = "0x185083750")]
			public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				return default(ValueTuple<WebConnection, bool>);
			}

			// Token: 0x04000D25 RID: 3365
			[Token(Token = "0x4000D25")]
			[FieldOffset(Offset = "0x0")]
			private static int nextId;

			// Token: 0x04000D26 RID: 3366
			[Token(Token = "0x4000D26")]
			[FieldOffset(Offset = "0x20")]
			public readonly int ID;

			// Token: 0x04000D27 RID: 3367
			[Token(Token = "0x4000D27")]
			[FieldOffset(Offset = "0x28")]
			private LinkedList<WebConnection> connections;

			// Token: 0x04000D28 RID: 3368
			[Token(Token = "0x4000D28")]
			[FieldOffset(Offset = "0x30")]
			private LinkedList<WebOperation> queue;
		}

		// Token: 0x02000337 RID: 823
		[Token(Token = "0x2000337")]
		private class AsyncManualResetEvent
		{
			// Token: 0x06001725 RID: 5925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001725")]
			[Address(RVA = "0x50833F0", Offset = "0x5081FF0", VA = "0x1850833F0")]
			public Task<bool> WaitAsync(int millisecondTimeout)
			{
				return null;
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001726")]
			[Address(RVA = "0x5083190", Offset = "0x5081D90", VA = "0x185083190")]
			public void Set()
			{
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001727")]
			[Address(RVA = "0x50830D0", Offset = "0x5081CD0", VA = "0x1850830D0")]
			public void Reset()
			{
			}

			// Token: 0x06001728 RID: 5928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001728")]
			[Address(RVA = "0x5083550", Offset = "0x5082150", VA = "0x185083550")]
			public AsyncManualResetEvent(bool state)
			{
			}

			// Token: 0x04000D29 RID: 3369
			[Token(Token = "0x4000D29")]
			[FieldOffset(Offset = "0x10")]
			private TaskCompletionSource<bool> m_tcs;
		}
	}
}
