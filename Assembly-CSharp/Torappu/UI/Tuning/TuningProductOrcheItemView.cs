using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD9 RID: 15577
	[Token(Token = "0x2003CD9")]
	public class TuningProductOrcheItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x06018496 RID: 99478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039EE")]
		public string orcheItemId
		{
			[Token(Token = "0x6018496")]
			[Address(RVA = "0x10CB5B0", Offset = "0x10CA1B0", VA = "0x1810CB5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039EF RID: 14831
		// (set) Token: 0x06018497 RID: 99479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170039EF")]
		public float layoutSpacingHeight
		{
			[Token(Token = "0x6018497")]
			[Address(RVA = "0x10CB610", Offset = "0x10CA210", VA = "0x1810CB610")]
			set
			{
			}
		}

		// Token: 0x06018498 RID: 99480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018498")]
		[Address(RVA = "0x10CB380", Offset = "0x10C9F80", VA = "0x1810CB380")]
		public void Render(TuningOrcheModel model)
		{
		}

		// Token: 0x06018499 RID: 99481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018499")]
		[Address(RVA = "0x10CB4B0", Offset = "0x10CA0B0", VA = "0x1810CB4B0")]
		public void SampleMovingAnim(float percent)
		{
		}

		// Token: 0x0601849A RID: 99482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849A")]
		[Address(RVA = "0x10CB550", Offset = "0x10CA150", VA = "0x1810CB550")]
		public TuningProductOrcheItemView()
		{
		}

		// Token: 0x0401DA73 RID: 121459
		[Token(Token = "0x401DA73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0401DA74 RID: 121460
		[Token(Token = "0x401DA74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _orcheItemName;

		// Token: 0x0401DA75 RID: 121461
		[Token(Token = "0x401DA75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _orcheDesc;

		// Token: 0x0401DA76 RID: 121462
		[Token(Token = "0x401DA76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401DA77 RID: 121463
		[Token(Token = "0x401DA77")]
		[FieldOffset(Offset = "0x40")]
		private string m_orcheItemId;

		// Token: 0x0401DA78 RID: 121464
		[Token(Token = "0x401DA78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_orcheItemId;

		// Token: 0x0401DA79 RID: 121465
		[Token(Token = "0x401DA79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_layoutSpacingHeight;

		// Token: 0x0401DA7A RID: 121466
		[Token(Token = "0x401DA7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA7B RID: 121467
		[Token(Token = "0x401DA7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SampleMovingAnim;

		// Token: 0x0401DA7C RID: 121468
		[Token(Token = "0x401DA7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
