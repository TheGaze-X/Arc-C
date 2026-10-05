using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200695C RID: 26972
	[Token(Token = "0x200695C")]
	public class StageCustomZoneContainerHolder : DataBinder<ZoneViewProperty>
	{
		// Token: 0x060269AA RID: 158122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AA")]
		[Address(RVA = "0x21AB390", Offset = "0x21A9F90", VA = "0x1821AB390")]
		private void _OnMapNotFound(string zoneId)
		{
		}

		// Token: 0x060269AB RID: 158123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AB")]
		[Address(RVA = "0x21AB300", Offset = "0x21A9F00", VA = "0x1821AB300")]
		private void _OnMapLoadFinish(string zoneId)
		{
		}

		// Token: 0x060269AC RID: 158124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AC")]
		[Address(RVA = "0x21AB540", Offset = "0x21AA140", VA = "0x1821AB540")]
		private void _OnStageClicked(string stageId)
		{
		}

		// Token: 0x060269AD RID: 158125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AD")]
		[Address(RVA = "0x21AB5D0", Offset = "0x21AA1D0", VA = "0x1821AB5D0")]
		private void _OnStageFogClicked(string stageId)
		{
		}

		// Token: 0x060269AE RID: 158126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AE")]
		[Address(RVA = "0x21AB4B0", Offset = "0x21AA0B0", VA = "0x1821AB4B0")]
		private void _OnSpecialStageRewardClicked(string stageId)
		{
		}

		// Token: 0x060269AF RID: 158127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269AF")]
		[Address(RVA = "0x21AB420", Offset = "0x21AA020", VA = "0x1821AB420")]
		private void _OnSelectDiffAction(StageDiffGroup diffGroup)
		{
		}

		// Token: 0x060269B0 RID: 158128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B0")]
		[Address(RVA = "0x21AB290", Offset = "0x21A9E90", VA = "0x1821AB290")]
		private void _OnDiffSelectDetail()
		{
		}

		// Token: 0x060269B1 RID: 158129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B1")]
		[Address(RVA = "0x21AB1B0", Offset = "0x21A9DB0", VA = "0x1821AB1B0")]
		private void _OnAddedReceiveCacheEvent()
		{
		}

		// Token: 0x060269B2 RID: 158130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B2")]
		[Address(RVA = "0x21AB220", Offset = "0x21A9E20", VA = "0x1821AB220")]
		private void _OnClosePreviewEvent()
		{
		}

		// Token: 0x060269B3 RID: 158131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B3")]
		[Address(RVA = "0x21AA7C0", Offset = "0x21A93C0", VA = "0x1821AA7C0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060269B4 RID: 158132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B4")]
		[Address(RVA = "0x21AB660", Offset = "0x21AA260", VA = "0x1821AB660")]
		private void _SetUp(ZoneViewModel model)
		{
		}

		// Token: 0x060269B5 RID: 158133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B5")]
		[Address(RVA = "0x21AAA00", Offset = "0x21A9600", VA = "0x1821AAA00")]
		private void _ClearLoadedContainer()
		{
		}

		// Token: 0x060269B6 RID: 158134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B6")]
		[Address(RVA = "0x21AAA80", Offset = "0x21A9680", VA = "0x1821AAA80")]
		private void _ClearUpdateCache()
		{
		}

		// Token: 0x060269B7 RID: 158135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B7")]
		[Address(RVA = "0x21AAAF0", Offset = "0x21A96F0", VA = "0x1821AAAF0")]
		private void _LoadZoneContainer(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060269B8 RID: 158136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B8")]
		[Address(RVA = "0x21AA760", Offset = "0x21A9360", VA = "0x1821AA760")]
		private void OnDestroy()
		{
		}

		// Token: 0x060269B9 RID: 158137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269B9")]
		[Address(RVA = "0x21AB760", Offset = "0x21AA360", VA = "0x1821AB760")]
		public StageCustomZoneContainerHolder()
		{
		}

		// Token: 0x04036784 RID: 223108
		[Token(Token = "0x4036784")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _zoneContainerHolder;

		// Token: 0x04036785 RID: 223109
		[Token(Token = "0x4036785")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStringEvent _eventMapNotFound;

		// Token: 0x04036786 RID: 223110
		[Token(Token = "0x4036786")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIStringEvent _eventMapLoadFinish;

		// Token: 0x04036787 RID: 223111
		[Token(Token = "0x4036787")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageCustomZoneContainerHolder.StageStringClickEvent _stageSelectEvent;

		// Token: 0x04036788 RID: 223112
		[Token(Token = "0x4036788")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _stageFogUnlockEvent;

		// Token: 0x04036789 RID: 223113
		[Token(Token = "0x4036789")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StageCustomZoneContainerHolder.StageStringClickEvent _specialStageRewardEvent;

		// Token: 0x0403678A RID: 223114
		[Token(Token = "0x403678A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIDiffGroupEvent _selectDiffAction;

		// Token: 0x0403678B RID: 223115
		[Token(Token = "0x403678B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _onDiffSelectDetail;

		// Token: 0x0403678C RID: 223116
		[Token(Token = "0x403678C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent _onAddedReceiveCacheEvent;

		// Token: 0x0403678D RID: 223117
		[Token(Token = "0x403678D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnityEvent _onClosePreviewEvent;

		// Token: 0x0403678E RID: 223118
		[Token(Token = "0x403678E")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403678F RID: 223119
		[Token(Token = "0x403678F")]
		[FieldOffset(Offset = "0x80")]
		private StageCustomZoneContainer m_zoneContainer;

		// Token: 0x04036790 RID: 223120
		[Token(Token = "0x4036790")]
		[FieldOffset(Offset = "0x88")]
		private string m_zoneContainerAssetPathCache;

		// Token: 0x04036791 RID: 223121
		[Token(Token = "0x4036791")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnMapNotFound;

		// Token: 0x04036792 RID: 223122
		[Token(Token = "0x4036792")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnMapLoadFinish;

		// Token: 0x04036793 RID: 223123
		[Token(Token = "0x4036793")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStageClicked;

		// Token: 0x04036794 RID: 223124
		[Token(Token = "0x4036794")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStageFogClicked;

		// Token: 0x04036795 RID: 223125
		[Token(Token = "0x4036795")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSpecialStageRewardClicked;

		// Token: 0x04036796 RID: 223126
		[Token(Token = "0x4036796")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSelectDiffAction;

		// Token: 0x04036797 RID: 223127
		[Token(Token = "0x4036797")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDiffSelectDetail;

		// Token: 0x04036798 RID: 223128
		[Token(Token = "0x4036798")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnAddedReceiveCacheEvent;

		// Token: 0x04036799 RID: 223129
		[Token(Token = "0x4036799")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClosePreviewEvent;

		// Token: 0x0403679A RID: 223130
		[Token(Token = "0x403679A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403679B RID: 223131
		[Token(Token = "0x403679B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetUp;

		// Token: 0x0403679C RID: 223132
		[Token(Token = "0x403679C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearLoadedContainer;

		// Token: 0x0403679D RID: 223133
		[Token(Token = "0x403679D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearUpdateCache;

		// Token: 0x0403679E RID: 223134
		[Token(Token = "0x403679E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadZoneContainer;

		// Token: 0x0403679F RID: 223135
		[Token(Token = "0x403679F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040367A0 RID: 223136
		[Token(Token = "0x40367A0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200695D RID: 26973
		[Token(Token = "0x200695D")]
		[Serializable]
		public class StageStringClickEvent : UnityEvent<string>
		{
			// Token: 0x060269BA RID: 158138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60269BA")]
			[Address(RVA = "0x21B73B0", Offset = "0x21B5FB0", VA = "0x1821B73B0")]
			public StageStringClickEvent()
			{
			}
		}
	}
}
