using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200220E RID: 8718
	[Token(Token = "0x200220E")]
	public class BattleUniEquipSetting : MonoBehaviour, IHotfixable, IEffectSource
	{
		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BA6")]
		public string[] effects
		{
			[Token(Token = "0x600DBAD")]
			[Address(RVA = "0x361A5F0", Offset = "0x36191F0", VA = "0x18361A5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBAE")]
		[Address(RVA = "0x361A4E0", Offset = "0x36190E0", VA = "0x18361A4E0", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBAF")]
		[Address(RVA = "0x361A590", Offset = "0x3619190", VA = "0x18361A590")]
		public BattleUniEquipSetting()
		{
		}

		// Token: 0x0400ED7B RID: 60795
		[Token(Token = "0x400ED7B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x0400ED7C RID: 60796
		[Token(Token = "0x400ED7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_effects;

		// Token: 0x0400ED7D RID: 60797
		[Token(Token = "0x400ED7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400ED7E RID: 60798
		[Token(Token = "0x400ED7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
