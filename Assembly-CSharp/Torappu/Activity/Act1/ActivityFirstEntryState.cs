using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B4A RID: 31562
	[Token(Token = "0x2007B4A")]
	public class ActivityFirstEntryState : State
	{
		// Token: 0x0602C2E1 RID: 180961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2E1")]
		[Address(RVA = "0x2812D40", Offset = "0x2811940", VA = "0x182812D40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C2E2 RID: 180962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E2")]
		[Address(RVA = "0x2812DA0", Offset = "0x28119A0", VA = "0x182812DA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C2E3 RID: 180963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E3")]
		[Address(RVA = "0x2812E10", Offset = "0x2811A10", VA = "0x182812E10")]
		public ActivityFirstEntryState()
		{
		}

		// Token: 0x0602C2E4 RID: 180964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040400C4 RID: 262340
		[Token(Token = "0x40400C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x040400C5 RID: 262341
		[Token(Token = "0x40400C5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _timeRange;

		// Token: 0x040400C6 RID: 262342
		[Token(Token = "0x40400C6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x040400C7 RID: 262343
		[Token(Token = "0x40400C7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _detailBack;

		// Token: 0x040400C8 RID: 262344
		[Token(Token = "0x40400C8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x040400C9 RID: 262345
		[Token(Token = "0x40400C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040400CA RID: 262346
		[Token(Token = "0x40400CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040400CB RID: 262347
		[Token(Token = "0x40400CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
