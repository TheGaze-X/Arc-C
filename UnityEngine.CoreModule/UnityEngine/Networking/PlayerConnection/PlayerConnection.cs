using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	[Serializable]
	public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A7")]
		public static PlayerConnection instance
		{
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x5966DD0", Offset = "0x59659D0", VA = "0x185966DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x170002A8")]
		public bool isConnected
		{
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x5966F90", Offset = "0x5965B90", VA = "0x185966F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x5965CA0", Offset = "0x59648A0", VA = "0x185965CA0")]
		private static PlayerConnection CreateInstance()
		{
			return null;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x5966030", Offset = "0x5964C30", VA = "0x185966030")]
		public void OnEnable()
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x5965E60", Offset = "0x5964A60", VA = "0x185965E60")]
		private IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			return null;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x5966250", Offset = "0x5964E50", VA = "0x185966250", Slot = "4")]
		public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x5966940", Offset = "0x5965540", VA = "0x185966940", Slot = "8")]
		public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x5966090", Offset = "0x5964C90", VA = "0x185966090", Slot = "5")]
		public void RegisterConnection(UnityAction<int> callback)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x59661F0", Offset = "0x5964DF0", VA = "0x1859661F0", Slot = "6")]
		public void RegisterDisconnection(UnityAction<int> callback)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x5966880", Offset = "0x5965480", VA = "0x185966880", Slot = "9")]
		public void UnregisterConnection(UnityAction<int> callback)
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x59668E0", Offset = "0x59654E0", VA = "0x1859668E0", Slot = "10")]
		public void UnregisterDisconnection(UnityAction<int> callback)
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x5966480", Offset = "0x5965080", VA = "0x185966480", Slot = "7")]
		public void Send(Guid messageId, byte[] data)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x5966680", Offset = "0x5965280", VA = "0x185966680", Slot = "11")]
		public bool TrySend(Guid messageId, byte[] data)
		{
			return default(bool);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x59658E0", Offset = "0x59644E0", VA = "0x1859658E0")]
		public bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			return default(bool);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x5965D70", Offset = "0x5964970", VA = "0x185965D70", Slot = "12")]
		public void DisconnectAll()
		{
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x5965EE0", Offset = "0x5964AE0", VA = "0x185965EE0")]
		[RequiredByNativeCode]
		private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x5965BD0", Offset = "0x59647D0", VA = "0x185965BD0")]
		[RequiredByNativeCode]
		private static void ConnectedCallbackInternal(int playerId)
		{
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x5965DD0", Offset = "0x59649D0", VA = "0x185965DD0")]
		[RequiredByNativeCode]
		private static void DisconnectedCallback(int playerId)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x5966BA0", Offset = "0x59657A0", VA = "0x185966BA0")]
		public PlayerConnection()
		{
		}

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x0")]
		internal static IPlayerEditorConnectionNative connectionNative;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<int> m_connectedPlayers;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsInitilized;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x8")]
		private static PlayerConnection s_Instance;
	}
}
