using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005862 RID: 22626
	[Token(Token = "0x2005862")]
	public class RL03TotemBuffMapView : DataBinder<RL03TotemMapViewProperty>
	{
		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x060210C5 RID: 135365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060210C6 RID: 135366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D88")]
		public Action<int, int> OnNodeClick
		{
			[Token(Token = "0x60210C5")]
			[Address(RVA = "0x1B66440", Offset = "0x1B65040", VA = "0x181B66440")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60210C6")]
			[Address(RVA = "0x1B664A0", Offset = "0x1B650A0", VA = "0x181B664A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060210C7 RID: 135367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C7")]
		[Address(RVA = "0x1B658C0", Offset = "0x1B644C0", VA = "0x181B658C0", Slot = "7")]
		public override void OnValueChanged(RL03TotemMapViewProperty property)
		{
		}

		// Token: 0x060210C8 RID: 135368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C8")]
		[Address(RVA = "0x1B65990", Offset = "0x1B64590", VA = "0x181B65990")]
		private void _CreateZone(RL03TotemBuffMapViewModel viewModel)
		{
		}

		// Token: 0x060210C9 RID: 135369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C9")]
		[Address(RVA = "0x1B65E00", Offset = "0x1B64A00", VA = "0x181B65E00")]
		private void _RenderZone(RL03TotemBuffMapViewModel viewModel)
		{
		}

		// Token: 0x060210CA RID: 135370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210CA")]
		[Address(RVA = "0x1B65CD0", Offset = "0x1B648D0", VA = "0x181B65CD0")]
		private void _OnMapNodeClick(int depth, int index)
		{
		}

		// Token: 0x060210CB RID: 135371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210CB")]
		[Address(RVA = "0x1B66370", Offset = "0x1B64F70", VA = "0x181B66370")]
		public RL03TotemBuffMapView()
		{
		}

		// Token: 0x0402CF7E RID: 184190
		[Token(Token = "0x402CF7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _layerPrefab;

		// Token: 0x0402CF7F RID: 184191
		[Token(Token = "0x402CF7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _layerContainer;

		// Token: 0x0402CF80 RID: 184192
		[Token(Token = "0x402CF80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL03TotemBuffMapNodeView _nodeViewPrefab;

		// Token: 0x0402CF82 RID: 184194
		[Token(Token = "0x402CF82")]
		[FieldOffset(Offset = "0x40")]
		private int m_curZoneIndex;

		// Token: 0x0402CF83 RID: 184195
		[Token(Token = "0x402CF83")]
		[FieldOffset(Offset = "0x48")]
		private RL03TotemBuffMapViewModel m_cachedViewModel;

		// Token: 0x0402CF84 RID: 184196
		[Token(Token = "0x402CF84")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, RL03TotemBuffMapNodeView> m_nodeViews;

		// Token: 0x0402CF85 RID: 184197
		[Token(Token = "0x402CF85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_OnNodeClick;

		// Token: 0x0402CF86 RID: 184198
		[Token(Token = "0x402CF86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_OnNodeClick;

		// Token: 0x0402CF87 RID: 184199
		[Token(Token = "0x402CF87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402CF88 RID: 184200
		[Token(Token = "0x402CF88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateZone;

		// Token: 0x0402CF89 RID: 184201
		[Token(Token = "0x402CF89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderZone;

		// Token: 0x0402CF8A RID: 184202
		[Token(Token = "0x402CF8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMapNodeClick;

		// Token: 0x0402CF8B RID: 184203
		[Token(Token = "0x402CF8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
