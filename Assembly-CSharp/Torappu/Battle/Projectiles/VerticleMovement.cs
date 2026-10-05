using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029F4 RID: 10740
	[Token(Token = "0x20029F4")]
	public class VerticleMovement : AdvancedMovement
	{
		// Token: 0x06011D14 RID: 72980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D14")]
		[Address(RVA = "0x9BFC70", Offset = "0x9BE870", VA = "0x1809BFC70", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011D15 RID: 72981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D15")]
		[Address(RVA = "0x9BFE40", Offset = "0x9BEA40", VA = "0x1809BFE40")]
		public VerticleMovement()
		{
		}

		// Token: 0x06011D16 RID: 72982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D16")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x0401403A RID: 81978
		[Token(Token = "0x401403A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Detail")]
		private float _startHeight;

		// Token: 0x0401403B RID: 81979
		[Token(Token = "0x401403B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401403C RID: 81980
		[Token(Token = "0x401403C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
