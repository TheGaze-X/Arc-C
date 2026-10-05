using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002539 RID: 9529
	[Token(Token = "0x2002539")]
	public class EmpgrdTalentSelector : RangeSelector
	{
		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600F5D2 RID: 62930 RVA: 0x0005B5F0 File Offset: 0x000597F0
		[Token(Token = "0x17002029")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F5D2")]
			[Address(RVA = "0x6D33B0", Offset = "0x6D1FB0", VA = "0x1806D33B0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600F5D3 RID: 62931 RVA: 0x0005B608 File Offset: 0x00059808
		[Token(Token = "0x1700202A")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F5D3")]
			[Address(RVA = "0x6D3350", Offset = "0x6D1F50", VA = "0x1806D3350", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600F5D4 RID: 62932 RVA: 0x0005B620 File Offset: 0x00059820
		[Token(Token = "0x1700202B")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F5D4")]
			[Address(RVA = "0x6D32F0", Offset = "0x6D1EF0", VA = "0x1806D32F0", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600F5D5 RID: 62933 RVA: 0x0005B638 File Offset: 0x00059838
		[Token(Token = "0x1700202C")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F5D5")]
			[Address(RVA = "0x6D3290", Offset = "0x6D1E90", VA = "0x1806D3290", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F5D6 RID: 62934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5D6")]
		[Address(RVA = "0x6D2BD0", Offset = "0x6D17D0", VA = "0x1806D2BD0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5D7 RID: 62935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5D7")]
		[Address(RVA = "0x6D2B70", Offset = "0x6D1770", VA = "0x1806D2B70", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F5D8 RID: 62936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5D8")]
		[Address(RVA = "0x6D30F0", Offset = "0x6D1CF0", VA = "0x1806D30F0")]
		private string _GetSafeKey(Entity entity)
		{
			return null;
		}

		// Token: 0x0600F5D9 RID: 62937 RVA: 0x0005B650 File Offset: 0x00059850
		[Token(Token = "0x600F5D9")]
		[Address(RVA = "0x6D2EF0", Offset = "0x6D1AF0", VA = "0x1806D2EF0")]
		private FP _CalculateDamageWeight(Entity entity, Buff recorderBuff)
		{
			return default(FP);
		}

		// Token: 0x0600F5DA RID: 62938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5DA")]
		[Address(RVA = "0x6D3220", Offset = "0x6D1E20", VA = "0x1806D3220")]
		public EmpgrdTalentSelector()
		{
		}

		// Token: 0x04011098 RID: 69784
		[Token(Token = "0x4011098")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _damageRecorderBuffKey;

		// Token: 0x04011099 RID: 69785
		[Token(Token = "0x4011099")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _lowPriorityBuffKey;

		// Token: 0x0401109A RID: 69786
		[Token(Token = "0x401109A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _maxTargetNum;

		// Token: 0x0401109B RID: 69787
		[Token(Token = "0x401109B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x0401109C RID: 69788
		[Token(Token = "0x401109C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x0401109D RID: 69789
		[Token(Token = "0x401109D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x0401109E RID: 69790
		[Token(Token = "0x401109E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x0401109F RID: 69791
		[Token(Token = "0x401109F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x040110A0 RID: 69792
		[Token(Token = "0x40110A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x040110A1 RID: 69793
		[Token(Token = "0x40110A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetSafeKey;

		// Token: 0x040110A2 RID: 69794
		[Token(Token = "0x40110A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculateDamageWeight;

		// Token: 0x040110A3 RID: 69795
		[Token(Token = "0x40110A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
