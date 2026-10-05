using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AFA RID: 31482
	[Token(Token = "0x2007AFA")]
	public class Act12D6RelicHandBookToggleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C154 RID: 180564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C154")]
		[Address(RVA = "0x27F5C90", Offset = "0x27F4890", VA = "0x1827F5C90")]
		public void SwitchOnState(bool isOn)
		{
		}

		// Token: 0x0602C155 RID: 180565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C155")]
		[Address(RVA = "0x27F5D70", Offset = "0x27F4970", VA = "0x1827F5D70")]
		public Act12D6RelicHandBookToggleItemView()
		{
		}

		// Token: 0x0403FE2B RID: 261675
		[Token(Token = "0x403FE2B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FE2C RID: 261676
		[Token(Token = "0x403FE2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objCheck;

		// Token: 0x0403FE2D RID: 261677
		[Token(Token = "0x403FE2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SwitchOnState;

		// Token: 0x0403FE2E RID: 261678
		[Token(Token = "0x403FE2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
