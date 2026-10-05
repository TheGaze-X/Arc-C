using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070CB RID: 28875
	[Token(Token = "0x20070CB")]
	public class Act1BossRushMissionPlugin : MonoBehaviour, TemplateActivityMissionPlugin, IHotfixable
	{
		// Token: 0x06029089 RID: 168073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029089")]
		[Address(RVA = "0x246AF90", Offset = "0x2469B90", VA = "0x18246AF90", Slot = "4")]
		public void ApplyDataBundle(TemplateMissionViewModel missionData)
		{
		}

		// Token: 0x0602908A RID: 168074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602908A")]
		[Address(RVA = "0x246B070", Offset = "0x2469C70", VA = "0x18246B070", Slot = "5")]
		public void RenderCoro(Action commonRender)
		{
		}

		// Token: 0x0602908B RID: 168075 RVA: 0x000D4208 File Offset: 0x000D2408
		[Token(Token = "0x602908B")]
		[Address(RVA = "0x246B010", Offset = "0x2469C10", VA = "0x18246B010", Slot = "6")]
		public bool IsAvailClick()
		{
			return default(bool);
		}

		// Token: 0x0602908C RID: 168076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602908C")]
		[Address(RVA = "0x246B5A0", Offset = "0x246A1A0", VA = "0x18246B5A0")]
		public Act1BossRushMissionPlugin()
		{
		}

		// Token: 0x0403A93A RID: 239930
		[Token(Token = "0x403A93A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRewardsBgDec;

		// Token: 0x0403A93B RID: 239931
		[Token(Token = "0x403A93B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgRewardsBg1;

		// Token: 0x0403A93C RID: 239932
		[Token(Token = "0x403A93C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgRewardsBg2;

		// Token: 0x0403A93D RID: 239933
		[Token(Token = "0x403A93D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _availRewardBgColor;

		// Token: 0x0403A93E RID: 239934
		[Token(Token = "0x403A93E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _notAvailRewardBgColor;

		// Token: 0x0403A93F RID: 239935
		[Token(Token = "0x403A93F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objRewardAdapter;

		// Token: 0x0403A940 RID: 239936
		[Token(Token = "0x403A940")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objRelicParent;

		// Token: 0x0403A941 RID: 239937
		[Token(Token = "0x403A941")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objRelicNormalBg;

		// Token: 0x0403A942 RID: 239938
		[Token(Token = "0x403A942")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objRelicActiveBg;

		// Token: 0x0403A943 RID: 239939
		[Token(Token = "0x403A943")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _relicIcon;

		// Token: 0x0403A944 RID: 239940
		[Token(Token = "0x403A944")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRelicName;

		// Token: 0x0403A945 RID: 239941
		[Token(Token = "0x403A945")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _availRelicColor;

		// Token: 0x0403A946 RID: 239942
		[Token(Token = "0x403A946")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _notAvailRelicColor;

		// Token: 0x0403A947 RID: 239943
		[Token(Token = "0x403A947")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x0403A948 RID: 239944
		[Token(Token = "0x403A948")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _availMissionColor;

		// Token: 0x0403A949 RID: 239945
		[Token(Token = "0x403A949")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _notAvailMissionColor;

		// Token: 0x0403A94A RID: 239946
		[Token(Token = "0x403A94A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textProgressDetail;

		// Token: 0x0403A94B RID: 239947
		[Token(Token = "0x403A94B")]
		private const string COLOR_PROGRESS_AVAIL = "<color=#FF9C00>{0}</color><color=#000000>/{1}</color>";

		// Token: 0x0403A94C RID: 239948
		[Token(Token = "0x403A94C")]
		private const string COLOR_PROGRESS_NOT_AVAIL = "<color=#FF9C00>{0}</color><color=#FFFFFF>/{1}</color>";

		// Token: 0x0403A94D RID: 239949
		[Token(Token = "0x403A94D")]
		[FieldOffset(Offset = "0xD0")]
		private TemplateMissionViewModel m_cacheViewModel;

		// Token: 0x0403A94E RID: 239950
		[Token(Token = "0x403A94E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x0403A94F RID: 239951
		[Token(Token = "0x403A94F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderCoro;

		// Token: 0x0403A950 RID: 239952
		[Token(Token = "0x403A950")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsAvailClick;

		// Token: 0x0403A951 RID: 239953
		[Token(Token = "0x403A951")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
