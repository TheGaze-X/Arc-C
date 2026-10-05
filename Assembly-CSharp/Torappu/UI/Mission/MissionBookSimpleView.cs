using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200489D RID: 18589
	[Token(Token = "0x200489D")]
	public class MissionBookSimpleView : MissionBookViewBase
	{
		// Token: 0x0601C0CA RID: 114890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0CA")]
		[Address(RVA = "0x1569840", Offset = "0x1568440", VA = "0x181569840")]
		public void RefreshFlag(MissionType missionType = MissionType.UNKNOWN)
		{
		}

		// Token: 0x0601C0CB RID: 114891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0CB")]
		[Address(RVA = "0x1569690", Offset = "0x1568290", VA = "0x181569690", Slot = "5")]
		public override void Init(MissionModel stateBean, MissionPageType? initMissionPage)
		{
		}

		// Token: 0x0601C0CC RID: 114892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0CC")]
		[Address(RVA = "0x1569CA0", Offset = "0x15688A0", VA = "0x181569CA0")]
		private void _Init(MissionModel stateBean)
		{
		}

		// Token: 0x0601C0CD RID: 114893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0CD")]
		[Address(RVA = "0x1569540", Offset = "0x1568140", VA = "0x181569540")]
		private static IEnumerable<MissionViewModel> EnumMissionViewModel(MissionPageType pageType, MissionModel model)
		{
			return null;
		}

		// Token: 0x0601C0CE RID: 114894 RVA: 0x000A70E8 File Offset: 0x000A52E8
		[Token(Token = "0x601C0CE")]
		[Address(RVA = "0x156A0F0", Offset = "0x1568CF0", VA = "0x18156A0F0")]
		private bool _NeedShowTabTrackPoint(MissionPageType pageType, MissionModel model)
		{
			return default(bool);
		}

		// Token: 0x0601C0CF RID: 114895 RVA: 0x000A7100 File Offset: 0x000A5300
		[Token(Token = "0x601C0CF")]
		[Address(RVA = "0x156A040", Offset = "0x1568C40", VA = "0x18156A040")]
		private bool _IsStartMissionGroupComplete(MissionPageType pageType, MissionModel model)
		{
			return default(bool);
		}

		// Token: 0x0601C0D0 RID: 114896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D0")]
		[Address(RVA = "0x156A660", Offset = "0x1569260", VA = "0x18156A660")]
		private void _RefreshTagPageAvailOfType(MissionType type)
		{
		}

		// Token: 0x0601C0D1 RID: 114897 RVA: 0x000A7118 File Offset: 0x000A5318
		[Token(Token = "0x601C0D1")]
		[Address(RVA = "0x1569610", Offset = "0x1568210", VA = "0x181569610")]
		public static bool HasNewSOCharTag()
		{
			return default(bool);
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D2")]
		[Address(RVA = "0x15697C0", Offset = "0x15683C0", VA = "0x1815697C0")]
		public static void MarkSOCharViewed()
		{
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D3")]
		[Address(RVA = "0x1569160", Offset = "0x1567D60", VA = "0x181569160", Slot = "6")]
		public override void DealWithState(int index, bool isInit)
		{
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0D4")]
		[Address(RVA = "0x1569B80", Offset = "0x1568780", VA = "0x181569B80")]
		private static string _ConvertTypeToTabString(MissionPageType type)
		{
			return null;
		}

		// Token: 0x0601C0D5 RID: 114901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D5")]
		[Address(RVA = "0x156A920", Offset = "0x1569520", VA = "0x18156A920")]
		public MissionBookSimpleView()
		{
		}

		// Token: 0x0601C0D6 RID: 114902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D6")]
		[Address(RVA = "0x1569B00", Offset = "0x1568700", VA = "0x181569B00")]
		private void <>xLuaBaseProxy_Init(MissionModel P0, MissionPageType? P1)
		{
		}

		// Token: 0x0601C0D7 RID: 114903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0D7")]
		[Address(RVA = "0x1569A80", Offset = "0x1568680", VA = "0x181569A80")]
		private void <>xLuaBaseProxy_DealWithState(int P0, bool P1)
		{
		}

		// Token: 0x04024A09 RID: 150025
		[Token(Token = "0x4024A09")]
		private const int DEFAULT_INITIAL_PAGE_INDEX = 0;

		// Token: 0x04024A0A RID: 150026
		[Token(Token = "0x4024A0A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MissionBookPageSimpleConfig[] _pageConfig;

		// Token: 0x04024A0B RID: 150027
		[Token(Token = "0x4024A0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MissionBookTagTab _tagPrefab;

		// Token: 0x04024A0C RID: 150028
		[Token(Token = "0x4024A0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MissionBookTagTab _soCharPrefab;

		// Token: 0x04024A0D RID: 150029
		[Token(Token = "0x4024A0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _bookContainer;

		// Token: 0x04024A0E RID: 150030
		[Token(Token = "0x4024A0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _tagContainer;

		// Token: 0x04024A0F RID: 150031
		[Token(Token = "0x4024A0F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04024A10 RID: 150032
		[Token(Token = "0x4024A10")]
		[FieldOffset(Offset = "0x48")]
		private List<MissionSinglePage> m_pageList;

		// Token: 0x04024A11 RID: 150033
		[Token(Token = "0x4024A11")]
		[FieldOffset(Offset = "0x50")]
		private List<MissionBookTagTab> m_tagList;

		// Token: 0x04024A12 RID: 150034
		[Token(Token = "0x4024A12")]
		[FieldOffset(Offset = "0x58")]
		private bool m_initFlag;

		// Token: 0x04024A13 RID: 150035
		[Token(Token = "0x4024A13")]
		[FieldOffset(Offset = "0x5C")]
		private MissionPageType? m_initPageType;

		// Token: 0x04024A14 RID: 150036
		[Token(Token = "0x4024A14")]
		[FieldOffset(Offset = "0x68")]
		private MissionModel m_stateBean;

		// Token: 0x04024A15 RID: 150037
		[Token(Token = "0x4024A15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshFlag;

		// Token: 0x04024A16 RID: 150038
		[Token(Token = "0x4024A16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024A17 RID: 150039
		[Token(Token = "0x4024A17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04024A18 RID: 150040
		[Token(Token = "0x4024A18")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnumMissionViewModel;

		// Token: 0x04024A19 RID: 150041
		[Token(Token = "0x4024A19")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NeedShowTabTrackPoint;

		// Token: 0x04024A1A RID: 150042
		[Token(Token = "0x4024A1A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsStartMissionGroupComplete;

		// Token: 0x04024A1B RID: 150043
		[Token(Token = "0x4024A1B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshTagPageAvailOfType;

		// Token: 0x04024A1C RID: 150044
		[Token(Token = "0x4024A1C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasNewSOCharTag;

		// Token: 0x04024A1D RID: 150045
		[Token(Token = "0x4024A1D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_MarkSOCharViewed;

		// Token: 0x04024A1E RID: 150046
		[Token(Token = "0x4024A1E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DealWithState;

		// Token: 0x04024A1F RID: 150047
		[Token(Token = "0x4024A1F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConvertTypeToTabString;

		// Token: 0x04024A20 RID: 150048
		[Token(Token = "0x4024A20")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
