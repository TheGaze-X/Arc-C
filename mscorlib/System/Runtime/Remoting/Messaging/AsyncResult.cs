using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public class AsyncResult : System.IAsyncResult, IMessageSink, IThreadPoolWorkItem
	{
		// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal AsyncResult()
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003AA")]
		public virtual object AsyncState
		{
			[Token(Token = "0x6001E56")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003AB")]
		public virtual System.Threading.WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x6001E57")]
			[Address(RVA = "0x4B6EAA0", Offset = "0x4B6D6A0", VA = "0x184B6EAA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x170003AC")]
		public virtual bool CompletedSynchronously
		{
			[Token(Token = "0x6001E58")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x170003AD")]
		public virtual bool IsCompleted
		{
			[Token(Token = "0x6001E59")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00012E88 File Offset: 0x00011088
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AE")]
		public bool EndInvokeCalled
		{
			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0x1694F60", Offset = "0x1693B60", VA = "0x181694F60")]
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003AF")]
		public virtual object AsyncDelegate
		{
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003B0")]
		public IMessageSink NextSink
		{
			[Token(Token = "0x6001E5D")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x4B6E790", Offset = "0x4B6D390", VA = "0x184B6E790", Slot = "18")]
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "19")]
		public virtual IMessage GetReplyMessage()
		{
			return null;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0", Slot = "20")]
		public virtual void SetMessageCtrl(IMessageCtrl mc)
		{
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
		internal void SetCompletedSynchronously(bool completed)
		{
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x4B6E7E0", Offset = "0x4B6D3E0", VA = "0x184B6E7E0")]
		internal IMessage EndInvoke()
		{
			return null;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x4B6E910", Offset = "0x4B6D510", VA = "0x184B6E910", Slot = "21")]
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B1")]
		internal MonoMethodMessage CallMessage
		{
			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x4B6E900", Offset = "0x4B6D500", VA = "0x184B6E900", Slot = "10")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		private void MarkAborted(System.Threading.ThreadAbortException tae)
		{
		}

		// Token: 0x06001E68 RID: 7784
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x4B6E900", Offset = "0x4B6D500", VA = "0x184B6E900")]
		[MethodImpl(4096)]
		internal extern object Invoke();

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object async_state;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Threading.WaitHandle handle;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object async_delegate;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.IntPtr data;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object object_data;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool sync_completed;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool completed;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool endinvoke_called;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object async_callback;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private System.Threading.ExecutionContext current;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private System.Threading.ExecutionContext original;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long add_time;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MonoMethodMessage call_message;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IMessageCtrl message_ctrl;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IMessage reply_message;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private System.Threading.WaitCallback orig_cb;
	}
}
