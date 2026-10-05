using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BEE RID: 27630
	[Token(Token = "0x2006BEE")]
	public class ArchiveQuestController : ActArchiveController
	{
		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0602773B RID: 161595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602773C RID: 161596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D1E")]
		public Action<SandboxV2ArchiveQuestType> actionOnSelectQuestType
		{
			[Token(Token = "0x602773B")]
			[Address(RVA = "0x229DA10", Offset = "0x229C610", VA = "0x18229DA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602773C")]
			[Address(RVA = "0x229DB30", Offset = "0x229C730", VA = "0x18229DB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0602773D RID: 161597 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602773E RID: 161598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D1F")]
		public Action<bool> onFullscreenToggled
		{
			[Token(Token = "0x602773D")]
			[Address(RVA = "0x229DAD0", Offset = "0x229C6D0", VA = "0x18229DAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x602773E")]
			[Address(RVA = "0x229DC30", Offset = "0x229C830", VA = "0x18229DC30")]
			set
			{
			}
		}

		// Token: 0x0602773F RID: 161599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602773F")]
		[Address(RVA = "0x229D340", Offset = "0x229BF40", VA = "0x18229D340")]
		public List<DataBinder<ArchiveQuestProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x06027740 RID: 161600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027741 RID: 161601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D20")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6027740")]
			[Address(RVA = "0x229DA70", Offset = "0x229C670", VA = "0x18229DA70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027741")]
			[Address(RVA = "0x229DBB0", Offset = "0x229C7B0", VA = "0x18229DBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027742 RID: 161602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027742")]
		[Address(RVA = "0x229D890", Offset = "0x229C490", VA = "0x18229D890")]
		public void OnSelectQuestType(SandboxV2ArchiveQuestType type)
		{
		}

		// Token: 0x06027743 RID: 161603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027743")]
		[Address(RVA = "0x229D570", Offset = "0x229C170", VA = "0x18229D570", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x06027744 RID: 161604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027744")]
		[Address(RVA = "0x229D660", Offset = "0x229C260", VA = "0x18229D660")]
		public void OnItemSelectEvent(int index)
		{
		}

		// Token: 0x06027745 RID: 161605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027745")]
		[Address(RVA = "0x229D780", Offset = "0x229C380", VA = "0x18229D780")]
		public void OnPicClicked()
		{
		}

		// Token: 0x06027746 RID: 161606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027746")]
		[Address(RVA = "0x229D9B0", Offset = "0x229C5B0", VA = "0x18229D9B0")]
		public ArchiveQuestController()
		{
		}

		// Token: 0x06027747 RID: 161607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027747")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04037E6C RID: 228972
		[Token(Token = "0x4037E6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animEnterPanelToSelect;

		// Token: 0x04037E6D RID: 228973
		[Token(Token = "0x4037E6D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArchiveQuestDataBinder _questDataBinder;

		// Token: 0x04037E6E RID: 228974
		[Token(Token = "0x4037E6E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArchiveQuestFullScreenDataBinder _fullScreenDataBinder;

		// Token: 0x04037E6F RID: 228975
		[Token(Token = "0x4037E6F")]
		[FieldOffset(Offset = "0x58")]
		private Action<bool> m_onFullscreenToggled;

		// Token: 0x04037E72 RID: 228978
		[Token(Token = "0x4037E72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actionOnSelectQuestType;

		// Token: 0x04037E73 RID: 228979
		[Token(Token = "0x4037E73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actionOnSelectQuestType;

		// Token: 0x04037E74 RID: 228980
		[Token(Token = "0x4037E74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onFullscreenToggled;

		// Token: 0x04037E75 RID: 228981
		[Token(Token = "0x4037E75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onFullscreenToggled;

		// Token: 0x04037E76 RID: 228982
		[Token(Token = "0x4037E76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037E77 RID: 228983
		[Token(Token = "0x4037E77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04037E78 RID: 228984
		[Token(Token = "0x4037E78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04037E79 RID: 228985
		[Token(Token = "0x4037E79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSelectQuestType;

		// Token: 0x04037E7A RID: 228986
		[Token(Token = "0x4037E7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037E7B RID: 228987
		[Token(Token = "0x4037E7B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnItemSelectEvent;

		// Token: 0x04037E7C RID: 228988
		[Token(Token = "0x4037E7C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPicClicked;

		// Token: 0x04037E7D RID: 228989
		[Token(Token = "0x4037E7D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
