using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	public static class CallbackDispatcher
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4EDB1E0", Offset = "0x4ED9DE0", VA = "0x184EDB1E0")]
		public static void ExceptionHandler(Exception e)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00007D84 File Offset: 0x00005F84
		[Token(Token = "0x17000021")]
		public static bool IsInitialized
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x4EDD480", Offset = "0x4EDC080", VA = "0x184EDD480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x4EDB260", Offset = "0x4ED9E60", VA = "0x184EDB260")]
		internal static void Initialize()
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4EDC4F0", Offset = "0x4EDB0F0", VA = "0x184EDC4F0")]
		internal static void Shutdown()
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4EDB6F0", Offset = "0x4EDA2F0", VA = "0x184EDB6F0")]
		internal static void Register(Callback cb)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4EDB4A0", Offset = "0x4EDA0A0", VA = "0x184EDB4A0")]
		internal static void Register(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4EDD0A0", Offset = "0x4EDBCA0", VA = "0x184EDD0A0")]
		internal static void Unregister(Callback cb)
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4EDCE80", Offset = "0x4EDBA80", VA = "0x184EDCE80")]
		internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x4EDC670", Offset = "0x4EDB270", VA = "0x184EDC670")]
		private static void UnregisterAll()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x4EDB950", Offset = "0x4EDA550", VA = "0x184EDB950")]
		internal static void RunFrame(bool isGameServer)
		{
		}

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, List<Callback>> m_registeredCallbacks;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<ulong, List<CallResult>> m_registeredCallResults;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x18")]
		private static object m_sync;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x20")]
		private static IntPtr m_pCallbackMsg;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x28")]
		private static int m_initCount;
	}
}
