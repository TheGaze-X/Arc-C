using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200698C RID: 27020
	[Token(Token = "0x200698C")]
	public class StageZoneMapContainer : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026AA2 RID: 158370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA2")]
		[Address(RVA = "0x21C5710", Offset = "0x21C4310", VA = "0x1821C5710")]
		private void _MoveMapWithTween(Vector2 targetAnchorPos)
		{
		}

		// Token: 0x06026AA3 RID: 158371 RVA: 0x000CBF28 File Offset: 0x000CA128
		[Token(Token = "0x6026AA3")]
		[Address(RVA = "0x21C5400", Offset = "0x21C4000", VA = "0x1821C5400")]
		private Vector2 _GetMapPos()
		{
			return default(Vector2);
		}

		// Token: 0x06026AA4 RID: 158372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA4")]
		[Address(RVA = "0x21C50F0", Offset = "0x21C3CF0", VA = "0x1821C50F0")]
		private void _FocusOnSelectedStage(string focusStageId)
		{
		}

		// Token: 0x06026AA5 RID: 158373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA5")]
		[Address(RVA = "0x21C4BB0", Offset = "0x21C37B0", VA = "0x1821C4BB0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026AA6 RID: 158374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA6")]
		[Address(RVA = "0x21C4F00", Offset = "0x21C3B00", VA = "0x1821C4F00")]
		private void Start()
		{
		}

		// Token: 0x06026AA7 RID: 158375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA7")]
		[Address(RVA = "0x21C4B50", Offset = "0x21C3750", VA = "0x1821C4B50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06026AA8 RID: 158376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA8")]
		[Address(RVA = "0x21C5890", Offset = "0x21C4490", VA = "0x1821C5890")]
		private void _OnStageSelected(string stageId)
		{
		}

		// Token: 0x06026AA9 RID: 158377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA9")]
		[Address(RVA = "0x21C4FE0", Offset = "0x21C3BE0", VA = "0x1821C4FE0")]
		private void _ClearCachedMap()
		{
		}

		// Token: 0x06026AAA RID: 158378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AAA")]
		[Address(RVA = "0x21C5050", Offset = "0x21C3C50", VA = "0x1821C5050")]
		private void _ClearUpdateCache()
		{
		}

		// Token: 0x06026AAB RID: 158379 RVA: 0x000CBF40 File Offset: 0x000CA140
		[Token(Token = "0x6026AAB")]
		[Address(RVA = "0x21C5470", Offset = "0x21C4070", VA = "0x1821C5470")]
		private bool _LoadZoneMap(ZoneViewModel zoneModel)
		{
			return default(bool);
		}

		// Token: 0x06026AAC RID: 158380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AAC")]
		[Address(RVA = "0x21C5920", Offset = "0x21C4520", VA = "0x1821C5920")]
		public StageZoneMapContainer()
		{
		}

		// Token: 0x04036953 RID: 223571
		[Token(Token = "0x4036953")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Event to notify a stage button is clicked, param : stageId")]
		private StageZoneMapContainer.StageClickEvent _onStageClicked;

		// Token: 0x04036954 RID: 223572
		[Token(Token = "0x4036954")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Used to change the position of whole zone map")]
		private RectTransform _mapPositionHandler;

		// Token: 0x04036955 RID: 223573
		[Token(Token = "0x4036955")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Parent transform of the map, note that all its children will be replaced at runtime")]
		private RectTransform _mapParent;

		// Token: 0x04036956 RID: 223574
		[Token(Token = "0x4036956")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Hotspot to show selected stage")]
		private RectTransform _stageHotspot;

		// Token: 0x04036957 RID: 223575
		[Token(Token = "0x4036957")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _eventMapNotFound;

		// Token: 0x04036958 RID: 223576
		[Token(Token = "0x4036958")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _eventMapLoadFinish;

		// Token: 0x04036959 RID: 223577
		[Token(Token = "0x4036959")]
		[FieldOffset(Offset = "0x50")]
		private string m_zoneMapAssetPathCache;

		// Token: 0x0403695A RID: 223578
		[Token(Token = "0x403695A")]
		[FieldOffset(Offset = "0x58")]
		private string m_selectedStageIdCache;

		// Token: 0x0403695B RID: 223579
		[Token(Token = "0x403695B")]
		[FieldOffset(Offset = "0x60")]
		private string m_focusStageIdCache;

		// Token: 0x0403695C RID: 223580
		[Token(Token = "0x403695C")]
		[FieldOffset(Offset = "0x68")]
		private StageZoneMap m_zoneMap;

		// Token: 0x0403695D RID: 223581
		[Token(Token = "0x403695D")]
		private const float ANIM_DURATION = 0.5f;

		// Token: 0x0403695E RID: 223582
		[Token(Token = "0x403695E")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_originMapPos;

		// Token: 0x0403695F RID: 223583
		[Token(Token = "0x403695F")]
		[FieldOffset(Offset = "0x78")]
		private Bounds m_stageHotspotBound;

		// Token: 0x04036960 RID: 223584
		[Token(Token = "0x4036960")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_mapTweener;

		// Token: 0x04036961 RID: 223585
		[Token(Token = "0x4036961")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__MoveMapWithTween;

		// Token: 0x04036962 RID: 223586
		[Token(Token = "0x4036962")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMapPos;

		// Token: 0x04036963 RID: 223587
		[Token(Token = "0x4036963")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FocusOnSelectedStage;

		// Token: 0x04036964 RID: 223588
		[Token(Token = "0x4036964")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036965 RID: 223589
		[Token(Token = "0x4036965")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04036966 RID: 223590
		[Token(Token = "0x4036966")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04036967 RID: 223591
		[Token(Token = "0x4036967")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnStageSelected;

		// Token: 0x04036968 RID: 223592
		[Token(Token = "0x4036968")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearCachedMap;

		// Token: 0x04036969 RID: 223593
		[Token(Token = "0x4036969")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearUpdateCache;

		// Token: 0x0403696A RID: 223594
		[Token(Token = "0x403696A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadZoneMap;

		// Token: 0x0403696B RID: 223595
		[Token(Token = "0x403696B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200698D RID: 27021
		[Token(Token = "0x200698D")]
		[Serializable]
		public class StageClickEvent : UnityEvent<string>
		{
			// Token: 0x06026AAD RID: 158381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026AAD")]
			[Address(RVA = "0x21BA800", Offset = "0x21B9400", VA = "0x1821BA800")]
			public StageClickEvent()
			{
			}
		}

		// Token: 0x0200698E RID: 27022
		[Token(Token = "0x200698E")]
		[Serializable]
		public class FocusStageEvent : UnityEvent<string>
		{
			// Token: 0x06026AAE RID: 158382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026AAE")]
			[Address(RVA = "0x21BA640", Offset = "0x21B9240", VA = "0x1821BA640")]
			public FocusStageEvent()
			{
			}
		}
	}
}
