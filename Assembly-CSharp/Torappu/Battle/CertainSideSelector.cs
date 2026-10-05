using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002537 RID: 9527
	[Token(Token = "0x2002537")]
	public class CertainSideSelector : AdvancedSelector
	{
		// Token: 0x0600F5C3 RID: 62915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5C3")]
		[Address(RVA = "0x6D1960", Offset = "0x6D0560", VA = "0x1806D1960", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F5C4 RID: 62916 RVA: 0x0005B5C0 File Offset: 0x000597C0
		[Token(Token = "0x600F5C4")]
		[Address(RVA = "0x6D1FA0", Offset = "0x6D0BA0", VA = "0x1806D1FA0", Slot = "18")]
		public override bool VerifyTarget(List<Entity> candidates)
		{
			return default(bool);
		}

		// Token: 0x0600F5C5 RID: 62917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5C5")]
		[Address(RVA = "0x6D1BE0", Offset = "0x6D07E0", VA = "0x1806D1BE0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5C6 RID: 62918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5C6")]
		[Address(RVA = "0x6D2110", Offset = "0x6D0D10", VA = "0x1806D2110")]
		private void _CheckBuff(List<Entity> candidates, string buffKey)
		{
		}

		// Token: 0x0600F5C7 RID: 62919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5C7")]
		[Address(RVA = "0x6D22B0", Offset = "0x6D0EB0", VA = "0x1806D22B0")]
		public CertainSideSelector()
		{
		}

		// Token: 0x0600F5C8 RID: 62920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5C8")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F5C9 RID: 62921 RVA: 0x0005B5D8 File Offset: 0x000597D8
		[Token(Token = "0x600F5C9")]
		[Address(RVA = "0x6D1E70", Offset = "0x6D0A70", VA = "0x1806D1E70")]
		private bool <>xLuaBaseProxy_VerifyTarget(List<Entity> P0)
		{
			return default(bool);
		}

		// Token: 0x0600F5CA RID: 62922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5CA")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011088 RID: 69768
		[Token(Token = "0x4011088")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SideType _selectSideType;

		// Token: 0x04011089 RID: 69769
		[Token(Token = "0x4011089")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _buffKeyExcluded;

		// Token: 0x0401108A RID: 69770
		[Token(Token = "0x401108A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private List<string> _buffs;

		// Token: 0x0401108B RID: 69771
		[Token(Token = "0x401108B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _filterBuffSource;

		// Token: 0x0401108C RID: 69772
		[Token(Token = "0x401108C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x0401108D RID: 69773
		[Token(Token = "0x401108D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x0401108E RID: 69774
		[Token(Token = "0x401108E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0401108F RID: 69775
		[Token(Token = "0x401108F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckBuff;

		// Token: 0x04011090 RID: 69776
		[Token(Token = "0x4011090")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
