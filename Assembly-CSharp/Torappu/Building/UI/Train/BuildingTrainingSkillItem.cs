using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C13 RID: 7187
	[Token(Token = "0x2001C13")]
	public class BuildingTrainingSkillItem : CharacterInfoSelectSkillView
	{
		// Token: 0x0600B336 RID: 45878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B336")]
		[Address(RVA = "0x32DE500", Offset = "0x32DD100", VA = "0x1832DE500", Slot = "4")]
		public override void Render(SkillItemViewModel viewModel, int index, bool isSelected)
		{
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B337")]
		[Address(RVA = "0x32DE820", Offset = "0x32DD420", VA = "0x1832DE820")]
		public void Update()
		{
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B338")]
		[Address(RVA = "0x32DE4F0", Offset = "0x32DD0F0", VA = "0x1832DE4F0")]
		public void BtnOnSpread()
		{
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B339")]
		[Address(RVA = "0x1A25360", Offset = "0x1A23F60", VA = "0x181A25360")]
		public void BtnOnUnSpread()
		{
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33A")]
		[Address(RVA = "0x32DE470", Offset = "0x32DD070", VA = "0x1832DE470")]
		public void BtnOnOtherSkillUpgrading()
		{
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33B")]
		[Address(RVA = "0x32DE840", Offset = "0x32DD440", VA = "0x1832DE840")]
		private void _RenderCountDownValues()
		{
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33C")]
		[Address(RVA = "0x32DEAF0", Offset = "0x32DD6F0", VA = "0x1832DEAF0")]
		public BuildingTrainingSkillItem()
		{
		}

		// Token: 0x0400AE6D RID: 44653
		[Token(Token = "0x400AE6D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lvlUpIngObj;

		// Token: 0x0400AE6E RID: 44654
		[Token(Token = "0x400AE6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _lvlUpBtn;

		// Token: 0x0400AE6F RID: 44655
		[Token(Token = "0x400AE6F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _onSpread;

		// Token: 0x0400AE70 RID: 44656
		[Token(Token = "0x400AE70")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _otherState;

		// Token: 0x0400AE71 RID: 44657
		[Token(Token = "0x400AE71")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _unableState;

		// Token: 0x0400AE72 RID: 44658
		[Token(Token = "0x400AE72")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _maxState;

		// Token: 0x0400AE73 RID: 44659
		[Token(Token = "0x400AE73")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _timeCircle;

		// Token: 0x0400AE74 RID: 44660
		[Token(Token = "0x400AE74")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0400AE75 RID: 44661
		[Token(Token = "0x400AE75")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _specialIcon;

		// Token: 0x0400AE76 RID: 44662
		[Token(Token = "0x400AE76")]
		[FieldOffset(Offset = "0x88")]
		private int m_targetLevel;

		// Token: 0x0400AE77 RID: 44663
		[Token(Token = "0x400AE77")]
		[FieldOffset(Offset = "0x90")]
		private SkillItemViewModel m_cacheViewModel;

		// Token: 0x0400AE78 RID: 44664
		[Token(Token = "0x400AE78")]
		[FieldOffset(Offset = "0x98")]
		private LevelUpSnapshot m_trainSnapshot;

		// Token: 0x0400AE79 RID: 44665
		[Token(Token = "0x400AE79")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;
	}
}
