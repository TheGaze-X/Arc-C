using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public struct InputEventListener : IObservable<InputEventPtr>
	{
		// Token: 0x06001006 RID: 4102 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x56DA990", Offset = "0x56D9590", VA = "0x1856DA990")]
		public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, InputDevice> callback)
		{
			return default(InputEventListener);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x56DAB00", Offset = "0x56D9700", VA = "0x1856DAB00")]
		public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, InputDevice> callback)
		{
			return default(InputEventListener);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x56DA780", Offset = "0x56D9380", VA = "0x1856DA780", Slot = "4")]
		public IDisposable Subscribe(IObserver<InputEventPtr> observer)
		{
			return null;
		}

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x0")]
		internal static InputEventListener.ObserverState s_ObserverState;

		// Token: 0x020001B1 RID: 433
		[Token(Token = "0x20001B1")]
		internal class ObserverState
		{
			// Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x56DEED0", Offset = "0x56DDAD0", VA = "0x1856DEED0")]
			public ObserverState()
			{
			}

			// Token: 0x040009C2 RID: 2498
			[Token(Token = "0x40009C2")]
			[FieldOffset(Offset = "0x10")]
			public InlinedArray<IObserver<InputEventPtr>> observers;

			// Token: 0x040009C3 RID: 2499
			[Token(Token = "0x40009C3")]
			[FieldOffset(Offset = "0x28")]
			public Action<InputEventPtr, InputDevice> onEventDelegate;
		}

		// Token: 0x020001B2 RID: 434
		[Token(Token = "0x20001B2")]
		private class DisposableObserver : IDisposable
		{
			// Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x56CF810", Offset = "0x56CE410", VA = "0x1856CF810", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DisposableObserver()
			{
			}

			// Token: 0x040009C4 RID: 2500
			[Token(Token = "0x40009C4")]
			[FieldOffset(Offset = "0x10")]
			public IObserver<InputEventPtr> observer;
		}
	}
}
