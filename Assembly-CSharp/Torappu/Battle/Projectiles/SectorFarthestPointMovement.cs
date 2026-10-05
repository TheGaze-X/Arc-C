using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029F0 RID: 10736
	[Token(Token = "0x20029F0")]
	public class SectorFarthestPointMovement : FarthestPointMovement
	{
		// Token: 0x06011CF4 RID: 72948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF4")]
		[Address(RVA = "0x9B5FB0", Offset = "0x9B4BB0", VA = "0x1809B5FB0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CF5 RID: 72949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF5")]
		[Address(RVA = "0x9B6060", Offset = "0x9B4C60", VA = "0x1809B6060", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011CF6 RID: 72950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF6")]
		[Address(RVA = "0x9B6A90", Offset = "0x9B5690", VA = "0x1809B6A90")]
		private void _SetTargetPosAndDirection(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CF7 RID: 72951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF7")]
		[Address(RVA = "0x9B6EB0", Offset = "0x9B5AB0", VA = "0x1809B6EB0")]
		public SectorFarthestPointMovement()
		{
		}

		// Token: 0x06011CF8 RID: 72952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF8")]
		[Address(RVA = "0x9B6A80", Offset = "0x9B5680", VA = "0x1809B6A80")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CF9 RID: 72953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF9")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401401A RID: 81946
		[Token(Token = "0x401401A")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 rotateOffset;

		// Token: 0x0401401B RID: 81947
		[Token(Token = "0x401401B")]
		[FieldOffset(Offset = "0x15C")]
		private bool _hasInitRotation;

		// Token: 0x0401401C RID: 81948
		[Token(Token = "0x401401C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401401D RID: 81949
		[Token(Token = "0x401401D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401401E RID: 81950
		[Token(Token = "0x401401E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetTargetPosAndDirection;

		// Token: 0x0401401F RID: 81951
		[Token(Token = "0x401401F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
