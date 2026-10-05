using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002532 RID: 9522
	[Token(Token = "0x2002532")]
	public class AdvancedSelectorWithTrapSheltr : AdvancedSelector
	{
		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600F5B1 RID: 62897 RVA: 0x0005B530 File Offset: 0x00059730
		[Token(Token = "0x17002027")]
		public bool checkOnTheSameLine
		{
			[Token(Token = "0x600F5B1")]
			[Address(RVA = "0x6D0A70", Offset = "0x6CF670", VA = "0x1806D0A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F5B2 RID: 62898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5B2")]
		[Address(RVA = "0x6CFB20", Offset = "0x6CE720", VA = "0x1806CFB20", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5B3 RID: 62899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5B3")]
		[Address(RVA = "0x6D0040", Offset = "0x6CEC40", VA = "0x1806D0040")]
		private void _AssignSheltrPos(Entity sheltr)
		{
		}

		// Token: 0x0600F5B4 RID: 62900 RVA: 0x0005B548 File Offset: 0x00059748
		[Token(Token = "0x600F5B4")]
		[Address(RVA = "0x6D04F0", Offset = "0x6CF0F0", VA = "0x1806D04F0")]
		private bool _CheckCandidateBehindSheltr(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x0600F5B5 RID: 62901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5B5")]
		[Address(RVA = "0x6D0920", Offset = "0x6CF520", VA = "0x1806D0920")]
		public AdvancedSelectorWithTrapSheltr()
		{
		}

		// Token: 0x0600F5B6 RID: 62902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5B6")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0401106D RID: 69741
		[Token(Token = "0x401106D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _sheltrBuffKey;

		// Token: 0x0401106E RID: 69742
		[Token(Token = "0x401106E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _exposedBuffKey;

		// Token: 0x0401106F RID: 69743
		[Token(Token = "0x401106F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _checkOnTheSameLine;

		// Token: 0x04011070 RID: 69744
		[Token(Token = "0x4011070")]
		[FieldOffset(Offset = "0x108")]
		[Group("Offset")]
		[Inspect("checkOnTheSameLine")]
		[SerializeField]
		private FP _offsetMinX;

		// Token: 0x04011071 RID: 69745
		[Token(Token = "0x4011071")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Offset")]
		[Inspect("checkOnTheSameLine")]
		private FP _offsetMaxX;

		// Token: 0x04011072 RID: 69746
		[Token(Token = "0x4011072")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Offset")]
		[Inspect("checkOnTheSameLine")]
		private FP _offsetMinY;

		// Token: 0x04011073 RID: 69747
		[Token(Token = "0x4011073")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Offset")]
		[Inspect("checkOnTheSameLine")]
		private FP _offsetMaxY;

		// Token: 0x04011074 RID: 69748
		[Token(Token = "0x4011074")]
		[FieldOffset(Offset = "0x128")]
		private float m_upSheltrPos;

		// Token: 0x04011075 RID: 69749
		[Token(Token = "0x4011075")]
		[FieldOffset(Offset = "0x12C")]
		private float m_downSheltrPos;

		// Token: 0x04011076 RID: 69750
		[Token(Token = "0x4011076")]
		[FieldOffset(Offset = "0x130")]
		private float m_leftSheltrPos;

		// Token: 0x04011077 RID: 69751
		[Token(Token = "0x4011077")]
		[FieldOffset(Offset = "0x134")]
		private float m_rightSheltrPos;

		// Token: 0x04011078 RID: 69752
		[Token(Token = "0x4011078")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkOnTheSameLine;

		// Token: 0x04011079 RID: 69753
		[Token(Token = "0x4011079")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0401107A RID: 69754
		[Token(Token = "0x401107A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AssignSheltrPos;

		// Token: 0x0401107B RID: 69755
		[Token(Token = "0x401107B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCandidateBehindSheltr;

		// Token: 0x0401107C RID: 69756
		[Token(Token = "0x401107C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
