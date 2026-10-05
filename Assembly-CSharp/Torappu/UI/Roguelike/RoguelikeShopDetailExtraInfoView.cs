using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054FE RID: 21758
	[Token(Token = "0x20054FE")]
	public class RoguelikeShopDetailExtraInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602000A RID: 131082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602000A")]
		[Address(RVA = "0x1A1FC00", Offset = "0x1A1E800", VA = "0x181A1FC00")]
		public void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602000B RID: 131083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602000B")]
		[Address(RVA = "0x1A1FB70", Offset = "0x1A1E770", VA = "0x181A1FB70")]
		public void InjectPlugin(RoguelikeShopDetailExtraInfoPlugin plugin)
		{
		}

		// Token: 0x0602000C RID: 131084 RVA: 0x000B4300 File Offset: 0x000B2500
		[Token(Token = "0x602000C")]
		[Address(RVA = "0x1A1FF80", Offset = "0x1A1EB80", VA = "0x181A1FF80")]
		private RoguelikeShopDetailExtraInfo _GetTipsInfo(RoguelikeGoodsViewModel viewModel)
		{
			return default(RoguelikeShopDetailExtraInfo);
		}

		// Token: 0x0602000D RID: 131085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602000D")]
		[Address(RVA = "0x1A20480", Offset = "0x1A1F080", VA = "0x181A20480")]
		public RoguelikeShopDetailExtraInfoView()
		{
		}

		// Token: 0x0402B30F RID: 176911
		[Token(Token = "0x402B30F")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static Color DEFAULT_BKG_COLOR;

		// Token: 0x0402B310 RID: 176912
		[Token(Token = "0x402B310")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _panelExtraInfo;

		// Token: 0x0402B311 RID: 176913
		[Token(Token = "0x402B311")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textExtraInfo;

		// Token: 0x0402B312 RID: 176914
		[Token(Token = "0x402B312")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bkgExtraInfo;

		// Token: 0x0402B313 RID: 176915
		[Token(Token = "0x402B313")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Color style")]
		private Color _colorRecruitHint;

		// Token: 0x0402B314 RID: 176916
		[Token(Token = "0x402B314")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Color style")]
		private Color _colorTrapHint;

		// Token: 0x0402B315 RID: 176917
		[Token(Token = "0x402B315")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Color style")]
		private Color _colorEffectiveHint;

		// Token: 0x0402B316 RID: 176918
		[Token(Token = "0x402B316")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeShopDetailExtraInfo m_info;

		// Token: 0x0402B317 RID: 176919
		[Token(Token = "0x402B317")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeShopDetailExtraInfoPlugin m_infoPlugin;

		// Token: 0x0402B318 RID: 176920
		[Token(Token = "0x402B318")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B319 RID: 176921
		[Token(Token = "0x402B319")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0402B31A RID: 176922
		[Token(Token = "0x402B31A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTipsInfo;

		// Token: 0x0402B31B RID: 176923
		[Token(Token = "0x402B31B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
