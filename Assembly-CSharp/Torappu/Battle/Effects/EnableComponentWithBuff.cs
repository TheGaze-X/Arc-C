using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003226 RID: 12838
	[Token(Token = "0x2003226")]
	public class EnableComponentWithBuff : Effect.Behaviour
	{
		// Token: 0x060145CE RID: 83406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CE")]
		[Address(RVA = "0xC9B8A0", Offset = "0xC9A4A0", VA = "0x180C9B8A0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145CF RID: 83407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CF")]
		[Address(RVA = "0xC9B910", Offset = "0xC9A510", VA = "0x180C9B910", Slot = "9")]
		public override void OnPostImport()
		{
		}

		// Token: 0x060145D0 RID: 83408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D0")]
		[Address(RVA = "0xC9BA40", Offset = "0xC9A640", VA = "0x180C9BA40")]
		private void Update()
		{
		}

		// Token: 0x060145D1 RID: 83409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D1")]
		[Address(RVA = "0xC9BAA0", Offset = "0xC9A6A0", VA = "0x180C9BAA0")]
		private void _CheckBuffs()
		{
		}

		// Token: 0x060145D2 RID: 83410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D2")]
		[Address(RVA = "0xC9BBF0", Offset = "0xC9A7F0", VA = "0x180C9BBF0")]
		public EnableComponentWithBuff()
		{
		}

		// Token: 0x060145D3 RID: 83411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D3")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145D4 RID: 83412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D4")]
		[Address(RVA = "0xC99520", Offset = "0xC98120", VA = "0x180C99520")]
		private void <>xLuaBaseProxy_OnPostImport()
		{
		}

		// Token: 0x04018061 RID: 98401
		[Token(Token = "0x4018061")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnableComponentWithBuff.buffWithComp[] _buffWithComps;

		// Token: 0x04018062 RID: 98402
		[Token(Token = "0x4018062")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018063 RID: 98403
		[Token(Token = "0x4018063")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostImport;

		// Token: 0x04018064 RID: 98404
		[Token(Token = "0x4018064")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018065 RID: 98405
		[Token(Token = "0x4018065")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckBuffs;

		// Token: 0x04018066 RID: 98406
		[Token(Token = "0x4018066")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003227 RID: 12839
		[Token(Token = "0x2003227")]
		[Serializable]
		public struct buffWithComp
		{
			// Token: 0x04018067 RID: 98407
			[Token(Token = "0x4018067")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public GameObject comp;

			// Token: 0x04018068 RID: 98408
			[Token(Token = "0x4018068")]
			[FieldOffset(Offset = "0x8")]
			public string objectName;

			// Token: 0x04018069 RID: 98409
			[Token(Token = "0x4018069")]
			[FieldOffset(Offset = "0x10")]
			public string buffKey;
		}
	}
}
