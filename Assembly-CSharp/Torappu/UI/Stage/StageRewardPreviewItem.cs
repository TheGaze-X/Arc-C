using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200697E RID: 27006
	[Token(Token = "0x200697E")]
	public class StageRewardPreviewItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026A4F RID: 158287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A4F")]
		[Address(RVA = "0x21BBB60", Offset = "0x21BA760", VA = "0x1821BBB60", Slot = "4")]
		protected virtual void _InitIfNeeded()
		{
		}

		// Token: 0x06026A50 RID: 158288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A50")]
		[Address(RVA = "0x21BB8D0", Offset = "0x21BA4D0", VA = "0x1821BB8D0")]
		public void Render(StageRewardViewModel viewModel)
		{
		}

		// Token: 0x06026A51 RID: 158289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A51")]
		[Address(RVA = "0x21BBD10", Offset = "0x21BA910", VA = "0x1821BBD10")]
		private void _RenderOverrideDropTag(StageRewardViewModel viewModel)
		{
		}

		// Token: 0x06026A52 RID: 158290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A52")]
		[Address(RVA = "0x21BBEC0", Offset = "0x21BAAC0", VA = "0x1821BBEC0")]
		private void _RenderTimelyDrop(StageRewardViewModel viewModel)
		{
		}

		// Token: 0x06026A53 RID: 158291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A53")]
		[Address(RVA = "0x21BC110", Offset = "0x21BAD10", VA = "0x1821BC110")]
		public StageRewardPreviewItem()
		{
		}

		// Token: 0x040368DF RID: 223455
		[Token(Token = "0x40368DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _itemCardContainer;

		// Token: 0x040368E0 RID: 223456
		[Token(Token = "0x40368E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _cardScaleFactor;

		// Token: 0x040368E1 RID: 223457
		[Token(Token = "0x40368E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _onceTag;

		// Token: 0x040368E2 RID: 223458
		[Token(Token = "0x40368E2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected GameObject _completeTag;

		// Token: 0x040368E3 RID: 223459
		[Token(Token = "0x40368E3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _overrideDropTag;

		// Token: 0x040368E4 RID: 223460
		[Token(Token = "0x40368E4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _overrideDropText;

		// Token: 0x040368E5 RID: 223461
		[Token(Token = "0x40368E5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected bool _showItemNum;

		// Token: 0x040368E6 RID: 223462
		[Token(Token = "0x40368E6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform _timelyDropContainer;

		// Token: 0x040368E7 RID: 223463
		[Token(Token = "0x40368E7")]
		[FieldOffset(Offset = "0x58")]
		protected GameObject m_timelyDropItem;

		// Token: 0x040368E8 RID: 223464
		[Token(Token = "0x40368E8")]
		[FieldOffset(Offset = "0x60")]
		private string m_cacheDropId;

		// Token: 0x040368E9 RID: 223465
		[Token(Token = "0x40368E9")]
		[FieldOffset(Offset = "0x68")]
		protected UIItemCard m_itemCard;

		// Token: 0x040368EA RID: 223466
		[Token(Token = "0x40368EA")]
		[FieldOffset(Offset = "0x70")]
		protected UIItemViewModel m_viewModel;

		// Token: 0x040368EB RID: 223467
		[Token(Token = "0x40368EB")]
		[FieldOffset(Offset = "0x78")]
		protected bool m_isInited;

		// Token: 0x040368EC RID: 223468
		[Token(Token = "0x40368EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNeeded;

		// Token: 0x040368ED RID: 223469
		[Token(Token = "0x40368ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040368EE RID: 223470
		[Token(Token = "0x40368EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderOverrideDropTag;

		// Token: 0x040368EF RID: 223471
		[Token(Token = "0x40368EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTimelyDrop;

		// Token: 0x040368F0 RID: 223472
		[Token(Token = "0x40368F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
