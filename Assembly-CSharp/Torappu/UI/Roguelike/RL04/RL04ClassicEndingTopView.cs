using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005692 RID: 22162
	[Token(Token = "0x2005692")]
	public class RL04ClassicEndingTopView : RoguelikeClassicEndingTopView
	{
		// Token: 0x17004C2C RID: 19500
		// (set) Token: 0x0602082C RID: 133164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C2C")]
		public override Action onShowReport
		{
			[Token(Token = "0x602082C")]
			[Address(RVA = "0x1AA6AE0", Offset = "0x1AA56E0", VA = "0x181AA6AE0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x0602082D RID: 133165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C2D")]
		protected override string showAnimName
		{
			[Token(Token = "0x602082D")]
			[Address(RVA = "0x1AA6A70", Offset = "0x1AA5670", VA = "0x181AA6A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602082E RID: 133166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602082E")]
		[Address(RVA = "0x1AA6490", Offset = "0x1AA5090", VA = "0x181AA6490", Slot = "6")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x0602082F RID: 133167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602082F")]
		[Address(RVA = "0x1AA67A0", Offset = "0x1AA53A0", VA = "0x181AA67A0")]
		private void _RenderDifficultIcon(RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020830 RID: 133168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020830")]
		[Address(RVA = "0x1AA66C0", Offset = "0x1AA52C0", VA = "0x181AA66C0")]
		private string _GetFailEndingIconName(RoguelikeClassicEndingViewModel endingViewModel)
		{
			return null;
		}

		// Token: 0x06020831 RID: 133169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020831")]
		[Address(RVA = "0x1AA65D0", Offset = "0x1AA51D0", VA = "0x181AA65D0")]
		private string _GetEndingIconName(RoguelikeClassicEndingViewModel endingViewModel)
		{
			return null;
		}

		// Token: 0x06020832 RID: 133170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020832")]
		[Address(RVA = "0x1AA6420", Offset = "0x1AA5020", VA = "0x181AA6420")]
		public void OnShowReportClicked()
		{
		}

		// Token: 0x06020833 RID: 133171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020833")]
		[Address(RVA = "0x1AA6A10", Offset = "0x1AA5610", VA = "0x181AA6A10")]
		public RL04ClassicEndingTopView()
		{
		}

		// Token: 0x0402C0E1 RID: 180449
		[Token(Token = "0x402C0E1")]
		private const string SHOW_ANIM_NAME = "anim_in";

		// Token: 0x0402C0E2 RID: 180450
		[Token(Token = "0x402C0E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x0402C0E3 RID: 180451
		[Token(Token = "0x402C0E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _failIconId;

		// Token: 0x0402C0E4 RID: 180452
		[Token(Token = "0x402C0E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C0E5 RID: 180453
		[Token(Token = "0x402C0E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _titleIcon;

		// Token: 0x0402C0E6 RID: 180454
		[Token(Token = "0x402C0E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlSuccess;

		// Token: 0x0402C0E7 RID: 180455
		[Token(Token = "0x402C0E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlFailed;

		// Token: 0x0402C0E8 RID: 180456
		[Token(Token = "0x402C0E8")]
		[FieldOffset(Offset = "0x68")]
		private Action m_onShowReport;

		// Token: 0x0402C0E9 RID: 180457
		[Token(Token = "0x402C0E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onShowReport;

		// Token: 0x0402C0EA RID: 180458
		[Token(Token = "0x402C0EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showAnimName;

		// Token: 0x0402C0EB RID: 180459
		[Token(Token = "0x402C0EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C0EC RID: 180460
		[Token(Token = "0x402C0EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDifficultIcon;

		// Token: 0x0402C0ED RID: 180461
		[Token(Token = "0x402C0ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetFailEndingIconName;

		// Token: 0x0402C0EE RID: 180462
		[Token(Token = "0x402C0EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetEndingIconName;

		// Token: 0x0402C0EF RID: 180463
		[Token(Token = "0x402C0EF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnShowReportClicked;

		// Token: 0x0402C0F0 RID: 180464
		[Token(Token = "0x402C0F0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
