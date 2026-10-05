using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	[Serializable]
	internal class PlayerEditorConnectionEvents
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x5967240", Offset = "0x5965E40", VA = "0x185967240")]
		public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x5966FF0", Offset = "0x5965BF0", VA = "0x185966FF0")]
		public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			return null;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x5967640", Offset = "0x5966240", VA = "0x185967640")]
		public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x5967790", Offset = "0x5966390", VA = "0x185967790")]
		public PlayerEditorConnectionEvents()
		{
		}

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

		// Token: 0x0200023A RID: 570
		[Token(Token = "0x200023A")]
		[Serializable]
		public class MessageEvent : UnityEvent<MessageEventArgs>
		{
			// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x5960350", Offset = "0x595EF50", VA = "0x185960350")]
			public MessageEvent()
			{
			}
		}

		// Token: 0x0200023B RID: 571
		[Token(Token = "0x200023B")]
		[Serializable]
		public class ConnectionChangeEvent : UnityEvent<int>
		{
			// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x5959D70", Offset = "0x5958970", VA = "0x185959D70")]
			public ConnectionChangeEvent()
			{
			}
		}

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		[Serializable]
		public class MessageTypeSubscribers
		{
			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00006C90 File Offset: 0x00004E90
			// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A9")]
			public Guid MessageTypeId
			{
				[Token(Token = "0x6000D68")]
				[Address(RVA = "0x5960430", Offset = "0x595F030", VA = "0x185960430")]
				get
				{
					return default(Guid);
				}
				[Token(Token = "0x6000D69")]
				[Address(RVA = "0x5960470", Offset = "0x595F070", VA = "0x185960470")]
				set
				{
				}
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D6A")]
			[Address(RVA = "0x5960390", Offset = "0x595EF90", VA = "0x185960390")]
			public MessageTypeSubscribers()
			{
			}

			// Token: 0x04000618 RID: 1560
			[Token(Token = "0x4000618")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_messageTypeId;

			// Token: 0x04000619 RID: 1561
			[Token(Token = "0x4000619")]
			[FieldOffset(Offset = "0x18")]
			public int subscriberCount;

			// Token: 0x0400061A RID: 1562
			[Token(Token = "0x400061A")]
			[FieldOffset(Offset = "0x20")]
			public PlayerEditorConnectionEvents.MessageEvent messageCallback;
		}
	}
}
