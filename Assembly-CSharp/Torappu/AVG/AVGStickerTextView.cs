using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F70 RID: 8048
	[Token(Token = "0x2001F70")]
	[RequireComponent(typeof(CanvasGroup))]
	public class AVGStickerTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x00048C60 File Offset: 0x00046E60
		[Token(Token = "0x170017A8")]
		public bool isTyping
		{
			[Token(Token = "0x600C7F4")]
			[Address(RVA = "0x3492490", Offset = "0x3491090", VA = "0x183492490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x0600C7F5 RID: 51189 RVA: 0x00048C78 File Offset: 0x00046E78
		[Token(Token = "0x170017A9")]
		public bool isHidden
		{
			[Token(Token = "0x600C7F5")]
			[Address(RVA = "0x3492430", Offset = "0x3491030", VA = "0x183492430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F6")]
		[Address(RVA = "0x3491D80", Offset = "0x3490980", VA = "0x183491D80")]
		public void TryFinishType()
		{
		}

		// Token: 0x0600C7F7 RID: 51191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F7")]
		[Address(RVA = "0x34917C0", Offset = "0x34903C0", VA = "0x1834917C0")]
		public void RenderSticker(StickerParam param, Action<int> eventOnTypeEnd)
		{
		}

		// Token: 0x0600C7F8 RID: 51192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C7F8")]
		[Address(RVA = "0x3491E80", Offset = "0x3490A80", VA = "0x183491E80")]
		private FadeSwitchTween _EnsureSwitch()
		{
			return null;
		}

		// Token: 0x0600C7F9 RID: 51193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F9")]
		[Address(RVA = "0x3492000", Offset = "0x3490C00", VA = "0x183492000")]
		private void _OnTypeWriterEnd()
		{
		}

		// Token: 0x0600C7FA RID: 51194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FA")]
		[Address(RVA = "0x34921C0", Offset = "0x3490DC0", VA = "0x1834921C0")]
		private void _ResetView()
		{
		}

		// Token: 0x0600C7FB RID: 51195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FB")]
		[Address(RVA = "0x3491CD0", Offset = "0x34908D0", VA = "0x183491CD0")]
		public void SetTypeWriterDelay(object arg)
		{
		}

		// Token: 0x0600C7FC RID: 51196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FC")]
		[Address(RVA = "0x3491620", Offset = "0x3490220", VA = "0x183491620")]
		public void HideSticker(float duration = 0f)
		{
		}

		// Token: 0x0600C7FD RID: 51197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FD")]
		[Address(RVA = "0x3491540", Offset = "0x3490140", VA = "0x183491540")]
		public void AppendText(string text)
		{
		}

		// Token: 0x0600C7FE RID: 51198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FE")]
		[Address(RVA = "0x3492290", Offset = "0x3490E90", VA = "0x183492290")]
		private void _SetHiddenInternal(bool isHide)
		{
		}

		// Token: 0x0600C7FF RID: 51199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7FF")]
		[Address(RVA = "0x34923A0", Offset = "0x3490FA0", VA = "0x1834923A0")]
		public AVGStickerTextView()
		{
		}

		// Token: 0x0400CE3D RID: 52797
		[Token(Token = "0x400CE3D")]
		private const float SCREEN_WIDTH = 1280f;

		// Token: 0x0400CE3E RID: 52798
		[Token(Token = "0x400CE3E")]
		private const float SCREEN_HEIGHT = 720f;

		// Token: 0x0400CE3F RID: 52799
		[Token(Token = "0x400CE3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGTypeWriterText _typeWriter;

		// Token: 0x0400CE40 RID: 52800
		[Token(Token = "0x400CE40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x0400CE41 RID: 52801
		[Token(Token = "0x400CE41")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _autoWaitBaseTime;

		// Token: 0x0400CE42 RID: 52802
		[Token(Token = "0x400CE42")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _autoWaitTimePerText;

		// Token: 0x0400CE43 RID: 52803
		[Token(Token = "0x400CE43")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _hideEase;

		// Token: 0x0400CE44 RID: 52804
		[Token(Token = "0x400CE44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _message;

		// Token: 0x0400CE45 RID: 52805
		[Token(Token = "0x400CE45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _textTransform;

		// Token: 0x0400CE46 RID: 52806
		[Token(Token = "0x400CE46")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400CE47 RID: 52807
		[Token(Token = "0x400CE47")]
		private const float TWEEN_DURATION = 0.15f;

		// Token: 0x0400CE48 RID: 52808
		[Token(Token = "0x400CE48")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hidden;

		// Token: 0x0400CE49 RID: 52809
		[Token(Token = "0x400CE49")]
		[FieldOffset(Offset = "0x50")]
		private Action<int> m_OnTypeEnd;

		// Token: 0x0400CE4A RID: 52810
		[Token(Token = "0x400CE4A")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_animSwitch;

		// Token: 0x0400CE4B RID: 52811
		[Token(Token = "0x400CE4B")]
		[FieldOffset(Offset = "0x60")]
		private float m_duration;

		// Token: 0x0400CE4C RID: 52812
		[Token(Token = "0x400CE4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTyping;

		// Token: 0x0400CE4D RID: 52813
		[Token(Token = "0x400CE4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0400CE4E RID: 52814
		[Token(Token = "0x400CE4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryFinishType;

		// Token: 0x0400CE4F RID: 52815
		[Token(Token = "0x400CE4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSticker;

		// Token: 0x0400CE50 RID: 52816
		[Token(Token = "0x400CE50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureSwitch;

		// Token: 0x0400CE51 RID: 52817
		[Token(Token = "0x400CE51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnTypeWriterEnd;

		// Token: 0x0400CE52 RID: 52818
		[Token(Token = "0x400CE52")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetView;

		// Token: 0x0400CE53 RID: 52819
		[Token(Token = "0x400CE53")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetTypeWriterDelay;

		// Token: 0x0400CE54 RID: 52820
		[Token(Token = "0x400CE54")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HideSticker;

		// Token: 0x0400CE55 RID: 52821
		[Token(Token = "0x400CE55")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AppendText;

		// Token: 0x0400CE56 RID: 52822
		[Token(Token = "0x400CE56")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetHiddenInternal;

		// Token: 0x0400CE57 RID: 52823
		[Token(Token = "0x400CE57")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
