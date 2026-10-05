using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A0 RID: 26784
	[Token(Token = "0x20068A0")]
	public class StageZoneStoryOnlyPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026636 RID: 157238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026636")]
		[Address(RVA = "0x2173CC0", Offset = "0x21728C0", VA = "0x182173CC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026637 RID: 157239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026637")]
		[Address(RVA = "0x2173980", Offset = "0x2172580", VA = "0x182173980")]
		public void Show(string stageCode, string stageTitle, string stageDesc, Action startHandler)
		{
		}

		// Token: 0x06026638 RID: 157240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026638")]
		[Address(RVA = "0x21737A0", Offset = "0x21723A0", VA = "0x1821737A0")]
		public void Hide()
		{
		}

		// Token: 0x06026639 RID: 157241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026639")]
		[Address(RVA = "0x2173900", Offset = "0x2172500", VA = "0x182173900")]
		public void OnStartButtonPressed()
		{
		}

		// Token: 0x0602663A RID: 157242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602663A")]
		[Address(RVA = "0x2173830", Offset = "0x2172430", VA = "0x182173830")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x0602663B RID: 157243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602663B")]
		[Address(RVA = "0x2173DE0", Offset = "0x21729E0", VA = "0x182173DE0")]
		public StageZoneStoryOnlyPanel()
		{
		}

		// Token: 0x040360EB RID: 221419
		[Token(Token = "0x40360EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x040360EC RID: 221420
		[Token(Token = "0x40360EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x040360ED RID: 221421
		[Token(Token = "0x40360ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageTitleText;

		// Token: 0x040360EE RID: 221422
		[Token(Token = "0x40360EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x040360EF RID: 221423
		[Token(Token = "0x40360EF")]
		[FieldOffset(Offset = "0x38")]
		private Action m_startHandler;

		// Token: 0x040360F0 RID: 221424
		[Token(Token = "0x40360F0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040360F1 RID: 221425
		[Token(Token = "0x40360F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040360F2 RID: 221426
		[Token(Token = "0x40360F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040360F3 RID: 221427
		[Token(Token = "0x40360F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040360F4 RID: 221428
		[Token(Token = "0x40360F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStartButtonPressed;

		// Token: 0x040360F5 RID: 221429
		[Token(Token = "0x40360F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x040360F6 RID: 221430
		[Token(Token = "0x40360F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
