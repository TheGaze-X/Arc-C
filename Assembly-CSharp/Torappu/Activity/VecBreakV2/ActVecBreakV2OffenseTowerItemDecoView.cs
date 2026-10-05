using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E56 RID: 28246
	[Token(Token = "0x2006E56")]
	public class ActVecBreakV2OffenseTowerItemDecoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028339 RID: 164665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028339")]
		[Address(RVA = "0x2380B00", Offset = "0x237F700", VA = "0x182380B00")]
		public void Render(VecBreakV2OffenseStageModel model, ActVecBreakV2OffenseTowerItemDecoView.Param param)
		{
		}

		// Token: 0x0602833A RID: 164666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833A")]
		[Address(RVA = "0x23810E0", Offset = "0x237FCE0", VA = "0x1823810E0")]
		private void _LoadSeasonRes(VecBreakV2OffenseStageModel model)
		{
		}

		// Token: 0x0602833B RID: 164667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833B")]
		[Address(RVA = "0x2380E50", Offset = "0x237FA50", VA = "0x182380E50")]
		private void _LoadBossIcon(VecBreakV2OffenseStageModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602833C RID: 164668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833C")]
		[Address(RVA = "0x2381280", Offset = "0x237FE80", VA = "0x182381280")]
		private void _PlayShowTween(ActVecBreakV2OffenseTowerItemDecoView.Param param)
		{
		}

		// Token: 0x0602833D RID: 164669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833D")]
		[Address(RVA = "0x23813F0", Offset = "0x237FFF0", VA = "0x1823813F0")]
		public ActVecBreakV2OffenseTowerItemDecoView()
		{
		}

		// Token: 0x040391C4 RID: 233924
		[Token(Token = "0x40391C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bossFigureImage;

		// Token: 0x040391C5 RID: 233925
		[Token(Token = "0x40391C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bossSignImage;

		// Token: 0x040391C6 RID: 233926
		[Token(Token = "0x40391C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _bossIconImage;

		// Token: 0x040391C7 RID: 233927
		[Token(Token = "0x40391C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _customBossIconImage;

		// Token: 0x040391C8 RID: 233928
		[Token(Token = "0x40391C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x040391C9 RID: 233929
		[Token(Token = "0x40391C9")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x040391CA RID: 233930
		[Token(Token = "0x40391CA")]
		[FieldOffset(Offset = "0x50")]
		private int m_level;

		// Token: 0x040391CB RID: 233931
		[Token(Token = "0x40391CB")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_showTween;

		// Token: 0x040391CC RID: 233932
		[Token(Token = "0x40391CC")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040391CD RID: 233933
		[Token(Token = "0x40391CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040391CE RID: 233934
		[Token(Token = "0x40391CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSeasonRes;

		// Token: 0x040391CF RID: 233935
		[Token(Token = "0x40391CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadBossIcon;

		// Token: 0x040391D0 RID: 233936
		[Token(Token = "0x40391D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayShowTween;

		// Token: 0x040391D1 RID: 233937
		[Token(Token = "0x40391D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E57 RID: 28247
		[Token(Token = "0x2006E57")]
		public struct Param
		{
			// Token: 0x040391D2 RID: 233938
			[Token(Token = "0x40391D2")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelected;

			// Token: 0x040391D3 RID: 233939
			[Token(Token = "0x40391D3")]
			[FieldOffset(Offset = "0x1")]
			public bool showDeco;

			// Token: 0x040391D4 RID: 233940
			[Token(Token = "0x40391D4")]
			[FieldOffset(Offset = "0x2")]
			public bool beforeCollapse;
		}
	}
}
