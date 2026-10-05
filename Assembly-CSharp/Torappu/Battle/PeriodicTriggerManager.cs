using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002340 RID: 9024
	[Token(Token = "0x2002340")]
	public class PeriodicTriggerManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E42B RID: 58411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42B")]
		[Address(RVA = "0x58EE80", Offset = "0x58DA80", VA = "0x18058EE80", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E42C RID: 58412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42C")]
		[Address(RVA = "0x58EE20", Offset = "0x58DA20", VA = "0x18058EE20", Slot = "16")]
		public virtual void InitCandidates()
		{
		}

		// Token: 0x0600E42D RID: 58413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42D")]
		[Address(RVA = "0x58F0C0", Offset = "0x58DCC0", VA = "0x18058F0C0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42E")]
		[Address(RVA = "0x58F430", Offset = "0x58E030", VA = "0x18058F430", Slot = "17")]
		public virtual void UpdateCandidates()
		{
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42F")]
		[Address(RVA = "0x58F250", Offset = "0x58DE50", VA = "0x18058F250", Slot = "18")]
		public virtual void OnTrigger()
		{
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E430")]
		[Address(RVA = "0x58EDC0", Offset = "0x58D9C0", VA = "0x18058EDC0", Slot = "19")]
		public virtual void FilterTargets()
		{
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E431")]
		[Address(RVA = "0x58ED10", Offset = "0x58D910", VA = "0x18058ED10", Slot = "20")]
		public virtual void EmitEvent(string value)
		{
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E432")]
		[Address(RVA = "0x58F490", Offset = "0x58E090", VA = "0x18058F490")]
		public PeriodicTriggerManager()
		{
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E434")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E435")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400FB43 RID: 64323
		[Token(Token = "0x400FB43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _triggerEvent;

		// Token: 0x0400FB44 RID: 64324
		[Token(Token = "0x400FB44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _defaultInterval;

		// Token: 0x0400FB45 RID: 64325
		[Token(Token = "0x400FB45")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _maxTarget;

		// Token: 0x0400FB46 RID: 64326
		[Token(Token = "0x400FB46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _waitFirstPeriod;

		// Token: 0x0400FB47 RID: 64327
		[Token(Token = "0x400FB47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _triggerEventBB;

		// Token: 0x0400FB48 RID: 64328
		[Token(Token = "0x400FB48")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _delayTriggerIntervalBB;

		// Token: 0x0400FB49 RID: 64329
		[Token(Token = "0x400FB49")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _delayTriggerEventBB;

		// Token: 0x0400FB4A RID: 64330
		[Token(Token = "0x400FB4A")]
		[FieldOffset(Offset = "0x58")]
		protected readonly List<Tile> candidateTiles;

		// Token: 0x0400FB4B RID: 64331
		[Token(Token = "0x400FB4B")]
		[FieldOffset(Offset = "0x60")]
		protected readonly List<Tile> targetTiles;

		// Token: 0x0400FB4C RID: 64332
		[Token(Token = "0x400FB4C")]
		[FieldOffset(Offset = "0x68")]
		protected readonly List<Entity> candidateEntities;

		// Token: 0x0400FB4D RID: 64333
		[Token(Token = "0x400FB4D")]
		[FieldOffset(Offset = "0x70")]
		protected readonly List<Entity> targetEntities;

		// Token: 0x0400FB4E RID: 64334
		[Token(Token = "0x400FB4E")]
		[FieldOffset(Offset = "0x78")]
		protected int maxTarget;

		// Token: 0x0400FB4F RID: 64335
		[Token(Token = "0x400FB4F")]
		[FieldOffset(Offset = "0x80")]
		private readonly PeriodicTimer m_intervalTicker;

		// Token: 0x0400FB50 RID: 64336
		[Token(Token = "0x400FB50")]
		[FieldOffset(Offset = "0x88")]
		private float m_interval;

		// Token: 0x0400FB51 RID: 64337
		[Token(Token = "0x400FB51")]
		[FieldOffset(Offset = "0x90")]
		private string m_triggerEvent;

		// Token: 0x0400FB52 RID: 64338
		[Token(Token = "0x400FB52")]
		[FieldOffset(Offset = "0x98")]
		private float m_delayTriggerInterval;

		// Token: 0x0400FB53 RID: 64339
		[Token(Token = "0x400FB53")]
		[FieldOffset(Offset = "0xA0")]
		private string m_delayTriggerEvent;

		// Token: 0x0400FB54 RID: 64340
		[Token(Token = "0x400FB54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FB55 RID: 64341
		[Token(Token = "0x400FB55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitCandidates;

		// Token: 0x0400FB56 RID: 64342
		[Token(Token = "0x400FB56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FB57 RID: 64343
		[Token(Token = "0x400FB57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateCandidates;

		// Token: 0x0400FB58 RID: 64344
		[Token(Token = "0x400FB58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FB59 RID: 64345
		[Token(Token = "0x400FB59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FilterTargets;

		// Token: 0x0400FB5A RID: 64346
		[Token(Token = "0x400FB5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EmitEvent;

		// Token: 0x0400FB5B RID: 64347
		[Token(Token = "0x400FB5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
