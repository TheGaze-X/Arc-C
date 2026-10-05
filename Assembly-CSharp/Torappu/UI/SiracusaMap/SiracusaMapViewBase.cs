using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F92 RID: 16274
	[Token(Token = "0x2003F92")]
	public abstract class SiracusaMapViewBase<T> : DataBinder<T> where T : IBindProperty
	{
		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x060193EA RID: 103402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060193EB RID: 103403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C45")]
		public AutoPackSpriteHub areaIconSpriteHub
		{
			[Token(Token = "0x60193EA")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60193EB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x060193EC RID: 103404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C46")]
		public List<SiracusaMapNodeViewHolder> nodeHolders
		{
			[Token(Token = "0x60193EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060193ED RID: 103405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193ED")]
		protected SiracusaMapViewBase()
		{
		}

		// Token: 0x0401F540 RID: 128320
		[Token(Token = "0x401F540")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<SiracusaMapNodeViewHolder> _nodeHolders;

		// Token: 0x0401F541 RID: 128321
		[Token(Token = "0x401F541")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Group("Editor Only")]
		private List<SiracusaMapPointView> _pointViews;

		// Token: 0x0401F542 RID: 128322
		[Token(Token = "0x401F542")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Group("Editor Only")]
		protected RectTransform _normalNodesContainer;

		// Token: 0x0401F543 RID: 128323
		[Token(Token = "0x401F543")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Group("Editor Only")]
		protected RectTransform _taskNodesContainer;

		// Token: 0x0401F544 RID: 128324
		[Token(Token = "0x401F544")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Group("Editor Only")]
		protected RectTransform _selectedNodesContainer;

		// Token: 0x0401F545 RID: 128325
		[Token(Token = "0x401F545")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Group("Editor Only")]
		private RectTransform _pointContainer;

		// Token: 0x0401F546 RID: 128326
		[Token(Token = "0x401F546")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _normalNodePrefab;

		// Token: 0x0401F547 RID: 128327
		[Token(Token = "0x401F547")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _taskNodePrefab;

		// Token: 0x0401F548 RID: 128328
		[Token(Token = "0x401F548")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _selectedNodePrefab;

		// Token: 0x0401F549 RID: 128329
		[Token(Token = "0x401F549")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<SiracusaMapAreaFogViewBase> _fogViews;

		// Token: 0x0401F54A RID: 128330
		[Token(Token = "0x401F54A")]
		[FieldOffset(Offset = "0x0")]
		protected ListDict<string, Vector2> m_pointPosMap;

		// Token: 0x0401F54B RID: 128331
		[Token(Token = "0x401F54B")]
		[FieldOffset(Offset = "0x0")]
		protected ListDict<string, SiracusaMapNodeViewHolder> m_pointNodeMap;

		// Token: 0x0401F54D RID: 128333
		[Token(Token = "0x401F54D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_areaIconSpriteHub;

		// Token: 0x0401F54E RID: 128334
		[Token(Token = "0x401F54E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_areaIconSpriteHub;

		// Token: 0x0401F54F RID: 128335
		[Token(Token = "0x401F54F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeHolders;

		// Token: 0x0401F550 RID: 128336
		[Token(Token = "0x401F550")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
