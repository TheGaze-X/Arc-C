using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B1 RID: 9137
	[Token(Token = "0x20023B1")]
	public class ToggleTile : InteractableTile
	{
		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600E842 RID: 59458 RVA: 0x00054C48 File Offset: 0x00052E48
		[Token(Token = "0x17001D4D")]
		protected override int maxTriggerCnt
		{
			[Token(Token = "0x600E842")]
			[Address(RVA = "0x5E9350", Offset = "0x5E7F50", VA = "0x1805E9350", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E843 RID: 59459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E843")]
		[Address(RVA = "0x5E9210", Offset = "0x5E7E10", VA = "0x1805E9210", Slot = "40")]
		protected override void OnTrigger()
		{
		}

		// Token: 0x0600E844 RID: 59460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E844")]
		[Address(RVA = "0x5E92B0", Offset = "0x5E7EB0", VA = "0x1805E92B0")]
		public ToggleTile()
		{
		}

		// Token: 0x0600E845 RID: 59461 RVA: 0x00054C60 File Offset: 0x00052E60
		[Token(Token = "0x600E845")]
		[Address(RVA = "0x5E8580", Offset = "0x5E7180", VA = "0x1805E8580")]
		private int <>xLuaBaseProxy_get_maxTriggerCnt()
		{
			return 0;
		}

		// Token: 0x0600E846 RID: 59462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E846")]
		[Address(RVA = "0x5B95E0", Offset = "0x5B81E0", VA = "0x1805B95E0")]
		private void <>xLuaBaseProxy_OnTrigger()
		{
		}

		// Token: 0x0400FFDE RID: 65502
		[Token(Token = "0x400FFDE")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Tile.Options _toggleOptions;

		// Token: 0x0400FFDF RID: 65503
		[Token(Token = "0x400FFDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTriggerCnt;

		// Token: 0x0400FFE0 RID: 65504
		[Token(Token = "0x400FFE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FFE1 RID: 65505
		[Token(Token = "0x400FFE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
