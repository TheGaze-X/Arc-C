using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CommonFriendAssist;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200778E RID: 30606
	[Token(Token = "0x200778E")]
	public class Act1VHalfIdleFriendAssistPlugin : ICommonFriendAssistPlugin, IHotfixable
	{
		// Token: 0x170064BF RID: 25791
		// (get) Token: 0x0602AFB2 RID: 176050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064BF")]
		public string tips
		{
			[Token(Token = "0x602AFB2")]
			[Address(RVA = "0x26CBCB0", Offset = "0x26CA8B0", VA = "0x1826CBCB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170064C0 RID: 25792
		// (get) Token: 0x0602AFB3 RID: 176051 RVA: 0x000DA8E0 File Offset: 0x000D8AE0
		[Token(Token = "0x170064C0")]
		public bool profValid
		{
			[Token(Token = "0x602AFB3")]
			[Address(RVA = "0x26CBC50", Offset = "0x26CA850", VA = "0x1826CBC50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170064C1 RID: 25793
		// (get) Token: 0x0602AFB4 RID: 176052 RVA: 0x000DA8F8 File Offset: 0x000D8AF8
		// (set) Token: 0x0602AFB5 RID: 176053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064C1")]
		public ProfessionCategory defaultProf
		{
			[Token(Token = "0x602AFB4")]
			[Address(RVA = "0x26CBBF0", Offset = "0x26CA7F0", VA = "0x1826CBBF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x602AFB5")]
			[Address(RVA = "0x26CBD50", Offset = "0x26CA950", VA = "0x1826CBD50", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AFB6 RID: 176054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFB6")]
		[Address(RVA = "0x26CAD90", Offset = "0x26C9990", VA = "0x1826CAD90")]
		public void InitPlugin(Act1VHalfIdleFriendAssistPlugin.AssistPluginInput assistPluginInput)
		{
		}

		// Token: 0x0602AFB7 RID: 176055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFB7")]
		[Address(RVA = "0x26CB0F0", Offset = "0x26C9CF0", VA = "0x1826CB0F0")]
		private void _CollectAssistBlackList(ref HashSet<string> blackList)
		{
		}

		// Token: 0x0602AFB8 RID: 176056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFB8")]
		[Address(RVA = "0x26CB370", Offset = "0x26C9F70", VA = "0x1826CB370")]
		private void _CollectForbiddenAssistCharsStep(Act1VHalfIdleData actData, ref HashSet<string> blackList)
		{
		}

		// Token: 0x0602AFB9 RID: 176057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFB9")]
		[Address(RVA = "0x26CB520", Offset = "0x26CA120", VA = "0x1826CB520")]
		private void _CollectNpcPoolAssistCharsStep(Act1VHalfIdleData actData, ref HashSet<string> blackList)
		{
		}

		// Token: 0x0602AFBA RID: 176058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFBA")]
		[Address(RVA = "0x26CA9E0", Offset = "0x26C95E0", VA = "0x1826CA9E0", Slot = "8")]
		public void FetchAssistData(ProfessionCategory profession, bool refreshFlag, Action<CommonFriendAssistData> result)
		{
		}

		// Token: 0x0602AFBB RID: 176059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFBB")]
		[Address(RVA = "0x26CB750", Offset = "0x26CA350", VA = "0x1826CB750")]
		private void _UpdateByResponse(GetFriendAssistCharListResponse response, ProfessionCategory profession, Action<CommonFriendAssistData> result)
		{
		}

		// Token: 0x0602AFBC RID: 176060 RVA: 0x000DA910 File Offset: 0x000D8B10
		[Token(Token = "0x602AFBC")]
		[Address(RVA = "0x26CAFB0", Offset = "0x26C9BB0", VA = "0x1826CAFB0")]
		private bool _CheckAssistCharAvail(SharedCharData assistChar)
		{
			return default(bool);
		}

		// Token: 0x0602AFBD RID: 176061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFBD")]
		[Address(RVA = "0x26CA3E0", Offset = "0x26C8FE0", VA = "0x1826CA3E0", Slot = "9")]
		public void ApplyAssistChoose(SquadAssistData assist, Action done)
		{
		}

		// Token: 0x0602AFBE RID: 176062 RVA: 0x000DA928 File Offset: 0x000D8B28
		[Token(Token = "0x602AFBE")]
		[Address(RVA = "0x26CA840", Offset = "0x26C9440", VA = "0x1826CA840", Slot = "10")]
		public bool CheckCanReqAssist(out long cdRemainTs)
		{
			return default(bool);
		}

		// Token: 0x0602AFBF RID: 176063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFBF")]
		[Address(RVA = "0x26CBAA0", Offset = "0x26CA6A0", VA = "0x1826CBAA0")]
		public Act1VHalfIdleFriendAssistPlugin()
		{
		}

		// Token: 0x0403E05E RID: 254046
		[Token(Token = "0x403E05E")]
		public const string IGNORE_SQUAD_WEIGHT_SQUAD_ID = "-1";

		// Token: 0x0403E060 RID: 254048
		[Token(Token = "0x403E060")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x0403E061 RID: 254049
		[Token(Token = "0x403E061")]
		[FieldOffset(Offset = "0x20")]
		private int m_slotId;

		// Token: 0x0403E062 RID: 254050
		[Token(Token = "0x403E062")]
		[FieldOffset(Offset = "0x24")]
		private bool m_allowNotRecruitedChar;

		// Token: 0x0403E063 RID: 254051
		[Token(Token = "0x403E063")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<string> m_assistBlackList;

		// Token: 0x0403E064 RID: 254052
		[Token(Token = "0x403E064")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType> m_charStatusDict;

		// Token: 0x0403E065 RID: 254053
		[Token(Token = "0x403E065")]
		[FieldOffset(Offset = "0x38")]
		private EnumIntDictionary<ProfessionCategory, GetFriendAssistCharListResponse> m_responseCacheDict;

		// Token: 0x0403E066 RID: 254054
		[Token(Token = "0x403E066")]
		[FieldOffset(Offset = "0x40")]
		private DateTime m_cachedNextAllowAskTs;

		// Token: 0x0403E067 RID: 254055
		[Token(Token = "0x403E067")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x0403E068 RID: 254056
		[Token(Token = "0x403E068")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_profValid;

		// Token: 0x0403E069 RID: 254057
		[Token(Token = "0x403E069")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_defaultProf;

		// Token: 0x0403E06A RID: 254058
		[Token(Token = "0x403E06A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_defaultProf;

		// Token: 0x0403E06B RID: 254059
		[Token(Token = "0x403E06B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitPlugin;

		// Token: 0x0403E06C RID: 254060
		[Token(Token = "0x403E06C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CollectAssistBlackList;

		// Token: 0x0403E06D RID: 254061
		[Token(Token = "0x403E06D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CollectForbiddenAssistCharsStep;

		// Token: 0x0403E06E RID: 254062
		[Token(Token = "0x403E06E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CollectNpcPoolAssistCharsStep;

		// Token: 0x0403E06F RID: 254063
		[Token(Token = "0x403E06F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FetchAssistData;

		// Token: 0x0403E070 RID: 254064
		[Token(Token = "0x403E070")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateByResponse;

		// Token: 0x0403E071 RID: 254065
		[Token(Token = "0x403E071")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckAssistCharAvail;

		// Token: 0x0403E072 RID: 254066
		[Token(Token = "0x403E072")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ApplyAssistChoose;

		// Token: 0x0403E073 RID: 254067
		[Token(Token = "0x403E073")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckCanReqAssist;

		// Token: 0x0403E074 RID: 254068
		[Token(Token = "0x403E074")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200778F RID: 30607
		[Token(Token = "0x200778F")]
		public struct AssistPluginInput
		{
			// Token: 0x0403E075 RID: 254069
			[Token(Token = "0x403E075")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory defaultProf;

			// Token: 0x0403E076 RID: 254070
			[Token(Token = "0x403E076")]
			[FieldOffset(Offset = "0x8")]
			public string actId;

			// Token: 0x0403E077 RID: 254071
			[Token(Token = "0x403E077")]
			[FieldOffset(Offset = "0x10")]
			public int slotId;

			// Token: 0x0403E078 RID: 254072
			[Token(Token = "0x403E078")]
			[FieldOffset(Offset = "0x14")]
			public bool allowNotRecruitedChar;

			// Token: 0x0403E079 RID: 254073
			[Token(Token = "0x403E079")]
			[FieldOffset(Offset = "0x18")]
			public GetFriendAssistCharListResponse firstCacheResponse;
		}
	}
}
