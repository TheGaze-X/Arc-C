using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F4C RID: 28492
	[Token(Token = "0x2006F4C")]
	public class ActMultiV3ManualState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602876A RID: 165738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602876A")]
		[Address(RVA = "0x23C43E0", Offset = "0x23C2FE0", VA = "0x1823C43E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602876B RID: 165739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602876B")]
		[Address(RVA = "0x23C4440", Offset = "0x23C3040", VA = "0x1823C4440", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602876C RID: 165740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602876C")]
		[Address(RVA = "0x23C4A40", Offset = "0x23C3640", VA = "0x1823C4A40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602876D RID: 165741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602876D")]
		[Address(RVA = "0x23C4BF0", Offset = "0x23C37F0", VA = "0x1823C4BF0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602876E RID: 165742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602876E")]
		[Address(RVA = "0x23C4710", Offset = "0x23C3310", VA = "0x1823C4710", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602876F RID: 165743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602876F")]
		[Address(RVA = "0x23C6C70", Offset = "0x23C5870", VA = "0x1823C6C70")]
		private void _OnClickTitle()
		{
		}

		// Token: 0x06028770 RID: 165744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028770")]
		[Address(RVA = "0x23C6D20", Offset = "0x23C5920", VA = "0x1823C6D20")]
		private void _OnSwitchTab(int tabType)
		{
		}

		// Token: 0x06028771 RID: 165745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028771")]
		[Address(RVA = "0x23C5F60", Offset = "0x23C4B60", VA = "0x1823C5F60")]
		private void _OnClaimMission(string missionId)
		{
		}

		// Token: 0x06028772 RID: 165746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028772")]
		[Address(RVA = "0x23C5710", Offset = "0x23C4310", VA = "0x1823C5710")]
		private void _OnClaimAllMission()
		{
		}

		// Token: 0x06028773 RID: 165747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028773")]
		[Address(RVA = "0x23C5B90", Offset = "0x23C4790", VA = "0x1823C5B90")]
		private void _OnClaimMissionSuc(List<string> missionIds, List<RewardItemModel> items)
		{
		}

		// Token: 0x06028774 RID: 165748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028774")]
		[Address(RVA = "0x23C6350", Offset = "0x23C4F50", VA = "0x1823C6350")]
		private void _OnClickAlbumTab(int tabIdx)
		{
		}

		// Token: 0x06028775 RID: 165749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028775")]
		[Address(RVA = "0x23C53F0", Offset = "0x23C3FF0", VA = "0x1823C53F0")]
		private void _OnClaimAlbum(string weekRewardId)
		{
		}

		// Token: 0x06028776 RID: 165750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028776")]
		[Address(RVA = "0x23C65E0", Offset = "0x23C51E0", VA = "0x1823C65E0")]
		private void _OnClickPhoto(string templateId, int photoTypeIdx)
		{
		}

		// Token: 0x06028777 RID: 165751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028777")]
		[Address(RVA = "0x23C4DF0", Offset = "0x23C39F0", VA = "0x1823C4DF0")]
		private void _CollectPhotoUids(string templateId, ref HashSet<string> idSet, out bool noPhoto)
		{
		}

		// Token: 0x06028778 RID: 165752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028778")]
		[Address(RVA = "0x23C4D50", Offset = "0x23C3950", VA = "0x1823C4D50")]
		private void _AddPhotoSelectState()
		{
		}

		// Token: 0x06028779 RID: 165753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028779")]
		[Address(RVA = "0x23C5200", Offset = "0x23C3E00", VA = "0x1823C5200")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602877A RID: 165754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602877A")]
		[Address(RVA = "0x23C50F0", Offset = "0x23C3CF0", VA = "0x1823C50F0")]
		private string _GetActivityId()
		{
			return null;
		}

		// Token: 0x0602877B RID: 165755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602877B")]
		[Address(RVA = "0x23C5040", Offset = "0x23C3C40", VA = "0x1823C5040")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x0602877C RID: 165756 RVA: 0x000D1DA8 File Offset: 0x000CFFA8
		[Token(Token = "0x602877C")]
		[Address(RVA = "0x23C5310", Offset = "0x23C3F10", VA = "0x1823C5310")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0602877D RID: 165757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602877D")]
		[Address(RVA = "0x23C6E40", Offset = "0x23C5A40", VA = "0x1823C6E40")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602877E RID: 165758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602877E")]
		[Address(RVA = "0x23C6F00", Offset = "0x23C5B00", VA = "0x1823C6F00")]
		private void _RegisterToPhotoSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602877F RID: 165759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602877F")]
		[Address(RVA = "0x23C7140", Offset = "0x23C5D40", VA = "0x1823C7140")]
		public ActMultiV3ManualState()
		{
		}

		// Token: 0x06028780 RID: 165760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028780")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028781 RID: 165761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028781")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06028782 RID: 165762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028782")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040398E7 RID: 235751
		[Token(Token = "0x40398E7")]
		[NonSerialized]
		public const int ON_CLICK_TITLE = 0;

		// Token: 0x040398E8 RID: 235752
		[Token(Token = "0x40398E8")]
		[NonSerialized]
		public const int ON_SWITCH_TAB = 1;

		// Token: 0x040398E9 RID: 235753
		[Token(Token = "0x40398E9")]
		[NonSerialized]
		public const int ON_CLAIM_MISSION = 2;

		// Token: 0x040398EA RID: 235754
		[Token(Token = "0x40398EA")]
		[NonSerialized]
		public const int ON_CLAIM_ALL_MISSION = 3;

		// Token: 0x040398EB RID: 235755
		[Token(Token = "0x40398EB")]
		[NonSerialized]
		public const int ON_CLICK_ALBUM_TAB = 4;

		// Token: 0x040398EC RID: 235756
		[Token(Token = "0x40398EC")]
		[NonSerialized]
		public const int ON_CLAIM_ALBUM = 5;

		// Token: 0x040398ED RID: 235757
		[Token(Token = "0x40398ED")]
		[NonSerialized]
		public const int ON_CLICK_PHOTO = 6;

		// Token: 0x040398EE RID: 235758
		[Token(Token = "0x40398EE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3ManualView _view;

		// Token: 0x040398EF RID: 235759
		[Token(Token = "0x40398EF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040398F0 RID: 235760
		[Token(Token = "0x40398F0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _guideSubSignal;

		// Token: 0x040398F1 RID: 235761
		[Token(Token = "0x40398F1")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x040398F2 RID: 235762
		[Token(Token = "0x40398F2")]
		[FieldOffset(Offset = "0x90")]
		private string m_actId;

		// Token: 0x040398F3 RID: 235763
		[Token(Token = "0x40398F3")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3ManualStateBean m_stateBean;

		// Token: 0x040398F4 RID: 235764
		[Token(Token = "0x40398F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040398F5 RID: 235765
		[Token(Token = "0x40398F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040398F6 RID: 235766
		[Token(Token = "0x40398F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040398F7 RID: 235767
		[Token(Token = "0x40398F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040398F8 RID: 235768
		[Token(Token = "0x40398F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040398F9 RID: 235769
		[Token(Token = "0x40398F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClickTitle;

		// Token: 0x040398FA RID: 235770
		[Token(Token = "0x40398FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSwitchTab;

		// Token: 0x040398FB RID: 235771
		[Token(Token = "0x40398FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClaimMission;

		// Token: 0x040398FC RID: 235772
		[Token(Token = "0x40398FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClaimAllMission;

		// Token: 0x040398FD RID: 235773
		[Token(Token = "0x40398FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClaimMissionSuc;

		// Token: 0x040398FE RID: 235774
		[Token(Token = "0x40398FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClickAlbumTab;

		// Token: 0x040398FF RID: 235775
		[Token(Token = "0x40398FF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnClaimAlbum;

		// Token: 0x04039900 RID: 235776
		[Token(Token = "0x4039900")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClickPhoto;

		// Token: 0x04039901 RID: 235777
		[Token(Token = "0x4039901")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CollectPhotoUids;

		// Token: 0x04039902 RID: 235778
		[Token(Token = "0x4039902")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AddPhotoSelectState;

		// Token: 0x04039903 RID: 235779
		[Token(Token = "0x4039903")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039904 RID: 235780
		[Token(Token = "0x4039904")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetActivityId;

		// Token: 0x04039905 RID: 235781
		[Token(Token = "0x4039905")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039906 RID: 235782
		[Token(Token = "0x4039906")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04039907 RID: 235783
		[Token(Token = "0x4039907")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04039908 RID: 235784
		[Token(Token = "0x4039908")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RegisterToPhotoSelectState;

		// Token: 0x04039909 RID: 235785
		[Token(Token = "0x4039909")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
