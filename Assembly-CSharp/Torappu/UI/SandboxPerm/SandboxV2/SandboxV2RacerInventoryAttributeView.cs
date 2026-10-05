using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200434C RID: 17228
	[Token(Token = "0x200434C")]
	public class SandboxV2RacerInventoryAttributeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A740 RID: 108352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A740")]
		[Address(RVA = "0x138DA10", Offset = "0x138C610", VA = "0x18138DA10")]
		public void Render(SandboxV2RacerAttributeModel model)
		{
		}

		// Token: 0x0601A741 RID: 108353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A741")]
		[Address(RVA = "0x138DBA0", Offset = "0x138C7A0", VA = "0x18138DBA0")]
		public SandboxV2RacerInventoryAttributeView()
		{
		}

		// Token: 0x04021A2C RID: 137772
		[Token(Token = "0x4021A2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelMax;

		// Token: 0x04021A2D RID: 137773
		[Token(Token = "0x4021A2D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotMax;

		// Token: 0x04021A2E RID: 137774
		[Token(Token = "0x4021A2E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _textAttribute;

		// Token: 0x04021A2F RID: 137775
		[Token(Token = "0x4021A2F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textAttributeName;

		// Token: 0x04021A30 RID: 137776
		[Token(Token = "0x4021A30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021A31 RID: 137777
		[Token(Token = "0x4021A31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
