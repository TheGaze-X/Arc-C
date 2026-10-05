using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD4 RID: 16340
	[Token(Token = "0x2003FD4")]
	public class PCKeySettingDisplayBtnView : UISimpleRecycleLayoutItemView<PCKeySettingDisplayBtnItemModel>, IHotfixable
	{
		// Token: 0x06019539 RID: 103737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019539")]
		[Address(RVA = "0x11FA5D0", Offset = "0x11F91D0", VA = "0x1811FA5D0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0601953A RID: 103738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601953A")]
		[Address(RVA = "0x11FA780", Offset = "0x11F9380", VA = "0x1811FA780", Slot = "6")]
		protected override void OnRender(PCKeySettingDisplayBtnItemModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x0601953B RID: 103739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601953B")]
		[Address(RVA = "0x11FA640", Offset = "0x11F9240", VA = "0x1811FA640")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601953C RID: 103740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601953C")]
		[Address(RVA = "0x11FA9A0", Offset = "0x11F95A0", VA = "0x1811FA9A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601953D RID: 103741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601953D")]
		[Address(RVA = "0x11FAA90", Offset = "0x11F9690", VA = "0x1811FAA90")]
		public PCKeySettingDisplayBtnView()
		{
		}

		// Token: 0x0401F7AB RID: 128939
		[Token(Token = "0x401F7AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x0401F7AC RID: 128940
		[Token(Token = "0x401F7AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0401F7AD RID: 128941
		[Token(Token = "0x401F7AD")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedIsNormal;

		// Token: 0x0401F7AE RID: 128942
		[Token(Token = "0x401F7AE")]
		[FieldOffset(Offset = "0x41")]
		private bool m_cachedDisplay;

		// Token: 0x0401F7AF RID: 128943
		[Token(Token = "0x401F7AF")]
		[FieldOffset(Offset = "0x42")]
		private bool m_hasInited;

		// Token: 0x0401F7B0 RID: 128944
		[Token(Token = "0x401F7B0")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_switchTween;

		// Token: 0x0401F7B1 RID: 128945
		[Token(Token = "0x401F7B1")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedSequenceNum;

		// Token: 0x0401F7B2 RID: 128946
		[Token(Token = "0x401F7B2")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401F7B3 RID: 128947
		[Token(Token = "0x401F7B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F7B4 RID: 128948
		[Token(Token = "0x401F7B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F7B5 RID: 128949
		[Token(Token = "0x401F7B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0401F7B6 RID: 128950
		[Token(Token = "0x401F7B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7B7 RID: 128951
		[Token(Token = "0x401F7B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FD5 RID: 16341
		[Token(Token = "0x2003FD5")]
		public class Output
		{
			// Token: 0x0601953E RID: 103742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601953E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x0401F7B8 RID: 128952
			[Token(Token = "0x401F7B8")]
			[FieldOffset(Offset = "0x10")]
			public bool isNormal;

			// Token: 0x0401F7B9 RID: 128953
			[Token(Token = "0x401F7B9")]
			[FieldOffset(Offset = "0x11")]
			public bool isEnable;
		}
	}
}
