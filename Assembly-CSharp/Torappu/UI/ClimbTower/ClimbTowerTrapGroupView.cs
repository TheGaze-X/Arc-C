using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF1 RID: 23793
	[Token(Token = "0x2005CF1")]
	public class ClimbTowerTrapGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x06022729 RID: 141097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602272A RID: 141098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005103")]
		public UIPage page
		{
			[Token(Token = "0x6022729")]
			[Address(RVA = "0x1CDA890", Offset = "0x1CD9490", VA = "0x181CDA890")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602272A")]
			[Address(RVA = "0x1CDA8F0", Offset = "0x1CD94F0", VA = "0x181CDA8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602272B RID: 141099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602272B")]
		[Address(RVA = "0x1CDA480", Offset = "0x1CD9080", VA = "0x181CDA480")]
		public void Render(ClimbTowerTrapGroupViewModel trapGroupViewModel)
		{
		}

		// Token: 0x0602272C RID: 141100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602272C")]
		[Address(RVA = "0x1CDA710", Offset = "0x1CD9310", VA = "0x181CDA710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602272D RID: 141101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602272D")]
		[Address(RVA = "0x1CDA830", Offset = "0x1CD9430", VA = "0x181CDA830")]
		public ClimbTowerTrapGroupView()
		{
		}

		// Token: 0x0402F593 RID: 193939
		[Token(Token = "0x402F593")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x0402F594 RID: 193940
		[Token(Token = "0x402F594")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgGroupBkg;

		// Token: 0x0402F595 RID: 193941
		[Token(Token = "0x402F595")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402F596 RID: 193942
		[Token(Token = "0x402F596")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _godCardGroupBkgId;

		// Token: 0x0402F597 RID: 193943
		[Token(Token = "0x402F597")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _curseGroupBkgId;

		// Token: 0x0402F598 RID: 193944
		[Token(Token = "0x402F598")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _trapGroupBkgId;

		// Token: 0x0402F599 RID: 193945
		[Token(Token = "0x402F599")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerTrapGroupViewModel m_trapGroupViewModel;

		// Token: 0x0402F59A RID: 193946
		[Token(Token = "0x402F59A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402F59B RID: 193947
		[Token(Token = "0x402F59B")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerTrapGroupView.Adapter m_adapter;

		// Token: 0x0402F59D RID: 193949
		[Token(Token = "0x402F59D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F59E RID: 193950
		[Token(Token = "0x402F59E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F59F RID: 193951
		[Token(Token = "0x402F59F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F5A0 RID: 193952
		[Token(Token = "0x402F5A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F5A1 RID: 193953
		[Token(Token = "0x402F5A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CF2 RID: 23794
		[Token(Token = "0x2005CF2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602272E RID: 141102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602272E")]
			[Address(RVA = "0x1CCC390", Offset = "0x1CCAF90", VA = "0x181CCC390")]
			public Adapter(ClimbTowerTrapGroupView closure)
			{
			}

			// Token: 0x17005104 RID: 20740
			// (get) Token: 0x0602272F RID: 141103 RVA: 0x000BD768 File Offset: 0x000BB968
			[Token(Token = "0x17005104")]
			public override int count
			{
				[Token(Token = "0x602272F")]
				[Address(RVA = "0x1CCC640", Offset = "0x1CCB240", VA = "0x181CCC640", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022730 RID: 141104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022730")]
			[Address(RVA = "0x1CCBF30", Offset = "0x1CCAB30", VA = "0x181CCBF30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F5A2 RID: 193954
			[Token(Token = "0x402F5A2")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerTrapGroupView m_closure;

			// Token: 0x0402F5A3 RID: 193955
			[Token(Token = "0x402F5A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F5A4 RID: 193956
			[Token(Token = "0x402F5A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F5A5 RID: 193957
			[Token(Token = "0x402F5A5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
