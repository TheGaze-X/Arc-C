using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DEE RID: 28142
	[Token(Token = "0x2006DEE")]
	public class ActVecBreakV2OffenseBattleFinishCharCardHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602811E RID: 164126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602811E")]
		[Address(RVA = "0x2351670", Offset = "0x2350270", VA = "0x182351670")]
		public void Render(ActVecBreakV2OffenseBattleFinishCharModel charModel)
		{
		}

		// Token: 0x0602811F RID: 164127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602811F")]
		[Address(RVA = "0x23518C0", Offset = "0x23504C0", VA = "0x1823518C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028120 RID: 164128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028120")]
		[Address(RVA = "0x23519A0", Offset = "0x23505A0", VA = "0x1823519A0")]
		public ActVecBreakV2OffenseBattleFinishCharCardHolder()
		{
		}

		// Token: 0x04038D74 RID: 232820
		[Token(Token = "0x4038D74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishCharCardView _cardViewPrefab;

		// Token: 0x04038D75 RID: 232821
		[Token(Token = "0x4038D75")]
		[FieldOffset(Offset = "0x20")]
		private ActVecBreakV2OffenseBattleFinishCharCardView m_cardView;

		// Token: 0x04038D76 RID: 232822
		[Token(Token = "0x4038D76")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x04038D77 RID: 232823
		[Token(Token = "0x4038D77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D78 RID: 232824
		[Token(Token = "0x4038D78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038D79 RID: 232825
		[Token(Token = "0x4038D79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
