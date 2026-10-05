using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200606E RID: 24686
	[Token(Token = "0x200606E")]
	public class CarvingMainChallengeInfoRoundItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023B1F RID: 146207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B1F")]
		[Address(RVA = "0x1E57E70", Offset = "0x1E56A70", VA = "0x181E57E70")]
		public void Render(CarvingMainChallengeInfoRoundItemViewModel model)
		{
		}

		// Token: 0x06023B20 RID: 146208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B20")]
		[Address(RVA = "0x1E58110", Offset = "0x1E56D10", VA = "0x181E58110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023B21 RID: 146209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B21")]
		[Address(RVA = "0x1E58240", Offset = "0x1E56E40", VA = "0x181E58240")]
		public CarvingMainChallengeInfoRoundItemView()
		{
		}

		// Token: 0x0403177C RID: 202620
		[Token(Token = "0x403177C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _roundItemTitle;

		// Token: 0x0403177D RID: 202621
		[Token(Token = "0x403177D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x0403177E RID: 202622
		[Token(Token = "0x403177E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _materialScale;

		// Token: 0x0403177F RID: 202623
		[Token(Token = "0x403177F")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isInited;

		// Token: 0x04031780 RID: 202624
		[Token(Token = "0x4031780")]
		[FieldOffset(Offset = "0x30")]
		private CarvingMainChallengeInfoRoundItemView.MaterialItemAdapter m_adapter;

		// Token: 0x04031781 RID: 202625
		[Token(Token = "0x4031781")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031782 RID: 202626
		[Token(Token = "0x4031782")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031783 RID: 202627
		[Token(Token = "0x4031783")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200606F RID: 24687
		[Token(Token = "0x200606F")]
		private class MaterialItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06023B22 RID: 146210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023B22")]
			[Address(RVA = "0x1E6A0E0", Offset = "0x1E68CE0", VA = "0x181E6A0E0")]
			public MaterialItemAdapter(float materialScale)
			{
			}

			// Token: 0x1700544B RID: 21579
			// (get) Token: 0x06023B23 RID: 146211 RVA: 0x000C1B00 File Offset: 0x000BFD00
			[Token(Token = "0x1700544B")]
			public override int count
			{
				[Token(Token = "0x6023B23")]
				[Address(RVA = "0x1E6A150", Offset = "0x1E68D50", VA = "0x181E6A150", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023B24 RID: 146212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023B24")]
			[Address(RVA = "0x1E69F30", Offset = "0x1E68B30", VA = "0x181E69F30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031784 RID: 202628
			[Token(Token = "0x4031784")]
			[FieldOffset(Offset = "0x20")]
			public List<CarvingMaterialModel> dataSource;

			// Token: 0x04031785 RID: 202629
			[Token(Token = "0x4031785")]
			[FieldOffset(Offset = "0x28")]
			private float m_materialScale;

			// Token: 0x04031786 RID: 202630
			[Token(Token = "0x4031786")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031787 RID: 202631
			[Token(Token = "0x4031787")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031788 RID: 202632
			[Token(Token = "0x4031788")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
