using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022A1 RID: 8865
	[Token(Token = "0x20022A1")]
	public class EnvSwitchEffectToTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEE5 RID: 57061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEE5")]
		[Address(RVA = "0x36566D0", Offset = "0x36552D0", VA = "0x1836566D0", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEE6")]
		[Address(RVA = "0x3656510", Offset = "0x3655110", VA = "0x183656510", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEE7")]
		[Address(RVA = "0x3656AA0", Offset = "0x36556A0", VA = "0x183656AA0")]
		public EnvSwitchEffectToTile()
		{
		}

		// Token: 0x0600DEE8 RID: 57064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEE8")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DEE9 RID: 57065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEE9")]
		[Address(RVA = "0x364FB20", Offset = "0x364E720", VA = "0x18364FB20")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400F1FF RID: 61951
		[Token(Token = "0x400F1FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<EnvSwitchEffectToTile.EffectConfig> _effectConfigs;

		// Token: 0x0400F200 RID: 61952
		[Token(Token = "0x400F200")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _checkStatusPrefix;

		// Token: 0x0400F201 RID: 61953
		[Token(Token = "0x400F201")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<Tile, Effect> m_tileEffectDict;

		// Token: 0x0400F202 RID: 61954
		[Token(Token = "0x400F202")]
		[FieldOffset(Offset = "0x48")]
		private string m_effectKey;

		// Token: 0x0400F203 RID: 61955
		[Token(Token = "0x400F203")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F204 RID: 61956
		[Token(Token = "0x400F204")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F205 RID: 61957
		[Token(Token = "0x400F205")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022A2 RID: 8866
		[Token(Token = "0x20022A2")]
		[Serializable]
		private struct EffectConfig
		{
			// Token: 0x0400F206 RID: 61958
			[Token(Token = "0x400F206")]
			[FieldOffset(Offset = "0x0")]
			public string effectKey;

			// Token: 0x0400F207 RID: 61959
			[Token(Token = "0x400F207")]
			[FieldOffset(Offset = "0x8")]
			public string status;
		}
	}
}
