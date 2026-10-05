using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051CA RID: 20938
	[Token(Token = "0x20051CA")]
	public class RoguelikeCommonJudgeDialog : UICustomDialog<RoguelikeCommonJudgeDialog.Options>
	{
		// Token: 0x0601EED4 RID: 126676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EED4")]
		[Address(RVA = "0x18B0140", Offset = "0x18AED40", VA = "0x1818B0140", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601EED5 RID: 126677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED5")]
		[Address(RVA = "0x18B02D0", Offset = "0x18AEED0", VA = "0x1818B02D0", Slot = "7")]
		protected override void OnRender(RoguelikeCommonJudgeDialog.Options options)
		{
		}

		// Token: 0x0601EED6 RID: 126678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED6")]
		[Address(RVA = "0x18B0210", Offset = "0x18AEE10", VA = "0x1818B0210")]
		public void OnClickPositive()
		{
		}

		// Token: 0x0601EED7 RID: 126679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED7")]
		[Address(RVA = "0x18B01A0", Offset = "0x18AEDA0", VA = "0x1818B01A0")]
		public void OnClickNegative()
		{
		}

		// Token: 0x0601EED8 RID: 126680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EED8")]
		[Address(RVA = "0x18B03E0", Offset = "0x18AEFE0", VA = "0x1818B03E0")]
		public RoguelikeCommonJudgeDialog()
		{
		}

		// Token: 0x040297EF RID: 169967
		[Token(Token = "0x40297EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _judgeText;

		// Token: 0x040297F0 RID: 169968
		[Token(Token = "0x40297F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _judgeTipsText;

		// Token: 0x040297F1 RID: 169969
		[Token(Token = "0x40297F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x040297F2 RID: 169970
		[Token(Token = "0x40297F2")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onPositive;

		// Token: 0x040297F3 RID: 169971
		[Token(Token = "0x40297F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040297F4 RID: 169972
		[Token(Token = "0x40297F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040297F5 RID: 169973
		[Token(Token = "0x40297F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickPositive;

		// Token: 0x040297F6 RID: 169974
		[Token(Token = "0x40297F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickNegative;

		// Token: 0x040297F7 RID: 169975
		[Token(Token = "0x40297F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051CB RID: 20939
		[Token(Token = "0x20051CB")]
		public class Options
		{
			// Token: 0x0601EEDA RID: 126682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EEDA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040297F8 RID: 169976
			[Token(Token = "0x40297F8")]
			[FieldOffset(Offset = "0x10")]
			public string judgeDesc;

			// Token: 0x040297F9 RID: 169977
			[Token(Token = "0x40297F9")]
			[FieldOffset(Offset = "0x18")]
			public string judgeTips;

			// Token: 0x040297FA RID: 169978
			[Token(Token = "0x40297FA")]
			[FieldOffset(Offset = "0x20")]
			public Action onPositive;
		}

		// Token: 0x020051CC RID: 20940
		[Token(Token = "0x20051CC")]
		public enum ResultType
		{
			// Token: 0x040297FC RID: 169980
			[Token(Token = "0x40297FC")]
			NEGATIVE,
			// Token: 0x040297FD RID: 169981
			[Token(Token = "0x40297FD")]
			POSITIVE
		}
	}
}
