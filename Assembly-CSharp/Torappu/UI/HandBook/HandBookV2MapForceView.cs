using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FE RID: 26366
	[Token(Token = "0x20066FE")]
	public class HandBookV2MapForceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x06025D74 RID: 154996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025D75 RID: 154997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700599C")]
		public UIStringEvent onBgClick
		{
			[Token(Token = "0x6025D74")]
			[Address(RVA = "0x20C6BD0", Offset = "0x20C57D0", VA = "0x1820C6BD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025D75")]
			[Address(RVA = "0x20C6C30", Offset = "0x20C5830", VA = "0x1820C6C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025D76 RID: 154998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D76")]
		[Address(RVA = "0x20C6770", Offset = "0x20C5370", VA = "0x1820C6770")]
		private void _RenderDot(HandBookV2PointData pointData, bool isForceUnlock)
		{
		}

		// Token: 0x06025D77 RID: 154999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D77")]
		[Address(RVA = "0x20C6660", Offset = "0x20C5260", VA = "0x1820C6660")]
		private void _OnDotClick()
		{
		}

		// Token: 0x06025D78 RID: 155000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D78")]
		[Address(RVA = "0x20C6550", Offset = "0x20C5150", VA = "0x1820C6550")]
		public void Render(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025D79 RID: 155001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D79")]
		[Address(RVA = "0x20C6B20", Offset = "0x20C5720", VA = "0x1820C6B20")]
		public HandBookV2MapForceView()
		{
		}

		// Token: 0x04035332 RID: 217906
		[Token(Token = "0x4035332")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapDotView _dotView;

		// Token: 0x04035333 RID: 217907
		[Token(Token = "0x4035333")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04035335 RID: 217909
		[Token(Token = "0x4035335")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, HandBookV2MapDotView> m_mapDotView;

		// Token: 0x04035336 RID: 217910
		[Token(Token = "0x4035336")]
		[FieldOffset(Offset = "0x38")]
		private HandBookV2ForceViewModel m_viewModel;

		// Token: 0x04035337 RID: 217911
		[Token(Token = "0x4035337")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBgClick;

		// Token: 0x04035338 RID: 217912
		[Token(Token = "0x4035338")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBgClick;

		// Token: 0x04035339 RID: 217913
		[Token(Token = "0x4035339")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDot;

		// Token: 0x0403533A RID: 217914
		[Token(Token = "0x403533A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDotClick;

		// Token: 0x0403533B RID: 217915
		[Token(Token = "0x403533B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403533C RID: 217916
		[Token(Token = "0x403533C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
