using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200320D RID: 12813
	[Token(Token = "0x200320D")]
	public class Act27SideAnimatorTrigger : AnimatorTriggerSource
	{
		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x06014551 RID: 83281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700302E")]
		private Tile effectHolder
		{
			[Token(Token = "0x6014551")]
			[Address(RVA = "0xC81730", Offset = "0xC80330", VA = "0x180C81730")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x06014552 RID: 83282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700302F")]
		private Act27SideBattleManager manager
		{
			[Token(Token = "0x6014552")]
			[Address(RVA = "0xC818B0", Offset = "0xC804B0", VA = "0x180C818B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014553 RID: 83283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014553")]
		[Address(RVA = "0xC81210", Offset = "0xC7FE10", VA = "0x180C81210", Slot = "10")]
		public override string GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014554 RID: 83284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014554")]
		[Address(RVA = "0xC812F0", Offset = "0xC7FEF0", VA = "0x180C812F0", Slot = "11")]
		public override string GetValue()
		{
			return null;
		}

		// Token: 0x06014555 RID: 83285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014555")]
		[Address(RVA = "0xC816D0", Offset = "0xC802D0", VA = "0x180C816D0")]
		public Act27SideAnimatorTrigger()
		{
		}

		// Token: 0x06014556 RID: 83286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014556")]
		[Address(RVA = "0xC81610", Offset = "0xC80210", VA = "0x180C81610")]
		private string <>xLuaBaseProxy_GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014557 RID: 83287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014557")]
		[Address(RVA = "0xC81670", Offset = "0xC80270", VA = "0x180C81670")]
		private string <>xLuaBaseProxy_GetValue()
		{
			return null;
		}

		// Token: 0x04017F9A RID: 98202
		[Token(Token = "0x4017F9A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _allySideTypeKey;

		// Token: 0x04017F9B RID: 98203
		[Token(Token = "0x4017F9B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _enemySideTypeKey;

		// Token: 0x04017F9C RID: 98204
		[Token(Token = "0x4017F9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _endKey;

		// Token: 0x04017F9D RID: 98205
		[Token(Token = "0x4017F9D")]
		[FieldOffset(Offset = "0x38")]
		private Act27SideBattleManager m_manager;

		// Token: 0x04017F9E RID: 98206
		[Token(Token = "0x4017F9E")]
		[FieldOffset(Offset = "0x40")]
		private Tile m_tile;

		// Token: 0x04017F9F RID: 98207
		[Token(Token = "0x4017F9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_effectHolder;

		// Token: 0x04017FA0 RID: 98208
		[Token(Token = "0x4017FA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_manager;

		// Token: 0x04017FA1 RID: 98209
		[Token(Token = "0x4017FA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FA2 RID: 98210
		[Token(Token = "0x4017FA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FA3 RID: 98211
		[Token(Token = "0x4017FA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
