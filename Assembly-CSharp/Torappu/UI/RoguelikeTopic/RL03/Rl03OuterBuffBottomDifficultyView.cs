using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C3 RID: 17859
	[Token(Token = "0x20045C3")]
	public class Rl03OuterBuffBottomDifficultyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B2C8 RID: 111304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C8")]
		[Address(RVA = "0x14546F0", Offset = "0x14532F0", VA = "0x1814546F0")]
		public void Render(Rl03OuterBuffDifficultyNodeViewModel viewModel)
		{
		}

		// Token: 0x0601B2C9 RID: 111305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C9")]
		[Address(RVA = "0x1454B80", Offset = "0x1453780", VA = "0x181454B80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B2CA RID: 111306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2CA")]
		[Address(RVA = "0x1454CD0", Offset = "0x14538D0", VA = "0x181454CD0")]
		public Rl03OuterBuffBottomDifficultyView()
		{
		}

		// Token: 0x04022FFF RID: 143359
		[Token(Token = "0x4022FFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _difficultDeco;

		// Token: 0x04023000 RID: 143360
		[Token(Token = "0x4023000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _difficultName;

		// Token: 0x04023001 RID: 143361
		[Token(Token = "0x4023001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x04023002 RID: 143362
		[Token(Token = "0x4023002")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNoEffect;

		// Token: 0x04023003 RID: 143363
		[Token(Token = "0x4023003")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x04023004 RID: 143364
		[Token(Token = "0x4023004")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x04023005 RID: 143365
		[Token(Token = "0x4023005")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _effectTip;

		// Token: 0x04023006 RID: 143366
		[Token(Token = "0x4023006")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _difficultContent;

		// Token: 0x04023007 RID: 143367
		[Token(Token = "0x4023007")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04023008 RID: 143368
		[Token(Token = "0x4023008")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023009 RID: 143369
		[Token(Token = "0x4023009")]
		[FieldOffset(Offset = "0x70")]
		private Rl03OuterBuffBottomDifficultyView.ContentAdapter m_adapter;

		// Token: 0x0402300A RID: 143370
		[Token(Token = "0x402300A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402300B RID: 143371
		[Token(Token = "0x402300B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402300C RID: 143372
		[Token(Token = "0x402300C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045C4 RID: 17860
		[Token(Token = "0x20045C4")]
		private class ContentAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040BE RID: 16574
			// (get) Token: 0x0601B2CB RID: 111307 RVA: 0x000A48E0 File Offset: 0x000A2AE0
			[Token(Token = "0x170040BE")]
			public override int count
			{
				[Token(Token = "0x601B2CB")]
				[Address(RVA = "0x14446A0", Offset = "0x14432A0", VA = "0x1814446A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B2CC RID: 111308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B2CC")]
			[Address(RVA = "0x1444400", Offset = "0x1443000", VA = "0x181444400", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B2CD RID: 111309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B2CD")]
			[Address(RVA = "0x1444640", Offset = "0x1443240", VA = "0x181444640")]
			public ContentAdapter()
			{
			}

			// Token: 0x0402300D RID: 143373
			[Token(Token = "0x402300D")]
			[FieldOffset(Offset = "0x20")]
			public List<string> datas;

			// Token: 0x0402300E RID: 143374
			[Token(Token = "0x402300E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402300F RID: 143375
			[Token(Token = "0x402300F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023010 RID: 143376
			[Token(Token = "0x4023010")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
