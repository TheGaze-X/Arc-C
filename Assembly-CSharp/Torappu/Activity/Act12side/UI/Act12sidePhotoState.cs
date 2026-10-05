using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A9B RID: 31387
	[Token(Token = "0x2007A9B")]
	public class Act12sidePhotoState : PopupFloatState
	{
		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x0602BF8D RID: 180109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700670E")]
		protected Act12sideStageController actController
		{
			[Token(Token = "0x602BF8D")]
			[Address(RVA = "0x27E1A00", Offset = "0x27E0600", VA = "0x1827E1A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BF8E RID: 180110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF8E")]
		[Address(RVA = "0x27E1320", Offset = "0x27DFF20", VA = "0x1827E1320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF8F RID: 180111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF8F")]
		[Address(RVA = "0x27E17F0", Offset = "0x27E03F0", VA = "0x1827E17F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF90 RID: 180112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF90")]
		[Address(RVA = "0x27E1690", Offset = "0x27E0290", VA = "0x1827E1690")]
		private void _FetchStageController()
		{
		}

		// Token: 0x0602BF91 RID: 180113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF91")]
		[Address(RVA = "0x27E1200", Offset = "0x27DFE00", VA = "0x1827E1200", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF92 RID: 180114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF92")]
		[Address(RVA = "0x27E1260", Offset = "0x27DFE60", VA = "0x1827E1260")]
		public void OnBtnJump()
		{
		}

		// Token: 0x0602BF93 RID: 180115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF93")]
		[Address(RVA = "0x27E1910", Offset = "0x27E0510", VA = "0x1827E1910")]
		public Act12sidePhotoState()
		{
		}

		// Token: 0x0602BF94 RID: 180116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF94")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403FB0C RID: 260876
		[Token(Token = "0x403FB0C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _bgRt;

		// Token: 0x0403FB0D RID: 260877
		[Token(Token = "0x403FB0D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _btnJumpGo;

		// Token: 0x0403FB0E RID: 260878
		[Token(Token = "0x403FB0E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textJumpDesc;

		// Token: 0x0403FB0F RID: 260879
		[Token(Token = "0x403FB0F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FB10 RID: 260880
		[Token(Token = "0x403FB10")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403FB11 RID: 260881
		[Token(Token = "0x403FB11")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgPhoto;

		// Token: 0x0403FB12 RID: 260882
		[Token(Token = "0x403FB12")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act12sidePhotoState.PhotoSprite[] _photoSpriteList;

		// Token: 0x0403FB13 RID: 260883
		[Token(Token = "0x403FB13")]
		[FieldOffset(Offset = "0xA8")]
		private Act12sidePhotoStateBean m_stateBean;

		// Token: 0x0403FB14 RID: 260884
		[Token(Token = "0x403FB14")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0403FB15 RID: 260885
		[Token(Token = "0x403FB15")]
		[FieldOffset(Offset = "0xB8")]
		private Act12sideStageController m_stageController;

		// Token: 0x0403FB16 RID: 260886
		[Token(Token = "0x403FB16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403FB17 RID: 260887
		[Token(Token = "0x403FB17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FB18 RID: 260888
		[Token(Token = "0x403FB18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FB19 RID: 260889
		[Token(Token = "0x403FB19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403FB1A RID: 260890
		[Token(Token = "0x403FB1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FB1B RID: 260891
		[Token(Token = "0x403FB1B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnJump;

		// Token: 0x0403FB1C RID: 260892
		[Token(Token = "0x403FB1C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A9C RID: 31388
		[Token(Token = "0x2007A9C")]
		[Serializable]
		public class PhotoSprite
		{
			// Token: 0x0602BF95 RID: 180117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BF95")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PhotoSprite()
			{
			}

			// Token: 0x0403FB1D RID: 260893
			[Token(Token = "0x403FB1D")]
			[FieldOffset(Offset = "0x10")]
			public string picId;

			// Token: 0x0403FB1E RID: 260894
			[Token(Token = "0x403FB1E")]
			[FieldOffset(Offset = "0x18")]
			public Sprite picSprite;
		}
	}
}
