using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F39 RID: 24377
	[Token(Token = "0x2005F39")]
	public class CharacterTokenDetailShowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060234D6 RID: 144598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234D6")]
		[Address(RVA = "0x1DDED80", Offset = "0x1DDD980", VA = "0x181DDED80")]
		public void Render(CharTokenViewModel tokenData)
		{
		}

		// Token: 0x060234D7 RID: 144599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234D7")]
		[Address(RVA = "0x1DDF380", Offset = "0x1DDDF80", VA = "0x181DDF380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060234D8 RID: 144600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234D8")]
		[Address(RVA = "0x1DDF4B0", Offset = "0x1DDE0B0", VA = "0x181DDF4B0")]
		private void _ShowAttribute()
		{
		}

		// Token: 0x060234D9 RID: 144601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234D9")]
		[Address(RVA = "0x1DDF8F0", Offset = "0x1DDE4F0", VA = "0x181DDF8F0")]
		private void _ShowSubProf()
		{
		}

		// Token: 0x060234DA RID: 144602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234DA")]
		[Address(RVA = "0x1DDF9E0", Offset = "0x1DDE5E0", VA = "0x181DDF9E0")]
		private void _ShowTalent()
		{
		}

		// Token: 0x060234DB RID: 144603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234DB")]
		[Address(RVA = "0x1DDF740", Offset = "0x1DDE340", VA = "0x181DDF740")]
		private void _ShowSkill()
		{
		}

		// Token: 0x060234DC RID: 144604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234DC")]
		[Address(RVA = "0x1DDFAA0", Offset = "0x1DDE6A0", VA = "0x181DDFAA0")]
		public CharacterTokenDetailShowView()
		{
		}

		// Token: 0x04030B17 RID: 199447
		[Token(Token = "0x4030B17")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x04030B18 RID: 199448
		[Token(Token = "0x4030B18")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _atk;

		// Token: 0x04030B19 RID: 199449
		[Token(Token = "0x4030B19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _def;

		// Token: 0x04030B1A RID: 199450
		[Token(Token = "0x4030B1A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _res;

		// Token: 0x04030B1B RID: 199451
		[Token(Token = "0x4030B1B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _reviveTime;

		// Token: 0x04030B1C RID: 199452
		[Token(Token = "0x4030B1C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _cost;

		// Token: 0x04030B1D RID: 199453
		[Token(Token = "0x4030B1D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x04030B1E RID: 199454
		[Token(Token = "0x4030B1E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _atkSpeed;

		// Token: 0x04030B1F RID: 199455
		[Token(Token = "0x4030B1F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030B20 RID: 199456
		[Token(Token = "0x4030B20")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x04030B21 RID: 199457
		[Token(Token = "0x4030B21")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _tokenAvatar;

		// Token: 0x04030B22 RID: 199458
		[Token(Token = "0x4030B22")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _tokenAvatarObj;

		// Token: 0x04030B23 RID: 199459
		[Token(Token = "0x4030B23")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _tokenPos;

		// Token: 0x04030B24 RID: 199460
		[Token(Token = "0x4030B24")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _skillPanel;

		// Token: 0x04030B25 RID: 199461
		[Token(Token = "0x4030B25")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _talentPanel;

		// Token: 0x04030B26 RID: 199462
		[Token(Token = "0x4030B26")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _subProfPanel;

		// Token: 0x04030B27 RID: 199463
		[Token(Token = "0x4030B27")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Skill")]
		private UISkillTagGroup _uiSkillTagGroup;

		// Token: 0x04030B28 RID: 199464
		[Token(Token = "0x4030B28")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Skill")]
		private Text _skillName;

		// Token: 0x04030B29 RID: 199465
		[Token(Token = "0x4030B29")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Skill")]
		private UICommentedText _skillDesc;

		// Token: 0x04030B2A RID: 199466
		[Token(Token = "0x4030B2A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Skill")]
		private Image _skillIcon;

		// Token: 0x04030B2B RID: 199467
		[Token(Token = "0x4030B2B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICommentedText _subProfDesc;

		// Token: 0x04030B2C RID: 199468
		[Token(Token = "0x4030B2C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private SimpleLayoutContent _talentListContent;

		// Token: 0x04030B2D RID: 199469
		[Token(Token = "0x4030B2D")]
		[FieldOffset(Offset = "0xC8")]
		private CharTokenViewModel m_tokenViewModel;

		// Token: 0x04030B2E RID: 199470
		[Token(Token = "0x4030B2E")]
		[FieldOffset(Offset = "0xD0")]
		private CharacterTokenDetailShowView.TalentListAdapter m_adapter;

		// Token: 0x04030B2F RID: 199471
		[Token(Token = "0x4030B2F")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x04030B30 RID: 199472
		[Token(Token = "0x4030B30")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030B31 RID: 199473
		[Token(Token = "0x4030B31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030B32 RID: 199474
		[Token(Token = "0x4030B32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030B33 RID: 199475
		[Token(Token = "0x4030B33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowAttribute;

		// Token: 0x04030B34 RID: 199476
		[Token(Token = "0x4030B34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowSubProf;

		// Token: 0x04030B35 RID: 199477
		[Token(Token = "0x4030B35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowTalent;

		// Token: 0x04030B36 RID: 199478
		[Token(Token = "0x4030B36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowSkill;

		// Token: 0x04030B37 RID: 199479
		[Token(Token = "0x4030B37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F3A RID: 24378
		[Token(Token = "0x2005F3A")]
		private class TalentListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700537B RID: 21371
			// (get) Token: 0x060234DD RID: 144605 RVA: 0x000C0840 File Offset: 0x000BEA40
			[Token(Token = "0x1700537B")]
			public override int count
			{
				[Token(Token = "0x60234DD")]
				[Address(RVA = "0x1DE5820", Offset = "0x1DE4420", VA = "0x181DE5820", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060234DE RID: 144606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60234DE")]
			[Address(RVA = "0x1DE5520", Offset = "0x1DE4120", VA = "0x181DE5520", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060234DF RID: 144607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60234DF")]
			[Address(RVA = "0x1DE57C0", Offset = "0x1DE43C0", VA = "0x181DE57C0")]
			public TalentListAdapter()
			{
			}

			// Token: 0x04030B38 RID: 199480
			[Token(Token = "0x4030B38")]
			[FieldOffset(Offset = "0x20")]
			public List<CharacterTokenTalentViewModel> viewModelList;

			// Token: 0x04030B39 RID: 199481
			[Token(Token = "0x4030B39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030B3A RID: 199482
			[Token(Token = "0x4030B3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030B3B RID: 199483
			[Token(Token = "0x4030B3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
