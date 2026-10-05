using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200652A RID: 25898
	[Token(Token = "0x200652A")]
	public class ArtMagazineCoverDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602538D RID: 152461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602538D")]
		[Address(RVA = "0x20268A0", Offset = "0x20254A0", VA = "0x1820268A0")]
		public void Render(ArtMagazineCoverDetailLeafItemViewModel viewModel)
		{
		}

		// Token: 0x0602538E RID: 152462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602538E")]
		[Address(RVA = "0x2026970", Offset = "0x2025570", VA = "0x182026970")]
		public ArtMagazineCoverDetailItemView()
		{
		}

		// Token: 0x0403435F RID: 213855
		[Token(Token = "0x403435F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x04034360 RID: 213856
		[Token(Token = "0x4034360")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034361 RID: 213857
		[Token(Token = "0x4034361")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200652B RID: 25899
		[Token(Token = "0x200652B")]
		public class Param : IHotfixable
		{
			// Token: 0x0602538F RID: 152463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602538F")]
			[Address(RVA = "0x2040EF0", Offset = "0x203FAF0", VA = "0x182040EF0")]
			public Param()
			{
			}

			// Token: 0x04034362 RID: 213858
			[Token(Token = "0x4034362")]
			[FieldOffset(Offset = "0x10")]
			public ArtMagazineCoverDetailLeafItemViewModel model;

			// Token: 0x04034363 RID: 213859
			[Token(Token = "0x4034363")]
			[FieldOffset(Offset = "0x18")]
			public ArtMagazineCoverDetailItemView viewPrefab;

			// Token: 0x04034364 RID: 213860
			[Token(Token = "0x4034364")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200652C RID: 25900
		[Token(Token = "0x200652C")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ArtMagazineCoverDetailItemView>
		{
			// Token: 0x06025390 RID: 152464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025390")]
			[Address(RVA = "0x2041590", Offset = "0x2040190", VA = "0x182041590")]
			public VirtualView(ArtMagazineCoverDetailItemView.Param param)
			{
			}

			// Token: 0x06025391 RID: 152465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025391")]
			[Address(RVA = "0x2041250", Offset = "0x203FE50", VA = "0x182041250", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06025392 RID: 152466 RVA: 0x000C70F8 File Offset: 0x000C52F8
			[Token(Token = "0x6025392")]
			[Address(RVA = "0x20412C0", Offset = "0x203FEC0", VA = "0x1820412C0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06025393 RID: 152467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025393")]
			[Address(RVA = "0x20413E0", Offset = "0x203FFE0", VA = "0x1820413E0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06025394 RID: 152468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025394")]
			[Address(RVA = "0x2041530", Offset = "0x2040130", VA = "0x182041530", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x04034365 RID: 213861
			[Token(Token = "0x4034365")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineCoverDetailItemView.Param m_param;

			// Token: 0x04034366 RID: 213862
			[Token(Token = "0x4034366")]
			[FieldOffset(Offset = "0x28")]
			private float m_preferSize;

			// Token: 0x04034367 RID: 213863
			[Token(Token = "0x4034367")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034368 RID: 213864
			[Token(Token = "0x4034368")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04034369 RID: 213865
			[Token(Token = "0x4034369")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403436A RID: 213866
			[Token(Token = "0x403436A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403436B RID: 213867
			[Token(Token = "0x403436B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}
	}
}
