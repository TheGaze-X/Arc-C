using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A79 RID: 23161
	[Token(Token = "0x2005A79")]
	public class ShopGetServiceCenter : PageSingleComponent, IHotfixable
	{
		// Token: 0x06021B23 RID: 138019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B23")]
		[Address(RVA = "0x1C24AC0", Offset = "0x1C236C0", VA = "0x181C24AC0")]
		public static void MarkHighAndClassicServiceDirty(string buyServiceCode)
		{
		}

		// Token: 0x06021B24 RID: 138020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B24")]
		[Address(RVA = "0x1C249B0", Offset = "0x1C235B0", VA = "0x181C249B0")]
		public static void MarkCashServicesDirty()
		{
		}

		// Token: 0x06021B25 RID: 138021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B25")]
		[Address(RVA = "0x1C24D20", Offset = "0x1C23920", VA = "0x181C24D20")]
		public static void SendUpdateServiceAfterBuying(string buyServiceCode)
		{
		}

		// Token: 0x06021B26 RID: 138022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B26")]
		[Address(RVA = "0x1C24CA0", Offset = "0x1C238A0", VA = "0x181C24CA0")]
		public static void SendUpdateServiceAfterBuying(ShopType shopType, QCShopDetailShopEnum qcShopType = QCShopDetailShopEnum.NONE)
		{
		}

		// Token: 0x06021B27 RID: 138023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B27")]
		[Address(RVA = "0x1C25500", Offset = "0x1C24100", VA = "0x181C25500")]
		private static void _MarkDirtyAndSendUpdateService(string listServiceCode)
		{
		}

		// Token: 0x06021B28 RID: 138024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B28")]
		[Address(RVA = "0x1C251C0", Offset = "0x1C23DC0", VA = "0x181C251C0")]
		public void TrySendService(string serviceCode)
		{
		}

		// Token: 0x06021B29 RID: 138025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B29")]
		[Address(RVA = "0x1C24BC0", Offset = "0x1C237C0", VA = "0x181C24BC0")]
		public void MarkServiceDirty(string serviceCode)
		{
		}

		// Token: 0x06021B2A RID: 138026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B2A")]
		public void BindToResponse<RespType>(string serviceCode, Action<RespType, bool> callback) where RespType : IShopGetResposne
		{
		}

		// Token: 0x06021B2B RID: 138027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B2B")]
		[Address(RVA = "0x1C245C0", Offset = "0x1C231C0", VA = "0x181C245C0")]
		public void BindToQCResponse(Action<IQCShopGetResponse> callback)
		{
		}

		// Token: 0x06021B2C RID: 138028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B2C")]
		[Address(RVA = "0x1C24640", Offset = "0x1C23240", VA = "0x181C24640")]
		public static string GetServiceCodeByShop(ShopType shopType, QCShopDetailShopEnum qcDetail)
		{
			return null;
		}

		// Token: 0x06021B2D RID: 138029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B2D")]
		private static void _InvokeRespCallback<RespType>(string serviceCode, Action<RespType, bool> callback, IShopGetResposne response, bool isResponseUpdated) where RespType : IShopGetResposne
		{
		}

		// Token: 0x06021B2E RID: 138030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B2E")]
		[Address(RVA = "0x1C25370", Offset = "0x1C23F70", VA = "0x181C25370")]
		private ShopGetServiceCenter.RespWrapper _EnsureRespWrapper(string serviceCode)
		{
			return null;
		}

		// Token: 0x06021B2F RID: 138031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B2F")]
		[Address(RVA = "0x1C259F0", Offset = "0x1C245F0", VA = "0x181C259F0")]
		private void _RouteService(string serviceCode)
		{
		}

		// Token: 0x06021B30 RID: 138032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B30")]
		[Address(RVA = "0x1C27030", Offset = "0x1C25C30", VA = "0x181C27030")]
		private void _TryFetchMultiCurrencyDataIfNecessary(Action nextStep)
		{
		}

		// Token: 0x06021B31 RID: 138033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B31")]
		private void _SendService<RequestType, ResponseType>(string serviceCode, RequestType request) where ResponseType : class, IShopGetResposne
		{
		}

		// Token: 0x06021B32 RID: 138034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B32")]
		[Address(RVA = "0x1C25840", Offset = "0x1C24440", VA = "0x181C25840")]
		private void _OnServiceResponse(string serviceCode, IShopGetResposne response)
		{
		}

		// Token: 0x06021B33 RID: 138035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B33")]
		[Address(RVA = "0x1C26C20", Offset = "0x1C25820", VA = "0x181C26C20")]
		private void _SendShopSkinRequest(string serviceCode)
		{
		}

		// Token: 0x06021B34 RID: 138036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B34")]
		[Address(RVA = "0x1C26400", Offset = "0x1C25000", VA = "0x181C26400")]
		private void _SendShopCashRequest(string serviceCode)
		{
		}

		// Token: 0x06021B35 RID: 138037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B35")]
		[Address(RVA = "0x1C269B0", Offset = "0x1C255B0", VA = "0x181C269B0")]
		private void _SendShopQCHighRequest(string serviceCode)
		{
		}

		// Token: 0x06021B36 RID: 138038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B36")]
		[Address(RVA = "0x1C26A80", Offset = "0x1C25680", VA = "0x181C26A80")]
		private void _SendShopQCLowRequest(string serviceCode)
		{
		}

		// Token: 0x06021B37 RID: 138039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B37")]
		[Address(RVA = "0x1C26810", Offset = "0x1C25410", VA = "0x181C26810")]
		private void _SendShopQCClassicRequest(string serviceCode)
		{
		}

		// Token: 0x06021B38 RID: 138040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B38")]
		[Address(RVA = "0x1C268E0", Offset = "0x1C254E0", VA = "0x181C268E0")]
		private void _SendShopQCExtraRequest(string serviceCode)
		{
		}

		// Token: 0x06021B39 RID: 138041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B39")]
		[Address(RVA = "0x1C264D0", Offset = "0x1C250D0", VA = "0x181C264D0")]
		private void _SendShopEPGSRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3A RID: 138042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3A")]
		[Address(RVA = "0x1C26B50", Offset = "0x1C25750", VA = "0x181C26B50")]
		private void _SendShopREPRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3B RID: 138043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3B")]
		[Address(RVA = "0x1C26740", Offset = "0x1C25340", VA = "0x181C26740")]
		private void _SendShopLMGTSRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3C RID: 138044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3C")]
		[Address(RVA = "0x1C26670", Offset = "0x1C25270", VA = "0x181C26670")]
		private void _SendShopGPRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3D RID: 138045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3D")]
		[Address(RVA = "0x1C26D40", Offset = "0x1C25940", VA = "0x181C26D40")]
		private void _SendShopSocialRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3E RID: 138046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3E")]
		[Address(RVA = "0x1C26E10", Offset = "0x1C25A10", VA = "0x181C26E10")]
		private void _SendShopStateRequest(string serviceCode)
		{
		}

		// Token: 0x06021B3F RID: 138047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B3F")]
		[Address(RVA = "0x1C265A0", Offset = "0x1C251A0", VA = "0x181C265A0")]
		private void _SendShopFurnitureStateRequest(string serviceCode)
		{
		}

		// Token: 0x06021B40 RID: 138048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B40")]
		[Address(RVA = "0x1C27280", Offset = "0x1C25E80", VA = "0x181C27280")]
		public ShopGetServiceCenter()
		{
		}

		// Token: 0x0402E132 RID: 188722
		[Token(Token = "0x402E132")]
		private const long RESP_TIMEOUT_SECS = 300L;

		// Token: 0x0402E133 RID: 188723
		[Token(Token = "0x402E133")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, ShopGetServiceCenter.RespWrapper> m_responses;

		// Token: 0x0402E134 RID: 188724
		[Token(Token = "0x402E134")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, ShopGetServiceCenter.RespListener> m_listeners;

		// Token: 0x0402E135 RID: 188725
		[Token(Token = "0x402E135")]
		[FieldOffset(Offset = "0x30")]
		private Action<IQCShopGetResponse> m_qcShopListener;

		// Token: 0x0402E136 RID: 188726
		[Token(Token = "0x402E136")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isSendingService;

		// Token: 0x0402E137 RID: 188727
		[Token(Token = "0x402E137")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_MarkHighAndClassicServiceDirty;

		// Token: 0x0402E138 RID: 188728
		[Token(Token = "0x402E138")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MarkCashServicesDirty;

		// Token: 0x0402E139 RID: 188729
		[Token(Token = "0x402E139")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendUpdateServiceAfterBuying;

		// Token: 0x0402E13A RID: 188730
		[Token(Token = "0x402E13A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_SendUpdateServiceAfterBuying;

		// Token: 0x0402E13B RID: 188731
		[Token(Token = "0x402E13B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MarkDirtyAndSendUpdateService;

		// Token: 0x0402E13C RID: 188732
		[Token(Token = "0x402E13C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TrySendService;

		// Token: 0x0402E13D RID: 188733
		[Token(Token = "0x402E13D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MarkServiceDirty;

		// Token: 0x0402E13E RID: 188734
		[Token(Token = "0x402E13E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BindToResponse;

		// Token: 0x0402E13F RID: 188735
		[Token(Token = "0x402E13F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BindToQCResponse;

		// Token: 0x0402E140 RID: 188736
		[Token(Token = "0x402E140")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetServiceCodeByShop;

		// Token: 0x0402E141 RID: 188737
		[Token(Token = "0x402E141")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InvokeRespCallback;

		// Token: 0x0402E142 RID: 188738
		[Token(Token = "0x402E142")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnsureRespWrapper;

		// Token: 0x0402E143 RID: 188739
		[Token(Token = "0x402E143")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RouteService;

		// Token: 0x0402E144 RID: 188740
		[Token(Token = "0x402E144")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryFetchMultiCurrencyDataIfNecessary;

		// Token: 0x0402E145 RID: 188741
		[Token(Token = "0x402E145")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SendService;

		// Token: 0x0402E146 RID: 188742
		[Token(Token = "0x402E146")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnServiceResponse;

		// Token: 0x0402E147 RID: 188743
		[Token(Token = "0x402E147")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SendShopSkinRequest;

		// Token: 0x0402E148 RID: 188744
		[Token(Token = "0x402E148")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SendShopCashRequest;

		// Token: 0x0402E149 RID: 188745
		[Token(Token = "0x402E149")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SendShopQCHighRequest;

		// Token: 0x0402E14A RID: 188746
		[Token(Token = "0x402E14A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SendShopQCLowRequest;

		// Token: 0x0402E14B RID: 188747
		[Token(Token = "0x402E14B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SendShopQCClassicRequest;

		// Token: 0x0402E14C RID: 188748
		[Token(Token = "0x402E14C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SendShopQCExtraRequest;

		// Token: 0x0402E14D RID: 188749
		[Token(Token = "0x402E14D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SendShopEPGSRequest;

		// Token: 0x0402E14E RID: 188750
		[Token(Token = "0x402E14E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SendShopREPRequest;

		// Token: 0x0402E14F RID: 188751
		[Token(Token = "0x402E14F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SendShopLMGTSRequest;

		// Token: 0x0402E150 RID: 188752
		[Token(Token = "0x402E150")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SendShopGPRequest;

		// Token: 0x0402E151 RID: 188753
		[Token(Token = "0x402E151")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SendShopSocialRequest;

		// Token: 0x0402E152 RID: 188754
		[Token(Token = "0x402E152")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SendShopStateRequest;

		// Token: 0x0402E153 RID: 188755
		[Token(Token = "0x402E153")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SendShopFurnitureStateRequest;

		// Token: 0x0402E154 RID: 188756
		[Token(Token = "0x402E154")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A7A RID: 23162
		[Token(Token = "0x2005A7A")]
		private class RespWrapper
		{
			// Token: 0x06021B41 RID: 138049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B41")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RespWrapper()
			{
			}

			// Token: 0x0402E155 RID: 188757
			[Token(Token = "0x402E155")]
			[FieldOffset(Offset = "0x10")]
			public string serviceCode;

			// Token: 0x0402E156 RID: 188758
			[Token(Token = "0x402E156")]
			[FieldOffset(Offset = "0x18")]
			public long ts;

			// Token: 0x0402E157 RID: 188759
			[Token(Token = "0x402E157")]
			[FieldOffset(Offset = "0x20")]
			public IShopGetResposne response;
		}

		// Token: 0x02005A7B RID: 23163
		[Token(Token = "0x2005A7B")]
		private abstract class RespListener
		{
			// Token: 0x06021B42 RID: 138050
			[Token(Token = "0x6021B42")]
			public abstract void NotifyUpdate(ShopGetServiceCenter.RespWrapper resp);

			// Token: 0x06021B43 RID: 138051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B43")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected RespListener()
			{
			}

			// Token: 0x0402E158 RID: 188760
			[Token(Token = "0x402E158")]
			[FieldOffset(Offset = "0x10")]
			public string serviceCode;

			// Token: 0x0402E159 RID: 188761
			[Token(Token = "0x402E159")]
			[FieldOffset(Offset = "0x18")]
			public long lastTs;
		}

		// Token: 0x02005A7C RID: 23164
		[Token(Token = "0x2005A7C")]
		private class RespListener<RespType> : ShopGetServiceCenter.RespListener where RespType : IShopGetResposne
		{
			// Token: 0x06021B44 RID: 138052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B44")]
			public override void NotifyUpdate(ShopGetServiceCenter.RespWrapper resp)
			{
			}

			// Token: 0x06021B45 RID: 138053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B45")]
			public RespListener()
			{
			}

			// Token: 0x0402E15A RID: 188762
			[Token(Token = "0x402E15A")]
			[FieldOffset(Offset = "0x0")]
			public Action<RespType, bool> callback;
		}
	}
}
