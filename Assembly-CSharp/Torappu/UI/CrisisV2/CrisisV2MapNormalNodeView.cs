using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059B7 RID: 22967
	[Token(Token = "0x20059B7")]
	public class CrisisV2MapNormalNodeView : CrisisV2MapNodeViewBase
	{
		// Token: 0x060217A0 RID: 137120 RVA: 0x000BA630 File Offset: 0x000B8830
		[Token(Token = "0x60217A0")]
		[Address(RVA = "0x1BD41E0", Offset = "0x1BD2DE0", VA = "0x181BD41E0", Slot = "4")]
		public override CrisisV2NodeSlotType GetSlotType()
		{
			return CrisisV2NodeSlotType.NONE;
		}

		// Token: 0x060217A1 RID: 137121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A1")]
		[Address(RVA = "0x1BD4240", Offset = "0x1BD2E40", VA = "0x181BD4240", Slot = "6")]
		protected override void PlayHighlightAnimIfNeed(bool isNodeHighlight)
		{
		}

		// Token: 0x060217A2 RID: 137122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A2")]
		[Address(RVA = "0x1BD42C0", Offset = "0x1BD2EC0", VA = "0x181BD42C0", Slot = "5")]
		protected override void Render()
		{
		}

		// Token: 0x060217A3 RID: 137123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A3")]
		[Address(RVA = "0x1BD46E0", Offset = "0x1BD32E0", VA = "0x181BD46E0")]
		private void _UpdateRuneIcon(CrisisV2MapNormalNodeModel normalNodeModel)
		{
		}

		// Token: 0x060217A4 RID: 137124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A4")]
		[Address(RVA = "0x1BD4840", Offset = "0x1BD3440", VA = "0x181BD4840")]
		public CrisisV2MapNormalNodeView()
		{
		}

		// Token: 0x060217A5 RID: 137125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A5")]
		[Address(RVA = "0x1BD3130", Offset = "0x1BD1D30", VA = "0x181BD3130")]
		private void <>xLuaBaseProxy_PlayHighlightAnimIfNeed(bool P0)
		{
		}

		// Token: 0x0402DB95 RID: 187285
		[Token(Token = "0x402DB95")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _normalViewGo;

		// Token: 0x0402DB96 RID: 187286
		[Token(Token = "0x402DB96")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _unknowViewGo;

		// Token: 0x0402DB97 RID: 187287
		[Token(Token = "0x402DB97")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _bgDisable;

		// Token: 0x0402DB98 RID: 187288
		[Token(Token = "0x402DB98")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _bgUnselect;

		// Token: 0x0402DB99 RID: 187289
		[Token(Token = "0x402DB99")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _bgSelect;

		// Token: 0x0402DB9A RID: 187290
		[Token(Token = "0x402DB9A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _bgExclusion;

		// Token: 0x0402DB9B RID: 187291
		[Token(Token = "0x402DB9B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _iconCompletedGo;

		// Token: 0x0402DB9C RID: 187292
		[Token(Token = "0x402DB9C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0402DB9D RID: 187293
		[Token(Token = "0x402DB9D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imgRune;

		// Token: 0x0402DB9E RID: 187294
		[Token(Token = "0x402DB9E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _toggleExclusion;

		// Token: 0x0402DB9F RID: 187295
		[Token(Token = "0x402DB9F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoStateToggle _toggleScoreBg;

		// Token: 0x0402DBA0 RID: 187296
		[Token(Token = "0x402DBA0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorRuneUnselect;

		// Token: 0x0402DBA1 RID: 187297
		[Token(Token = "0x402DBA1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorRuneSelect;

		// Token: 0x0402DBA2 RID: 187298
		[Token(Token = "0x402DBA2")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _colorRuneUnreach;

		// Token: 0x0402DBA3 RID: 187299
		[Token(Token = "0x402DBA3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color _colorScoreReachable;

		// Token: 0x0402DBA4 RID: 187300
		[Token(Token = "0x402DBA4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Color _colorScoreUnreach;

		// Token: 0x0402DBA5 RID: 187301
		[Token(Token = "0x402DBA5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _highlightAnimGo;

		// Token: 0x0402DBA6 RID: 187302
		[Token(Token = "0x402DBA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSlotType;

		// Token: 0x0402DBA7 RID: 187303
		[Token(Token = "0x402DBA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayHighlightAnimIfNeed;

		// Token: 0x0402DBA8 RID: 187304
		[Token(Token = "0x402DBA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DBA9 RID: 187305
		[Token(Token = "0x402DBA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateRuneIcon;

		// Token: 0x0402DBAA RID: 187306
		[Token(Token = "0x402DBAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
