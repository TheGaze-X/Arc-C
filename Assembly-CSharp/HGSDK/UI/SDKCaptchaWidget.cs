using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class SDKCaptchaWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public InputField input
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x2535FD0", Offset = "0x2534BD0", VA = "0x182535FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public string captcha
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x2535F60", Offset = "0x2534B60", VA = "0x182535F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public SDKInputWarning warning
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x25360B0", Offset = "0x2534CB0", VA = "0x1825360B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00003E70 File Offset: 0x00002070
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012B")]
		public SDKCaptchaWidget.Options options
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x2536030", Offset = "0x2534C30", VA = "0x182536030")]
			[CompilerGenerated]
			get
			{
				return default(SDKCaptchaWidget.Options);
			}
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x2536110", Offset = "0x2534D10", VA = "0x182536110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2535330", Offset = "0x2533F30", VA = "0x182535330")]
		public void RegisterOnFetchPhoneNumber(Func<string> onFetchPhoneNumber)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2534EE0", Offset = "0x2533AE0", VA = "0x182534EE0")]
		public void EventOnSendCaptchaClicked()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x25353B0", Offset = "0x2533FB0", VA = "0x1825353B0")]
		public void SetNextAllowCaptchaTs(long timeStamp)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2535D00", Offset = "0x2534900", VA = "0x182535D00")]
		private void _OnUpdate()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2535430", Offset = "0x2534030", VA = "0x182535430")]
		private void Start()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x25355C0", Offset = "0x25341C0", VA = "0x1825355C0")]
		private void Update()
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x25358A0", Offset = "0x25344A0", VA = "0x1825358A0")]
		private void _OnSendCaptchaSucV1(UserSendSmsCodeResponse response)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2535AE0", Offset = "0x25346E0", VA = "0x182535AE0")]
		private void _OnSendCaptchaSucV2(APIV2RespWrapper<SendPhoneCodeResponse> response)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2535620", Offset = "0x2534220", VA = "0x182535620")]
		private void _OnSendCaptchaFailV2(APIV2FailResponse response)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2535B50", Offset = "0x2534750", VA = "0x182535B50")]
		private void _OnSendCaptchaSuc()
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2535840", Offset = "0x2534440", VA = "0x182535840")]
		private void _OnSendCaptchaFail()
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2535EF0", Offset = "0x2534AF0", VA = "0x182535EF0")]
		public SDKCaptchaWidget()
		{
		}

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _captchaInput;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private SDKInputWarning _captchaInputWarning;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _sendCaptchaBtn;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _sendCaptchaBtnText;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _sendCaptchaCooldown;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Nullable")]
		private SDKInputWarning _warningHint;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x48")]
		private Func<string> m_onFetchPhoneNumber;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x50")]
		private long m_nextAllowCaptchaTs;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x58")]
		private bool m_canSendCaptcha;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_captcha;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_warning;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterOnFetchPhoneNumber;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSendCaptchaClicked;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetNextAllowCaptchaTs;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUpdate;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSendCaptchaSucV1;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSendCaptchaSucV2;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSendCaptchaFailV2;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSendCaptchaSuc;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSendCaptchaFail;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		public struct Options
		{
			// Token: 0x04000A87 RID: 2695
			[Token(Token = "0x4000A87")]
			[FieldOffset(Offset = "0x0")]
			public Action<long> onSuc;

			// Token: 0x04000A88 RID: 2696
			[Token(Token = "0x4000A88")]
			[FieldOffset(Offset = "0x8")]
			public Action onAccountInvalid;

			// Token: 0x04000A89 RID: 2697
			[Token(Token = "0x4000A89")]
			[FieldOffset(Offset = "0x10")]
			public HGSDK.SendSmsCodeType sendSmsCodeType;

			// Token: 0x04000A8A RID: 2698
			[Token(Token = "0x4000A8A")]
			[FieldOffset(Offset = "0x14")]
			public HGSDK.SendPhoneCodeTypeV2 phoneCodeTypeV2;
		}
	}
}
