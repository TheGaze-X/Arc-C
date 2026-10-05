using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F47 RID: 24391
	[Token(Token = "0x2005F47")]
	public class CharacterEvolveDetailNewAttackRangeView : CharacterEvolveDetailCommon
	{
		// Token: 0x0602352A RID: 144682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352A")]
		[Address(RVA = "0x1DD4330", Offset = "0x1DD2F30", VA = "0x181DD4330")]
		public void Render(AttackRangeDescModel rangeIDOld, AttackRangeDescModel rangeIDNew)
		{
		}

		// Token: 0x0602352B RID: 144683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352B")]
		[Address(RVA = "0x1DD4400", Offset = "0x1DD3000", VA = "0x181DD4400")]
		public CharacterEvolveDetailNewAttackRangeView()
		{
		}

		// Token: 0x04030BD0 RID: 199632
		[Token(Token = "0x4030BD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterAttackRangeDeltaWidget delta;

		// Token: 0x04030BD1 RID: 199633
		[Token(Token = "0x4030BD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BD2 RID: 199634
		[Token(Token = "0x4030BD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
