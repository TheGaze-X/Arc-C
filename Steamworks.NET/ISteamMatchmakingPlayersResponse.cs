using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public class ISteamMatchmakingPlayersResponse
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x4EDF8A0", Offset = "0x4EDE4A0", VA = "0x184EDF8A0")]
		public ISteamMatchmakingPlayersResponse(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x4EDF730", Offset = "0x4EDE330", VA = "0x184EDF730", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x4EDF820", Offset = "0x4EDE420", VA = "0x184EDF820")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x3DCF750", Offset = "0x3DCE350", VA = "0x183DCF750")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x4EDF870", Offset = "0x4EDE470", VA = "0x184EDF870")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00007EA4 File Offset: 0x000060A4
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x4EDF710", Offset = "0x4EDE310", VA = "0x184EDF710")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return 0;
		}

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingPlayersResponse.VTable m_VTable;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete;

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x0600093E RID: 2366
		[Token(Token = "0x200019D")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000942 RID: 2370
		[Token(Token = "0x200019E")]
		public delegate void PlayersFailedToRespond();

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000946 RID: 2374
		[Token(Token = "0x200019F")]
		public delegate void PlayersRefreshComplete();

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x0600094A RID: 2378
		[Token(Token = "0x20001A0")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600094E RID: 2382
		[Token(Token = "0x20001A1")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x06000952 RID: 2386
		[Token(Token = "0x20001A2")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		// Token: 0x020001A3 RID: 419
		[Token(Token = "0x20001A3")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000955 RID: 2389 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VTable()
			{
			}

			// Token: 0x04000A72 RID: 2674
			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalAddPlayerToList m_VTAddPlayerToList;

			// Token: 0x04000A73 RID: 2675
			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			// Token: 0x04000A74 RID: 2676
			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;
		}
	}
}
