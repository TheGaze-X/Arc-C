using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003213 RID: 12819
	[Token(Token = "0x2003213")]
	public class BuffsKeyAnimatorTrigger : AnimatorTriggerSource
	{
		// Token: 0x06014573 RID: 83315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014573")]
		[Address(RVA = "0xC86740", Offset = "0xC85340", VA = "0x180C86740", Slot = "10")]
		public override string GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014574 RID: 83316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014574")]
		[Address(RVA = "0xC86800", Offset = "0xC85400", VA = "0x180C86800", Slot = "11")]
		public override string GetValue()
		{
			return null;
		}

		// Token: 0x06014575 RID: 83317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014575")]
		[Address(RVA = "0xC86A90", Offset = "0xC85690", VA = "0x180C86A90")]
		public BuffsKeyAnimatorTrigger()
		{
		}

		// Token: 0x06014576 RID: 83318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014576")]
		[Address(RVA = "0xC81610", Offset = "0xC80210", VA = "0x180C81610")]
		private string <>xLuaBaseProxy_GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x06014577 RID: 83319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014577")]
		[Address(RVA = "0xC81670", Offset = "0xC80270", VA = "0x180C81670")]
		private string <>xLuaBaseProxy_GetValue()
		{
			return null;
		}

		// Token: 0x04017FC4 RID: 98244
		[Token(Token = "0x4017FC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffsKeyAnimatorTrigger.TriggerKeyPair[] _triggerKeyPairs;

		// Token: 0x04017FC5 RID: 98245
		[Token(Token = "0x4017FC5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _defaultVal;

		// Token: 0x04017FC6 RID: 98246
		[Token(Token = "0x4017FC6")]
		[FieldOffset(Offset = "0x30")]
		private BuffsKeyAnimatorTrigger.TriggerKeyPair m_cachedTriggerKeyPair;

		// Token: 0x04017FC7 RID: 98247
		[Token(Token = "0x4017FC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FC8 RID: 98248
		[Token(Token = "0x4017FC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FC9 RID: 98249
		[Token(Token = "0x4017FC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003214 RID: 12820
		[Token(Token = "0x2003214")]
		[Serializable]
		public struct TriggerKeyPair
		{
			// Token: 0x04017FCA RID: 98250
			[Token(Token = "0x4017FCA")]
			[FieldOffset(Offset = "0x0")]
			public string triggerKey;

			// Token: 0x04017FCB RID: 98251
			[Token(Token = "0x4017FCB")]
			[FieldOffset(Offset = "0x8")]
			public string buffKey;
		}
	}
}
