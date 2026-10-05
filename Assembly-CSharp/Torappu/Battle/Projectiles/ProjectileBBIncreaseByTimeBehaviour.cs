using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A4 RID: 10660
	[Token(Token = "0x20029A4")]
	public class ProjectileBBIncreaseByTimeBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011A6F RID: 72303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6F")]
		[Address(RVA = "0x97FD20", Offset = "0x97E920", VA = "0x18097FD20", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A70 RID: 72304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A70")]
		[Address(RVA = "0x980050", Offset = "0x97EC50", VA = "0x180980050", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A71 RID: 72305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A71")]
		[Address(RVA = "0x980140", Offset = "0x97ED40", VA = "0x180980140", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A72 RID: 72306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A72")]
		[Address(RVA = "0x980440", Offset = "0x97F040", VA = "0x180980440")]
		public ProjectileBBIncreaseByTimeBehaviour()
		{
		}

		// Token: 0x06011A73 RID: 72307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A73")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A74 RID: 72308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A74")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A75 RID: 72309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A75")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013C4D RID: 80973
		[Token(Token = "0x4013C4D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ProjectileBBIncreaseByTimeBehaviour.BBGroup[] _bbGroups;

		// Token: 0x04013C4E RID: 80974
		[Token(Token = "0x4013C4E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _onlyIncreaseReached;

		// Token: 0x04013C4F RID: 80975
		[Token(Token = "0x4013C4F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _interval;

		// Token: 0x04013C50 RID: 80976
		[Token(Token = "0x4013C50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _intervalKey;

		// Token: 0x04013C51 RID: 80977
		[Token(Token = "0x4013C51")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _syncProjectileScaleBbKey;

		// Token: 0x04013C52 RID: 80978
		[Token(Token = "0x4013C52")]
		[FieldOffset(Offset = "0x48")]
		private PeriodicTimer m_timer;

		// Token: 0x04013C53 RID: 80979
		[Token(Token = "0x4013C53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C54 RID: 80980
		[Token(Token = "0x4013C54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013C55 RID: 80981
		[Token(Token = "0x4013C55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C56 RID: 80982
		[Token(Token = "0x4013C56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029A5 RID: 10661
		[Token(Token = "0x20029A5")]
		[Serializable]
		public class BBGroup
		{
			// Token: 0x06011A76 RID: 72310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011A76")]
			[Address(RVA = "0x97FC00", Offset = "0x97E800", VA = "0x18097FC00")]
			public void InitGroup(Blackboard blackboard)
			{
			}

			// Token: 0x06011A77 RID: 72311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011A77")]
			[Address(RVA = "0x97FB20", Offset = "0x97E720", VA = "0x18097FB20")]
			public void IncreaseBBValue(Blackboard blackboard)
			{
			}

			// Token: 0x06011A78 RID: 72312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011A78")]
			[Address(RVA = "0x97FCF0", Offset = "0x97E8F0", VA = "0x18097FCF0")]
			public void ResetBlackboard(Blackboard blackboard)
			{
			}

			// Token: 0x06011A79 RID: 72313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011A79")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BBGroup()
			{
			}

			// Token: 0x04013C57 RID: 80983
			[Token(Token = "0x4013C57")]
			[FieldOffset(Offset = "0x10")]
			public string blackboardKey;

			// Token: 0x04013C58 RID: 80984
			[Token(Token = "0x4013C58")]
			[FieldOffset(Offset = "0x18")]
			public string increaseValueKey;

			// Token: 0x04013C59 RID: 80985
			[Token(Token = "0x4013C59")]
			[FieldOffset(Offset = "0x20")]
			public string maxValueKey;

			// Token: 0x04013C5A RID: 80986
			[Token(Token = "0x4013C5A")]
			[FieldOffset(Offset = "0x28")]
			private FP m_increaseValue;

			// Token: 0x04013C5B RID: 80987
			[Token(Token = "0x4013C5B")]
			[FieldOffset(Offset = "0x30")]
			private FP m_maxValue;

			// Token: 0x04013C5C RID: 80988
			[Token(Token = "0x4013C5C")]
			[FieldOffset(Offset = "0x38")]
			private FP m_curValue;

			// Token: 0x04013C5D RID: 80989
			[Token(Token = "0x4013C5D")]
			[FieldOffset(Offset = "0x40")]
			private FP m_originValue;
		}
	}
}
