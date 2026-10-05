using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002286 RID: 8838
	[Token(Token = "0x2002286")]
	public class EnvEffectToGridPosition : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x0600DE53 RID: 56915 RVA: 0x00051018 File Offset: 0x0004F218
		[Token(Token = "0x17001BEF")]
		private Vector3 worldZero
		{
			[Token(Token = "0x600DE53")]
			[Address(RVA = "0x3635520", Offset = "0x3634120", VA = "0x183635520")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600DE54 RID: 56916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE54")]
		[Address(RVA = "0x3634B60", Offset = "0x3633760", VA = "0x183634B60")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DE55 RID: 56917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE55")]
		public override void OnEnvEvent<T>(T value, string status)
		{
		}

		// Token: 0x0600DE56 RID: 56918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE56")]
		[Address(RVA = "0x3634C30", Offset = "0x3633830", VA = "0x183634C30", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE57 RID: 56919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE57")]
		[Address(RVA = "0x3634CD0", Offset = "0x36338D0", VA = "0x183634CD0", Slot = "20")]
		protected virtual void UpdateGridEffect()
		{
		}

		// Token: 0x0600DE58 RID: 56920 RVA: 0x00051030 File Offset: 0x0004F230
		[Token(Token = "0x600DE58")]
		[Address(RVA = "0x3635100", Offset = "0x3633D00", VA = "0x183635100")]
		protected Vector3 _GetWorldPosition(int row, int col)
		{
			return default(Vector3);
		}

		// Token: 0x0600DE59 RID: 56921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE59")]
		[Address(RVA = "0x3635350", Offset = "0x3633F50", VA = "0x183635350")]
		public EnvEffectToGridPosition()
		{
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE5A")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F120 RID: 61728
		[Token(Token = "0x400F120")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _gridOnStatus;

		// Token: 0x0400F121 RID: 61729
		[Token(Token = "0x400F121")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _gridOffStatus;

		// Token: 0x0400F122 RID: 61730
		[Token(Token = "0x400F122")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected string _tileEffectKey;

		// Token: 0x0400F123 RID: 61731
		[Token(Token = "0x400F123")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _boundaryExtensionLength;

		// Token: 0x0400F124 RID: 61732
		[Token(Token = "0x400F124")]
		[FieldOffset(Offset = "0x50")]
		private readonly Dictionary<ValueTuple<int, int>, Vector3> m_gridToWorldPos;

		// Token: 0x0400F125 RID: 61733
		[Token(Token = "0x400F125")]
		[FieldOffset(Offset = "0x58")]
		protected readonly Dictionary<GridPosition, ObjectPtr<Effect>> m_gridEffects;

		// Token: 0x0400F126 RID: 61734
		[Token(Token = "0x400F126")]
		[FieldOffset(Offset = "0x60")]
		protected readonly HashSet<GridPosition> m_gridOn;

		// Token: 0x0400F127 RID: 61735
		[Token(Token = "0x400F127")]
		[FieldOffset(Offset = "0x68")]
		protected readonly HashSet<GridPosition> m_gridOff;

		// Token: 0x0400F128 RID: 61736
		[Token(Token = "0x400F128")]
		[FieldOffset(Offset = "0x70")]
		private bool m_worldZeroValid;

		// Token: 0x0400F129 RID: 61737
		[Token(Token = "0x400F129")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_worldZero;

		// Token: 0x0400F12A RID: 61738
		[Token(Token = "0x400F12A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_worldZero;

		// Token: 0x0400F12B RID: 61739
		[Token(Token = "0x400F12B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F12C RID: 61740
		[Token(Token = "0x400F12C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvEvent;

		// Token: 0x0400F12D RID: 61741
		[Token(Token = "0x400F12D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F12E RID: 61742
		[Token(Token = "0x400F12E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateGridEffect;

		// Token: 0x0400F12F RID: 61743
		[Token(Token = "0x400F12F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetWorldPosition;

		// Token: 0x0400F130 RID: 61744
		[Token(Token = "0x400F130")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
