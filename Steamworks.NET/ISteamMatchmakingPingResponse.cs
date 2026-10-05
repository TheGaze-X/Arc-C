using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class ISteamMatchmakingPingResponse
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x4EDF3B0", Offset = "0x4EDDFB0", VA = "0x184EDF3B0")]
		public ISteamMatchmakingPingResponse(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x4EDF290", Offset = "0x4EDDE90", VA = "0x184EDF290", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x4EDF380", Offset = "0x4EDDF80", VA = "0x184EDF380")]
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x3DCF750", Offset = "0x3DCE350", VA = "0x183DCF750")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00007E8C File Offset: 0x0000608C
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x4EDF710", Offset = "0x4EDE310", VA = "0x184EDF710")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return 0;
		}

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingPingResponse.VTable m_VTable;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000927 RID: 2343
		[Token(Token = "0x2000197")]
		public delegate void ServerResponded(gameserveritem_t server);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x0600092B RID: 2347
		[Token(Token = "0x2000198")]
		public delegate void ServerFailedToRespond();

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x0600092F RID: 2351
		[Token(Token = "0x2000199")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x06000933 RID: 2355
		[Token(Token = "0x200019A")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		// Token: 0x0200019B RID: 411
		[Token(Token = "0x200019B")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000936 RID: 2358 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VTable()
			{
			}

			// Token: 0x04000A6A RID: 2666
			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingPingResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x04000A6B RID: 2667
			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingPingResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;
		}
	}
}
