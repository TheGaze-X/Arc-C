using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024EA RID: 9450
	[Token(Token = "0x20024EA")]
	public class AdvancedSelectorWithExCludeWhenSucceeded : AdvancedSelectorWithValidatorFilter
	{
		// Token: 0x0600F37A RID: 62330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F37A")]
		[Address(RVA = "0x69CC30", Offset = "0x69B830", VA = "0x18069CC30", Slot = "39")]
		protected override void Awake()
		{
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F37B")]
		[Address(RVA = "0x69CE00", Offset = "0x69BA00", VA = "0x18069CE00", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F37C RID: 62332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F37C")]
		[Address(RVA = "0x69CD20", Offset = "0x69B920", VA = "0x18069CD20", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F37D RID: 62333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F37D")]
		[Address(RVA = "0x69CB90", Offset = "0x69B790", VA = "0x18069CB90")]
		public void AddSucceededTarget(Entity target)
		{
		}

		// Token: 0x0600F37E RID: 62334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F37E")]
		[Address(RVA = "0x69CCA0", Offset = "0x69B8A0", VA = "0x18069CCA0")]
		public void ClearSucceededTarget()
		{
		}

		// Token: 0x0600F37F RID: 62335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F37F")]
		[Address(RVA = "0x69CF40", Offset = "0x69BB40", VA = "0x18069CF40")]
		public AdvancedSelectorWithExCludeWhenSucceeded()
		{
		}

		// Token: 0x0600F380 RID: 62336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F380")]
		[Address(RVA = "0x69CF30", Offset = "0x69BB30", VA = "0x18069CF30")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0600F381 RID: 62337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F381")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0600F382 RID: 62338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F382")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010D86 RID: 68998
		[Token(Token = "0x4010D86")]
		[FieldOffset(Offset = "0xF8")]
		private ListSet<Entity> m_succeededTargetList;

		// Token: 0x04010D87 RID: 68999
		[Token(Token = "0x4010D87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04010D88 RID: 69000
		[Token(Token = "0x4010D88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D89 RID: 69001
		[Token(Token = "0x4010D89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010D8A RID: 69002
		[Token(Token = "0x4010D8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddSucceededTarget;

		// Token: 0x04010D8B RID: 69003
		[Token(Token = "0x4010D8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearSucceededTarget;

		// Token: 0x04010D8C RID: 69004
		[Token(Token = "0x4010D8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
