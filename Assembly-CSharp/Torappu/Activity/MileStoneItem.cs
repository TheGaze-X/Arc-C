using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D87 RID: 28039
	[Token(Token = "0x2006D87")]
	public class MileStoneItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x06027F11 RID: 163601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E6C")]
		protected UIItemCard itemCard
		{
			[Token(Token = "0x6027F11")]
			[Address(RVA = "0x23426A0", Offset = "0x23412A0", VA = "0x1823426A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027F12 RID: 163602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F12")]
		[Address(RVA = "0x23424C0", Offset = "0x23410C0", VA = "0x1823424C0")]
		private void _Inited()
		{
		}

		// Token: 0x06027F13 RID: 163603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F13")]
		[Address(RVA = "0x23422D0", Offset = "0x2340ED0", VA = "0x1823422D0")]
		public void OnClick()
		{
		}

		// Token: 0x06027F14 RID: 163604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F14")]
		[Address(RVA = "0x2342070", Offset = "0x2340C70", VA = "0x182342070", Slot = "4")]
		public virtual void InitData(MileStoneViewModel viewModel)
		{
		}

		// Token: 0x06027F15 RID: 163605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F15")]
		[Address(RVA = "0x2342350", Offset = "0x2340F50", VA = "0x182342350", Slot = "5")]
		protected virtual void OnRenderDataPart(MileStoneViewModel viewModel)
		{
		}

		// Token: 0x06027F16 RID: 163606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F16")]
		[Address(RVA = "0x2342440", Offset = "0x2341040", VA = "0x182342440", Slot = "6")]
		protected virtual void OnRenderItemStyle(MileStoneViewModel.PartType part, MileStoneViewModel.State state)
		{
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F17")]
		[Address(RVA = "0x2342640", Offset = "0x2341240", VA = "0x182342640")]
		public MileStoneItem()
		{
		}

		// Token: 0x040389C1 RID: 231873
		[Token(Token = "0x40389C1")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x040389C2 RID: 231874
		[Token(Token = "0x40389C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x040389C3 RID: 231875
		[Token(Token = "0x40389C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x040389C4 RID: 231876
		[Token(Token = "0x40389C4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x040389C5 RID: 231877
		[Token(Token = "0x40389C5")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x040389C6 RID: 231878
		[Token(Token = "0x40389C6")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheId;

		// Token: 0x040389C7 RID: 231879
		[Token(Token = "0x40389C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemCard;

		// Token: 0x040389C8 RID: 231880
		[Token(Token = "0x40389C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Inited;

		// Token: 0x040389C9 RID: 231881
		[Token(Token = "0x40389C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040389CA RID: 231882
		[Token(Token = "0x40389CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040389CB RID: 231883
		[Token(Token = "0x40389CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRenderDataPart;

		// Token: 0x040389CC RID: 231884
		[Token(Token = "0x40389CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRenderItemStyle;

		// Token: 0x040389CD RID: 231885
		[Token(Token = "0x40389CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
