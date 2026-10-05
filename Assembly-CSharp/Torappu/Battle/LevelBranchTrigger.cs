using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200256D RID: 9581
	[Token(Token = "0x200256D")]
	public class LevelBranchTrigger : TargetTrigger
	{
		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600F73E RID: 63294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700206F")]
		public override Entity target
		{
			[Token(Token = "0x600F73E")]
			[Address(RVA = "0x710E50", Offset = "0x70FA50", VA = "0x180710E50", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600F73F RID: 63295 RVA: 0x0005C538 File Offset: 0x0005A738
		[Token(Token = "0x17002070")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F73F")]
			[Address(RVA = "0x710D50", Offset = "0x70F950", VA = "0x180710D50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F740 RID: 63296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F740")]
		[Address(RVA = "0x710BC0", Offset = "0x70F7C0", VA = "0x180710BC0", Slot = "11")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x0005C550 File Offset: 0x0005A750
		[Token(Token = "0x600F741")]
		[Address(RVA = "0x710B30", Offset = "0x70F730", VA = "0x180710B30", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F742 RID: 63298 RVA: 0x0005C568 File Offset: 0x0005A768
		[Token(Token = "0x600F742")]
		[Address(RVA = "0x710AA0", Offset = "0x70F6A0", VA = "0x180710AA0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F743 RID: 63299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F743")]
		[Address(RVA = "0x710CB0", Offset = "0x70F8B0", VA = "0x180710CB0")]
		public LevelBranchTrigger()
		{
		}

		// Token: 0x0600F744 RID: 63300 RVA: 0x0005C580 File Offset: 0x0005A780
		[Token(Token = "0x600F744")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F745 RID: 63301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F745")]
		[Address(RVA = "0x70D9A0", Offset = "0x70C5A0", VA = "0x18070D9A0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x040112AE RID: 70318
		[Token(Token = "0x40112AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isLoop;

		// Token: 0x040112AF RID: 70319
		[Token(Token = "0x40112AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _branchId;

		// Token: 0x040112B0 RID: 70320
		[Token(Token = "0x40112B0")]
		[FieldOffset(Offset = "0x30")]
		private string m_branchId;

		// Token: 0x040112B1 RID: 70321
		[Token(Token = "0x40112B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040112B2 RID: 70322
		[Token(Token = "0x40112B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112B3 RID: 70323
		[Token(Token = "0x40112B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040112B4 RID: 70324
		[Token(Token = "0x40112B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112B5 RID: 70325
		[Token(Token = "0x40112B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112B6 RID: 70326
		[Token(Token = "0x40112B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
