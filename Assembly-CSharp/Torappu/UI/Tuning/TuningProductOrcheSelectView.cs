using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CDA RID: 15578
	[Token(Token = "0x2003CDA")]
	public class TuningProductOrcheSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601849B RID: 99483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849B")]
		[Address(RVA = "0x10CB6B0", Offset = "0x10CA2B0", VA = "0x1810CB6B0")]
		public void Render(TuningProductViewModel model)
		{
		}

		// Token: 0x0601849C RID: 99484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849C")]
		[Address(RVA = "0x10CB8A0", Offset = "0x10CA4A0", VA = "0x1810CB8A0")]
		public void SetFormEffectHide()
		{
		}

		// Token: 0x0601849D RID: 99485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849D")]
		[Address(RVA = "0x10CB980", Offset = "0x10CA580", VA = "0x1810CB980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601849E RID: 99486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849E")]
		[Address(RVA = "0x10CBA00", Offset = "0x10CA600", VA = "0x1810CBA00")]
		public TuningProductOrcheSelectView()
		{
		}

		// Token: 0x0401DA7D RID: 121469
		[Token(Token = "0x401DA7D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TuningProductPagerView _pagerView;

		// Token: 0x0401DA7E RID: 121470
		[Token(Token = "0x401DA7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TuningProductOrcheSelectView.OrcheTypeToFormEffectView> _orcheTypeToFormEffectViewList;

		// Token: 0x0401DA7F RID: 121471
		[Token(Token = "0x401DA7F")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> onSelectOrche;

		// Token: 0x0401DA80 RID: 121472
		[Token(Token = "0x401DA80")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x0401DA81 RID: 121473
		[Token(Token = "0x401DA81")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x0401DA82 RID: 121474
		[Token(Token = "0x401DA82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA83 RID: 121475
		[Token(Token = "0x401DA83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetFormEffectHide;

		// Token: 0x0401DA84 RID: 121476
		[Token(Token = "0x401DA84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DA85 RID: 121477
		[Token(Token = "0x401DA85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CDB RID: 15579
		[Token(Token = "0x2003CDB")]
		[Serializable]
		public struct OrcheTypeToFormEffectView : IHotfixable
		{
			// Token: 0x0401DA86 RID: 121478
			[Token(Token = "0x401DA86")]
			[FieldOffset(Offset = "0x0")]
			public Act29SideData.Act29SideOrcheType orcheType;

			// Token: 0x0401DA87 RID: 121479
			[Token(Token = "0x401DA87")]
			[FieldOffset(Offset = "0x8")]
			public TuningProductSlotFormEffectView formEffectView;
		}
	}
}
