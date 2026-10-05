using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200524E RID: 21070
	[Token(Token = "0x200524E")]
	public class RoguelikeFragmentOverloadDialog : UICustomDialog<RoguelikeFragmentOverloadDialog.Options>
	{
		// Token: 0x0601F14F RID: 127311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F14F")]
		[Address(RVA = "0x18D9E10", Offset = "0x18D8A10", VA = "0x1818D9E10", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601F150 RID: 127312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F150")]
		[Address(RVA = "0x18DA070", Offset = "0x18D8C70", VA = "0x1818DA070", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601F151 RID: 127313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F151")]
		[Address(RVA = "0x18DA220", Offset = "0x18D8E20", VA = "0x1818DA220", Slot = "7")]
		protected override void OnRender(RoguelikeFragmentOverloadDialog.Options options)
		{
		}

		// Token: 0x0601F152 RID: 127314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F152")]
		[Address(RVA = "0x18D9EF0", Offset = "0x18D8AF0", VA = "0x1818D9EF0")]
		public void OnCheckboxClick()
		{
		}

		// Token: 0x0601F153 RID: 127315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F153")]
		[Address(RVA = "0x18D9E70", Offset = "0x18D8A70", VA = "0x1818D9E70")]
		public void OnCancel()
		{
		}

		// Token: 0x0601F154 RID: 127316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F154")]
		[Address(RVA = "0x18D9F70", Offset = "0x18D8B70", VA = "0x1818D9F70")]
		public void OnConfirm()
		{
		}

		// Token: 0x0601F155 RID: 127317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F155")]
		[Address(RVA = "0x18DA390", Offset = "0x18D8F90", VA = "0x1818DA390")]
		private void _ConfirmCheckBox()
		{
		}

		// Token: 0x0601F156 RID: 127318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F156")]
		[Address(RVA = "0x18DA430", Offset = "0x18D9030", VA = "0x1818DA430")]
		public RoguelikeFragmentOverloadDialog()
		{
		}

		// Token: 0x04029B0C RID: 170764
		[Token(Token = "0x4029B0C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelHeavy;

		// Token: 0x04029B0D RID: 170765
		[Token(Token = "0x4029B0D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelOverload;

		// Token: 0x04029B0E RID: 170766
		[Token(Token = "0x4029B0E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _checkBox;

		// Token: 0x04029B0F RID: 170767
		[Token(Token = "0x4029B0F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04029B10 RID: 170768
		[Token(Token = "0x4029B10")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x04029B11 RID: 170769
		[Token(Token = "0x4029B11")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeFragmentOverloadDialog.Plugin _plugin;

		// Token: 0x04029B12 RID: 170770
		[Token(Token = "0x4029B12")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeFragmentOverloadDialog.Options m_options;

		// Token: 0x04029B13 RID: 170771
		[Token(Token = "0x4029B13")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_judgeResult;

		// Token: 0x04029B14 RID: 170772
		[Token(Token = "0x4029B14")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_viewFade;

		// Token: 0x04029B15 RID: 170773
		[Token(Token = "0x4029B15")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_checkBoxFade;

		// Token: 0x04029B16 RID: 170774
		[Token(Token = "0x4029B16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04029B17 RID: 170775
		[Token(Token = "0x4029B17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04029B18 RID: 170776
		[Token(Token = "0x4029B18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029B19 RID: 170777
		[Token(Token = "0x4029B19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCheckboxClick;

		// Token: 0x04029B1A RID: 170778
		[Token(Token = "0x4029B1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x04029B1B RID: 170779
		[Token(Token = "0x4029B1B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x04029B1C RID: 170780
		[Token(Token = "0x4029B1C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmCheckBox;

		// Token: 0x04029B1D RID: 170781
		[Token(Token = "0x4029B1D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200524F RID: 21071
		[Token(Token = "0x200524F")]
		public struct Options
		{
			// Token: 0x04029B1E RID: 170782
			[Token(Token = "0x4029B1E")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04029B1F RID: 170783
			[Token(Token = "0x4029B1F")]
			[FieldOffset(Offset = "0x8")]
			public FragmentBagStatus weightState;

			// Token: 0x04029B20 RID: 170784
			[Token(Token = "0x4029B20")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;

			// Token: 0x04029B21 RID: 170785
			[Token(Token = "0x4029B21")]
			[FieldOffset(Offset = "0x18")]
			public Action onCancel;
		}

		// Token: 0x02005250 RID: 21072
		[Token(Token = "0x2005250")]
		public abstract class Plugin : MonoBehaviour, IHotfixable
		{
			// Token: 0x0601F157 RID: 127319
			[Token(Token = "0x601F157")]
			public abstract void OnRender(RoguelikeFragmentOverloadDialog.Options options);

			// Token: 0x0601F158 RID: 127320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F158")]
			[Address(RVA = "0x18C7A80", Offset = "0x18C6680", VA = "0x1818C7A80")]
			protected Plugin()
			{
			}

			// Token: 0x04029B22 RID: 170786
			[Token(Token = "0x4029B22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
