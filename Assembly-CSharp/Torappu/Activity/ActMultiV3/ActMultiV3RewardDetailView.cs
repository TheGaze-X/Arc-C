using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F35 RID: 28469
	[Token(Token = "0x2006F35")]
	public class ActMultiV3RewardDetailView : DataBinder<ActMultiV3RewardDetailProperty>
	{
		// Token: 0x060286F3 RID: 165619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F3")]
		[Address(RVA = "0x23BB230", Offset = "0x23B9E30", VA = "0x1823BB230", Slot = "7")]
		public override void OnValueChanged(ActMultiV3RewardDetailProperty property)
		{
		}

		// Token: 0x060286F4 RID: 165620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F4")]
		[Address(RVA = "0x23BB5A0", Offset = "0x23BA1A0", VA = "0x1823BB5A0")]
		public ActMultiV3RewardDetailView()
		{
		}

		// Token: 0x0403983C RID: 235580
		[Token(Token = "0x403983C")]
		private const string FORMAT_TOTAL_COUNT = "/{0}";

		// Token: 0x0403983D RID: 235581
		[Token(Token = "0x403983D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSeasonLogo;

		// Token: 0x0403983E RID: 235582
		[Token(Token = "0x403983E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDailyMissionName;

		// Token: 0x0403983F RID: 235583
		[Token(Token = "0x403983F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _progressBar;

		// Token: 0x04039840 RID: 235584
		[Token(Token = "0x4039840")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDailyMissionRule;

		// Token: 0x04039841 RID: 235585
		[Token(Token = "0x4039841")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _progressBarTotLen;

		// Token: 0x04039842 RID: 235586
		[Token(Token = "0x4039842")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _progressBarMinLen;

		// Token: 0x04039843 RID: 235587
		[Token(Token = "0x4039843")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _progressBarHeight;

		// Token: 0x04039844 RID: 235588
		[Token(Token = "0x4039844")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCurrCount;

		// Token: 0x04039845 RID: 235589
		[Token(Token = "0x4039845")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTotCount;

		// Token: 0x04039846 RID: 235590
		[Token(Token = "0x4039846")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039847 RID: 235591
		[Token(Token = "0x4039847")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039848 RID: 235592
		[Token(Token = "0x4039848")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
