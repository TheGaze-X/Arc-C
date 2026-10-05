using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF6 RID: 28406
	[Token(Token = "0x2006EF6")]
	public class ActMultiV3CharCardView : ActMultiV3CharCardBase
	{
		// Token: 0x060285C2 RID: 165314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C2")]
		[Address(RVA = "0x23A8DE0", Offset = "0x23A79E0", VA = "0x1823A8DE0", Slot = "4")]
		protected override void OnRenderView()
		{
		}

		// Token: 0x060285C3 RID: 165315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C3")]
		[Address(RVA = "0x23A92E0", Offset = "0x23A7EE0", VA = "0x1823A92E0")]
		private void _RenderSkillAndEquipIfNeed(ActMultiV3CharCardBase.Param param)
		{
		}

		// Token: 0x060285C4 RID: 165316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C4")]
		[Address(RVA = "0x23A9390", Offset = "0x23A7F90", VA = "0x1823A9390")]
		private void _RenderSkillInfo(ActMultiV3CharCardBase.Param.SkillInfo skillInfo)
		{
		}

		// Token: 0x060285C5 RID: 165317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C5")]
		[Address(RVA = "0x23A90A0", Offset = "0x23A7CA0", VA = "0x1823A90A0")]
		private void _RenderEquipInfo(ActMultiV3CharCardBase.Param.EquipInfo equipInfo)
		{
		}

		// Token: 0x060285C6 RID: 165318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C6")]
		[Address(RVA = "0x23A9540", Offset = "0x23A8140", VA = "0x1823A9540")]
		public ActMultiV3CharCardView()
		{
		}

		// Token: 0x060285C7 RID: 165319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C7")]
		[Address(RVA = "0x23A8790", Offset = "0x23A7390", VA = "0x1823A8790")]
		private void <>xLuaBaseProxy_OnRenderView()
		{
		}

		// Token: 0x040395FB RID: 235003
		[Token(Token = "0x40395FB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040395FC RID: 235004
		[Token(Token = "0x40395FC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x040395FD RID: 235005
		[Token(Token = "0x40395FD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _iconPriGO;

		// Token: 0x040395FE RID: 235006
		[Token(Token = "0x40395FE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _iconPriHighGO;

		// Token: 0x040395FF RID: 235007
		[Token(Token = "0x40395FF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _iconPriLowGO;

		// Token: 0x04039600 RID: 235008
		[Token(Token = "0x4039600")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _skillEquipPanelGO;

		// Token: 0x04039601 RID: 235009
		[Token(Token = "0x4039601")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Skill")]
		private GameObject _emptySkillPanelGO;

		// Token: 0x04039602 RID: 235010
		[Token(Token = "0x4039602")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Skill")]
		private GameObject _normalSkillPanelGO;

		// Token: 0x04039603 RID: 235011
		[Token(Token = "0x4039603")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Skill")]
		private Image _imgSkillIcon;

		// Token: 0x04039604 RID: 235012
		[Token(Token = "0x4039604")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Skill")]
		private Image _imgSkillSpecLv;

		// Token: 0x04039605 RID: 235013
		[Token(Token = "0x4039605")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Skill")]
		private Text _textSkillLv;

		// Token: 0x04039606 RID: 235014
		[Token(Token = "0x4039606")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Equip")]
		private GameObject _emptyEquipPanelGO;

		// Token: 0x04039607 RID: 235015
		[Token(Token = "0x4039607")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Equip")]
		private GameObject _normalEquipPanelGO;

		// Token: 0x04039608 RID: 235016
		[Token(Token = "0x4039608")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Equip")]
		private Image _imgEquipIcon;

		// Token: 0x04039609 RID: 235017
		[Token(Token = "0x4039609")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Equip")]
		private GameObject _equipLvGO;

		// Token: 0x0403960A RID: 235018
		[Token(Token = "0x403960A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Equip")]
		private Text _textEquipLv;

		// Token: 0x0403960B RID: 235019
		[Token(Token = "0x403960B")]
		[FieldOffset(Offset = "0x100")]
		private string m_cacheSkillId;

		// Token: 0x0403960C RID: 235020
		[Token(Token = "0x403960C")]
		[FieldOffset(Offset = "0x108")]
		private string m_cacheEquipId;

		// Token: 0x0403960D RID: 235021
		[Token(Token = "0x403960D")]
		[FieldOffset(Offset = "0x110")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403960E RID: 235022
		[Token(Token = "0x403960E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderView;

		// Token: 0x0403960F RID: 235023
		[Token(Token = "0x403960F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSkillAndEquipIfNeed;

		// Token: 0x04039610 RID: 235024
		[Token(Token = "0x4039610")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSkillInfo;

		// Token: 0x04039611 RID: 235025
		[Token(Token = "0x4039611")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEquipInfo;

		// Token: 0x04039612 RID: 235026
		[Token(Token = "0x4039612")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
