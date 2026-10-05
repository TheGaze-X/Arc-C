using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E6C RID: 15980
	[Token(Token = "0x2003E6C")]
	public class SpecialOperatorBoardLvlupEvolveDetailFeatureView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D83 RID: 101763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D83")]
		[Address(RVA = "0x1189A30", Offset = "0x1188630", VA = "0x181189A30")]
		public void Render(SpecialOperatorBoardEvolveNodeViewModel.Feature viewModel)
		{
		}

		// Token: 0x06018D84 RID: 101764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D84")]
		[Address(RVA = "0x1189BC0", Offset = "0x11887C0", VA = "0x181189BC0")]
		public SpecialOperatorBoardLvlupEvolveDetailFeatureView()
		{
		}

		// Token: 0x0401E903 RID: 125187
		[Token(Token = "0x401E903")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelDesc;

		// Token: 0x0401E904 RID: 125188
		[Token(Token = "0x401E904")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRange;

		// Token: 0x0401E905 RID: 125189
		[Token(Token = "0x401E905")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0401E906 RID: 125190
		[Token(Token = "0x401E906")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterAttackRangeDeltaWidget _range;

		// Token: 0x0401E907 RID: 125191
		[Token(Token = "0x401E907")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E908 RID: 125192
		[Token(Token = "0x401E908")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
