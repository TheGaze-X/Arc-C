using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F9B RID: 24475
	[Token(Token = "0x2005F9B")]
	public class CharacterInfoRightProfSpreadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602368E RID: 145038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602368E")]
		[Address(RVA = "0x1E071C0", Offset = "0x1E05DC0", VA = "0x181E071C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602368F RID: 145039 RVA: 0x000C0C18 File Offset: 0x000BEE18
		[Token(Token = "0x602368F")]
		[Address(RVA = "0x1E06B50", Offset = "0x1E05750", VA = "0x181E06B50")]
		public float CalcHeight()
		{
			return 0f;
		}

		// Token: 0x06023690 RID: 145040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023690")]
		[Address(RVA = "0x1E06CF0", Offset = "0x1E058F0", VA = "0x181E06CF0")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel, int equipScrollSequenceNum)
		{
		}

		// Token: 0x06023691 RID: 145041 RVA: 0x000C0C30 File Offset: 0x000BEE30
		[Token(Token = "0x6023691")]
		private float _CalcContentSize<TView, TModel>(SimpleLayoutContent content, CharacterInfoRightProfSpreadView.Adapter<TView, TModel> adapter) where TView : CharacterInfoRightProfObj
		{
			return 0f;
		}

		// Token: 0x06023692 RID: 145042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023692")]
		[Address(RVA = "0x1E07390", Offset = "0x1E05F90", VA = "0x181E07390")]
		public CharacterInfoRightProfSpreadView()
		{
		}

		// Token: 0x04030EC9 RID: 200393
		[Token(Token = "0x4030EC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _talentContent;

		// Token: 0x04030ECA RID: 200394
		[Token(Token = "0x4030ECA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _masterContent;

		// Token: 0x04030ECB RID: 200395
		[Token(Token = "0x4030ECB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CharacterInfoRightProfObj> _objList;

		// Token: 0x04030ECC RID: 200396
		[Token(Token = "0x4030ECC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _initHeight;

		// Token: 0x04030ECD RID: 200397
		[Token(Token = "0x4030ECD")]
		[FieldOffset(Offset = "0x38")]
		private CharacterInfoRightProfSpreadView.TalentAdapter m_talentAdapter;

		// Token: 0x04030ECE RID: 200398
		[Token(Token = "0x4030ECE")]
		[FieldOffset(Offset = "0x40")]
		private CharacterInfoRightProfSpreadView.MasterAdapter m_masterAdapter;

		// Token: 0x04030ECF RID: 200399
		[Token(Token = "0x4030ECF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04030ED0 RID: 200400
		[Token(Token = "0x4030ED0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030ED1 RID: 200401
		[Token(Token = "0x4030ED1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalcHeight;

		// Token: 0x04030ED2 RID: 200402
		[Token(Token = "0x4030ED2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030ED3 RID: 200403
		[Token(Token = "0x4030ED3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcContentSize;

		// Token: 0x04030ED4 RID: 200404
		[Token(Token = "0x4030ED4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F9C RID: 24476
		[Token(Token = "0x2005F9C")]
		private abstract class Adapter<TView, TModel> : SimpleLayoutAdapter where TView : CharacterInfoRightProfObj
		{
			// Token: 0x06023693 RID: 145043 RVA: 0x000C0C48 File Offset: 0x000BEE48
			[Token(Token = "0x6023693")]
			public float CalcHeight()
			{
				return 0f;
			}

			// Token: 0x1700539F RID: 21407
			// (get) Token: 0x06023694 RID: 145044 RVA: 0x000C0C60 File Offset: 0x000BEE60
			[Token(Token = "0x1700539F")]
			public override int count
			{
				[Token(Token = "0x6023694")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023695 RID: 145045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023695")]
			protected Adapter()
			{
			}

			// Token: 0x04030ED5 RID: 200405
			[Token(Token = "0x4030ED5")]
			[FieldOffset(Offset = "0x0")]
			public List<TModel> viewModelList;

			// Token: 0x04030ED6 RID: 200406
			[Token(Token = "0x4030ED6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CalcHeight;

			// Token: 0x04030ED7 RID: 200407
			[Token(Token = "0x4030ED7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030ED8 RID: 200408
			[Token(Token = "0x4030ED8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005F9D RID: 24477
		[Token(Token = "0x2005F9D")]
		private class TalentAdapter : CharacterInfoRightProfSpreadView.Adapter<CharacterInfoRightProfTalentView, CharacterTalentViewModel>
		{
			// Token: 0x06023696 RID: 145046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023696")]
			[Address(RVA = "0x1E112A0", Offset = "0x1E0FEA0", VA = "0x181E112A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023697 RID: 145047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023697")]
			[Address(RVA = "0x1E11480", Offset = "0x1E10080", VA = "0x181E11480")]
			public TalentAdapter()
			{
			}

			// Token: 0x04030ED9 RID: 200409
			[Token(Token = "0x4030ED9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030EDA RID: 200410
			[Token(Token = "0x4030EDA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005F9E RID: 24478
		[Token(Token = "0x2005F9E")]
		private class MasterAdapter : CharacterInfoRightProfSpreadView.Adapter<CharacterInfoRightProfMasterView, CharacterMasterViewModel>
		{
			// Token: 0x06023698 RID: 145048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023698")]
			[Address(RVA = "0x1E10410", Offset = "0x1E0F010", VA = "0x181E10410", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023699 RID: 145049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023699")]
			[Address(RVA = "0x1E105B0", Offset = "0x1E0F1B0", VA = "0x181E105B0")]
			public MasterAdapter()
			{
			}

			// Token: 0x04030EDB RID: 200411
			[Token(Token = "0x4030EDB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030EDC RID: 200412
			[Token(Token = "0x4030EDC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
