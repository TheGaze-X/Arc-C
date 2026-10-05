using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023C7 RID: 9159
	[Token(Token = "0x20023C7")]
	public class CacheAtkToBBBehaviour : Projectile.Behaviour
	{
		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x0600E8FB RID: 59643 RVA: 0x00055368 File Offset: 0x00053568
		[Token(Token = "0x17001D7B")]
		private bool increaseByTime
		{
			[Token(Token = "0x600E8FB")]
			[Address(RVA = "0x5F2390", Offset = "0x5F0F90", VA = "0x1805F2390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8FC")]
		[Address(RVA = "0x5F1A20", Offset = "0x5F0620", VA = "0x1805F1A20", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x0600E8FD RID: 59645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8FD")]
		[Address(RVA = "0x5F1E70", Offset = "0x5F0A70", VA = "0x1805F1E70", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8FE")]
		[Address(RVA = "0x5F1F80", Offset = "0x5F0B80", VA = "0x1805F1F80", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8FF")]
		[Address(RVA = "0x5F20A0", Offset = "0x5F0CA0", VA = "0x1805F20A0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E900")]
		[Address(RVA = "0x5F22C0", Offset = "0x5F0EC0", VA = "0x1805F22C0")]
		public CacheAtkToBBBehaviour()
		{
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E901")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E902")]
		[Address(RVA = "0x5EEAE0", Offset = "0x5ED6E0", VA = "0x1805EEAE0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E903")]
		[Address(RVA = "0x5EEB40", Offset = "0x5ED740", VA = "0x1805EEB40")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E904")]
		[Address(RVA = "0x5EEBA0", Offset = "0x5ED7A0", VA = "0x1805EEBA0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040100ED RID: 65773
		[Token(Token = "0x40100ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _increaseByTime;

		// Token: 0x040100EE RID: 65774
		[Token(Token = "0x40100EE")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private bool _onlyIncreaseReached;

		// Token: 0x040100EF RID: 65775
		[Token(Token = "0x40100EF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private float _interval;

		// Token: 0x040100F0 RID: 65776
		[Token(Token = "0x40100F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private float _firstIntervalOffset;

		// Token: 0x040100F1 RID: 65777
		[Token(Token = "0x40100F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private string _intervalKey;

		// Token: 0x040100F2 RID: 65778
		[Token(Token = "0x40100F2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private float _increaseValue;

		// Token: 0x040100F3 RID: 65779
		[Token(Token = "0x40100F3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private string _increaseValueKey;

		// Token: 0x040100F4 RID: 65780
		[Token(Token = "0x40100F4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private float _maxIncreaseValue;

		// Token: 0x040100F5 RID: 65781
		[Token(Token = "0x40100F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("increaseByTime")]
		private string _maxIncreaseValueKey;

		// Token: 0x040100F6 RID: 65782
		[Token(Token = "0x40100F6")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isReached;

		// Token: 0x040100F7 RID: 65783
		[Token(Token = "0x40100F7")]
		[FieldOffset(Offset = "0x68")]
		private FP m_originAtk;

		// Token: 0x040100F8 RID: 65784
		[Token(Token = "0x40100F8")]
		[FieldOffset(Offset = "0x70")]
		private FP m_originAtkScale;

		// Token: 0x040100F9 RID: 65785
		[Token(Token = "0x40100F9")]
		[FieldOffset(Offset = "0x78")]
		private FP m_interval;

		// Token: 0x040100FA RID: 65786
		[Token(Token = "0x40100FA")]
		[FieldOffset(Offset = "0x80")]
		private FP m_increaseValue;

		// Token: 0x040100FB RID: 65787
		[Token(Token = "0x40100FB")]
		[FieldOffset(Offset = "0x88")]
		private FP m_maxIncreaseValue;

		// Token: 0x040100FC RID: 65788
		[Token(Token = "0x40100FC")]
		[FieldOffset(Offset = "0x90")]
		private PeriodicTimer m_timer;

		// Token: 0x040100FD RID: 65789
		[Token(Token = "0x40100FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_increaseByTime;

		// Token: 0x040100FE RID: 65790
		[Token(Token = "0x40100FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040100FF RID: 65791
		[Token(Token = "0x40100FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04010100 RID: 65792
		[Token(Token = "0x4010100")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04010101 RID: 65793
		[Token(Token = "0x4010101")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010102 RID: 65794
		[Token(Token = "0x4010102")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
