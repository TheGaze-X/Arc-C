using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002287 RID: 8839
	[Token(Token = "0x2002287")]
	public class EnvEffectToTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600DE5B RID: 56923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BF0")]
		private string effectKey
		{
			[Token(Token = "0x600DE5B")]
			[Address(RVA = "0x3650510", Offset = "0x364F110", VA = "0x183650510")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE5C")]
		[Address(RVA = "0x3650110", Offset = "0x364ED10", VA = "0x183650110", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DE5D RID: 56925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE5D")]
		[Address(RVA = "0x364FFE0", Offset = "0x364EBE0", VA = "0x18364FFE0", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DE5E RID: 56926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE5E")]
		[Address(RVA = "0x3650460", Offset = "0x364F060", VA = "0x183650460")]
		public EnvEffectToTile()
		{
		}

		// Token: 0x0600DE5F RID: 56927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE5F")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DE60 RID: 56928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE60")]
		[Address(RVA = "0x364FB20", Offset = "0x364E720", VA = "0x18364FB20")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400F131 RID: 61745
		[Token(Token = "0x400F131")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnvEffectToTile.EffectSetting _effectSettings;

		// Token: 0x0400F132 RID: 61746
		[Token(Token = "0x400F132")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<Tile, Effect> m_tileEffectDict;

		// Token: 0x0400F133 RID: 61747
		[Token(Token = "0x400F133")]
		[FieldOffset(Offset = "0x60")]
		private string m_effectKey;

		// Token: 0x0400F134 RID: 61748
		[Token(Token = "0x400F134")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_effectKey;

		// Token: 0x0400F135 RID: 61749
		[Token(Token = "0x400F135")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F136 RID: 61750
		[Token(Token = "0x400F136")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F137 RID: 61751
		[Token(Token = "0x400F137")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002288 RID: 8840
		[Token(Token = "0x2002288")]
		[Serializable]
		private struct EffectSetting
		{
			// Token: 0x0400F138 RID: 61752
			[Token(Token = "0x400F138")]
			[FieldOffset(Offset = "0x0")]
			public string effectBBKey;

			// Token: 0x0400F139 RID: 61753
			[Token(Token = "0x400F139")]
			[FieldOffset(Offset = "0x8")]
			public List<string> extraLoadKeys;

			// Token: 0x0400F13A RID: 61754
			[Token(Token = "0x400F13A")]
			[FieldOffset(Offset = "0x10")]
			public string effectKey;

			// Token: 0x0400F13B RID: 61755
			[Token(Token = "0x400F13B")]
			[FieldOffset(Offset = "0x18")]
			public string envStatusToCreate;

			// Token: 0x0400F13C RID: 61756
			[Token(Token = "0x400F13C")]
			[FieldOffset(Offset = "0x20")]
			public string envStatusToFinish;
		}
	}
}
