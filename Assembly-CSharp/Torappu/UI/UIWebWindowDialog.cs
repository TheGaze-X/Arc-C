using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038B6 RID: 14518
	[Token(Token = "0x20038B6")]
	public sealed class UIWebWindowDialog : UICustomDialog<UIWebWindowDialog.Input>, IHotfixable
	{
		// Token: 0x06016F64 RID: 94052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F64")]
		[Address(RVA = "0xF69F40", Offset = "0xF68B40", VA = "0x180F69F40", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06016F65 RID: 94053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F65")]
		[Address(RVA = "0xF69FA0", Offset = "0xF68BA0", VA = "0x180F69FA0", Slot = "7")]
		protected override void OnRender(UIWebWindowDialog.Input input)
		{
		}

		// Token: 0x06016F66 RID: 94054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F66")]
		[Address(RVA = "0xF69EC0", Offset = "0xF68AC0", VA = "0x180F69EC0", Slot = "9")]
		protected override void BeforeDestroy()
		{
		}

		// Token: 0x06016F67 RID: 94055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F67")]
		[Address(RVA = "0xF6A900", Offset = "0xF69500", VA = "0x180F6A900")]
		private void _CloseWebWindowInLifecycle()
		{
		}

		// Token: 0x06016F68 RID: 94056 RVA: 0x00094248 File Offset: 0x00092448
		[Token(Token = "0x6016F68")]
		[Address(RVA = "0xF6A7B0", Offset = "0xF693B0", VA = "0x180F6A7B0")]
		private bool _CheckIfDestroyed()
		{
			return default(bool);
		}

		// Token: 0x06016F69 RID: 94057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F69")]
		[Address(RVA = "0xF6A880", Offset = "0xF69480", VA = "0x180F6A880")]
		private void _CloseDialog()
		{
		}

		// Token: 0x06016F6A RID: 94058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F6A")]
		[Address(RVA = "0xF6AA40", Offset = "0xF69640", VA = "0x180F6AA40")]
		private AudioChannelEffect _GenerateMuteAudioChannelEffect()
		{
			return null;
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F6B")]
		[Address(RVA = "0xF6ACB0", Offset = "0xF698B0", VA = "0x180F6ACB0")]
		private void _OnWebOpenFailed()
		{
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F6C")]
		[Address(RVA = "0xF6ABC0", Offset = "0xF697C0", VA = "0x180F6ABC0")]
		private void _OnWebClosed()
		{
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F6D")]
		[Address(RVA = "0xF6AD20", Offset = "0xF69920", VA = "0x180F6AD20")]
		private void _OnWebOpenRet(UIWebWindow.OpenRet ret)
		{
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F6E")]
		[Address(RVA = "0xF6AC30", Offset = "0xF69830", VA = "0x180F6AC30")]
		private void _OnWebMessage(UIWebScheme msg)
		{
		}

		// Token: 0x06016F6F RID: 94063 RVA: 0x00094260 File Offset: 0x00092460
		[Token(Token = "0x6016F6F")]
		[Address(RVA = "0xF6A6E0", Offset = "0xF692E0", VA = "0x180F6A6E0")]
		public static bool OpenWebWindowDialog(UIWebWindowDialog.Input input)
		{
			return default(bool);
		}

		// Token: 0x06016F70 RID: 94064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F70")]
		[Address(RVA = "0xF6ADD0", Offset = "0xF699D0", VA = "0x180F6ADD0")]
		public UIWebWindowDialog()
		{
		}

		// Token: 0x0401BB86 RID: 113542
		[Token(Token = "0x401BB86")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0401BB87 RID: 113543
		[Token(Token = "0x401BB87")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBlurBkg;

		// Token: 0x0401BB88 RID: 113544
		[Token(Token = "0x401BB88")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBlackBkg;

		// Token: 0x0401BB89 RID: 113545
		[Token(Token = "0x401BB89")]
		[FieldOffset(Offset = "0x58")]
		private UIWebWindow m_window;

		// Token: 0x0401BB8A RID: 113546
		[Token(Token = "0x401BB8A")]
		[FieldOffset(Offset = "0x60")]
		private AudioChannelEffect m_channelEffect;

		// Token: 0x0401BB8B RID: 113547
		[Token(Token = "0x401BB8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401BB8C RID: 113548
		[Token(Token = "0x401BB8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401BB8D RID: 113549
		[Token(Token = "0x401BB8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BeforeDestroy;

		// Token: 0x0401BB8E RID: 113550
		[Token(Token = "0x401BB8E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CloseWebWindowInLifecycle;

		// Token: 0x0401BB8F RID: 113551
		[Token(Token = "0x401BB8F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfDestroyed;

		// Token: 0x0401BB90 RID: 113552
		[Token(Token = "0x401BB90")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseDialog;

		// Token: 0x0401BB91 RID: 113553
		[Token(Token = "0x401BB91")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateMuteAudioChannelEffect;

		// Token: 0x0401BB92 RID: 113554
		[Token(Token = "0x401BB92")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnWebOpenFailed;

		// Token: 0x0401BB93 RID: 113555
		[Token(Token = "0x401BB93")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnWebClosed;

		// Token: 0x0401BB94 RID: 113556
		[Token(Token = "0x401BB94")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnWebOpenRet;

		// Token: 0x0401BB95 RID: 113557
		[Token(Token = "0x401BB95")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnWebMessage;

		// Token: 0x0401BB96 RID: 113558
		[Token(Token = "0x401BB96")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OpenWebWindowDialog;

		// Token: 0x0401BB97 RID: 113559
		[Token(Token = "0x401BB97")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038B7 RID: 14519
		[Token(Token = "0x20038B7")]
		public enum BkgType
		{
			// Token: 0x0401BB99 RID: 113561
			[Token(Token = "0x401BB99")]
			BLACK,
			// Token: 0x0401BB9A RID: 113562
			[Token(Token = "0x401BB9A")]
			BLUR
		}

		// Token: 0x020038B8 RID: 14520
		[Token(Token = "0x20038B8")]
		public class Input
		{
			// Token: 0x06016F71 RID: 94065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F71")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401BB9B RID: 113563
			[Token(Token = "0x401BB9B")]
			[FieldOffset(Offset = "0x10")]
			public string busType;

			// Token: 0x0401BB9C RID: 113564
			[Token(Token = "0x401BB9C")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> webQuery;

			// Token: 0x0401BB9D RID: 113565
			[Token(Token = "0x401BB9D")]
			[FieldOffset(Offset = "0x20")]
			public string urlFragment;

			// Token: 0x0401BB9E RID: 113566
			[Token(Token = "0x401BB9E")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> urlParam;

			// Token: 0x0401BB9F RID: 113567
			[Token(Token = "0x401BB9F")]
			[FieldOffset(Offset = "0x30")]
			public bool setAudioMute;

			// Token: 0x0401BBA0 RID: 113568
			[Token(Token = "0x401BBA0")]
			[FieldOffset(Offset = "0x34")]
			public UIWebWindowDialog.BkgType bkgType;
		}
	}
}
