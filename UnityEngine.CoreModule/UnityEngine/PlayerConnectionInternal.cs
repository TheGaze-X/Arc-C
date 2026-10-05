using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x594FB20", Offset = "0x594E720", VA = "0x18594FB20", Slot = "6")]
		private void SendMessage(Guid messageId, byte[] data, int playerId)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x594FC40", Offset = "0x594E840", VA = "0x18594FC40", Slot = "7")]
		private bool TrySendMessage(Guid messageId, byte[] data, int playerId)
		{
			return default(bool);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x594F980", Offset = "0x594E580", VA = "0x18594F980", Slot = "8")]
		private void Poll()
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x594FAB0", Offset = "0x594E6B0", VA = "0x18594FAB0", Slot = "9")]
		private void RegisterInternal(Guid messageId)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x594FD60", Offset = "0x594E960", VA = "0x18594FD60", Slot = "10")]
		private void UnregisterInternal(Guid messageId)
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x594F920", Offset = "0x594E520", VA = "0x18594F920", Slot = "4")]
		private void Initialize()
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x594F950", Offset = "0x594E550", VA = "0x18594F950", Slot = "11")]
		private bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x594F8F0", Offset = "0x594E4F0", VA = "0x18594F8F0", Slot = "5")]
		private void DisconnectAll()
		{
		}

		// Token: 0x0600089B RID: 2203
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x594F950", Offset = "0x594E550", VA = "0x18594F950")]
		[FreeFunction("PlayerConnection_Bindings::IsConnected")]
		[MethodImpl(4096)]
		private static extern bool IsConnected();

		// Token: 0x0600089C RID: 2204
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x594F920", Offset = "0x594E520", VA = "0x18594F920")]
		[FreeFunction("PlayerConnection_Bindings::Initialize")]
		[MethodImpl(4096)]
		private static extern void Initialize();

		// Token: 0x0600089D RID: 2205
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x594F9B0", Offset = "0x594E5B0", VA = "0x18594F9B0")]
		[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
		[MethodImpl(4096)]
		private static extern void RegisterInternal(string messageId);

		// Token: 0x0600089E RID: 2206
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x594FDD0", Offset = "0x594E9D0", VA = "0x18594FDD0")]
		[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
		[MethodImpl(4096)]
		private static extern void UnregisterInternal(string messageId);

		// Token: 0x0600089F RID: 2207
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x594F9F0", Offset = "0x594E5F0", VA = "0x18594F9F0")]
		[FreeFunction("PlayerConnection_Bindings::SendMessage")]
		[MethodImpl(4096)]
		private static extern void SendMessage(string messageId, [Unmarshalled] byte[] data, int playerId);

		// Token: 0x060008A0 RID: 2208
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x594FA50", Offset = "0x594E650", VA = "0x18594FA50")]
		[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
		[MethodImpl(4096)]
		private static extern bool TrySendMessage(string messageId, [Unmarshalled] byte[] data, int playerId);

		// Token: 0x060008A1 RID: 2209
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x594F980", Offset = "0x594E580", VA = "0x18594F980")]
		[FreeFunction("PlayerConnection_Bindings::PollInternal")]
		[MethodImpl(4096)]
		private static extern void PollInternal();

		// Token: 0x060008A2 RID: 2210
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x594F8F0", Offset = "0x594E4F0", VA = "0x18594F8F0")]
		[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
		[MethodImpl(4096)]
		private static extern void DisconnectAll();

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerConnectionInternal()
		{
		}
	}
}
