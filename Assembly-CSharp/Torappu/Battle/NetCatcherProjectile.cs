using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023D4 RID: 9172
	[Token(Token = "0x20023D4")]
	public class NetCatcherProjectile : LinkProjectile
	{
		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600E99B RID: 59803 RVA: 0x00055878 File Offset: 0x00053A78
		[Token(Token = "0x17001D9F")]
		public Vector2 firstPullBackDestination
		{
			[Token(Token = "0x600E99B")]
			[Address(RVA = "0x5F8060", Offset = "0x5F6C60", VA = "0x1805F8060")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x00055890 File Offset: 0x00053A90
		[Token(Token = "0x17001DA0")]
		public bool isFirstPart
		{
			[Token(Token = "0x600E99C")]
			[Address(RVA = "0x5F80D0", Offset = "0x5F6CD0", VA = "0x1805F80D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x0600E99D RID: 59805 RVA: 0x000558A8 File Offset: 0x00053AA8
		[Token(Token = "0x17001DA1")]
		public int pullForceLevel
		{
			[Token(Token = "0x600E99D")]
			[Address(RVA = "0x5F8130", Offset = "0x5F6D30", VA = "0x1805F8130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E99E")]
		[Address(RVA = "0x5F75C0", Offset = "0x5F61C0", VA = "0x1805F75C0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600E99F RID: 59807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E99F")]
		[Address(RVA = "0x5F6DF0", Offset = "0x5F59F0", VA = "0x1805F6DF0", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600E9A0 RID: 59808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A0")]
		[Address(RVA = "0x5F73F0", Offset = "0x5F5FF0", VA = "0x1805F73F0", Slot = "51")]
		protected override void OnProjectileStop()
		{
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A1")]
		[Address(RVA = "0x5F79D0", Offset = "0x5F65D0", VA = "0x1805F79D0")]
		public void SetPullForceLevel(int level)
		{
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x000558C0 File Offset: 0x00053AC0
		[Token(Token = "0x600E9A2")]
		[Address(RVA = "0x5F6730", Offset = "0x5F5330", VA = "0x1805F6730", Slot = "44")]
		protected override bool ExtraCheckToFinish()
		{
			return default(bool);
		}

		// Token: 0x0600E9A3 RID: 59811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A3")]
		[Address(RVA = "0x5F7ED0", Offset = "0x5F6AD0", VA = "0x1805F7ED0")]
		private void _StopForceOnEnemy(Entity rawTarget)
		{
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A4")]
		[Address(RVA = "0x5F7B70", Offset = "0x5F6770", VA = "0x1805F7B70")]
		protected void StartSecondPartProjectile()
		{
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9A5")]
		[Address(RVA = "0x5F6660", Offset = "0x5F5260", VA = "0x1805F6660", Slot = "54")]
		protected override IEnumerator DoLink(Entity rawTarget)
		{
			return null;
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9A6")]
		[Address(RVA = "0x5F6590", Offset = "0x5F5190", VA = "0x1805F6590")]
		protected IEnumerator DoLink_SecondPart(Entity rawTarget)
		{
			return null;
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A7")]
		[Address(RVA = "0x5F7A40", Offset = "0x5F6640", VA = "0x1805F7A40")]
		protected void SetPullTime(Enemy target, float pullTime)
		{
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A8")]
		[Address(RVA = "0x5F7630", Offset = "0x5F6230", VA = "0x1805F7630", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9A9")]
		[Address(RVA = "0x5F7D70", Offset = "0x5F6970", VA = "0x1805F7D70")]
		private IEnumerator _DoPull(Enemy target, Vector2 destination, float duration, Func<bool> pullCond, bool stopAfterPulledBack)
		{
			return null;
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9AA")]
		[Address(RVA = "0x5F6A10", Offset = "0x5F5610", VA = "0x1805F6A10")]
		public Enemy GetEffectFollowTarget()
		{
			return null;
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9AB")]
		[Address(RVA = "0x5F7FF0", Offset = "0x5F6BF0", VA = "0x1805F7FF0")]
		public NetCatcherProjectile()
		{
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9AF")]
		[Address(RVA = "0x5F2D00", Offset = "0x5F1900", VA = "0x1805F2D00")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600E9B0 RID: 59824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9B0")]
		[Address(RVA = "0x5F2CE0", Offset = "0x5F18E0", VA = "0x1805F2CE0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9B1")]
		[Address(RVA = "0x5F2CF0", Offset = "0x5F18F0", VA = "0x1805F2CF0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x00055908 File Offset: 0x00053B08
		[Token(Token = "0x600E9B2")]
		[Address(RVA = "0x5F7D00", Offset = "0x5F6900", VA = "0x1805F7D00")]
		private bool <>xLuaBaseProxy_ExtraCheckToFinish()
		{
			return default(bool);
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9B3")]
		[Address(RVA = "0x5F2CD0", Offset = "0x5F18D0", VA = "0x1805F2CD0")]
		private IEnumerator <>xLuaBaseProxy_DoLink(Entity P0)
		{
			return null;
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9B4")]
		[Address(RVA = "0x5F7D60", Offset = "0x5F6960", VA = "0x1805F7D60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040101BE RID: 65982
		[Token(Token = "0x40101BE")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Pull", 1)]
		private string _blackboardPrefix;

		// Token: 0x040101BF RID: 65983
		[Token(Token = "0x40101BF")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Pull", 1)]
		private int _pullForceLevel;

		// Token: 0x040101C0 RID: 65984
		[Token(Token = "0x40101C0")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[Group("First Pull", 2)]
		private float _firstPartTime;

		// Token: 0x040101C1 RID: 65985
		[Token(Token = "0x40101C1")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("First Pull")]
		private bool _stopAfterFirstPulledBack;

		// Token: 0x040101C2 RID: 65986
		[Token(Token = "0x40101C2")]
		[FieldOffset(Offset = "0x1E1")]
		[SerializeField]
		[Group("First Pull")]
		private bool _allowInputTargetDead;

		// Token: 0x040101C3 RID: 65987
		[Token(Token = "0x40101C3")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		[Group("Second Pull", 3)]
		private float _secondPullSourceOffset;

		// Token: 0x040101C4 RID: 65988
		[Token(Token = "0x40101C4")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("Second Pull")]
		private float _secondPartTime;

		// Token: 0x040101C5 RID: 65989
		[Token(Token = "0x40101C5")]
		[FieldOffset(Offset = "0x1EC")]
		[SerializeField]
		[Group("Second Pull")]
		private bool _stopAfterSecondPulledBack;

		// Token: 0x040101C6 RID: 65990
		[Token(Token = "0x40101C6")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[Group("Second Pull")]
		private float _maxRandomOffset;

		// Token: 0x040101C7 RID: 65991
		[Token(Token = "0x40101C7")]
		[FieldOffset(Offset = "0x1F4")]
		private int m_pullForceLevel;

		// Token: 0x040101C8 RID: 65992
		[Token(Token = "0x40101C8")]
		[FieldOffset(Offset = "0x1F8")]
		private Vector2 m_firstPullBackDestination;

		// Token: 0x040101C9 RID: 65993
		[Token(Token = "0x40101C9")]
		[FieldOffset(Offset = "0x200")]
		private Vector2 m_secondPullBackDestination;

		// Token: 0x040101CA RID: 65994
		[Token(Token = "0x40101CA")]
		[FieldOffset(Offset = "0x208")]
		private Vector2 m_lastInputTargetMapPosition;

		// Token: 0x040101CB RID: 65995
		[Token(Token = "0x40101CB")]
		[FieldOffset(Offset = "0x210")]
		protected bool m_isFirstPart;

		// Token: 0x040101CC RID: 65996
		[Token(Token = "0x40101CC")]
		[FieldOffset(Offset = "0x211")]
		protected bool m_isPullStopped;

		// Token: 0x040101CD RID: 65997
		[Token(Token = "0x40101CD")]
		private const int FILTER_TOO_HEAVY_MASS_LEVEL = 3;

		// Token: 0x040101CE RID: 65998
		[Token(Token = "0x40101CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_firstPullBackDestination;

		// Token: 0x040101CF RID: 65999
		[Token(Token = "0x40101CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isFirstPart;

		// Token: 0x040101D0 RID: 66000
		[Token(Token = "0x40101D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pullForceLevel;

		// Token: 0x040101D1 RID: 66001
		[Token(Token = "0x40101D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x040101D2 RID: 66002
		[Token(Token = "0x40101D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040101D3 RID: 66003
		[Token(Token = "0x40101D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x040101D4 RID: 66004
		[Token(Token = "0x40101D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetPullForceLevel;

		// Token: 0x040101D5 RID: 66005
		[Token(Token = "0x40101D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExtraCheckToFinish;

		// Token: 0x040101D6 RID: 66006
		[Token(Token = "0x40101D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopForceOnEnemy;

		// Token: 0x040101D7 RID: 66007
		[Token(Token = "0x40101D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_StartSecondPartProjectile;

		// Token: 0x040101D8 RID: 66008
		[Token(Token = "0x40101D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoLink;

		// Token: 0x040101D9 RID: 66009
		[Token(Token = "0x40101D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoLink_SecondPart;

		// Token: 0x040101DA RID: 66010
		[Token(Token = "0x40101DA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetPullTime;

		// Token: 0x040101DB RID: 66011
		[Token(Token = "0x40101DB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040101DC RID: 66012
		[Token(Token = "0x40101DC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoPull;

		// Token: 0x040101DD RID: 66013
		[Token(Token = "0x40101DD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetEffectFollowTarget;

		// Token: 0x040101DE RID: 66014
		[Token(Token = "0x40101DE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
