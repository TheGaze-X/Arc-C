using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200427E RID: 17022
	[Token(Token = "0x200427E")]
	public class SandboxV2DungeonMapView : DataBinder<SandboxV2DungeonProperty>
	{
		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0601A395 RID: 107413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E41")]
		public SandboxV2DungeonLayerContainer layerContainer
		{
			[Token(Token = "0x601A395")]
			[Address(RVA = "0x1319080", Offset = "0x1317C80", VA = "0x181319080")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A396 RID: 107414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A396")]
		[Address(RVA = "0x1318880", Offset = "0x1317480", VA = "0x181318880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A397 RID: 107415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A397")]
		[Address(RVA = "0x13186C0", Offset = "0x13172C0", VA = "0x1813186C0")]
		private void _ConstructDungeonView(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A398 RID: 107416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A398")]
		[Address(RVA = "0x13181C0", Offset = "0x1316DC0", VA = "0x1813181C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonProperty property)
		{
		}

		// Token: 0x0601A399 RID: 107417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A399")]
		[Address(RVA = "0x1318D00", Offset = "0x1317900", VA = "0x181318D00")]
		public SandboxV2DungeonMapView()
		{
		}

		// Token: 0x0402133F RID: 135999
		[Token(Token = "0x402133F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2DungeonLayerContainer _layerContainer;

		// Token: 0x04021340 RID: 136000
		[Token(Token = "0x4021340")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x04021341 RID: 136001
		[Token(Token = "0x4021341")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021342 RID: 136002
		[Token(Token = "0x4021342")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2DungeonViewConfig m_dungeonViewConfig;

		// Token: 0x04021343 RID: 136003
		[Token(Token = "0x4021343")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x04021344 RID: 136004
		[Token(Token = "0x4021344")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2DungeonViewModel m_cachedDungeonViewModel;

		// Token: 0x04021345 RID: 136005
		[Token(Token = "0x4021345")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<string, SandboxV2AbstractBackgroundView> m_cachedDungeonBackgroundConfig;

		// Token: 0x04021346 RID: 136006
		[Token(Token = "0x4021346")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, SandboxV2DungeonNodeViewModel> m_cachedNodeViewModelGroup;

		// Token: 0x04021347 RID: 136007
		[Token(Token = "0x4021347")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, SandboxV2DungeonLineViewModel> m_cachedLineViewModelGroup;

		// Token: 0x04021348 RID: 136008
		[Token(Token = "0x4021348")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, SandboxV2DungeonZoneViewModel> m_cachedZoneViewModelGroup;

		// Token: 0x04021349 RID: 136009
		[Token(Token = "0x4021349")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, SandboxV2DungeonPathLineViewModel> m_cachedEnemyRushLineViewModelGroup;

		// Token: 0x0402134A RID: 136010
		[Token(Token = "0x402134A")]
		[FieldOffset(Offset = "0x88")]
		private List<SandboxV2DungeonNodeViewModel> m_cachedNodeViewModelList;

		// Token: 0x0402134B RID: 136011
		[Token(Token = "0x402134B")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2DungeonMapView.BackgroundViewPool m_backgroundViewPool;

		// Token: 0x0402134C RID: 136012
		[Token(Token = "0x402134C")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_backgroundViewPoolChecker;

		// Token: 0x0402134D RID: 136013
		[Token(Token = "0x402134D")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2DungeonMapView.NodeViewPool m_nodeViewPool;

		// Token: 0x0402134E RID: 136014
		[Token(Token = "0x402134E")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeViewPoolChecker;

		// Token: 0x0402134F RID: 136015
		[Token(Token = "0x402134F")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2DungeonMapView.NodeShadowViewPool m_nodeShadowViewPool;

		// Token: 0x04021350 RID: 136016
		[Token(Token = "0x4021350")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeShadowViewPoolChecker;

		// Token: 0x04021351 RID: 136017
		[Token(Token = "0x4021351")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxV2DungeonMapView.LineViewPool m_lineViewPool;

		// Token: 0x04021352 RID: 136018
		[Token(Token = "0x4021352")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_lineViewPoolChecker;

		// Token: 0x04021353 RID: 136019
		[Token(Token = "0x4021353")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2DungeonMapView.ZoneViewPool m_zoneViewPool;

		// Token: 0x04021354 RID: 136020
		[Token(Token = "0x4021354")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_zoneViewPoolChecker;

		// Token: 0x04021355 RID: 136021
		[Token(Token = "0x4021355")]
		[FieldOffset(Offset = "0x108")]
		private SandboxV2DungeonMapView.EnemyRushLineViewPool m_enemyRushLineViewPool;

		// Token: 0x04021356 RID: 136022
		[Token(Token = "0x4021356")]
		[FieldOffset(Offset = "0x110")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enemyRushLineViewPoolChecker;

		// Token: 0x04021357 RID: 136023
		[Token(Token = "0x4021357")]
		[FieldOffset(Offset = "0x120")]
		private SandboxV2DungeonMapView.NodeFloatViewPool m_nodeFloatViewPool;

		// Token: 0x04021358 RID: 136024
		[Token(Token = "0x4021358")]
		[FieldOffset(Offset = "0x128")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeFloatViewPoolChecker;

		// Token: 0x04021359 RID: 136025
		[Token(Token = "0x4021359")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layerContainer;

		// Token: 0x0402135A RID: 136026
		[Token(Token = "0x402135A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402135B RID: 136027
		[Token(Token = "0x402135B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ConstructDungeonView;

		// Token: 0x0402135C RID: 136028
		[Token(Token = "0x402135C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402135D RID: 136029
		[Token(Token = "0x402135D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200427F RID: 17023
		[Token(Token = "0x200427F")]
		private class BackgroundViewPool : GameObjectDictPool<SandboxV2AbstractBackgroundView>
		{
			// Token: 0x0601A39A RID: 107418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A39A")]
			[Address(RVA = "0x13144A0", Offset = "0x13130A0", VA = "0x1813144A0")]
			public BackgroundViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A39B RID: 107419 RVA: 0x000A07D0 File Offset: 0x0009E9D0
			[Token(Token = "0x601A39B")]
			[Address(RVA = "0x1314010", Offset = "0x1312C10", VA = "0x181314010", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A39C RID: 107420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A39C")]
			[Address(RVA = "0x13142F0", Offset = "0x1312EF0", VA = "0x1813142F0", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A39D RID: 107421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A39D")]
			[Address(RVA = "0x1314130", Offset = "0x1312D30", VA = "0x181314130", Slot = "7")]
			protected override SandboxV2AbstractBackgroundView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A39E RID: 107422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A39E")]
			[Address(RVA = "0x1314220", Offset = "0x1312E20", VA = "0x181314220", Slot = "8")]
			protected override SandboxV2AbstractBackgroundView Instantiate(string key, SandboxV2AbstractBackgroundView prefab)
			{
				return null;
			}

			// Token: 0x0601A39F RID: 107423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A39F")]
			[Address(RVA = "0x13143A0", Offset = "0x1312FA0", VA = "0x1813143A0", Slot = "9")]
			protected override void Render(string key, SandboxV2AbstractBackgroundView obj)
			{
			}

			// Token: 0x0402135E RID: 136030
			[Token(Token = "0x402135E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x0402135F RID: 136031
			[Token(Token = "0x402135F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021360 RID: 136032
			[Token(Token = "0x4021360")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04021361 RID: 136033
			[Token(Token = "0x4021361")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04021362 RID: 136034
			[Token(Token = "0x4021362")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04021363 RID: 136035
			[Token(Token = "0x4021363")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04021364 RID: 136036
			[Token(Token = "0x4021364")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004281 RID: 17025
		[Token(Token = "0x2004281")]
		private class NodeViewPool : AsyncGameObjectDictPool<SandboxV2AbstractNodeView, SandboxV2AbstractNodeView.RenderParam>
		{
			// Token: 0x0601A3A9 RID: 107433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3A9")]
			[Address(RVA = "0x13164C0", Offset = "0x13150C0", VA = "0x1813164C0")]
			public NodeViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3AA RID: 107434 RVA: 0x000A0800 File Offset: 0x0009EA00
			[Token(Token = "0x601A3AA")]
			[Address(RVA = "0x1315FA0", Offset = "0x1314BA0", VA = "0x181315FA0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A3AB RID: 107435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3AB")]
			[Address(RVA = "0x1316320", Offset = "0x1314F20", VA = "0x181316320", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A3AC RID: 107436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3AC")]
			[Address(RVA = "0x13160C0", Offset = "0x1314CC0", VA = "0x1813160C0", Slot = "7")]
			protected override SandboxV2AbstractNodeView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A3AD RID: 107437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3AD")]
			[Address(RVA = "0x1316210", Offset = "0x1314E10", VA = "0x181316210", Slot = "8")]
			protected override AsyncDataViewHandler<SandboxV2AbstractNodeView, SandboxV2AbstractNodeView.RenderParam> Instantiate(string key, SandboxV2AbstractNodeView prefab)
			{
				return null;
			}

			// Token: 0x0601A3AE RID: 107438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3AE")]
			[Address(RVA = "0x13163D0", Offset = "0x1314FD0", VA = "0x1813163D0", Slot = "9")]
			protected override void Render(string key, AsyncDataViewHandler<SandboxV2AbstractNodeView, SandboxV2AbstractNodeView.RenderParam> obj)
			{
			}

			// Token: 0x0402136A RID: 136042
			[Token(Token = "0x402136A")]
			private const uint PER_OBJ_COST = 20U;

			// Token: 0x0402136B RID: 136043
			[Token(Token = "0x402136B")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x0402136C RID: 136044
			[Token(Token = "0x402136C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402136D RID: 136045
			[Token(Token = "0x402136D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402136E RID: 136046
			[Token(Token = "0x402136E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402136F RID: 136047
			[Token(Token = "0x402136F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04021370 RID: 136048
			[Token(Token = "0x4021370")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04021371 RID: 136049
			[Token(Token = "0x4021371")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004283 RID: 17027
		[Token(Token = "0x2004283")]
		private class NodeShadowViewPool : AsyncGameObjectDictPool<SandboxV2NodeShadowView, SandboxV2NodeShadowView.RenderParam>
		{
			// Token: 0x0601A3B8 RID: 107448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3B8")]
			[Address(RVA = "0x1315F10", Offset = "0x1314B10", VA = "0x181315F10")]
			public NodeShadowViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3B9 RID: 107449 RVA: 0x000A0830 File Offset: 0x0009EA30
			[Token(Token = "0x601A3B9")]
			[Address(RVA = "0x13159F0", Offset = "0x13145F0", VA = "0x1813159F0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A3BA RID: 107450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3BA")]
			[Address(RVA = "0x1315D70", Offset = "0x1314970", VA = "0x181315D70", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A3BB RID: 107451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3BB")]
			[Address(RVA = "0x1315B10", Offset = "0x1314710", VA = "0x181315B10", Slot = "7")]
			protected override SandboxV2NodeShadowView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A3BC RID: 107452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3BC")]
			[Address(RVA = "0x1315C60", Offset = "0x1314860", VA = "0x181315C60", Slot = "8")]
			protected override AsyncDataViewHandler<SandboxV2NodeShadowView, SandboxV2NodeShadowView.RenderParam> Instantiate(string key, SandboxV2NodeShadowView prefab)
			{
				return null;
			}

			// Token: 0x0601A3BD RID: 107453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3BD")]
			[Address(RVA = "0x1315E20", Offset = "0x1314A20", VA = "0x181315E20", Slot = "9")]
			protected override void Render(string key, AsyncDataViewHandler<SandboxV2NodeShadowView, SandboxV2NodeShadowView.RenderParam> obj)
			{
			}

			// Token: 0x04021377 RID: 136055
			[Token(Token = "0x4021377")]
			private const uint PER_OBJ_COST = 5U;

			// Token: 0x04021378 RID: 136056
			[Token(Token = "0x4021378")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x04021379 RID: 136057
			[Token(Token = "0x4021379")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402137A RID: 136058
			[Token(Token = "0x402137A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402137B RID: 136059
			[Token(Token = "0x402137B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402137C RID: 136060
			[Token(Token = "0x402137C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402137D RID: 136061
			[Token(Token = "0x402137D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402137E RID: 136062
			[Token(Token = "0x402137E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004285 RID: 17029
		[Token(Token = "0x2004285")]
		private class LineViewPool : AsyncGameObjectDictPool<SandboxV2LineView, SandboxV2LineView.RenderParam>
		{
			// Token: 0x0601A3C7 RID: 107463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3C7")]
			[Address(RVA = "0x1315960", Offset = "0x1314560", VA = "0x181315960")]
			public LineViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3C8 RID: 107464 RVA: 0x000A0860 File Offset: 0x0009EA60
			[Token(Token = "0x601A3C8")]
			[Address(RVA = "0x1315470", Offset = "0x1314070", VA = "0x181315470", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A3C9 RID: 107465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3C9")]
			[Address(RVA = "0x13157C0", Offset = "0x13143C0", VA = "0x1813157C0", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A3CA RID: 107466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3CA")]
			[Address(RVA = "0x1315590", Offset = "0x1314190", VA = "0x181315590", Slot = "7")]
			protected override SandboxV2LineView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A3CB RID: 107467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3CB")]
			[Address(RVA = "0x1315690", Offset = "0x1314290", VA = "0x181315690", Slot = "8")]
			protected override AsyncDataViewHandler<SandboxV2LineView, SandboxV2LineView.RenderParam> Instantiate(string key, SandboxV2LineView prefab)
			{
				return null;
			}

			// Token: 0x0601A3CC RID: 107468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3CC")]
			[Address(RVA = "0x1315870", Offset = "0x1314470", VA = "0x181315870", Slot = "9")]
			protected override void Render(string key, AsyncDataViewHandler<SandboxV2LineView, SandboxV2LineView.RenderParam> obj)
			{
			}

			// Token: 0x04021384 RID: 136068
			[Token(Token = "0x4021384")]
			private const uint PER_OBJ_COST = 1U;

			// Token: 0x04021385 RID: 136069
			[Token(Token = "0x4021385")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x04021386 RID: 136070
			[Token(Token = "0x4021386")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021387 RID: 136071
			[Token(Token = "0x4021387")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04021388 RID: 136072
			[Token(Token = "0x4021388")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04021389 RID: 136073
			[Token(Token = "0x4021389")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402138A RID: 136074
			[Token(Token = "0x402138A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402138B RID: 136075
			[Token(Token = "0x402138B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004287 RID: 17031
		[Token(Token = "0x2004287")]
		private class ZoneViewPool : GameObjectDictPool<SandboxV2ZoneView>
		{
			// Token: 0x0601A3D6 RID: 107478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3D6")]
			[Address(RVA = "0x1328A40", Offset = "0x1327640", VA = "0x181328A40")]
			public ZoneViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3D7 RID: 107479 RVA: 0x000A0890 File Offset: 0x0009EA90
			[Token(Token = "0x601A3D7")]
			[Address(RVA = "0x13285A0", Offset = "0x13271A0", VA = "0x1813285A0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A3D8 RID: 107480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3D8")]
			[Address(RVA = "0x1328880", Offset = "0x1327480", VA = "0x181328880", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A3D9 RID: 107481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3D9")]
			[Address(RVA = "0x13286C0", Offset = "0x13272C0", VA = "0x1813286C0", Slot = "7")]
			protected override SandboxV2ZoneView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A3DA RID: 107482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3DA")]
			[Address(RVA = "0x13287C0", Offset = "0x13273C0", VA = "0x1813287C0", Slot = "8")]
			protected override SandboxV2ZoneView Instantiate(string key, SandboxV2ZoneView prefab)
			{
				return null;
			}

			// Token: 0x0601A3DB RID: 107483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3DB")]
			[Address(RVA = "0x1328930", Offset = "0x1327530", VA = "0x181328930", Slot = "9")]
			protected override void Render(string key, SandboxV2ZoneView obj)
			{
			}

			// Token: 0x04021391 RID: 136081
			[Token(Token = "0x4021391")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x04021392 RID: 136082
			[Token(Token = "0x4021392")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021393 RID: 136083
			[Token(Token = "0x4021393")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04021394 RID: 136084
			[Token(Token = "0x4021394")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04021395 RID: 136085
			[Token(Token = "0x4021395")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04021396 RID: 136086
			[Token(Token = "0x4021396")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04021397 RID: 136087
			[Token(Token = "0x4021397")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004289 RID: 17033
		[Token(Token = "0x2004289")]
		private class EnemyRushLineViewPool : AsyncGameObjectDictPool<SandboxV2EnemyRushLineView, SandboxV2EnemyRushLineView.RenderParam>
		{
			// Token: 0x0601A3E5 RID: 107493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3E5")]
			[Address(RVA = "0x13153E0", Offset = "0x1313FE0", VA = "0x1813153E0")]
			public EnemyRushLineViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3E6 RID: 107494 RVA: 0x000A08C0 File Offset: 0x0009EAC0
			[Token(Token = "0x601A3E6")]
			[Address(RVA = "0x1314EF0", Offset = "0x1313AF0", VA = "0x181314EF0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A3E7 RID: 107495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3E7")]
			[Address(RVA = "0x1315240", Offset = "0x1313E40", VA = "0x181315240", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A3E8 RID: 107496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3E8")]
			[Address(RVA = "0x1315010", Offset = "0x1313C10", VA = "0x181315010", Slot = "7")]
			protected override SandboxV2EnemyRushLineView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A3E9 RID: 107497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3E9")]
			[Address(RVA = "0x1315110", Offset = "0x1313D10", VA = "0x181315110", Slot = "8")]
			protected override AsyncDataViewHandler<SandboxV2EnemyRushLineView, SandboxV2EnemyRushLineView.RenderParam> Instantiate(string key, SandboxV2EnemyRushLineView prefab)
			{
				return null;
			}

			// Token: 0x0601A3EA RID: 107498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3EA")]
			[Address(RVA = "0x13152F0", Offset = "0x1313EF0", VA = "0x1813152F0", Slot = "9")]
			protected override void Render(string key, AsyncDataViewHandler<SandboxV2EnemyRushLineView, SandboxV2EnemyRushLineView.RenderParam> obj)
			{
			}

			// Token: 0x0402139D RID: 136093
			[Token(Token = "0x402139D")]
			private const uint PER_OBJ_COST = 1U;

			// Token: 0x0402139E RID: 136094
			[Token(Token = "0x402139E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x0402139F RID: 136095
			[Token(Token = "0x402139F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040213A0 RID: 136096
			[Token(Token = "0x40213A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x040213A1 RID: 136097
			[Token(Token = "0x40213A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x040213A2 RID: 136098
			[Token(Token = "0x40213A2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040213A3 RID: 136099
			[Token(Token = "0x40213A3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x040213A4 RID: 136100
			[Token(Token = "0x40213A4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x0200428B RID: 17035
		[Token(Token = "0x200428B")]
		private class NodeFloatViewPool : SandboxV2OrderedViewGroupAdapter<SandboxV2NodeFloatViewHolder>
		{
			// Token: 0x0601A3F4 RID: 107508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3F4")]
			[Address(RVA = "0x1328E80", Offset = "0x1327A80", VA = "0x181328E80")]
			public NodeFloatViewPool(SandboxV2DungeonMapView closure)
			{
			}

			// Token: 0x0601A3F5 RID: 107509 RVA: 0x000A08F0 File Offset: 0x0009EAF0
			[Token(Token = "0x601A3F5")]
			[Address(RVA = "0x1328BA0", Offset = "0x13277A0", VA = "0x181328BA0", Slot = "4")]
			protected override int GetCount()
			{
				return 0;
			}

			// Token: 0x0601A3F6 RID: 107510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A3F6")]
			[Address(RVA = "0x1328C70", Offset = "0x1327870", VA = "0x181328C70", Slot = "5")]
			protected override SandboxV2NodeFloatViewHolder Instantiate(int index)
			{
				return null;
			}

			// Token: 0x0601A3F7 RID: 107511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3F7")]
			[Address(RVA = "0x1328D70", Offset = "0x1327970", VA = "0x181328D70", Slot = "6")]
			protected override void Render(SandboxV2NodeFloatViewHolder view, int index)
			{
			}

			// Token: 0x040213AA RID: 136106
			[Token(Token = "0x40213AA")]
			[FieldOffset(Offset = "0x18")]
			private SandboxV2DungeonMapView m_closure;

			// Token: 0x040213AB RID: 136107
			[Token(Token = "0x40213AB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040213AC RID: 136108
			[Token(Token = "0x40213AC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCount;

			// Token: 0x040213AD RID: 136109
			[Token(Token = "0x40213AD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x040213AE RID: 136110
			[Token(Token = "0x40213AE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
