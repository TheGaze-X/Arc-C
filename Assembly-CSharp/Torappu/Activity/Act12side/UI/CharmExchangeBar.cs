using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A7A RID: 31354
	[Token(Token = "0x2007A7A")]
	public class CharmExchangeBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BEAC RID: 179884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEAC")]
		[Address(RVA = "0x27D4020", Offset = "0x27D2C20", VA = "0x1827D4020")]
		public void UpdateProgress(int cur, int target)
		{
		}

		// Token: 0x0602BEAD RID: 179885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BEAD")]
		[Address(RVA = "0x27D3F40", Offset = "0x27D2B40", VA = "0x1827D3F40")]
		public IEnumerator UpdateProgressToNext(int next, int target)
		{
			return null;
		}

		// Token: 0x0602BEAE RID: 179886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEAE")]
		[Address(RVA = "0x27D3DC0", Offset = "0x27D29C0", VA = "0x1827D3DC0")]
		public void UpdateNextPrg(int next, int target)
		{
		}

		// Token: 0x0602BEAF RID: 179887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEAF")]
		[Address(RVA = "0x27D3BF0", Offset = "0x27D27F0", VA = "0x1827D3BF0")]
		public void SetShowPrgDetail(bool v)
		{
		}

		// Token: 0x0602BEB0 RID: 179888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEB0")]
		[Address(RVA = "0x27D3D40", Offset = "0x27D2940", VA = "0x1827D3D40")]
		public void StopBlink()
		{
		}

		// Token: 0x0602BEB1 RID: 179889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEB1")]
		[Address(RVA = "0x27D3B70", Offset = "0x27D2770", VA = "0x1827D3B70")]
		public void FadeInDetail()
		{
		}

		// Token: 0x0602BEB2 RID: 179890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEB2")]
		[Address(RVA = "0x27D4160", Offset = "0x27D2D60", VA = "0x1827D4160")]
		public CharmExchangeBar()
		{
		}

		// Token: 0x0403F9B0 RID: 260528
		[Token(Token = "0x403F9B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403F9B1 RID: 260529
		[Token(Token = "0x403F9B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _iconNormal;

		// Token: 0x0403F9B2 RID: 260530
		[Token(Token = "0x403F9B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _iconGradient;

		// Token: 0x0403F9B3 RID: 260531
		[Token(Token = "0x403F9B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _prgPic;

		// Token: 0x0403F9B4 RID: 260532
		[Token(Token = "0x403F9B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _nextPrgPic;

		// Token: 0x0403F9B5 RID: 260533
		[Token(Token = "0x403F9B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _num;

		// Token: 0x0403F9B6 RID: 260534
		[Token(Token = "0x403F9B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _prgDetail;

		// Token: 0x0403F9B7 RID: 260535
		[Token(Token = "0x403F9B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _curNum;

		// Token: 0x0403F9B8 RID: 260536
		[Token(Token = "0x403F9B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _targetNum;

		// Token: 0x0403F9B9 RID: 260537
		[Token(Token = "0x403F9B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIEffectHelper _effect;

		// Token: 0x0403F9BA RID: 260538
		[Token(Token = "0x403F9BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403F9BB RID: 260539
		[Token(Token = "0x403F9BB")]
		private const string ANIM_BLINK_ANIM_NAME = "exchange_prg_blink";

		// Token: 0x0403F9BC RID: 260540
		[Token(Token = "0x403F9BC")]
		private const string ANIM_DETAIL_FADEIN = "exchange_prg_detail_fadein";

		// Token: 0x0403F9BD RID: 260541
		[Token(Token = "0x403F9BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateProgress;

		// Token: 0x0403F9BE RID: 260542
		[Token(Token = "0x403F9BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateProgressToNext;

		// Token: 0x0403F9BF RID: 260543
		[Token(Token = "0x403F9BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateNextPrg;

		// Token: 0x0403F9C0 RID: 260544
		[Token(Token = "0x403F9C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShowPrgDetail;

		// Token: 0x0403F9C1 RID: 260545
		[Token(Token = "0x403F9C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopBlink;

		// Token: 0x0403F9C2 RID: 260546
		[Token(Token = "0x403F9C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FadeInDetail;

		// Token: 0x0403F9C3 RID: 260547
		[Token(Token = "0x403F9C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
