using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	[StructLayout(0)]
	internal sealed class InternalThread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x06001372 RID: 4978
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x4ADF220", Offset = "0x4ADDE20", VA = "0x184ADF220")]
		[MethodImpl(4096)]
		private extern void Thread_free_internal();

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x4ADF1C0", Offset = "0x4ADDDC0", VA = "0x184ADF1C0", Slot = "1")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected override void Finalize()
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x4ADF230", Offset = "0x4ADDE30", VA = "0x184ADF230")]
		public InternalThread()
		{
		}

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int lock_thread_id;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr handle;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.IntPtr native_handle;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.IntPtr name_chars;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int name_free;

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int name_length;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ThreadState state;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object abort_exc;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int abort_state_handle;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal long thread_id;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private System.IntPtr debugger_thread;

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.UIntPtr static_data;

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private System.IntPtr runtime_thread_info;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object current_appcontext;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object root_domain_thread;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal byte[] _serialized_principal;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int _serialized_principal_version;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private System.IntPtr appdomain_refs;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int interruption_requested;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private System.IntPtr longlived;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal bool threadpool_thread;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool thread_interrupt_requested;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		internal int stack_size;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal byte apartment_state;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		internal int critical_region_level;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal int managed_id;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int small_id;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private System.IntPtr manage_callback;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private System.IntPtr flags;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private System.IntPtr thread_pinning_ref;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private System.IntPtr abort_protected_block_count;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int priority;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private System.IntPtr owned_mutex;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private System.IntPtr suspended_event;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int self_suspended;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private System.IntPtr thread_state;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private System.IntPtr netcore0;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private System.IntPtr netcore1;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private System.IntPtr netcore2;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private System.IntPtr last;
	}
}
