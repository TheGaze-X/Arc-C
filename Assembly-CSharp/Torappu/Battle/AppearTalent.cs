using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200246A RID: 9322
	[Token(Token = "0x200246A")]
	[RequireComponent(typeof(Ability))]
	public class AppearTalent : Talent
	{
		// Token: 0x0600EFDA RID: 61402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDA")]
		[Address(RVA = "0x66A6B0", Offset = "0x6692B0", VA = "0x18066A6B0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDB")]
		[Address(RVA = "0x66A8A0", Offset = "0x6694A0", VA = "0x18066A8A0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600EFDC RID: 61404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDC")]
		[Address(RVA = "0x66AA90", Offset = "0x669690", VA = "0x18066AA90")]
		private void _OnBorn(object arg)
		{
		}

		// Token: 0x0600EFDD RID: 61405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDD")]
		[Address(RVA = "0x66AB90", Offset = "0x669790", VA = "0x18066AB90")]
		private void _OnLocate(object arg)
		{
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDE")]
		[Address(RVA = "0x66AC90", Offset = "0x669890", VA = "0x18066AC90")]
		public AppearTalent()
		{
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDF")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE0")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401093F RID: 67903
		[Token(Token = "0x401093F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _castOnLocate;

		// Token: 0x04010940 RID: 67904
		[Token(Token = "0x4010940")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010941 RID: 67905
		[Token(Token = "0x4010941")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010942 RID: 67906
		[Token(Token = "0x4010942")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBorn;

		// Token: 0x04010943 RID: 67907
		[Token(Token = "0x4010943")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnLocate;

		// Token: 0x04010944 RID: 67908
		[Token(Token = "0x4010944")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
