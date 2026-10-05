using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200722E RID: 29230
	[Token(Token = "0x200722E")]
	public class RuneBattleFinishHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296CF RID: 169679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296CF")]
		[Address(RVA = "0x24D5120", Offset = "0x24D3D20", VA = "0x1824D5120")]
		public void Render(RuneBattleFinishStateBean stateBean)
		{
		}

		// Token: 0x060296D0 RID: 169680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296D0")]
		[Address(RVA = "0x24D4CC0", Offset = "0x24D38C0", VA = "0x1824D4CC0")]
		public void PlayAnim()
		{
		}

		// Token: 0x060296D1 RID: 169681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296D1")]
		[Address(RVA = "0x24D4D40", Offset = "0x24D3940", VA = "0x1824D4D40")]
		public void RenderIllust(CharUISkinStruct randomIllust)
		{
		}

		// Token: 0x060296D2 RID: 169682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60296D2")]
		[Address(RVA = "0x24D5790", Offset = "0x24D4390", VA = "0x1824D5790")]
		private IEnumerator _UpdateIllust()
		{
			return null;
		}

		// Token: 0x060296D3 RID: 169683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296D3")]
		[Address(RVA = "0x24D5620", Offset = "0x24D4220", VA = "0x1824D5620")]
		private void _PlayCharThreeStarVoice(VoiceQuery voiceQuery)
		{
		}

		// Token: 0x060296D4 RID: 169684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296D4")]
		[Address(RVA = "0x24D5840", Offset = "0x24D4440", VA = "0x1824D5840")]
		public RuneBattleFinishHolder()
		{
		}

		// Token: 0x0403B2AD RID: 242349
		[Token(Token = "0x403B2AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _battleStageBg;

		// Token: 0x0403B2AE RID: 242350
		[Token(Token = "0x403B2AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _battleStageLogo;

		// Token: 0x0403B2AF RID: 242351
		[Token(Token = "0x403B2AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _battleStageTitle;

		// Token: 0x0403B2B0 RID: 242352
		[Token(Token = "0x403B2B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _battleStageDesc;

		// Token: 0x0403B2B1 RID: 242353
		[Token(Token = "0x403B2B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _runeValue;

		// Token: 0x0403B2B2 RID: 242354
		[Token(Token = "0x403B2B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _healthValue;

		// Token: 0x0403B2B3 RID: 242355
		[Token(Token = "0x403B2B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BattleFinishRuneGridAdapter _runeAdapter;

		// Token: 0x0403B2B4 RID: 242356
		[Token(Token = "0x403B2B4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<BattleFinishCardPlaceHolder> _cellTransList;

		// Token: 0x0403B2B5 RID: 242357
		[Token(Token = "0x403B2B5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BattleFinishCardPlaceHolder _cellFriendTrans;

		// Token: 0x0403B2B6 RID: 242358
		[Token(Token = "0x403B2B6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BattleFinishCard _cellObj;

		// Token: 0x0403B2B7 RID: 242359
		[Token(Token = "0x403B2B7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _illustTrans;

		// Token: 0x0403B2B8 RID: 242360
		[Token(Token = "0x403B2B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _anim;

		// Token: 0x0403B2B9 RID: 242361
		[Token(Token = "0x403B2B9")]
		[FieldOffset(Offset = "0x78")]
		private UICharacterIllust m_illust;

		// Token: 0x0403B2BA RID: 242362
		[Token(Token = "0x403B2BA")]
		private const int MAXFRAME = 10;

		// Token: 0x0403B2BB RID: 242363
		[Token(Token = "0x403B2BB")]
		private const string START_ANIM_KEY = "Start";

		// Token: 0x0403B2BC RID: 242364
		[Token(Token = "0x403B2BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B2BD RID: 242365
		[Token(Token = "0x403B2BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0403B2BE RID: 242366
		[Token(Token = "0x403B2BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderIllust;

		// Token: 0x0403B2BF RID: 242367
		[Token(Token = "0x403B2BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateIllust;

		// Token: 0x0403B2C0 RID: 242368
		[Token(Token = "0x403B2C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayCharThreeStarVoice;

		// Token: 0x0403B2C1 RID: 242369
		[Token(Token = "0x403B2C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
