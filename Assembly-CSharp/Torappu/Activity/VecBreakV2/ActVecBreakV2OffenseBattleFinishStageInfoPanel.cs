using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF0 RID: 28144
	[Token(Token = "0x2006DF0")]
	public class ActVecBreakV2OffenseBattleFinishStageInfoPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028123 RID: 164131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028123")]
		[Address(RVA = "0x2351F60", Offset = "0x2350B60", VA = "0x182351F60")]
		public void Render(ActVecBreakV2OffenseBattleFinishViewModel model)
		{
		}

		// Token: 0x06028124 RID: 164132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028124")]
		[Address(RVA = "0x2352400", Offset = "0x2351000", VA = "0x182352400")]
		private void _RenderNormalStageInfo(ActVecBreakV2OffenseBattleFinishViewModel model)
		{
		}

		// Token: 0x06028125 RID: 164133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028125")]
		[Address(RVA = "0x2352310", Offset = "0x2350F10", VA = "0x182352310")]
		private void _RenderHardStageInfo(ActVecBreakV2OffenseBattleFinishViewModel model)
		{
		}

		// Token: 0x06028126 RID: 164134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028126")]
		[Address(RVA = "0x2352570", Offset = "0x2351170", VA = "0x182352570")]
		public ActVecBreakV2OffenseBattleFinishStageInfoPanel()
		{
		}

		// Token: 0x04038D85 RID: 232837
		[Token(Token = "0x4038D85")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _playerNameText;

		// Token: 0x04038D86 RID: 232838
		[Token(Token = "0x4038D86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageCompleteTimeText;

		// Token: 0x04038D87 RID: 232839
		[Token(Token = "0x4038D87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageLevelText;

		// Token: 0x04038D88 RID: 232840
		[Token(Token = "0x4038D88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalCompleteGo;

		// Token: 0x04038D89 RID: 232841
		[Token(Token = "0x4038D89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finalCompleteGo;

		// Token: 0x04038D8A RID: 232842
		[Token(Token = "0x4038D8A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _stageAlphaOrderImg;

		// Token: 0x04038D8B RID: 232843
		[Token(Token = "0x4038D8B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stageCodeNameText;

		// Token: 0x04038D8C RID: 232844
		[Token(Token = "0x4038D8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D8D RID: 232845
		[Token(Token = "0x4038D8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderNormalStageInfo;

		// Token: 0x04038D8E RID: 232846
		[Token(Token = "0x4038D8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderHardStageInfo;

		// Token: 0x04038D8F RID: 232847
		[Token(Token = "0x4038D8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
