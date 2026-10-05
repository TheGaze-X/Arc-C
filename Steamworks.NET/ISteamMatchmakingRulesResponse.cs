using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public class ISteamMatchmakingRulesResponse
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x4EDFE30", Offset = "0x4EDEA30", VA = "0x184EDFE30")]
		public ISteamMatchmakingRulesResponse(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4EDFCE0", Offset = "0x4EDE8E0", VA = "0x184EDFCE0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x4EDFDD0", Offset = "0x4EDE9D0", VA = "0x184EDFDD0")]
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x3DCF750", Offset = "0x3DCE350", VA = "0x183DCF750")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x4EDF870", Offset = "0x4EDE470", VA = "0x184EDF870")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00007EBC File Offset: 0x000060BC
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x4EDF710", Offset = "0x4EDE310", VA = "0x184EDF710")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return 0;
		}

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingRulesResponse.VTable m_VTable;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete;

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x0600095D RID: 2397
		[Token(Token = "0x20001A5")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000961 RID: 2401
		[Token(Token = "0x20001A6")]
		public delegate void RulesFailedToRespond();

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000965 RID: 2405
		[Token(Token = "0x20001A7")]
		public delegate void RulesRefreshComplete();

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000969 RID: 2409
		[Token(Token = "0x20001A8")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x0600096D RID: 2413
		[Token(Token = "0x20001A9")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x06000971 RID: 2417
		[Token(Token = "0x20001AA")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		// Token: 0x020001AB RID: 427
		[Token(Token = "0x20001AB")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000974 RID: 2420 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VTable()
			{
			}

			// Token: 0x04000A7B RID: 2683
			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesResponded m_VTRulesResponded;

			// Token: 0x04000A7C RID: 2684
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			// Token: 0x04000A7D RID: 2685
			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}
	}
}
