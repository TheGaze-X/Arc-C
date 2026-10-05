using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004741 RID: 18241
	[Token(Token = "0x2004741")]
	public class RecruitFesClassicCharPart : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA2E RID: 113198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2E")]
		[Address(RVA = "0x14FE3A0", Offset = "0x14FCFA0", VA = "0x1814FE3A0")]
		public void Render(string poolId)
		{
		}

		// Token: 0x0601BA2F RID: 113199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2F")]
		[Address(RVA = "0x14FE780", Offset = "0x14FD380", VA = "0x1814FE780")]
		public RecruitFesClassicCharPart()
		{
		}

		// Token: 0x04023D87 RID: 146823
		[Token(Token = "0x4023D87")]
		private const string CHAR_DICT = "rarityPickCharDict";

		// Token: 0x04023D88 RID: 146824
		[Token(Token = "0x4023D88")]
		private const string STAR5_TITLE = "star5ChooseRuleConst";

		// Token: 0x04023D89 RID: 146825
		[Token(Token = "0x4023D89")]
		private const string STAR6_TITLE = "star6ChooseRuleConst";

		// Token: 0x04023D8A RID: 146826
		[Token(Token = "0x4023D8A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04023D8B RID: 146827
		[Token(Token = "0x4023D8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitFesClassicCharPortObj _portObj;

		// Token: 0x04023D8C RID: 146828
		[Token(Token = "0x4023D8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecruitFesClassicCharPortObj _charObj;

		// Token: 0x04023D8D RID: 146829
		[Token(Token = "0x4023D8D")]
		[FieldOffset(Offset = "0x30")]
		private RecruitFesClassicCharPortObj m_star5Obj;

		// Token: 0x04023D8E RID: 146830
		[Token(Token = "0x4023D8E")]
		[FieldOffset(Offset = "0x38")]
		private RecruitFesClassicCharPortObj m_star6Obj;

		// Token: 0x04023D8F RID: 146831
		[Token(Token = "0x4023D8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D90 RID: 146832
		[Token(Token = "0x4023D90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
