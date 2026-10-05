using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;

namespace YoStar.SDK.Help
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	public class SteamHelper
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x5CAA190", Offset = "0x5CA8D90", VA = "0x185CAA190")]
		public static SteamHelper Instance()
		{
			return null;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x5CAA180", Offset = "0x5CA8D80", VA = "0x185CAA180")]
		public bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x5CAA090", Offset = "0x5CA8C90", VA = "0x185CAA090")]
		public void AuthTicket(Action<Dictionary<string, object>> callBack)
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x5CAA440", Offset = "0x5CA9040", VA = "0x185CAA440")]
		public bool IsOverlayEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x5CAA7D0", Offset = "0x5CA93D0", VA = "0x185CAA7D0")]
		private void OnMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t pCallback)
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x5CAAD50", Offset = "0x5CA9950", VA = "0x185CAAD50")]
		public bool TryGetGameLanguageAndSteamId(out string languageCode, out string steamId, Action<uint, ulong, uint> purchaseCallback)
		{
			return default(bool);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x5CAAB70", Offset = "0x5CA9770", VA = "0x185CAAB70")]
		private void RequestWebAPIAuthTicket(CSteamID steamID)
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x5CAA510", Offset = "0x5CA9110", VA = "0x185CAA510")]
		private void OnGetTicketForWebApiResponse(GetTicketForWebApiResponse_t callback)
		{
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x5CAA450", Offset = "0x5CA9050", VA = "0x185CAA450")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x5CAB720", Offset = "0x5CAA320", VA = "0x185CAB720")]
		public SteamHelper()
		{
		}

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x10")]
		private Action<Dictionary<string, object>> _callBack;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, object> _failedDic;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x0")]
		private static SteamHelper _instance;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x8")]
		private static object lockObj;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x20")]
		private Callback<MicroTxnAuthorizationResponse_t> m_MicroTxnAuthorizationResponse;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0x28")]
		private Action<uint, ulong, uint> _purchaseCallback;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, string> languages;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x30")]
		private Callback<GetTicketForWebApiResponse_t> m_GetTicketForWebApiResponse;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x38")]
		private HAuthTicket m_AuthTicketForWebApiHandle;
	}
}
