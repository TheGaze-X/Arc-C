using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act14Side
{
	// Token: 0x020079C2 RID: 31170
	[Token(Token = "0x20079C2")]
	public class Act14SideUIFloat : ActivityStageComponent
	{
		// Token: 0x0602BB7C RID: 179068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7C")]
		[Address(RVA = "0x279CCA0", Offset = "0x279B8A0", VA = "0x18279CCA0", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BB7D RID: 179069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7D")]
		[Address(RVA = "0x279CAE0", Offset = "0x279B6E0", VA = "0x18279CAE0", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x0602BB7E RID: 179070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7E")]
		[Address(RVA = "0x279CF90", Offset = "0x279BB90", VA = "0x18279CF90")]
		private void _UpdateFloat([Optional] object _)
		{
		}

		// Token: 0x0602BB7F RID: 179071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7F")]
		[Address(RVA = "0x279D0F0", Offset = "0x279BCF0", VA = "0x18279D0F0")]
		public Act14SideUIFloat()
		{
		}

		// Token: 0x0602BB80 RID: 179072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB80")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602BB81 RID: 179073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB81")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403F406 RID: 259078
		[Token(Token = "0x403F406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _UIAnimator;

		// Token: 0x0403F407 RID: 259079
		[Token(Token = "0x403F407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F408 RID: 259080
		[Token(Token = "0x403F408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403F409 RID: 259081
		[Token(Token = "0x403F409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateFloat;

		// Token: 0x0403F40A RID: 259082
		[Token(Token = "0x403F40A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
