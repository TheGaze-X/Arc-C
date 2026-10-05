using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020F3 RID: 8435
	[Token(Token = "0x20020F3")]
	public class Headb2AttackHighlandAOE : Headb2AttackHighlandAOEBase
	{
		// Token: 0x0600CEC7 RID: 52935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEC7")]
		[Address(RVA = "0x3500E70", Offset = "0x34FFA70", VA = "0x183500E70", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEC8")]
		[Address(RVA = "0x35014C0", Offset = "0x35000C0", VA = "0x1835014C0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEC9")]
		[Address(RVA = "0x3500F00", Offset = "0x34FFB00", VA = "0x183500F00", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0600CECA RID: 52938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CECA")]
		[Address(RVA = "0x35015A0", Offset = "0x35001A0", VA = "0x1835015A0")]
		public void StopHeadb2HighlandAOE()
		{
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CECB")]
		[Address(RVA = "0x3501720", Offset = "0x3500320", VA = "0x183501720")]
		private void _StopCoroutine()
		{
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CECC")]
		[Address(RVA = "0x3501640", Offset = "0x3500240", VA = "0x183501640")]
		private IEnumerator _PropagateEffect(List<Tile> initialTiles)
		{
			return null;
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CECD")]
		[Address(RVA = "0x3501870", Offset = "0x3500470", VA = "0x183501870")]
		public Headb2AttackHighlandAOE()
		{
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CECF")]
		[Address(RVA = "0x3501620", Offset = "0x3500220", VA = "0x183501620")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CED0")]
		[Address(RVA = "0x3501630", Offset = "0x3500230", VA = "0x183501630")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CED1")]
		[Address(RVA = "0x34FAC40", Offset = "0x34F9840", VA = "0x1834FAC40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0400DC60 RID: 56416
		[Token(Token = "0x400DC60")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _intervalTime;

		// Token: 0x0400DC61 RID: 56417
		[Token(Token = "0x400DC61")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string _recoverSpBuffKey;

		// Token: 0x0400DC62 RID: 56418
		[Token(Token = "0x400DC62")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private string _recoverSpPerHighlandKey;

		// Token: 0x0400DC63 RID: 56419
		[Token(Token = "0x400DC63")]
		[FieldOffset(Offset = "0x0")]
		private static List<Tile> s_sharedTiles;

		// Token: 0x0400DC64 RID: 56420
		[Token(Token = "0x400DC64")]
		[FieldOffset(Offset = "0x170")]
		private bool m_unlocked;

		// Token: 0x0400DC65 RID: 56421
		[Token(Token = "0x400DC65")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine m_propagationCoroutine;

		// Token: 0x0400DC66 RID: 56422
		[Token(Token = "0x400DC66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DC67 RID: 56423
		[Token(Token = "0x400DC67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400DC68 RID: 56424
		[Token(Token = "0x400DC68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DC69 RID: 56425
		[Token(Token = "0x400DC69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopHeadb2HighlandAOE;

		// Token: 0x0400DC6A RID: 56426
		[Token(Token = "0x400DC6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StopCoroutine;

		// Token: 0x0400DC6B RID: 56427
		[Token(Token = "0x400DC6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PropagateEffect;

		// Token: 0x0400DC6C RID: 56428
		[Token(Token = "0x400DC6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
