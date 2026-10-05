using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005138 RID: 20792
	[Token(Token = "0x2005138")]
	public class DeepSeaRPZoneMapContainer : DataBinder<DeepSeaRPProperty>
	{
		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x0601EB76 RID: 125814 RVA: 0x000AF548 File Offset: 0x000AD748
		[Token(Token = "0x17004793")]
		public float visibleOffset
		{
			[Token(Token = "0x601EB76")]
			[Address(RVA = "0x1877320", Offset = "0x1875F20", VA = "0x181877320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x0601EB77 RID: 125815 RVA: 0x000AF560 File Offset: 0x000AD760
		[Token(Token = "0x17004794")]
		public float unknownOffset
		{
			[Token(Token = "0x601EB77")]
			[Address(RVA = "0x18772C0", Offset = "0x1875EC0", VA = "0x1818772C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x0601EB78 RID: 125816 RVA: 0x000AF578 File Offset: 0x000AD778
		[Token(Token = "0x17004795")]
		public float greyOffset
		{
			[Token(Token = "0x601EB78")]
			[Address(RVA = "0x18771A0", Offset = "0x1875DA0", VA = "0x1818771A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x0601EB79 RID: 125817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EB7A RID: 125818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004796")]
		public Action<string, string> onNodeClick
		{
			[Token(Token = "0x601EB79")]
			[Address(RVA = "0x1877200", Offset = "0x1875E00", VA = "0x181877200")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EB7A")]
			[Address(RVA = "0x1877380", Offset = "0x1875F80", VA = "0x181877380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x0601EB7B RID: 125819 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EB7C RID: 125820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004797")]
		public Action<string> onPlaceDiscover
		{
			[Token(Token = "0x601EB7B")]
			[Address(RVA = "0x1877260", Offset = "0x1875E60", VA = "0x181877260")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EB7C")]
			[Address(RVA = "0x1877400", Offset = "0x1876000", VA = "0x181877400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EB7D RID: 125821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB7D")]
		[Address(RVA = "0x1876620", Offset = "0x1875220", VA = "0x181876620", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPProperty property)
		{
		}

		// Token: 0x0601EB7E RID: 125822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB7E")]
		[Address(RVA = "0x18768F0", Offset = "0x18754F0", VA = "0x1818768F0")]
		public void SetMapLock()
		{
		}

		// Token: 0x0601EB7F RID: 125823 RVA: 0x000AF590 File Offset: 0x000AD790
		[Token(Token = "0x601EB7F")]
		[Address(RVA = "0x1876530", Offset = "0x1875130", VA = "0x181876530")]
		public bool IsMapLock()
		{
			return default(bool);
		}

		// Token: 0x0601EB80 RID: 125824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB80")]
		[Address(RVA = "0x1876840", Offset = "0x1875440", VA = "0x181876840")]
		public void SetHintVisible(bool isLeft, bool isShow)
		{
		}

		// Token: 0x0601EB81 RID: 125825 RVA: 0x000AF5A8 File Offset: 0x000AD7A8
		[Token(Token = "0x601EB81")]
		[Address(RVA = "0x1876B50", Offset = "0x1875750", VA = "0x181876B50")]
		private bool _SetupZoneMapIfNeeded(DeepSeaRPModel deepSeaModel)
		{
			return default(bool);
		}

		// Token: 0x0601EB82 RID: 125826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EB82")]
		[Address(RVA = "0x18769F0", Offset = "0x18755F0", VA = "0x1818769F0")]
		private string _GetZoneMapAssetPath(string zoneId)
		{
			return null;
		}

		// Token: 0x0601EB83 RID: 125827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB83")]
		[Address(RVA = "0x1876470", Offset = "0x1875070", VA = "0x181876470")]
		public void FocusOnPlace(string placeId)
		{
		}

		// Token: 0x0601EB84 RID: 125828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB84")]
		[Address(RVA = "0x1877120", Offset = "0x1875D20", VA = "0x181877120")]
		public DeepSeaRPZoneMapContainer()
		{
		}

		// Token: 0x04029319 RID: 168729
		[Token(Token = "0x4029319")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _mapRoot;

		// Token: 0x0402931A RID: 168730
		[Token(Token = "0x402931A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DeepSeaRPPlaceView _placeTemplate;

		// Token: 0x0402931B RID: 168731
		[Token(Token = "0x402931B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _cursorTemplate;

		// Token: 0x0402931C RID: 168732
		[Token(Token = "0x402931C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _leftHintGo;

		// Token: 0x0402931D RID: 168733
		[Token(Token = "0x402931D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightHintGo;

		// Token: 0x0402931E RID: 168734
		[Token(Token = "0x402931E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _visibleOffset;

		// Token: 0x0402931F RID: 168735
		[Token(Token = "0x402931F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _unknownOffset;

		// Token: 0x04029320 RID: 168736
		[Token(Token = "0x4029320")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _greyOffset;

		// Token: 0x04029321 RID: 168737
		[Token(Token = "0x4029321")]
		[FieldOffset(Offset = "0x58")]
		private string m_currentZoneId;

		// Token: 0x04029322 RID: 168738
		[Token(Token = "0x4029322")]
		[FieldOffset(Offset = "0x60")]
		private DeepSeaRPZoneMapView m_mapView;

		// Token: 0x04029323 RID: 168739
		[Token(Token = "0x4029323")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04029326 RID: 168742
		[Token(Token = "0x4029326")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_visibleOffset;

		// Token: 0x04029327 RID: 168743
		[Token(Token = "0x4029327")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unknownOffset;

		// Token: 0x04029328 RID: 168744
		[Token(Token = "0x4029328")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_greyOffset;

		// Token: 0x04029329 RID: 168745
		[Token(Token = "0x4029329")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0402932A RID: 168746
		[Token(Token = "0x402932A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0402932B RID: 168747
		[Token(Token = "0x402932B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onPlaceDiscover;

		// Token: 0x0402932C RID: 168748
		[Token(Token = "0x402932C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onPlaceDiscover;

		// Token: 0x0402932D RID: 168749
		[Token(Token = "0x402932D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402932E RID: 168750
		[Token(Token = "0x402932E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetMapLock;

		// Token: 0x0402932F RID: 168751
		[Token(Token = "0x402932F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsMapLock;

		// Token: 0x04029330 RID: 168752
		[Token(Token = "0x4029330")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetHintVisible;

		// Token: 0x04029331 RID: 168753
		[Token(Token = "0x4029331")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetupZoneMapIfNeeded;

		// Token: 0x04029332 RID: 168754
		[Token(Token = "0x4029332")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetZoneMapAssetPath;

		// Token: 0x04029333 RID: 168755
		[Token(Token = "0x4029333")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FocusOnPlace;

		// Token: 0x04029334 RID: 168756
		[Token(Token = "0x4029334")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
