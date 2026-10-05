using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002572 RID: 9586
	[Token(Token = "0x2002572")]
	public class SelectorTriggerWithCertainCondition : SelectorTrigger
	{
		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600F767 RID: 63335 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		[Token(Token = "0x17002076")]
		public bool checkContainBuffs
		{
			[Token(Token = "0x600F767")]
			[Address(RVA = "0x713D00", Offset = "0x712900", VA = "0x180713D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600F768 RID: 63336 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		[Token(Token = "0x17002077")]
		public bool checkNotAbnormalFlags
		{
			[Token(Token = "0x600F768")]
			[Address(RVA = "0x713D60", Offset = "0x712960", VA = "0x180713D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F769 RID: 63337 RVA: 0x0005C6E8 File Offset: 0x0005A8E8
		[Token(Token = "0x600F769")]
		[Address(RVA = "0x713A30", Offset = "0x712630", VA = "0x180713A30", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F76A RID: 63338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F76A")]
		[Address(RVA = "0x713CA0", Offset = "0x7128A0", VA = "0x180713CA0")]
		public SelectorTriggerWithCertainCondition()
		{
		}

		// Token: 0x0600F76B RID: 63339 RVA: 0x0005C700 File Offset: 0x0005A900
		[Token(Token = "0x600F76B")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x040112D8 RID: 70360
		[Token(Token = "0x40112D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _checkContainBuffs;

		// Token: 0x040112D9 RID: 70361
		[Token(Token = "0x40112D9")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		[Inspect("checkContainBuffs")]
		private bool _isAnd;

		// Token: 0x040112DA RID: 70362
		[Token(Token = "0x40112DA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string[] _buffKeys;

		// Token: 0x040112DB RID: 70363
		[Token(Token = "0x40112DB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _checkHasSp;

		// Token: 0x040112DC RID: 70364
		[Token(Token = "0x40112DC")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _checkNotAbnormalFlags;

		// Token: 0x040112DD RID: 70365
		[Token(Token = "0x40112DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Inspect("checkNotAbnormalFlags")]
		private AbnormalFlag[] _abnormalFlags;

		// Token: 0x040112DE RID: 70366
		[Token(Token = "0x40112DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkContainBuffs;

		// Token: 0x040112DF RID: 70367
		[Token(Token = "0x40112DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkNotAbnormalFlags;

		// Token: 0x040112E0 RID: 70368
		[Token(Token = "0x40112E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112E1 RID: 70369
		[Token(Token = "0x40112E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
