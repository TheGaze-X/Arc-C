using System;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using Torappu.UI.Firework;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007438 RID: 29752
	[Token(Token = "0x2007438")]
	public class Act38sideFireworkSquadPluginView : SquadHomePluginView, IHotfixable
	{
		// Token: 0x06029FC6 RID: 171974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC6")]
		[Address(RVA = "0x25A7620", Offset = "0x25A6220", VA = "0x1825A7620", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x06029FC7 RID: 171975 RVA: 0x000D71F0 File Offset: 0x000D53F0
		[Token(Token = "0x6029FC7")]
		[Address(RVA = "0x25A75C0", Offset = "0x25A61C0", VA = "0x1825A75C0", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x06029FC8 RID: 171976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC8")]
		[Address(RVA = "0x25A7410", Offset = "0x25A6010", VA = "0x1825A7410")]
		public void EventOnEditBtnClicked()
		{
		}

		// Token: 0x06029FC9 RID: 171977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC9")]
		[Address(RVA = "0x25A7D60", Offset = "0x25A6960", VA = "0x1825A7D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029FCA RID: 171978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCA")]
		[Address(RVA = "0x25A8480", Offset = "0x25A7080", VA = "0x1825A8480")]
		private void _Render()
		{
		}

		// Token: 0x06029FCB RID: 171979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCB")]
		[Address(RVA = "0x25A79C0", Offset = "0x25A65C0", VA = "0x1825A79C0")]
		private void _EventOnAnimalClicked(string animId)
		{
		}

		// Token: 0x06029FCC RID: 171980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCC")]
		[Address(RVA = "0x25A80C0", Offset = "0x25A6CC0", VA = "0x1825A80C0")]
		private void _OnAnimalChangeProceed(FireworkChangeAnimalResponse response)
		{
		}

		// Token: 0x06029FCD RID: 171981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCD")]
		[Address(RVA = "0x25A8740", Offset = "0x25A7340", VA = "0x1825A8740")]
		private void _TryTriggerTutorialAVG()
		{
		}

		// Token: 0x06029FCE RID: 171982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCE")]
		[Address(RVA = "0x25A8220", Offset = "0x25A6E20", VA = "0x1825A8220")]
		private void _OnTutorialAVGCompleted(string customOperationKey, bool showGuidebookTrigger)
		{
		}

		// Token: 0x06029FCF RID: 171983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FCF")]
		[Address(RVA = "0x25A86B0", Offset = "0x25A72B0", VA = "0x1825A86B0")]
		private void _ShowGuideBookTrigger(Story story)
		{
		}

		// Token: 0x06029FD0 RID: 171984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FD0")]
		[Address(RVA = "0x25A83A0", Offset = "0x25A6FA0", VA = "0x1825A83A0")]
		private void _RegisterTutorialGameObject()
		{
		}

		// Token: 0x06029FD1 RID: 171985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FD1")]
		[Address(RVA = "0x25A8910", Offset = "0x25A7510", VA = "0x1825A8910")]
		public Act38sideFireworkSquadPluginView()
		{
		}

		// Token: 0x06029FD4 RID: 171988 RVA: 0x000D7208 File Offset: 0x000D5408
		[Token(Token = "0x6029FD4")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0403C34C RID: 246604
		[Token(Token = "0x403C34C")]
		private const string GUIDE_SUB_SIGNAL = "craft";

		// Token: 0x0403C34D RID: 246605
		[Token(Token = "0x403C34D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x0403C34E RID: 246606
		[Token(Token = "0x403C34E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgAnimBkg;

		// Token: 0x0403C34F RID: 246607
		[Token(Token = "0x403C34F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403C350 RID: 246608
		[Token(Token = "0x403C350")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _plateContainer;

		// Token: 0x0403C351 RID: 246609
		[Token(Token = "0x403C351")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelEditBtn;

		// Token: 0x0403C352 RID: 246610
		[Token(Token = "0x403C352")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIColorGraphic _buttonTarget;

		// Token: 0x0403C353 RID: 246611
		[Token(Token = "0x403C353")]
		[FieldOffset(Offset = "0x60")]
		private Act38sideFireworkSquadPluginViewModel m_viewModel;

		// Token: 0x0403C354 RID: 246612
		[Token(Token = "0x403C354")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403C355 RID: 246613
		[Token(Token = "0x403C355")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedAnimalId;

		// Token: 0x0403C356 RID: 246614
		[Token(Token = "0x403C356")]
		[FieldOffset(Offset = "0x78")]
		private Act38sideFireworkSquadPluginView.Adapter m_adapter;

		// Token: 0x0403C357 RID: 246615
		[Token(Token = "0x403C357")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C358 RID: 246616
		[Token(Token = "0x403C358")]
		[FieldOffset(Offset = "0x90")]
		private FireworkPlateView m_plateView;

		// Token: 0x0403C359 RID: 246617
		[Token(Token = "0x403C359")]
		[FieldOffset(Offset = "0x98")]
		private FireworkPlateViewStyle m_style;

		// Token: 0x0403C35A RID: 246618
		[Token(Token = "0x403C35A")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403C35B RID: 246619
		[Token(Token = "0x403C35B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403C35C RID: 246620
		[Token(Token = "0x403C35C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403C35D RID: 246621
		[Token(Token = "0x403C35D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnEditBtnClicked;

		// Token: 0x0403C35E RID: 246622
		[Token(Token = "0x403C35E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C35F RID: 246623
		[Token(Token = "0x403C35F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403C360 RID: 246624
		[Token(Token = "0x403C360")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnAnimalClicked;

		// Token: 0x0403C361 RID: 246625
		[Token(Token = "0x403C361")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnAnimalChangeProceed;

		// Token: 0x0403C362 RID: 246626
		[Token(Token = "0x403C362")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialAVG;

		// Token: 0x0403C363 RID: 246627
		[Token(Token = "0x403C363")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnTutorialAVGCompleted;

		// Token: 0x0403C364 RID: 246628
		[Token(Token = "0x403C364")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowGuideBookTrigger;

		// Token: 0x0403C365 RID: 246629
		[Token(Token = "0x403C365")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGameObject;

		// Token: 0x0403C366 RID: 246630
		[Token(Token = "0x403C366")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007439 RID: 29753
		[Token(Token = "0x2007439")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06029FD5 RID: 171989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029FD5")]
			[Address(RVA = "0x25AB350", Offset = "0x25A9F50", VA = "0x1825AB350")]
			public Adapter(Act38sideFireworkSquadPluginView closure)
			{
			}

			// Token: 0x1700631A RID: 25370
			// (get) Token: 0x06029FD6 RID: 171990 RVA: 0x000D7220 File Offset: 0x000D5420
			[Token(Token = "0x1700631A")]
			public override int count
			{
				[Token(Token = "0x6029FD6")]
				[Address(RVA = "0x25AB5F0", Offset = "0x25AA1F0", VA = "0x1825AB5F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029FD7 RID: 171991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029FD7")]
			[Address(RVA = "0x25AB0E0", Offset = "0x25A9CE0", VA = "0x1825AB0E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403C367 RID: 246631
			[Token(Token = "0x403C367")]
			[FieldOffset(Offset = "0x20")]
			private Act38sideFireworkSquadPluginView m_closure;

			// Token: 0x0403C368 RID: 246632
			[Token(Token = "0x403C368")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C369 RID: 246633
			[Token(Token = "0x403C369")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C36A RID: 246634
			[Token(Token = "0x403C36A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
