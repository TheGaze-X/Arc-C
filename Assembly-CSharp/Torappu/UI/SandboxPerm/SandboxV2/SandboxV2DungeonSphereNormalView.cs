using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004217 RID: 16919
	[Token(Token = "0x2004217")]
	public class SandboxV2DungeonSphereNormalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A196 RID: 106902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A196")]
		[Address(RVA = "0x1302D00", Offset = "0x1301900", VA = "0x181302D00")]
		private void Update()
		{
		}

		// Token: 0x0601A197 RID: 106903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A197")]
		[Address(RVA = "0x13024F0", Offset = "0x13010F0", VA = "0x1813024F0")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A198 RID: 106904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A198")]
		[Address(RVA = "0x1302450", Offset = "0x1301050", VA = "0x181302450")]
		public void OnReserveClick()
		{
		}

		// Token: 0x0601A199 RID: 106905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A199")]
		[Address(RVA = "0x13023B0", Offset = "0x1300FB0", VA = "0x1813023B0")]
		public void OnLoadArchiveClick()
		{
		}

		// Token: 0x0601A19A RID: 106906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A19A")]
		[Address(RVA = "0x1302310", Offset = "0x1300F10", VA = "0x181302310")]
		public void OnDeleteArchiveClick()
		{
		}

		// Token: 0x0601A19B RID: 106907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A19B")]
		[Address(RVA = "0x1302B40", Offset = "0x1301740", VA = "0x181302B40")]
		public void TutorialOnly_TryRaiseAVGSignal()
		{
		}

		// Token: 0x0601A19C RID: 106908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A19C")]
		[Address(RVA = "0x1302D70", Offset = "0x1301970", VA = "0x181302D70")]
		public SandboxV2DungeonSphereNormalView()
		{
		}

		// Token: 0x04020EA4 RID: 134820
		[Token(Token = "0x4020EA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _topicName;

		// Token: 0x04020EA5 RID: 134821
		[Token(Token = "0x4020EA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _settleDayTip;

		// Token: 0x04020EA6 RID: 134822
		[Token(Token = "0x4020EA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x04020EA7 RID: 134823
		[Token(Token = "0x4020EA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _seasonRemainDay;

		// Token: 0x04020EA8 RID: 134824
		[Token(Token = "0x4020EA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _seasonRemainBkg;

		// Token: 0x04020EA9 RID: 134825
		[Token(Token = "0x4020EA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020EAA RID: 134826
		[Token(Token = "0x4020EAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _functionalDesc;

		// Token: 0x04020EAB RID: 134827
		[Token(Token = "0x4020EAB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04020EAC RID: 134828
		[Token(Token = "0x4020EAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelRiftReserve;

		// Token: 0x04020EAD RID: 134829
		[Token(Token = "0x4020EAD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelArchive;

		// Token: 0x04020EAE RID: 134830
		[Token(Token = "0x4020EAE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _coolDownText;

		// Token: 0x04020EAF RID: 134831
		[Token(Token = "0x4020EAF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _panelArchiveHotspot;

		// Token: 0x04020EB0 RID: 134832
		[Token(Token = "0x4020EB0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelLoadArchive;

		// Token: 0x04020EB1 RID: 134833
		[Token(Token = "0x4020EB1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelDeleteArchive;

		// Token: 0x04020EB2 RID: 134834
		[Token(Token = "0x4020EB2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04020EB3 RID: 134835
		[Token(Token = "0x4020EB3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelSeason;

		// Token: 0x04020EB4 RID: 134836
		[Token(Token = "0x4020EB4")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020EB5 RID: 134837
		[Token(Token = "0x4020EB5")]
		[FieldOffset(Offset = "0xA8")]
		private CountDownTask m_cacheCountDownTask;

		// Token: 0x04020EB6 RID: 134838
		[Token(Token = "0x4020EB6")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2DungeonViewModel m_cachedViewModel;

		// Token: 0x04020EB7 RID: 134839
		[Token(Token = "0x4020EB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04020EB8 RID: 134840
		[Token(Token = "0x4020EB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020EB9 RID: 134841
		[Token(Token = "0x4020EB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReserveClick;

		// Token: 0x04020EBA RID: 134842
		[Token(Token = "0x4020EBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLoadArchiveClick;

		// Token: 0x04020EBB RID: 134843
		[Token(Token = "0x4020EBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDeleteArchiveClick;

		// Token: 0x04020EBC RID: 134844
		[Token(Token = "0x4020EBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x04020EBD RID: 134845
		[Token(Token = "0x4020EBD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
