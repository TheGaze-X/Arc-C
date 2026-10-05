using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E2F RID: 20015
	[Token(Token = "0x2004E2F")]
	public class FireworkPlateListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE6E RID: 122478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE6E")]
		[Address(RVA = "0x176E540", Offset = "0x176D140", VA = "0x18176E540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DE6F RID: 122479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE6F")]
		[Address(RVA = "0x176DE00", Offset = "0x176CA00", VA = "0x18176DE00")]
		public void Render(FireworkPieceGroupModel pieceGroupModel, FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style)
		{
		}

		// Token: 0x0601DE70 RID: 122480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE70")]
		[Address(RVA = "0x176E630", Offset = "0x176D230", VA = "0x18176E630")]
		private void _UpdateHintDisplay(FireworkPlateGroupModel groupModel, FireworkPieceGroupModel pieceGroupModel)
		{
		}

		// Token: 0x0601DE71 RID: 122481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE71")]
		[Address(RVA = "0x176DD20", Offset = "0x176C920", VA = "0x18176DD20")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601DE72 RID: 122482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE72")]
		[Address(RVA = "0x176DC10", Offset = "0x176C810", VA = "0x18176DC10")]
		public void OnClicked()
		{
		}

		// Token: 0x0601DE73 RID: 122483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE73")]
		[Address(RVA = "0x176E8F0", Offset = "0x176D4F0", VA = "0x18176E8F0")]
		public FireworkPlateListItemView()
		{
		}

		// Token: 0x04027AA9 RID: 162473
		[Token(Token = "0x4027AA9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlTag;

		// Token: 0x04027AAA RID: 162474
		[Token(Token = "0x4027AAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgTagBkg;

		// Token: 0x04027AAB RID: 162475
		[Token(Token = "0x4027AAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _imgTagText;

		// Token: 0x04027AAC RID: 162476
		[Token(Token = "0x4027AAC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x04027AAD RID: 162477
		[Token(Token = "0x4027AAD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRange;

		// Token: 0x04027AAE RID: 162478
		[Token(Token = "0x4027AAE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _previewingAlphaHandler;

		// Token: 0x04027AAF RID: 162479
		[Token(Token = "0x4027AAF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgSelectedLight;

		// Token: 0x04027AB0 RID: 162480
		[Token(Token = "0x4027AB0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04027AB1 RID: 162481
		[Token(Token = "0x4027AB1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x04027AB2 RID: 162482
		[Token(Token = "0x4027AB2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _spriteFilled;

		// Token: 0x04027AB3 RID: 162483
		[Token(Token = "0x4027AB3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _spriteNormal;

		// Token: 0x04027AB4 RID: 162484
		[Token(Token = "0x4027AB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FireworkPlatePieceView _pieceView;

		// Token: 0x04027AB5 RID: 162485
		[Token(Token = "0x4027AB5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _hintGo;

		// Token: 0x04027AB6 RID: 162486
		[Token(Token = "0x4027AB6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animHint;

		// Token: 0x04027AB7 RID: 162487
		[Token(Token = "0x4027AB7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasImage _imgRangeCenter;

		// Token: 0x04027AB8 RID: 162488
		[Token(Token = "0x4027AB8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _hotspotGo;

		// Token: 0x04027AB9 RID: 162489
		[Token(Token = "0x4027AB9")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04027ABA RID: 162490
		[Token(Token = "0x4027ABA")]
		[FieldOffset(Offset = "0xA8")]
		private UISwitchTween m_previewingTween;

		// Token: 0x04027ABB RID: 162491
		[Token(Token = "0x4027ABB")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedGroupId;

		// Token: 0x04027ABC RID: 162492
		[Token(Token = "0x4027ABC")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027ABD RID: 162493
		[Token(Token = "0x4027ABD")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_hintTween;

		// Token: 0x04027ABE RID: 162494
		[Token(Token = "0x4027ABE")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cacheHintSeqNum;

		// Token: 0x04027ABF RID: 162495
		[Token(Token = "0x4027ABF")]
		[FieldOffset(Offset = "0xD4")]
		private int m_cacheHintCount;

		// Token: 0x04027AC0 RID: 162496
		[Token(Token = "0x4027AC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027AC1 RID: 162497
		[Token(Token = "0x4027AC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027AC2 RID: 162498
		[Token(Token = "0x4027AC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateHintDisplay;

		// Token: 0x04027AC3 RID: 162499
		[Token(Token = "0x4027AC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027AC4 RID: 162500
		[Token(Token = "0x4027AC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04027AC5 RID: 162501
		[Token(Token = "0x4027AC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
