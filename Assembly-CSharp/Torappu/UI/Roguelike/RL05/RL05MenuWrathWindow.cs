using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055EF RID: 21999
	[Token(Token = "0x20055EF")]
	public class RL05MenuWrathWindow : RoguelikeMenuWindow<RL05MenuWrathViewModel>
	{
		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x060204B0 RID: 132272 RVA: 0x000B53B0 File Offset: 0x000B35B0
		[Token(Token = "0x17004BA6")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x60204B0")]
			[Address(RVA = "0x1A6BF30", Offset = "0x1A6AB30", VA = "0x181A6BF30", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x060204B1 RID: 132273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B1")]
		[Address(RVA = "0x1A6BA60", Offset = "0x1A6A660", VA = "0x181A6BA60", Slot = "10")]
		public override void Render(RL05MenuWrathViewModel viewModel)
		{
		}

		// Token: 0x060204B2 RID: 132274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B2")]
		[Address(RVA = "0x1A6BB10", Offset = "0x1A6A710", VA = "0x181A6BB10")]
		private void _UpdateWrathEntries(RL05MenuWrathViewModel viewModel, ILoadAsset loader)
		{
		}

		// Token: 0x060204B3 RID: 132275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B3")]
		[Address(RVA = "0x1A6BE60", Offset = "0x1A6AA60", VA = "0x181A6BE60")]
		public RL05MenuWrathWindow()
		{
		}

		// Token: 0x0402BB3B RID: 179003
		[Token(Token = "0x402BB3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _wrathInfoContainer;

		// Token: 0x0402BB3C RID: 179004
		[Token(Token = "0x402BB3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _wrathInfoPrefab;

		// Token: 0x0402BB3D RID: 179005
		[Token(Token = "0x402BB3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _wrathAtlas;

		// Token: 0x0402BB3E RID: 179006
		[Token(Token = "0x402BB3E")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BB3F RID: 179007
		[Token(Token = "0x402BB3F")]
		[FieldOffset(Offset = "0x50")]
		private List<RL05MenuWrathWindowInfoObject> m_wrathInfoObjs;

		// Token: 0x0402BB40 RID: 179008
		[Token(Token = "0x402BB40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402BB41 RID: 179009
		[Token(Token = "0x402BB41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BB42 RID: 179010
		[Token(Token = "0x402BB42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateWrathEntries;

		// Token: 0x0402BB43 RID: 179011
		[Token(Token = "0x402BB43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
