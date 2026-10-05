using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B4 RID: 18356
	[Token(Token = "0x20047B4")]
	public abstract class RecalRuneStageRunePackItemBase : MonoBehaviour, IHotfixable, ILayoutElement
	{
		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x0601BCA9 RID: 113833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004216")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601BCA9")]
			[Address(RVA = "0x15313B0", Offset = "0x152FFB0", VA = "0x1815313B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x0601BCAA RID: 113834 RVA: 0x000A6428 File Offset: 0x000A4628
		[Token(Token = "0x17004217")]
		public float minWidth
		{
			[Token(Token = "0x601BCAA")]
			[Address(RVA = "0x15315F0", Offset = "0x15301F0", VA = "0x1815315F0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x0601BCAB RID: 113835 RVA: 0x000A6440 File Offset: 0x000A4640
		[Token(Token = "0x17004218")]
		public float flexibleWidth
		{
			[Token(Token = "0x601BCAB")]
			[Address(RVA = "0x1531490", Offset = "0x1530090", VA = "0x181531490", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x0601BCAC RID: 113836 RVA: 0x000A6458 File Offset: 0x000A4658
		[Token(Token = "0x17004219")]
		public float minHeight
		{
			[Token(Token = "0x601BCAC")]
			[Address(RVA = "0x1531570", Offset = "0x1530170", VA = "0x181531570", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0601BCAD RID: 113837 RVA: 0x000A6470 File Offset: 0x000A4670
		[Token(Token = "0x1700421A")]
		public float flexibleHeight
		{
			[Token(Token = "0x601BCAD")]
			[Address(RVA = "0x1531410", Offset = "0x1530010", VA = "0x181531410", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0601BCAE RID: 113838 RVA: 0x000A6488 File Offset: 0x000A4688
		[Token(Token = "0x1700421B")]
		public int layoutPriority
		{
			[Token(Token = "0x601BCAE")]
			[Address(RVA = "0x1531510", Offset = "0x1530110", VA = "0x181531510", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0601BCAF RID: 113839
		[Token(Token = "0x1700421C")]
		public abstract float preferredWidth { [Token(Token = "0x601BCAF")] get; }

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x0601BCB0 RID: 113840
		[Token(Token = "0x1700421D")]
		public abstract float preferredHeight { [Token(Token = "0x601BCB0")] get; }

		// Token: 0x0601BCB1 RID: 113841
		[Token(Token = "0x601BCB1")]
		public abstract void Render(IRecalRunePack pack);

		// Token: 0x0601BCB2 RID: 113842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB2")]
		[Address(RVA = "0x15312F0", Offset = "0x152FEF0", VA = "0x1815312F0", Slot = "16")]
		public virtual void SetFocus(bool isFocused)
		{
		}

		// Token: 0x0601BCB3 RID: 113843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB3")]
		[Address(RVA = "0x1531230", Offset = "0x152FE30", VA = "0x181531230", Slot = "4")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0601BCB4 RID: 113844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB4")]
		[Address(RVA = "0x1531290", Offset = "0x152FE90", VA = "0x181531290", Slot = "5")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x0601BCB5 RID: 113845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB5")]
		[Address(RVA = "0x1531350", Offset = "0x152FF50", VA = "0x181531350")]
		protected RecalRuneStageRunePackItemBase()
		{
		}

		// Token: 0x0402425A RID: 148058
		[Token(Token = "0x402425A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0402425B RID: 148059
		[Token(Token = "0x402425B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402425C RID: 148060
		[Token(Token = "0x402425C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0402425D RID: 148061
		[Token(Token = "0x402425D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0402425E RID: 148062
		[Token(Token = "0x402425E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0402425F RID: 148063
		[Token(Token = "0x402425F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x04024260 RID: 148064
		[Token(Token = "0x4024260")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x04024261 RID: 148065
		[Token(Token = "0x4024261")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x04024262 RID: 148066
		[Token(Token = "0x4024262")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x04024263 RID: 148067
		[Token(Token = "0x4024263")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x04024264 RID: 148068
		[Token(Token = "0x4024264")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
