using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200513A RID: 20794
	[Token(Token = "0x200513A")]
	public class DeepSeaRPZoneMapView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x0601EB87 RID: 125831 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
		// (set) Token: 0x0601EB88 RID: 125832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004798")]
		public bool isMapLock
		{
			[Token(Token = "0x601EB87")]
			[Address(RVA = "0x1879010", Offset = "0x1877C10", VA = "0x181879010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601EB88")]
			[Address(RVA = "0x1879130", Offset = "0x1877D30", VA = "0x181879130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x0601EB89 RID: 125833 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EB8A RID: 125834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004799")]
		public Action<string, string> onNodeClick
		{
			[Token(Token = "0x601EB89")]
			[Address(RVA = "0x1879070", Offset = "0x1877C70", VA = "0x181879070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EB8A")]
			[Address(RVA = "0x18791A0", Offset = "0x1877DA0", VA = "0x1818791A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x0601EB8B RID: 125835 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EB8C RID: 125836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700479A")]
		public Action<string> onPlaceDiscover
		{
			[Token(Token = "0x601EB8B")]
			[Address(RVA = "0x18790D0", Offset = "0x1877CD0", VA = "0x1818790D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EB8C")]
			[Address(RVA = "0x1879220", Offset = "0x1877E20", VA = "0x181879220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EB8D RID: 125837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB8D")]
		[Address(RVA = "0x1878300", Offset = "0x1876F00", VA = "0x181878300")]
		public void Render(DeepSeaRPModel deepSeaModel, DeepSeaRPZoneMapContainer mapContainer, DeepSeaRPPlaceView placeTemplate, GameObject cursorTemplate)
		{
		}

		// Token: 0x0601EB8E RID: 125838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB8E")]
		[Address(RVA = "0x1877D10", Offset = "0x1876910", VA = "0x181877D10")]
		public void AdjustMapView()
		{
		}

		// Token: 0x0601EB8F RID: 125839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB8F")]
		[Address(RVA = "0x1878A20", Offset = "0x1877620", VA = "0x181878A20")]
		private void _UpdateMapHint()
		{
		}

		// Token: 0x0601EB90 RID: 125840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB90")]
		[Address(RVA = "0x1878D20", Offset = "0x1877920", VA = "0x181878D20")]
		private void _UpdateSlideBgPos()
		{
		}

		// Token: 0x0601EB91 RID: 125841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB91")]
		[Address(RVA = "0x1877FB0", Offset = "0x1876BB0", VA = "0x181877FB0")]
		public void FocusOnPlace(string placeId)
		{
		}

		// Token: 0x0601EB92 RID: 125842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB92")]
		[Address(RVA = "0x1878770", Offset = "0x1877370", VA = "0x181878770")]
		public void TryScrollToEnd(DeepSeaRPModel deepSeaModel)
		{
		}

		// Token: 0x0601EB93 RID: 125843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB93")]
		[Address(RVA = "0x1878870", Offset = "0x1877470", VA = "0x181878870")]
		private void _ScrollTo(float normalizedVal)
		{
		}

		// Token: 0x0601EB94 RID: 125844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB94")]
		[Address(RVA = "0x1878280", Offset = "0x1876E80", VA = "0x181878280")]
		public void OnScroll(Vector2 _)
		{
		}

		// Token: 0x0601EB95 RID: 125845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB95")]
		[Address(RVA = "0x1878F50", Offset = "0x1877B50", VA = "0x181878F50")]
		public DeepSeaRPZoneMapView()
		{
		}

		// Token: 0x04029337 RID: 168759
		[Token(Token = "0x4029337")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DeepSeaRPPlaceHolder[] _placeHolderList;

		// Token: 0x04029338 RID: 168760
		[Token(Token = "0x4029338")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cursorContainer;

		// Token: 0x04029339 RID: 168761
		[Token(Token = "0x4029339")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _contentRt;

		// Token: 0x0402933A RID: 168762
		[Token(Token = "0x402933A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _mapScroll;

		// Token: 0x0402933B RID: 168763
		[Token(Token = "0x402933B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _mapPadding;

		// Token: 0x0402933C RID: 168764
		[Token(Token = "0x402933C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _contentWidthLimit;

		// Token: 0x0402933D RID: 168765
		[Token(Token = "0x402933D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x0402933E RID: 168766
		[Token(Token = "0x402933E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _slideBgRt;

		// Token: 0x0402933F RID: 168767
		[Token(Token = "0x402933F")]
		[FieldOffset(Offset = "0x50")]
		private List<DeepSeaRPPlaceHolder> m_trackPointPlaceList;

		// Token: 0x04029340 RID: 168768
		[Token(Token = "0x4029340")]
		[FieldOffset(Offset = "0x58")]
		private DeepSeaRPZoneMapContainer m_mapContainer;

		// Token: 0x04029341 RID: 168769
		[Token(Token = "0x4029341")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_cursorGo;

		// Token: 0x04029342 RID: 168770
		[Token(Token = "0x4029342")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_posTween;

		// Token: 0x04029343 RID: 168771
		[Token(Token = "0x4029343")]
		[FieldOffset(Offset = "0x70")]
		private float m_cacheWidth;

		// Token: 0x04029344 RID: 168772
		[Token(Token = "0x4029344")]
		[FieldOffset(Offset = "0x74")]
		private float m_maxContentWidth;

		// Token: 0x04029345 RID: 168773
		[Token(Token = "0x4029345")]
		[FieldOffset(Offset = "0x78")]
		private bool m_notFirstScroll;

		// Token: 0x04029349 RID: 168777
		[Token(Token = "0x4029349")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isMapLock;

		// Token: 0x0402934A RID: 168778
		[Token(Token = "0x402934A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isMapLock;

		// Token: 0x0402934B RID: 168779
		[Token(Token = "0x402934B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0402934C RID: 168780
		[Token(Token = "0x402934C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0402934D RID: 168781
		[Token(Token = "0x402934D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onPlaceDiscover;

		// Token: 0x0402934E RID: 168782
		[Token(Token = "0x402934E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onPlaceDiscover;

		// Token: 0x0402934F RID: 168783
		[Token(Token = "0x402934F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029350 RID: 168784
		[Token(Token = "0x4029350")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AdjustMapView;

		// Token: 0x04029351 RID: 168785
		[Token(Token = "0x4029351")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateMapHint;

		// Token: 0x04029352 RID: 168786
		[Token(Token = "0x4029352")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateSlideBgPos;

		// Token: 0x04029353 RID: 168787
		[Token(Token = "0x4029353")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FocusOnPlace;

		// Token: 0x04029354 RID: 168788
		[Token(Token = "0x4029354")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryScrollToEnd;

		// Token: 0x04029355 RID: 168789
		[Token(Token = "0x4029355")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ScrollTo;

		// Token: 0x04029356 RID: 168790
		[Token(Token = "0x4029356")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x04029357 RID: 168791
		[Token(Token = "0x4029357")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
