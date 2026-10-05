using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200373A RID: 14138
	[Token(Token = "0x200373A")]
	public class UIItemDescFloatVoucherRelation : MonoBehaviour, IHotfixable
	{
		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x06016759 RID: 91993 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601675A RID: 91994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035D9")]
		public Action<ItemUtil.ConsumableInfo, ItemType, UIItemDescFloatVoucherRelation.VoucherRouteFocus> onVoucherClicked
		{
			[Token(Token = "0x6016759")]
			[Address(RVA = "0xEE7C40", Offset = "0xEE6840", VA = "0x180EE7C40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601675A")]
			[Address(RVA = "0xEE7CA0", Offset = "0xEE68A0", VA = "0x180EE7CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601675B RID: 91995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601675B")]
		[Address(RVA = "0xEE7AE0", Offset = "0xEE66E0", VA = "0x180EE7AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601675C RID: 91996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601675C")]
		[Address(RVA = "0xEE7830", Offset = "0xEE6430", VA = "0x180EE7830")]
		public void Render(ItemUtil.ConsumableInfo consumableInfo, ItemType voucherItemType, UIItemDescFloatVoucherRelation.VoucherRouteFocus focus)
		{
		}

		// Token: 0x0601675D RID: 91997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601675D")]
		[Address(RVA = "0xEE7750", Offset = "0xEE6350", VA = "0x180EE7750")]
		public void OnVoucherRouted()
		{
		}

		// Token: 0x0601675E RID: 91998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601675E")]
		[Address(RVA = "0xEE7BD0", Offset = "0xEE67D0", VA = "0x180EE7BD0")]
		public UIItemDescFloatVoucherRelation()
		{
		}

		// Token: 0x0401B0A9 RID: 110761
		[Token(Token = "0x401B0A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _voucherName;

		// Token: 0x0401B0AA RID: 110762
		[Token(Token = "0x401B0AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _remainTimeContainer;

		// Token: 0x0401B0AB RID: 110763
		[Token(Token = "0x401B0AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemTimeCountDown _remainTimePrefab;

		// Token: 0x0401B0AC RID: 110764
		[Token(Token = "0x401B0AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _remainTimeScale;

		// Token: 0x0401B0AD RID: 110765
		[Token(Token = "0x401B0AD")]
		[FieldOffset(Offset = "0x38")]
		private ItemUtil.ConsumableInfo m_consumableInfo;

		// Token: 0x0401B0AE RID: 110766
		[Token(Token = "0x401B0AE")]
		[FieldOffset(Offset = "0x50")]
		private ItemType m_cachedVoucherItemType;

		// Token: 0x0401B0AF RID: 110767
		[Token(Token = "0x401B0AF")]
		[FieldOffset(Offset = "0x58")]
		private UIItemDescFloatVoucherRelation.VoucherRouteFocus m_cachedFocus;

		// Token: 0x0401B0B0 RID: 110768
		[Token(Token = "0x401B0B0")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0401B0B1 RID: 110769
		[Token(Token = "0x401B0B1")]
		[FieldOffset(Offset = "0x70")]
		private UIItemTimeCountDown m_timeCountDown;

		// Token: 0x0401B0B3 RID: 110771
		[Token(Token = "0x401B0B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onVoucherClicked;

		// Token: 0x0401B0B4 RID: 110772
		[Token(Token = "0x401B0B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onVoucherClicked;

		// Token: 0x0401B0B5 RID: 110773
		[Token(Token = "0x401B0B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B0B6 RID: 110774
		[Token(Token = "0x401B0B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B0B7 RID: 110775
		[Token(Token = "0x401B0B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnVoucherRouted;

		// Token: 0x0401B0B8 RID: 110776
		[Token(Token = "0x401B0B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200373B RID: 14139
		[Token(Token = "0x200373B")]
		public struct VoucherRouteFocus
		{
			// Token: 0x0401B0B9 RID: 110777
			[Token(Token = "0x401B0B9")]
			[FieldOffset(Offset = "0x0")]
			public string focusItemId;

			// Token: 0x0401B0BA RID: 110778
			[Token(Token = "0x401B0BA")]
			[FieldOffset(Offset = "0x8")]
			public long focusItemNeedCount;
		}
	}
}
