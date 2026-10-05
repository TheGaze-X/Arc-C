using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007246 RID: 29254
	[Token(Token = "0x2007246")]
	public class Act5D1RuneStageState : PopupFadeState
	{
		// Token: 0x06029743 RID: 169795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029743")]
		[Address(RVA = "0x24CDAD0", Offset = "0x24CC6D0", VA = "0x1824CDAD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029744 RID: 169796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029744")]
		[Address(RVA = "0x24CF3E0", Offset = "0x24CDFE0", VA = "0x1824CF3E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029745 RID: 169797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029745")]
		[Address(RVA = "0x24CE6E0", Offset = "0x24CD2E0", VA = "0x1824CE6E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029746 RID: 169798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029746")]
		[Address(RVA = "0x24CEF80", Offset = "0x24CDB80", VA = "0x1824CEF80")]
		public void RefreshPointInfo()
		{
		}

		// Token: 0x06029747 RID: 169799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029747")]
		[Address(RVA = "0x24CF200", Offset = "0x24CDE00", VA = "0x1824CF200")]
		public void Refresh()
		{
		}

		// Token: 0x06029748 RID: 169800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029748")]
		[Address(RVA = "0x24CE090", Offset = "0x24CCC90", VA = "0x1824CE090")]
		public void OnClick(string runeId)
		{
		}

		// Token: 0x06029749 RID: 169801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029749")]
		[Address(RVA = "0x24CDB40", Offset = "0x24CC740", VA = "0x1824CDB40")]
		public void OnClickToEnemyHandBook()
		{
		}

		// Token: 0x0602974A RID: 169802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602974A")]
		[Address(RVA = "0x24CE5F0", Offset = "0x24CD1F0", VA = "0x1824CE5F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602974B RID: 169803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602974B")]
		[Address(RVA = "0x24CF560", Offset = "0x24CE160", VA = "0x1824CF560")]
		public void ToDetailState()
		{
		}

		// Token: 0x0602974C RID: 169804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602974C")]
		[Address(RVA = "0x24CD990", Offset = "0x24CC590", VA = "0x1824CD990")]
		public void CleanAllSelect()
		{
		}

		// Token: 0x0602974D RID: 169805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602974D")]
		[Address(RVA = "0x24CE760", Offset = "0x24CD360", VA = "0x1824CE760")]
		public void OpenSquadPage()
		{
		}

		// Token: 0x0602974E RID: 169806 RVA: 0x000D5BB8 File Offset: 0x000D3DB8
		[Token(Token = "0x602974E")]
		[Address(RVA = "0x24CF760", Offset = "0x24CE360", VA = "0x1824CF760")]
		private BattleActivityMeta _GenerateActMeta4BattleFinish(string activityId)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x0602974F RID: 169807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602974F")]
		[Address(RVA = "0x24CF830", Offset = "0x24CE430", VA = "0x1824CF830")]
		private DataBundle _GenerateDataBundleToRuneStage(string activityId)
		{
			return null;
		}

		// Token: 0x06029750 RID: 169808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029750")]
		[Address(RVA = "0x24CFAC0", Offset = "0x24CE6C0", VA = "0x1824CFAC0")]
		private void _TweenPointText(int targetValue)
		{
		}

		// Token: 0x06029751 RID: 169809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029751")]
		[Address(RVA = "0x24CF980", Offset = "0x24CE580", VA = "0x1824CF980")]
		private void _SetPointText(int value)
		{
		}

		// Token: 0x06029752 RID: 169810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029752")]
		[Address(RVA = "0x24CFDB0", Offset = "0x24CE9B0", VA = "0x1824CFDB0")]
		public Act5D1RuneStageState()
		{
		}

		// Token: 0x06029758 RID: 169816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029758")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029759 RID: 169817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029759")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602975A RID: 169818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B39D RID: 242589
		[Token(Token = "0x403B39D")]
		[FieldOffset(Offset = "0x0")]
		public static Color NEW_HAND_COLOR;

		// Token: 0x0403B39E RID: 242590
		[Token(Token = "0x403B39E")]
		[FieldOffset(Offset = "0x10")]
		public static Color WARNING_COLOR;

		// Token: 0x0403B39F RID: 242591
		[Token(Token = "0x403B39F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D1RuneStageStateBean _stateBean;

		// Token: 0x0403B3A0 RID: 242592
		[Token(Token = "0x403B3A0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act5D1RuneStageRuneContainer _runeContainer;

		// Token: 0x0403B3A1 RID: 242593
		[Token(Token = "0x403B3A1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act5D1RuneStageSelectRuneContainer _selectedContainer;

		// Token: 0x0403B3A2 RID: 242594
		[Token(Token = "0x403B3A2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act5D1RuneStageDetailContainer _detailContainer;

		// Token: 0x0403B3A3 RID: 242595
		[Token(Token = "0x403B3A3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act5D1RuneStagePreview _stagePreview;

		// Token: 0x0403B3A4 RID: 242596
		[Token(Token = "0x403B3A4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B3A5 RID: 242597
		[Token(Token = "0x403B3A5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _pointText;

		// Token: 0x0403B3A6 RID: 242598
		[Token(Token = "0x403B3A6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _pointText2;

		// Token: 0x0403B3A7 RID: 242599
		[Token(Token = "0x403B3A7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Act5D1ResourceBar _resourceBar;

		// Token: 0x0403B3A8 RID: 242600
		[Token(Token = "0x403B3A8")]
		[FieldOffset(Offset = "0xB8")]
		private string m_stageId;

		// Token: 0x0403B3A9 RID: 242601
		[Token(Token = "0x403B3A9")]
		[FieldOffset(Offset = "0xC0")]
		private string m_runeId;

		// Token: 0x0403B3AA RID: 242602
		[Token(Token = "0x403B3AA")]
		private const float DUR_PER_POINT = 0.1f;

		// Token: 0x0403B3AB RID: 242603
		[Token(Token = "0x403B3AB")]
		private const float MAX_DUR_POINT = 0.6f;

		// Token: 0x0403B3AC RID: 242604
		[Token(Token = "0x403B3AC")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_pointTextTween;

		// Token: 0x0403B3AD RID: 242605
		[Token(Token = "0x403B3AD")]
		[FieldOffset(Offset = "0xD0")]
		private int m_currentPoint;

		// Token: 0x0403B3AE RID: 242606
		[Token(Token = "0x403B3AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B3AF RID: 242607
		[Token(Token = "0x403B3AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B3B0 RID: 242608
		[Token(Token = "0x403B3B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B3B1 RID: 242609
		[Token(Token = "0x403B3B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshPointInfo;

		// Token: 0x0403B3B2 RID: 242610
		[Token(Token = "0x403B3B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403B3B3 RID: 242611
		[Token(Token = "0x403B3B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B3B4 RID: 242612
		[Token(Token = "0x403B3B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickToEnemyHandBook;

		// Token: 0x0403B3B5 RID: 242613
		[Token(Token = "0x403B3B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B3B6 RID: 242614
		[Token(Token = "0x403B3B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToDetailState;

		// Token: 0x0403B3B7 RID: 242615
		[Token(Token = "0x403B3B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CleanAllSelect;

		// Token: 0x0403B3B8 RID: 242616
		[Token(Token = "0x403B3B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OpenSquadPage;

		// Token: 0x0403B3B9 RID: 242617
		[Token(Token = "0x403B3B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateActMeta4BattleFinish;

		// Token: 0x0403B3BA RID: 242618
		[Token(Token = "0x403B3BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenerateDataBundleToRuneStage;

		// Token: 0x0403B3BB RID: 242619
		[Token(Token = "0x403B3BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TweenPointText;

		// Token: 0x0403B3BC RID: 242620
		[Token(Token = "0x403B3BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetPointText;

		// Token: 0x0403B3BD RID: 242621
		[Token(Token = "0x403B3BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
