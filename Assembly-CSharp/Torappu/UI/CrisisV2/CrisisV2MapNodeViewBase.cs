using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059B5 RID: 22965
	[Token(Token = "0x20059B5")]
	public abstract class CrisisV2MapNodeViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x0602178E RID: 137102 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602178F RID: 137103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EB2")]
		public Action<string> onNodeClick
		{
			[Token(Token = "0x602178E")]
			[Address(RVA = "0x1BD3600", Offset = "0x1BD2200", VA = "0x181BD3600")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602178F")]
			[Address(RVA = "0x1BD3660", Offset = "0x1BD2260", VA = "0x181BD3660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021790 RID: 137104
		[Token(Token = "0x6021790")]
		public abstract CrisisV2NodeSlotType GetSlotType();

		// Token: 0x06021791 RID: 137105
		[Token(Token = "0x6021791")]
		protected abstract void Render();

		// Token: 0x06021792 RID: 137106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021792")]
		[Address(RVA = "0x1BD3130", Offset = "0x1BD1D30", VA = "0x181BD3130", Slot = "6")]
		protected virtual void PlayHighlightAnimIfNeed(bool isNodeHighlight)
		{
		}

		// Token: 0x06021793 RID: 137107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021793")]
		[Address(RVA = "0x1BD3190", Offset = "0x1BD1D90", VA = "0x181BD3190")]
		public void RenderView(CrisisV2MapNodeModel nodeModel, CrisisV2MapNodeStatus nodeStatus, bool isExclusion, bool isNodeHighlight, string tutorialKey)
		{
		}

		// Token: 0x06021794 RID: 137108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021794")]
		[Address(RVA = "0x1BD33F0", Offset = "0x1BD1FF0", VA = "0x181BD33F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021795 RID: 137109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021795")]
		[Address(RVA = "0x1BD3460", Offset = "0x1BD2060", VA = "0x181BD3460")]
		private void _RegisterTutorialGoIfNeed(string key)
		{
		}

		// Token: 0x06021796 RID: 137110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021796")]
		[Address(RVA = "0x1BD3010", Offset = "0x1BD1C10", VA = "0x181BD3010")]
		public void EventOnNodeClick()
		{
		}

		// Token: 0x06021797 RID: 137111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021797")]
		[Address(RVA = "0x1BD35A0", Offset = "0x1BD21A0", VA = "0x181BD35A0")]
		protected CrisisV2MapNodeViewBase()
		{
		}

		// Token: 0x0402DB77 RID: 187255
		[Token(Token = "0x402DB77")]
		[FieldOffset(Offset = "0x18")]
		private bool m_hasInited;

		// Token: 0x0402DB78 RID: 187256
		[Token(Token = "0x402DB78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected GameObject _panelFocus;

		// Token: 0x0402DB79 RID: 187257
		[Token(Token = "0x402DB79")]
		[FieldOffset(Offset = "0x28")]
		protected UIStateFinder m_stateFinder;

		// Token: 0x0402DB7A RID: 187258
		[Token(Token = "0x402DB7A")]
		[FieldOffset(Offset = "0x38")]
		protected CrisisV2MapNodeModel m_nodeModel;

		// Token: 0x0402DB7B RID: 187259
		[Token(Token = "0x402DB7B")]
		[FieldOffset(Offset = "0x40")]
		protected CrisisV2MapNodeStatus m_nodeStatus;

		// Token: 0x0402DB7C RID: 187260
		[Token(Token = "0x402DB7C")]
		[FieldOffset(Offset = "0x44")]
		protected bool m_isExclusion;

		// Token: 0x0402DB7E RID: 187262
		[Token(Token = "0x402DB7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0402DB7F RID: 187263
		[Token(Token = "0x402DB7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0402DB80 RID: 187264
		[Token(Token = "0x402DB80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayHighlightAnimIfNeed;

		// Token: 0x0402DB81 RID: 187265
		[Token(Token = "0x402DB81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402DB82 RID: 187266
		[Token(Token = "0x402DB82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DB83 RID: 187267
		[Token(Token = "0x402DB83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGoIfNeed;

		// Token: 0x0402DB84 RID: 187268
		[Token(Token = "0x402DB84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnNodeClick;

		// Token: 0x0402DB85 RID: 187269
		[Token(Token = "0x402DB85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
