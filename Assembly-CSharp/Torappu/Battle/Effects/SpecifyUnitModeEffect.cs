using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003261 RID: 12897
	[Token(Token = "0x2003261")]
	public class SpecifyUnitModeEffect : Effect.Behaviour
	{
		// Token: 0x0601473B RID: 83771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601473B")]
		[Address(RVA = "0xCB62A0", Offset = "0xCB4EA0", VA = "0x180CB62A0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601473C RID: 83772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601473C")]
		[Address(RVA = "0xCB64E0", Offset = "0xCB50E0", VA = "0x180CB64E0")]
		private void Update()
		{
		}

		// Token: 0x0601473D RID: 83773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601473D")]
		[Address(RVA = "0xCB6610", Offset = "0xCB5210", VA = "0x180CB6610")]
		public SpecifyUnitModeEffect()
		{
		}

		// Token: 0x0601473E RID: 83774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601473E")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040182A6 RID: 98982
		[Token(Token = "0x40182A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _unitModeIndex;

		// Token: 0x040182A7 RID: 98983
		[Token(Token = "0x40182A7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _pauseOnOtherMode;

		// Token: 0x040182A8 RID: 98984
		[Token(Token = "0x40182A8")]
		[FieldOffset(Offset = "0x28")]
		private Unit m_unit;

		// Token: 0x040182A9 RID: 98985
		[Token(Token = "0x40182A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040182AA RID: 98986
		[Token(Token = "0x40182AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182AB RID: 98987
		[Token(Token = "0x40182AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
