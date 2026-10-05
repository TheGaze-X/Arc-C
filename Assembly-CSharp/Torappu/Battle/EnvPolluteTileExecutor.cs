using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002291 RID: 8849
	[Token(Token = "0x2002291")]
	public class EnvPolluteTileExecutor : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEAC RID: 57004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEAC")]
		[Address(RVA = "0x3653E30", Offset = "0x3652A30", VA = "0x183653E30", Slot = "18")]
		public override void OnEnvChanged(Tile tile, int param)
		{
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEAD")]
		[Address(RVA = "0x3653FC0", Offset = "0x3652BC0", VA = "0x183653FC0")]
		public EnvPolluteTileExecutor()
		{
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEAE")]
		[Address(RVA = "0x3651F40", Offset = "0x3650B40", VA = "0x183651F40")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, int P1)
		{
		}

		// Token: 0x0400F1A5 RID: 61861
		[Token(Token = "0x400F1A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _extraStrengthWhenHighlight;

		// Token: 0x0400F1A6 RID: 61862
		[Token(Token = "0x400F1A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EnvPolluteTileExecutor.TilePolluteSetting[] _polluteSettings;

		// Token: 0x0400F1A7 RID: 61863
		[Token(Token = "0x400F1A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1A8 RID: 61864
		[Token(Token = "0x400F1A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002292 RID: 8850
		[Token(Token = "0x2002292")]
		[Serializable]
		private struct TilePolluteSetting
		{
			// Token: 0x0400F1A9 RID: 61865
			[Token(Token = "0x400F1A9")]
			[FieldOffset(Offset = "0x0")]
			public int pollute;

			// Token: 0x0400F1AA RID: 61866
			[Token(Token = "0x400F1AA")]
			[FieldOffset(Offset = "0x4")]
			public float strength;
		}
	}
}
