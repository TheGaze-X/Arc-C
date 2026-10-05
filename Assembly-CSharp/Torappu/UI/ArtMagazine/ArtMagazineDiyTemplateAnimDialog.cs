using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A8 RID: 26024
	[Token(Token = "0x20065A8")]
	public class ArtMagazineDiyTemplateAnimDialog : UICompDialog<ArtMagazineDiyTemplateViewModel>
	{
		// Token: 0x0602568B RID: 153227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568B")]
		[Address(RVA = "0x2064360", Offset = "0x2062F60", VA = "0x182064360", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602568C RID: 153228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568C")]
		[Address(RVA = "0x2064400", Offset = "0x2063000", VA = "0x182064400", Slot = "18")]
		protected override void OnRender(ArtMagazineDiyTemplateViewModel input)
		{
		}

		// Token: 0x0602568D RID: 153229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568D")]
		[Address(RVA = "0x2064290", Offset = "0x2062E90", VA = "0x182064290")]
		public void EventCloseToHomeState()
		{
		}

		// Token: 0x0602568E RID: 153230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568E")]
		[Address(RVA = "0x20646B0", Offset = "0x20632B0", VA = "0x1820646B0")]
		public ArtMagazineDiyTemplateAnimDialog()
		{
		}

		// Token: 0x0602568F RID: 153231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568F")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040347E7 RID: 215015
		[Token(Token = "0x40347E7")]
		private const string TYPE_NAME_FORMAT = ".{0}";

		// Token: 0x040347E8 RID: 215016
		[Token(Token = "0x40347E8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("First Set Anim")]
		private ArtMagazineLeafViewHolder _completeAnimLeafHolder;

		// Token: 0x040347E9 RID: 215017
		[Token(Token = "0x40347E9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("First Set Anim")]
		private Image[] _templateColorImage;

		// Token: 0x040347EA RID: 215018
		[Token(Token = "0x40347EA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("First Set Anim")]
		private Image _leafTypeIcon;

		// Token: 0x040347EB RID: 215019
		[Token(Token = "0x40347EB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("First Set Anim")]
		private Text _leafTypeEngName;

		// Token: 0x040347EC RID: 215020
		[Token(Token = "0x40347EC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("First Set Anim")]
		private UIAnimationLocation _firstSetAnim;

		// Token: 0x040347ED RID: 215021
		[Token(Token = "0x40347ED")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040347EE RID: 215022
		[Token(Token = "0x40347EE")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_firstSetAnimTween;

		// Token: 0x040347EF RID: 215023
		[Token(Token = "0x40347EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040347F0 RID: 215024
		[Token(Token = "0x40347F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347F1 RID: 215025
		[Token(Token = "0x40347F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventCloseToHomeState;

		// Token: 0x040347F2 RID: 215026
		[Token(Token = "0x40347F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
