using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004243 RID: 16963
	[Token(Token = "0x2004243")]
	public class SandboxV2DungeonHomeTipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A255 RID: 107093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A255")]
		[Address(RVA = "0x12FFC70", Offset = "0x12FE870", VA = "0x1812FFC70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A256 RID: 107094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A256")]
		[Address(RVA = "0x12FFA20", Offset = "0x12FE620", VA = "0x1812FFA20")]
		public void Render(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A257 RID: 107095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A257")]
		[Address(RVA = "0x12FFD70", Offset = "0x12FE970", VA = "0x1812FFD70")]
		private void _Render(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A258 RID: 107096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A258")]
		[Address(RVA = "0x12FF910", Offset = "0x12FE510", VA = "0x1812FF910")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601A259 RID: 107097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A259")]
		[Address(RVA = "0x12FFBF0", Offset = "0x12FE7F0", VA = "0x1812FFBF0")]
		public GameObject TutorialOnly_GetBottomBarHomeBtnGo()
		{
			return null;
		}

		// Token: 0x0601A25A RID: 107098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A25A")]
		[Address(RVA = "0x13002D0", Offset = "0x12FEED0", VA = "0x1813002D0")]
		public SandboxV2DungeonHomeTipView()
		{
		}

		// Token: 0x04021063 RID: 135267
		[Token(Token = "0x4021063")]
		private const string TEXT_BASEMENT_LVL_FORMAT = "LV.{0}";

		// Token: 0x04021064 RID: 135268
		[Token(Token = "0x4021064")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ConstructTipType[] CONCERNED_TIPS;

		// Token: 0x04021065 RID: 135269
		[Token(Token = "0x4021065")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04021066 RID: 135270
		[Token(Token = "0x4021066")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgHomeTip;

		// Token: 0x04021067 RID: 135271
		[Token(Token = "0x4021067")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBasementLvl;

		// Token: 0x04021068 RID: 135272
		[Token(Token = "0x4021068")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlEnemyRush;

		// Token: 0x04021069 RID: 135273
		[Token(Token = "0x4021069")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402106A RID: 135274
		[Token(Token = "0x402106A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _hotspot;

		// Token: 0x0402106B RID: 135275
		[Token(Token = "0x402106B")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402106C RID: 135276
		[Token(Token = "0x402106C")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedCenterNodeId;

		// Token: 0x0402106D RID: 135277
		[Token(Token = "0x402106D")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_showTween;

		// Token: 0x0402106E RID: 135278
		[Token(Token = "0x402106E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0402106F RID: 135279
		[Token(Token = "0x402106F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021070 RID: 135280
		[Token(Token = "0x4021070")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021071 RID: 135281
		[Token(Token = "0x4021071")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04021072 RID: 135282
		[Token(Token = "0x4021072")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x04021073 RID: 135283
		[Token(Token = "0x4021073")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetBottomBarHomeBtnGo;

		// Token: 0x04021074 RID: 135284
		[Token(Token = "0x4021074")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
