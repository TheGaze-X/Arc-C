using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Train;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB7 RID: 24503
	[Token(Token = "0x2005FB7")]
	public class CharacterSelectSpecializedSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602370F RID: 145167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370F")]
		[Address(RVA = "0x1E23780", Offset = "0x1E22380", VA = "0x181E23780")]
		public void Render(SkillItemViewModel viewModel, int index, bool isSelected, bool hasSpecialFlag)
		{
		}

		// Token: 0x06023710 RID: 145168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023710")]
		[Address(RVA = "0x1E23AC0", Offset = "0x1E226C0", VA = "0x181E23AC0")]
		public void Update()
		{
		}

		// Token: 0x06023711 RID: 145169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023711")]
		[Address(RVA = "0x1E236D0", Offset = "0x1E222D0", VA = "0x181E236D0")]
		public void BtnOnOtherSkillUpgrading()
		{
		}

		// Token: 0x06023712 RID: 145170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023712")]
		[Address(RVA = "0x1E23B90", Offset = "0x1E22790", VA = "0x181E23B90")]
		public CharacterSelectSpecializedSkillView()
		{
		}

		// Token: 0x04030FFF RID: 200703
		[Token(Token = "0x4030FFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lvlUpIngObj;

		// Token: 0x04031000 RID: 200704
		[Token(Token = "0x4031000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _skillStateObj;

		// Token: 0x04031001 RID: 200705
		[Token(Token = "0x4031001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _timeCircle;

		// Token: 0x04031002 RID: 200706
		[Token(Token = "0x4031002")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _specialIcon;

		// Token: 0x04031003 RID: 200707
		[Token(Token = "0x4031003")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _startLevel;

		// Token: 0x04031004 RID: 200708
		[Token(Token = "0x4031004")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _targetLevel;

		// Token: 0x04031005 RID: 200709
		[Token(Token = "0x4031005")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x04031006 RID: 200710
		[Token(Token = "0x4031006")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _hasSpecializedPart;

		// Token: 0x04031007 RID: 200711
		[Token(Token = "0x4031007")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _noSpecializedPart;

		// Token: 0x04031008 RID: 200712
		[Token(Token = "0x4031008")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected CharacterInfoSkillView _skillView;

		// Token: 0x04031009 RID: 200713
		[Token(Token = "0x4031009")]
		[FieldOffset(Offset = "0x68")]
		private float m_specialTime;

		// Token: 0x0403100A RID: 200714
		[Token(Token = "0x403100A")]
		[FieldOffset(Offset = "0x6C")]
		private int m_targetLevel;

		// Token: 0x0403100B RID: 200715
		[Token(Token = "0x403100B")]
		[FieldOffset(Offset = "0x70")]
		private SkillItemViewModel m_cacheViewModel;

		// Token: 0x0403100C RID: 200716
		[Token(Token = "0x403100C")]
		[FieldOffset(Offset = "0x78")]
		private LevelUpSnapshot m_trainSnapshot;

		// Token: 0x0403100D RID: 200717
		[Token(Token = "0x403100D")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403100E RID: 200718
		[Token(Token = "0x403100E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403100F RID: 200719
		[Token(Token = "0x403100F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04031010 RID: 200720
		[Token(Token = "0x4031010")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BtnOnOtherSkillUpgrading;

		// Token: 0x04031011 RID: 200721
		[Token(Token = "0x4031011")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
