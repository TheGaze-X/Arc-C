using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023CB RID: 9163
	[Token(Token = "0x20023CB")]
	public class HarpoonProjectile : LinkProjectile
	{
		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x00055470 File Offset: 0x00053670
		[Token(Token = "0x17001D82")]
		public int pullForceLevel
		{
			[Token(Token = "0x600E91A")]
			[Address(RVA = "0x5F2E90", Offset = "0x5F1A90", VA = "0x1805F2E90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E91B RID: 59675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E91B")]
		[Address(RVA = "0x5F2BC0", Offset = "0x5F17C0", VA = "0x1805F2BC0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600E91C RID: 59676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E91C")]
		[Address(RVA = "0x5F2620", Offset = "0x5F1220", VA = "0x1805F2620", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600E91D RID: 59677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E91D")]
		[Address(RVA = "0x5F2930", Offset = "0x5F1530", VA = "0x1805F2930", Slot = "51")]
		protected override void OnProjectileStop()
		{
		}

		// Token: 0x0600E91E RID: 59678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E91E")]
		[Address(RVA = "0x5F2D10", Offset = "0x5F1910", VA = "0x1805F2D10")]
		private void _StopCollideHighLand(object obj)
		{
		}

		// Token: 0x0600E91F RID: 59679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E91F")]
		[Address(RVA = "0x5F2C60", Offset = "0x5F1860", VA = "0x1805F2C60")]
		public void SetPullForceLevel(int level)
		{
		}

		// Token: 0x0600E920 RID: 59680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E920")]
		[Address(RVA = "0x5F2550", Offset = "0x5F1150", VA = "0x1805F2550", Slot = "54")]
		protected override IEnumerator DoLink(Entity rawTarget)
		{
			return null;
		}

		// Token: 0x0600E921 RID: 59681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E921")]
		[Address(RVA = "0x5F2E20", Offset = "0x5F1A20", VA = "0x1805F2E20")]
		public HarpoonProjectile()
		{
		}

		// Token: 0x0600E923 RID: 59683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E923")]
		[Address(RVA = "0x5F2D00", Offset = "0x5F1900", VA = "0x1805F2D00")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600E924 RID: 59684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E924")]
		[Address(RVA = "0x5F2CE0", Offset = "0x5F18E0", VA = "0x1805F2CE0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600E925 RID: 59685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E925")]
		[Address(RVA = "0x5F2CF0", Offset = "0x5F18F0", VA = "0x1805F2CF0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x0600E926 RID: 59686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E926")]
		[Address(RVA = "0x5F2CD0", Offset = "0x5F18D0", VA = "0x1805F2CD0")]
		private IEnumerator <>xLuaBaseProxy_DoLink(Entity P0)
		{
			return null;
		}

		// Token: 0x0401011B RID: 65819
		[Token(Token = "0x401011B")]
		[FieldOffset(Offset = "0x1D0")]
		public float WAIT_CHECK_HIGNLAND;

		// Token: 0x0401011C RID: 65820
		[Token(Token = "0x401011C")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		[Group("Pull")]
		private int _pullForceLevel;

		// Token: 0x0401011D RID: 65821
		[Token(Token = "0x401011D")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Pull")]
		private float _pullSourceOffset;

		// Token: 0x0401011E RID: 65822
		[Token(Token = "0x401011E")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[Group("Pull")]
		private bool _stopAfterPulledBack;

		// Token: 0x0401011F RID: 65823
		[Token(Token = "0x401011F")]
		[FieldOffset(Offset = "0x1DD")]
		[SerializeField]
		[Group("Pull")]
		private bool _ignoreTargetMess;

		// Token: 0x04010120 RID: 65824
		[Token(Token = "0x4010120")]
		[FieldOffset(Offset = "0x1DE")]
		[SerializeField]
		[Group("Pull")]
		private bool _stopWhenCollideWithHighLand;

		// Token: 0x04010121 RID: 65825
		[Token(Token = "0x4010121")]
		[FieldOffset(Offset = "0x1DF")]
		[SerializeField]
		[Group("Pull")]
		private bool _notInfluencedByBlock;

		// Token: 0x04010122 RID: 65826
		[Token(Token = "0x4010122")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("Pull")]
		private bool _pullToPosInBB;

		// Token: 0x04010123 RID: 65827
		[Token(Token = "0x4010123")]
		[FieldOffset(Offset = "0x1E4")]
		private int m_pullForceLevel;

		// Token: 0x04010124 RID: 65828
		[Token(Token = "0x4010124")]
		[FieldOffset(Offset = "0x1E8")]
		private Vector2 m_pullBackDestination;

		// Token: 0x04010125 RID: 65829
		[Token(Token = "0x4010125")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_isPullStopped;

		// Token: 0x04010126 RID: 65830
		[Token(Token = "0x4010126")]
		[FieldOffset(Offset = "0x1F8")]
		private FP m_targetTime;

		// Token: 0x04010127 RID: 65831
		[Token(Token = "0x4010127")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pullForceLevel;

		// Token: 0x04010128 RID: 65832
		[Token(Token = "0x4010128")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04010129 RID: 65833
		[Token(Token = "0x4010129")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401012A RID: 65834
		[Token(Token = "0x401012A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x0401012B RID: 65835
		[Token(Token = "0x401012B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StopCollideHighLand;

		// Token: 0x0401012C RID: 65836
		[Token(Token = "0x401012C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetPullForceLevel;

		// Token: 0x0401012D RID: 65837
		[Token(Token = "0x401012D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoLink;

		// Token: 0x0401012E RID: 65838
		[Token(Token = "0x401012E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
