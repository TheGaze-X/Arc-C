using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200451F RID: 17695
	[Token(Token = "0x200451F")]
	public class RoguelikeCommonOuterBuffView : DataBinder<RoguelikeCommonOuterBuffProperty>
	{
		// Token: 0x0601AFB0 RID: 110512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB0")]
		[Address(RVA = "0x1426CB0", Offset = "0x14258B0", VA = "0x181426CB0")]
		private void Update()
		{
		}

		// Token: 0x0601AFB1 RID: 110513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB1")]
		[Address(RVA = "0x1426130", Offset = "0x1424D30", VA = "0x181426130")]
		public void Init(RoguelikeCommonOuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601AFB2 RID: 110514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB2")]
		[Address(RVA = "0x1426620", Offset = "0x1425220", VA = "0x181426620", Slot = "7")]
		public override void OnValueChanged(RoguelikeCommonOuterBuffProperty property)
		{
		}

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB3")]
		[Address(RVA = "0x1426E10", Offset = "0x1425A10", VA = "0x181426E10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB4")]
		[Address(RVA = "0x14273B0", Offset = "0x1425FB0", VA = "0x1814273B0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601AFB5 RID: 110517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB5")]
		[Address(RVA = "0x14270B0", Offset = "0x1425CB0", VA = "0x1814270B0")]
		private void _InitLocationGroup(RoguelikeCommonOuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601AFB6 RID: 110518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB6")]
		[Address(RVA = "0x1426450", Offset = "0x1425050", VA = "0x181426450")]
		public void OnLeftFocus()
		{
		}

		// Token: 0x0601AFB7 RID: 110519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB7")]
		[Address(RVA = "0x1426500", Offset = "0x1425100", VA = "0x181426500")]
		public void OnRightFocus()
		{
		}

		// Token: 0x0601AFB8 RID: 110520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB8")]
		[Address(RVA = "0x14263D0", Offset = "0x1424FD0", VA = "0x1814263D0")]
		public void OnBackgroundPress()
		{
		}

		// Token: 0x0601AFB9 RID: 110521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFB9")]
		[Address(RVA = "0x14265B0", Offset = "0x14251B0", VA = "0x1814265B0")]
		public void OnSummaryClick()
		{
		}

		// Token: 0x0601AFBA RID: 110522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFBA")]
		[Address(RVA = "0x1427500", Offset = "0x1426100", VA = "0x181427500")]
		public RoguelikeCommonOuterBuffView()
		{
		}

		// Token: 0x04022A4E RID: 141902
		[Token(Token = "0x4022A4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeCommonOuterBuffContentView _contentView;

		// Token: 0x04022A4F RID: 141903
		[Token(Token = "0x4022A4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeCommonOuterBuffBottomView _bottomView;

		// Token: 0x04022A50 RID: 141904
		[Token(Token = "0x4022A50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04022A51 RID: 141905
		[Token(Token = "0x4022A51")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04022A52 RID: 141906
		[Token(Token = "0x4022A52")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect _scroll;

		// Token: 0x04022A53 RID: 141907
		[Token(Token = "0x4022A53")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _contentRect;

		// Token: 0x04022A54 RID: 141908
		[Token(Token = "0x4022A54")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _locationRect;

		// Token: 0x04022A55 RID: 141909
		[Token(Token = "0x4022A55")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffView.LocationGroup> _locationGroups;

		// Token: 0x04022A56 RID: 141910
		[Token(Token = "0x4022A56")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnLeft;

		// Token: 0x04022A57 RID: 141911
		[Token(Token = "0x4022A57")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _btnRight;

		// Token: 0x04022A58 RID: 141912
		[Token(Token = "0x4022A58")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _focusLocation;

		// Token: 0x04022A59 RID: 141913
		[Token(Token = "0x4022A59")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x04022A5A RID: 141914
		[Token(Token = "0x4022A5A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _tokenName;

		// Token: 0x04022A5B RID: 141915
		[Token(Token = "0x4022A5B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _tokenCount;

		// Token: 0x04022A5C RID: 141916
		[Token(Token = "0x4022A5C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _activeCount;

		// Token: 0x04022A5D RID: 141917
		[Token(Token = "0x4022A5D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _totalCount;

		// Token: 0x04022A5E RID: 141918
		[Token(Token = "0x4022A5E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelTokenAll;

		// Token: 0x04022A5F RID: 141919
		[Token(Token = "0x4022A5F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelToken;

		// Token: 0x04022A60 RID: 141920
		[Token(Token = "0x4022A60")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _leftCanvasGroup;

		// Token: 0x04022A61 RID: 141921
		[Token(Token = "0x4022A61")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _rightCanvasGroup;

		// Token: 0x04022A62 RID: 141922
		[Token(Token = "0x4022A62")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x04022A63 RID: 141923
		[Token(Token = "0x4022A63")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public Action<string> onUpgradeClick;

		// Token: 0x04022A64 RID: 141924
		[Token(Token = "0x4022A64")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public Action onSummaryClick;

		// Token: 0x04022A65 RID: 141925
		[Token(Token = "0x4022A65")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x04022A66 RID: 141926
		[Token(Token = "0x4022A66")]
		[FieldOffset(Offset = "0xE8")]
		private RoguelikeCommonOuterBuffViewModel m_cachedViewModel;

		// Token: 0x04022A67 RID: 141927
		[Token(Token = "0x4022A67")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04022A68 RID: 141928
		[Token(Token = "0x4022A68")]
		[FieldOffset(Offset = "0xF8")]
		private List<RoguelikeCommonOuterBuffView.LocationData> m_locationDatas;

		// Token: 0x04022A69 RID: 141929
		[Token(Token = "0x4022A69")]
		[FieldOffset(Offset = "0x100")]
		private RoguelikeCommonOuterBuffView.LocationHandler m_locationHandler;

		// Token: 0x04022A6A RID: 141930
		[Token(Token = "0x4022A6A")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_enterTween;

		// Token: 0x04022A6B RID: 141931
		[Token(Token = "0x4022A6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04022A6C RID: 141932
		[Token(Token = "0x4022A6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022A6D RID: 141933
		[Token(Token = "0x4022A6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022A6E RID: 141934
		[Token(Token = "0x4022A6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022A6F RID: 141935
		[Token(Token = "0x4022A6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04022A70 RID: 141936
		[Token(Token = "0x4022A70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitLocationGroup;

		// Token: 0x04022A71 RID: 141937
		[Token(Token = "0x4022A71")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnLeftFocus;

		// Token: 0x04022A72 RID: 141938
		[Token(Token = "0x4022A72")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRightFocus;

		// Token: 0x04022A73 RID: 141939
		[Token(Token = "0x4022A73")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackgroundPress;

		// Token: 0x04022A74 RID: 141940
		[Token(Token = "0x4022A74")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSummaryClick;

		// Token: 0x04022A75 RID: 141941
		[Token(Token = "0x4022A75")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004520 RID: 17696
		[Token(Token = "0x2004520")]
		[Serializable]
		public struct LocationGroup
		{
			// Token: 0x04022A76 RID: 141942
			[Token(Token = "0x4022A76")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x04022A77 RID: 141943
			[Token(Token = "0x4022A77")]
			[FieldOffset(Offset = "0x8")]
			public float groupLocation;
		}

		// Token: 0x02004521 RID: 17697
		[Token(Token = "0x2004521")]
		private class LocationData : IHotfixable, IComparable<RoguelikeCommonOuterBuffView.LocationData>
		{
			// Token: 0x0601AFBB RID: 110523 RVA: 0x000A3C98 File Offset: 0x000A1E98
			[Token(Token = "0x601AFBB")]
			[Address(RVA = "0x1416FA0", Offset = "0x1415BA0", VA = "0x181416FA0", Slot = "4")]
			public int CompareTo(RoguelikeCommonOuterBuffView.LocationData other)
			{
				return 0;
			}

			// Token: 0x0601AFBC RID: 110524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFBC")]
			[Address(RVA = "0x1417020", Offset = "0x1415C20", VA = "0x181417020")]
			public LocationData()
			{
			}

			// Token: 0x04022A78 RID: 141944
			[Token(Token = "0x4022A78")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04022A79 RID: 141945
			[Token(Token = "0x4022A79")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04022A7A RID: 141946
			[Token(Token = "0x4022A7A")]
			[FieldOffset(Offset = "0x1C")]
			public bool isComplete;

			// Token: 0x04022A7B RID: 141947
			[Token(Token = "0x4022A7B")]
			[FieldOffset(Offset = "0x20")]
			public float location;

			// Token: 0x04022A7C RID: 141948
			[Token(Token = "0x4022A7C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04022A7D RID: 141949
			[Token(Token = "0x4022A7D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004522 RID: 17698
		[Token(Token = "0x2004522")]
		private class LocationHandler : IHotfixable
		{
			// Token: 0x0601AFBD RID: 110525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFBD")]
			[Address(RVA = "0x1417A60", Offset = "0x1416660", VA = "0x181417A60")]
			public LocationHandler(RoguelikeCommonOuterBuffView closure)
			{
			}

			// Token: 0x0601AFBE RID: 110526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFBE")]
			[Address(RVA = "0x1417370", Offset = "0x1415F70", VA = "0x181417370")]
			public void UpdateLocation()
			{
			}

			// Token: 0x0601AFBF RID: 110527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFBF")]
			[Address(RVA = "0x1417290", Offset = "0x1415E90", VA = "0x181417290")]
			public void FocusLeft()
			{
			}

			// Token: 0x0601AFC0 RID: 110528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC0")]
			[Address(RVA = "0x1417300", Offset = "0x1415F00", VA = "0x181417300")]
			public void FocusRight()
			{
			}

			// Token: 0x0601AFC1 RID: 110529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC1")]
			[Address(RVA = "0x1417080", Offset = "0x1415C80", VA = "0x181417080")]
			public void FocusIndex(int index, bool fastMode = false)
			{
			}

			// Token: 0x0601AFC2 RID: 110530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC2")]
			[Address(RVA = "0x1417700", Offset = "0x1416300", VA = "0x181417700")]
			private void _UpdateLocationButtonsStatus()
			{
			}

			// Token: 0x0601AFC3 RID: 110531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC3")]
			[Address(RVA = "0x14177D0", Offset = "0x14163D0", VA = "0x1814177D0")]
			private void _UpdateLocation()
			{
			}

			// Token: 0x0601AFC4 RID: 110532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC4")]
			[Address(RVA = "0x1417480", Offset = "0x1416080", VA = "0x181417480")]
			private void _FocusLocationImmediately(int index)
			{
			}

			// Token: 0x0601AFC5 RID: 110533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AFC5")]
			[Address(RVA = "0x14175B0", Offset = "0x14161B0", VA = "0x1814175B0")]
			private void _FocusLocation(int index)
			{
			}

			// Token: 0x04022A7E RID: 141950
			[Token(Token = "0x4022A7E")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeCommonOuterBuffView m_closure;

			// Token: 0x04022A7F RID: 141951
			[Token(Token = "0x4022A7F")]
			[FieldOffset(Offset = "0x18")]
			private int m_leftIndex;

			// Token: 0x04022A80 RID: 141952
			[Token(Token = "0x4022A80")]
			[FieldOffset(Offset = "0x1C")]
			private int m_rightIndex;

			// Token: 0x04022A81 RID: 141953
			[Token(Token = "0x4022A81")]
			[FieldOffset(Offset = "0x20")]
			private Tween m_focusTween;

			// Token: 0x04022A82 RID: 141954
			[Token(Token = "0x4022A82")]
			[FieldOffset(Offset = "0x28")]
			private FadeSwitchTween m_leftSwitchTween;

			// Token: 0x04022A83 RID: 141955
			[Token(Token = "0x4022A83")]
			[FieldOffset(Offset = "0x30")]
			private FadeSwitchTween m_rightSwitchTween;

			// Token: 0x04022A84 RID: 141956
			[Token(Token = "0x4022A84")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022A85 RID: 141957
			[Token(Token = "0x4022A85")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateLocation;

			// Token: 0x04022A86 RID: 141958
			[Token(Token = "0x4022A86")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FocusLeft;

			// Token: 0x04022A87 RID: 141959
			[Token(Token = "0x4022A87")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FocusRight;

			// Token: 0x04022A88 RID: 141960
			[Token(Token = "0x4022A88")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FocusIndex;

			// Token: 0x04022A89 RID: 141961
			[Token(Token = "0x4022A89")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__UpdateLocationButtonsStatus;

			// Token: 0x04022A8A RID: 141962
			[Token(Token = "0x4022A8A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__UpdateLocation;

			// Token: 0x04022A8B RID: 141963
			[Token(Token = "0x4022A8B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__FocusLocationImmediately;

			// Token: 0x04022A8C RID: 141964
			[Token(Token = "0x4022A8C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__FocusLocation;
		}
	}
}
