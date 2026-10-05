using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005190 RID: 20880
	[Token(Token = "0x2005190")]
	public class UIRoguelikeEndingDialog : UICustomDialog<UIRoguelikeEndingDialog.Options>
	{
		// Token: 0x0601EDAC RID: 126380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDAC")]
		[Address(RVA = "0x18AC2C0", Offset = "0x18AAEC0", VA = "0x1818AC2C0", Slot = "7")]
		protected override void OnRender(UIRoguelikeEndingDialog.Options options)
		{
		}

		// Token: 0x0601EDAD RID: 126381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDAD")]
		[Address(RVA = "0x18AC250", Offset = "0x18AAE50", VA = "0x1818AC250")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDAE")]
		[Address(RVA = "0x18AC690", Offset = "0x18AB290", VA = "0x1818AC690")]
		public UIRoguelikeEndingDialog()
		{
		}

		// Token: 0x04029633 RID: 169523
		[Token(Token = "0x4029633")]
		private const string ANIM_NAME = "relic_dialog";

		// Token: 0x04029634 RID: 169524
		[Token(Token = "0x4029634")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _bossIcon;

		// Token: 0x04029635 RID: 169525
		[Token(Token = "0x4029635")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _endingDesc;

		// Token: 0x04029636 RID: 169526
		[Token(Token = "0x4029636")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _animation;

		// Token: 0x04029637 RID: 169527
		[Token(Token = "0x4029637")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIRoguelikeEndingDialogBasePlugin _plugin;

		// Token: 0x04029638 RID: 169528
		[Token(Token = "0x4029638")]
		[FieldOffset(Offset = "0x70")]
		private Action m_onConfirm;

		// Token: 0x04029639 RID: 169529
		[Token(Token = "0x4029639")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402963A RID: 169530
		[Token(Token = "0x402963A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0402963B RID: 169531
		[Token(Token = "0x402963B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005191 RID: 20881
		[Token(Token = "0x2005191")]
		public struct Options
		{
			// Token: 0x0402963C RID: 169532
			[Token(Token = "0x402963C")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402963D RID: 169533
			[Token(Token = "0x402963D")]
			[FieldOffset(Offset = "0x8")]
			public string endingId;

			// Token: 0x0402963E RID: 169534
			[Token(Token = "0x402963E")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;
		}
	}
}
