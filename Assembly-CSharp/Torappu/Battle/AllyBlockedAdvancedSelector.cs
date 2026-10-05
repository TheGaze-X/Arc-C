using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024FA RID: 9466
	[Token(Token = "0x20024FA")]
	public class AllyBlockedAdvancedSelector : BlockedBaseSelector
	{
		// Token: 0x0600F3CD RID: 62413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3CD")]
		[Address(RVA = "0x6A4140", Offset = "0x6A2D40", VA = "0x1806A4140", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3CE")]
		[Address(RVA = "0x6A3A50", Offset = "0x6A2650", VA = "0x1806A3A50", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x00059E68 File Offset: 0x00058068
		[Token(Token = "0x600F3CF")]
		[Address(RVA = "0x6A4380", Offset = "0x6A2F80", VA = "0x1806A4380")]
		protected bool ValidateEnemyTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00059E80 File Offset: 0x00058080
		[Token(Token = "0x600F3D0")]
		[Address(RVA = "0x6A42D0", Offset = "0x6A2ED0", VA = "0x1806A42D0")]
		protected bool ValidateAllyTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3D1 RID: 62417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3D1")]
		[Address(RVA = "0x6A4440", Offset = "0x6A3040", VA = "0x1806A4440")]
		public AllyBlockedAdvancedSelector()
		{
		}

		// Token: 0x0600F3D2 RID: 62418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3D2")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3D3")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010DFC RID: 69116
		[Token(Token = "0x4010DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _onlyForToken;

		// Token: 0x04010DFD RID: 69117
		[Token(Token = "0x4010DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<Entity> m_tmpList;

		// Token: 0x04010DFE RID: 69118
		[Token(Token = "0x4010DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Character m_character;

		// Token: 0x04010DFF RID: 69119
		[Token(Token = "0x4010DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E00 RID: 69120
		[Token(Token = "0x4010E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E01 RID: 69121
		[Token(Token = "0x4010E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ValidateEnemyTarget;

		// Token: 0x04010E02 RID: 69122
		[Token(Token = "0x4010E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ValidateAllyTarget;

		// Token: 0x04010E03 RID: 69123
		[Token(Token = "0x4010E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
