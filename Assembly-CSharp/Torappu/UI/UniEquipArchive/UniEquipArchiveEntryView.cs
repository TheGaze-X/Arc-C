using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF0 RID: 15344
	[Token(Token = "0x2003BF0")]
	public class UniEquipArchiveEntryView : DataBinder<UniEquipArchiveEntryProperty>
	{
		// Token: 0x06018011 RID: 98321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018011")]
		[Address(RVA = "0x1080460", Offset = "0x107F060", VA = "0x181080460", Slot = "7")]
		public override void OnValueChanged(UniEquipArchiveEntryProperty property)
		{
		}

		// Token: 0x06018012 RID: 98322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018012")]
		[Address(RVA = "0x10809E0", Offset = "0x107F5E0", VA = "0x1810809E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018013 RID: 98323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018013")]
		[Address(RVA = "0x1080CA0", Offset = "0x107F8A0", VA = "0x181080CA0")]
		private void _ShowEnterAnim()
		{
		}

		// Token: 0x06018014 RID: 98324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018014")]
		[Address(RVA = "0x1080DD0", Offset = "0x107F9D0", VA = "0x181080DD0")]
		private void _UpdateTrackPoint()
		{
		}

		// Token: 0x06018015 RID: 98325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018015")]
		[Address(RVA = "0x1080B70", Offset = "0x107F770", VA = "0x181080B70")]
		private void _PlaySwitchInfoAnim()
		{
		}

		// Token: 0x06018016 RID: 98326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018016")]
		[Address(RVA = "0x1080180", Offset = "0x107ED80", VA = "0x181080180")]
		public void OnOpenCharacterClick()
		{
		}

		// Token: 0x06018017 RID: 98327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018017")]
		[Address(RVA = "0x10802B0", Offset = "0x107EEB0", VA = "0x1810802B0")]
		public void OnSwitchInfoTypeClick()
		{
		}

		// Token: 0x06018018 RID: 98328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018018")]
		[Address(RVA = "0x1080210", Offset = "0x107EE10", VA = "0x181080210")]
		public void OnOpenModuleListClick()
		{
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018019")]
		[Address(RVA = "0x1080E50", Offset = "0x107FA50", VA = "0x181080E50")]
		public UniEquipArchiveEntryView()
		{
		}

		// Token: 0x0401D154 RID: 119124
		[Token(Token = "0x401D154")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _infoContent;

		// Token: 0x0401D155 RID: 119125
		[Token(Token = "0x401D155")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtNewEditionCnt;

		// Token: 0x0401D156 RID: 119126
		[Token(Token = "0x401D156")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UniEquipArchiveEntryCollectionNewEditionsAdapter _newEditionsAdapter;

		// Token: 0x0401D157 RID: 119127
		[Token(Token = "0x401D157")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopHorizontalScrollRect _horizontalScroll;

		// Token: 0x0401D158 RID: 119128
		[Token(Token = "0x401D158")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _charNewUniEquipTrackPoint;

		// Token: 0x0401D159 RID: 119129
		[Token(Token = "0x401D159")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0401D15A RID: 119130
		[Token(Token = "0x401D15A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _switchIconAnim;

		// Token: 0x0401D15B RID: 119131
		[Token(Token = "0x401D15B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0401D15C RID: 119132
		[Token(Token = "0x401D15C")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D15D RID: 119133
		[Token(Token = "0x401D15D")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipArchiveEntryViewModel m_cachedViewModel;

		// Token: 0x0401D15E RID: 119134
		[Token(Token = "0x401D15E")]
		[FieldOffset(Offset = "0x88")]
		private UniEquipArchiveEntryView.UniEquipArchiveEntryCollectionInfoListAdapter m_infoListAdapter;

		// Token: 0x0401D15F RID: 119135
		[Token(Token = "0x401D15F")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_charNewUniEquipTrackPointProperty;

		// Token: 0x0401D160 RID: 119136
		[Token(Token = "0x401D160")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedEnterSeq;

		// Token: 0x0401D161 RID: 119137
		[Token(Token = "0x401D161")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_showTween;

		// Token: 0x0401D162 RID: 119138
		[Token(Token = "0x401D162")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_switchIconTween;

		// Token: 0x0401D163 RID: 119139
		[Token(Token = "0x401D163")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D164 RID: 119140
		[Token(Token = "0x401D164")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D165 RID: 119141
		[Token(Token = "0x401D165")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowEnterAnim;

		// Token: 0x0401D166 RID: 119142
		[Token(Token = "0x401D166")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x0401D167 RID: 119143
		[Token(Token = "0x401D167")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySwitchInfoAnim;

		// Token: 0x0401D168 RID: 119144
		[Token(Token = "0x401D168")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOpenCharacterClick;

		// Token: 0x0401D169 RID: 119145
		[Token(Token = "0x401D169")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSwitchInfoTypeClick;

		// Token: 0x0401D16A RID: 119146
		[Token(Token = "0x401D16A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnOpenModuleListClick;

		// Token: 0x0401D16B RID: 119147
		[Token(Token = "0x401D16B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BF1 RID: 15345
		[Token(Token = "0x2003BF1")]
		private class UniEquipArchiveEntryCollectionInfoListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601801A RID: 98330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601801A")]
			[Address(RVA = "0x107B780", Offset = "0x107A380", VA = "0x18107B780")]
			public UniEquipArchiveEntryCollectionInfoListAdapter(UniEquipArchiveEntryView closure)
			{
			}

			// Token: 0x17003942 RID: 14658
			// (get) Token: 0x0601801B RID: 98331 RVA: 0x00098EC8 File Offset: 0x000970C8
			[Token(Token = "0x17003942")]
			public override int count
			{
				[Token(Token = "0x601801B")]
				[Address(RVA = "0x107B800", Offset = "0x107A400", VA = "0x18107B800", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601801C RID: 98332 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601801C")]
			[Address(RVA = "0x107B580", Offset = "0x107A180", VA = "0x18107B580", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D16C RID: 119148
			[Token(Token = "0x401D16C")]
			[FieldOffset(Offset = "0x20")]
			private UniEquipArchiveEntryView m_closure;

			// Token: 0x0401D16D RID: 119149
			[Token(Token = "0x401D16D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D16E RID: 119150
			[Token(Token = "0x401D16E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D16F RID: 119151
			[Token(Token = "0x401D16F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
