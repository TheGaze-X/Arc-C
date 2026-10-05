using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HGSDK.UI
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	public class SDKSettingCaptchaWidget : MonoBehaviour
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		public InputField input
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		public string captcha
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x25378A0", Offset = "0x25364A0", VA = "0x1825378A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public SDKInputWarning warning
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000134")]
		public SDKSettingCaptchaWidget.Options options
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x25378C0", Offset = "0x25364C0", VA = "0x1825378C0")]
			[CompilerGenerated]
			get
			{
				return default(SDKSettingCaptchaWidget.Options);
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x25378E0", Offset = "0x25364E0", VA = "0x1825378E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		public void RegisterOnFetchPhoneNumber(Func<string> onFetchPhoneNumber)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x25370E0", Offset = "0x2535CE0", VA = "0x1825370E0")]
		public void EventOnSendCaptchaClicked()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x25376A0", Offset = "0x25362A0", VA = "0x1825376A0")]
		private void _OnUpdate()
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x2537270", Offset = "0x2535E70", VA = "0x182537270")]
		private void Start()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x2537390", Offset = "0x2535F90", VA = "0x182537390")]
		private void Update()
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x25373B0", Offset = "0x2535FB0", VA = "0x1825373B0")]
		private void _OnSendCaptchaSuc(UserSendSmsCodeResponse response)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x25375E0", Offset = "0x25361E0", VA = "0x1825375E0")]
		private void _OnSendCaptchaSuc()
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x25373A0", Offset = "0x2535FA0", VA = "0x1825373A0")]
		private void _OnSendCaptchaFail()
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2537890", Offset = "0x2536490", VA = "0x182537890")]
		public SDKSettingCaptchaWidget()
		{
		}

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _captchaInput;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SDKInputWarning _captchaInputWarning;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _sendCaptchaBtn;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _sendCaptchaBtnText;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _sendCaptchaCooldown;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SDKInputWarning _warningHint;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x48")]
		private Func<string> m_onFetchPhoneNumber;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x50")]
		private long m_nextAllowCaptchaTs;

		// Token: 0x020001E2 RID: 482
		[Token(Token = "0x20001E2")]
		public struct Options
		{
			// Token: 0x04000AB0 RID: 2736
			[Token(Token = "0x4000AB0")]
			[FieldOffset(Offset = "0x0")]
			public Action onSuc;

			// Token: 0x04000AB1 RID: 2737
			[Token(Token = "0x4000AB1")]
			[FieldOffset(Offset = "0x8")]
			public Action onAccountInvalid;

			// Token: 0x04000AB2 RID: 2738
			[Token(Token = "0x4000AB2")]
			[FieldOffset(Offset = "0x10")]
			public HGSDK.SendSmsCodeType sendSmsCodeType;
		}
	}
}
