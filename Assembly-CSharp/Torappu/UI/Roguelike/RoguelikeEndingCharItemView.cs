using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052AB RID: 21163
	[Token(Token = "0x20052AB")]
	public class RoguelikeEndingCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F38C RID: 127884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F38C")]
		[Address(RVA = "0x18EA220", Offset = "0x18E8E20", VA = "0x1818EA220")]
		public void Render(string topicId, RoguelikeCharCardViewModel viewModel, RoguelikeEndingCharItemViewPlugin charItemViewPluginPrefab)
		{
		}

		// Token: 0x0601F38D RID: 127885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F38D")]
		[Address(RVA = "0x18EA6A0", Offset = "0x18E92A0", VA = "0x1818EA6A0")]
		public RoguelikeEndingCharItemView()
		{
		}

		// Token: 0x04029EBD RID: 171709
		[Token(Token = "0x4029EBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imagePortrait;

		// Token: 0x04029EBE RID: 171710
		[Token(Token = "0x4029EBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageEvolvePhase;

		// Token: 0x04029EBF RID: 171711
		[Token(Token = "0x4029EBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageUpgraded;

		// Token: 0x04029EC0 RID: 171712
		[Token(Token = "0x4029EC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageMask;

		// Token: 0x04029EC1 RID: 171713
		[Token(Token = "0x4029EC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("tag")]
		private UIAtlasImage _imgTagBkg;

		// Token: 0x04029EC2 RID: 171714
		[Token(Token = "0x4029EC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("tag")]
		private GameObject _objAssistTag;

		// Token: 0x04029EC3 RID: 171715
		[Token(Token = "0x4029EC3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("tag")]
		private GameObject _objMonthTag;

		// Token: 0x04029EC4 RID: 171716
		[Token(Token = "0x4029EC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("tag")]
		private GameObject _objFreeTag;

		// Token: 0x04029EC5 RID: 171717
		[Token(Token = "0x4029EC5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("tag")]
		private GameObject _objNpcTag;

		// Token: 0x04029EC6 RID: 171718
		[Token(Token = "0x4029EC6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("tag")]
		private Color _colorNpc;

		// Token: 0x04029EC7 RID: 171719
		[Token(Token = "0x4029EC7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("tag")]
		private Color _colorFree;

		// Token: 0x04029EC8 RID: 171720
		[Token(Token = "0x4029EC8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("tag")]
		private Color _colorAssist;

		// Token: 0x04029EC9 RID: 171721
		[Token(Token = "0x4029EC9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _pluginContainer;

		// Token: 0x04029ECA RID: 171722
		[Token(Token = "0x4029ECA")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeEndingCharItemViewPlugin m_plugin;

		// Token: 0x04029ECB RID: 171723
		[Token(Token = "0x4029ECB")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04029ECC RID: 171724
		[Token(Token = "0x4029ECC")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedTopicId;

		// Token: 0x04029ECD RID: 171725
		[Token(Token = "0x4029ECD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029ECE RID: 171726
		[Token(Token = "0x4029ECE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
