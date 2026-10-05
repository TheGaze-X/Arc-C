using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200252B RID: 9515
	[Token(Token = "0x200252B")]
	public class SequenceGroupSelector : RangeSelector
	{
		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600F590 RID: 62864 RVA: 0x0005B410 File Offset: 0x00059610
		[Token(Token = "0x1700201F")]
		protected bool limitTargetNum
		{
			[Token(Token = "0x600F590")]
			[Address(RVA = "0x6DBED0", Offset = "0x6DAAD0", VA = "0x1806DBED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600F591 RID: 62865 RVA: 0x0005B428 File Offset: 0x00059628
		[Token(Token = "0x17002020")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F591")]
			[Address(RVA = "0x6DBFF0", Offset = "0x6DABF0", VA = "0x1806DBFF0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600F592 RID: 62866 RVA: 0x0005B440 File Offset: 0x00059640
		[Token(Token = "0x17002021")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F592")]
			[Address(RVA = "0x6DBF90", Offset = "0x6DAB90", VA = "0x1806DBF90", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600F593 RID: 62867 RVA: 0x0005B458 File Offset: 0x00059658
		[Token(Token = "0x17002022")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F593")]
			[Address(RVA = "0x6DBF30", Offset = "0x6DAB30", VA = "0x1806DBF30", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600F594 RID: 62868 RVA: 0x0005B470 File Offset: 0x00059670
		[Token(Token = "0x17002023")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F594")]
			[Address(RVA = "0x6DBE70", Offset = "0x6DAA70", VA = "0x1806DBE70", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F595 RID: 62869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F595")]
		[Address(RVA = "0x6DBAE0", Offset = "0x6DA6E0", VA = "0x1806DBAE0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F596 RID: 62870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F596")]
		[Address(RVA = "0x6DBC30", Offset = "0x6DA830", VA = "0x1806DBC30", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F597 RID: 62871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F597")]
		[Address(RVA = "0x6DB5A0", Offset = "0x6DA1A0", VA = "0x1806DB5A0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F598 RID: 62872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F598")]
		[Address(RVA = "0x6DB9D0", Offset = "0x6DA5D0", VA = "0x1806DB9D0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F599 RID: 62873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F599")]
		[Address(RVA = "0x6DBA80", Offset = "0x6DA680", VA = "0x1806DBA80", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F59A RID: 62874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F59A")]
		[Address(RVA = "0x6DBDD0", Offset = "0x6DA9D0", VA = "0x1806DBDD0")]
		public SequenceGroupSelector()
		{
		}

		// Token: 0x0600F59B RID: 62875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F59B")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F59C RID: 62876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F59C")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F59D RID: 62877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F59D")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04011041 RID: 69697
		[Token(Token = "0x4011041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RangeSelector _firstOrderSelector;

		// Token: 0x04011042 RID: 69698
		[Token(Token = "0x4011042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RangeSelector _appendOrderSelector;

		// Token: 0x04011043 RID: 69699
		[Token(Token = "0x4011043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04011044 RID: 69700
		[Token(Token = "0x4011044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private int _maxNum;

		// Token: 0x04011045 RID: 69701
		[Token(Token = "0x4011045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private string _maxNumBlackboardKey;

		// Token: 0x04011046 RID: 69702
		[Token(Token = "0x4011046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_maxTargetNum;

		// Token: 0x04011047 RID: 69703
		[Token(Token = "0x4011047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04011048 RID: 69704
		[Token(Token = "0x4011048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04011049 RID: 69705
		[Token(Token = "0x4011049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x0401104A RID: 69706
		[Token(Token = "0x401104A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x0401104B RID: 69707
		[Token(Token = "0x401104B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x0401104C RID: 69708
		[Token(Token = "0x401104C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401104D RID: 69709
		[Token(Token = "0x401104D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401104E RID: 69710
		[Token(Token = "0x401104E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x0401104F RID: 69711
		[Token(Token = "0x401104F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04011050 RID: 69712
		[Token(Token = "0x4011050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04011051 RID: 69713
		[Token(Token = "0x4011051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
