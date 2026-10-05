using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007284 RID: 29316
	[Token(Token = "0x2007284")]
	public class Act4D0EntryStageObj : MonoBehaviour
	{
		// Token: 0x0602985E RID: 170078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602985E")]
		[Address(RVA = "0x24DC1C0", Offset = "0x24DADC0", VA = "0x1824DC1C0")]
		public void OnClick()
		{
		}

		// Token: 0x0602985F RID: 170079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602985F")]
		[Address(RVA = "0x24DBDC0", Offset = "0x24DA9C0", VA = "0x1824DBDC0")]
		public void InitInfo(Act4D0Data.StageJumpInfo jumpInfo)
		{
		}

		// Token: 0x06029860 RID: 170080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029860")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Act4D0EntryStageObj()
		{
		}

		// Token: 0x0403B53E RID: 243006
		[Token(Token = "0x403B53E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B53F RID: 243007
		[Token(Token = "0x403B53F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _gotoText;

		// Token: 0x0403B540 RID: 243008
		[Token(Token = "0x403B540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bannedImage;

		// Token: 0x0403B541 RID: 243009
		[Token(Token = "0x403B541")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _bannedText;

		// Token: 0x0403B542 RID: 243010
		[Token(Token = "0x403B542")]
		[FieldOffset(Offset = "0x38")]
		private Act4D0Data.StageJumpInfo m_cacheInfo;

		// Token: 0x0403B543 RID: 243011
		[Token(Token = "0x403B543")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isUnlocked;
	}
}
