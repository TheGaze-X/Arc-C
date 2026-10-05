using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020F7 RID: 8439
	[Token(Token = "0x20020F7")]
	public class Headb2S3HighlandAOE : Headb2AttackHighlandAOEBase
	{
		// Token: 0x0600CEE9 RID: 52969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE9")]
		[Address(RVA = "0x3501940", Offset = "0x3500540", VA = "0x183501940", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEEA")]
		[Address(RVA = "0x3502140", Offset = "0x3500D40", VA = "0x183502140", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600CEEB RID: 52971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEEB")]
		[Address(RVA = "0x3501B00", Offset = "0x3500700", VA = "0x183501B00", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0600CEEC RID: 52972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEEC")]
		[Address(RVA = "0x35022B0", Offset = "0x3500EB0", VA = "0x1835022B0")]
		public void StopHeadb2HighlandAOE()
		{
		}

		// Token: 0x0600CEED RID: 52973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEED")]
		[Address(RVA = "0x3502600", Offset = "0x3501200", VA = "0x183502600")]
		private void _DoDefaultAOE(Vector2 AOECenterMapPos)
		{
		}

		// Token: 0x0600CEEE RID: 52974 RVA: 0x0004AB80 File Offset: 0x00048D80
		[Token(Token = "0x600CEEE")]
		[Address(RVA = "0x3502330", Offset = "0x3500F30", VA = "0x183502330")]
		private bool _CheckTargetAlreadyInCastTargetList(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x0004AB98 File Offset: 0x00048D98
		[Token(Token = "0x600CEEF")]
		[Address(RVA = "0x3502AF0", Offset = "0x35016F0", VA = "0x183502AF0")]
		private bool _TryGetSplashEffectKey(int index, out string effectKey)
		{
			return default(bool);
		}

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEF0")]
		[Address(RVA = "0x3502A40", Offset = "0x3501640", VA = "0x183502A40")]
		private void _StopCoroutine()
		{
		}

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CEF1")]
		[Address(RVA = "0x3502940", Offset = "0x3501540", VA = "0x183502940")]
		private IEnumerator _PropagateEffect(List<Tile> initialTiles, int times)
		{
			return null;
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEF2")]
		[Address(RVA = "0x3502CC0", Offset = "0x35018C0", VA = "0x183502CC0")]
		public Headb2S3HighlandAOE()
		{
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEF4")]
		[Address(RVA = "0x3501620", Offset = "0x3500220", VA = "0x183501620")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEF5")]
		[Address(RVA = "0x3501630", Offset = "0x3500230", VA = "0x183501630")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEF6")]
		[Address(RVA = "0x34FAC40", Offset = "0x34F9840", VA = "0x1834FAC40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0400DC90 RID: 56464
		[Token(Token = "0x400DC90")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _intervalTime;

		// Token: 0x0400DC91 RID: 56465
		[Token(Token = "0x400DC91")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private float _firstIntervalTime;

		// Token: 0x0400DC92 RID: 56466
		[Token(Token = "0x400DC92")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private TargetSelector _aoeSelector;

		// Token: 0x0400DC93 RID: 56467
		[Token(Token = "0x400DC93")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<string> _groundSplashEffects;

		// Token: 0x0400DC94 RID: 56468
		[Token(Token = "0x400DC94")]
		[FieldOffset(Offset = "0x170")]
		private MultiMeleeAttackWithSplashDmg m_headb2S3Ability;

		// Token: 0x0400DC95 RID: 56469
		[Token(Token = "0x400DC95")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine m_propagationCoroutine;

		// Token: 0x0400DC96 RID: 56470
		[Token(Token = "0x400DC96")]
		[FieldOffset(Offset = "0x180")]
		private bool m_isRunning;

		// Token: 0x0400DC97 RID: 56471
		[Token(Token = "0x400DC97")]
		[FieldOffset(Offset = "0x0")]
		private static List<Tile> s_sharedTiles;

		// Token: 0x0400DC98 RID: 56472
		[Token(Token = "0x400DC98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DC99 RID: 56473
		[Token(Token = "0x400DC99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400DC9A RID: 56474
		[Token(Token = "0x400DC9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DC9B RID: 56475
		[Token(Token = "0x400DC9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopHeadb2HighlandAOE;

		// Token: 0x0400DC9C RID: 56476
		[Token(Token = "0x400DC9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoDefaultAOE;

		// Token: 0x0400DC9D RID: 56477
		[Token(Token = "0x400DC9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckTargetAlreadyInCastTargetList;

		// Token: 0x0400DC9E RID: 56478
		[Token(Token = "0x400DC9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGetSplashEffectKey;

		// Token: 0x0400DC9F RID: 56479
		[Token(Token = "0x400DC9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopCoroutine;

		// Token: 0x0400DCA0 RID: 56480
		[Token(Token = "0x400DCA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PropagateEffect;

		// Token: 0x0400DCA1 RID: 56481
		[Token(Token = "0x400DCA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
