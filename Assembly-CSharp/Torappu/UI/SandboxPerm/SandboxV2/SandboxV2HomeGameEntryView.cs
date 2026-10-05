using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004331 RID: 17201
	[Token(Token = "0x2004331")]
	public class SandboxV2HomeGameEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6D5 RID: 108245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D5")]
		[Address(RVA = "0x1385780", Offset = "0x1384380", VA = "0x181385780")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D6")]
		[Address(RVA = "0x13858F0", Offset = "0x13844F0", VA = "0x1813858F0")]
		public SandboxV2HomeGameEntryView()
		{
		}

		// Token: 0x04021943 RID: 137539
		[Token(Token = "0x4021943")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _enterBtnToggle;

		// Token: 0x04021944 RID: 137540
		[Token(Token = "0x4021944")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormalContinue;

		// Token: 0x04021945 RID: 137541
		[Token(Token = "0x4021945")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelWithMaxContinue;

		// Token: 0x04021946 RID: 137542
		[Token(Token = "0x4021946")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNormalDay;

		// Token: 0x04021947 RID: 137543
		[Token(Token = "0x4021947")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCurrentDay;

		// Token: 0x04021948 RID: 137544
		[Token(Token = "0x4021948")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtMaxDay;

		// Token: 0x04021949 RID: 137545
		[Token(Token = "0x4021949")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402194A RID: 137546
		[Token(Token = "0x402194A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
