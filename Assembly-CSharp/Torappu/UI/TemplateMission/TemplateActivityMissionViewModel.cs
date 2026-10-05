using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB7 RID: 15799
	[Token(Token = "0x2003DB7")]
	public class TemplateActivityMissionViewModel : TemplateActivityViewModel
	{
		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x06018911 RID: 100625 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018912 RID: 100626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AA3")]
		public TemplateMissionInputParam param
		{
			[Token(Token = "0x6018911")]
			[Address(RVA = "0x1108E90", Offset = "0x1107A90", VA = "0x181108E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018912")]
			[Address(RVA = "0x1108EF0", Offset = "0x1107AF0", VA = "0x181108EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018913 RID: 100627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018913")]
		[Address(RVA = "0x1108B90", Offset = "0x1107790", VA = "0x181108B90")]
		public TemplateActivityMissionViewModel(object param)
		{
		}

		// Token: 0x06018914 RID: 100628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018914")]
		[Address(RVA = "0x1108B20", Offset = "0x1107720", VA = "0x181108B20")]
		public void RefreshMissionState()
		{
		}

		// Token: 0x06018915 RID: 100629 RVA: 0x0009ACC8 File Offset: 0x00098EC8
		[Token(Token = "0x6018915")]
		[Address(RVA = "0x11089D0", Offset = "0x11075D0", VA = "0x1811089D0")]
		public bool CheckHaveMissionToGet()
		{
			return default(bool);
		}

		// Token: 0x06018916 RID: 100630 RVA: 0x0009ACE0 File Offset: 0x00098EE0
		[Token(Token = "0x6018916")]
		[Address(RVA = "0x1108A70", Offset = "0x1107670", VA = "0x181108A70")]
		public bool CheckMissionListPlayerDataChanged(PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0401E1F1 RID: 123377
		[Token(Token = "0x401E1F1")]
		[FieldOffset(Offset = "0x28")]
		private TemplateMissionViewModel m_viewModel;

		// Token: 0x0401E1F2 RID: 123378
		[Token(Token = "0x401E1F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x0401E1F3 RID: 123379
		[Token(Token = "0x401E1F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_param;

		// Token: 0x0401E1F4 RID: 123380
		[Token(Token = "0x401E1F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E1F5 RID: 123381
		[Token(Token = "0x401E1F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshMissionState;

		// Token: 0x0401E1F6 RID: 123382
		[Token(Token = "0x401E1F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckHaveMissionToGet;

		// Token: 0x0401E1F7 RID: 123383
		[Token(Token = "0x401E1F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckMissionListPlayerDataChanged;
	}
}
