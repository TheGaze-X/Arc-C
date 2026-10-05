using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004617 RID: 17943
	[Token(Token = "0x2004617")]
	public class RL02OuterBuffNodeGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0601B45C RID: 111708 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B45D RID: 111709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040FF")]
		public Action<string> onNodeClicked
		{
			[Token(Token = "0x601B45C")]
			[Address(RVA = "0x149F960", Offset = "0x149E560", VA = "0x18149F960")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B45D")]
			[Address(RVA = "0x149F9C0", Offset = "0x149E5C0", VA = "0x18149F9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B45E RID: 111710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B45E")]
		[Address(RVA = "0x149F770", Offset = "0x149E370", VA = "0x18149F770")]
		public void OnInit(UIPage page)
		{
		}

		// Token: 0x0601B45F RID: 111711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B45F")]
		[Address(RVA = "0x149F850", Offset = "0x149E450", VA = "0x18149F850")]
		public void Render(ListDict<string, RL02OuterBuffItemModel> viewModelList, RL02OuterBuffNodeGroupView.RenderConfig config)
		{
		}

		// Token: 0x0601B460 RID: 111712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B460")]
		[Address(RVA = "0x149F900", Offset = "0x149E500", VA = "0x18149F900")]
		public RL02OuterBuffNodeGroupView()
		{
		}

		// Token: 0x04023316 RID: 144150
		[Token(Token = "0x4023316")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL02OuterBuffNodeItemView[] _nodePrefab;

		// Token: 0x04023317 RID: 144151
		[Token(Token = "0x4023317")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04023318 RID: 144152
		[Token(Token = "0x4023318")]
		[FieldOffset(Offset = "0x28")]
		private RL02OuterBuffNodeGroupView.Adapter m_adapter;

		// Token: 0x04023319 RID: 144153
		[Token(Token = "0x4023319")]
		[FieldOffset(Offset = "0x30")]
		private UIPage m_page;

		// Token: 0x0402331B RID: 144155
		[Token(Token = "0x402331B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x0402331C RID: 144156
		[Token(Token = "0x402331C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x0402331D RID: 144157
		[Token(Token = "0x402331D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402331E RID: 144158
		[Token(Token = "0x402331E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402331F RID: 144159
		[Token(Token = "0x402331F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004618 RID: 17944
		[Token(Token = "0x2004618")]
		public struct RenderConfig
		{
			// Token: 0x04023320 RID: 144160
			[Token(Token = "0x4023320")]
			[FieldOffset(Offset = "0x0")]
			public string selectNodeId;

			// Token: 0x04023321 RID: 144161
			[Token(Token = "0x4023321")]
			[FieldOffset(Offset = "0x8")]
			public int token;

			// Token: 0x04023322 RID: 144162
			[Token(Token = "0x4023322")]
			[FieldOffset(Offset = "0xC")]
			public bool showNodeName;
		}

		// Token: 0x02004619 RID: 17945
		[Token(Token = "0x2004619")]
		private class Adapter : IHotfixable
		{
			// Token: 0x0601B461 RID: 111713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B461")]
			[Address(RVA = "0x1495A60", Offset = "0x1494660", VA = "0x181495A60")]
			public Adapter(RL02OuterBuffNodeGroupView closure)
			{
			}

			// Token: 0x0601B462 RID: 111714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B462")]
			[Address(RVA = "0x1494B60", Offset = "0x1493760", VA = "0x181494B60")]
			public void RefreshView(ListDict<string, RL02OuterBuffItemModel> viewModelList, RL02OuterBuffNodeGroupView.RenderConfig config)
			{
			}

			// Token: 0x0601B463 RID: 111715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B463")]
			[Address(RVA = "0x1494AB0", Offset = "0x14936B0", VA = "0x181494AB0")]
			private RL02OuterBuffNodeItemView GetView(int position)
			{
				return null;
			}

			// Token: 0x0601B464 RID: 111716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B464")]
			[Address(RVA = "0x14956E0", Offset = "0x14942E0", VA = "0x1814956E0")]
			private void _UpdateViewInstance(int position, RL02OuterBuffNodeItemView view)
			{
			}

			// Token: 0x04023323 RID: 144163
			[Token(Token = "0x4023323")]
			[FieldOffset(Offset = "0x10")]
			private RL02OuterBuffNodeGroupView m_closure;

			// Token: 0x04023324 RID: 144164
			[Token(Token = "0x4023324")]
			[FieldOffset(Offset = "0x18")]
			private List<RL02OuterBuffNodeItemView> m_views;

			// Token: 0x04023325 RID: 144165
			[Token(Token = "0x4023325")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<RL02DevelopmentNodeType, RL02OuterBuffNodeItemView> m_cacheNodePrefabMap;

			// Token: 0x04023326 RID: 144166
			[Token(Token = "0x4023326")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023327 RID: 144167
			[Token(Token = "0x4023327")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x04023328 RID: 144168
			[Token(Token = "0x4023328")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetView;

			// Token: 0x04023329 RID: 144169
			[Token(Token = "0x4023329")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__UpdateViewInstance;
		}
	}
}
