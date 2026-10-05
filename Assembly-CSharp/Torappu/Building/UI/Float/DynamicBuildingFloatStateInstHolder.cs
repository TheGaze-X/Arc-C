using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DEF RID: 7663
	[Token(Token = "0x2001DEF")]
	public class DynamicBuildingFloatStateInstHolder : DynamicPrefabInstHolder
	{
		// Token: 0x0600BD4A RID: 48458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BD4A")]
		[Address(RVA = "0x33B0AB0", Offset = "0x33AF6B0", VA = "0x1833B0AB0", Slot = "4")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0600BD4B RID: 48459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4B")]
		[Address(RVA = "0x33B0C10", Offset = "0x33AF810", VA = "0x1833B0C10")]
		public DynamicBuildingFloatStateInstHolder()
		{
		}

		// Token: 0x0400BD84 RID: 48516
		[Token(Token = "0x400BD84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _prefabName;

		// Token: 0x0400BD85 RID: 48517
		[Token(Token = "0x400BD85")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400BD86 RID: 48518
		[Token(Token = "0x400BD86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0400BD87 RID: 48519
		[Token(Token = "0x400BD87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
