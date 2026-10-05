using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001968 RID: 6504
	[Token(Token = "0x2001968")]
	public class DIYThemeItemViewAdapter : LoopScrollAdapter<DIYThemeItemViewAdapter.ViewHolder, DIYThemeItemViewData>
	{
		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600A367 RID: 41831 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A368 RID: 41832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004A")]
		public event Action<DIYThemeItemViewData> furnitureSelected
		{
			[Token(Token = "0x600A367")]
			[Address(RVA = "0x31E6380", Offset = "0x31E4F80", VA = "0x1831E6380")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A368")]
			[Address(RVA = "0x31E6480", Offset = "0x31E5080", VA = "0x1831E6480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A369")]
		[Address(RVA = "0x31E6270", Offset = "0x31E4E70", VA = "0x1831E6270")]
		private void _OnButtonPressed(DIYThemeItemViewData data, ThemeFurnitureItemView view)
		{
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A36A")]
		[Address(RVA = "0x31E6020", Offset = "0x31E4C20", VA = "0x1831E6020", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A36B")]
		[Address(RVA = "0x31E60D0", Offset = "0x31E4CD0", VA = "0x1831E60D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DIYThemeItemViewAdapter.ViewHolder holder, DIYThemeItemViewData data)
		{
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A36C")]
		[Address(RVA = "0x31E6310", Offset = "0x31E4F10", VA = "0x1831E6310")]
		public DIYThemeItemViewAdapter()
		{
		}

		// Token: 0x040099D8 RID: 39384
		[Token(Token = "0x40099D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _furnitureViewPrefab;

		// Token: 0x040099DA RID: 39386
		[Token(Token = "0x40099DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_furnitureSelected;

		// Token: 0x040099DB RID: 39387
		[Token(Token = "0x40099DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_furnitureSelected;

		// Token: 0x040099DC RID: 39388
		[Token(Token = "0x40099DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x040099DD RID: 39389
		[Token(Token = "0x40099DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040099DE RID: 39390
		[Token(Token = "0x40099DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040099DF RID: 39391
		[Token(Token = "0x40099DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001969 RID: 6505
		[Token(Token = "0x2001969")]
		public struct ViewHolder
		{
			// Token: 0x040099E0 RID: 39392
			[Token(Token = "0x40099E0")]
			[FieldOffset(Offset = "0x0")]
			public GameObject panel;
		}
	}
}
