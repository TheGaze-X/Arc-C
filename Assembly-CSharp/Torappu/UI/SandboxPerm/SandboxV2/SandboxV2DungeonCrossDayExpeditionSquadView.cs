using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004190 RID: 16784
	[Token(Token = "0x2004190")]
	public class SandboxV2DungeonCrossDayExpeditionSquadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019E39 RID: 106041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E39")]
		[Address(RVA = "0x12C2310", Offset = "0x12C0F10", VA = "0x1812C2310")]
		public void Render(List<Sprite> charSprites)
		{
		}

		// Token: 0x06019E3A RID: 106042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E3A")]
		[Address(RVA = "0x12C2500", Offset = "0x12C1100", VA = "0x1812C2500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019E3B RID: 106043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E3B")]
		[Address(RVA = "0x12C2660", Offset = "0x12C1260", VA = "0x1812C2660")]
		public SandboxV2DungeonCrossDayExpeditionSquadView()
		{
		}

		// Token: 0x040208F1 RID: 133361
		[Token(Token = "0x40208F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _squadListContent;

		// Token: 0x040208F2 RID: 133362
		[Token(Token = "0x40208F2")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040208F3 RID: 133363
		[Token(Token = "0x40208F3")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2DungeonCrossDayExpeditionSquadView.CharItemListAdapter m_adapter;

		// Token: 0x040208F4 RID: 133364
		[Token(Token = "0x40208F4")]
		[FieldOffset(Offset = "0x30")]
		private List<Sprite> m_charSprites;

		// Token: 0x040208F5 RID: 133365
		[Token(Token = "0x40208F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040208F6 RID: 133366
		[Token(Token = "0x40208F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040208F7 RID: 133367
		[Token(Token = "0x40208F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004191 RID: 16785
		[Token(Token = "0x2004191")]
		private class CharItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019E3C RID: 106044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019E3C")]
			[Address(RVA = "0x12B72E0", Offset = "0x12B5EE0", VA = "0x1812B72E0")]
			public CharItemListAdapter(SandboxV2DungeonCrossDayExpeditionSquadView closure)
			{
			}

			// Token: 0x17003DA5 RID: 15781
			// (get) Token: 0x06019E3D RID: 106045 RVA: 0x0009FA38 File Offset: 0x0009DC38
			[Token(Token = "0x17003DA5")]
			public override int count
			{
				[Token(Token = "0x6019E3D")]
				[Address(RVA = "0x12B7360", Offset = "0x12B5F60", VA = "0x1812B7360", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019E3E RID: 106046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019E3E")]
			[Address(RVA = "0x12B70E0", Offset = "0x12B5CE0", VA = "0x1812B70E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040208F8 RID: 133368
			[Token(Token = "0x40208F8")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonCrossDayExpeditionSquadView m_closure;

			// Token: 0x040208F9 RID: 133369
			[Token(Token = "0x40208F9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040208FA RID: 133370
			[Token(Token = "0x40208FA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040208FB RID: 133371
			[Token(Token = "0x40208FB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
