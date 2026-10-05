using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004726 RID: 18214
	[Token(Token = "0x2004726")]
	public class RecruitBuildSlotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B9AA RID: 113066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9AA")]
		[Address(RVA = "0x14F8630", Offset = "0x14F7230", VA = "0x1814F8630")]
		public void Render(BuildSlotViewModel viewModel)
		{
		}

		// Token: 0x0601B9AB RID: 113067 RVA: 0x000A5A80 File Offset: 0x000A3C80
		[Token(Token = "0x601B9AB")]
		[Address(RVA = "0x14F8540", Offset = "0x14F7140", VA = "0x1814F8540")]
		public bool RegisterEmptySlotForAVG()
		{
			return default(bool);
		}

		// Token: 0x0601B9AC RID: 113068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9AC")]
		[Address(RVA = "0x14F8F20", Offset = "0x14F7B20", VA = "0x1814F8F20")]
		private void _RenderResultView(BuildSlotViewModel viewModel)
		{
		}

		// Token: 0x0601B9AD RID: 113069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9AD")]
		[Address(RVA = "0x14F8BF0", Offset = "0x14F77F0", VA = "0x1814F8BF0")]
		private void _OnSlotStateChanged(BuildSlotViewModel viewModel, RecruitBuildSlotState? prev, RecruitBuildSlotState? current)
		{
		}

		// Token: 0x0601B9AE RID: 113070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9AE")]
		[Address(RVA = "0x14F8B70", Offset = "0x14F7770", VA = "0x1814F8B70")]
		private void Update()
		{
		}

		// Token: 0x0601B9AF RID: 113071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9AF")]
		[Address(RVA = "0x14F8CD0", Offset = "0x14F78D0", VA = "0x1814F8CD0")]
		private void _RenderBuildingView(BuildSlotViewModel viewModel)
		{
		}

		// Token: 0x0601B9B0 RID: 113072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B0")]
		[Address(RVA = "0x14F8230", Offset = "0x14F6E30", VA = "0x1814F8230")]
		private void OnBuildTimeUp()
		{
		}

		// Token: 0x0601B9B1 RID: 113073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B1")]
		[Address(RVA = "0x14F8340", Offset = "0x14F6F40", VA = "0x1814F8340")]
		public void OnFashFinish()
		{
		}

		// Token: 0x0601B9B2 RID: 113074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B2")]
		[Address(RVA = "0x14F84C0", Offset = "0x14F70C0", VA = "0x1814F84C0")]
		public void OnStopRecruit()
		{
		}

		// Token: 0x0601B9B3 RID: 113075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B3")]
		[Address(RVA = "0x14F8440", Offset = "0x14F7040", VA = "0x1814F8440")]
		public void OnStartRecruit()
		{
		}

		// Token: 0x0601B9B4 RID: 113076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B4")]
		[Address(RVA = "0x14F83C0", Offset = "0x14F6FC0", VA = "0x1814F83C0")]
		public void OnFinishBuild()
		{
		}

		// Token: 0x0601B9B5 RID: 113077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B5")]
		[Address(RVA = "0x14F82C0", Offset = "0x14F6EC0", VA = "0x1814F82C0")]
		public void OnBuySlot()
		{
		}

		// Token: 0x0601B9B6 RID: 113078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B6")]
		[Address(RVA = "0x14F8FC0", Offset = "0x14F7BC0", VA = "0x1814F8FC0")]
		public RecruitBuildSlotView()
		{
		}

		// Token: 0x04023C66 RID: 146534
		[Token(Token = "0x4023C66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textSlotNum;

		// Token: 0x04023C67 RID: 146535
		[Token(Token = "0x4023C67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelBuilding;

		// Token: 0x04023C68 RID: 146536
		[Token(Token = "0x4023C68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04023C69 RID: 146537
		[Token(Token = "0x4023C69")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04023C6A RID: 146538
		[Token(Token = "0x4023C6A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFinish;

		// Token: 0x04023C6B RID: 146539
		[Token(Token = "0x4023C6B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04023C6C RID: 146540
		[Token(Token = "0x4023C6C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RecruitBuildTagGroupView _requireTagGroup;

		// Token: 0x04023C6D RID: 146541
		[Token(Token = "0x4023C6D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RecruitBuildTagGroupView _resultTagGroup;

		// Token: 0x04023C6E RID: 146542
		[Token(Token = "0x4023C6E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RecruitBuildCostView _costView;

		// Token: 0x04023C6F RID: 146543
		[Token(Token = "0x4023C6F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textLockedView;

		// Token: 0x04023C70 RID: 146544
		[Token(Token = "0x4023C70")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<int> fastFinishListener;

		// Token: 0x04023C71 RID: 146545
		[Token(Token = "0x4023C71")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<int> stopRecruitListener;

		// Token: 0x04023C72 RID: 146546
		[Token(Token = "0x4023C72")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<int> startRecruitListener;

		// Token: 0x04023C73 RID: 146547
		[Token(Token = "0x4023C73")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<int> buildTimeUpListener;

		// Token: 0x04023C74 RID: 146548
		[Token(Token = "0x4023C74")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<int> finishBuildListener;

		// Token: 0x04023C75 RID: 146549
		[Token(Token = "0x4023C75")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<int> buySlotListener;

		// Token: 0x04023C76 RID: 146550
		[Token(Token = "0x4023C76")]
		[FieldOffset(Offset = "0x98")]
		private int m_slotIndexCache;

		// Token: 0x04023C77 RID: 146551
		[Token(Token = "0x4023C77")]
		[FieldOffset(Offset = "0x9C")]
		private RecruitBuildSlotState? m_slotStateCache;

		// Token: 0x04023C78 RID: 146552
		[Token(Token = "0x4023C78")]
		[FieldOffset(Offset = "0xA8")]
		private BuildTagModel[] m_requireTagsCache;

		// Token: 0x04023C79 RID: 146553
		[Token(Token = "0x4023C79")]
		[FieldOffset(Offset = "0xB0")]
		private BuildTagModel[] m_resultTagsCache;

		// Token: 0x04023C7A RID: 146554
		[Token(Token = "0x4023C7A")]
		[FieldOffset(Offset = "0xB8")]
		private CountDownTask m_realTimeCountDown;

		// Token: 0x04023C7B RID: 146555
		[Token(Token = "0x4023C7B")]
		[FieldOffset(Offset = "0xC0")]
		private CountDownTask m_showTimeCountDown;

		// Token: 0x04023C7C RID: 146556
		[Token(Token = "0x4023C7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023C7D RID: 146557
		[Token(Token = "0x4023C7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterEmptySlotForAVG;

		// Token: 0x04023C7E RID: 146558
		[Token(Token = "0x4023C7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderResultView;

		// Token: 0x04023C7F RID: 146559
		[Token(Token = "0x4023C7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSlotStateChanged;

		// Token: 0x04023C80 RID: 146560
		[Token(Token = "0x4023C80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04023C81 RID: 146561
		[Token(Token = "0x4023C81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBuildingView;

		// Token: 0x04023C82 RID: 146562
		[Token(Token = "0x4023C82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBuildTimeUp;

		// Token: 0x04023C83 RID: 146563
		[Token(Token = "0x4023C83")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnFashFinish;

		// Token: 0x04023C84 RID: 146564
		[Token(Token = "0x4023C84")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStopRecruit;

		// Token: 0x04023C85 RID: 146565
		[Token(Token = "0x4023C85")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStartRecruit;

		// Token: 0x04023C86 RID: 146566
		[Token(Token = "0x4023C86")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFinishBuild;

		// Token: 0x04023C87 RID: 146567
		[Token(Token = "0x4023C87")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBuySlot;

		// Token: 0x04023C88 RID: 146568
		[Token(Token = "0x4023C88")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
