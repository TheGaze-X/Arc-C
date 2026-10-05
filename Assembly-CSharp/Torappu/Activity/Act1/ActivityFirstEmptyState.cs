using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B49 RID: 31561
	[Token(Token = "0x2007B49")]
	public class ActivityFirstEmptyState : State
	{
		// Token: 0x0602C2DB RID: 180955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2DB")]
		[Address(RVA = "0x2812B60", Offset = "0x2811760", VA = "0x182812B60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C2DC RID: 180956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2DC")]
		[Address(RVA = "0x2812BC0", Offset = "0x28117C0", VA = "0x182812BC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C2DD RID: 180957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2DD")]
		[Address(RVA = "0x2812C40", Offset = "0x2811840", VA = "0x182812C40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602C2DE RID: 180958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2DE")]
		[Address(RVA = "0x2812CE0", Offset = "0x28118E0", VA = "0x182812CE0")]
		public ActivityFirstEmptyState()
		{
		}

		// Token: 0x0602C2DF RID: 180959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2DF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602C2E0 RID: 180960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040400BE RID: 262334
		[Token(Token = "0x40400BE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActivityFirstStateBean _stateBean;

		// Token: 0x040400BF RID: 262335
		[Token(Token = "0x40400BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x040400C0 RID: 262336
		[Token(Token = "0x40400C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040400C1 RID: 262337
		[Token(Token = "0x40400C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040400C2 RID: 262338
		[Token(Token = "0x40400C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040400C3 RID: 262339
		[Token(Token = "0x40400C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
