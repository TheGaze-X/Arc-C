using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD0 RID: 7632
	[Token(Token = "0x2001DD0")]
	public class BuildingFloatBlueprintState : BuildingFloatState
	{
		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x00046188 File Offset: 0x00044388
		[Token(Token = "0x170016C3")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC31")]
			[Address(RVA = "0x3387110", Offset = "0x3385D10", VA = "0x183387110", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC32")]
		[Address(RVA = "0x3386F80", Offset = "0x3385B80", VA = "0x183386F80", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC33")]
		[Address(RVA = "0x3387020", Offset = "0x3385C20", VA = "0x183387020", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC34")]
		[Address(RVA = "0x33870B0", Offset = "0x3385CB0", VA = "0x1833870B0")]
		public BuildingFloatBlueprintState()
		{
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC35")]
		[Address(RVA = "0x3383AE0", Offset = "0x33826E0", VA = "0x183383AE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC36")]
		[Address(RVA = "0x3383AF0", Offset = "0x33826F0", VA = "0x183383AF0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BC2D RID: 48173
		[Token(Token = "0x400BC2D")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_extraViews;

		// Token: 0x0400BC2E RID: 48174
		[Token(Token = "0x400BC2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC2F RID: 48175
		[Token(Token = "0x400BC2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BC30 RID: 48176
		[Token(Token = "0x400BC30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC31 RID: 48177
		[Token(Token = "0x400BC31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
