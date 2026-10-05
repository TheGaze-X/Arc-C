using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000670 RID: 1648
	[Token(Token = "0x2000670")]
	[System.Serializable]
	public abstract class Stream : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x060031BE RID: 12734 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x4C87390", Offset = "0x4C85F90", VA = "0x184C87390")]
		internal System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			return null;
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060031BF RID: 12735
		[Token(Token = "0x17000801")]
		public abstract bool CanRead { [Token(Token = "0x60031BF")] get; }

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060031C0 RID: 12736
		[Token(Token = "0x17000802")]
		public abstract bool CanSeek { [Token(Token = "0x60031C0")] get; }

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0001AB68 File Offset: 0x00018D68
		[Token(Token = "0x17000803")]
		public virtual bool CanTimeout
		{
			[Token(Token = "0x60031C1")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060031C2 RID: 12738
		[Token(Token = "0x17000804")]
		public abstract bool CanWrite { [Token(Token = "0x60031C2")] get; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060031C3 RID: 12739
		[Token(Token = "0x17000805")]
		public abstract long Length { [Token(Token = "0x60031C3")] get; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060031C4 RID: 12740
		// (set) Token: 0x060031C5 RID: 12741
		[Token(Token = "0x17000806")]
		public abstract long Position { [Token(Token = "0x60031C4")] get; [Token(Token = "0x60031C5")] set; }

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0001AB80 File Offset: 0x00018D80
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000807")]
		public virtual int ReadTimeout
		{
			[Token(Token = "0x60031C6")]
			[Address(RVA = "0x4C88CD0", Offset = "0x4C878D0", VA = "0x184C88CD0", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031C7")]
			[Address(RVA = "0x4C88D90", Offset = "0x4C87990", VA = "0x184C88D90", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0001AB98 File Offset: 0x00018D98
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000808")]
		public virtual int WriteTimeout
		{
			[Token(Token = "0x60031C8")]
			[Address(RVA = "0x4C88D30", Offset = "0x4C87930", VA = "0x184C88D30", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031C9")]
			[Address(RVA = "0x4C88DF0", Offset = "0x4C879F0", VA = "0x184C88DF0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x4C86E50", Offset = "0x4C85A50", VA = "0x184C86E50", Slot = "18")]
		public virtual void Close()
		{
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x4B244E0", Offset = "0x4B230E0", VA = "0x184B244E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060031CD RID: 12749
		[Token(Token = "0x60031CD")]
		public abstract void Flush();

		// Token: 0x060031CE RID: 12750 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x4C875F0", Offset = "0x4C861F0", VA = "0x184C875F0", Slot = "21")]
		public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x4C866E0", Offset = "0x4C852E0", VA = "0x184C866E0", Slot = "22")]
		public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x4C86480", Offset = "0x4C85080", VA = "0x184C86480")]
		internal System.IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			return null;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x4C86EC0", Offset = "0x4C85AC0", VA = "0x184C86EC0", Slot = "23")]
		public virtual int EndRead(System.IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x4C87CB0", Offset = "0x4C868B0", VA = "0x184C87CB0")]
		public System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x4C87800", Offset = "0x4C86400", VA = "0x184C87800", Slot = "24")]
		public virtual System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x4C878E0", Offset = "0x4C864E0", VA = "0x184C878E0", Slot = "25")]
		public virtual System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x4C86000", Offset = "0x4C84C00", VA = "0x184C86000")]
		private System.Threading.Tasks.Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x4C86980", Offset = "0x4C85580", VA = "0x184C86980", Slot = "26")]
		public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x4C86720", Offset = "0x4C85320", VA = "0x184C86720")]
		internal System.IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			return null;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x4C88080", Offset = "0x4C86C80", VA = "0x184C88080")]
		private void RunReadWriteTaskWhenReady(System.Threading.Tasks.Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0x4C88250", Offset = "0x4C86E50", VA = "0x184C88250")]
		private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x4C874B0", Offset = "0x4C860B0", VA = "0x184C874B0")]
		private void FinishTrackingAsyncOperation()
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x4C87130", Offset = "0x4C85D30", VA = "0x184C87130", Slot = "27")]
		public virtual void EndWrite(System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x4C88840", Offset = "0x4C87440", VA = "0x184C88840")]
		public System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x4C88900", Offset = "0x4C87500", VA = "0x184C88900", Slot = "28")]
		public virtual System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x4C884A0", Offset = "0x4C870A0", VA = "0x184C884A0", Slot = "29")]
		public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x4C874F0", Offset = "0x4C860F0", VA = "0x184C874F0")]
		private System.Threading.Tasks.Task FinishWriteAsync(System.Threading.Tasks.Task writeTask, byte[] localBuffer)
		{
			return null;
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x4C86240", Offset = "0x4C84E40", VA = "0x184C86240")]
		private System.Threading.Tasks.Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x060031E1 RID: 12769
		[Token(Token = "0x60031E1")]
		public abstract long Seek(long offset, SeekOrigin origin);

		// Token: 0x060031E2 RID: 12770
		[Token(Token = "0x60031E2")]
		public abstract void SetLength(long value);

		// Token: 0x060031E3 RID: 12771
		[Token(Token = "0x60031E3")]
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x060031E4 RID: 12772 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x4C87E20", Offset = "0x4C86A20", VA = "0x184C87E20", Slot = "33")]
		public virtual int Read(System.Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x0001AC10 File Offset: 0x00018E10
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x4C87D70", Offset = "0x4C86970", VA = "0x184C87D70", Slot = "34")]
		public virtual int ReadByte()
		{
			return 0;
		}

		// Token: 0x060031E6 RID: 12774
		[Token(Token = "0x60031E6")]
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x060031E7 RID: 12775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x4C88A80", Offset = "0x4C87680", VA = "0x184C88A80", Slot = "36")]
		public virtual void Write(System.ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x4C889D0", Offset = "0x4C875D0", VA = "0x184C889D0", Slot = "37")]
		public virtual void WriteByte(byte value)
		{
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x4C869C0", Offset = "0x4C855C0", VA = "0x184C869C0")]
		internal System.IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0001AC28 File Offset: 0x00018E28
		[Token(Token = "0x60031EA")]
		[Address(RVA = "0x4C86C20", Offset = "0x4C85820", VA = "0x184C86C20")]
		internal static int BlockingEndRead(System.IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031EB")]
		[Address(RVA = "0x4C86AF0", Offset = "0x4C856F0", VA = "0x184C86AF0")]
		internal System.IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x4C86D40", Offset = "0x4C85940", VA = "0x184C86D40")]
		internal static void BlockingEndWrite(System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0001AC40 File Offset: 0x00018E40
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool HasOverriddenBeginEndRead()
		{
			return default(bool);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0001AC58 File Offset: 0x00018E58
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool HasOverriddenBeginEndWrite()
		{
			return default(bool);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Stream()
		{
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x4C88320", Offset = "0x4C86F20", VA = "0x184C88320")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal static System.Threading.Tasks.ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(System.Threading.Tasks.Task<int> readTask, byte[] localBuffer, System.Memory<byte> localDestination)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x04001B50 RID: 6992
		[Token(Token = "0x4001B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Stream Null;

		// Token: 0x04001B51 RID: 6993
		[Token(Token = "0x4001B51")]
		private const int DefaultCopyBufferSize = 81920;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private System.Threading.SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x02000671 RID: 1649
		[Token(Token = "0x2000671")]
		private struct ReadWriteParameters
		{
			// Token: 0x04001B54 RID: 6996
			[Token(Token = "0x4001B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal byte[] Buffer;

			// Token: 0x04001B55 RID: 6997
			[Token(Token = "0x4001B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int Offset;

			// Token: 0x04001B56 RID: 6998
			[Token(Token = "0x4001B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int Count;
		}

		// Token: 0x02000672 RID: 1650
		[Token(Token = "0x2000672")]
		private sealed class ReadWriteTask : System.Threading.Tasks.Task<int>, ITaskCompletionAction
		{
			// Token: 0x060031F2 RID: 12786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031F2")]
			[Address(RVA = "0x4C81150", Offset = "0x4C7FD50", VA = "0x184C81150")]
			internal void ClearBeginState()
			{
			}

			// Token: 0x060031F3 RID: 12787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031F3")]
			[Address(RVA = "0x4C81370", Offset = "0x4C7FF70", VA = "0x184C81370")]
			public ReadWriteTask(bool isRead, bool apm, System.Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, System.AsyncCallback callback)
			{
			}

			// Token: 0x060031F4 RID: 12788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031F4")]
			[Address(RVA = "0x4C81190", Offset = "0x4C7FD90", VA = "0x184C81190")]
			private static void InvokeAsyncCallback(object completedTask)
			{
			}

			// Token: 0x060031F5 RID: 12789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031F5")]
			[Address(RVA = "0x4C81220", Offset = "0x4C7FE20", VA = "0x184C81220", Slot = "14")]
			private void Invoke(System.Threading.Tasks.Task completingTask)
			{
			}

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x060031F6 RID: 12790 RVA: 0x0001AC88 File Offset: 0x00018E88
			[Token(Token = "0x17000809")]
			private bool InvokeMayRunArbitraryCode
			{
				[Token(Token = "0x60031F6")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04001B57 RID: 6999
			[Token(Token = "0x4001B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal readonly bool _isRead;

			// Token: 0x04001B58 RID: 7000
			[Token(Token = "0x4001B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
			internal readonly bool _apm;

			// Token: 0x04001B59 RID: 7001
			[Token(Token = "0x4001B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal Stream _stream;

			// Token: 0x04001B5A RID: 7002
			[Token(Token = "0x4001B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal byte[] _buffer;

			// Token: 0x04001B5B RID: 7003
			[Token(Token = "0x4001B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal readonly int _offset;

			// Token: 0x04001B5C RID: 7004
			[Token(Token = "0x4001B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal readonly int _count;

			// Token: 0x04001B5D RID: 7005
			[Token(Token = "0x4001B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private System.AsyncCallback _callback;

			// Token: 0x04001B5E RID: 7006
			[Token(Token = "0x4001B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private System.Threading.ExecutionContext _context;

			// Token: 0x04001B5F RID: 7007
			[Token(Token = "0x4001B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static System.Threading.ContextCallback s_invokeAsyncCallback;
		}

		// Token: 0x02000673 RID: 1651
		[Token(Token = "0x2000673")]
		private sealed class NullStream : Stream
		{
			// Token: 0x060031F7 RID: 12791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031F7")]
			[Address(RVA = "0x4C7FC60", Offset = "0x4C7E860", VA = "0x184C7FC60")]
			internal NullStream()
			{
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x060031F8 RID: 12792 RVA: 0x0001ACA0 File Offset: 0x00018EA0
			[Token(Token = "0x1700080A")]
			public override bool CanRead
			{
				[Token(Token = "0x60031F8")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x060031F9 RID: 12793 RVA: 0x0001ACB8 File Offset: 0x00018EB8
			[Token(Token = "0x1700080B")]
			public override bool CanWrite
			{
				[Token(Token = "0x60031F9")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x060031FA RID: 12794 RVA: 0x0001ACD0 File Offset: 0x00018ED0
			[Token(Token = "0x1700080C")]
			public override bool CanSeek
			{
				[Token(Token = "0x60031FA")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x060031FB RID: 12795 RVA: 0x0001ACE8 File Offset: 0x00018EE8
			[Token(Token = "0x1700080D")]
			public override long Length
			{
				[Token(Token = "0x60031FB")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x060031FC RID: 12796 RVA: 0x0001AD00 File Offset: 0x00018F00
			// (set) Token: 0x060031FD RID: 12797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700080E")]
			public override long Position
			{
				[Token(Token = "0x60031FC")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x60031FD")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
				set
				{
				}
			}

			// Token: 0x060031FE RID: 12798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031FE")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031FF")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
			public override void Flush()
			{
			}

			// Token: 0x06003200 RID: 12800 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6003200")]
			[Address(RVA = "0x4C7F870", Offset = "0x4C7E470", VA = "0x184C7F870", Slot = "21")]
			public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
			{
				return null;
			}

			// Token: 0x06003201 RID: 12801 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6003201")]
			[Address(RVA = "0x4C7F3F0", Offset = "0x4C7DFF0", VA = "0x184C7F3F0", Slot = "22")]
			public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
			{
				return null;
			}

			// Token: 0x06003202 RID: 12802 RVA: 0x0001AD18 File Offset: 0x00018F18
			[Token(Token = "0x6003202")]
			[Address(RVA = "0x4C7F530", Offset = "0x4C7E130", VA = "0x184C7F530", Slot = "23")]
			public override int EndRead(System.IAsyncResult asyncResult)
			{
				return 0;
			}

			// Token: 0x06003203 RID: 12803 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6003203")]
			[Address(RVA = "0x4C7F490", Offset = "0x4C7E090", VA = "0x184C7F490", Slot = "26")]
			public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
			{
				return null;
			}

			// Token: 0x06003204 RID: 12804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003204")]
			[Address(RVA = "0x4C7F6D0", Offset = "0x4C7E2D0", VA = "0x184C7F6D0", Slot = "27")]
			public override void EndWrite(System.IAsyncResult asyncResult)
			{
			}

			// Token: 0x06003205 RID: 12805 RVA: 0x0001AD30 File Offset: 0x00018F30
			[Token(Token = "0x6003205")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "32")]
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06003206 RID: 12806 RVA: 0x0001AD48 File Offset: 0x00018F48
			[Token(Token = "0x6003206")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "33")]
			public override int Read(System.Span<byte> buffer)
			{
				return 0;
			}

			// Token: 0x06003207 RID: 12807 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6003207")]
			[Address(RVA = "0x4C7F950", Offset = "0x4C7E550", VA = "0x184C7F950", Slot = "24")]
			public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
			{
				return null;
			}

			// Token: 0x06003208 RID: 12808 RVA: 0x0001AD60 File Offset: 0x00018F60
			[Token(Token = "0x6003208")]
			[Address(RVA = "0x4C7F9A0", Offset = "0x4C7E5A0", VA = "0x184C7F9A0", Slot = "25")]
			public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
			{
				return default(System.Threading.Tasks.ValueTask<int>);
			}

			// Token: 0x06003209 RID: 12809 RVA: 0x0001AD78 File Offset: 0x00018F78
			[Token(Token = "0x6003209")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "34")]
			public override int ReadByte()
			{
				return 0;
			}

			// Token: 0x0600320A RID: 12810 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600320A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x0600320B RID: 12811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600320B")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
			public override void Write(System.ReadOnlySpan<byte> buffer)
			{
			}

			// Token: 0x0600320C RID: 12812 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600320C")]
			[Address(RVA = "0x4C7FAF0", Offset = "0x4C7E6F0", VA = "0x184C7FAF0", Slot = "28")]
			public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
			{
				return null;
			}

			// Token: 0x0600320D RID: 12813 RVA: 0x0001AD90 File Offset: 0x00018F90
			[Token(Token = "0x600320D")]
			[Address(RVA = "0x4C7FA00", Offset = "0x4C7E600", VA = "0x184C7FA00", Slot = "29")]
			public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
			{
				return default(System.Threading.Tasks.ValueTask);
			}

			// Token: 0x0600320E RID: 12814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600320E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "37")]
			public override void WriteByte(byte value)
			{
			}

			// Token: 0x0600320F RID: 12815 RVA: 0x0001ADA8 File Offset: 0x00018FA8
			[Token(Token = "0x600320F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "30")]
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06003210 RID: 12816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003210")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
			public override void SetLength(long length)
			{
			}

			// Token: 0x04001B60 RID: 7008
			[Token(Token = "0x4001B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly System.Threading.Tasks.Task<int> s_zeroTask;
		}

		// Token: 0x02000674 RID: 1652
		[Token(Token = "0x2000674")]
		private sealed class SynchronousAsyncResult : System.IAsyncResult
		{
			// Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003212")]
			[Address(RVA = "0x4C89680", Offset = "0x4C88280", VA = "0x184C89680")]
			internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
			{
			}

			// Token: 0x06003213 RID: 12819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003213")]
			[Address(RVA = "0x4B5BE60", Offset = "0x4B5AA60", VA = "0x184B5BE60")]
			internal SynchronousAsyncResult(object asyncStateObject)
			{
			}

			// Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003214")]
			[Address(RVA = "0x4C89610", Offset = "0x4C88210", VA = "0x184C89610")]
			internal SynchronousAsyncResult(System.Exception ex, object asyncStateObject, bool isWrite)
			{
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06003215 RID: 12821 RVA: 0x0001ADC0 File Offset: 0x00018FC0
			[Token(Token = "0x1700080F")]
			public bool IsCompleted
			{
				[Token(Token = "0x6003215")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06003216 RID: 12822 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000810")]
			public System.Threading.WaitHandle AsyncWaitHandle
			{
				[Token(Token = "0x6003216")]
				[Address(RVA = "0x4C896C0", Offset = "0x4C882C0", VA = "0x184C896C0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06003217 RID: 12823 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000811")]
			public object AsyncState
			{
				[Token(Token = "0x6003217")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06003218 RID: 12824 RVA: 0x0001ADD8 File Offset: 0x00018FD8
			[Token(Token = "0x17000812")]
			public bool CompletedSynchronously
			{
				[Token(Token = "0x6003218")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003219")]
			[Address(RVA = "0x4C895F0", Offset = "0x4C881F0", VA = "0x184C895F0")]
			internal void ThrowIfError()
			{
			}

			// Token: 0x0600321A RID: 12826 RVA: 0x0001ADF0 File Offset: 0x00018FF0
			[Token(Token = "0x600321A")]
			[Address(RVA = "0x4C86C20", Offset = "0x4C85820", VA = "0x184C86C20")]
			internal static int EndRead(System.IAsyncResult asyncResult)
			{
				return 0;
			}

			// Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600321B")]
			[Address(RVA = "0x4C86D40", Offset = "0x4C85940", VA = "0x184C86D40")]
			internal static void EndWrite(System.IAsyncResult asyncResult)
			{
			}

			// Token: 0x04001B61 RID: 7009
			[Token(Token = "0x4001B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly object _stateObject;

			// Token: 0x04001B62 RID: 7010
			[Token(Token = "0x4001B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly bool _isWrite;

			// Token: 0x04001B63 RID: 7011
			[Token(Token = "0x4001B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private System.Threading.ManualResetEvent _waitHandle;

			// Token: 0x04001B64 RID: 7012
			[Token(Token = "0x4001B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionInfo;

			// Token: 0x04001B65 RID: 7013
			[Token(Token = "0x4001B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool _endXxxCalled;

			// Token: 0x04001B66 RID: 7014
			[Token(Token = "0x4001B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _bytesRead;
		}
	}
}
