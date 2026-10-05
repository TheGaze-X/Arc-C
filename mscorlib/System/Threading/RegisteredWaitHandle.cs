using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class RegisteredWaitHandle : System.MarshalByRefObject
	{
		// Token: 0x0600136E RID: 4974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x4AE0350", Offset = "0x4ADEF50", VA = "0x184AE0350")]
		internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, System.TimeSpan timeout, bool executeOnlyOnce)
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x4ADFD40", Offset = "0x4ADE940", VA = "0x184ADFD40")]
		internal void Wait(object state)
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x4ADFB30", Offset = "0x4ADE730", VA = "0x184ADFB30")]
		private void DoCallBack(object timedOut)
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x4ADFC50", Offset = "0x4ADE850", VA = "0x184ADFC50")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public bool Unregister(WaitHandle waitObject)
		{
			return default(bool);
		}

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private WaitHandle _waitObject;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaitOrTimerCallback _callback;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _state;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitHandle _finalEvent;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ManualResetEvent _cancelEvent;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.TimeSpan _timeout;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _callsInProcess;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _executeOnlyOnce;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool _unregistered;
	}
}
