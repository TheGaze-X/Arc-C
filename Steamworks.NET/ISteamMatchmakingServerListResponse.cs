using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class ISteamMatchmakingServerListResponse
	{
		// Token: 0x06000902 RID: 2306 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x4EE04B0", Offset = "0x4EDF0B0", VA = "0x184EE04B0")]
		public ISteamMatchmakingServerListResponse(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x4EE0270", Offset = "0x4EDEE70", VA = "0x184EE0270", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x4EE0440", Offset = "0x4EDF040", VA = "0x184EE0440")]
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x4EE03D0", Offset = "0x4EDEFD0", VA = "0x184EE03D0")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x4EE0360", Offset = "0x4EDEF60", VA = "0x184EE0360")]
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00007E74 File Offset: 0x00006074
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x4EDF710", Offset = "0x4EDE310", VA = "0x184EDF710")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return 0;
		}

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingServerListResponse.VTable m_VTable;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete;

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06000909 RID: 2313
		[Token(Token = "0x200018F")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x0600090D RID: 2317
		[Token(Token = "0x2000190")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x06000911 RID: 2321
		[Token(Token = "0x2000191")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x06000915 RID: 2325
		[Token(Token = "0x2000192")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x06000919 RID: 2329
		[Token(Token = "0x2000193")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x0600091D RID: 2333
		[Token(Token = "0x2000194")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x02000195 RID: 405
		[Token(Token = "0x2000195")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VTable()
			{
			}

			// Token: 0x04000A62 RID: 2658
			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x04000A63 RID: 2659
			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;

			// Token: 0x04000A64 RID: 2660
			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalRefreshComplete m_VTRefreshComplete;
		}
	}
}
