using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029F1 RID: 10737
	[Token(Token = "0x20029F1")]
	public class TargetTileLRFarthestMovement : AdvancedMovement
	{
		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x06011CFA RID: 72954 RVA: 0x0006D110 File Offset: 0x0006B310
		[Token(Token = "0x17002746")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011CFA")]
			[Address(RVA = "0x9B7F70", Offset = "0x9B6B70", VA = "0x1809B7F70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011CFB RID: 72955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CFB")]
		[Address(RVA = "0x9B79B0", Offset = "0x9B65B0", VA = "0x1809B79B0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CFC RID: 72956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CFC")]
		[Address(RVA = "0x9B7E30", Offset = "0x9B6A30", VA = "0x1809B7E30", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011CFD RID: 72957 RVA: 0x0006D128 File Offset: 0x0006B328
		[Token(Token = "0x6011CFD")]
		[Address(RVA = "0x9B77F0", Offset = "0x9B63F0", VA = "0x1809B77F0", Slot = "23")]
		protected override Vector3 GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06011CFE RID: 72958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CFE")]
		[Address(RVA = "0x9B7900", Offset = "0x9B6500", VA = "0x1809B7900")]
		private void OnDestroy()
		{
		}

		// Token: 0x06011CFF RID: 72959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CFF")]
		[Address(RVA = "0x9B7F00", Offset = "0x9B6B00", VA = "0x1809B7F00")]
		public TargetTileLRFarthestMovement()
		{
		}

		// Token: 0x06011D00 RID: 72960 RVA: 0x0006D140 File Offset: 0x0006B340
		[Token(Token = "0x6011D00")]
		[Address(RVA = "0x9B7EF0", Offset = "0x9B6AF0", VA = "0x1809B7EF0")]
		private bool <>xLuaBaseProxy_get_movementAdjustable()
		{
			return default(bool);
		}

		// Token: 0x06011D01 RID: 72961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D01")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011D02 RID: 72962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D02")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011D03 RID: 72963 RVA: 0x0006D158 File Offset: 0x0006B358
		[Token(Token = "0x6011D03")]
		[Address(RVA = "0x993690", Offset = "0x992290", VA = "0x180993690")]
		private Vector3 <>xLuaBaseProxy_GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x04014020 RID: 81952
		[Token(Token = "0x4014020")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _isLeftToRight;

		// Token: 0x04014021 RID: 81953
		[Token(Token = "0x4014021")]
		[FieldOffset(Offset = "0x141")]
		[SerializeField]
		private bool _overrideMovementAdjustable;

		// Token: 0x04014022 RID: 81954
		[Token(Token = "0x4014022")]
		[FieldOffset(Offset = "0x148")]
		private ObjectPtr<Tile> m_targetTile;

		// Token: 0x04014023 RID: 81955
		[Token(Token = "0x4014023")]
		[FieldOffset(Offset = "0x158")]
		private ObjectPtr<Tile> m_startTile;

		// Token: 0x04014024 RID: 81956
		[Token(Token = "0x4014024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04014025 RID: 81957
		[Token(Token = "0x4014025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014026 RID: 81958
		[Token(Token = "0x4014026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04014027 RID: 81959
		[Token(Token = "0x4014027")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTraceTargetMapPosition;

		// Token: 0x04014028 RID: 81960
		[Token(Token = "0x4014028")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04014029 RID: 81961
		[Token(Token = "0x4014029")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
