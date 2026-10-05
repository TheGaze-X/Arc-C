using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004240 RID: 16960
	[Token(Token = "0x2004240")]
	public class SandboxV2DungeonBottomBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A247 RID: 107079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A247")]
		[Address(RVA = "0x12FF770", Offset = "0x12FE370", VA = "0x1812FF770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A248 RID: 107080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A248")]
		[Address(RVA = "0x12FF4B0", Offset = "0x12FE0B0", VA = "0x1812FF4B0")]
		public void Render(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A249 RID: 107081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A249")]
		[Address(RVA = "0x12FF420", Offset = "0x12FE020", VA = "0x1812FF420")]
		public void OnBtnOtherClicked()
		{
		}

		// Token: 0x0601A24A RID: 107082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A24A")]
		[Address(RVA = "0x12FF690", Offset = "0x12FE290", VA = "0x1812FF690")]
		public GameObject TutorialOnly_GetCookPanelBtnGo()
		{
			return null;
		}

		// Token: 0x0601A24B RID: 107083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A24B")]
		[Address(RVA = "0x12FF700", Offset = "0x12FE300", VA = "0x1812FF700")]
		public GameObject TutorialOnly_GetWorkbenchPanelBtnGo()
		{
			return null;
		}

		// Token: 0x0601A24C RID: 107084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A24C")]
		[Address(RVA = "0x12FF8A0", Offset = "0x12FE4A0", VA = "0x1812FF8A0")]
		public SandboxV2DungeonBottomBar()
		{
		}

		// Token: 0x0402103A RID: 135226
		[Token(Token = "0x402103A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlShop;

		// Token: 0x0402103B RID: 135227
		[Token(Token = "0x402103B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlLogistics;

		// Token: 0x0402103C RID: 135228
		[Token(Token = "0x402103C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _cookPnlBtn;

		// Token: 0x0402103D RID: 135229
		[Token(Token = "0x402103D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _workbenchPnlBtn;

		// Token: 0x0402103E RID: 135230
		[Token(Token = "0x402103E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2DungeonBottomBarFloatPanel _bottomBarFloatPanel;

		// Token: 0x0402103F RID: 135231
		[Token(Token = "0x402103F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIBlendRTImage _bkgBlur;

		// Token: 0x04021040 RID: 135232
		[Token(Token = "0x4021040")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgBkgColor;

		// Token: 0x04021041 RID: 135233
		[Token(Token = "0x4021041")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaBkgColor;

		// Token: 0x04021042 RID: 135234
		[Token(Token = "0x4021042")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021043 RID: 135235
		[Token(Token = "0x4021043")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04021044 RID: 135236
		[Token(Token = "0x4021044")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonViewModel m_cachedDungeonViewModel;

		// Token: 0x04021045 RID: 135237
		[Token(Token = "0x4021045")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021046 RID: 135238
		[Token(Token = "0x4021046")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021047 RID: 135239
		[Token(Token = "0x4021047")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnOtherClicked;

		// Token: 0x04021048 RID: 135240
		[Token(Token = "0x4021048")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetCookPanelBtnGo;

		// Token: 0x04021049 RID: 135241
		[Token(Token = "0x4021049")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetWorkbenchPanelBtnGo;

		// Token: 0x0402104A RID: 135242
		[Token(Token = "0x402104A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
