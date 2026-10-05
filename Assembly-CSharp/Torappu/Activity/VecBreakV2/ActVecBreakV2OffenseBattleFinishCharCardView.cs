using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DEF RID: 28143
	[Token(Token = "0x2006DEF")]
	public class ActVecBreakV2OffenseBattleFinishCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028121 RID: 164129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028121")]
		[Address(RVA = "0x2351A00", Offset = "0x2350600", VA = "0x182351A00")]
		public void Render(ActVecBreakV2OffenseBattleFinishCharModel charModel)
		{
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028122")]
		[Address(RVA = "0x2351B50", Offset = "0x2350750", VA = "0x182351B50")]
		public ActVecBreakV2OffenseBattleFinishCharCardView()
		{
		}

		// Token: 0x04038D7A RID: 232826
		[Token(Token = "0x4038D7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonCharCardView _normalCardView;

		// Token: 0x04038D7B RID: 232827
		[Token(Token = "0x4038D7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyCardGo;

		// Token: 0x04038D7C RID: 232828
		[Token(Token = "0x4038D7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyNormalCardPart;

		// Token: 0x04038D7D RID: 232829
		[Token(Token = "0x4038D7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyAssistCardPart;

		// Token: 0x04038D7E RID: 232830
		[Token(Token = "0x4038D7E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalCardGo;

		// Token: 0x04038D7F RID: 232831
		[Token(Token = "0x4038D7F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalBgPart;

		// Token: 0x04038D80 RID: 232832
		[Token(Token = "0x4038D80")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _assistBgPart;

		// Token: 0x04038D81 RID: 232833
		[Token(Token = "0x4038D81")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _assistOutlinePart;

		// Token: 0x04038D82 RID: 232834
		[Token(Token = "0x4038D82")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _potentialGo;

		// Token: 0x04038D83 RID: 232835
		[Token(Token = "0x4038D83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D84 RID: 232836
		[Token(Token = "0x4038D84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
