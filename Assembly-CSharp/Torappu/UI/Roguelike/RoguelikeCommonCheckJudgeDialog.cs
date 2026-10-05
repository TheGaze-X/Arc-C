using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051C8 RID: 20936
	[Token(Token = "0x20051C8")]
	public class RoguelikeCommonCheckJudgeDialog : UICustomDialog<RoguelikeCommonCheckJudgeDialog.Options>
	{
		// Token: 0x0601EECB RID: 126667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EECB")]
		[Address(RVA = "0x18AFE80", Offset = "0x18AEA80", VA = "0x1818AFE80", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601EECC RID: 126668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EECC")]
		[Address(RVA = "0x18AFC70", Offset = "0x18AE870", VA = "0x1818AFC70", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601EECD RID: 126669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EECD")]
		[Address(RVA = "0x18AFF80", Offset = "0x18AEB80", VA = "0x1818AFF80", Slot = "7")]
		protected override void OnRender(RoguelikeCommonCheckJudgeDialog.Options input)
		{
		}

		// Token: 0x0601EECE RID: 126670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EECE")]
		[Address(RVA = "0x18AFCD0", Offset = "0x18AE8D0", VA = "0x1818AFCD0")]
		public void OnClickCheckBox()
		{
		}

		// Token: 0x0601EECF RID: 126671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EECF")]
		[Address(RVA = "0x18AFDC0", Offset = "0x18AE9C0", VA = "0x1818AFDC0")]
		public void OnClickPositive()
		{
		}

		// Token: 0x0601EED0 RID: 126672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED0")]
		[Address(RVA = "0x18AFD50", Offset = "0x18AE950", VA = "0x1818AFD50")]
		public void OnClickNegative()
		{
		}

		// Token: 0x0601EED1 RID: 126673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED1")]
		[Address(RVA = "0x18B00D0", Offset = "0x18AECD0", VA = "0x1818B00D0")]
		public RoguelikeCommonCheckJudgeDialog()
		{
		}

		// Token: 0x040297DE RID: 169950
		[Token(Token = "0x40297DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _judgeText;

		// Token: 0x040297DF RID: 169951
		[Token(Token = "0x40297DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _judgeTipsText;

		// Token: 0x040297E0 RID: 169952
		[Token(Token = "0x40297E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x040297E1 RID: 169953
		[Token(Token = "0x40297E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _checkBox;

		// Token: 0x040297E2 RID: 169954
		[Token(Token = "0x40297E2")]
		[FieldOffset(Offset = "0x60")]
		private Action<bool> m_onPositive;

		// Token: 0x040297E3 RID: 169955
		[Token(Token = "0x40297E3")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_checkBoxFade;

		// Token: 0x040297E4 RID: 169956
		[Token(Token = "0x40297E4")]
		[FieldOffset(Offset = "0x70")]
		private bool m_boxChecked;

		// Token: 0x040297E5 RID: 169957
		[Token(Token = "0x40297E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040297E6 RID: 169958
		[Token(Token = "0x40297E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040297E7 RID: 169959
		[Token(Token = "0x40297E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040297E8 RID: 169960
		[Token(Token = "0x40297E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickCheckBox;

		// Token: 0x040297E9 RID: 169961
		[Token(Token = "0x40297E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickPositive;

		// Token: 0x040297EA RID: 169962
		[Token(Token = "0x40297EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickNegative;

		// Token: 0x040297EB RID: 169963
		[Token(Token = "0x40297EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051C9 RID: 20937
		[Token(Token = "0x20051C9")]
		public class Options
		{
			// Token: 0x0601EED3 RID: 126675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EED3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040297EC RID: 169964
			[Token(Token = "0x40297EC")]
			[FieldOffset(Offset = "0x10")]
			public string judgeDesc;

			// Token: 0x040297ED RID: 169965
			[Token(Token = "0x40297ED")]
			[FieldOffset(Offset = "0x18")]
			public string checkBoxTips;

			// Token: 0x040297EE RID: 169966
			[Token(Token = "0x40297EE")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onPositive;
		}
	}
}
