using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059DE RID: 23006
	[Token(Token = "0x20059DE")]
	public class CrisisV2RuneDetailView : DataBinder<CrisisV2MapProp>
	{
		// Token: 0x06021842 RID: 137282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021842")]
		[Address(RVA = "0x1BDAD60", Offset = "0x1BD9960", VA = "0x181BDAD60", Slot = "7")]
		public override void OnValueChanged(CrisisV2MapProp property)
		{
		}

		// Token: 0x06021843 RID: 137283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021843")]
		[Address(RVA = "0x1BDB270", Offset = "0x1BD9E70", VA = "0x181BDB270")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x06021844 RID: 137284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021844")]
		[Address(RVA = "0x1BDB390", Offset = "0x1BD9F90", VA = "0x181BDB390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021845 RID: 137285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021845")]
		[Address(RVA = "0x1BDB4E0", Offset = "0x1BDA0E0", VA = "0x181BDB4E0")]
		public CrisisV2RuneDetailView()
		{
		}

		// Token: 0x0402DCBD RID: 187581
		[Token(Token = "0x402DCBD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasEmpty;

		// Token: 0x0402DCBE RID: 187582
		[Token(Token = "0x402DCBE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasHardMode;

		// Token: 0x0402DCBF RID: 187583
		[Token(Token = "0x402DCBF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrisisV2RuneDetailSlotView _slotView;

		// Token: 0x0402DCC0 RID: 187584
		[Token(Token = "0x402DCC0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrisisV2RuneDetailPackView _packView;

		// Token: 0x0402DCC1 RID: 187585
		[Token(Token = "0x402DCC1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelFocus;

		// Token: 0x0402DCC2 RID: 187586
		[Token(Token = "0x402DCC2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgBgGlow;

		// Token: 0x0402DCC3 RID: 187587
		[Token(Token = "0x402DCC3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colBgGlowNormal;

		// Token: 0x0402DCC4 RID: 187588
		[Token(Token = "0x402DCC4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colBgGlowHard;

		// Token: 0x0402DCC5 RID: 187589
		[Token(Token = "0x402DCC5")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402DCC6 RID: 187590
		[Token(Token = "0x402DCC6")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_emptyTween;

		// Token: 0x0402DCC7 RID: 187591
		[Token(Token = "0x402DCC7")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_hardModeTween;

		// Token: 0x0402DCC8 RID: 187592
		[Token(Token = "0x402DCC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DCC9 RID: 187593
		[Token(Token = "0x402DCC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402DCCA RID: 187594
		[Token(Token = "0x402DCCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DCCB RID: 187595
		[Token(Token = "0x402DCCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
