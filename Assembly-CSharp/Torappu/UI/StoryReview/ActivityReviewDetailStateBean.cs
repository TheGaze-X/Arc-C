using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004906 RID: 18694
	[Token(Token = "0x2004906")]
	public class ActivityReviewDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x0601C31F RID: 115487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042EE")]
		public TrackPointViewProperty newTrialTrackPointProp
		{
			[Token(Token = "0x601C31F")]
			[Address(RVA = "0x15AB530", Offset = "0x15AA130", VA = "0x1815AB530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x0601C320 RID: 115488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042EF")]
		public TrackPointViewProperty collectTrialTrackPointProp
		{
			[Token(Token = "0x601C320")]
			[Address(RVA = "0x15AB4D0", Offset = "0x15AA0D0", VA = "0x1815AB4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C321 RID: 115489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C321")]
		[Address(RVA = "0x15AB170", Offset = "0x15A9D70", VA = "0x1815AB170")]
		public void UpdateCollectTrialTrackPoint()
		{
		}

		// Token: 0x0601C322 RID: 115490 RVA: 0x000A7850 File Offset: 0x000A5A50
		[Token(Token = "0x601C322")]
		[Address(RVA = "0x15AB020", Offset = "0x15A9C20", VA = "0x1815AB020")]
		public float CalculatePos(string storyTextId)
		{
			return 0f;
		}

		// Token: 0x0601C323 RID: 115491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C323")]
		[Address(RVA = "0x15AB380", Offset = "0x15A9F80", VA = "0x1815AB380")]
		public ActivityReviewDetailStateBean()
		{
		}

		// Token: 0x04024DAD RID: 150957
		[Token(Token = "0x4024DAD")]
		[FieldOffset(Offset = "0x10")]
		public readonly ActivityReviewDetailProperty entryProp;

		// Token: 0x04024DAE RID: 150958
		[Token(Token = "0x4024DAE")]
		[FieldOffset(Offset = "0x18")]
		private TrackPointViewProperty m_newTrialTrackPointProp;

		// Token: 0x04024DAF RID: 150959
		[Token(Token = "0x4024DAF")]
		[FieldOffset(Offset = "0x20")]
		private TrackPointViewProperty m_collectTrialTrackPointProp;

		// Token: 0x04024DB0 RID: 150960
		[Token(Token = "0x4024DB0")]
		[FieldOffset(Offset = "0x28")]
		public bool backToStage;

		// Token: 0x04024DB1 RID: 150961
		[Token(Token = "0x4024DB1")]
		[FieldOffset(Offset = "0x2C")]
		public StoryReviewPage.FastExit fastExit;

		// Token: 0x04024DB2 RID: 150962
		[Token(Token = "0x4024DB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_newTrialTrackPointProp;

		// Token: 0x04024DB3 RID: 150963
		[Token(Token = "0x4024DB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_collectTrialTrackPointProp;

		// Token: 0x04024DB4 RID: 150964
		[Token(Token = "0x4024DB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCollectTrialTrackPoint;

		// Token: 0x04024DB5 RID: 150965
		[Token(Token = "0x4024DB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculatePos;

		// Token: 0x04024DB6 RID: 150966
		[Token(Token = "0x4024DB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
