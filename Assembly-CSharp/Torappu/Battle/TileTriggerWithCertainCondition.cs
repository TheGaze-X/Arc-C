using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002577 RID: 9591
	[Token(Token = "0x2002577")]
	public class TileTriggerWithCertainCondition : TileTrigger
	{
		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600F78B RID: 63371 RVA: 0x0005C7D8 File Offset: 0x0005A9D8
		[Token(Token = "0x17002081")]
		public bool checkNotAbnormalFlags
		{
			[Token(Token = "0x600F78B")]
			[Address(RVA = "0x7165B0", Offset = "0x7151B0", VA = "0x1807165B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x0005C7F0 File Offset: 0x0005A9F0
		[Token(Token = "0x600F78C")]
		[Address(RVA = "0x716300", Offset = "0x714F00", VA = "0x180716300", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F78D")]
		[Address(RVA = "0x716480", Offset = "0x715080", VA = "0x180716480")]
		public TileTriggerWithCertainCondition()
		{
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x0005C808 File Offset: 0x0005AA08
		[Token(Token = "0x600F78E")]
		[Address(RVA = "0x716470", Offset = "0x715070", VA = "0x180716470")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04011307 RID: 70407
		[Token(Token = "0x4011307")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _checkNotAbnormalFlags;

		// Token: 0x04011308 RID: 70408
		[Token(Token = "0x4011308")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Inspect("checkNotAbnormalFlags")]
		private AbnormalFlag[] _abnormalFlags;

		// Token: 0x04011309 RID: 70409
		[Token(Token = "0x4011309")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkNotAbnormalFlags;

		// Token: 0x0401130A RID: 70410
		[Token(Token = "0x401130A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401130B RID: 70411
		[Token(Token = "0x401130B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
