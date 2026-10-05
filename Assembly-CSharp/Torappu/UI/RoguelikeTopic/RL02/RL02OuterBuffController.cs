using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004607 RID: 17927
	[Token(Token = "0x2004607")]
	public class RL02OuterBuffController : RoguelikeTopicOuterBuffController, IHotfixable
	{
		// Token: 0x0601B400 RID: 111616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B400")]
		[Address(RVA = "0x1462510", Offset = "0x1461110", VA = "0x181462510", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0601B401 RID: 111617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B401")]
		[Address(RVA = "0x1462D10", Offset = "0x1461910", VA = "0x181462D10", Slot = "5")]
		public override void OnEnter(string topicId)
		{
		}

		// Token: 0x0601B402 RID: 111618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B402")]
		[Address(RVA = "0x1462F00", Offset = "0x1461B00", VA = "0x181462F00", Slot = "6")]
		public override void OnResume(bool isResumeFromStack)
		{
		}

		// Token: 0x0601B403 RID: 111619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B403")]
		[Address(RVA = "0x1462C50", Offset = "0x1461850", VA = "0x181462C50", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601B404 RID: 111620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B404")]
		[Address(RVA = "0x1463580", Offset = "0x1462180", VA = "0x181463580")]
		private void _OnNodeClicked(string nodeId)
		{
		}

		// Token: 0x0601B405 RID: 111621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B405")]
		[Address(RVA = "0x14633F0", Offset = "0x1461FF0", VA = "0x1814633F0")]
		private void _OnClearSelectNode()
		{
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B406")]
		[Address(RVA = "0x1463670", Offset = "0x1462270", VA = "0x181463670")]
		private void _OnSummaryClicked()
		{
		}

		// Token: 0x0601B407 RID: 111623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B407")]
		[Address(RVA = "0x14636E0", Offset = "0x14622E0", VA = "0x1814636E0")]
		private void _OnSummaryClose()
		{
		}

		// Token: 0x0601B408 RID: 111624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B408")]
		[Address(RVA = "0x1463020", Offset = "0x1461C20", VA = "0x181463020")]
		private void _OnActivateNodeClicked()
		{
		}

		// Token: 0x0601B409 RID: 111625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B409")]
		[Address(RVA = "0x1462490", Offset = "0x1461090", VA = "0x181462490")]
		public void EventOnScaleChanged(float scale)
		{
		}

		// Token: 0x0601B40A RID: 111626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40A")]
		[Address(RVA = "0x14634C0", Offset = "0x14620C0", VA = "0x1814634C0")]
		private void _OnFloatPanelShowChanged(bool hasPanelShown)
		{
		}

		// Token: 0x0601B40B RID: 111627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40B")]
		[Address(RVA = "0x1463750", Offset = "0x1462350", VA = "0x181463750")]
		public RL02OuterBuffController()
		{
		}

		// Token: 0x0601B40C RID: 111628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40C")]
		[Address(RVA = "0x1456430", Offset = "0x1455030", VA = "0x181456430")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x0601B40D RID: 111629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40D")]
		[Address(RVA = "0x1456440", Offset = "0x1455040", VA = "0x181456440")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0601B40E RID: 111630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40E")]
		[Address(RVA = "0x1456450", Offset = "0x1455050", VA = "0x181456450")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x0601B40F RID: 111631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B40F")]
		[Address(RVA = "0x1463010", Offset = "0x1461C10", VA = "0x181463010")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402327B RID: 143995
		[Token(Token = "0x402327B")]
		public const float ANGLE_PER_SEGMENT = 7.5f;

		// Token: 0x0402327C RID: 143996
		[Token(Token = "0x402327C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02OuterBuffDetailView _detailView;

		// Token: 0x0402327D RID: 143997
		[Token(Token = "0x402327D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL02OuterBuffMapView _mapView;

		// Token: 0x0402327E RID: 143998
		[Token(Token = "0x402327E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402327F RID: 143999
		[Token(Token = "0x402327F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL02OuterBuffSummaryView _summaryView;

		// Token: 0x04023280 RID: 144000
		[Token(Token = "0x4023280")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _scaleShowDetail;

		// Token: 0x04023281 RID: 144001
		[Token(Token = "0x4023281")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Floats")]
		private UIFadeFloatPanel _panelSummary;

		// Token: 0x04023282 RID: 144002
		[Token(Token = "0x4023282")]
		[FieldOffset(Offset = "0x58")]
		private RL02OuterBuffProperty m_property;

		// Token: 0x04023283 RID: 144003
		[Token(Token = "0x4023283")]
		[FieldOffset(Offset = "0x60")]
		private RL02OuterBuffListProperty m_listProperty;

		// Token: 0x04023284 RID: 144004
		[Token(Token = "0x4023284")]
		[FieldOffset(Offset = "0x68")]
		private RL02OuterBuffController.LODController m_lodController;

		// Token: 0x04023285 RID: 144005
		[Token(Token = "0x4023285")]
		[FieldOffset(Offset = "0x70")]
		private RL02OuterBuffController.MapScaleController m_mapScaleController;

		// Token: 0x04023286 RID: 144006
		[Token(Token = "0x4023286")]
		[FieldOffset(Offset = "0x78")]
		private RL02OuterBuffController.FloatController m_floatController;

		// Token: 0x04023287 RID: 144007
		[Token(Token = "0x4023287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023288 RID: 144008
		[Token(Token = "0x4023288")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023289 RID: 144009
		[Token(Token = "0x4023289")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402328A RID: 144010
		[Token(Token = "0x402328A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402328B RID: 144011
		[Token(Token = "0x402328B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnNodeClicked;

		// Token: 0x0402328C RID: 144012
		[Token(Token = "0x402328C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClearSelectNode;

		// Token: 0x0402328D RID: 144013
		[Token(Token = "0x402328D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSummaryClicked;

		// Token: 0x0402328E RID: 144014
		[Token(Token = "0x402328E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSummaryClose;

		// Token: 0x0402328F RID: 144015
		[Token(Token = "0x402328F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnActivateNodeClicked;

		// Token: 0x04023290 RID: 144016
		[Token(Token = "0x4023290")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnScaleChanged;

		// Token: 0x04023291 RID: 144017
		[Token(Token = "0x4023291")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnFloatPanelShowChanged;

		// Token: 0x04023292 RID: 144018
		[Token(Token = "0x4023292")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004608 RID: 17928
		[Token(Token = "0x2004608")]
		private class LODController : IHotfixable
		{
			// Token: 0x0601B410 RID: 111632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B410")]
			[Address(RVA = "0x145B4A0", Offset = "0x145A0A0", VA = "0x18145B4A0")]
			public LODController(RL02OuterBuffController closure)
			{
			}

			// Token: 0x0601B411 RID: 111633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B411")]
			[Address(RVA = "0x145B370", Offset = "0x1459F70", VA = "0x18145B370")]
			public void EventOnScaleChanged(float scale)
			{
			}

			// Token: 0x04023293 RID: 144019
			[Token(Token = "0x4023293")]
			[FieldOffset(Offset = "0x10")]
			private RL02OuterBuffController m_closure;

			// Token: 0x04023294 RID: 144020
			[Token(Token = "0x4023294")]
			[FieldOffset(Offset = "0x18")]
			private RL02OuterBuffController.LODController.LOD m_lod;

			// Token: 0x04023295 RID: 144021
			[Token(Token = "0x4023295")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023296 RID: 144022
			[Token(Token = "0x4023296")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EventOnScaleChanged;

			// Token: 0x02004609 RID: 17929
			[Token(Token = "0x2004609")]
			public enum LOD
			{
				// Token: 0x04023298 RID: 144024
				[Token(Token = "0x4023298")]
				BEFORE_INIT,
				// Token: 0x04023299 RID: 144025
				[Token(Token = "0x4023299")]
				SHOW_NODE_NAME,
				// Token: 0x0402329A RID: 144026
				[Token(Token = "0x402329A")]
				HIDE_NODE_NAME
			}
		}

		// Token: 0x0200460A RID: 17930
		[Token(Token = "0x200460A")]
		private class MapScaleController : RL02OuterBuffMapView.IBindings, IHotfixable, IDisposable
		{
			// Token: 0x0601B412 RID: 111634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B412")]
			[Address(RVA = "0x145C900", Offset = "0x145B500", VA = "0x18145C900")]
			public MapScaleController(RL02OuterBuffController closure)
			{
			}

			// Token: 0x0601B413 RID: 111635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B413")]
			[Address(RVA = "0x145C5C0", Offset = "0x145B1C0", VA = "0x18145C5C0")]
			public void StartInitLayoutTween()
			{
			}

			// Token: 0x0601B414 RID: 111636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B414")]
			[Address(RVA = "0x145C280", Offset = "0x145AE80", VA = "0x18145C280", Slot = "9")]
			public void Dispose()
			{
			}

			// Token: 0x0601B415 RID: 111637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B415")]
			[Address(RVA = "0x145C2E0", Offset = "0x145AEE0", VA = "0x18145C2E0")]
			public void EnableTouchZoom(bool enabled)
			{
			}

			// Token: 0x0601B416 RID: 111638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B416")]
			[Address(RVA = "0x145C650", Offset = "0x145B250", VA = "0x18145C650")]
			private void _DisposeInitTween()
			{
			}

			// Token: 0x0601B417 RID: 111639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B417")]
			[Address(RVA = "0x145C6F0", Offset = "0x145B2F0", VA = "0x18145C6F0")]
			private void _TryStartInitLayoutTween()
			{
			}

			// Token: 0x0601B418 RID: 111640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B418")]
			[Address(RVA = "0x145C1C0", Offset = "0x145ADC0", VA = "0x18145C1C0", Slot = "8")]
			public void BindTouchZoom(Action<float> scaleMethod, Action<float, float> scaleRangeMethod, Action<bool> enableTouchMethod)
			{
			}

			// Token: 0x0601B419 RID: 111641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B419")]
			[Address(RVA = "0x145C140", Offset = "0x145AD40", VA = "0x18145C140", Slot = "7")]
			public void BindScroll(Action<Vector2> normalizedPosMethod)
			{
			}

			// Token: 0x0601B41A RID: 111642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B41A")]
			[Address(RVA = "0x145C360", Offset = "0x145AF60", VA = "0x18145C360", Slot = "5")]
			public void OnMapLayoutChanged(Vector2 viewportSize, Vector2 contentSize)
			{
			}

			// Token: 0x0601B41B RID: 111643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B41B")]
			[Address(RVA = "0x145C4B0", Offset = "0x145B0B0", VA = "0x18145C4B0", Slot = "4")]
			public void OnMapScaleChanged(float scale)
			{
			}

			// Token: 0x0601B41C RID: 111644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B41C")]
			[Address(RVA = "0x145C540", Offset = "0x145B140", VA = "0x18145C540", Slot = "6")]
			public void OnMapTouchZoomStateChanged(bool isZooming)
			{
			}

			// Token: 0x0402329B RID: 144027
			[Token(Token = "0x402329B")]
			public const float MAX_SCALE = 1f;

			// Token: 0x0402329C RID: 144028
			[Token(Token = "0x402329C")]
			private const float INIT_SCALE_BIAS = 0.1f;

			// Token: 0x0402329D RID: 144029
			[Token(Token = "0x402329D")]
			private const float INIT_SCALE_DUR = 1.8f;

			// Token: 0x0402329E RID: 144030
			[Token(Token = "0x402329E")]
			[FieldOffset(Offset = "0x10")]
			private Action<float> m_scaleMethod;

			// Token: 0x0402329F RID: 144031
			[Token(Token = "0x402329F")]
			[FieldOffset(Offset = "0x18")]
			private Action<float, float> m_scaleRangeMethod;

			// Token: 0x040232A0 RID: 144032
			[Token(Token = "0x40232A0")]
			[FieldOffset(Offset = "0x20")]
			private Action<bool> m_enableTouchMethod;

			// Token: 0x040232A1 RID: 144033
			[Token(Token = "0x40232A1")]
			[FieldOffset(Offset = "0x28")]
			private Action<Vector2> m_normalizedPosMethod;

			// Token: 0x040232A2 RID: 144034
			[Token(Token = "0x40232A2")]
			[FieldOffset(Offset = "0x30")]
			private RL02OuterBuffController m_closure;

			// Token: 0x040232A3 RID: 144035
			[Token(Token = "0x40232A3")]
			[FieldOffset(Offset = "0x38")]
			private Tween m_initTween;

			// Token: 0x040232A4 RID: 144036
			[Token(Token = "0x40232A4")]
			[FieldOffset(Offset = "0x40")]
			private float m_lastMinScale;

			// Token: 0x040232A5 RID: 144037
			[Token(Token = "0x40232A5")]
			[FieldOffset(Offset = "0x44")]
			private bool m_hasPendingInitTween;

			// Token: 0x040232A6 RID: 144038
			[Token(Token = "0x40232A6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040232A7 RID: 144039
			[Token(Token = "0x40232A7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_StartInitLayoutTween;

			// Token: 0x040232A8 RID: 144040
			[Token(Token = "0x40232A8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x040232A9 RID: 144041
			[Token(Token = "0x40232A9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_EnableTouchZoom;

			// Token: 0x040232AA RID: 144042
			[Token(Token = "0x40232AA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__DisposeInitTween;

			// Token: 0x040232AB RID: 144043
			[Token(Token = "0x40232AB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TryStartInitLayoutTween;

			// Token: 0x040232AC RID: 144044
			[Token(Token = "0x40232AC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BindTouchZoom;

			// Token: 0x040232AD RID: 144045
			[Token(Token = "0x40232AD")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_BindScroll;

			// Token: 0x040232AE RID: 144046
			[Token(Token = "0x40232AE")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnMapLayoutChanged;

			// Token: 0x040232AF RID: 144047
			[Token(Token = "0x40232AF")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnMapScaleChanged;

			// Token: 0x040232B0 RID: 144048
			[Token(Token = "0x40232B0")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnMapTouchZoomStateChanged;
		}

		// Token: 0x0200460C RID: 17932
		[Token(Token = "0x200460C")]
		private class FloatController : IHotfixable
		{
			// Token: 0x0601B420 RID: 111648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B420")]
			[Address(RVA = "0x145B260", Offset = "0x1459E60", VA = "0x18145B260")]
			public FloatController(RL02OuterBuffController closure)
			{
			}

			// Token: 0x0601B421 RID: 111649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B421")]
			[Address(RVA = "0x145AE30", Offset = "0x1459A30", VA = "0x18145AE30")]
			public void SetShowSummary(bool isShow)
			{
			}

			// Token: 0x0601B422 RID: 111650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B422")]
			[Address(RVA = "0x145AEB0", Offset = "0x1459AB0", VA = "0x18145AEB0")]
			private void _SetShowPanel(RL02OuterBuffController.FloatController.FloatType type, bool isShow)
			{
			}

			// Token: 0x040232B3 RID: 144051
			[Token(Token = "0x40232B3")]
			[FieldOffset(Offset = "0x10")]
			private RL02OuterBuffController m_closure;

			// Token: 0x040232B4 RID: 144052
			[Token(Token = "0x40232B4")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<RL02OuterBuffController.FloatController.FloatType, UIReentrantFloatPanel> m_floats;

			// Token: 0x040232B5 RID: 144053
			[Token(Token = "0x40232B5")]
			[FieldOffset(Offset = "0x20")]
			private bool? m_hasPanelShown;

			// Token: 0x040232B6 RID: 144054
			[Token(Token = "0x40232B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040232B7 RID: 144055
			[Token(Token = "0x40232B7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetShowSummary;

			// Token: 0x040232B8 RID: 144056
			[Token(Token = "0x40232B8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__SetShowPanel;

			// Token: 0x0200460D RID: 17933
			[Token(Token = "0x200460D")]
			private enum FloatType
			{
				// Token: 0x040232BA RID: 144058
				[Token(Token = "0x40232BA")]
				NONE,
				// Token: 0x040232BB RID: 144059
				[Token(Token = "0x40232BB")]
				SUMMARY
			}
		}
	}
}
