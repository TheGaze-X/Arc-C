using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003211 RID: 12817
	[Token(Token = "0x2003211")]
	public class AuraProjectileSetAnimatorTrigger : AnimatorTriggerSource
	{
		// Token: 0x06014561 RID: 83297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014561")]
		[Address(RVA = "0xC84D40", Offset = "0xC83940", VA = "0x180C84D40", Slot = "10")]
		public override string GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014562 RID: 83298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014562")]
		[Address(RVA = "0xC84E10", Offset = "0xC83A10", VA = "0x180C84E10")]
		public void SetTriggerValue()
		{
		}

		// Token: 0x06014563 RID: 83299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014563")]
		[Address(RVA = "0xC84DA0", Offset = "0xC839A0", VA = "0x180C84DA0", Slot = "11")]
		public override string GetValue()
		{
			return null;
		}

		// Token: 0x06014564 RID: 83300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014564")]
		[Address(RVA = "0xC84E70", Offset = "0xC83A70", VA = "0x180C84E70")]
		public AuraProjectileSetAnimatorTrigger()
		{
		}

		// Token: 0x06014565 RID: 83301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014565")]
		[Address(RVA = "0xC81610", Offset = "0xC80210", VA = "0x180C81610")]
		private string <>xLuaBaseProxy_GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014566 RID: 83302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014566")]
		[Address(RVA = "0xC81670", Offset = "0xC80270", VA = "0x180C81670")]
		private string <>xLuaBaseProxy_GetValue()
		{
			return null;
		}

		// Token: 0x04017FAD RID: 98221
		[Token(Token = "0x4017FAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _defaultKey;

		// Token: 0x04017FAE RID: 98222
		[Token(Token = "0x4017FAE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _triggerKey;

		// Token: 0x04017FAF RID: 98223
		[Token(Token = "0x4017FAF")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isTriggerOn;

		// Token: 0x04017FB0 RID: 98224
		[Token(Token = "0x4017FB0")]
		[FieldOffset(Offset = "0x38")]
		private string m_valueOnPlay;

		// Token: 0x04017FB1 RID: 98225
		[Token(Token = "0x4017FB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FB2 RID: 98226
		[Token(Token = "0x4017FB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTriggerValue;

		// Token: 0x04017FB3 RID: 98227
		[Token(Token = "0x4017FB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FB4 RID: 98228
		[Token(Token = "0x4017FB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
