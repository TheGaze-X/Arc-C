using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E8 RID: 10728
	[Token(Token = "0x20029E8")]
	public class NearestHighlandWallBottomMovement : ParacurveMovement
	{
		// Token: 0x06011CA7 RID: 72871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA7")]
		[Address(RVA = "0x9A4970", Offset = "0x9A3570", VA = "0x1809A4970", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CA8 RID: 72872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA8")]
		[Address(RVA = "0x9A4AA0", Offset = "0x9A36A0", VA = "0x1809A4AA0")]
		private void _SetTargetPos(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CA9 RID: 72873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA9")]
		[Address(RVA = "0x9A54D0", Offset = "0x9A40D0", VA = "0x1809A54D0")]
		public NearestHighlandWallBottomMovement()
		{
		}

		// Token: 0x06011CAA RID: 72874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CAA")]
		[Address(RVA = "0x9A4A90", Offset = "0x9A3690", VA = "0x1809A4A90")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x04013FA5 RID: 81829
		[Token(Token = "0x4013FA5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _includeSourceGrid;

		// Token: 0x04013FA6 RID: 81830
		[Token(Token = "0x4013FA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013FA7 RID: 81831
		[Token(Token = "0x4013FA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetTargetPos;

		// Token: 0x04013FA8 RID: 81832
		[Token(Token = "0x4013FA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
