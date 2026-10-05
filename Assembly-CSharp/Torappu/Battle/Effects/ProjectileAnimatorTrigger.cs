using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003217 RID: 12823
	[Token(Token = "0x2003217")]
	public class ProjectileAnimatorTrigger : AnimatorTriggerSource
	{
		// Token: 0x0601457F RID: 83327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601457F")]
		[Address(RVA = "0xC91790", Offset = "0xC90390", VA = "0x180C91790", Slot = "10")]
		public override string GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014580 RID: 83328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014580")]
		[Address(RVA = "0xC91850", Offset = "0xC90450", VA = "0x180C91850")]
		public void SetTriggerValue(string triggerKey)
		{
		}

		// Token: 0x06014581 RID: 83329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014581")]
		[Address(RVA = "0xC917F0", Offset = "0xC903F0", VA = "0x180C917F0", Slot = "11")]
		public override string GetValue()
		{
			return null;
		}

		// Token: 0x06014582 RID: 83330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014582")]
		[Address(RVA = "0xC918D0", Offset = "0xC904D0", VA = "0x180C918D0")]
		public ProjectileAnimatorTrigger()
		{
		}

		// Token: 0x06014583 RID: 83331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014583")]
		[Address(RVA = "0xC81610", Offset = "0xC80210", VA = "0x180C81610")]
		private string <>xLuaBaseProxy_GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014584 RID: 83332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014584")]
		[Address(RVA = "0xC81670", Offset = "0xC80270", VA = "0x180C81670")]
		private string <>xLuaBaseProxy_GetValue()
		{
			return null;
		}

		// Token: 0x04017FD5 RID: 98261
		[Token(Token = "0x4017FD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _defaultKey;

		// Token: 0x04017FD6 RID: 98262
		[Token(Token = "0x4017FD6")]
		[FieldOffset(Offset = "0x28")]
		private string m_triggerKey;

		// Token: 0x04017FD7 RID: 98263
		[Token(Token = "0x4017FD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FD8 RID: 98264
		[Token(Token = "0x4017FD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTriggerValue;

		// Token: 0x04017FD9 RID: 98265
		[Token(Token = "0x4017FD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FDA RID: 98266
		[Token(Token = "0x4017FDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
