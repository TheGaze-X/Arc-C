using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200320C RID: 12812
	[Token(Token = "0x200320C")]
	public class Act25SideAnimatorBool : AnimatorBoolSource
	{
		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0601454D RID: 83277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700302D")]
		private Character followedTrap
		{
			[Token(Token = "0x601454D")]
			[Address(RVA = "0xC81120", Offset = "0xC7FD20", VA = "0x180C81120")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601454E RID: 83278 RVA: 0x00086850 File Offset: 0x00084A50
		[Token(Token = "0x601454E")]
		[Address(RVA = "0xC80ED0", Offset = "0xC7FAD0", VA = "0x180C80ED0", Slot = "11")]
		public override bool GetValue()
		{
			return default(bool);
		}

		// Token: 0x0601454F RID: 83279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601454F")]
		[Address(RVA = "0xC81040", Offset = "0xC7FC40", VA = "0x180C81040")]
		public Act25SideAnimatorBool()
		{
		}

		// Token: 0x06014550 RID: 83280 RVA: 0x00086868 File Offset: 0x00084A68
		[Token(Token = "0x6014550")]
		[Address(RVA = "0xC80FE0", Offset = "0xC7FBE0", VA = "0x180C80FE0")]
		private bool <>xLuaBaseProxy_GetValue()
		{
			return default(bool);
		}

		// Token: 0x04017F95 RID: 98197
		[Token(Token = "0x4017F95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SharedConsts.Direction _defaultValue;

		// Token: 0x04017F96 RID: 98198
		[Token(Token = "0x4017F96")]
		[FieldOffset(Offset = "0x28")]
		private Character m_followedTrap;

		// Token: 0x04017F97 RID: 98199
		[Token(Token = "0x4017F97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_followedTrap;

		// Token: 0x04017F98 RID: 98200
		[Token(Token = "0x4017F98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017F99 RID: 98201
		[Token(Token = "0x4017F99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
