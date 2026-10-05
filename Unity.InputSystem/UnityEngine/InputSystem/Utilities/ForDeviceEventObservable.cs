using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	internal class ForDeviceEventObservable : IObservable<InputEventPtr>
	{
		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x560F520", Offset = "0x560E120", VA = "0x18560F520")]
		public ForDeviceEventObservable(IObservable<InputEventPtr> source, Type deviceType, InputDevice device)
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x560F3D0", Offset = "0x560DFD0", VA = "0x18560F3D0", Slot = "4")]
		public IDisposable Subscribe(IObserver<InputEventPtr> observer)
		{
			return null;
		}

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x10")]
		private IObservable<InputEventPtr> m_Source;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x18")]
		private InputDevice m_Device;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x20")]
		private Type m_DeviceType;

		// Token: 0x02000249 RID: 585
		[Token(Token = "0x2000249")]
		private class ForDevice : IObserver<InputEventPtr>
		{
			// Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x560F7B0", Offset = "0x560E3B0", VA = "0x18560F7B0")]
			public ForDevice(Type deviceType, InputDevice device, IObserver<InputEventPtr> observer)
			{
			}

			// Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public void OnCompleted()
			{
			}

			// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x560F590", Offset = "0x560E190", VA = "0x18560F590", Slot = "5")]
			public void OnError(Exception error)
			{
			}

			// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x560F5E0", Offset = "0x560E1E0", VA = "0x18560F5E0", Slot = "4")]
			public void OnNext(InputEventPtr value)
			{
			}

			// Token: 0x04000C3B RID: 3131
			[Token(Token = "0x4000C3B")]
			[FieldOffset(Offset = "0x10")]
			private IObserver<InputEventPtr> m_Observer;

			// Token: 0x04000C3C RID: 3132
			[Token(Token = "0x4000C3C")]
			[FieldOffset(Offset = "0x18")]
			private InputDevice m_Device;

			// Token: 0x04000C3D RID: 3133
			[Token(Token = "0x4000C3D")]
			[FieldOffset(Offset = "0x20")]
			private Type m_DeviceType;
		}
	}
}
