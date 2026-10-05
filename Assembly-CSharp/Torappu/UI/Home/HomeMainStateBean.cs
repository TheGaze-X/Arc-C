using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B6B RID: 19307
	[Token(Token = "0x2004B6B")]
	public class HomeMainStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601D0F1 RID: 119025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0F1")]
		[Address(RVA = "0x169F070", Offset = "0x169DC70", VA = "0x18169F070")]
		public static void SetExtension(HomeMainStateBean.ILuaExtension ext)
		{
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x0601D0F2 RID: 119026 RVA: 0x000AA2C8 File Offset: 0x000A84C8
		// (set) Token: 0x0601D0F3 RID: 119027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700444C")]
		public bool isOpenServerAvailable
		{
			[Token(Token = "0x601D0F2")]
			[Address(RVA = "0x16A1030", Offset = "0x169FC30", VA = "0x1816A1030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D0F3")]
			[Address(RVA = "0x16A11B0", Offset = "0x169FDB0", VA = "0x1816A11B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x0601D0F4 RID: 119028 RVA: 0x000AA2E0 File Offset: 0x000A84E0
		// (set) Token: 0x0601D0F5 RID: 119029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700444D")]
		public HomeMainStateBean.ReturningStatus returningStatus
		{
			[Token(Token = "0x601D0F4")]
			[Address(RVA = "0x16A1090", Offset = "0x169FC90", VA = "0x1816A1090")]
			[CompilerGenerated]
			get
			{
				return default(HomeMainStateBean.ReturningStatus);
			}
			[Token(Token = "0x601D0F5")]
			[Address(RVA = "0x16A1220", Offset = "0x169FE20", VA = "0x1816A1220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x0601D0F6 RID: 119030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D0F7 RID: 119031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700444E")]
		public string validActivityAnnounceStoryId
		{
			[Token(Token = "0x601D0F6")]
			[Address(RVA = "0x16A10F0", Offset = "0x169FCF0", VA = "0x1816A10F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D0F7")]
			[Address(RVA = "0x16A1290", Offset = "0x169FE90", VA = "0x1816A1290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0601D0F8 RID: 119032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D0F9 RID: 119033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700444F")]
		public string validNeedPlayStoryId
		{
			[Token(Token = "0x601D0F8")]
			[Address(RVA = "0x16A1150", Offset = "0x169FD50", VA = "0x1816A1150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D0F9")]
			[Address(RVA = "0x16A1310", Offset = "0x169FF10", VA = "0x1816A1310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0FA")]
		[Address(RVA = "0x169E620", Offset = "0x169D220", VA = "0x18169E620")]
		public void LoadData()
		{
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x000AA2F8 File Offset: 0x000A84F8
		[Token(Token = "0x601D0FB")]
		[Address(RVA = "0x169F0E0", Offset = "0x169DCE0", VA = "0x18169F0E0")]
		public bool TryLoadRandomIllustText(out CharWordData charWord)
		{
			return default(bool);
		}

		// Token: 0x0601D0FC RID: 119036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0FC")]
		[Address(RVA = "0x169E6E0", Offset = "0x169D2E0", VA = "0x18169E6E0")]
		public void NotifyMailUpdated()
		{
		}

		// Token: 0x0601D0FD RID: 119037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0FD")]
		[Address(RVA = "0x169E750", Offset = "0x169D350", VA = "0x18169E750")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601D0FE RID: 119038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0FE")]
		[Address(RVA = "0x169F210", Offset = "0x169DE10", VA = "0x18169F210")]
		public void UpdateResourceProperty()
		{
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0FF")]
		[Address(RVA = "0x16A06A0", Offset = "0x169F2A0", VA = "0x1816A06A0")]
		private void _SplitUncompleteHomeActs(List<string> uncompleteHomeActs, List<string> popupWithCheckinActs, List<string> popupAfterCheckinActs)
		{
		}

		// Token: 0x0601D100 RID: 119040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D100")]
		[Address(RVA = "0x169F6F0", Offset = "0x169E2F0", VA = "0x18169F6F0")]
		private void _FindHomeEntryActivity(List<string> outValidActs, List<string> outUncompleteActs, List<string> outUnfinishedActs, List<string> outFinishedActs)
		{
		}

		// Token: 0x0601D101 RID: 119041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D101")]
		[Address(RVA = "0x169E380", Offset = "0x169CF80", VA = "0x18169E380")]
		public string FindCurrentValidHomeAct(string funcActId)
		{
			return null;
		}

		// Token: 0x0601D102 RID: 119042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D102")]
		[Address(RVA = "0x16A0810", Offset = "0x169F410", VA = "0x1816A0810")]
		private string _TryFindCurrentValidAprilFoolAct()
		{
			return null;
		}

		// Token: 0x0601D103 RID: 119043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D103")]
		[Address(RVA = "0x16A05C0", Offset = "0x169F1C0", VA = "0x1816A05C0")]
		private void _FindValidActivityAnnounceStory(out string validStoryId)
		{
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D104")]
		[Address(RVA = "0x16A0360", Offset = "0x169EF60", VA = "0x1816A0360")]
		private void _FindValidAct17D7Story(out string actId, out string validStoryId)
		{
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D105")]
		[Address(RVA = "0x16A0490", Offset = "0x169F090", VA = "0x1816A0490")]
		private void _FindValidActFun(out string actId, out string validStoryId)
		{
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D106")]
		[Address(RVA = "0x169F2F0", Offset = "0x169DEF0", VA = "0x18169F2F0")]
		private void _FindActivityWithAvg(out List<HomeMainStateBean.ActWithAvg> list)
		{
		}

		// Token: 0x0601D107 RID: 119047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D107")]
		[Address(RVA = "0x16A0990", Offset = "0x169F590", VA = "0x1816A0990")]
		public HomeMainStateBean()
		{
		}

		// Token: 0x040261F2 RID: 156146
		[Token(Token = "0x40261F2")]
		[FieldOffset(Offset = "0x0")]
		private static HomeMainStateBean.ILuaExtension s_luaExt;

		// Token: 0x040261F3 RID: 156147
		[Token(Token = "0x40261F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceBarViewProperty _resourceProperty;

		// Token: 0x040261F4 RID: 156148
		[Token(Token = "0x40261F4")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string activityOpenId;

		// Token: 0x040261F5 RID: 156149
		[Token(Token = "0x40261F5")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public DataBundle activityOpenMeta;

		// Token: 0x040261F6 RID: 156150
		[Token(Token = "0x40261F6")]
		[FieldOffset(Offset = "0x30")]
		private CharWordData m_illustWord;

		// Token: 0x040261F7 RID: 156151
		[Token(Token = "0x40261F7")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public TrackPointViewProperty mailTrackProp;

		// Token: 0x040261F8 RID: 156152
		[Token(Token = "0x40261F8")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public TrackPointViewProperty checkInTrackProp;

		// Token: 0x040261F9 RID: 156153
		[Token(Token = "0x40261F9")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public TrackPointViewProperty recruitTrackProp;

		// Token: 0x040261FA RID: 156154
		[Token(Token = "0x40261FA")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public TrackPointViewProperty charRepoTrackProp;

		// Token: 0x040261FB RID: 156155
		[Token(Token = "0x40261FB")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public TrackPointViewProperty buildingTrackProp;

		// Token: 0x040261FC RID: 156156
		[Token(Token = "0x40261FC")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public TrackPointViewProperty missionTrackProp;

		// Token: 0x040261FD RID: 156157
		[Token(Token = "0x40261FD")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public TrackPointViewProperty friendTrackProp;

		// Token: 0x040261FE RID: 156158
		[Token(Token = "0x40261FE")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public TrackPointViewProperty openServerTrackProp;

		// Token: 0x040261FF RID: 156159
		[Token(Token = "0x40261FF")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public TrackPointViewProperty returnTrackProp;

		// Token: 0x04026200 RID: 156160
		[Token(Token = "0x4026200")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public TrackPointViewProperty shopTrackProp;

		// Token: 0x04026201 RID: 156161
		[Token(Token = "0x4026201")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public TrackPointViewProperty announceTrackProp;

		// Token: 0x04026202 RID: 156162
		[Token(Token = "0x4026202")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public TrackPointViewProperty apItemTrackProp;

		// Token: 0x04026203 RID: 156163
		[Token(Token = "0x4026203")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public TrackPointViewProperty infoPolyTrackProp;

		// Token: 0x04026204 RID: 156164
		[Token(Token = "0x4026204")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public TrackPointViewProperty illustTrackProp;

		// Token: 0x04026205 RID: 156165
		[Token(Token = "0x4026205")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public TrackPointViewProperty settingTrackProp;

		// Token: 0x04026206 RID: 156166
		[Token(Token = "0x4026206")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public ActivityOnBattleViewProperty actOnBattleProp;

		// Token: 0x0402620B RID: 156171
		[Token(Token = "0x402620B")]
		[FieldOffset(Offset = "0xD0")]
		public List<HomeMainStateBean.ActWithAvg> validActWithAvgList;

		// Token: 0x0402620C RID: 156172
		[Token(Token = "0x402620C")]
		[FieldOffset(Offset = "0xD8")]
		private List<string> m_validHomeEntryActs;

		// Token: 0x0402620D RID: 156173
		[Token(Token = "0x402620D")]
		[FieldOffset(Offset = "0xE0")]
		private List<string> m_uncompleteHomeActs;

		// Token: 0x0402620E RID: 156174
		[Token(Token = "0x402620E")]
		[FieldOffset(Offset = "0xE8")]
		public List<string> unfinishedHomeActs;

		// Token: 0x0402620F RID: 156175
		[Token(Token = "0x402620F")]
		[FieldOffset(Offset = "0xF0")]
		public List<string> finishedHomeActs;

		// Token: 0x04026210 RID: 156176
		[Token(Token = "0x4026210")]
		[FieldOffset(Offset = "0xF8")]
		public List<string> popupWithCheckinActs;

		// Token: 0x04026211 RID: 156177
		[Token(Token = "0x4026211")]
		[FieldOffset(Offset = "0x100")]
		public List<string> popupAfterCheckinActs;

		// Token: 0x04026212 RID: 156178
		[Token(Token = "0x4026212")]
		[FieldOffset(Offset = "0x108")]
		private List<ActivityUtil.SortableActivity> m_validActsCache;

		// Token: 0x04026213 RID: 156179
		[Token(Token = "0x4026213")]
		[FieldOffset(Offset = "0x110")]
		private List<ActivityUtil.SortableActivity> m_uncmpltActsCache;

		// Token: 0x04026214 RID: 156180
		[Token(Token = "0x4026214")]
		[FieldOffset(Offset = "0x118")]
		private List<ActivityUtil.SortableActivity> m_unfinishedActsCache;

		// Token: 0x04026215 RID: 156181
		[Token(Token = "0x4026215")]
		[FieldOffset(Offset = "0x120")]
		private List<ActivityUtil.SortableActivity> m_finishedActsCache;

		// Token: 0x04026216 RID: 156182
		[Token(Token = "0x4026216")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetExtension;

		// Token: 0x04026217 RID: 156183
		[Token(Token = "0x4026217")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isOpenServerAvailable;

		// Token: 0x04026218 RID: 156184
		[Token(Token = "0x4026218")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isOpenServerAvailable;

		// Token: 0x04026219 RID: 156185
		[Token(Token = "0x4026219")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_returningStatus;

		// Token: 0x0402621A RID: 156186
		[Token(Token = "0x402621A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_returningStatus;

		// Token: 0x0402621B RID: 156187
		[Token(Token = "0x402621B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_validActivityAnnounceStoryId;

		// Token: 0x0402621C RID: 156188
		[Token(Token = "0x402621C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_validActivityAnnounceStoryId;

		// Token: 0x0402621D RID: 156189
		[Token(Token = "0x402621D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_validNeedPlayStoryId;

		// Token: 0x0402621E RID: 156190
		[Token(Token = "0x402621E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_validNeedPlayStoryId;

		// Token: 0x0402621F RID: 156191
		[Token(Token = "0x402621F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026220 RID: 156192
		[Token(Token = "0x4026220")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryLoadRandomIllustText;

		// Token: 0x04026221 RID: 156193
		[Token(Token = "0x4026221")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_NotifyMailUpdated;

		// Token: 0x04026222 RID: 156194
		[Token(Token = "0x4026222")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04026223 RID: 156195
		[Token(Token = "0x4026223")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateResourceProperty;

		// Token: 0x04026224 RID: 156196
		[Token(Token = "0x4026224")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SplitUncompleteHomeActs;

		// Token: 0x04026225 RID: 156197
		[Token(Token = "0x4026225")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FindHomeEntryActivity;

		// Token: 0x04026226 RID: 156198
		[Token(Token = "0x4026226")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FindCurrentValidHomeAct;

		// Token: 0x04026227 RID: 156199
		[Token(Token = "0x4026227")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryFindCurrentValidAprilFoolAct;

		// Token: 0x04026228 RID: 156200
		[Token(Token = "0x4026228")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__FindValidActivityAnnounceStory;

		// Token: 0x04026229 RID: 156201
		[Token(Token = "0x4026229")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__FindValidAct17D7Story;

		// Token: 0x0402622A RID: 156202
		[Token(Token = "0x402622A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FindValidActFun;

		// Token: 0x0402622B RID: 156203
		[Token(Token = "0x402622B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__FindActivityWithAvg;

		// Token: 0x0402622C RID: 156204
		[Token(Token = "0x402622C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B6C RID: 19308
		[Token(Token = "0x2004B6C")]
		private static class ActSortWeight
		{
			// Token: 0x0402622D RID: 156205
			[Token(Token = "0x402622D")]
			public const int FUN = 50;

			// Token: 0x0402622E RID: 156206
			[Token(Token = "0x402622E")]
			public const int LOGIN = 100;

			// Token: 0x0402622F RID: 156207
			[Token(Token = "0x402622F")]
			public const int CHECKIN = 200;

			// Token: 0x04026230 RID: 156208
			[Token(Token = "0x4026230")]
			public const int COLLECTION = 300;

			// Token: 0x04026231 RID: 156209
			[Token(Token = "0x4026231")]
			public const int MISSION = 400;
		}

		// Token: 0x02004B6D RID: 19309
		[Token(Token = "0x2004B6D")]
		public class ActWithAvg
		{
			// Token: 0x0601D108 RID: 119048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D108")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActWithAvg()
			{
			}

			// Token: 0x04026232 RID: 156210
			[Token(Token = "0x4026232")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;

			// Token: 0x04026233 RID: 156211
			[Token(Token = "0x4026233")]
			[FieldOffset(Offset = "0x18")]
			public string storyId;
		}

		// Token: 0x02004B6E RID: 19310
		[Token(Token = "0x2004B6E")]
		[CSharpCallLua]
		public interface ILuaExtension
		{
			// Token: 0x0601D109 RID: 119049
			[Token(Token = "0x601D109")]
			HomeMainStateBean.ReturningStatus GetReturnStatus();
		}

		// Token: 0x02004B6F RID: 19311
		[Token(Token = "0x2004B6F")]
		public struct ReturningStatus
		{
			// Token: 0x04026234 RID: 156212
			[Token(Token = "0x4026234")]
			[FieldOffset(Offset = "0x0")]
			public bool open;

			// Token: 0x04026235 RID: 156213
			[Token(Token = "0x4026235")]
			[FieldOffset(Offset = "0x1")]
			public bool shouldPopup;

			// Token: 0x04026236 RID: 156214
			[Token(Token = "0x4026236")]
			[FieldOffset(Offset = "0x2")]
			public bool showTrackPoint;

			// Token: 0x04026237 RID: 156215
			[Token(Token = "0x4026237")]
			[FieldOffset(Offset = "0x3")]
			public bool onlySpecialOpen;
		}
	}
}
