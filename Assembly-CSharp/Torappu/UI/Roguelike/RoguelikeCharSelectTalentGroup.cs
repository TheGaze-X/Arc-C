using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A3 RID: 21667
	[Token(Token = "0x20054A3")]
	public class RoguelikeCharSelectTalentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE1A RID: 130586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1A")]
		[Address(RVA = "0x1A02BE0", Offset = "0x1A017E0", VA = "0x181A02BE0")]
		public void RenderTalent(RoguelikeTalentViewModel[] talents)
		{
		}

		// Token: 0x0601FE1B RID: 130587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1B")]
		[Address(RVA = "0x1A02DC0", Offset = "0x1A019C0", VA = "0x181A02DC0")]
		public RoguelikeCharSelectTalentGroup()
		{
		}

		// Token: 0x0402AFC7 RID: 176071
		[Token(Token = "0x402AFC7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x0402AFC8 RID: 176072
		[Token(Token = "0x402AFC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x0402AFC9 RID: 176073
		[Token(Token = "0x402AFC9")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeTalentViewModel[] m_talentsCache;

		// Token: 0x0402AFCA RID: 176074
		[Token(Token = "0x402AFCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTalent;

		// Token: 0x0402AFCB RID: 176075
		[Token(Token = "0x402AFCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
