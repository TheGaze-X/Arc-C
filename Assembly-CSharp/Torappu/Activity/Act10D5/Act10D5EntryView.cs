using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B2D RID: 31533
	[Token(Token = "0x2007B2D")]
	public class Act10D5EntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C260 RID: 180832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C260")]
		[Address(RVA = "0x2804640", Offset = "0x2803240", VA = "0x182804640")]
		public void Render()
		{
		}

		// Token: 0x0602C261 RID: 180833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C261")]
		[Address(RVA = "0x2804BB0", Offset = "0x28037B0", VA = "0x182804BB0")]
		public Act10D5EntryView()
		{
		}

		// Token: 0x0403FFDA RID: 262106
		[Token(Token = "0x403FFDA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelStageEndTime;

		// Token: 0x0403FFDB RID: 262107
		[Token(Token = "0x403FFDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRewardEndTime;

		// Token: 0x0403FFDC RID: 262108
		[Token(Token = "0x403FFDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageEndTime;

		// Token: 0x0403FFDD RID: 262109
		[Token(Token = "0x403FFDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRewardEndTime;

		// Token: 0x0403FFDE RID: 262110
		[Token(Token = "0x403FFDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0403FFDF RID: 262111
		[Token(Token = "0x403FFDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FFE0 RID: 262112
		[Token(Token = "0x403FFE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
