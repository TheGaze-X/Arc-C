using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A1F RID: 31263
	[Token(Token = "0x2007A1F")]
	public class Act13sideMissionViewModelPlugin : TemplateActivityMissionViewModelPlugin
	{
		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x0602BD01 RID: 179457 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD00 RID: 179456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066B9")]
		public string orgId
		{
			[Token(Token = "0x602BD01")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x602BD00")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x0602BD02 RID: 179458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD02")]
		[Address(RVA = "0x27BB8E0", Offset = "0x27BA4E0", VA = "0x1827BB8E0", Slot = "4")]
		public void SetContext(TemplateActivityMissionGroupViewModel viewModel)
		{
		}

		// Token: 0x0602BD03 RID: 179459 RVA: 0x000DD4D8 File Offset: 0x000DB6D8
		[Token(Token = "0x602BD03")]
		[Address(RVA = "0x27BB580", Offset = "0x27BA180", VA = "0x1827BB580", Slot = "5")]
		public bool CheckMissionShowAbleFlag(int missionIndex)
		{
			return default(bool);
		}

		// Token: 0x0602BD04 RID: 179460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BD04")]
		[Address(RVA = "0x27BB770", Offset = "0x27BA370", VA = "0x1827BB770")]
		public TemplateMissionViewModel GetTargetViewModel(string groupId)
		{
			return null;
		}

		// Token: 0x0602BD05 RID: 179461 RVA: 0x000DD4F0 File Offset: 0x000DB6F0
		[Token(Token = "0x602BD05")]
		[Address(RVA = "0x27BB650", Offset = "0x27BA250", VA = "0x1827BB650")]
		public bool GetCanGetMissionByOrg(string orgId)
		{
			return default(bool);
		}

		// Token: 0x0602BD06 RID: 179462 RVA: 0x000DD508 File Offset: 0x000DB708
		[Token(Token = "0x602BD06")]
		[Address(RVA = "0x27BB640", Offset = "0x27BA240", VA = "0x1827BB640", Slot = "6")]
		public bool Compare(TemplateMissionViewModel a, TemplateMissionViewModel b, out int result)
		{
			return default(bool);
		}

		// Token: 0x0602BD07 RID: 179463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD07")]
		[Address(RVA = "0x27BB8A0", Offset = "0x27BA4A0", VA = "0x1827BB8A0")]
		public void OnChangeOrg(string orgId_)
		{
		}

		// Token: 0x0602BD08 RID: 179464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD08")]
		[Address(RVA = "0x27BB940", Offset = "0x27BA540", VA = "0x1827BB940")]
		public Act13sideMissionViewModelPlugin()
		{
		}

		// Token: 0x0403F645 RID: 259653
		[Token(Token = "0x403F645")]
		private const string INIT_ORG_PARAM = "kazimierz";

		// Token: 0x0403F646 RID: 259654
		[Token(Token = "0x403F646")]
		[FieldOffset(Offset = "0x10")]
		private TemplateActivityMissionGroupViewModel m_context;

		// Token: 0x0403F647 RID: 259655
		[Token(Token = "0x403F647")]
		[FieldOffset(Offset = "0x18")]
		private string m_currentSelectOrg;

		// Token: 0x0403F648 RID: 259656
		[Token(Token = "0x403F648")]
		[FieldOffset(Offset = "0x20")]
		public string missionGroupId;

		// Token: 0x02007A20 RID: 31264
		[Token(Token = "0x2007A20")]
		public enum MissionType
		{
			// Token: 0x0403F64A RID: 259658
			[Token(Token = "0x403F64A")]
			MISSION,
			// Token: 0x0403F64B RID: 259659
			[Token(Token = "0x403F64B")]
			EMPTY,
			// Token: 0x0403F64C RID: 259660
			[Token(Token = "0x403F64C")]
			ALLFINISH
		}
	}
}
