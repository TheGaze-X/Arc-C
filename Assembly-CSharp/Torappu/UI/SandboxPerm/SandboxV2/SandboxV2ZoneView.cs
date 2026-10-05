using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200429D RID: 17053
	[Token(Token = "0x200429D")]
	public class SandboxV2ZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A444 RID: 107588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A444")]
		[Address(RVA = "0x133EA20", Offset = "0x133D620", VA = "0x18133EA20")]
		public void Render(SandboxV2DungeonZoneViewModel zoneViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A445 RID: 107589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A445")]
		[Address(RVA = "0x133ED60", Offset = "0x133D960", VA = "0x18133ED60")]
		public SandboxV2ZoneView()
		{
		}

		// Token: 0x04021437 RID: 136247
		[Token(Token = "0x4021437")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imageZoneWeather;

		// Token: 0x04021438 RID: 136248
		[Token(Token = "0x4021438")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageZoneName;

		// Token: 0x04021439 RID: 136249
		[Token(Token = "0x4021439")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402143A RID: 136250
		[Token(Token = "0x402143A")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x0402143B RID: 136251
		[Token(Token = "0x402143B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402143C RID: 136252
		[Token(Token = "0x402143C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
