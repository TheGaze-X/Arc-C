using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CommonFriendAssist;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200630D RID: 25357
	[Token(Token = "0x200630D")]
	public class AutoChessFriendAssistPlugin : ICommonFriendAssistPlugin, IHotfixable
	{
		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x060248AA RID: 149674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060248AB RID: 149675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055F7")]
		public string activityId
		{
			[Token(Token = "0x60248AA")]
			[Address(RVA = "0x1F50900", Offset = "0x1F4F500", VA = "0x181F50900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60248AB")]
			[Address(RVA = "0x1F50B70", Offset = "0x1F4F770", VA = "0x181F50B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x060248AC RID: 149676 RVA: 0x000C48A8 File Offset: 0x000C2AA8
		// (set) Token: 0x060248AD RID: 149677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055F8")]
		public CharQuery charQuery
		{
			[Token(Token = "0x60248AC")]
			[Address(RVA = "0x1F50960", Offset = "0x1F4F560", VA = "0x181F50960")]
			[CompilerGenerated]
			get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x60248AD")]
			[Address(RVA = "0x1F50BF0", Offset = "0x1F4F7F0", VA = "0x181F50BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x060248AE RID: 149678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060248AF RID: 149679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055F9")]
		public string chessId
		{
			[Token(Token = "0x60248AE")]
			[Address(RVA = "0x1F509E0", Offset = "0x1F4F5E0", VA = "0x181F509E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60248AF")]
			[Address(RVA = "0x1F50C80", Offset = "0x1F4F880", VA = "0x181F50C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x060248B0 RID: 149680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055FA")]
		public string tips
		{
			[Token(Token = "0x60248B0")]
			[Address(RVA = "0x1F50B00", Offset = "0x1F4F700", VA = "0x181F50B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x060248B1 RID: 149681 RVA: 0x000C48C0 File Offset: 0x000C2AC0
		[Token(Token = "0x170055FB")]
		public bool profValid
		{
			[Token(Token = "0x60248B1")]
			[Address(RVA = "0x1F50AA0", Offset = "0x1F4F6A0", VA = "0x181F50AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x060248B2 RID: 149682 RVA: 0x000C48D8 File Offset: 0x000C2AD8
		// (set) Token: 0x060248B3 RID: 149683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055FC")]
		public ProfessionCategory defaultProf
		{
			[Token(Token = "0x60248B2")]
			[Address(RVA = "0x1F50A40", Offset = "0x1F4F640", VA = "0x181F50A40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x60248B3")]
			[Address(RVA = "0x1F50D00", Offset = "0x1F4F900", VA = "0x181F50D00", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060248B4 RID: 149684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248B4")]
		[Address(RVA = "0x1F50240", Offset = "0x1F4EE40", VA = "0x181F50240", Slot = "9")]
		public void ApplyAssistChoose(SquadAssistData assist, Action done)
		{
		}

		// Token: 0x060248B5 RID: 149685 RVA: 0x000C48F0 File Offset: 0x000C2AF0
		[Token(Token = "0x60248B5")]
		[Address(RVA = "0x1F50540", Offset = "0x1F4F140", VA = "0x181F50540", Slot = "10")]
		public bool CheckCanReqAssist(out long cdRemainTs)
		{
			return default(bool);
		}

		// Token: 0x060248B6 RID: 149686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248B6")]
		[Address(RVA = "0x1F505B0", Offset = "0x1F4F1B0", VA = "0x181F505B0", Slot = "8")]
		public void FetchAssistData(ProfessionCategory profession, bool refreshFlag, Action<CommonFriendAssistData> result)
		{
		}

		// Token: 0x060248B7 RID: 149687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248B7")]
		[Address(RVA = "0x1F508A0", Offset = "0x1F4F4A0", VA = "0x181F508A0")]
		public AutoChessFriendAssistPlugin()
		{
		}

		// Token: 0x04032FBB RID: 208827
		[Token(Token = "0x4032FBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04032FBC RID: 208828
		[Token(Token = "0x4032FBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x04032FBD RID: 208829
		[Token(Token = "0x4032FBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x04032FBE RID: 208830
		[Token(Token = "0x4032FBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x04032FBF RID: 208831
		[Token(Token = "0x4032FBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_chessId;

		// Token: 0x04032FC0 RID: 208832
		[Token(Token = "0x4032FC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_chessId;

		// Token: 0x04032FC1 RID: 208833
		[Token(Token = "0x4032FC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x04032FC2 RID: 208834
		[Token(Token = "0x4032FC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_profValid;

		// Token: 0x04032FC3 RID: 208835
		[Token(Token = "0x4032FC3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_defaultProf;

		// Token: 0x04032FC4 RID: 208836
		[Token(Token = "0x4032FC4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_defaultProf;

		// Token: 0x04032FC5 RID: 208837
		[Token(Token = "0x4032FC5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyAssistChoose;

		// Token: 0x04032FC6 RID: 208838
		[Token(Token = "0x4032FC6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckCanReqAssist;

		// Token: 0x04032FC7 RID: 208839
		[Token(Token = "0x4032FC7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FetchAssistData;

		// Token: 0x04032FC8 RID: 208840
		[Token(Token = "0x4032FC8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
