using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056AA RID: 22186
	[Token(Token = "0x20056AA")]
	public class RL04DungeonDisasterModule : RoguelikeDungeonModule
	{
		// Token: 0x06020898 RID: 133272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020898")]
		[Address(RVA = "0x1AA6E20", Offset = "0x1AA5A20", VA = "0x181AA6E20", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06020899 RID: 133273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020899")]
		[Address(RVA = "0x1AA7070", Offset = "0x1AA5C70", VA = "0x181AA7070", Slot = "5")]
		protected override void OnReloadDungeon()
		{
		}

		// Token: 0x0602089A RID: 133274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089A")]
		[Address(RVA = "0x1AA70D0", Offset = "0x1AA5CD0", VA = "0x181AA70D0", Slot = "7")]
		protected override void OnStateChanged()
		{
		}

		// Token: 0x0602089B RID: 133275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089B")]
		[Address(RVA = "0x1AA71C0", Offset = "0x1AA5DC0", VA = "0x181AA71C0")]
		private void _OnDisasterPushMsg(object arg)
		{
		}

		// Token: 0x0602089C RID: 133276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089C")]
		[Address(RVA = "0x1AA7870", Offset = "0x1AA6470", VA = "0x181AA7870")]
		private void _TryToNotify(RoguelikeOnDisastersChangedToastArgs msg, RoguelikeModule roguelikeModule, RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0602089D RID: 133277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089D")]
		[Address(RVA = "0x1AA7660", Offset = "0x1AA6260", VA = "0x181AA7660")]
		private void _RefreshEffect()
		{
		}

		// Token: 0x0602089E RID: 133278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089E")]
		[Address(RVA = "0x1AA73C0", Offset = "0x1AA5FC0", VA = "0x181AA73C0")]
		private void _PlayDisasterStartEffect()
		{
		}

		// Token: 0x0602089F RID: 133279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602089F")]
		[Address(RVA = "0x1AA7C80", Offset = "0x1AA6880", VA = "0x181AA7C80")]
		public RL04DungeonDisasterModule()
		{
		}

		// Token: 0x060208A0 RID: 133280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A0")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x060208A1 RID: 133281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A1")]
		[Address(RVA = "0x1AA71A0", Offset = "0x1AA5DA0", VA = "0x181AA71A0")]
		private void <>xLuaBaseProxy_OnReloadDungeon()
		{
		}

		// Token: 0x060208A2 RID: 133282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A2")]
		[Address(RVA = "0x1AA71B0", Offset = "0x1AA5DB0", VA = "0x181AA71B0")]
		private void <>xLuaBaseProxy_OnStateChanged()
		{
		}

		// Token: 0x0402C161 RID: 180577
		[Token(Token = "0x402C161")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL04DisasterToastView _toastPrefab;

		// Token: 0x0402C162 RID: 180578
		[Token(Token = "0x402C162")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL04DungeonDisasterEffect _disasterEffect;

		// Token: 0x0402C163 RID: 180579
		[Token(Token = "0x402C163")]
		[FieldOffset(Offset = "0x38")]
		private RL04DungeonDisasterEffect m_disasterEffect;

		// Token: 0x0402C164 RID: 180580
		[Token(Token = "0x402C164")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C165 RID: 180581
		[Token(Token = "0x402C165")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402C166 RID: 180582
		[Token(Token = "0x402C166")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReloadDungeon;

		// Token: 0x0402C167 RID: 180583
		[Token(Token = "0x402C167")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0402C168 RID: 180584
		[Token(Token = "0x402C168")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDisasterPushMsg;

		// Token: 0x0402C169 RID: 180585
		[Token(Token = "0x402C169")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryToNotify;

		// Token: 0x0402C16A RID: 180586
		[Token(Token = "0x402C16A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshEffect;

		// Token: 0x0402C16B RID: 180587
		[Token(Token = "0x402C16B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayDisasterStartEffect;

		// Token: 0x0402C16C RID: 180588
		[Token(Token = "0x402C16C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
