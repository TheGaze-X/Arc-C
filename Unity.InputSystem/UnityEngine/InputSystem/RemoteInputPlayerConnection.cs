using System;
using Il2CppDummyDll;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message>
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5698EA0", Offset = "0x5697AA0", VA = "0x185698EA0")]
		public void Bind(IEditorPlayerConnection connection, bool isConnected)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x5699790", Offset = "0x5698390", VA = "0x185699790", Slot = "7")]
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer)
		{
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5699410", Offset = "0x5698010", VA = "0x185699410")]
		private void OnConnected(int id)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x56994D0", Offset = "0x56980D0", VA = "0x1856994D0")]
		private void OnDisconnected(int id)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x5699590", Offset = "0x5698190", VA = "0x185699590")]
		private void OnNewDevice(MessageEventArgs args)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x56995B0", Offset = "0x56981B0", VA = "0x1856995B0")]
		private void OnNewLayout(MessageEventArgs args)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x56995A0", Offset = "0x56981A0", VA = "0x1856995A0")]
		private void OnNewEvents(MessageEventArgs args)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x56995C0", Offset = "0x56981C0", VA = "0x1856995C0")]
		private void OnRemoveDevice(MessageEventArgs args)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x5699400", Offset = "0x5698000", VA = "0x185699400")]
		private void OnChangeUsages(MessageEventArgs args)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x56995D0", Offset = "0x56981D0", VA = "0x1856995D0")]
		private void OnStartSending(MessageEventArgs args)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x56995E0", Offset = "0x56981E0", VA = "0x1856995E0")]
		private void OnStopSending(MessageEventArgs args)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x56995F0", Offset = "0x56981F0", VA = "0x1856995F0")]
		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x56999A0", Offset = "0x56985A0", VA = "0x1856999A0", Slot = "4")]
		private void OnNext(InputRemoting.Message msg)
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void OnError(Exception error)
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		private void OnCompleted()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public RemoteInputPlayerConnection()
		{
		}

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid kNewDeviceMsg;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Guid kNewLayoutMsg;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Guid kNewEventsMsg;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Guid kRemoveDeviceMsg;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Guid kChangeUsagesMsg;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Guid kStartSendingMsg;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Guid kStopSendingMsg;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private IEditorPlayerConnection m_Connection;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RemoteInputPlayerConnection.Subscriber[] m_Subscribers;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] m_ConnectedIds;

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		private class Subscriber : IDisposable
		{
			// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x569A200", Offset = "0x5698E00", VA = "0x18569A200", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Subscriber()
			{
			}

			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x10")]
			public RemoteInputPlayerConnection owner;

			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0x18")]
			public IObserver<InputRemoting.Message> observer;
		}
	}
}
