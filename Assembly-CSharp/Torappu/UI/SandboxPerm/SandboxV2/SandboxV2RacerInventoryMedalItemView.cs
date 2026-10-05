using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004359 RID: 17241
	[Token(Token = "0x2004359")]
	public class SandboxV2RacerInventoryMedalItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A76C RID: 108396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76C")]
		[Address(RVA = "0x138FEE0", Offset = "0x138EAE0", VA = "0x18138FEE0")]
		public void Render(SandboxV2RacerMedalModel model)
		{
		}

		// Token: 0x0601A76D RID: 108397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76D")]
		[Address(RVA = "0x13900F0", Offset = "0x138ECF0", VA = "0x1813900F0")]
		public SandboxV2RacerInventoryMedalItemView()
		{
		}

		// Token: 0x04021AAC RID: 137900
		[Token(Token = "0x4021AAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04021AAD RID: 137901
		[Token(Token = "0x4021AAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04021AAE RID: 137902
		[Token(Token = "0x4021AAE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04021AAF RID: 137903
		[Token(Token = "0x4021AAF")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021AB0 RID: 137904
		[Token(Token = "0x4021AB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021AB1 RID: 137905
		[Token(Token = "0x4021AB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
