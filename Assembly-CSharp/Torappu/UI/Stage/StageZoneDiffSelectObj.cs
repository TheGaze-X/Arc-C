using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006906 RID: 26886
	[Token(Token = "0x2006906")]
	public class StageZoneDiffSelectObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026824 RID: 157732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026824")]
		[Address(RVA = "0x21A40A0", Offset = "0x21A2CA0", VA = "0x1821A40A0")]
		public void Render(StageDiffGroup diffGroup, bool isUnlock)
		{
		}

		// Token: 0x06026825 RID: 157733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026825")]
		[Address(RVA = "0x21A3FD0", Offset = "0x21A2BD0", VA = "0x1821A3FD0")]
		public void OnClick()
		{
		}

		// Token: 0x06026826 RID: 157734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026826")]
		[Address(RVA = "0x21A4340", Offset = "0x21A2F40", VA = "0x1821A4340")]
		public void SetSelect(StageDiffGroup diffGroup)
		{
		}

		// Token: 0x06026827 RID: 157735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026827")]
		[Address(RVA = "0x21A4590", Offset = "0x21A3190", VA = "0x1821A4590")]
		public StageZoneDiffSelectObj()
		{
		}

		// Token: 0x04036460 RID: 222304
		[Token(Token = "0x4036460")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIDiffGroupEvent selectDiffAction;

		// Token: 0x04036461 RID: 222305
		[Token(Token = "0x4036461")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x04036462 RID: 222306
		[Token(Token = "0x4036462")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _longName;

		// Token: 0x04036463 RID: 222307
		[Token(Token = "0x4036463")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _shortName;

		// Token: 0x04036464 RID: 222308
		[Token(Token = "0x4036464")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04036465 RID: 222309
		[Token(Token = "0x4036465")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _isLockPart;

		// Token: 0x04036466 RID: 222310
		[Token(Token = "0x4036466")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _button;

		// Token: 0x04036467 RID: 222311
		[Token(Token = "0x4036467")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04036468 RID: 222312
		[Token(Token = "0x4036468")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x04036469 RID: 222313
		[Token(Token = "0x4036469")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _backImage;

		// Token: 0x0403646A RID: 222314
		[Token(Token = "0x403646A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasObject _atlasHub;

		// Token: 0x0403646B RID: 222315
		[Token(Token = "0x403646B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _commonBack;

		// Token: 0x0403646C RID: 222316
		[Token(Token = "0x403646C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _toughBack;

		// Token: 0x0403646D RID: 222317
		[Token(Token = "0x403646D")]
		[FieldOffset(Offset = "0x88")]
		private StageDiffGroup m_diffGroup;

		// Token: 0x0403646E RID: 222318
		[Token(Token = "0x403646E")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_cacheUnlock;

		// Token: 0x0403646F RID: 222319
		[Token(Token = "0x403646F")]
		private const string PARAM_ANIM = "diff_select_anim";

		// Token: 0x04036470 RID: 222320
		[Token(Token = "0x4036470")]
		[FieldOffset(Offset = "0x90")]
		private float m_state;

		// Token: 0x04036471 RID: 222321
		[Token(Token = "0x4036471")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_cacheTween;

		// Token: 0x04036472 RID: 222322
		[Token(Token = "0x4036472")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036473 RID: 222323
		[Token(Token = "0x4036473")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04036474 RID: 222324
		[Token(Token = "0x4036474")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x04036475 RID: 222325
		[Token(Token = "0x4036475")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
