using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004328 RID: 17192
	[Token(Token = "0x2004328")]
	public class SandboxV2HomeChallengeEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6C4 RID: 108228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6C4")]
		[Address(RVA = "0x1385080", Offset = "0x1383C80", VA = "0x181385080")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6C5 RID: 108229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6C5")]
		[Address(RVA = "0x1385210", Offset = "0x1383E10", VA = "0x181385210")]
		public GameObject TutorialOnly_GetEntryBtnGo()
		{
			return null;
		}

		// Token: 0x0601A6C6 RID: 108230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6C6")]
		[Address(RVA = "0x1385280", Offset = "0x1383E80", VA = "0x181385280")]
		public SandboxV2HomeChallengeEntryView()
		{
		}

		// Token: 0x040218FD RID: 137469
		[Token(Token = "0x40218FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _bkgLocked;

		// Token: 0x040218FE RID: 137470
		[Token(Token = "0x40218FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bkgUnlocked;

		// Token: 0x040218FF RID: 137471
		[Token(Token = "0x40218FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _iconInactivated;

		// Token: 0x04021900 RID: 137472
		[Token(Token = "0x4021900")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _iconLocked;

		// Token: 0x04021901 RID: 137473
		[Token(Token = "0x4021901")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _inactivatedMask;

		// Token: 0x04021902 RID: 137474
		[Token(Token = "0x4021902")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasBtn;

		// Token: 0x04021903 RID: 137475
		[Token(Token = "0x4021903")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _alphaInactivated;

		// Token: 0x04021904 RID: 137476
		[Token(Token = "0x4021904")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _entryBtn;

		// Token: 0x04021905 RID: 137477
		[Token(Token = "0x4021905")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021906 RID: 137478
		[Token(Token = "0x4021906")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetEntryBtnGo;

		// Token: 0x04021907 RID: 137479
		[Token(Token = "0x4021907")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004329 RID: 17193
		[Token(Token = "0x2004329")]
		private enum ShowType
		{
			// Token: 0x04021909 RID: 137481
			[Token(Token = "0x4021909")]
			NONE,
			// Token: 0x0402190A RID: 137482
			[Token(Token = "0x402190A")]
			INACTIVATED,
			// Token: 0x0402190B RID: 137483
			[Token(Token = "0x402190B")]
			LOCKED,
			// Token: 0x0402190C RID: 137484
			[Token(Token = "0x402190C")]
			UNLOCKED
		}
	}
}
