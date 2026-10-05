using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040CB RID: 16587
	[Token(Token = "0x20040CB")]
	public class SandboxV2AdminMainScienceNodeGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x06019A79 RID: 105081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019A7A RID: 105082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D34")]
		public Action<string> eventOnNodeClick
		{
			[Token(Token = "0x6019A79")]
			[Address(RVA = "0x1279D70", Offset = "0x1278970", VA = "0x181279D70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019A7A")]
			[Address(RVA = "0x1279DD0", Offset = "0x12789D0", VA = "0x181279DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019A7B RID: 105083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A7B")]
		[Address(RVA = "0x1279BB0", Offset = "0x12787B0", VA = "0x181279BB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A7C RID: 105084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A7C")]
		[Address(RVA = "0x1279990", Offset = "0x1278590", VA = "0x181279990")]
		public void Render(ListDict<string, SandboxV2AdminMainScienceItemViewModel> viewModelList, SandboxV2AdminMainScienceType scienceType, string selectingNodeId, string topicId)
		{
		}

		// Token: 0x06019A7D RID: 105085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A7D")]
		[Address(RVA = "0x1279D10", Offset = "0x1278910", VA = "0x181279D10")]
		public SandboxV2AdminMainScienceNodeGroupView()
		{
		}

		// Token: 0x04020104 RID: 131332
		[Token(Token = "0x4020104")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04020105 RID: 131333
		[Token(Token = "0x4020105")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2AdminMainScienceNodeItem _nodePrefab;

		// Token: 0x04020106 RID: 131334
		[Token(Token = "0x4020106")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2AdminMainScienceNodeGroupView.NodeGroupAdapter m_adapter;

		// Token: 0x04020108 RID: 131336
		[Token(Token = "0x4020108")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnNodeClick;

		// Token: 0x04020109 RID: 131337
		[Token(Token = "0x4020109")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnNodeClick;

		// Token: 0x0402010A RID: 131338
		[Token(Token = "0x402010A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402010B RID: 131339
		[Token(Token = "0x402010B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402010C RID: 131340
		[Token(Token = "0x402010C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040CC RID: 16588
		[Token(Token = "0x20040CC")]
		private class NodeGroupAdapter : IHotfixable
		{
			// Token: 0x06019A7E RID: 105086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A7E")]
			[Address(RVA = "0x12730D0", Offset = "0x1271CD0", VA = "0x1812730D0")]
			public NodeGroupAdapter(SandboxV2AdminMainScienceNodeGroupView closure)
			{
			}

			// Token: 0x06019A7F RID: 105087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A7F")]
			[Address(RVA = "0x1272AB0", Offset = "0x12716B0", VA = "0x181272AB0")]
			public void RefreshView(ListDict<string, SandboxV2AdminMainScienceItemViewModel> viewModelList, SandboxV2AdminMainScienceType curType, string selectingNodeId, string topicId)
			{
			}

			// Token: 0x06019A80 RID: 105088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019A80")]
			[Address(RVA = "0x1272E20", Offset = "0x1271A20", VA = "0x181272E20")]
			private SandboxV2AdminMainScienceNodeItem _GetView(int position)
			{
				return null;
			}

			// Token: 0x06019A81 RID: 105089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A81")]
			[Address(RVA = "0x1272ED0", Offset = "0x1271AD0", VA = "0x181272ED0")]
			private void _UpdateViewInstance(int position, SandboxV2AdminMainScienceNodeItem view)
			{
			}

			// Token: 0x0402010D RID: 131341
			[Token(Token = "0x402010D")]
			[FieldOffset(Offset = "0x10")]
			private SandboxV2AdminMainScienceNodeGroupView m_closure;

			// Token: 0x0402010E RID: 131342
			[Token(Token = "0x402010E")]
			[FieldOffset(Offset = "0x18")]
			private List<SandboxV2AdminMainScienceNodeItem> m_nodeViews;

			// Token: 0x0402010F RID: 131343
			[Token(Token = "0x402010F")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2AdminMainScienceType m_cachedType;

			// Token: 0x04020110 RID: 131344
			[Token(Token = "0x4020110")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020111 RID: 131345
			[Token(Token = "0x4020111")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x04020112 RID: 131346
			[Token(Token = "0x4020112")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GetView;

			// Token: 0x04020113 RID: 131347
			[Token(Token = "0x4020113")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__UpdateViewInstance;
		}
	}
}
