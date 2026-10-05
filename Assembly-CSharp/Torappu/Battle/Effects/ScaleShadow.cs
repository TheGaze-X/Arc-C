using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003250 RID: 12880
	[Token(Token = "0x2003250")]
	public class ScaleShadow : Effect.Behaviour
	{
		// Token: 0x060146D8 RID: 83672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D8")]
		[Address(RVA = "0xCAC540", Offset = "0xCAB140", VA = "0x180CAC540", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146D9 RID: 83673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D9")]
		[Address(RVA = "0xCAC720", Offset = "0xCAB320", VA = "0x180CAC720")]
		public ScaleShadow()
		{
		}

		// Token: 0x060146DA RID: 83674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146DA")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018209 RID: 98825
		[Token(Token = "0x4018209")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scale;

		// Token: 0x0401820A RID: 98826
		[Token(Token = "0x401820A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401820B RID: 98827
		[Token(Token = "0x401820B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401820C RID: 98828
		[Token(Token = "0x401820C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
