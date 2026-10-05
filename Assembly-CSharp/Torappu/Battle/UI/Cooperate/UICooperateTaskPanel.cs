using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F6 RID: 13302
	[Token(Token = "0x20033F6")]
	public class UICooperateTaskPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x060153A3 RID: 86947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003252")]
		protected Text stageInfo
		{
			[Token(Token = "0x60153A3")]
			[Address(RVA = "0xDBF320", Offset = "0xDBDF20", VA = "0x180DBF320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x060153A4 RID: 86948 RVA: 0x0008AB88 File Offset: 0x00088D88
		// (set) Token: 0x060153A5 RID: 86949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003253")]
		public bool isBasicStage
		{
			[Token(Token = "0x60153A4")]
			[Address(RVA = "0xDBF1C0", Offset = "0xDBDDC0", VA = "0x180DBF1C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60153A5")]
			[Address(RVA = "0xDBF440", Offset = "0xDBE040", VA = "0x180DBF440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x060153A6 RID: 86950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060153A7 RID: 86951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003254")]
		public UICooperateTaskView taskView
		{
			[Token(Token = "0x60153A6")]
			[Address(RVA = "0xDBF380", Offset = "0xDBDF80", VA = "0x180DBF380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60153A7")]
			[Address(RVA = "0xDBF5B0", Offset = "0xDBE1B0", VA = "0x180DBF5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x060153A8 RID: 86952 RVA: 0x0008ABA0 File Offset: 0x00088DA0
		// (set) Token: 0x060153A9 RID: 86953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003255")]
		private protected ObjectPtr<Buff> registBuff
		{
			[Token(Token = "0x60153A8")]
			[Address(RVA = "0xDBF2A0", Offset = "0xDBDEA0", VA = "0x180DBF2A0")]
			[CompilerGenerated]
			protected get
			{
				return default(ObjectPtr<Buff>);
			}
			[Token(Token = "0x60153A9")]
			[Address(RVA = "0xDBF530", Offset = "0xDBE130", VA = "0x180DBF530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x060153AA RID: 86954 RVA: 0x0008ABB8 File Offset: 0x00088DB8
		// (set) Token: 0x060153AB RID: 86955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003256")]
		private protected ObjectPtr<Buff> progressBuff
		{
			[Token(Token = "0x60153AA")]
			[Address(RVA = "0xDBF220", Offset = "0xDBDE20", VA = "0x180DBF220")]
			[CompilerGenerated]
			protected get
			{
				return default(ObjectPtr<Buff>);
			}
			[Token(Token = "0x60153AB")]
			[Address(RVA = "0xDBF4B0", Offset = "0xDBE0B0", VA = "0x180DBF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x060153AC RID: 86956 RVA: 0x0008ABD0 File Offset: 0x00088DD0
		[Token(Token = "0x17003257")]
		public virtual CoopStageType type
		{
			[Token(Token = "0x60153AC")]
			[Address(RVA = "0xDBF3E0", Offset = "0xDBDFE0", VA = "0x180DBF3E0", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x060153AD RID: 86957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153AD")]
		[Address(RVA = "0xDBDC90", Offset = "0xDBC890", VA = "0x180DBDC90")]
		public void InitTask(ObjectPtr<Buff> buff, GameModeFactory.CooperateGameMode gameMode, CooperateUIPlugin uiPlugin)
		{
		}

		// Token: 0x060153AE RID: 86958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153AE")]
		[Address(RVA = "0xDBDF60", Offset = "0xDBCB60", VA = "0x180DBDF60", Slot = "5")]
		public virtual void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153AF RID: 86959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153AF")]
		[Address(RVA = "0xDBF0A0", Offset = "0xDBDCA0", VA = "0x180DBF0A0")]
		public void UpdateProgeressBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153B0 RID: 86960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B0")]
		[Address(RVA = "0xDBDC30", Offset = "0xDBC830", VA = "0x180DBDC30", Slot = "6")]
		public virtual void GetProgerss(int curScore)
		{
		}

		// Token: 0x060153B1 RID: 86961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B1")]
		[Address(RVA = "0xDBE220", Offset = "0xDBCE20", VA = "0x180DBE220")]
		protected void SetFontSize(FP cnt)
		{
		}

		// Token: 0x060153B2 RID: 86962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B2")]
		[Address(RVA = "0xDBEEE0", Offset = "0xDBDAE0", VA = "0x180DBEEE0", Slot = "7")]
		public virtual void UpdatePanelFixed()
		{
		}

		// Token: 0x060153B3 RID: 86963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B3")]
		[Address(RVA = "0xDBF040", Offset = "0xDBDC40", VA = "0x180DBF040", Slot = "8")]
		public virtual void UpdatePanel()
		{
		}

		// Token: 0x060153B4 RID: 86964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B4")]
		[Address(RVA = "0xDBECF0", Offset = "0xDBD8F0", VA = "0x180DBECF0", Slot = "9")]
		public virtual void StopTimerAnim()
		{
		}

		// Token: 0x060153B5 RID: 86965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B5")]
		[Address(RVA = "0xDBEB20", Offset = "0xDBD720", VA = "0x180DBEB20", Slot = "10")]
		public virtual void StageEndAnim()
		{
		}

		// Token: 0x060153B6 RID: 86966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B6")]
		[Address(RVA = "0xDBD980", Offset = "0xDBC580", VA = "0x180DBD980")]
		protected void AddProgress(bool complete, string progress, string max)
		{
		}

		// Token: 0x060153B7 RID: 86967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B7")]
		[Address(RVA = "0xDBE3A0", Offset = "0xDBCFA0", VA = "0x180DBE3A0")]
		protected void SetProgressSlider(FP progress)
		{
		}

		// Token: 0x060153B8 RID: 86968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B8")]
		[Address(RVA = "0xDBE680", Offset = "0xDBD280", VA = "0x180DBE680")]
		protected void SetProgressSlider(FP progress, FP basicProgress)
		{
		}

		// Token: 0x060153B9 RID: 86969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153B9")]
		[Address(RVA = "0xDBF160", Offset = "0xDBDD60", VA = "0x180DBF160")]
		public UICooperateTaskPanel()
		{
		}

		// Token: 0x040195BD RID: 103869
		[Token(Token = "0x40195BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageInfo;

		// Token: 0x040195BE RID: 103870
		[Token(Token = "0x40195BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _stageInfoFromMap;

		// Token: 0x040195BF RID: 103871
		[Token(Token = "0x40195BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stageNameFromMap;

		// Token: 0x040195C0 RID: 103872
		[Token(Token = "0x40195C0")]
		protected const string STAGE_INFO_FORMAT = "STAGE.";

		// Token: 0x040195C1 RID: 103873
		[Token(Token = "0x40195C1")]
		protected const string SCORE_FORMAT = "{0}/{1}";

		// Token: 0x040195C2 RID: 103874
		[Token(Token = "0x40195C2")]
		protected const string INFO_FORMAT = "{0}{1}";

		// Token: 0x040195C3 RID: 103875
		[Token(Token = "0x40195C3")]
		private const int BASIC_FONT_TOLERANCE = 100;

		// Token: 0x040195C4 RID: 103876
		[Token(Token = "0x40195C4")]
		private const float PROGRESS_COMPARE_OFFSET = 0.0001f;

		// Token: 0x040195C5 RID: 103877
		[Token(Token = "0x40195C5")]
		[FieldOffset(Offset = "0x30")]
		protected GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x040195C6 RID: 103878
		[Token(Token = "0x40195C6")]
		[FieldOffset(Offset = "0x38")]
		protected CooperateUIPlugin m_plugin;

		// Token: 0x040195C7 RID: 103879
		[Token(Token = "0x40195C7")]
		[FieldOffset(Offset = "0x40")]
		protected bool m_isResting;

		// Token: 0x040195CC RID: 103884
		[Token(Token = "0x40195CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageInfo;

		// Token: 0x040195CD RID: 103885
		[Token(Token = "0x40195CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isBasicStage;

		// Token: 0x040195CE RID: 103886
		[Token(Token = "0x40195CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isBasicStage;

		// Token: 0x040195CF RID: 103887
		[Token(Token = "0x40195CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_taskView;

		// Token: 0x040195D0 RID: 103888
		[Token(Token = "0x40195D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_taskView;

		// Token: 0x040195D1 RID: 103889
		[Token(Token = "0x40195D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_registBuff;

		// Token: 0x040195D2 RID: 103890
		[Token(Token = "0x40195D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_registBuff;

		// Token: 0x040195D3 RID: 103891
		[Token(Token = "0x40195D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_progressBuff;

		// Token: 0x040195D4 RID: 103892
		[Token(Token = "0x40195D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_progressBuff;

		// Token: 0x040195D5 RID: 103893
		[Token(Token = "0x40195D5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040195D6 RID: 103894
		[Token(Token = "0x40195D6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitTask;

		// Token: 0x040195D7 RID: 103895
		[Token(Token = "0x40195D7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x040195D8 RID: 103896
		[Token(Token = "0x40195D8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateProgeressBuff;

		// Token: 0x040195D9 RID: 103897
		[Token(Token = "0x40195D9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x040195DA RID: 103898
		[Token(Token = "0x40195DA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetFontSize;

		// Token: 0x040195DB RID: 103899
		[Token(Token = "0x40195DB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x040195DC RID: 103900
		[Token(Token = "0x40195DC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195DD RID: 103901
		[Token(Token = "0x40195DD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StopTimerAnim;

		// Token: 0x040195DE RID: 103902
		[Token(Token = "0x40195DE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_StageEndAnim;

		// Token: 0x040195DF RID: 103903
		[Token(Token = "0x40195DF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddProgress;

		// Token: 0x040195E0 RID: 103904
		[Token(Token = "0x40195E0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetProgressSlider;

		// Token: 0x040195E1 RID: 103905
		[Token(Token = "0x40195E1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1_SetProgressSlider;

		// Token: 0x040195E2 RID: 103906
		[Token(Token = "0x40195E2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
