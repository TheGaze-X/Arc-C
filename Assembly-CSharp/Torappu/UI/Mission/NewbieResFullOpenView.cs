using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004870 RID: 18544
	[Token(Token = "0x2004870")]
	public class NewbieResFullOpenView : DataBinder<NewbieResFullOpenProp>
	{
		// Token: 0x0601C018 RID: 114712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C018")]
		[Address(RVA = "0x155FA50", Offset = "0x155E650", VA = "0x18155FA50", Slot = "7")]
		public override void OnValueChanged(NewbieResFullOpenProp property)
		{
		}

		// Token: 0x0601C019 RID: 114713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C019")]
		[Address(RVA = "0x155FEE0", Offset = "0x155EAE0", VA = "0x18155FEE0")]
		public NewbieResFullOpenView()
		{
		}

		// Token: 0x04024880 RID: 149632
		[Token(Token = "0x4024880")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04024881 RID: 149633
		[Token(Token = "0x4024881")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04024882 RID: 149634
		[Token(Token = "0x4024882")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRemainDay;

		// Token: 0x04024883 RID: 149635
		[Token(Token = "0x4024883")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLockHint;

		// Token: 0x04024884 RID: 149636
		[Token(Token = "0x4024884")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _remainDayGo;

		// Token: 0x04024885 RID: 149637
		[Token(Token = "0x4024885")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lockHintGo;

		// Token: 0x04024886 RID: 149638
		[Token(Token = "0x4024886")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _expireHintGo;

		// Token: 0x04024887 RID: 149639
		[Token(Token = "0x4024887")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pauseHintGo;

		// Token: 0x04024888 RID: 149640
		[Token(Token = "0x4024888")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _bgRemainTime;

		// Token: 0x04024889 RID: 149641
		[Token(Token = "0x4024889")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorActiveTimeBg;

		// Token: 0x0402488A RID: 149642
		[Token(Token = "0x402488A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorPauseTimeBg;

		// Token: 0x0402488B RID: 149643
		[Token(Token = "0x402488B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorActiveTimeText;

		// Token: 0x0402488C RID: 149644
		[Token(Token = "0x402488C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorPauseTimeText;

		// Token: 0x0402488D RID: 149645
		[Token(Token = "0x402488D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402488E RID: 149646
		[Token(Token = "0x402488E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
