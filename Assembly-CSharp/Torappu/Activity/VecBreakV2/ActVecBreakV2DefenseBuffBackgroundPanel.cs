using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E0B RID: 28171
	[Token(Token = "0x2006E0B")]
	public class ActVecBreakV2DefenseBuffBackgroundPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060281B2 RID: 164274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281B2")]
		[Address(RVA = "0x235E040", Offset = "0x235CC40", VA = "0x18235E040")]
		public void Render(ActVecBreakV2DefenseStageBuffItemModel model, bool isSelected, bool showDivLine, bool useSelectPanel)
		{
		}

		// Token: 0x060281B3 RID: 164275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281B3")]
		[Address(RVA = "0x235E220", Offset = "0x235CE20", VA = "0x18235E220")]
		public ActVecBreakV2DefenseBuffBackgroundPanel()
		{
		}

		// Token: 0x04038E87 RID: 233095
		[Token(Token = "0x4038E87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x04038E88 RID: 233096
		[Token(Token = "0x4038E88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _notCompletePanel;

		// Token: 0x04038E89 RID: 233097
		[Token(Token = "0x4038E89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _completedNotSelectPanel;

		// Token: 0x04038E8A RID: 233098
		[Token(Token = "0x4038E8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completedSelectPanel;

		// Token: 0x04038E8B RID: 233099
		[Token(Token = "0x4038E8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _divLine;

		// Token: 0x04038E8C RID: 233100
		[Token(Token = "0x4038E8C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _buffFullPanel;

		// Token: 0x04038E8D RID: 233101
		[Token(Token = "0x4038E8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038E8E RID: 233102
		[Token(Token = "0x4038E8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
