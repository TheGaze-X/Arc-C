using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	[System.Serializable]
	public sealed class ExecutionContext : System.IDisposable, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		internal bool isNewCapture
		{
			[Token(Token = "0x6001254")]
			[Address(RVA = "0x4D54E60", Offset = "0x4D53A60", VA = "0x184D54E60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x4D54E90", Offset = "0x4D53A90", VA = "0x184D54E90")]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		internal bool isFlowSuppressed
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x4D54E50", Offset = "0x4D53A50", VA = "0x184D54E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001257")]
			[Address(RVA = "0x4D54E70", Offset = "0x4D53A70", VA = "0x184D54E70")]
			set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x170001B8")]
		internal bool IsPreAllocatedDefault
		{
			[Token(Token = "0x6001258")]
			[Address(RVA = "0x4D54DC0", Offset = "0x4D539C0", VA = "0x184D54DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal ExecutionContext()
		{
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x4D54BD0", Offset = "0x4D537D0", VA = "0x184D54BD0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal ExecutionContext(bool isPreAllocatedDefault)
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x4D54880", Offset = "0x4D53480", VA = "0x184D54880")]
		internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
		{
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x4D53E70", Offset = "0x4D52A70", VA = "0x184D53E70")]
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		internal System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x4D54DD0", Offset = "0x4D539D0", VA = "0x184D54DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BA")]
		internal IllogicalCallContext IllogicalCallContext
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x4D54D40", Offset = "0x4D53940", VA = "0x184D54D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		internal SynchronizationContext SynchronizationContext
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return null;
			}
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		internal SynchronizationContext SynchronizationContextNoFlow
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return null;
			}
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			set
			{
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x3CF2790", Offset = "0x3CF1390", VA = "0x183CF2790", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x4D545A0", Offset = "0x4D531A0", VA = "0x184D545A0")]
		public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
		{
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x4D54510", Offset = "0x4D53110", VA = "0x184D54510")]
		[FriendAccessAllowed]
		internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x4D54490", Offset = "0x4D53090", VA = "0x184D54490")]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x4D54230", Offset = "0x4D52E30", VA = "0x184D54230")]
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x4D53B80", Offset = "0x4D52780", VA = "0x184D53B80")]
		internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x4D53C20", Offset = "0x4D52820", VA = "0x184D53C20")]
		private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x4D54710", Offset = "0x4D53310", VA = "0x184D54710")]
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		[MethodImpl(8)]
		internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			return default(ExecutionContextSwitcher);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x4D53820", Offset = "0x4D52420", VA = "0x184D53820")]
		public ExecutionContext CreateCopy()
		{
			return null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x4D539D0", Offset = "0x4D525D0", VA = "0x184D539D0")]
		internal ExecutionContext CreateMutableCopy()
		{
			return null;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x4D53E30", Offset = "0x4D52A30", VA = "0x184D53E30")]
		public static bool IsFlowSuppressed()
		{
			return default(bool);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x4D537D0", Offset = "0x4D523D0", VA = "0x184D537D0")]
		[MethodImpl(8)]
		public static ExecutionContext Capture()
		{
			return null;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x4D53C90", Offset = "0x4D52890", VA = "0x184D53C90")]
		[FriendAccessAllowed]
		[MethodImpl(8)]
		internal static ExecutionContext FastCapture()
		{
			return null;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x4D535E0", Offset = "0x4D521E0", VA = "0x184D535E0")]
		internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			return null;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x4D53CE0", Offset = "0x4D528E0", VA = "0x184D53CE0", Slot = "5")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x4D54C00", Offset = "0x4D53800", VA = "0x184D54C00")]
		private ExecutionContext(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6001275")]
		[Address(RVA = "0x4D53DE0", Offset = "0x4D529E0", VA = "0x184D53DE0")]
		internal bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			return default(bool);
		}

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x10")]
		private SynchronizationContext _syncContext;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x18")]
		private SynchronizationContext _syncContextNoFlow;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x20")]
		private System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x28")]
		private IllogicalCallContext _illogicalCallContext;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x30")]
		private ExecutionContext.Flags _flags;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x38")]
		private System.Collections.Generic.Dictionary<IAsyncLocal, object> _localValues;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x40")]
		private System.Collections.Generic.List<IAsyncLocal> _localChangeNotifications;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ExecutionContext s_dummyDefaultEC;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly ExecutionContext Default;

		// Token: 0x02000219 RID: 537
		[Token(Token = "0x2000219")]
		private enum Flags
		{
			// Token: 0x04000A70 RID: 2672
			[Token(Token = "0x4000A70")]
			None,
			// Token: 0x04000A71 RID: 2673
			[Token(Token = "0x4000A71")]
			IsNewCapture,
			// Token: 0x04000A72 RID: 2674
			[Token(Token = "0x4000A72")]
			IsFlowSuppressed,
			// Token: 0x04000A73 RID: 2675
			[Token(Token = "0x4000A73")]
			IsPreAllocatedDefault = 4
		}

		// Token: 0x0200021A RID: 538
		[Token(Token = "0x200021A")]
		internal struct Reader
		{
			// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001277")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Reader(ExecutionContext ec)
			{
			}

			// Token: 0x06001278 RID: 4728 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001278")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public ExecutionContext DangerousGetRawExecutionContext()
			{
				return null;
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06001279 RID: 4729 RVA: 0x0000E970 File Offset: 0x0000CB70
			[Token(Token = "0x170001BD")]
			public bool IsNull
			{
				[Token(Token = "0x6001279")]
				[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600127A RID: 4730 RVA: 0x0000E988 File Offset: 0x0000CB88
			[Token(Token = "0x600127A")]
			[Address(RVA = "0x4D587C0", Offset = "0x4D573C0", VA = "0x184D587C0")]
			public bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				return default(bool);
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x0600127B RID: 4731 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
			[Token(Token = "0x170001BE")]
			public bool IsFlowSuppressed
			{
				[Token(Token = "0x600127B")]
				[Address(RVA = "0x4D58820", Offset = "0x4D57420", VA = "0x184D58820")]
				[MethodImpl(256)]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x0600127C RID: 4732 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001BF")]
			public SynchronizationContext SynchronizationContext
			{
				[Token(Token = "0x600127C")]
				[Address(RVA = "0x4D58890", Offset = "0x4D57490", VA = "0x184D58890")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x0600127D RID: 4733 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001C0")]
			public SynchronizationContext SynchronizationContextNoFlow
			{
				[Token(Token = "0x600127D")]
				[Address(RVA = "0x4D58880", Offset = "0x4D57480", VA = "0x184D58880")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x0600127E RID: 4734 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
			[Token(Token = "0x170001C1")]
			public System.Runtime.Remoting.Messaging.LogicalCallContext.Reader LogicalCallContext
			{
				[Token(Token = "0x600127E")]
				[Address(RVA = "0x4D58840", Offset = "0x4D57440", VA = "0x184D58840")]
				get
				{
					return default(System.Runtime.Remoting.Messaging.LogicalCallContext.Reader);
				}
			}

			// Token: 0x0600127F RID: 4735 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
			[Token(Token = "0x600127F")]
			[Address(RVA = "0x4D58790", Offset = "0x4D57390", VA = "0x184D58790")]
			public bool HasSameLocalValues(ExecutionContext other)
			{
				return default(bool);
			}

			// Token: 0x04000A74 RID: 2676
			[Token(Token = "0x4000A74")]
			[FieldOffset(Offset = "0x0")]
			private ExecutionContext m_ec;
		}

		// Token: 0x0200021B RID: 539
		[Token(Token = "0x200021B")]
		[System.Flags]
		internal enum CaptureOptions
		{
			// Token: 0x04000A76 RID: 2678
			[Token(Token = "0x4000A76")]
			None = 0,
			// Token: 0x04000A77 RID: 2679
			[Token(Token = "0x4000A77")]
			IgnoreSyncCtx = 1,
			// Token: 0x04000A78 RID: 2680
			[Token(Token = "0x4000A78")]
			OptimizeDefaultCase = 2
		}
	}
}
